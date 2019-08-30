using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace appSugerencias
{
    public partial class Concentrador : Form
    {
        public Concentrador()
        {
            InitializeComponent();
        }

        MySqlConnection conex_buscar;

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbBuscar.Text))
                {
                    MessageBox.Show("Inserte un dato");
                }
                else
                {
                    conex_buscar = BDConexicon.conectar();
                    buscaDatos();
                    conex_buscar.Close();
                }
            }
        }

        public void buscaDatos()
        {
            try
            {
                



                MySqlCommand cmd = new MySqlCommand("SELECT articulo,descrip,existencia,precio1,precio2, linea, marca,fabricante, peso, impuesto, unidad FROM prods  WHERE   articulo  LIKE '%" + tbBuscar.Text + "%' OR descrip LIKE '%" + tbBuscar.Text + "%' ORDER BY existencia DESC", conex_buscar);

                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();



                adaptador.Fill(dt);

                dgvArticulo.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dgvArticulo.Rows.Add();

                    double mayoreo, menudeo;

                    mayoreo= Convert.ToDouble(item["precio1"].ToString());
                    menudeo= Convert.ToDouble(item["precio2"].ToString());

                    dgvArticulo.Rows[n].Cells[0].Value = item["articulo"].ToString();
                    dgvArticulo.Rows[n].Cells[1].Value = item["descrip"].ToString();
                    dgvArticulo.Rows[n].Cells[2].Value = item["existencia"].ToString();

                    if(item["impuesto"].ToString()=="IVA" || item["impuesto"].ToString() == "iva")
                    {
                        mayoreo = mayoreo +(mayoreo * 0.16);
                        menudeo = menudeo +(menudeo * 0.16);
                    }

                    dgvArticulo.Rows[n].Cells[3].Value = mayoreo;
                    dgvArticulo.Rows[n].Cells[4].Value = menudeo;
                    dgvArticulo.Rows[n].Cells[5].Value = item["linea"].ToString();
                    dgvArticulo.Rows[n].Cells[6].Value = item["marca"].ToString();
                    dgvArticulo.Rows[n].Cells[7].Value = item["fabricante"].ToString();
                    dgvArticulo.Rows[n].Cells[8].Value = item["peso"].ToString();
                    dgvArticulo.Rows[n].Cells[9].Value = item["impuesto"].ToString();
                    dgvArticulo.Rows[n].Cells[10].Value = item["unidad"].ToString();

                }

                

            }
            catch (Exception e)
            {

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvArticulo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idTraspaso = dgvArticulo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            int dan = e.RowIndex;
            int dabb = e.ColumnIndex;

            tbArticulo.Text = dgvArticulo.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbDescrip.Text = dgvArticulo.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbMenudeo.Text = dgvArticulo.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbMayoreo.Text = dgvArticulo.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbLinea.Text = dgvArticulo.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbMarca.Text = dgvArticulo.Rows[e.RowIndex].Cells[6].Value.ToString();
            tbFabricante.Text = dgvArticulo.Rows[e.RowIndex].Cells[7].Value.ToString();
            tbPresentacion.Text = dgvArticulo.Rows[e.RowIndex].Cells[8].Value.ToString();
            tbImpuesto.Text = dgvArticulo.Rows[e.RowIndex].Cells[9].Value.ToString();
            tbUnidad.Text = dgvArticulo.Rows[e.RowIndex].Cells[10].Value.ToString();
            //MessageBox.Show(dan.ToString()+ " + " + dabb.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbArticulo.Text))
            {
                MessageBox.Show("Seleccione un Articulo");

            }
            else
            {
                guardaVallarta();

            }
        }

        public void guardaVallarta()
        {
            MySqlConnection con = BDConexicon.VallartaOpen();
            //try
            //{

            //    double Precio1 = Convert.ToDouble(tbPrecio1.Text);
            //    double Precio2 = Convert.ToDouble(tbPrecio2.Text);
            //    Precio1 = Precio1 / 1.16;
            //    Precio2 = Precio2 / 1.16;


            //    MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET precio1=?precio1,precio2=?precio2  WHERE articulo=?articulo", con);
            //    cmdoo.Parameters.Add("?precio1", MySqlDbType.VarChar).Value = Precio1;
            //    cmdoo.Parameters.Add("?precio2", MySqlDbType.VarChar).Value = Precio2;
            //    cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
            //    MySqlDataReader mdrr;
            //    mdrr = cmdoo.ExecuteReader();
            //    mdrr.Close();


            //    //lblVaPre.Text = "OK";
            //    //lblVaPre.ForeColor = Color.DarkGreen;

            //}
            //catch (Exception e)
            //{
            //    //lblVaPre.Text = "N/A";
            //    //lblVaPre.ForeColor = Color.Red;
            //}
            //BDConexicon.VallartaClose();
        }

      }


}
