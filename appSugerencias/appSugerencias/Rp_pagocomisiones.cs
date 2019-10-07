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
    public partial class Rp_pagocomisiones : Form
    {
        public Rp_pagocomisiones()
        {
            InitializeComponent();
        }


        public void datos()
        {

            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            MySqlCommand cmd = new MySqlCommand("select usuario, fecha_ini, fecha_fin,total_semana as semana,extra as incentivo_extra,pagar_total as total from rd_pagocomisiones where fecha_ini and fecha_fin between '" + inicio.ToString("yyyy-MM-dd") + "'" + " and '" + fin.ToString("yyyy-MM-dd") + "'",BDConexicon.conectar());
            DataTable dt = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ad.Fill(dt);
            tabla.DataSource = dt;
        }


        public void formatoExcel(Microsoft.Office.Interop.Excel.Application excel)
        {
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            excel.Cells.Range["A4:F4"].Merge();
            excel.Cells.Range["A4:F4"].Value = "Pago comisiones correspondiente del  " + inicio.ToString("dd-MM-yyyy") + "   al   " + fin.ToString("dd-MM-yyyy");
            excel.Cells.Range["A4:F4"].Font.Bold = true;
            excel.Cells.Range["A5:F5"].Interior.ColorIndex = 49;
            excel.Cells.Range["A5:F5"].Font.ColorIndex = 2;
            excel.Cells.Range["A5:F5"].Font.Bold = true;
            excel.Cells.Range["E:E"].ColumnWidth = 14.14;
           
        }

        public void exportarExcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);

            formatoExcel(excel);


            int indiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in tabla.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;

                    //if ((indiceFila + 1) % 2 == 0)// pinta de color gris las celdas cuyas filas son numeros pares
                    //{
                    //    excel.Cells.Range[indiceFila + 1, indiceColumna].Interior.ColorIndex = 15;

                    //}




                }



            }
           
            excel.Visible = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            datos();
            exportarExcel(tabla);
        }

        private void Rp_pagocomisiones_Load(object sender, EventArgs e)
        {

        }
    }
}
