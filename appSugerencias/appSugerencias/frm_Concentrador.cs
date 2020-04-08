using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.OleDb;



namespace appSugerencias
{
    public partial class Concentrador : Form
    {
        public Concentrador()
        {
            InitializeComponent();
        }
        double IVA = 1.16;
        MySqlConnection conex_buscar;
        MySqlConnection conex_guardar;
        MySqlConnection conex_excel;

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


                limpiaTiendas();

                MySqlCommand cmd = new MySqlCommand("SELECT articulo,descrip,costo_u,existencia,precio1,precio2, linea, marca,fabricante, peso, impuesto, unidad FROM prods  WHERE   articulo  LIKE '%" + tbBuscar.Text + "%' OR descrip LIKE '%" + tbBuscar.Text + "%' ORDER BY existencia DESC", conex_buscar);

                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();



                adaptador.Fill(dt);

                dgvArticulo.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dgvArticulo.Rows.Add();

                    double costo,mayoreo, menudeo;

                    menudeo= Convert.ToDouble(item["precio1"].ToString());
                    mayoreo= Convert.ToDouble(item["precio2"].ToString());
                    costo = Convert.ToDouble(item["costo_u"].ToString());

                    dgvArticulo.Rows[n].Cells[0].Value = item["articulo"].ToString();
                    dgvArticulo.Rows[n].Cells[1].Value = item["descrip"].ToString();
                    dgvArticulo.Rows[n].Cells[2].Value = item["existencia"].ToString();

                    if(item["impuesto"].ToString()!="SYS" || item["impuesto"].ToString() != "sys")
                    {
                        mayoreo = mayoreo +(mayoreo * 0.16);
                        menudeo = menudeo +(menudeo * 0.16);
                        costo = costo + (costo * 0.16);

                    }
                    dgvArticulo.Rows[n].Cells[3].Value = costo;
                    dgvArticulo.Rows[n].Cells[4].Value = mayoreo;
                    dgvArticulo.Rows[n].Cells[5].Value = menudeo;
                    dgvArticulo.Rows[n].Cells[6].Value = item["linea"].ToString();
                    dgvArticulo.Rows[n].Cells[7].Value = item["marca"].ToString();
                    dgvArticulo.Rows[n].Cells[8].Value = item["fabricante"].ToString();
                    dgvArticulo.Rows[n].Cells[9].Value = item["peso"].ToString();
                    dgvArticulo.Rows[n].Cells[10].Value = item["impuesto"].ToString();
                    dgvArticulo.Rows[n].Cells[11].Value = item["unidad"].ToString();

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

        private void dgvArticulo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idTraspaso = dgvArticulo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            int dan = e.RowIndex;
            int dabb = e.ColumnIndex;

            tbArticulo.Text = dgvArticulo.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbDescrip.Text = dgvArticulo.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbCosto.Text = dgvArticulo.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbMenudeo.Text = dgvArticulo.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbMayoreo.Text = dgvArticulo.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbLinea.Text = dgvArticulo.Rows[e.RowIndex].Cells[6].Value.ToString();
            tbMarca.Text = dgvArticulo.Rows[e.RowIndex].Cells[7].Value.ToString();
            tbFabricante.Text = dgvArticulo.Rows[e.RowIndex].Cells[8].Value.ToString();
            tbPresentacion.Text = dgvArticulo.Rows[e.RowIndex].Cells[9].Value.ToString();
            tbImpuesto.Text = dgvArticulo.Rows[e.RowIndex].Cells[10].Value.ToString();
            tbUnidad.Text = dgvArticulo.Rows[e.RowIndex].Cells[11].Value.ToString();
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
                btGuardar.Enabled = false;
                try
                {
                    conex_guardar = BDConexicon.conectar();
                    actualiza();
                    conex_guardar.Close();

                    lblBo.Text = "OK";
                    lblBo.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {
                    lblBo.Text = "NA";
                    lblBo.ForeColor = Color.Red;

                }

                try
                {
                    conex_guardar = BDConexicon.VallartaOpen();
                    actualiza();
                    conex_guardar.Close();

                    lblVa.Text = "OK";
                    lblVa.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {
                    lblVa.Text = "NA";
                    lblVa.ForeColor = Color.Red;

                }

                try
                {
                    conex_guardar = BDConexicon.RenaOpen();
                    actualiza();
                    conex_guardar.Close();

                    lblRe.Text = "OK";
                    lblRe.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {
                    lblRe.Text = "NA";
                    lblRe.ForeColor = Color.Red;

                }

                try
                {

                    conex_guardar = BDConexicon.ColosoOpen();
                    actualiza();
                    conex_guardar.Close();

                   lblCo.Text = "OK";
                    lblCo.ForeColor= Color.DarkGreen;
                }
                catch (Exception ex)
                {
                    lblCo.Text= "NA";
                    lblCo.ForeColor= Color.Red;
                }


                try
                {
                    conex_guardar = BDConexicon.VelazquezOpen();
                    actualiza();
                    conex_guardar.Close();

                    lblVe.Text= "OK";
                    lblVe.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {
                   lblVe.Text = "NA";
                   lblVe.ForeColor = Color.Red;
                }

                try
                {
                    conex_guardar = BDConexicon.Papeleria1Open();
                    actualiza();
                    conex_guardar.Close();

                    lblPre.Text = "OK";
                    lblPre.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {
                    lblPre.Text = "NA";
                    lblPre.ForeColor = Color.Red;
                }

                limpiar();

                btGuardar.Enabled = true;

            }
        }

        public void actualiza()
        {
            string comando;
            
            //try
            //{
                double mayoreo, menudeo, costo;

                mayoreo = Convert.ToDouble(tbMayoreo.Text);
                menudeo = Convert.ToDouble(tbMenudeo.Text);
                costo = Convert.ToDouble(tbCosto.Text);

                if (tbImpuesto.Text!= "SYS" || tbImpuesto.Text != "sys")
                {
                    mayoreo = mayoreo / IVA;
                    menudeo = menudeo / IVA;
                    costo = costo / IVA;

                }

                MySqlCommand cmdart = new MySqlCommand("SELECT ARTICULO FROM prods WHERE ARTICULO ='" + tbArticulo.Text + "'", conex_guardar);
                MySqlDataReader mdrart;
                mdrart = cmdart.ExecuteReader();


                if (mdrart.Read())
                {
                    comando= "UPDATE prods SET descrip=?descrip,costo_u=?costo_u,precio1=?precio1,precio2=?precio2,impuesto=?impuesto,linea=?linea,marca=?marca,fabricante=?fabricante,peso=?peso,unidad=?unidad,paraventa=?paraventa,invent=?invent   WHERE articulo=?articulo";
                }
                else
                {
                    comando = "INSERT INTO  prods (articulo,descrip,costo_u,precio1,precio2,impuesto,linea,marca,fabricante,peso,unidad,invent,paraventa) VALUES (?articulo,?descrip,?costo_u,?precio1,?precio2,?impuesto,?linea,?marca,?fabricante,?peso,?unidad,?invent,?paraventa) ";
                }

                mdrart.Close();

                MySqlCommand cmdoo = new MySqlCommand(comando, conex_guardar);
                
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = tbArticulo.Text;
                cmdoo.Parameters.Add("?descrip", MySqlDbType.VarChar).Value = tbDescrip.Text;

                cmdoo.Parameters.Add("?precio1", MySqlDbType.VarChar).Value = menudeo;
                cmdoo.Parameters.Add("?precio2", MySqlDbType.VarChar).Value = mayoreo;
                cmdoo.Parameters.Add("?costo_u", MySqlDbType.VarChar).Value = costo;
                cmdoo.Parameters.Add("?impuesto", MySqlDbType.VarChar).Value = tbImpuesto.Text;
                cmdoo.Parameters.Add("?linea", MySqlDbType.VarChar).Value = tbLinea.Text;
                cmdoo.Parameters.Add("?marca", MySqlDbType.VarChar).Value = tbMarca.Text;
                cmdoo.Parameters.Add("?fabricante", MySqlDbType.VarChar).Value = tbFabricante.Text;
                cmdoo.Parameters.Add("?peso", MySqlDbType.VarChar).Value = tbPresentacion.Text;
                cmdoo.Parameters.Add("?unidad", MySqlDbType.VarChar).Value = tbUnidad.Text;
                 cmdoo.Parameters.Add("?invent", MySqlDbType.VarChar).Value =1;
                cmdoo.Parameters.Add("?paraventa", MySqlDbType.VarChar).Value = 1;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();

               // MessageBox.Show("Datos con Exito");


                
                //lblVaPre.Text = "OK";
                //lblVaPre.ForeColor = Color.DarkGreen;

            //}
            //catch (Exception e)
            //{
            //    //lblVaPre.Text = "N/A";
            //    //lblVaPre.ForeColor = Color.Red;
            //    MessageBox.Show("Error Al guardar el producto");
            //}
         
        }

        public void limpiar()
        {
            dgvArticulo.Rows.Clear();

            tbArticulo.Text ="";
            tbDescrip.Text = "";
            tbCosto.Text = "";
            tbMayoreo.Text = "";
            tbMenudeo.Text = "";
            tbPresentacion.Text = "";
            tbLinea.Text = "";
            tbMarca.Text = "";
            tbFabricante.Text = "";
            tbImpuesto.Text = "";
            tbUnidad.Text = "";





        }


        public void limpiaTiendas()
        {
            lblBo.Text = "---";
            lblBo.ForeColor = Color.Black;

            lblVa.Text = "---";
            lblVa.ForeColor = Color.Black;

            lblRe.Text = "---";
            lblRe.ForeColor = Color.Black;

            lblCo.Text = "---";
            lblCo.ForeColor = Color.Black;

            lblVe.Text = "---";
            lblVe.ForeColor = Color.Black;


            lblPre.Text = "---";
            lblPre.ForeColor = Color.Black;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNuevo.Checked )
            {
                tbArticulo.Enabled = true;
                tbBuscar.Text = "";
                limpiar();
                limpiaTiendas();
                tbArticulo.Focus();
            }
            else
            {
                tbArticulo.Enabled = false;
                tbBuscar.Focus();
            }
        }

        //public void inserta()
        //{
        //    MySqlConnection con = BDConexicon.VallartaOpen();
        //    try
        //    {
        //        double mayoreo, menudeo, costo;

        //        mayoreo = Convert.ToDouble(tbMayoreo.Text);
        //        menudeo = Convert.ToDouble(tbMenudeo.Text);
        //        costo = Convert.ToDouble(tbCosto.Text);

        //        if (tbImpuesto.Text == "IVA" || tbImpuesto.Text == "iva")
        //        {
        //            mayoreo = mayoreo / 1.16;
        //            menudeo = menudeo / 1.16;
        //            costo = costo / 1.16;

        //        }



        //        MySqlCommand cmdoo = new MySqlCommand("INSERT INTO  prods (articulo,descrip,costo_u,precio1,precio2,impuesto,linea,marca,fabricante,peso,unidad) VALUES (?articulo,?descrip,?costo_u,?precio1,?precio2,?impuesto,?linea,?marca,?fabricante,?peso,?unidad) ", con);
        //        cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = tbArticulo.Text;
        //        cmdoo.Parameters.Add("?descrip", MySqlDbType.VarChar).Value = tbDescrip.Text;

        //        cmdoo.Parameters.Add("?precio1", MySqlDbType.VarChar).Value = menudeo;
        //        cmdoo.Parameters.Add("?precio2", MySqlDbType.VarChar).Value = mayoreo;
        //        cmdoo.Parameters.Add("?costo_u", MySqlDbType.VarChar).Value = costo;
        //        cmdoo.Parameters.Add("?impuesto", MySqlDbType.VarChar).Value = tbImpuesto.Text;
        //        cmdoo.Parameters.Add("?linea", MySqlDbType.VarChar).Value = tbLinea.Text;
        //        cmdoo.Parameters.Add("?marca", MySqlDbType.VarChar).Value = tbMarca.Text;
        //        cmdoo.Parameters.Add("?fabricante", MySqlDbType.VarChar).Value = tbFabricante.Text;
        //        cmdoo.Parameters.Add("?peso", MySqlDbType.VarChar).Value = tbPresentacion.Text;
        //        cmdoo.Parameters.Add("?unidad", MySqlDbType.VarChar).Value = tbUnidad.Text;
        //        MySqlDataReader mdrr;
        //        mdrr = cmdoo.ExecuteReader();
        //        mdrr.Close();

        //        MessageBox.Show("Datos con Exito");


        //        limpiar();
        //        //lblVaPre.Text = "OK";
        //        //lblVaPre.ForeColor = Color.DarkGreen;

        //    }
        //    catch (Exception e)
        //    {
        //        //lblVaPre.Text = "N/A";
        //        //lblVaPre.ForeColor = Color.Red;
        //        MessageBox.Show("Error Al guardar el producto");
        //    }
        //    BDConexicon.VallartaClose();

        //}



       //##############################################################################################################################

        private void tabPage1_Click(object sender, EventArgs e)
        {
            tbBuscar.Focus();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {


                OpenFileDialog open = new OpenFileDialog();
                if (open.ShowDialog() == DialogResult.OK)
                {
                    tbArchivo.Text = open.FileName;
                }

                CargarExcel();
            }
            catch (Exception ed)
            {
                MessageBox.Show("Error archivo de Excel / Cierre Archivo de Excel");
            }
        }


        public void CargarExcel()
        {
            string hoja = "Hoja1";
            string pathconn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + tbArchivo.Text + ";Extended Properties='Excel 12.0 Xml; HDR=YES;';";
            OleDbConnection conn = new OleDbConnection(pathconn);
            OleDbCommand oconn = new OleDbCommand("Select * from [" + hoja + "$]", conn);
            conn.Open();

            OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            DataTable data = new DataTable();
            sda.Fill(data);
            dgvArticulos.DataSource = data;


        }

        public void cargarArticulos()
        {
            string articulo, descripcion, linea, marca, fabricante, impuesto, unidad,comando;
            double costo, mayoreo, menudeo;
            for (int i = 0; i < dgvArticulos.Rows.Count; i++)
            {
                if (string.IsNullOrEmpty(dgvArticulos[0, i].Value.ToString()))
                {
                    
                }
                else
                {
                    articulo= dgvArticulos[0, i].Value.ToString();
                    descripcion = dgvArticulos[1, i].Value.ToString();

                    costo = Convert.ToDouble( dgvArticulos[2, i].Value);
                    mayoreo = Convert.ToDouble( dgvArticulos[3, i].Value);
                    menudeo = Convert.ToDouble( dgvArticulos[4, i].Value);

                    impuesto = dgvArticulos[5, i].Value.ToString();
                    linea = dgvArticulos[6, i].Value.ToString();
                    marca = dgvArticulos[7, i].Value.ToString();
                    fabricante = dgvArticulos[8, i].Value.ToString();
                    
                    unidad = dgvArticulos[9, i].Value.ToString();

                    if (impuesto != "SYS" || impuesto != "sys")
                    {
                        mayoreo = mayoreo / IVA;
                        menudeo = menudeo / IVA;


                        costo = costo / IVA;
                    }
                    


                    MySqlCommand cmdart = new MySqlCommand("SELECT ARTICULO FROM prods WHERE ARTICULO ='" + articulo + "'", conex_excel);
                    MySqlDataReader mdrart;
                    mdrart = cmdart.ExecuteReader();


                    if (mdrart.Read())
                    {
                        comando = "UPDATE prods SET descrip=?descrip,costo_u=?costo_u,precio1=?precio1,precio2=?precio2,impuesto=?impuesto,linea=?linea,marca=?marca,fabricante=?fabricante,unidad=?unidad,paraventa=?paraventa,invent=?invent  WHERE articulo=?articulo";
                    }
                    else
                    {
                        comando = "INSERT INTO  prods (articulo,descrip,costo_u,precio1,precio2,impuesto,linea,marca,fabricante,unidad,invent,paraventa) VALUES (?articulo,?descrip,?costo_u,?precio1,?precio2,?impuesto,?linea,?marca,?fabricante,?unidad,?invent,?paraventa) ";
                    }

                    mdrart.Close();

                    MySqlCommand cmdoo = new MySqlCommand(comando, conex_excel);

                    cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = articulo;
                    cmdoo.Parameters.Add("?descrip", MySqlDbType.VarChar).Value = descripcion;

                    cmdoo.Parameters.Add("?precio1", MySqlDbType.VarChar).Value = menudeo.ToString();
                    cmdoo.Parameters.Add("?precio2", MySqlDbType.VarChar).Value = mayoreo.ToString();
                    cmdoo.Parameters.Add("?costo_u", MySqlDbType.VarChar).Value = costo.ToString();
                    cmdoo.Parameters.Add("?impuesto", MySqlDbType.VarChar).Value = impuesto;
                    cmdoo.Parameters.Add("?linea", MySqlDbType.VarChar).Value = linea;
                    cmdoo.Parameters.Add("?marca", MySqlDbType.VarChar).Value =marca;
                    cmdoo.Parameters.Add("?fabricante", MySqlDbType.VarChar).Value = fabricante;
                    //cmdoo.Parameters.Add("?peso", MySqlDbType.VarChar).Value = tbPresentacion.Text;
                    cmdoo.Parameters.Add("?unidad", MySqlDbType.VarChar).Value = unidad;
                    cmdoo.Parameters.Add("?paraventa", MySqlDbType.VarChar).Value = 1;
                    cmdoo.Parameters.Add("?invent", MySqlDbType.VarChar).Value = 1;
                    MySqlDataReader mdrr;
                    mdrr = cmdoo.ExecuteReader();
                    mdrr.Close();


                }

            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbArchivo.Text))
            {
                MessageBox.Show("Cargue Excel");

            }
            else
            {
                btExcel.Enabled = false;

                //Local
                try
                {
                    conex_excel = BDConexicon.conectar();
                    cargarArticulos();
                    conex_excel.Close();

                lblBo2.Text = "OK";
                lblBo2.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {
                lblBo2.Text = "NA";
                lblBo2.ForeColor = Color.Red;
               

                }

                //VALLARTA
                try
                {
                    conex_excel = BDConexicon.VallartaOpen();
                    cargarArticulos();
                    conex_excel.Close();

                    lblVa2.Text = "OK";
                    lblVa2.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {
                    lblVa2.Text = "NA";
                    lblVa2.ForeColor = Color.Red;


                }

                //RENA
                try
                {
                    conex_excel = BDConexicon.RenaOpen();
                    cargarArticulos();
                    conex_excel.Close();

                    lblRe2.Text = "OK";
                    lblRe2.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {
                    lblRe2.Text = "NA";
                    lblRe2.ForeColor = Color.Red;


                }

                //COLOSO
                try
                {
                    conex_excel = BDConexicon.ColosoOpen();
                    cargarArticulos();
                    conex_excel.Close();

                    lblCo2.Text = "OK";
                    lblCo2.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {
                    lblCo2.Text = "NA";
                    lblCo2.ForeColor = Color.Red;


                }


                //VELAZQUEZ
                try
                {
                    conex_excel = BDConexicon.VelazquezOpen();
                    cargarArticulos();
                    conex_excel.Close();

                    lblVe2.Text = "OK";
                    lblVe2.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {
                    lblVe2.Text = "NA";
                    lblVe2.ForeColor = Color.Red;


                }

                //PREGOT
                try
                {
                    conex_excel = BDConexicon.Papeleria1Open();
                    cargarArticulos();
                    conex_excel.Close();

                    lblPre2.Text = "OK";
                    lblPre2.ForeColor = Color.DarkGreen;
                }
                catch (Exception ex)
                {
                    lblPre2.Text = "NA";
                    lblPre2.ForeColor = Color.Red;


                }


                btExcel.Enabled = true;
            }
        }
    }


}
