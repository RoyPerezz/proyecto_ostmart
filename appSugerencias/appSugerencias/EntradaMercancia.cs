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
    public partial class EntradaMercancia : Form
    {
        public EntradaMercancia()
        {
            InitializeComponent();
        }


        public void limpiar()
        {
            LB_estado.Text = "";
            TB_usuario.Text = "";
            DG_detalle.DataSource = "";
            DG_entradas.DataSource = "";
            DT_fecha.ResetText();
        }


        public string nombreSuc()
        {
            // obtengo el nombre de la sucursal para el reporte
            string suc = "";

            if (CB_vitrinas.SelectedItem.Equals("RENA"))
            {
                con = BDConexicon.V_rena();
            }

            if (CB_vitrinas.SelectedItem.Equals("COLOSO"))
            {
                con = BDConexicon.V_coloso();
            }

            if (CB_vitrinas.SelectedItem.Equals("VELAZQUEZ"))
            {
                con = BDConexicon.V_velazquez();
            }

            if (CB_vitrinas.SelectedItem.Equals("VALLARTA"))
            {
                con = BDConexicon.V_vallarta();
            }

            MySqlCommand cmd = new MySqlCommand("select empresa from econfig", con);
            //MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            MySqlDataReader myreader = cmd.ExecuteReader();



            myreader.Read();
            suc = myreader["EMPRESA"].ToString();



            return suc;
        }

        MySqlConnection con = null;
        private void BT_buscar_Click(object sender, EventArgs e)
        {


            TB_usuario.Text = "";
            DG_detalle.DataSource = "";
            if (CB_vitrinas.SelectedIndex==-1)
            {
                MessageBox.Show("Elige una vitrina");
            }
            else
            {
                try
                {
                    if (CB_vitrinas.SelectedItem.Equals("RENA"))
                    {
                        con = BDConexicon.V_rena();
                    }

                    if (CB_vitrinas.SelectedItem.Equals("COLOSO"))
                    {
                        con = BDConexicon.V_coloso();
                    }

                    if (CB_vitrinas.SelectedItem.Equals("VELAZQUEZ"))
                    {
                        con = BDConexicon.V_velazquez();
                    }

                    if (CB_vitrinas.SelectedItem.Equals("VALLARTA"))
                    {
                        con = BDConexicon.V_vallarta();
                    }

                   
                    DateTime f = DT_fecha.Value;

                    MySqlCommand cmd = new MySqlCommand("SELECT Entrada as ENTRADAS from entradas where F_EMISION='" + f.ToString("yyyy-MM-dd") + "'", con);


                    DataTable dt = new DataTable();
                    MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                    ad.Fill(dt);


                    if (dt.Rows.Count==0)
                    {
                        DG_entradas.DataSource = null;
                        LB_estado.ForeColor = Color.Red;
                        LB_estado.Text = "Sin entradas";
                    }
                    else
                    {
                        DG_entradas.DataSource = dt;
                        DG_entradas.Columns[0].Width = 160;
                        LB_estado.Text = "Conectado";
                        LB_estado.ForeColor = Color.Green;
                    }
                  
                }
                catch (Exception ex)
                {
                    LB_estado.ForeColor = Color.Red;
                    LB_estado.Text = "Sin conexión";

                }
            }

           



            

        }

        private void DG_entradas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string usuario = "";
                string entrada = DG_entradas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                MySqlCommand cmd = new MySqlCommand("SELECT articulo as ARTICULO, observ AS PRODUCTO,cantidad AS CANTIDAD,usuario from entpart where entrada='" + entrada + "'", con);
                DataTable dt = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ad.Fill(dt);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    usuario = dr["usuario"].ToString();
                }

                dr.Close();
                TB_usuario.Text = usuario;
                dt.Columns.Remove("usuario");

                DG_detalle.DataSource = dt;
                DG_detalle.Columns[1].Width = 300;
                DG_detalle.Columns[2].Width = 75;
                DG_detalle.Columns[3].Visible = false;
            }
            catch (Exception ex)
            {

               
            }
           
        }

        private void EntradaMercancia_Load(object sender, EventArgs e)
        {

        }

        private void CB_vitrinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            LB_estado.Text = "";
            TB_usuario.Text = "";
            DG_detalle.DataSource = null;
            DG_entradas.DataSource = null;
            DT_fecha.ResetText();
        }

        public void ReporteExcel()
        {
            //Crea reporte en pdf sobre los saldos de los proveedores

            if (DG_detalle.DataSource==null || LB_estado.Text.Equals("Sin entradas"))
            {
                MessageBox.Show("No hay datos que mostrar");
            }
            else
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);
                string sucursal = nombreSuc();
                DateTime fecha = DT_fecha.Value;
                string usuario = TB_usuario.Text;
                excel.Cells.Range["A2:G2"].Merge();
                excel.Cells.Range["A3:G3"].Merge();
                excel.Cells.Range["A2:A2"].Value="REPORTE DE ENTRADA DE MERCANCIA A "+sucursal.ToUpper()+"              "+fecha.ToShortDateString();
                excel.Cells.Range["A2"].Font.Bold = true;
                excel.Cells.Range["A2"].Font.Size = 14;
                excel.Cells.Range["A2"].Interior.ColorIndex = 15;
                excel.Cells.Range["A3"].Interior.ColorIndex = 15;
                excel.Cells.Range["A5:C5"].Interior.ColorIndex = 15;
                excel.Cells.Range["A5:C5"].Font.Bold = true;
                excel.Cells.Range["A3:A3"].Value = "CARGÓ: " + usuario.ToUpper();
                excel.Cells.Range["A3"].Font.Bold = true;
           

                int indiceColumna = 0;

                foreach (DataGridViewColumn col in DG_detalle.Columns)
                {
                    indiceColumna++;
                    excel.Cells[5, indiceColumna] = col.Name;

                }

                int indiceFila = 4;

                foreach (DataGridViewRow row in DG_detalle.Rows)
                {
                    indiceFila++;
                    indiceColumna = 0;




                    foreach (DataGridViewColumn col in DG_detalle.Columns)
                    {
                        indiceColumna++;

                        excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                    }



                }




                excel.Visible = true;
            }

           

        }





        private void button1_Click(object sender, EventArgs e)
        {
            ReporteExcel();
        }
    }
}
