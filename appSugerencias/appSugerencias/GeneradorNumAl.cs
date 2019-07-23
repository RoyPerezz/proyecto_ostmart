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
    public partial class GeneradorNumAl : Form
    {
        public GeneradorNumAl()
        {
            InitializeComponent();
        }


        public void Validar()
        {

        }

        private void BT_Generar_Click(object sender, EventArgs e)
        {
            DG_numeros.Rows.Clear();
            Random rnd = new Random();
            int num = Convert.ToInt32(TB_cantidad.Text);
            for (int i = 0; i < num; i++)
            {
                int numero = rnd.Next(100000, 999999);
                DG_numeros.Rows.Add(Convert.ToString(numero));
            }

           

        }

        
        

        private void TB_exportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            excel.Range["A1:A1000"].NumberFormat = "@";
            int indiceColumna = 0;

            foreach (DataGridViewColumn col in DG_numeros.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in DG_numeros.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in DG_numeros.Columns)
                {
                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                }



            }




            excel.Visible = true;
        }

        private void BT_productos_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
        }
    }
    
}
