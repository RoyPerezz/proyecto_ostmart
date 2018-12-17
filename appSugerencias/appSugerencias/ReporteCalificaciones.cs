using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class ReporteCalificaciones : Form
    {


        int contador = 0;

        public ReporteCalificaciones()
        {
            InitializeComponent();
        }

        private void ReporteCalificaciones_Load(object sender, EventArgs e)
        {

        }

        private void BT_reporte_Click(object sender, EventArgs e)
        {
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;

            //TimeSpan t = fin - inicio;

            //int dias = t.Days;

            string finicio = FormatoFecha.getDate(inicio);
            string ffin = FormatoFecha.getDate(fin);

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            // Encabezado y nombre de las columnas
            MySqlCommand cmd = new MySqlCommand("select distinct fecha from rd_comisiones where fecha between '" + inicio.ToString("yyyy-MM-dd") + "'" + " and '" + fin.ToString("yyyy-MM-dd") + "'", BDConexicon.conectar());
            MySqlDataReader rd = cmd.ExecuteReader();
           
            excel.Cells.Range["A3:J3"].Merge();
            excel.Cells.Range["A3"].Font.Bold = true;
            excel.Cells.Range["A3:J3"].Value = "Comision de Cajeras correspondiente del   " + inicio.ToShortDateString() + " al    " + fin.ToShortDateString();
            excel.Cells.Range["A:J"].ColumnWidth = 13.57;
            excel.Cells.Range["A4"].Value = "CAJERAS";
            excel.Cells.Range["A4:H4"].Interior.ColorIndex = 49;
            excel.Cells.Range["A4:H4"].Font.ColorIndex = 2;
            excel.Cells.Range["A4:H4"].Font.Bold = true;
            int i = 2;
            while (rd.Read())
            {
                DateTime fecha =Convert.ToDateTime( rd[0].ToString());
                string f = FormatoFecha.getDate(fecha);
                excel.Cells[4, i] =f ;
              

                i++;
            }
            rd.Close();

            // Fin de Encabezado y nombre de las columnas


            // Nombres de los usuarios
            MySqlCommand com = new MySqlCommand("select distinct usuario from rd_comisiones order by usuario", BDConexicon.conectar());
            MySqlDataReader rd2 = com.ExecuteReader();

            int j = 5;
            while (rd2.Read())
            {
                excel.Cells[j, 1] = rd2[0].ToString();
                j++;
            }
            // Fin de nombres de los usuarios

            MySqlCommand com2 = new MySqlCommand("select Ctotal from rd_comisiones where fecha between '" + inicio.ToString("yyyy-MM-dd") + "'" + " and '" + fin.ToString("yyyy-MM-dd")+"' order by usuario", BDConexicon.conectar());
            MySqlDataReader rd3 = com2.ExecuteReader();

            int x = 2;
            int y = 5;
            int count = 0;
            while (rd3.Read())
            {
                count++;

                excel.Cells[y, x] = rd3[0].ToString();
                if (count == 7)
                {
                    y++;
                    x = 1;
                    count = 0;
                }
                x++;

            }

            excel.Visible = true;
        }
    }
}
