using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

using System.Runtime.InteropServices;

namespace appSugerencias
{
    public partial class ReporteComisiones : Form
    {
        public ReporteComisiones()
        {
            InitializeComponent();
        }


        public static String getDate(DateTime now)
        {
            String datePatt = @"yyyy-MM-dd";
            String snow = now.ToString(datePatt);
            return snow;
        }

      

        private void BT_reporte_Click(object sender, EventArgs e)
        {



            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;

            string finicio = getDate(inicio);
            string ffin = getDate(fin);

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            // Encabezado y nombre de las columnas
            MySqlCommand cmd = new MySqlCommand("select distinct fecha from pr_comisiones where fecha between '" + inicio.ToString("yyyy-MM-dd") + "'" + " and '" + fin.ToString("yyyy-MM-dd") + "'", BDConexicon.conectar());
            MySqlDataReader rd = cmd.ExecuteReader();

            excel.Cells.Range["A3:J3"].Merge();
            excel.Cells.Range["A3:J3"].Value = "Comision de Cajeras correspondiente del " + finicio + " al " + ffin;
            excel.Cells.Range["A:J"].ColumnWidth = 22.51;
            excel.Cells.Range["A4"].Value = "CAJERAS";
            int i = 2;
            while (rd.Read())
            {

                excel.Cells.Range[4, i].Value = rd[0].ToString();

                i++;
            }
            rd.Close();

            // Fin de Encabezado y nombre de las columnas


            // Nombres de los usuarios
            MySqlCommand com = new MySqlCommand("select distinct usuario from pr_comisiones order by usuario", BDConexicon.conectar());
            MySqlDataReader rd2 = com.ExecuteReader();

            int j = 5;
            while (rd2.Read())
            {
                excel.Cells.Range[j, 1].Value = rd2[0].ToString();
                j++;
            }
            // Fin de nombres de los usuarios

            MySqlCommand com2 = new MySqlCommand("select comision from pr_comisiones order by usuario", BDConexicon.conectar());
            MySqlDataReader rd3 = com2.ExecuteReader();

            int x = 2;
            int y = 5;
            int count = 0;
            while (rd3.Read())
            {
                count++;

                excel.Cells.Range[y, x].Value = rd3[0].ToString();
                if (count == 4)
                {
                    y++;
                    x = 1;
                    count = 0;
                }
                x++;

            }

            excel.Visible = true;
        }

        private void ReporteComisiones_Load(object sender, EventArgs e)
        {

        }
    }
}
