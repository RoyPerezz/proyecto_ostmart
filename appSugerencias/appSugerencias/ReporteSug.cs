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
    public partial class ReporteSug : Form
    {
        public ReporteSug()
        {
            InitializeComponent();
        }

        private void ReporteSug_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlConnection con = BDConexicon.conectar();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT cajera,sugerencia FROM rd_sugerencias WHERE fecha BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "'and '" + fin.ToString("yyyy-MM-dd") + "'", con);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ad.Fill(dt);
            DG_sugerencias.DataSource = dt;

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            excel.Cells.Range["A3:A3"].Value = "SUGERENCIAS DEL " + inicio.ToString("dd-MM-yyyy") + " al " + fin.ToString("dd-MM-yyyy");
            int indiceColumna = 0;

            foreach (DataGridViewColumn col in DG_sugerencias.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in DG_sugerencias.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in DG_sugerencias.Columns)
                {
                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;

                }

            }

            excel.Visible = true;
        }
    }
}
