using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;

namespace appSugerencias
{
    public partial class ReporteTraspaso : Form
    {
        public ReporteTraspaso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id, usuario, fecha_sol,fecha_apli,origen,destino,motivo,observaciones,estatus;
            id = "1250";
            usuario = "SISTEMAS";
            origen = "VALLARTA";
            destino = "VELAZQUEZ";
            fecha_sol = "31/01/2019";
            fecha_apli = "1/02/2019";
            motivo = "SE ENVIA PARA CLIENTE QUE NECESITA EN TIENDA, ADEMAS DE QUE ESTO ES UNA PRUEBA, DAN QUIERE QUE LE PAGUEN EL MODULO DE CONSULTA Y TRAPSASPS";
            observaciones = "VAN 2 MATERIALES DAÑADOS";
            estatus = "APLICADA";
            try
            {
                Document doc = new Document(PageSize.A4);
                string filename = "TraspasosPDF\\prueba.pdf";
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@filename, FileMode.Create));

                doc.AddTitle("Prueba DaNxD");
                doc.AddCreator("DaN");

                // Abrimos el archivo
                doc.Open();

                iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                //######################################## ENCABEZADO ################################################################
               
                // Escribimos el encabezamiento en el documento
                Paragraph parrafoEnc = new Paragraph();
                parrafoEnc.Alignment = Element.ALIGN_CENTER;
                //parrafoEnc.Font = FontFactory.GetFont("Arial",14);
                parrafoEnc.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD,16);

                Paragraph parrafo = new Paragraph();
                //parrafoEnc.Alignment = Element.ALIGN_CENTER;
                //parrafoEnc.Font = FontFactory.GetFont("Arial", 14);
                var normal = FontFactory.GetFont(FontFactory.HELVETICA,10);
                var negritas = FontFactory.GetFont(FontFactory.HELVETICA_BOLD,12);


            
                parrafoEnc.Add("Traspaso de " + origen + " N. " + id);
                doc.Add(parrafoEnc);
                parrafoEnc.Clear();

                doc.Add(Chunk.NEWLINE);
                doc.Add(Chunk.NEWLINE);

                parrafo.Add(new Chunk("ID Traspaso: ",negritas));
                parrafo.Add(new Chunk(id, normal));
                doc.Add(parrafo);

                parrafo.Clear();


                parrafo.Add(new Chunk("Fecha de Creacion: ", negritas));
                parrafo.Add(new Chunk(fecha_sol, normal));
                doc.Add(parrafo);

                parrafo.Clear();

                parrafo.Add(new Chunk("Solicito: ", negritas));
                parrafo.Add(new Chunk(usuario, normal));
                doc.Add(parrafo);

                parrafo.Clear();

                parrafo.Add(new Chunk("Origen: ", negritas));
                parrafo.Add(new Chunk(origen, normal));

                parrafo.Add("         ");
                parrafo.Add(new Chunk("Destino: ", negritas));
                parrafo.Add(new Chunk(destino, normal));

                doc.Add(parrafo);

                parrafo.Clear();

                parrafo.Add(new Chunk("Motivo: ", negritas));
                parrafo.Add(new Chunk(motivo, normal));
                doc.Add(parrafo);

                parrafo.Clear();

                parrafo.Add(new Chunk("Estado: ", negritas));
                parrafo.Add(new Chunk(estatus, normal));
                doc.Add(parrafo);

                parrafo.Clear();

                doc.Add(Chunk.NEWLINE);
                doc.Add(Chunk.NEWLINE);

                parrafoEnc.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                parrafoEnc.Add("ARTICULOS DEL TRASPASO");
                doc.Add(parrafoEnc);

             
               

                //parrafo.Font = FontFactory.GetFont("Arial", 10);
                //doc.Add(Chunk.NEWLINE);
                ////parrafo.Add(new Chunk( " Envia a ",negritas));
                ////doc.Add(parrafo);


                ////doc.Add(Chunk.NEWLINE);
                //parrafo.Add(new Chunk(" Id Traspaso :", negritas));
                //doc.Add(parrafo);
                //parrafo.Clear();

                //parrafo.Add(id);
                //doc.Add(parrafo);
                //parrafo.Clear();


                // PRUEBA DAN
                //PdfPTable table = new PdfPTable(dgvItem.Columns.Count);
                PdfPTable table = new PdfPTable(3);

                table.WidthPercentage = 100;
                float[] widths = new float[] { 30f, 100f, 30f };
                table.SetWidths(widths);
                table.SkipLastFooter = true;
                table.SpacingAfter = 10;


                ////Encabezados
                //for (int j = 0; j < dgvItem.Columns.Count; j++)
                //{
                //    table.AddCell(new Phrase(dgvItem.Columns[j].HeaderText));

                //}

                ////flag the first row as a header
                //table.HeaderRows = 1;

                //for (int i = 0; i < dgvItem.Rows.Count; i++)
                //{
                //    for (int k = 0; k < dgvItem.Rows.Count; k++)
                //    {
                //        if (dgvItem[k, i].Value != null)
                //        {
                //            table.AddCell(new Phrase(dgvItem[k, i].Value.ToString()));
                //        }
                //    }
                //}

                //doc.Add(table);
                //Creamos una tabla que contendrá el nombre, apellido y país
                //de nuestros visitante.
                PdfPTable tblPrueba = new PdfPTable(3);
                tblPrueba.WidthPercentage = 100;

                // Configuramos el título de las columnas de la tabla
                PdfPCell clNombre = new PdfPCell(new Phrase("Nombre", _standardFont));
                clNombre.BorderWidth = 0;
                clNombre.BorderWidthBottom = 0.75f;

                PdfPCell clApellido = new PdfPCell(new Phrase("Apellido", _standardFont));
                clApellido.BorderWidth = 0;
                clApellido.BorderWidthBottom = 0.75f;

                PdfPCell clPais = new PdfPCell(new Phrase("País", _standardFont));
                clPais.BorderWidth = 0;
                clPais.BorderWidthBottom = 0.75f;

                // Añadimos las celdas a la tabla
                tblPrueba.AddCell(clNombre);
                tblPrueba.AddCell(clApellido);
                tblPrueba.AddCell(clPais);

                // Llenamos la tabla con información
                clNombre = new PdfPCell(new Phrase("Roberto", _standardFont));
                clNombre.BorderWidth = 0;

                clApellido = new PdfPCell(new Phrase("Torres", _standardFont));
                clApellido.BorderWidth = 0;

                clPais = new PdfPCell(new Phrase("Puerto Rico", _standardFont));
                clPais.BorderWidth = 0;

                // Añadimos las celdas a la tabla
                tblPrueba.AddCell(clNombre);
                tblPrueba.AddCell(clApellido);
                tblPrueba.AddCell(clPais);

                doc.Add(tblPrueba);

                doc.Close();
                writer.Close();

                Process prc = new System.Diagnostics.Process();
                prc.StartInfo.FileName = filename;
                prc.Start();
            }
            catch(Exception ex){

                MessageBox.Show("Puede tener abierto el archivo PDF");
            }

        }
    }
}
