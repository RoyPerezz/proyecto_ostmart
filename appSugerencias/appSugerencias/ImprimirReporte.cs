using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using Microsoft.Office.Interop.Excel;

namespace appSugerencias
{
    public partial class ImprimirReporte : Form
    {
        public ImprimirReporte()
        {
            InitializeComponent();
        }




        public void selectDatos(DataGridView grid)
        {
           

            DateTime Finicio = DT_inicio.Value;
            DateTime Ffin = DT_fin.Value;

            string inicio = getDate(Finicio);
            string fin = getDate(Ffin);

           

            MySqlCommand cmd = new MySqlCommand("select texto as sugerencias,usuario  from sugerencias where fecha between '" + inicio +"'"+" and '"+ fin+"'", frm_Sugerencias.conectar());

            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            System.Data.DataTable tb = new System.Data.DataTable();

            adaptador.Fill(tb);

            grid.DataSource = tb;
        }

        internal static String getDate(DateTime now)
        {
            String datePatt = @"yyyy-MM-dd";
            String snow = now.ToString(datePatt);
            return snow;
        }

        public void exportarExcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);

            int indiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns)
            {
                indiceColumna++;
                excel.Cells[1, indiceColumna] = col.Name;
            }

            int indiceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows)
            {
                indiceFila++;
                indiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    indiceColumna++;
                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;

                }
            }

            excel.Visible = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectDatos(DG_sugerencias);
        }

        private void BT_Excel_Click(object sender, EventArgs e)
        {
            exportarExcel(DG_sugerencias);
        }
    }
}
