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



        public void llenarGrid(MySqlConnection con)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT  p.proveedor AS PROVEEDOR,p.nombre AS NOMBRE,sum(cp.saldo) as SALDO from proveed p inner join cuenxpag cp on p.proveedor = cp.proveedor GROUP BY p.PROVEEDOR",con);
            DataTable dt = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ad.Fill(dt);

            DG_reporte.DataSource = dt;

            DG_reporte.Columns[0].Width = 80;
            DG_reporte.Columns[1].Width = 300;
            DG_reporte.Columns[2].Width = 140;
            DG_reporte.Columns["SALDO"].DefaultCellStyle.Format = "$##,##0.00";


        }

        private void button1_Click(object sender, EventArgs e)
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




        }//FIN METODO BOTON

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

                llenarGrid(con);
                LB_estado.Text = "Conectado";
                LB_estado.ForeColor = Color.DarkGreen;
            }
            catch (Exception ex)
            {

                LB_estado.Text = "Sin conexión";
                LB_estado.ForeColor = Color.Red;
            }
           
        }

        private void RPT_SaldoProveedores_Load(object sender, EventArgs e)
        {
          
        }
    }//FIN CLASE
}//FIN NAMES PACE
