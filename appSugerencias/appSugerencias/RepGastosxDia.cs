using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class RepGastosxDia : Form
    {
        public RepGastosxDia()
        {
            InitializeComponent();
        }

        private void RepGastosxDia_Load(object sender, EventArgs e)
        {
            DG_reporte.Columns["CLAVE"].Width = 70;
            DG_reporte.Columns["HORA"].Width = 80;
            DG_reporte.Columns["IE"].Width = 30;
            DG_reporte.Columns["DESCRIPCION"].Width = 400;
        }


        public string MesRespaldo(int mes)
        {
            string mesRespaldo = "";

            if (mes == 1)
            {
                mesRespaldo = "ENE";
            }
            if (mes == 2)
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

        public string Sucursal()
        {

            string nombre = "";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT EMPRESA FROM ECONFIG", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nombre = dr["EMPRESA"].ToString();
            }
            dr.Close();
            con.Close();

            return nombre;

        }

        public void Reporte()
        {


            if (CHK_respaldo.Checked == true)
            {
                if (CHK_respaldo.Checked == true)
                {

                    string suc = Sucursal();
                    string sucursal = "";

                    if (suc.Equals("OSMART VALLARTA"))
                    {
                        sucursal = "VALLARTA";
                    }

                    if (suc.Equals("OSMART RENACIMIENTO"))
                    {
                        sucursal = "RENA";
                    }

                    if (suc.Equals("OSMART VELAZQUEZ"))
                    {
                        sucursal = "DIEZ";
                    }

                    if (suc.Equals("OSMART COLOSO"))
                    {
                        sucursal = "COLOSO";
                    }

                    if (suc.Equals("PREGOT"))
                    {
                        sucursal = "PREGOT";
                    }



                    int mes = DT_fecha.Value.Month;
                    int año = DT_fecha.Value.Year;

                    string mesRespaldo = MesRespaldo(mes);

                    DG_reporte.Rows.Clear();
                    MySqlConnection con = BDConexicon.Respconectar(sucursal,mesRespaldo,año);
                    DateTime fecha = DT_fecha.Value;
                    double efectivo = 0;
                    double retiro = 0;
                    double disponible = 0;
                    double monto = 0;

                    try
                    {
                        MySqlCommand cmd = new MySqlCommand("SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM" +
                            " flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto where fecha = '" + fecha.ToString("yyyy-MM-dd") + "' AND flujo.concepto<>'CAM' AND flujo.ing_eg = 'E' and flujo.concepto<>'cortz' GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora", con);
                        MySqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            monto = Convert.ToDouble(dr["Importe"].ToString());

                            if (dr["concepto2"].ToString().Equals("Retir"))
                            {
                                efectivo = Convert.ToDouble(dr["Importe"].ToString());
                            }


                            if (dr["concepto2"].ToString().Equals("RPPP") || dr["concepto2"].ToString().Equals("RBAN"))
                            {
                                retiro += Convert.ToDouble(dr["Importe"].ToString());
                            }

                            DateTime f = Convert.ToDateTime(dr["fecha"].ToString());

                            DG_reporte.Rows.Add(dr["concepto2"].ToString(), dr["descrip"].ToString(), monto, dr["IE"].ToString(), f.ToString("dd-MM-yyyy"), dr["hora"].ToString(), dr["usuario"].ToString(), dr["estacion"].ToString());

                        }


                        disponible = efectivo - retiro;
                        double suma = 0;
                        for (int i = 0; i < DG_reporte.Rows.Count; i++)
                        {
                            if (DG_reporte.Rows[i].Cells["CLAVE"].Value.Equals("Retir"))
                            {
                                DG_reporte.Rows[i].Cells["IMPORTE"].Value = disponible;
                            }
                            suma += Convert.ToDouble(DG_reporte.Rows[i].Cells["IMPORTE"].Value);
                        }

                        DG_reporte.Rows.Add("", "GASTOS TOTALES", suma, "", "", "", "", "");

                        dr.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al obtener datos del reporte :" + ex);
                    }
                    DG_reporte.Columns[2].DefaultCellStyle.Format = "C2";
                    con.Close();



                }
                else
                {
                    DG_reporte.Rows.Clear();
                    MySqlConnection con = BDConexicon.conectar();
                    DateTime fecha = DT_fecha.Value;
                    double efectivo = 0;
                    double retiro = 0;
                    double disponible = 0;
                    double monto = 0;

                    try
                    {
                        MySqlCommand cmd = new MySqlCommand("SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM" +
                            " flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto where fecha = '" + fecha.ToString("yyyy-MM-dd") + "' AND flujo.concepto<>'CAM' AND flujo.ing_eg = 'E' and flujo.concepto<>'cortz' GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora", con);
                        MySqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            monto = Convert.ToDouble(dr["Importe"].ToString());

                            if (dr["concepto2"].ToString().Equals("Retir"))
                            {
                                efectivo = Convert.ToDouble(dr["Importe"].ToString());
                            }


                            if (dr["concepto2"].ToString().Equals("RPPP") || dr["concepto2"].ToString().Equals("RBAN"))
                            {
                                retiro += Convert.ToDouble(dr["Importe"].ToString());
                            }

                            DateTime f = Convert.ToDateTime(dr["fecha"].ToString());

                            DG_reporte.Rows.Add(dr["concepto2"].ToString(), dr["descrip"].ToString(), monto, dr["IE"].ToString(), f.ToString("dd-MM-yyyy"), dr["hora"].ToString(), dr["usuario"].ToString(), dr["estacion"].ToString());

                        }


                        disponible = efectivo - retiro;
                        double suma = 0;
                        for (int i = 0; i < DG_reporte.Rows.Count; i++)
                        {
                            if (DG_reporte.Rows[i].Cells["CLAVE"].Value.Equals("Retir"))
                            {
                                DG_reporte.Rows[i].Cells["IMPORTE"].Value = disponible;
                            }
                            suma += Convert.ToDouble(DG_reporte.Rows[i].Cells["IMPORTE"].Value);
                        }

                        DG_reporte.Rows.Add("", "GASTOS TOTALES", suma, "", "", "", "", "");

                        dr.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al obtener datos del reporte :" + ex);
                    }
                    DG_reporte.Columns[2].DefaultCellStyle.Format = "C2";
                    con.Close();
                }


            }
        }

        private void BT_aceptar_Click(object sender, EventArgs e)
        {
            Reporte();
        }

        public void PDF()
        {
            DateTime fecha = DT_fecha.Value;
            try
            {

                Document doc = new Document(PageSize.A4.Rotate());
                string filename = "gastos\\gastoxdia" + fecha.ToString("dd-MM-yyyy")+".pdf";

                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@filename, FileMode.Create));

                //writer.PageEvent = new HeaderFooter();
                


                doc.AddTitle("Gastos por día");
                doc.AddCreator("RoyP3r3z");


                // Abrimos el archivo
                doc.Open();

                iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 4, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);



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
                float[] widths = new float[] { 30f, 90f, 55f, 20f, 55f, 55f, 55f, 55f};
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

                            if (k == 2)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear PDF" + ex);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            PDF();
        }
    }
}
