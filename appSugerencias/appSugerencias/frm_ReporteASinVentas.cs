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

namespace appSugerencias
{
    public partial class frm_ReporteASinVentas : Form
    {
        public frm_ReporteASinVentas()
        {
            InitializeComponent();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            selectDatos(dgASV);
        }

        public void selectDatos(DataGridView grid)
        {


            DateTime Finicio = dtInicio.Value;
            DateTime Ffin = dtFin.Value;

            string inicio = getDate(Finicio);
            string fin = getDate(Ffin);



            MySqlCommand cmd = new MySqlCommand("SELECT RD_sinventas.articulo,RD_sinventas.motivo,RD_sinventas.usuario,prods.DESCRIP,prods.PRECIO1,prods.fabricante,prods.EXISTENCIA FROM RD_sinventas INNER JOIN prods ON prods.ARTICULO=RD_sinventas.articulo where fecha between '" + inicio + "'" + " and '" + fin + "'", BDConexicon.conectar());

            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            System.Data.DataTable tb = new System.Data.DataTable();

            adaptador.Fill(tb);

            grid.DataSource = tb;
            grid.Columns[0].Width = 100;
            grid.Columns[1].Width = 400;
            //grid.RowHeadersWidth = 200;
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



        internal static String getDate(DateTime now)
        {
            String datePatt = @"yyyy-MM-dd";
            String snow = now.ToString(datePatt);
            return snow;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            exportarExcel(dgASV);
        }

        private void frm_ReporteASinVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
