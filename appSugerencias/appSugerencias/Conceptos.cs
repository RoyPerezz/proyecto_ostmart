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
    public partial class Conceptos : Form
    {
        public Conceptos()
        {
            InitializeComponent();
        }





        public void Exportar(String mensaje)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            excel.Range["B1:B1"].Value = mensaje;
            int indiceColumna = 0;

            foreach (DataGridViewColumn col in DG_conceptos.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in DG_conceptos.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in DG_conceptos.Columns)
                {
                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;

                }

            }

            excel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = BDConexicon.conectar();



            if (CB_concepto.SelectedItem.ToString().Equals("EGRESOS"))
            {
                MySqlCommand cmd = new MySqlCommand("Select concepto, descrip,usufecha from conegre", con);
                DataTable dt = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ad.Fill(dt);
                DG_conceptos.DataSource = dt;
                Exportar("CONCEPTOS DE EGRESOS VALLARTA");
            }

            if (CB_concepto.SelectedItem.ToString().Equals("INGRESOS"))
            {
                MySqlCommand cmd = new MySqlCommand("Select concepto, descrip, usufecha from coningre", con);
                DataTable dt = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ad.Fill(dt);
                DG_conceptos.DataSource = dt;
                Exportar("CONCEPTOS DE INGRESOS VALLARTA");
            }


          
            con.Close();
        }

        private void Conceptos_Load(object sender, EventArgs e)
        {

        }
    }
}
