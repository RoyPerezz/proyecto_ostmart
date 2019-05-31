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
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;

namespace appSugerencias
{

   
    public partial class RPT_SaldoProveedores : Form
    {

        

        public RPT_SaldoProveedores()
        {
            InitializeComponent();
        }

        public string suc;

        public string getSucursal()
        {
            return suc;
        }
       
        public void sucursal(MySqlConnection con)
        {
            try
            {
                
               MySqlCommand cmd = new MySqlCommand("select empresa from econfig", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    suc = dr["empresa"].ToString();
                    TB_suc.Text = dr["empresa"].ToString();
                }
                Singleton s = Singleton.obtenerInstancia();
                s.nombreTienda(suc);
                dr.Close();

                

            }
            catch (Exception ex)
            {

                MessageBox.Show("falló traer el nombre de la empresa");
            }

          
        }



        public void llenarGrid(MySqlConnection con)
        {

            MySqlCommand cmd = null; //saldos
            MySqlCommand cmd2 = null;//fechas
            if (CHB_saldo.Checked == true)
            {
                //Si el checkbox CHB_saldo ha sido marcado, ejecutara esta consulta, obteniendo solo los provedores con saldo positivo
                cmd = new MySqlCommand("SELECT  p.proveedor AS PROVEEDOR,p.nombre AS NOMBRE,sum(cp.saldo) as SALDO from proveed p inner join cuenxpag cp on p.proveedor = cp.proveedor GROUP BY p.PROVEEDOR having SALDO > 0 order by PROVEEDOR", con);
            }
            else
            {
                //Si no, ejecutará esta otram trayendo todos los proveedores
                cmd = new MySqlCommand("SELECT  p.proveedor AS PROVEEDOR,p.nombre AS NOMBRE,sum(cp.saldo) as SALDO from proveed p inner join cuenxpag cp on p.proveedor = cp.proveedor GROUP BY p.PROVEEDOR order by PROVEEDOR", con);
            }

            DataTable dt = new DataTable();
            //dt.Columns[2].DataType = Double;
            DataRow fila = dt.NewRow();





            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ad.Fill(dt);




            if (CHB_saldo.Checked == true)
            {
                //Se obtiene la fecha del ultimo moviento en las cuentas pendientes sin saldo negativo
                cmd2 = new MySqlCommand("select max(pd.fecha) as FECHA,p.proveedor from cuenxpdet pd inner join CUENXPAG p on pd.proveedor = p.PROVEEDOR GROUP BY p.PROVEEDOR  having sum(p.saldo)>0 order by p.PROVEEDOR ", con);
            }
            else
            {
                //se obtiene todas las fechas de los ultimos mov de cada proveedor
                cmd2 = new MySqlCommand("select max(pd.fecha) as FECHA from cuenxpdet pd inner join proveed p on pd.proveedor = p.PROVEEDOR GROUP BY p.PROVEEDOR order by p.PROVEEDOR ", con);
            }


            
            MySqlDataReader d = cmd.ExecuteReader();//datareader para obtener los proveedores con su saldo




            DateTime fecha;


            DG_reporte.DataSource = dt;
            dt.Columns.Remove("SALDO");
            dt.Columns.Add("FECHA", typeof(string));
            dt.Columns.Add("SALDO PROVEEDOR", typeof(string));
            string saldo = "";
            foreach (DataRow row in dt.Rows)
            {
                if (d.Read())
                {

                    double s = Convert.ToDouble(d["SALDO"].ToString());

                    row[3] = saldo = String.Format("{0:C}", s);


                }
             
            }
            d.Close();

            MySqlDataReader dr = cmd2.ExecuteReader();
            foreach (DataRow row in dt.Rows)
            {
                if (dr.Read())
                {
                    fecha = Convert.ToDateTime(dr["FECHA"].ToString());
                    row[2] = fecha.ToString("dd/MM/yyyy");
                    


                }

            }
            dr.Close();

            DG_reporte.Columns[0].Width = 80;
            DG_reporte.Columns[1].Width = 300;
            DG_reporte.Columns[2].Width = 100;
          //  DG_reporte.Columns[2].DefaultCellStyle.Format = "$##,##0.00";

            //DG_reporte.Columns[0].HeaderCell.Style.BackColor = Color.LightGray;
            //DG_reporte.Columns[1].HeaderCell.Style.BackColor = Color.LightGray;
            //DG_reporte.Columns[2].HeaderCell.Style.BackColor = Color.LightGray;
            //DG_reporte.Columns[3].HeaderCell.Style.BackColor = Color.LightGray;


           

            con.Close();
        }


        public void ReporteExcel()
        {
            //Crea reporte en pdf sobre los saldos de los proveedores

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);



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
         
            Document doc = new Document(PageSize.A4);
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
            float[] widths = new float[] { 40f, 110f, 30f, 45f };
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
               
              
            for (int i = 0; i < DG_reporte.Rows.Count; i++)
            {
                for (int k = 0; k < DG_reporte.Columns.Count; k++)
                {
                       

                    if (DG_reporte[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(DG_reporte[k, i].Value.ToString()));
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
           










        private void button1_Click(object sender, EventArgs e)
        {

            ReportePDF();



        }

        private void CB_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            LB_estado.Text = "";
            DG_reporte.DataSource = null;
            try
            {
                MySqlConnection con = null;
                if (CB_sucursal.SelectedItem.Equals("BODEGA"))
                {
                    con = BDConexicon.BodegaOpen();
                }
                else if (CB_sucursal.SelectedItem.Equals("COLOSO"))
                {
                    con = BDConexicon.ColosoOpen();
                }
                else if (CB_sucursal.SelectedItem.Equals("RENA"))
                {
                    con = BDConexicon.RenaOpen();

                }
                else if (CB_sucursal.SelectedItem.Equals("VALLARTA"))
                {
                    con = BDConexicon.VallartaOpen();

                }
                else if (CB_sucursal.SelectedItem.Equals("VELAZQUEZ"))
                {
                    con = BDConexicon.VelazquezOpen();
                }
               sucursal(con);//mmm a ver, pon un breack point en esta linea, y al crear el objeto checa si esta linea se ejecuta
           
              
                llenarGrid(con);
                
                LB_estado.Text = "Conectado";
                LB_estado.ForeColor = Color.DarkGreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("  "+ex);
                LB_estado.Text = "Sin conexión";
                LB_estado.ForeColor = Color.Red;
            }
           
        }

        private void RPT_SaldoProveedores_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Reporte en excel
            ReporteExcel();
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
