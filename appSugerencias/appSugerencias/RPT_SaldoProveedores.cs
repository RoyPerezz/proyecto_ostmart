using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;

namespace appSugerencias
{


    public partial class RPT_SaldoProveedores : Form
    {

    

        List<Proveedor> prov = new List<Proveedor>();
        DataTable dtbo = new DataTable();
        DataTable dtva = new DataTable();
        DataTable dtre = new DataTable();
        DataTable dtco = new DataTable();
        DataTable dtve = new DataTable();
        DataTable dtpre = new DataTable();
        DataTable maestro = new DataTable();
        public string area = "";



        public RPT_SaldoProveedores()
        {
            InitializeComponent();
        }

        public string suc;

        public string getSucursal()
        {
            return suc;
        }

      
        double total = 0;
        public void Proveedores()
        {
            try
            {
                MySqlConnection con = BDConexicon.BodegaOpen();
                string consulta = "SELECT PROVEEDOR,NOMBRE FROM PROVEED ORDER BY PROVEEDOR";
                MySqlCommand cmd = new MySqlCommand(consulta, con);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    prov.Add(new Proveedor { proveedor = dr["PROVEEDOR"].ToString(), nombre = dr["NOMBRE"].ToString() });
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("SIN CONEXIÓN CON EL SERVIDOR DE BODEGA "+ex);
            }

           

            for (int i = 0; i < prov.Count; i++)
            {
                maestro.Rows.Add(prov[i].proveedor, prov[i].nombre, 0, 0, 0, 0, 0, 0);
            }

            //DG_reporte.DataSource = maestro;

            
        }

        
        

        


        public void ReporteExcel()
        {
            //Crea reporte en pdf sobre los saldos de los proveedores

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);

            excel.Cells.Range["C6:C1000"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["D6:D1000"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["E6:E1000"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["F6:F1000"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["G6:G1000"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["H6:H1000"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["I6:I1000"].NumberFormat = "$#,##0.00";

            int indiceColumna = 0;

            foreach (DataGridViewColumn col in DG_reporte.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in DG_reporte.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in DG_reporte.Columns)
                {
                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                }



            }




            excel.Visible = true;

        }



        public void ReportePDF()
        {
            DateTime fecha = DT_fecha.Value;
            try { 
         
            Document doc = new Document(PageSize.A4.Rotate());
            string filename = "ResumenSaldo\\ResumenSaldo"+fecha.ToString("dd-MM-yyyy")+"_"+suc+".pdf";
             
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@filename, FileMode.Create));
            
                writer.PageEvent = new HeaderFooter();

            doc.AddTitle("Reporte de saldos de proveedor");
            doc.AddCreator("RoyP3r3z");

              
                // Abrimos el archivo
                doc.Open();

            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);



                Paragraph paragraph = new Paragraph("");
                doc.Add(paragraph);

                //Este codigo agrega una imagen al pdf
                string imageURL = "imagenes/logo.png";
                iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(imageURL);

                ////Resize image depend upon your need
                jpg.ScaleToFit(140f, 120f);

                ////Give space before image
                jpg.SpacingBefore = 10f;

                ////Give some space after the image
                jpg.SpacingAfter = 10f;
                jpg.Alignment = Element.ALIGN_CENTER;
                doc.Add(jpg);
                ////fin del codigo de la imagen
              

                Paragraph parrafoEnc = new Paragraph();
                parrafoEnc.Add("");
                doc.Add(parrafoEnc);
                parrafoEnc.Clear();

                doc.Add(Chunk.NEWLINE);
            


                //Creamos nuestra tabla 
                PdfPTable table = new PdfPTable(DG_reporte.Columns.Count);
               
           
            table.WidthPercentage = 100;
            float[] widths = new float[] { 40f, 90f, 55f, 55f,55f,55f,55f,55f,55f };
            table.SetWidths(widths);
            table.SkipLastFooter = true;
            table.SpacingAfter = 50;

            //Encabezados
            for (int j = 0; j < DG_reporte.Columns.Count; j++)
            {
                table.AddCell(new Phrase(DG_reporte.Columns[j].HeaderText));
                   
            }

            //flag the first row as a header
            table.HeaderRows = 1;

                double valor = 0;
            for (int i = 0; i < DG_reporte.Rows.Count; i++)
            {
                for (int k = 0; k < DG_reporte.Columns.Count; k++)
                {
                       

                    if (DG_reporte[k, i].Value != null)
                    {
                       
                            if (k>1)
                            {
                                //string.Format("{0:C3}", 112.236677
                                //table.AddCell(new Phrase(DG_reporte[k, i].Value.ToString()));
                                valor = Convert.ToDouble(DG_reporte[k, i].Value);
                                table.AddCell(new Phrase(string.Format("{0:C2}", valor)));
                            }
                            else
                            {
                                table.AddCell(new Phrase(DG_reporte[k, i].Value.ToString()));
                            }
                    }
                }
            }
                
                doc.Add(table);


            doc.Close();
            writer.Close();

            Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = filename;
            prc.Start();
            }catch(Exception ex)
            {
                MessageBox.Show("Error al crear PDF" + ex);
            }

        }


        public void OrdenarDT()
        {
            try
            {
                DataView vista = maestro.DefaultView;
                vista.Sort = "PROVEEDOR";
                maestro = vista.ToTable();

                DataView vista2 = dtbo.DefaultView;
                vista2.Sort = "PROVEEDOR";
                dtbo = vista2.ToTable();

                DataView vista3 = dtva.DefaultView;
                vista3.Sort = "PROVEEDOR";
                dtva = vista3.ToTable();

                DataView vista4 = dtre.DefaultView;
                vista4.Sort = "PROVEEDOR";
                dtre = vista4.ToTable();

                DataView vista5 = dtco.DefaultView;
                vista5.Sort = "PROVEEDOR";
                dtco = vista5.ToTable();

                DataView vista6 = dtve.DefaultView;
                vista6.Sort = "PROVEEDOR";
                dtve = vista6.ToTable();

                DataView vista7 = dtpre.DefaultView;
                vista7.Sort = "PROVEEDOR";
                dtpre = vista7.ToTable();
            }
            catch (Exception ex)
            {

               
            }
        }


        public void Saldos()
        {



            maestro.Clear();
            dtbo.Clear();
            dtva.Clear();
            dtre.Clear();
            dtco.Clear();
            dtve.Clear();
            dtpre.Clear();
            prov.Clear();
            LB_bo.ForeColor = Color.Black;
            LB_va.ForeColor = Color.Black;
            LB_rena.ForeColor = Color.Black;
            LB_coloso.ForeColor = Color.Black;
            LB_pregot.ForeColor = Color.Black;

            if (CHK_fecha.Checked == true)
            {

                DateTime fecha = DT_date.Value;
                int mes = DT_date.Value.Month;
                int año = DT_date.Value.Year;



                string mesRespaldo = MesdeRespaldo(mes);

                string consulta = "SELECT cuenxpag.proveedor,proveed.nombre,SUM( cuenxpag.saldo * cuenxpag.tip_cam ) AS SALDO FROM cuenxpag INNER JOIN proveed USING(proveedor)" +
               " WHERE cuenxpag.saldo > 0 and cuenxpag.fecha between '2008-01-01' and '" + fecha.ToString("yyyy-MM-dd") + "' GROUP BY cuenxpag.proveedor ORDER BY cuenxpag.proveedor, cuenxpag.moneda,cuenxpag.tipo_doc,cuenxpag.no_referen ";
                MySqlConnection con = BDConexicon.RespaldoVA(mesRespaldo, año);//ERA EL METODO DE BODEGA ANTES RespaldoVA(mesRespaldo,año)
                try
                {

                    //OBTENGO LOS PROVEEDORES QUE EXISTEN EN LA BASE DE DATOS DE BODEGA
                    MySqlCommand cmd = new MySqlCommand("SELECT PROVEEDOR,NOMBRE from proveed", con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        prov.Add(new Proveedor { proveedor = dr["PROVEEDOR"].ToString(), nombre = dr["NOMBRE"].ToString() });

                    }
                    dr.Close();
                }
                catch (Exception ex)
                {

                    //MessageBox.Show("NO HAY CONEXION CON EL SERVIDOR DE BODEGA");
                }

                //LLENO MI DATATABLE maestro
                for (int i = 0; i < prov.Count; i++)
                {
                    maestro.Rows.Add(prov[i].proveedor, prov[i].nombre, 0, 0, 0, 0, 0, 0);
                }

                try
                {
                    //LLENO MI DATATABLE dtbo
                    MySqlConnection conexbo = BDConexicon.BodegaOpen();
                    MySqlCommand bo = new MySqlCommand(consulta, conexbo);
                    MySqlDataAdapter ad = new MySqlDataAdapter(bo);
                    ad.Fill(dtbo);
                    LB_bo.ForeColor = Color.DarkGreen;
                    conexbo.Close();
                }
                catch (Exception ex)
                {
                    LB_bo.ForeColor = Color.Red;

                }

                try
                {
                    //LLENO MI DATATABLE dtva
                    MySqlConnection conva = BDConexicon.RespaldoVA(mesRespaldo, año);
                    MySqlCommand va = new MySqlCommand(consulta, conva);
                    MySqlDataAdapter adva = new MySqlDataAdapter(va);
                    adva.Fill(dtva);
                    LB_va.ForeColor = Color.DarkGreen;

                }
                catch (Exception ex)
                {
                    LB_va.ForeColor = Color.Red;
                }

                try
                {
                    MySqlConnection conre = BDConexicon.RespaldoRE(mesRespaldo, año);
                    MySqlCommand re = new MySqlCommand(consulta, conre);
                    MySqlDataAdapter adre = new MySqlDataAdapter(re);
                    adre.Fill(dtre);
                    LB_rena.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {
                    LB_rena.ForeColor = Color.Red;

                }


                try
                {
                    MySqlConnection conco = BDConexicon.RespaldoCO(mesRespaldo, año);
                    MySqlCommand co = new MySqlCommand(consulta, conco);
                    MySqlDataAdapter adco = new MySqlDataAdapter(co);
                    adco.Fill(dtco);
                    LB_coloso.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {

                    LB_coloso.ForeColor = Color.Red;
                }

                try
                {
                    MySqlConnection conve = BDConexicon.RespaldoVE(mesRespaldo, año);
                    MySqlCommand ve = new MySqlCommand(consulta, conve);
                    MySqlDataAdapter adve = new MySqlDataAdapter(ve);
                    adve.Fill(dtve);
                    LB_velazquez.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {

                    LB_velazquez.ForeColor = Color.Red;
                }

                try
                {
                    MySqlConnection conpre = BDConexicon.RespaldoPRE(mesRespaldo, año);
                    MySqlCommand pre = new MySqlCommand(consulta, conpre);
                    MySqlDataAdapter adpre = new MySqlDataAdapter(pre);
                    adpre.Fill(dtpre);
                    LB_pregot.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {
                    LB_pregot.ForeColor = Color.Red;
                }

                double saldoBO = 0, saldoVA = 0, saldoRE = 0, saldoCO = 0, saldoVE = 0, saldoPRE = 0, suma = 0;
                double sbo = 0, sva = 0, sre = 0, sco = 0, sve = 0, spre = 0, sum = 0;
                OrdenarDT();

                foreach (DataRow maestroRow in maestro.Rows)
                {
                    foreach (DataRow boRow in dtbo.Rows)
                    {
                        if (maestroRow["PROVEEDOR"].ToString().Equals(boRow["PROVEEDOR"].ToString()))
                        {
                            sbo = Convert.ToDouble(boRow["SALDO"].ToString());
                            if (sbo != 0)
                            {
                                saldoBO = Math.Round(sbo, 2);
                                maestroRow["BODEGA"] = Convert.ToDouble(boRow["SALDO"].ToString());
                            }
                        }

                    }

                    foreach (DataRow vaRow in dtva.Rows)
                    {
                        if (maestroRow["PROVEEDOR"].ToString().Equals(vaRow["PROVEEDOR"].ToString()))
                        {
                            sva = Convert.ToDouble(vaRow["SALDO"].ToString());
                            if (sva != 0)
                            {
                                saldoVA = Math.Round(sva, 2);
                                maestroRow["VALLARTA"] = Convert.ToDouble(vaRow["SALDO"].ToString());
                            }
                        }

                    }

                    foreach (DataRow reRow in dtre.Rows)
                    {
                        if (maestroRow["PROVEEDOR"].ToString().Equals(reRow["PROVEEDOR"].ToString()))
                        {
                            sre = Convert.ToDouble(reRow["SALDO"].ToString());
                            if (sre != 0)
                            {
                                saldoRE = Math.Round(sre, 2);
                                maestroRow["RENA"] = Convert.ToDouble(reRow["SALDO"].ToString());
                            }
                        }

                    }



                    foreach (DataRow coRow in dtco.Rows)
                    {
                        if (maestroRow["PROVEEDOR"].ToString().Equals(coRow["PROVEEDOR"].ToString()))
                        {
                            sco = Convert.ToDouble(coRow["SALDO"].ToString());
                            if (sco != 0)
                            {
                                saldoCO = Math.Round(sco, 2);
                                maestroRow["COLOSO"] = Convert.ToDouble(coRow["SALDO"].ToString());
                            }
                        }

                    }

                    foreach (DataRow veRow in dtve.Rows)
                    {
                        if (maestroRow["PROVEEDOR"].ToString().Equals(veRow["PROVEEDOR"].ToString()))
                        {
                            sve = Convert.ToDouble(veRow["SALDO"].ToString());
                            if (sve != 0)
                            {
                                saldoVE = Math.Round(sve, 2);
                                maestroRow["VELAZQUEZ"] = Convert.ToDouble(veRow["SALDO"].ToString());
                            }
                        }

                    }

                    foreach (DataRow preRow in dtpre.Rows)
                    {
                        if (maestroRow["PROVEEDOR"].ToString().Equals(preRow["PROVEEDOR"].ToString()))
                        {
                            spre = Convert.ToDouble(preRow["SALDO"].ToString());


                            if (spre != 0)
                            {
                                saldoPRE = Math.Round(spre, 2);
                                maestroRow["PREGOT"] = Convert.ToDouble(preRow["SALDO"].ToString());
                            }
                        }



                    }


                    suma = saldoBO + saldoVA + saldoVE + saldoCO + saldoRE + saldoPRE;

                    maestroRow["SALDO"] = Math.Round(suma, 2);

                    suma = 0; saldoBO = 0; saldoRE = 0; saldoVA = 0; saldoCO = 0; saldoVE = 0; saldoPRE = 0;

                }



                //############################ SALDOS TOTALES POR TIENDA #######################################################################
                double Tbodega = 0, Tvallarta = 0, Trena = 0, Tcoloso = 0, Tvelazquez = 0, Tpregot = 0, total = 0;

                for (int i = 0; i < maestro.Rows.Count; i++)
                {
                    Tbodega += Math.Round(Convert.ToDouble(maestro.Rows[i]["BODEGA"]), 2);
                    Tvallarta += Math.Round(Convert.ToDouble(maestro.Rows[i]["VALLARTA"]), 2);
                    Trena += Math.Round(Convert.ToDouble(maestro.Rows[i]["RENA"]), 2);
                    Tcoloso += Math.Round(Convert.ToDouble(maestro.Rows[i]["COLOSO"]), 2);
                    Tvelazquez += Math.Round(Convert.ToDouble(maestro.Rows[i]["VELAZQUEZ"]), 2);
                    Tpregot += Math.Round(Convert.ToDouble(maestro.Rows[i]["PREGOT"]), 2);
                    total += Math.Round(Convert.ToDouble(maestro.Rows[i]["SALDO"]), 2);
                }




                DataRow filaTotales = maestro.NewRow();
                filaTotales["PROVEEDOR"] = "";
                filaTotales["NOMBRE"] = "TOTALES";
                filaTotales["BODEGA"] = Math.Round(Tbodega, 2);
                filaTotales["VALLARTA"] = Math.Round(Tvallarta, 2);
                filaTotales["RENA"] = Math.Round(Trena, 2);
                filaTotales["COLOSO"] = Math.Round(Tcoloso, 2);
                filaTotales["VELAZQUEZ"] = Math.Round(Tvelazquez, 2);
                filaTotales["PREGOT"] = Math.Round(Tpregot, 2);
                filaTotales["SALDO"] = Math.Round(total, 2);

                maestro.Rows.Add(filaTotales);
                DataView dv = new DataView(maestro);
                dv.RowFilter = "SALDO<>0";
                //maestro.DefaultView.RowFilter = "SALDO<>0";




                DG_reporte.DataSource = dv;

                DG_reporte.Columns[1].Width = 350;
                DG_reporte.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[2].DefaultCellStyle.Format = "C2";
                DG_reporte.Columns[3].DefaultCellStyle.Format = "C2";
                DG_reporte.Columns[4].DefaultCellStyle.Format = "C2";
                DG_reporte.Columns[5].DefaultCellStyle.Format = "C2";
                DG_reporte.Columns[6].DefaultCellStyle.Format = "C2";
                DG_reporte.Columns[7].DefaultCellStyle.Format = "C2";
                DG_reporte.Columns[8].DefaultCellStyle.Format = "C2";

                DG_reporte.Columns["PROVEEDOR"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["NOMBRE"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["BODEGA"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["VALLARTA"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["RENA"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["COLOSO"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["VELAZQUEZ"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["PREGOT"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["SALDO"].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            else
            {
                string consulta = "SELECT cuenxpag.proveedor,proveed.nombre,SUM( cuenxpag.saldo * cuenxpag.tip_cam ) AS SALDO FROM cuenxpag INNER JOIN proveed USING(proveedor)" +
               " GROUP BY cuenxpag.proveedor ORDER BY cuenxpag.proveedor, cuenxpag.moneda,cuenxpag.tipo_doc,cuenxpag.no_referen ";
                MySqlConnection con = BDConexicon.BodegaOpen();
                try
                {

                    //OBTENGO LOS PROVEEDORES QUE EXISTEN EN LA BASE DE DATOS DE BODEGA
                    MySqlCommand cmd = new MySqlCommand("SELECT PROVEEDOR,NOMBRE from proveed", con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        prov.Add(new Proveedor { proveedor = dr["PROVEEDOR"].ToString(), nombre = dr["NOMBRE"].ToString() });

                    }
                    dr.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("NO HAY CONEXION CON EL SERVIDOR DE BODEGA");
                }

                //LLENO MI DATATABLE maestro
                for (int i = 0; i < prov.Count; i++)
                {
                    maestro.Rows.Add(prov[i].proveedor, prov[i].nombre, 0, 0, 0, 0, 0, 0);
                }

                try
                {
                    //LLENO MI DATATABLE dtbo
                    MySqlCommand bo = new MySqlCommand(consulta, con);
                    MySqlDataAdapter ad = new MySqlDataAdapter(bo);
                    ad.Fill(dtbo);
                    LB_bo.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {
                    LB_bo.ForeColor = Color.Red;
                    MessageBox.Show("ERROR: "+ex);

                }

                try
                {
                    //LLENO MI DATATABLE dtva
                    MySqlConnection conva = BDConexicon.VallartaOpen();
                    MySqlCommand va = new MySqlCommand(consulta, conva);
                    MySqlDataAdapter adva = new MySqlDataAdapter(va);
                    adva.Fill(dtva);
                    LB_va.ForeColor = Color.DarkGreen;

                }
                catch (Exception ex)
                {
                    LB_va.ForeColor = Color.Red;
                }

                try
                {
                    MySqlConnection conre = BDConexicon.RenaOpen();
                    MySqlCommand re = new MySqlCommand(consulta, conre);
                    MySqlDataAdapter adre = new MySqlDataAdapter(re);
                    adre.Fill(dtre);
                    LB_rena.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {
                    LB_rena.ForeColor = Color.Red;

                }


                try
                {
                    MySqlConnection conco = BDConexicon.ColosoOpen();
                    MySqlCommand co = new MySqlCommand(consulta, conco);
                    MySqlDataAdapter adco = new MySqlDataAdapter(co);
                    adco.Fill(dtco);
                    LB_coloso.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {

                    LB_coloso.ForeColor = Color.Red;
                }

                try
                {
                    MySqlConnection conve = BDConexicon.VelazquezOpen();
                    MySqlCommand ve = new MySqlCommand(consulta, conve);
                    MySqlDataAdapter adve = new MySqlDataAdapter(ve);
                    adve.Fill(dtve);
                    LB_velazquez.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {

                    LB_velazquez.ForeColor = Color.Red;
                }

                try
                {
                    MySqlConnection conpre = BDConexicon.Papeleria1Open();
                    MySqlCommand pre = new MySqlCommand(consulta, conpre);
                    MySqlDataAdapter adpre = new MySqlDataAdapter(pre);
                    adpre.Fill(dtpre);
                    LB_pregot.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {
                    LB_pregot.ForeColor = Color.Red;
                }

                double saldoBO = 0, saldoVA = 0, saldoRE = 0, saldoCO = 0, saldoVE = 0, saldoPRE = 0, suma = 0;
                double sbo = 0, sva = 0, sre = 0, sco = 0, sve = 0, spre = 0, sum = 0;
                OrdenarDT();

                foreach (DataRow maestroRow in maestro.Rows)
                {
                    foreach (DataRow boRow in dtbo.Rows)
                    {
                        if (maestroRow["PROVEEDOR"].ToString().Equals(boRow["PROVEEDOR"].ToString()))
                        {
                            sbo = Convert.ToDouble(boRow["SALDO"].ToString());
                            if (sbo != 0)
                            {
                                saldoBO = Math.Round(sbo, 2);
                                maestroRow["BODEGA"] = Convert.ToDouble(boRow["SALDO"].ToString());
                            }
                        }

                    }

                    foreach (DataRow vaRow in dtva.Rows)
                    {
                        if (maestroRow["PROVEEDOR"].ToString().Equals(vaRow["PROVEEDOR"].ToString()))
                        {
                            sva = Convert.ToDouble(vaRow["SALDO"].ToString());
                            if (sva != 0)
                            {
                                saldoVA = Math.Round(sva, 2);
                                maestroRow["VALLARTA"] = Convert.ToDouble(vaRow["SALDO"].ToString());
                            }
                        }

                    }

                    foreach (DataRow reRow in dtre.Rows)
                    {
                        if (maestroRow["PROVEEDOR"].ToString().Equals(reRow["PROVEEDOR"].ToString()))
                        {
                            sre = Convert.ToDouble(reRow["SALDO"].ToString());
                            if (sre != 0)
                            {
                                saldoRE = Math.Round(sre, 2);
                                maestroRow["RENA"] = Convert.ToDouble(reRow["SALDO"].ToString());
                            }
                        }

                    }



                    foreach (DataRow coRow in dtco.Rows)
                    {
                        if (maestroRow["PROVEEDOR"].ToString().Equals(coRow["PROVEEDOR"].ToString()))
                        {
                            sco = Convert.ToDouble(coRow["SALDO"].ToString());
                            if (sco != 0)
                            {
                                saldoCO = Math.Round(sco, 2);
                                maestroRow["COLOSO"] = Convert.ToDouble(coRow["SALDO"].ToString());
                            }
                        }

                    }

                    foreach (DataRow veRow in dtve.Rows)
                    {
                        if (maestroRow["PROVEEDOR"].ToString().Equals(veRow["PROVEEDOR"].ToString()))
                        {
                            sve = Convert.ToDouble(veRow["SALDO"].ToString());
                            if (sve != 0)
                            {
                                saldoVE = Math.Round(sve, 2);
                                maestroRow["VELAZQUEZ"] = Convert.ToDouble(veRow["SALDO"].ToString());
                            }
                        }

                    }

                    foreach (DataRow preRow in dtpre.Rows)
                    {
                        if (maestroRow["PROVEEDOR"].ToString().Equals(preRow["PROVEEDOR"].ToString()))
                        {
                            spre = Convert.ToDouble(preRow["SALDO"].ToString());


                            if (spre != 0)
                            {
                                saldoPRE = Math.Round(spre, 2);
                                maestroRow["PREGOT"] = Convert.ToDouble(preRow["SALDO"].ToString());
                            }
                        }



                    }


                    suma = saldoBO + saldoVA + saldoVE + saldoCO + saldoRE + saldoPRE;

                    maestroRow["SALDO"] = Math.Round(suma, 2);

                    suma = 0; saldoBO = 0; saldoRE = 0; saldoVA = 0; saldoCO = 0; saldoVE = 0; saldoPRE = 0;

                }



                //############################ SALDOS TOTALES POR TIENDA #######################################################################
                double Tbodega = 0, Tvallarta = 0, Trena = 0, Tcoloso = 0, Tvelazquez = 0, Tpregot = 0, total = 0;

                for (int i = 0; i < maestro.Rows.Count; i++)
                {
                    Tbodega += Math.Round(Convert.ToDouble(maestro.Rows[i]["BODEGA"]), 2);
                    Tvallarta += Math.Round(Convert.ToDouble(maestro.Rows[i]["VALLARTA"]), 2);
                    Trena += Math.Round(Convert.ToDouble(maestro.Rows[i]["RENA"]), 2);
                    Tcoloso += Math.Round(Convert.ToDouble(maestro.Rows[i]["COLOSO"]), 2);
                    Tvelazquez += Math.Round(Convert.ToDouble(maestro.Rows[i]["VELAZQUEZ"]), 2);
                    Tpregot += Math.Round(Convert.ToDouble(maestro.Rows[i]["PREGOT"]), 2);
                    total += Math.Round(Convert.ToDouble(maestro.Rows[i]["SALDO"]), 2);
                }




                DataRow filaTotales = maestro.NewRow();
                filaTotales["PROVEEDOR"] = "";
                filaTotales["NOMBRE"] = "TOTALES";
                filaTotales["BODEGA"] = Math.Round(Tbodega, 2);
                filaTotales["VALLARTA"] = Math.Round(Tvallarta, 2);
                filaTotales["RENA"] = Math.Round(Trena, 2);
                filaTotales["COLOSO"] = Math.Round(Tcoloso, 2);
                filaTotales["VELAZQUEZ"] = Math.Round(Tvelazquez, 2);
                filaTotales["PREGOT"] = Math.Round(Tpregot, 2);
                filaTotales["SALDO"] = Math.Round(total, 2);

                maestro.Rows.Add(filaTotales);
                DataView dv = new DataView(maestro);
                dv.RowFilter = "SALDO<>0";
                //maestro.DefaultView.RowFilter = "SALDO<>0";




                DG_reporte.DataSource = dv;

                DG_reporte.Columns[1].Width = 350;
                DG_reporte.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[2].DefaultCellStyle.Format = "C2";
                DG_reporte.Columns[3].DefaultCellStyle.Format = "C2";
                DG_reporte.Columns[4].DefaultCellStyle.Format = "C2";
                DG_reporte.Columns[5].DefaultCellStyle.Format = "C2";
                DG_reporte.Columns[6].DefaultCellStyle.Format = "C2";
                DG_reporte.Columns[7].DefaultCellStyle.Format = "C2";
                DG_reporte.Columns[8].DefaultCellStyle.Format = "C2";

                DG_reporte.Columns["PROVEEDOR"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["NOMBRE"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["BODEGA"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["VALLARTA"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["RENA"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["COLOSO"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["VELAZQUEZ"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["PREGOT"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["SALDO"].SortMode = DataGridViewColumnSortMode.NotSortable;

            }





            ////SE AGREGAN LAS SIGUIENTES COLUMNAS AL DATATABLE maestro
            //maestro.Columns.Add("PROVEEDOR", typeof(string));
            //maestro.Columns.Add("NOMBRE", typeof(string));
            //maestro.Columns.Add("BODEGA", typeof(double));
            //maestro.Columns.Add("VALLARTA", typeof(double));
            //maestro.Columns.Add("RENA", typeof(double));
            //maestro.Columns.Add("COLOSO", typeof(double));
            //maestro.Columns.Add("VELAZQUEZ", typeof(double));
            //maestro.Columns.Add("PREGOT", typeof(double));
            //maestro.Columns.Add("SALDO", typeof(double));

            //MySqlConnection con = BDConexicon.BodegaOpen();
            //try
            //{

            //    //OBTENGO LOS PROVEEDORES QUE EXISTEN EN LA BASE DE DATOS DE BODEGA
            //    MySqlCommand cmd = new MySqlCommand("SELECT PROVEEDOR,NOMBRE from proveed", con);
            //    MySqlDataReader dr = cmd.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        prov.Add(new Proveedor { proveedor = dr["PROVEEDOR"].ToString(), nombre = dr["NOMBRE"].ToString() });
            //    }
            //    dr.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("NO HAY CONEXION CON EL SERVIDOR DE BODEGA GENERAL");

            //}

            ////LLENO MI DATATABLE maestro
            //for (int i = 0; i < prov.Count; i++)
            //{
            //    maestro.Rows.Add(prov[i].proveedor, prov[i].nombre, 0,0,0,0,0,0);
            //}

            //try
            //{
            //    //LLENO MI DATATABLE dtbo
            //    MySqlCommand bo = new MySqlCommand("SELECT cp.PROVEEDOR AS PROVEEDOR,p.NOMBRE AS NOMBRE,SUM(cp.SALDO) AS SALDO FROM cuenxpag cp INNER JOIN proveed p ON cp.PROVEEDOR = p.PROVEEDOR GROUP BY PROVEEDOR ORDER BY PROVEEDOR", con);
            //    MySqlDataAdapter ad = new MySqlDataAdapter(bo);
            //    ad.Fill(dtbo);
            //}
            //catch (Exception ex)
            //{


            //}

            //try
            //{
            //    //LLENO MI DATATABLE dtva
            //    MySqlConnection conva = BDConexicon.VallartaOpen();
            //    MySqlCommand va = new MySqlCommand("SELECT cp.PROVEEDOR AS PROVEEDOR,p.NOMBRE AS NOMBRE,SUM(cp.SALDO) AS SALDO FROM cuenxpag cp INNER JOIN proveed p ON cp.PROVEEDOR = p.PROVEEDOR GROUP BY PROVEEDOR ORDER BY PROVEEDOR", conva);
            //    MySqlDataAdapter adva = new MySqlDataAdapter(va);
            //    adva.Fill(dtva);

            //}
            //catch (Exception ex)
            //{

            //}

            //try
            //{
            //    MySqlConnection conre = BDConexicon.RenaOpen();
            //    MySqlCommand re = new MySqlCommand("SELECT cp.PROVEEDOR AS PROVEEDOR,p.NOMBRE AS NOMBRE,SUM(cp.SALDO) AS SALDO FROM cuenxpag cp INNER JOIN proveed p ON cp.PROVEEDOR = p.PROVEEDOR GROUP BY PROVEEDOR ORDER BY PROVEEDOR", conre);
            //    MySqlDataAdapter adre = new MySqlDataAdapter(re);
            //    adre.Fill(dtre);
            //}
            //catch (Exception ex)
            //{


            //}


            //try
            //{
            //    MySqlConnection conco = BDConexicon.ColosoOpen();
            //    MySqlCommand co = new MySqlCommand("SELECT cp.PROVEEDOR AS PROVEEDOR,p.NOMBRE AS NOMBRE,SUM(cp.SALDO) AS SALDO FROM cuenxpag cp INNER JOIN proveed p ON cp.PROVEEDOR = p.PROVEEDOR GROUP BY PROVEEDOR ORDER BY PROVEEDOR", conco);
            //    MySqlDataAdapter adco = new MySqlDataAdapter(co);
            //    adco.Fill(dtco);
            //}
            //catch (Exception ex)
            //{


            //}

            //try
            //{
            //    MySqlConnection conve = BDConexicon.VelazquezOpen();
            //    MySqlCommand ve = new MySqlCommand("SELECT cp.PROVEEDOR AS PROVEEDOR,p.NOMBRE AS NOMBRE,SUM(cp.SALDO) AS SALDO FROM cuenxpag cp INNER JOIN proveed p ON cp.PROVEEDOR = p.PROVEEDOR GROUP BY PROVEEDOR ORDER BY PROVEEDOR", conve);
            //    MySqlDataAdapter adve = new MySqlDataAdapter(ve);
            //    adve.Fill(dtve);
            //}
            //catch (Exception ex)
            //{

            //    throw;
            //}

            //try
            //{
            //    MySqlConnection conpre = BDConexicon.Papeleria1Open();
            //    MySqlCommand pre = new MySqlCommand("SELECT cp.PROVEEDOR AS PROVEEDOR,p.NOMBRE AS NOMBRE,SUM(cp.SALDO) AS SALDO FROM cuenxpag cp INNER JOIN proveed p ON cp.PROVEEDOR = p.PROVEEDOR GROUP BY PROVEEDOR ORDER BY PROVEEDOR", conpre);
            //    MySqlDataAdapter adpre = new MySqlDataAdapter(pre);
            //    adpre.Fill(dtpre);
            //}
            //catch (Exception ex)
            //{
            //}

            //double saldoBO = 0, saldoVA = 0, saldoRE = 0, saldoCO = 0, saldoVE = 0, saldoPRE = 0, suma = 0;
            //double sbo = 0, sva = 0, sre = 0, sco = 0, sve = 0, spre = 0, sum = 0;
            //OrdenarDT();

            //foreach (DataRow maestroRow in maestro.Rows)
            //{
            //    foreach (DataRow boRow in dtbo.Rows)
            //    {
            //        if (maestroRow["PROVEEDOR"].ToString().Equals(boRow["PROVEEDOR"].ToString()))
            //        {
            //            sbo = Convert.ToDouble(boRow["SALDO"].ToString());
            //            saldoBO = Math.Round(sbo, 2);
            //            maestroRow["BODEGA"] = Convert.ToDouble(boRow["SALDO"].ToString());
            //        }
            //    }

            //    foreach (DataRow vaRow in dtva.Rows)
            //    {
            //        if (maestroRow["PROVEEDOR"].ToString().Equals(vaRow["PROVEEDOR"].ToString()))
            //        {
            //            sva = Convert.ToDouble(vaRow["SALDO"].ToString());
            //            saldoVA = Math.Round(sva, 2);
            //            maestroRow["VALLARTA"] = Convert.ToDouble(vaRow["SALDO"].ToString());
            //        }
            //    }

            //    foreach (DataRow reRow in dtre.Rows)
            //    {
            //        if (maestroRow["PROVEEDOR"].ToString().Equals(reRow["PROVEEDOR"].ToString()))
            //        {
            //            sre = Convert.ToDouble(reRow["SALDO"].ToString());
            //            saldoRE = Math.Round(sre, 2);
            //            maestroRow["RENA"] = Convert.ToDouble(reRow["SALDO"].ToString());
            //        }
            //    }



            //    foreach (DataRow coRow in dtco.Rows)
            //    {
            //        if (maestroRow["PROVEEDOR"].ToString().Equals(coRow["PROVEEDOR"].ToString()))
            //        {
            //            sco = Convert.ToDouble(coRow["SALDO"].ToString());
            //            saldoCO = Math.Round(sco, 2);
            //            maestroRow["COLOSO"] = Convert.ToDouble(coRow["SALDO"].ToString());
            //        }
            //    }

            //    foreach (DataRow veRow in dtve.Rows)
            //    {
            //        if (maestroRow["PROVEEDOR"].ToString().Equals(veRow["PROVEEDOR"].ToString()))
            //        {
            //            sve = Convert.ToDouble(veRow["SALDO"].ToString());
            //            saldoVE = Math.Round(sve, 2);
            //            maestroRow["VELAZQUEZ"] = Convert.ToDouble(veRow["SALDO"].ToString());
            //        }
            //    }

            //    foreach (DataRow preRow in dtpre.Rows)
            //    {
            //        if (maestroRow["PROVEEDOR"].ToString().Equals(preRow["PROVEEDOR"].ToString()))
            //        {
            //            spre = Convert.ToDouble(preRow["SALDO"].ToString());
            //            saldoPRE = Math.Round(spre, 2);
            //            maestroRow["PREGOT"] = Convert.ToDouble(preRow["SALDO"].ToString());
            //        }


            //    }


            //    suma = saldoBO + saldoVA + saldoVE + saldoCO + saldoRE + saldoPRE;

            //    maestroRow["SALDO"] = Math.Round(suma, 2);

            //    suma = 0; saldoBO = 0; saldoRE = 0; saldoVA = 0; saldoCO = 0; saldoVE = 0; saldoPRE = 0;
            //}



            ////############################ SALDOS TOTALES POR TIENDA #######################################################################
            //double Tbodega = 0, Tvallarta = 0, Trena = 0, Tcoloso = 0, Tvelazquez = 0, Tpregot = 0, total = 0;

            //for (int i = 0; i < maestro.Rows.Count; i++)
            //{
            //    Tbodega += Math.Round(Convert.ToDouble(maestro.Rows[i]["BODEGA"]), 2);
            //    Tvallarta += Math.Round(Convert.ToDouble(maestro.Rows[i]["VALLARTA"]), 2);
            //    Trena += Math.Round(Convert.ToDouble(maestro.Rows[i]["RENA"]), 2);
            //    Tcoloso += Math.Round(Convert.ToDouble(maestro.Rows[i]["COLOSO"]), 2);
            //    Tvelazquez += Math.Round(Convert.ToDouble(maestro.Rows[i]["VELAZQUEZ"]), 2);
            //    Tpregot += Math.Round(Convert.ToDouble(maestro.Rows[i]["PREGOT"]), 2);
            //    total += Math.Round(Convert.ToDouble(maestro.Rows[i]["SALDO"]), 2);
            //}




            //DataRow filaTotales = maestro.NewRow();
            //filaTotales["PROVEEDOR"] = "";
            //filaTotales["NOMBRE"] = "TOTALES";
            //filaTotales["BODEGA"] = Math.Round(Tbodega, 2);
            //filaTotales["VALLARTA"] = Math.Round(Tvallarta, 2);
            //filaTotales["RENA"] = Math.Round(Trena, 2);
            //filaTotales["COLOSO"] = Math.Round(Tcoloso, 2);
            //filaTotales["VELAZQUEZ"] = Math.Round(Tvelazquez, 2);
            //filaTotales["PREGOT"] = Math.Round(Tpregot, 2);
            //filaTotales["SALDO"] = Math.Round(total, 2);

            //maestro.Rows.Add(filaTotales);
            ////maestro.DefaultView.RowFilter = "SALDO <>0";



            //DG_reporte.DataSource = maestro;
            //DG_reporte.Columns[1].Width = 350;
            //DG_reporte.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            //DG_reporte.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            //DG_reporte.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            //DG_reporte.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            //DG_reporte.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            //DG_reporte.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            //DG_reporte.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            //DG_reporte.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            //DG_reporte.Columns[2].DefaultCellStyle.Format = "C2";
            //DG_reporte.Columns[3].DefaultCellStyle.Format = "C2";
            //DG_reporte.Columns[4].DefaultCellStyle.Format = "C2";
            //DG_reporte.Columns[5].DefaultCellStyle.Format = "C2";
            //DG_reporte.Columns[6].DefaultCellStyle.Format = "C2";
            //DG_reporte.Columns[7].DefaultCellStyle.Format = "C2";
            //DG_reporte.Columns[8].DefaultCellStyle.Format = "C2";

            //DG_reporte.Columns["PROVEEDOR"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //DG_reporte.Columns["NOMBRE"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //DG_reporte.Columns["BODEGA"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //DG_reporte.Columns["VALLARTA"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //DG_reporte.Columns["RENA"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //DG_reporte.Columns["COLOSO"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //DG_reporte.Columns["VELAZQUEZ"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //DG_reporte.Columns["PREGOT"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //DG_reporte.Columns["SALDO"].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        public string MesdeRespaldo(int mes)
        {
            string mesRespaldo = "";

            if (mes == 1)
            {
                mesRespaldo = "ENE";
            }
            if (mes==2)
            {
                mesRespaldo = "FEB";
            }
            if (mes == 3)
            {
                mesRespaldo = "MAR";
            }
            if (mes == 4)
            {
                mesRespaldo = "ABR";
            }
            if (mes == 5)
            {
                mesRespaldo = "MAY";
            }
            if (mes == 6)
            {
                mesRespaldo = "JUN";
            }
            if (mes == 7)
            {
                mesRespaldo = "JUL";
            }
            if (mes == 8)
            {
                mesRespaldo = "AGO";
            }
            if (mes == 9)
            {
                mesRespaldo = "SEP";
            }
            if (mes == 10)
            {
                mesRespaldo = "OCT";
            }
            if (mes == 11)
            {
                mesRespaldo = "NOV";
            }
            if (mes == 12)
            {
                mesRespaldo = "DIC";
            }
            return mesRespaldo;
        }

        public void SaldosMayoresACero()
        {

            maestro.Clear();
            dtbo.Clear();
            dtva.Clear();
            dtre.Clear();
            dtco.Clear();
            dtve.Clear();
            dtpre.Clear();
            prov.Clear();
            LB_bo.ForeColor = Color.Black;
            LB_va.ForeColor = Color.Black;
            LB_rena.ForeColor = Color.Black;
            LB_coloso.ForeColor = Color.Black;
            LB_pregot.ForeColor = Color.Black;
            DateTime fecha = DT_date.Value;
            int mes = DT_date.Value.Month;
            int año = DT_date.Value.Year;

            if (CHK_fecha.Checked==true)
            {

               



               string mesRespaldo= MesdeRespaldo(mes);

                string consulta = "SELECT cuenxpag.proveedor,proveed.nombre,SUM( cuenxpag.saldo * cuenxpag.tip_cam ) AS SALDO FROM cuenxpag INNER JOIN proveed USING(proveedor)" +
               " WHERE cuenxpag.saldo > 0 and cuenxpag.fecha between '2008-01-01' and '"+fecha.ToString("yyyy-MM-dd")+"' GROUP BY cuenxpag.proveedor ORDER BY cuenxpag.proveedor, cuenxpag.moneda,cuenxpag.tipo_doc,cuenxpag.no_referen ";
                MySqlConnection con = BDConexicon.RespaldoVA(mesRespaldo, año);//ERA EL METODO DE BODEGA ANTES RespaldoVA(mesRespaldo,año)
                try
                {

                    //OBTENGO LOS PROVEEDORES QUE EXISTEN EN LA BASE DE DATOS DE BODEGA
                    MySqlCommand cmd = new MySqlCommand("SELECT PROVEEDOR,NOMBRE from proveed", con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        prov.Add(new Proveedor { proveedor = dr["PROVEEDOR"].ToString(), nombre = dr["NOMBRE"].ToString() });

                    }
                    dr.Close();
                }
                catch (Exception ex)
                {

                    //MessageBox.Show("NO HAY CONEXION CON EL SERVIDOR DE BODEGA");
                }

                //LLENO MI DATATABLE maestro
                for (int i = 0; i < prov.Count; i++)
                {
                    maestro.Rows.Add(prov[i].proveedor, prov[i].nombre, 0, 0, 0, 0, 0, 0);
                }

                try
                {
                    //LLENO MI DATATABLE dtbo
                    MySqlConnection conexbo = BDConexicon.BodegaOpen();
                    MySqlCommand bo = new MySqlCommand(consulta, conexbo);
                    MySqlDataAdapter ad = new MySqlDataAdapter(bo);
                    ad.Fill(dtbo);
                    LB_bo.ForeColor = Color.DarkGreen;
                    conexbo.Close();
                }
                catch (Exception ex)
                {
                    LB_bo.ForeColor = Color.Red;

                }

                try
                {
                    //LLENO MI DATATABLE dtva
                    MySqlConnection conva = BDConexicon.RespaldoVA(mesRespaldo,año);
                    MySqlCommand va = new MySqlCommand(consulta, conva);
                    MySqlDataAdapter adva = new MySqlDataAdapter(va);
                    adva.Fill(dtva);
                    LB_va.ForeColor = Color.DarkGreen;

                }
                catch (Exception ex)
                {
                    LB_va.ForeColor = Color.Red;
                }

                try
                {
                    MySqlConnection conre = BDConexicon.RespaldoRE(mesRespaldo, año);
                    MySqlCommand re = new MySqlCommand(consulta, conre);
                    MySqlDataAdapter adre = new MySqlDataAdapter(re);
                    adre.Fill(dtre);
                    LB_rena.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {
                    LB_rena.ForeColor = Color.Red;

                }


                try
                {
                    MySqlConnection conco = BDConexicon.RespaldoCO(mesRespaldo, año);
                    MySqlCommand co = new MySqlCommand(consulta, conco);
                    MySqlDataAdapter adco = new MySqlDataAdapter(co);
                    adco.Fill(dtco);
                    LB_coloso.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {

                    LB_coloso.ForeColor = Color.Red;
                }

                try
                {
                    MySqlConnection conve = BDConexicon.RespaldoVE(mesRespaldo, año);
                    MySqlCommand ve = new MySqlCommand(consulta, conve);
                    MySqlDataAdapter adve = new MySqlDataAdapter(ve);
                    adve.Fill(dtve);
                    LB_velazquez.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {

                    LB_velazquez.ForeColor = Color.Red;
                }

                try
                {
                    MySqlConnection conpre = BDConexicon.RespaldoPRE(mesRespaldo, año);
                    MySqlCommand pre = new MySqlCommand(consulta, conpre);
                    MySqlDataAdapter adpre = new MySqlDataAdapter(pre);
                    adpre.Fill(dtpre);
                    LB_pregot.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {
                    LB_pregot.ForeColor = Color.Red;
                }

                double saldoBO = 0, saldoVA = 0, saldoRE = 0, saldoCO = 0, saldoVE = 0, saldoPRE = 0, suma = 0;
                double sbo = 0, sva = 0, sre = 0, sco = 0, sve = 0, spre = 0, sum = 0;
                OrdenarDT();

                foreach (DataRow maestroRow in maestro.Rows)
                {
                    foreach (DataRow boRow in dtbo.Rows)
                    {
                        if (maestroRow["PROVEEDOR"].ToString().Equals(boRow["PROVEEDOR"].ToString()))
                        {
                            sbo = Convert.ToDouble(boRow["SALDO"].ToString());
                            if (sbo != 0)
                            {
                                saldoBO = Math.Round(sbo, 2);
                                maestroRow["BODEGA"] = Convert.ToDouble(boRow["SALDO"].ToString());
                            }
                        }

                    }

                    foreach (DataRow vaRow in dtva.Rows)
                    {
                        if (maestroRow["PROVEEDOR"].ToString().Equals(vaRow["PROVEEDOR"].ToString()))
                        {
                            sva = Convert.ToDouble(vaRow["SALDO"].ToString());
                            if (sva != 0)
                            {
                                saldoVA = Math.Round(sva, 2);
                                maestroRow["VALLARTA"] = Convert.ToDouble(vaRow["SALDO"].ToString());
                            }
                        }

                    }

                    foreach (DataRow reRow in dtre.Rows)
                    {
                        if (maestroRow["PROVEEDOR"].ToString().Equals(reRow["PROVEEDOR"].ToString()))
                        {
                            sre = Convert.ToDouble(reRow["SALDO"].ToString());
                            if (sre != 0)
                            {
                                saldoRE = Math.Round(sre, 2);
                                maestroRow["RENA"] = Convert.ToDouble(reRow["SALDO"].ToString());
                            }
                        }

                    }



                    foreach (DataRow coRow in dtco.Rows)
                    {
                        if (maestroRow["PROVEEDOR"].ToString().Equals(coRow["PROVEEDOR"].ToString()))
                        {
                            sco = Convert.ToDouble(coRow["SALDO"].ToString());
                            if (sco != 0)
                            {
                                saldoCO = Math.Round(sco, 2);
                                maestroRow["COLOSO"] = Convert.ToDouble(coRow["SALDO"].ToString());
                            }
                        }

                    }

                    foreach (DataRow veRow in dtve.Rows)
                    {
                        if (maestroRow["PROVEEDOR"].ToString().Equals(veRow["PROVEEDOR"].ToString()))
                        {
                            sve = Convert.ToDouble(veRow["SALDO"].ToString());
                            if (sve != 0)
                            {
                                saldoVE = Math.Round(sve, 2);
                                maestroRow["VELAZQUEZ"] = Convert.ToDouble(veRow["SALDO"].ToString());
                            }
                        }

                    }

                    foreach (DataRow preRow in dtpre.Rows)
                    {
                        if (maestroRow["PROVEEDOR"].ToString().Equals(preRow["PROVEEDOR"].ToString()))
                        {
                            spre = Convert.ToDouble(preRow["SALDO"].ToString());


                            if (spre != 0)
                            {
                                saldoPRE = Math.Round(spre, 2);
                                maestroRow["PREGOT"] = Convert.ToDouble(preRow["SALDO"].ToString());
                            }
                        }



                    }


                    suma = saldoBO + saldoVA + saldoVE + saldoCO + saldoRE + saldoPRE;

                    maestroRow["SALDO"] = Math.Round(suma, 2);

                    suma = 0; saldoBO = 0; saldoRE = 0; saldoVA = 0; saldoCO = 0; saldoVE = 0; saldoPRE = 0;

                }



                //############################ SALDOS TOTALES POR TIENDA #######################################################################
                double Tbodega = 0, Tvallarta = 0, Trena = 0, Tcoloso = 0, Tvelazquez = 0, Tpregot = 0, total = 0;

                for (int i = 0; i < maestro.Rows.Count; i++)
                {
                    Tbodega += Math.Round(Convert.ToDouble(maestro.Rows[i]["BODEGA"]), 2);
                    Tvallarta += Math.Round(Convert.ToDouble(maestro.Rows[i]["VALLARTA"]), 2);
                    Trena += Math.Round(Convert.ToDouble(maestro.Rows[i]["RENA"]), 2);
                    Tcoloso += Math.Round(Convert.ToDouble(maestro.Rows[i]["COLOSO"]), 2);
                    Tvelazquez += Math.Round(Convert.ToDouble(maestro.Rows[i]["VELAZQUEZ"]), 2);
                    Tpregot += Math.Round(Convert.ToDouble(maestro.Rows[i]["PREGOT"]), 2);
                    total += Math.Round(Convert.ToDouble(maestro.Rows[i]["SALDO"]), 2);
                }




                DataRow filaTotales = maestro.NewRow();
                filaTotales["PROVEEDOR"] = "";
                filaTotales["NOMBRE"] = "TOTALES";
                filaTotales["BODEGA"] = Math.Round(Tbodega, 2);
                filaTotales["VALLARTA"] = Math.Round(Tvallarta, 2);
                filaTotales["RENA"] = Math.Round(Trena, 2);
                filaTotales["COLOSO"] = Math.Round(Tcoloso, 2);
                filaTotales["VELAZQUEZ"] = Math.Round(Tvelazquez, 2);
                filaTotales["PREGOT"] = Math.Round(Tpregot, 2);
                filaTotales["SALDO"] = Math.Round(total, 2);

                maestro.Rows.Add(filaTotales);
                DataView dv = new DataView(maestro);
                dv.RowFilter = "SALDO<>0";
                //maestro.DefaultView.RowFilter = "SALDO<>0";




                DG_reporte.DataSource = dv;

                DG_reporte.Columns[1].Width = 350;
                DG_reporte.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[2].DefaultCellStyle.Format = "C2";
                DG_reporte.Columns[3].DefaultCellStyle.Format = "C2";
                DG_reporte.Columns[4].DefaultCellStyle.Format = "C2";
                DG_reporte.Columns[5].DefaultCellStyle.Format = "C2";
                DG_reporte.Columns[6].DefaultCellStyle.Format = "C2";
                DG_reporte.Columns[7].DefaultCellStyle.Format = "C2";
                DG_reporte.Columns[8].DefaultCellStyle.Format = "C2";

                DG_reporte.Columns["PROVEEDOR"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["NOMBRE"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["BODEGA"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["VALLARTA"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["RENA"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["COLOSO"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["VELAZQUEZ"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["PREGOT"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["SALDO"].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            else
            {
                string consulta = "SELECT cuenxpag.proveedor,proveed.nombre,SUM( cuenxpag.saldo * cuenxpag.tip_cam ) AS SALDO FROM cuenxpag INNER JOIN proveed USING(proveedor)" +
               " WHERE cuenxpag.saldo <> 0 GROUP BY cuenxpag.proveedor ORDER BY cuenxpag.proveedor, cuenxpag.moneda,cuenxpag.tipo_doc,cuenxpag.no_referen ";
                MySqlConnection con = BDConexicon.BodegaOpen();
                try
                {

                    //OBTENGO LOS PROVEEDORES QUE EXISTEN EN LA BASE DE DATOS DE BODEGA
                    MySqlCommand cmd = new MySqlCommand("SELECT PROVEEDOR,NOMBRE from proveed", con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        prov.Add(new Proveedor { proveedor = dr["PROVEEDOR"].ToString(), nombre = dr["NOMBRE"].ToString() });

                    }
                    dr.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("NO HAY CONEXION CON EL SERVIDOR DE BODEGA");
                }

                //LLENO MI DATATABLE maestro
                for (int i = 0; i < prov.Count; i++)
                {
                    maestro.Rows.Add(prov[i].proveedor, prov[i].nombre, 0, 0, 0, 0, 0, 0);
                }

                try
                {
                    //LLENO MI DATATABLE dtbo
                    MySqlCommand bo = new MySqlCommand(consulta, con);
                    MySqlDataAdapter ad = new MySqlDataAdapter(bo);
                    ad.Fill(dtbo);
                    LB_bo.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {
                    LB_bo.ForeColor = Color.Red;

                }

                try
                {
                    //LLENO MI DATATABLE dtva
                    MySqlConnection conva = BDConexicon.VallartaOpen();
                    MySqlCommand va = new MySqlCommand(consulta, conva);
                    MySqlDataAdapter adva = new MySqlDataAdapter(va);
                    adva.Fill(dtva);
                    LB_va.ForeColor = Color.DarkGreen;

                }
                catch (Exception ex)
                {
                    LB_va.ForeColor = Color.Red;
                }

                try
                {
                    MySqlConnection conre = BDConexicon.RenaOpen();
                    MySqlCommand re = new MySqlCommand(consulta, conre);
                    MySqlDataAdapter adre = new MySqlDataAdapter(re);
                    adre.Fill(dtre);
                    LB_rena.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {
                    LB_rena.ForeColor = Color.Red;

                }


                try
                {
                    MySqlConnection conco = BDConexicon.ColosoOpen();
                    MySqlCommand co = new MySqlCommand(consulta, conco);
                    MySqlDataAdapter adco = new MySqlDataAdapter(co);
                    adco.Fill(dtco);
                    LB_coloso.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {

                    LB_coloso.ForeColor = Color.Red;
                }

                try
                {
                    MySqlConnection conve = BDConexicon.VelazquezOpen();
                    MySqlCommand ve = new MySqlCommand(consulta, conve);
                    MySqlDataAdapter adve = new MySqlDataAdapter(ve);
                    adve.Fill(dtve);
                    LB_velazquez.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {

                    LB_velazquez.ForeColor = Color.Red;
                }

                try
                {
                    MySqlConnection conpre = BDConexicon.Papeleria1Open();
                    MySqlCommand pre = new MySqlCommand(consulta, conpre);
                    MySqlDataAdapter adpre = new MySqlDataAdapter(pre);
                    adpre.Fill(dtpre);
                    LB_pregot.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {
                    LB_pregot.ForeColor = Color.Red;
                }

                double saldoBO = 0, saldoVA = 0, saldoRE = 0, saldoCO = 0, saldoVE = 0, saldoPRE = 0, suma = 0;
                double sbo = 0, sva = 0, sre = 0, sco = 0, sve = 0, spre = 0, sum = 0;
                OrdenarDT();

                foreach (DataRow maestroRow in maestro.Rows)
                {
                    foreach (DataRow boRow in dtbo.Rows)
                    {
                        if (maestroRow["PROVEEDOR"].ToString().Equals(boRow["PROVEEDOR"].ToString()))
                        {
                            sbo = Convert.ToDouble(boRow["SALDO"].ToString());
                            if (sbo != 0)
                            {
                                saldoBO = Math.Round(sbo, 2);
                                maestroRow["BODEGA"] = Convert.ToDouble(boRow["SALDO"].ToString());
                            }
                        }

                    }

                    foreach (DataRow vaRow in dtva.Rows)
                    {
                        if (maestroRow["PROVEEDOR"].ToString().Equals(vaRow["PROVEEDOR"].ToString()))
                        {
                            sva = Convert.ToDouble(vaRow["SALDO"].ToString());
                            if (sva != 0)
                            {
                                saldoVA = Math.Round(sva, 2);
                                maestroRow["VALLARTA"] = Convert.ToDouble(vaRow["SALDO"].ToString());
                            }
                        }

                    }

                    foreach (DataRow reRow in dtre.Rows)
                    {
                        if (maestroRow["PROVEEDOR"].ToString().Equals(reRow["PROVEEDOR"].ToString()))
                        {
                            sre = Convert.ToDouble(reRow["SALDO"].ToString());
                            if (sre != 0)
                            {
                                saldoRE = Math.Round(sre, 2);
                                maestroRow["RENA"] = Convert.ToDouble(reRow["SALDO"].ToString());
                            }
                        }

                    }



                    foreach (DataRow coRow in dtco.Rows)
                    {
                        if (maestroRow["PROVEEDOR"].ToString().Equals(coRow["PROVEEDOR"].ToString()))
                        {
                            sco = Convert.ToDouble(coRow["SALDO"].ToString());
                            if (sco != 0)
                            {
                                saldoCO = Math.Round(sco, 2);
                                maestroRow["COLOSO"] = Convert.ToDouble(coRow["SALDO"].ToString());
                            }
                        }

                    }

                    foreach (DataRow veRow in dtve.Rows)
                    {
                        if (maestroRow["PROVEEDOR"].ToString().Equals(veRow["PROVEEDOR"].ToString()))
                        {
                            sve = Convert.ToDouble(veRow["SALDO"].ToString());
                            if (sve != 0)
                            {
                                saldoVE = Math.Round(sve, 2);
                                maestroRow["VELAZQUEZ"] = Convert.ToDouble(veRow["SALDO"].ToString());
                            }
                        }

                    }

                    foreach (DataRow preRow in dtpre.Rows)
                    {
                        if (maestroRow["PROVEEDOR"].ToString().Equals(preRow["PROVEEDOR"].ToString()))
                        {
                            spre = Convert.ToDouble(preRow["SALDO"].ToString());


                            if (spre != 0)
                            {
                                saldoPRE = Math.Round(spre, 2);
                                maestroRow["PREGOT"] = Convert.ToDouble(preRow["SALDO"].ToString());
                            }
                        }



                    }


                    suma = saldoBO + saldoVA + saldoVE + saldoCO + saldoRE + saldoPRE;

                    maestroRow["SALDO"] = Math.Round(suma, 2);

                    suma = 0; saldoBO = 0; saldoRE = 0; saldoVA = 0; saldoCO = 0; saldoVE = 0; saldoPRE = 0;

                }



                //############################ SALDOS TOTALES POR TIENDA #######################################################################
                double Tbodega = 0, Tvallarta = 0, Trena = 0, Tcoloso = 0, Tvelazquez = 0, Tpregot = 0, total = 0;

                for (int i = 0; i < maestro.Rows.Count; i++)
                {
                    Tbodega += Math.Round(Convert.ToDouble(maestro.Rows[i]["BODEGA"]), 2);
                    Tvallarta += Math.Round(Convert.ToDouble(maestro.Rows[i]["VALLARTA"]), 2);
                    Trena += Math.Round(Convert.ToDouble(maestro.Rows[i]["RENA"]), 2);
                    Tcoloso += Math.Round(Convert.ToDouble(maestro.Rows[i]["COLOSO"]), 2);
                    Tvelazquez += Math.Round(Convert.ToDouble(maestro.Rows[i]["VELAZQUEZ"]), 2);
                    Tpregot += Math.Round(Convert.ToDouble(maestro.Rows[i]["PREGOT"]), 2);
                    total += Math.Round(Convert.ToDouble(maestro.Rows[i]["SALDO"]), 2);
                }




                DataRow filaTotales = maestro.NewRow();
                filaTotales["PROVEEDOR"] = "";
                filaTotales["NOMBRE"] = "TOTALES";
                filaTotales["BODEGA"] = Math.Round(Tbodega, 2);
                filaTotales["VALLARTA"] = Math.Round(Tvallarta, 2);
                filaTotales["RENA"] = Math.Round(Trena, 2);
                filaTotales["COLOSO"] = Math.Round(Tcoloso, 2);
                filaTotales["VELAZQUEZ"] = Math.Round(Tvelazquez, 2);
                filaTotales["PREGOT"] = Math.Round(Tpregot, 2);
                filaTotales["SALDO"] = Math.Round(total, 2);

                maestro.Rows.Add(filaTotales);
                DataView dv = new DataView(maestro);
                dv.RowFilter = "SALDO<>0";
                //maestro.DefaultView.RowFilter = "SALDO<>0";




                DG_reporte.DataSource = dv;

                DG_reporte.Columns[1].Width = 350;
                DG_reporte.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_reporte.Columns[2].DefaultCellStyle.Format = "C2";
                DG_reporte.Columns[3].DefaultCellStyle.Format = "C2";
                DG_reporte.Columns[4].DefaultCellStyle.Format = "C2";
                DG_reporte.Columns[5].DefaultCellStyle.Format = "C2";
                DG_reporte.Columns[6].DefaultCellStyle.Format = "C2";
                DG_reporte.Columns[7].DefaultCellStyle.Format = "C2";
                DG_reporte.Columns[8].DefaultCellStyle.Format = "C2";

                DG_reporte.Columns["PROVEEDOR"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["NOMBRE"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["BODEGA"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["VALLARTA"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["RENA"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["COLOSO"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["VELAZQUEZ"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["PREGOT"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_reporte.Columns["SALDO"].SortMode = DataGridViewColumnSortMode.NotSortable;

            }

           

           


        }


    

        private void BT_saldos_Click(object sender, EventArgs e)
        {
            

            if (CHK_saldo.Checked == true)
            {
                SaldosMayoresACero();
               
            }
            else
            {
                Saldos();
               
            }
           




        }

        private void button1_Click(object sender, EventArgs e)
        {

          



        }

        

        private void RPT_SaldoProveedores_Load(object sender, EventArgs e)
        {
            //Proveedores();
            maestro.Columns.Add("PROVEEDOR", typeof(string));
            maestro.Columns.Add("NOMBRE", typeof(string));
            maestro.Columns.Add("BODEGA", typeof(double));
            maestro.Columns.Add("VALLARTA", typeof(double));
            maestro.Columns.Add("RENA", typeof(double));
            maestro.Columns.Add("COLOSO", typeof(double));
            maestro.Columns.Add("VELAZQUEZ", typeof(double));
            maestro.Columns.Add("PREGOT", typeof(double));
            maestro.Columns.Add("SALDO", typeof(double));
            CHK_saldo.Checked = true;
            if (area.Equals("CXPAGAR"))
            {
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Reporte en excel
            ReporteExcel();
        }

        private void BT_reporte_Click(object sender, EventArgs e)
        {
          


        }

        private void BT_pdf_Click(object sender, EventArgs e)
        {
            ReportePDF();
        }

        private void CHK_fecha_CheckedChanged(object sender, EventArgs e)
        {

        }
    }//FIN CLASE




    public partial class HeaderFooter : PdfPageEventHelper
    {
        

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            Singleton s = Singleton.obtenerInstancia();
            string sucursal = s.getNombreTienda();


      

            //base.OnEndPage(writer, document);


            DateTime fecha = DateTime.Today;
            PdfPTable tbHeader = new PdfPTable(1);
            tbHeader.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
            tbHeader.DefaultCell.Border = 0;

            tbHeader.AddCell(new Paragraph());


            PdfPCell _cell = new PdfPCell(new Paragraph("RESUMEN DE CUENTAS POR PAGAR AL DIA " + fecha.ToString("dd/MM/yyyy                    ")+  sucursal));
           
            _cell.Border = 0;
            _cell.PaddingTop = 10;
            _cell.PaddingBottom = 10;
         
            tbHeader.AddCell(_cell);

           
            tbHeader.AddCell(new Paragraph());


            tbHeader.WriteSelectedRows(0, -1, document.LeftMargin, writer.PageSize.GetTop(document.TopMargin) + 25, writer.DirectContent);

            PdfPTable tbFooter = new PdfPTable(1);
            tbFooter.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
            tbFooter.DefaultCell.Border = 0;

            PdfPCell cell = new PdfPCell(new Paragraph());
            tbFooter.AddCell(cell);
           
            cell = new PdfPCell(new Paragraph("Pagina " + writer.PageNumber));
            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            cell.Border = 0;

            tbFooter.AddCell(cell);

            tbFooter.WriteSelectedRows(0, -1, document.LeftMargin, writer.PageSize.GetBottom(document.BottomMargin) - 5, writer.DirectContent);



        }
    }

}//FIN NAMES PACE
