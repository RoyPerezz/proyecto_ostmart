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
    public partial class ExistenciasVitrina : Form
    {
        public ExistenciasVitrina()
        {
            InitializeComponent();
        }

        MySqlConnection vVallarta;
        MySqlConnection vRena;
        MySqlConnection vColoso;
        MySqlConnection vVelazquez;
        //MySqlConnection bodega;

        string Usuario;
        string Area;
        string ip;

        public ExistenciasVitrina(string usuario, string area)
        {
            InitializeComponent();
            Usuario = usuario;
            Area = area;
        }

        private void ExistenciasVitrina_Load(object sender, EventArgs e)
        {

        }


        //################################################  ESTE METODO TRAE LOS DATOS DEL PRODUCTO DE LA BD LOCAL  ###################################################
        public void DatosProducto()
        {
            vVallarta = BDConexicon.V_vallarta();

            try
            {
                string consulta = "SELECT descrip,precio1,precio2,costo_u,fabricante,existencia,impuesto from prods where articulo='" + TB_clave.Text + "'";
                MySqlCommand cmd = new MySqlCommand(consulta, vVallarta);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {


                    if (dr["impuesto"].ToString().Equals("SYS") || dr["impuesto"].ToString().Equals("sys"))
                    {
                        TB_descripcion.Text = dr["descrip"].ToString();
                       
                   

              
                     

                        TB_menudeo.Text = dr["PRECIO1"].ToString();

                        TB_mayoreo.Text = dr["PRECIO2"].ToString();
                        TB_costo.Text = dr["costo_u"].ToString();
                        TB_fabricante.Text = dr["fabricante"].ToString();
                        TB_vallarta.Text = dr["existencia"].ToString();
                    }
                    else
                    {
                        TB_descripcion.Text = dr["descrip"].ToString();
                        //TB_menudeo.Text = dr["precio1"].ToString();
                        //TB_mayoreo.Text = dr["precio2"].ToString();
                        double precio1 = Convert.ToDouble(dr["PRECIO1"].ToString());
                        double ivaPrecio1 = precio1 + precio1 * 0.16;

                        double precio2 = Convert.ToDouble(dr["PRECIO2"].ToString());
                        double ivaPrecio2 = precio2 + precio2 * 0.16;

                        double costo = Convert.ToDouble(dr["costo_u"].ToString());
                        double ivaCosto = costo + costo * 0.16;

                        TB_menudeo.Text = ivaPrecio1.ToString();
                        TB_mayoreo.Text = ivaPrecio2.ToString();
                        TB_costo.Text = ivaCosto.ToString();
                        TB_fabricante.Text = dr["fabricante"].ToString();
                        TB_vallarta.Text = dr["existencia"].ToString();
                    }










                   

                }
                else
                {
                    TB_vallarta.ForeColor = Color.Red;
                    TB_vallarta.Text = "No existe";
                    MessageBox.Show("EL PRODUCTO NO EXISTE EN TU SUCURSAL, O LA CLAVE FUE MAL ESCRITA");
                }

                dr.Close();
                vVallarta.Close();
            }
            catch (Exception)
            {
                TB_vallarta.ForeColor = Color.Red;
                TB_vallarta.Text = "Sin Conexión";

            }






        }


        public void ExistenciaRE()
        {
            try
            {
                vRena = BDConexicon.V_rena();
                string consulta = "SELECT existencia from prods where articulo='" + TB_clave.Text + "'";
                MySqlCommand cmd = new MySqlCommand(consulta, vRena);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    TB_rena.Text = dr["existencia"].ToString();
                }
                else
                {
                    TB_rena.ForeColor = Color.Red;
                    TB_rena.Text = "No existe";
                }

                dr.Close();
                vRena.Close();
            }
            catch (Exception ex)
            {
                TB_rena.ForeColor = Color.Red;
                TB_rena.Text = "Sin conexion";
            }


        }

        public void ExistenciaCo()
        {
            try
            {
                vColoso = BDConexicon.V_coloso();
                string consulta = "SELECT existencia from prods where articulo='" + TB_clave.Text + "'";
                MySqlCommand cmd = new MySqlCommand(consulta, vColoso);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    TB_coloso.Text = dr["existencia"].ToString();
                }
                else
                {
                    TB_coloso.ForeColor = Color.Red;
                    TB_coloso.Text = "No existe";
                }

                dr.Close();
                vColoso.Close();
            }
            catch (Exception ex)
            {
                TB_coloso.ForeColor = Color.Red;
                TB_coloso.Text = "Sin conexion";
            }


        }

        public void ExistenciaVE()
        {
            try
            {

                vVelazquez = BDConexicon.V_velazquez();
                string consulta = "SELECT existencia from prods where articulo='" + TB_clave.Text + "'";
                MySqlCommand cmd = new MySqlCommand(consulta, vVelazquez);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    TB_velazquez.Text = dr["existencia"].ToString();
                }
                else
                {
                    TB_velazquez.ForeColor = Color.Red;
                    TB_velazquez.Text = "No existe";
                }

                dr.Close();
                vVelazquez.Close();
            }
            catch (Exception ex)
            {
                TB_velazquez.ForeColor = Color.Red;
                TB_velazquez.Text = "Sin conexion";
            }


        }

        


        private void BT_buscar_Click(object sender, EventArgs e)
        {





            DatosProducto();
            ExistenciaRE();
            ExistenciaCo();
            ExistenciaVE();
     
            TB_clave.Focus();
        }

        private void BT_limpiar_Click(object sender, EventArgs e)
        {
            TB_clave.Text = "";
            TB_descripcion.Text = "";
            TB_menudeo.Text = "";
            TB_mayoreo.Text = "";
            TB_costo.Text = "";
            TB_fabricante.Text = "";

            TB_vallarta.Text = "";
            TB_rena.Text = "";
            TB_coloso.Text = "";
            TB_velazquez.Text = "";
            limpiarOferta();
            limpiarPrecio();

            lblVa.Text = "";
            lblRe.Text = "";
            lblVe.Text = "";
            lblCo.Text = "";

            lblVaPre.Text = "";
            lblRePre.Text = "";
            lblVePre.Text = "";
            lblCoPre.Text = "";

            TB_clave.Focus();
        }

        private void TB_clave_KeyDown(object sender, KeyEventArgs e)
        {
            TB_clave.Text = "";
            TB_descripcion.Text = "";
            TB_menudeo.Text = "";
            TB_mayoreo.Text = "";
            TB_costo.Text = "";
            TB_fabricante.Text = "";

            TB_vallarta.Text = "";
            TB_rena.Text = "";
            TB_coloso.Text = "";
            TB_velazquez.Text = "";
         
            TB_clave.Focus();
        }

        private void TB_clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                DatosProducto();
                ExistenciaRE();
                ExistenciaCo();
                ExistenciaVE();
               
                TB_clave.Focus();
            }

            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                TB_clave.Text = "";
                TB_descripcion.Text = "";
                TB_menudeo.Text = "";
                TB_mayoreo.Text = "";
                TB_costo.Text = "";
                TB_fabricante.Text = "";

                TB_vallarta.Text = "";
                TB_rena.Text = "";
                TB_coloso.Text = "";
                TB_velazquez.Text = "";
               
                TB_clave.Focus();
            }
        }

        //###################################### OFERTAS  Y CAMBIO DE PRECIO  ###################################################################


        private void cBoxTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxTodas.Checked)
            {
                cBoxVa.Checked = true;
                cBoxRe.Checked = true;
                cBoxVe.Checked = true;
                cBoxCo.Checked = true;
            }
            else if (!cBoxTodas.Checked)
            {
                cBoxVa.Checked = false;
                cBoxRe.Checked = false;
                cBoxVe.Checked = false;
                cBoxCo.Checked = false;
            }
        }

        internal static String getDate(DateTime now)
        {
            String datePatt = @"yyyy-MM-dd";
            String snow = now.ToString(datePatt);
            return snow;
        }



        public void VallartaOferta()
        {

            MySqlConnection con;
        
            try
            {
                con = BDConexicon.V_vallarta();
                DateTime Finicio = dt_Inicio.Value;
                DateTime Ffin = dt_Fin.Value;

                string inicio = getDate(Finicio);
                string fin = getDate(Ffin);



                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET oferta=1  WHERE articulo=?articulo", con);
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_clave.Text;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();

                MySqlCommand cmdo = new MySqlCommand("DELETE FROM ofertas WHERE articulo=?articulo", con);
                cmdo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_clave.Text;
                MySqlDataReader mdr;
                mdr = cmdo.ExecuteReader();
                mdr.Close();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO ofertas(articulo,fechainicial,fechafinal,porporcentaje,porcentaje) VALUES(?articulo,?fechainicial,?fechafinal,?porporcentaje,?porcentaje)", con);
                cmd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_clave.Text;
                cmd.Parameters.Add("?fechainicial", MySqlDbType.VarChar).Value = inicio;
                cmd.Parameters.Add("?fechafinal", MySqlDbType.VarChar).Value = fin;
                cmd.Parameters.Add("?porporcentaje", MySqlDbType.Int16).Value = 1;
                cmd.Parameters.Add("?porcentaje", MySqlDbType.Float).Value = (float)Convert.ToDouble(tbporcentaje.Text);
                cmd.ExecuteNonQuery();

                //limpiarOferta();

                lblVa.Text = "OK";
                con.Close();
                //MessageBox.Show("Los datos se Guardaron");
            }
            catch (Exception e)
            {
                lblVa.Text = "N/A";
                lblVa.ForeColor = Color.Red;
            }
            
        }


        public void RenaOferta()
        {

            MySqlConnection con;
            try
            {
                con = BDConexicon.V_rena();
                DateTime Finicio = dt_Inicio.Value;
                DateTime Ffin = dt_Fin.Value;

                string inicio = getDate(Finicio);
                string fin = getDate(Ffin);



                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET oferta=1  WHERE articulo=?articulo", con);
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_clave.Text;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();

                MySqlCommand cmdo = new MySqlCommand("DELETE FROM ofertas WHERE articulo=?articulo", con);
                cmdo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_clave.Text;
                MySqlDataReader mdr;
                mdr = cmdo.ExecuteReader();
                mdr.Close();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO ofertas(articulo,fechainicial,fechafinal,porporcentaje,porcentaje) VALUES(?articulo,?fechainicial,?fechafinal,?porporcentaje,?porcentaje)", con);
                cmd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_clave.Text;
                cmd.Parameters.Add("?fechainicial", MySqlDbType.VarChar).Value = inicio;
                cmd.Parameters.Add("?fechafinal", MySqlDbType.VarChar).Value = fin;
                cmd.Parameters.Add("?porporcentaje", MySqlDbType.Int16).Value = 1;
                cmd.Parameters.Add("?porcentaje", MySqlDbType.Float).Value = (float)Convert.ToDouble(tbporcentaje.Text);
                cmd.ExecuteNonQuery();

                //limpiarOferta();

                lblRe.Text = "OK";
                con.Close();
                //MessageBox.Show("Los datos se Guardaron");
            }
            catch (Exception e)
            {
                lblRe.Text = "N/A";
                lblRe.ForeColor = Color.Red;
            }
          
        }

        public void VelazquezOferta()
        {

            MySqlConnection con;
            try
            {

                con = BDConexicon.V_velazquez();
                DateTime Finicio = dt_Inicio.Value;
                DateTime Ffin = dt_Fin.Value;

                string inicio = getDate(Finicio);
                string fin = getDate(Ffin);



                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET oferta=1  WHERE articulo=?articulo", con);
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_clave.Text;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();

                MySqlCommand cmdo = new MySqlCommand("DELETE FROM ofertas WHERE articulo=?articulo", con);
                cmdo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_clave.Text;
                MySqlDataReader mdr;
                mdr = cmdo.ExecuteReader();
                mdr.Close();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO ofertas(articulo,fechainicial,fechafinal,porporcentaje,porcentaje) VALUES(?articulo,?fechainicial,?fechafinal,?porporcentaje,?porcentaje)", con);
                cmd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_clave.Text;
                cmd.Parameters.Add("?fechainicial", MySqlDbType.VarChar).Value = inicio;
                cmd.Parameters.Add("?fechafinal", MySqlDbType.VarChar).Value = fin;
                cmd.Parameters.Add("?porporcentaje", MySqlDbType.Int16).Value = 1;
                cmd.Parameters.Add("?porcentaje", MySqlDbType.Float).Value = (float)Convert.ToDouble(tbporcentaje.Text);
                cmd.ExecuteNonQuery();

                //limpiarOferta();

                lblVe.Text = "OK";
                //MessageBox.Show("Los datos se Guardaron");
                con.Close();
            }
            catch (Exception e)
            {
                lblVe.Text = "N/A";
                lblVe.ForeColor = Color.Red;
            }

           
        }

        public void ColosoOferta()
        {

            MySqlConnection con;
            try
            {
                con = BDConexicon.V_coloso();
                DateTime Finicio = dt_Inicio.Value;
                DateTime Ffin = dt_Fin.Value;

                string inicio = getDate(Finicio);
                string fin = getDate(Ffin);



                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET oferta=1  WHERE articulo=?articulo", con);
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_clave.Text;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();

                MySqlCommand cmdo = new MySqlCommand("DELETE FROM ofertas WHERE articulo=?articulo", con);
                cmdo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_clave.Text;
                MySqlDataReader mdr;
                mdr = cmdo.ExecuteReader();
                mdr.Close();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO ofertas(articulo,fechainicial,fechafinal,porporcentaje,porcentaje) VALUES(?articulo,?fechainicial,?fechafinal,?porporcentaje,?porcentaje)", con);
                cmd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_clave.Text;
                cmd.Parameters.Add("?fechainicial", MySqlDbType.VarChar).Value = inicio;
                cmd.Parameters.Add("?fechafinal", MySqlDbType.VarChar).Value = fin;
                cmd.Parameters.Add("?porporcentaje", MySqlDbType.Int16).Value = 1;
                cmd.Parameters.Add("?porcentaje", MySqlDbType.Float).Value = (float)Convert.ToDouble(tbporcentaje.Text);
                cmd.ExecuteNonQuery();

                // limpiarOferta();

                lblCo.Text = "OK";
                //MessageBox.Show("Los datos se Guardaron");
                con.Close();
            }
            catch (Exception e)
            {
                lblCo.Text = "N/A";
                lblCo.ForeColor = Color.Red;
            }

        }

        public void limpiarPrecio()
        {
            cBoxTodasPrecio.Checked = false;
            cBoxVaPrecio.Checked = false;
            cBoxRePrecio.Checked = false;
            cBoxVePrecio.Checked = false;
            cBoxCoPrecio.Checked = false;
            tbPrecio1.Text = "";
            tbPrecio2.Text = "";
        }

        public void limpiarOferta()
        {
            cBoxTodas.Checked = false;
            cBoxVa.Checked = false;
            cBoxRe.Checked = false;
            cBoxVe.Checked = false;
            cBoxCo.Checked = false;
            tbporcentaje.Text = "";
        }

        private void AplicaOferta_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void Existencias_Load_1(object sender, EventArgs e)
        {
            //#################################################### ACTUALIZACION PARA ACTIVAR  SEGUN USUARIO #####################################
            if (Area == "TRASPASOS" || Area == "SISTEMAS" || Area == "SUPER")
            {
                panelOfertas.Enabled = true;
            }
            else
            {
                panelOfertas.Enabled = false;
            }


            if (Area == "TRASPASOS" || Area == "SISTEMAS" || Area == "SUPER")
            {
                panelPrecios.Enabled = true;
            }
            else
            {
                panelPrecios.Enabled = false;
            }
        }

        private void groupBox2_Enter_2(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cBoxTodas_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cBoxTodas.Checked)
            {
                cBoxVa.Checked = true;
                cBoxRe.Checked = true;
                cBoxVe.Checked = true;
                cBoxCo.Checked = true;
            }
            else if (!cBoxTodas.Checked)
            {
                cBoxVa.Checked = false;
                cBoxRe.Checked = false;
                cBoxVe.Checked = false;
                cBoxCo.Checked = false;
            }

            ip = BDConexicon.optieneIp();
        }

        private void AplicaOferta_Click_1(object sender, EventArgs e)
        {
           

        }

       

        private void AplicaOferta_Click_2(object sender, EventArgs e)
        {
            if (cBoxVa.Checked == false & cBoxRe.Checked == false & cBoxVe.Checked == false & cBoxCo.Checked == false)
            {
                MessageBox.Show("Selecciona una Tienda para aplicar la Oferta");
            }
            if (cBoxVa.Checked)
            {
                if (string.IsNullOrEmpty(TB_clave.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbporcentaje.Text))
                {
                    MessageBox.Show("Inserta Porcentaje de Descuento");
                }
                else
                {
                    VallartaOferta();
                    //MessageBox.Show("Vallarta");
                }

            }
            if (cBoxRe.Checked)
            {
                if (string.IsNullOrEmpty(TB_clave.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbporcentaje.Text))
                {
                    MessageBox.Show("Inserta Porcentaje de Descuento");
                }
                else
                {
                    RenaOferta();
                    //MessageBox.Show("Rena");
                }

            }
            if (cBoxVe.Checked)
            {
                if (string.IsNullOrEmpty(TB_clave.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbporcentaje.Text))
                {
                    MessageBox.Show("Inserta Porcentaje de Descuento");
                }
                else
                {
                    VelazquezOferta();
                    //MessageBox.Show("Velazquez");
                }
            }
            if (cBoxCo.Checked)
            {
                if (string.IsNullOrEmpty(TB_clave.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbporcentaje.Text))
                {
                    MessageBox.Show("Inserta Porcentaje de Descuento");
                }
                else
                {
                    ColosoOferta();
                    //MessageBox.Show("Coloso");
                }
            }
            else
            {
                limpiarOferta();
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }



  

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void AplicaOferta_Click_3(object sender, EventArgs e)
        {
            if (cBoxVa.Checked == false & cBoxRe.Checked == false & cBoxVe.Checked == false & cBoxCo.Checked == false)
            {
                MessageBox.Show("Selecciona una Tienda para aplicar la Oferta");
            }
            if (cBoxVa.Checked)
            {
                if (string.IsNullOrEmpty(TB_clave.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbporcentaje.Text))
                {
                    MessageBox.Show("Inserta Porcentaje de Descuento");
                }
                else
                {
                    VallartaOferta();
                    //MessageBox.Show("Vallarta");
                }

            }
            if (cBoxRe.Checked)
            {
                if (string.IsNullOrEmpty(TB_clave.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbporcentaje.Text))
                {
                    MessageBox.Show("Inserta Porcentaje de Descuento");
                }
                else
                {
                    RenaOferta();
                    //MessageBox.Show("Rena");
                }

            }
            if (cBoxVe.Checked)
            {
                if (string.IsNullOrEmpty(TB_clave.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbporcentaje.Text))
                {
                    MessageBox.Show("Inserta Porcentaje de Descuento");
                }
                else
                {
                    VelazquezOferta();
                    //MessageBox.Show("Velazquez");
                }
            }
            if (cBoxCo.Checked)
            {
                if (string.IsNullOrEmpty(TB_clave.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbporcentaje.Text))
                {
                    MessageBox.Show("Inserta Porcentaje de Descuento");
                }
                else
                {
                    ColosoOferta();
                    //MessageBox.Show("Coloso");
                }
            }
            else
            {
                limpiarOferta();
            }
        }

        private void aplicarPrecio_Click(object sender, EventArgs e)
        {
            // APLICACION DE PRECIO


            if (cBoxVaPrecio.Checked == false & cBoxRePrecio.Checked == false & cBoxVePrecio.Checked == false & cBoxCoPrecio.Checked == false)
            {
                MessageBox.Show("Selecciona una Tienda para aplicar la Oferta");
            }
            if (cBoxVaPrecio.Checked)
            {
                if (string.IsNullOrEmpty(TB_clave.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbPrecio1.Text))
                {
                    MessageBox.Show("Inserta Precio Menudeo");
                }
                else if (string.IsNullOrEmpty(tbPrecio2.Text))
                {
                    MessageBox.Show("Inserta Precio Mayoreo");
                }
                else
                {

                    VallartaPrecio();
                    //MessageBox.Show("Vallarta");
                }

            }
            if (cBoxRePrecio.Checked)
            {
                if (string.IsNullOrEmpty(TB_clave.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbPrecio1.Text))
                {
                    MessageBox.Show("Inserta Precio Menudeo");
                }
                else if (string.IsNullOrEmpty(tbPrecio2.Text))
                {
                    MessageBox.Show("Inserta Precio Mayoreo");
                }
                else
                {
                    RenaPrecio();
                    //MessageBox.Show("Rena");
                }

            }
            if (cBoxVePrecio.Checked)
            {
                if (string.IsNullOrEmpty(TB_clave.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbPrecio1.Text))
                {
                    MessageBox.Show("Inserta Precio Menudeo");
                }
                else if (string.IsNullOrEmpty(tbPrecio2.Text))
                {
                    MessageBox.Show("Inserta Precio Mayoreo");
                }
                else
                {
                    VelazquezPrecio();
                    //MessageBox.Show("Velazquez");
                }
            }
            if (cBoxCoPrecio.Checked)
            {
                if (string.IsNullOrEmpty(TB_clave.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbPrecio1.Text))
                {
                    MessageBox.Show("Inserta Precio Menudeo");
                }
                else if (string.IsNullOrEmpty(tbPrecio2.Text))
                {
                    MessageBox.Show("Inserta Precio Mayoreo");
                }
                {
                    ColosoPrecio();
                    //MessageBox.Show("Coloso");
                }
            }

            limpiarPrecio();

        }

        //#############################################################################################################################
        public void VallartaPrecio()
        {

            MySqlConnection con;
            try
            {
                con = BDConexicon.V_vallarta();
                double Precio1 = Convert.ToDouble(tbPrecio1.Text);
                double Precio2 = Convert.ToDouble(tbPrecio2.Text);
                Precio1 = Precio1 / 1.16;
                Precio2 = Precio2 / 1.16;


                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET precio1=?precio1,precio2=?precio2  WHERE articulo=?articulo", con);
                cmdoo.Parameters.Add("?precio1", MySqlDbType.VarChar).Value = Precio1;
                cmdoo.Parameters.Add("?precio2", MySqlDbType.VarChar).Value = Precio2;
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_clave.Text;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();


                lblVaPre.Text = "OK";
                lblVaPre.ForeColor = Color.DarkGreen;
                con.Close();
            }
            catch (Exception e)
            {
                lblVaPre.Text = "N/A";
                lblVaPre.ForeColor = Color.Red;
            }
        
        }



        private void RenaPrecio()
        {

            MySqlConnection con;
            try
            {
                con = BDConexicon.V_rena();
                double Precio1 = Convert.ToDouble(tbPrecio1.Text);
                double Precio2 = Convert.ToDouble(tbPrecio2.Text);
                Precio1 = Precio1 / 1.16;
                Precio2 = Precio2 / 1.16;


                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET precio1=?precio1,precio2=?precio2  WHERE articulo=?articulo", con);
                cmdoo.Parameters.Add("?precio1", MySqlDbType.VarChar).Value = Precio1;
                cmdoo.Parameters.Add("?precio2", MySqlDbType.VarChar).Value = Precio2;
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_clave.Text;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();


                lblRePre.Text = "OK";
                lblRePre.ForeColor = Color.DarkGreen;
                con.Close();
            }
            catch (Exception e)
            {
                lblRePre.Text = "N/A";
                lblRePre.ForeColor = Color.Red;
            }
           
        }

        private void VelazquezPrecio()
        {

            MySqlConnection con;
            try
            {
                con = BDConexicon.V_velazquez();
                double Precio1 = Convert.ToDouble(tbPrecio1.Text);
                double Precio2 = Convert.ToDouble(tbPrecio2.Text);
                Precio1 = Precio1 / 1.16;
                Precio2 = Precio2 / 1.16;


                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET precio1=?precio1,precio2=?precio2  WHERE articulo=?articulo", con);
                cmdoo.Parameters.Add("?precio1", MySqlDbType.VarChar).Value = Precio1;
                cmdoo.Parameters.Add("?precio2", MySqlDbType.VarChar).Value = Precio2;
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_clave.Text;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();


                lblVePre.Text = "OK";
                lblVePre.ForeColor = Color.DarkGreen;
                con.Close();
            }
            catch (Exception e)
            {
                lblVePre.Text = "N/A";
                lblVePre.ForeColor = Color.Red;
            }
           
        }

        private void ColosoPrecio()
        {


            MySqlConnection con;
            try
            {
                con = BDConexicon.V_coloso();
                double Precio1 = Convert.ToDouble(tbPrecio1.Text);
                double Precio2 = Convert.ToDouble(tbPrecio2.Text);
                Precio1 = Precio1 / 1.16;
                Precio2 = Precio2 / 1.16;


                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET precio1=?precio1,precio2=?precio2  WHERE articulo=?articulo", con);
                cmdoo.Parameters.Add("?precio1", MySqlDbType.VarChar).Value = Precio1;
                cmdoo.Parameters.Add("?precio2", MySqlDbType.VarChar).Value = Precio2;
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_clave.Text;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();


                lblCoPre.Text = "OK";
                lblCoPre.ForeColor = Color.DarkGreen;
                con.Close();
            }
            catch (Exception e)
            {
                lblCoPre.Text = "N/A";
                lblCoPre.ForeColor = Color.Red;
            }
           
        }


        //private void cBoxTodasPrecio_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (cBoxTodasPrecio.Checked)
        //    {
        //        cBoxVaPrecio.Checked = true;
        //        cBoxRePrecio.Checked = true;
        //        cBoxVePrecio.Checked = true;
        //        cBoxCoPrecio.Checked = true;
             

        //    }
        //    else if (!cBoxTodasPrecio.Checked)
        //    {
        //        cBoxVaPrecio.Checked = false;
        //        cBoxRePrecio.Checked = false;
        //        cBoxVePrecio.Checked = false;
        //        cBoxCoPrecio.Checked = false;
        //    }
        //}

        private void cBoxTodas_CheckedChanged_3(object sender, EventArgs e)
        {
            if (cBoxTodas.Checked)
            {
                cBoxVa.Checked = true;
                cBoxRe.Checked = true;
                cBoxVe.Checked = true;
                cBoxCo.Checked = true;
            }
            else if (!cBoxTodas.Checked)
            {
                cBoxVa.Checked = false;
                cBoxRe.Checked = false;
                cBoxVe.Checked = false;
                cBoxCo.Checked = false;
            }
        }

   

        private void TB_articulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TB_clave.Text.Equals(""))
                {
                    MessageBox.Show("Ingresa un artículo");
                }
                else
                {


                    lblVa.Text = "";
                    lblRe.Text = "";
                    lblVe.Text = "";
                    lblCo.Text = "";

                    lblVaPre.Text = "";
                    lblRePre.Text = "";
                    lblVePre.Text = "";
                    lblCoPre.Text = "";

                    DatosProducto();
               
                    ExistenciaRE();
                    ExistenciaVE();
                    ExistenciaCo();

                  


                }
            }

            if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                //borrarArticulo();
                limpiarOferta();
                limpiarPrecio();

                lblVa.Text = "";
                lblRe.Text = "";
                lblVe.Text = "";
                lblCo.Text = "";

                lblVaPre.Text = "";
                lblRePre.Text = "";
                lblVePre.Text = "";
                lblCoPre.Text = "";
                TB_clave.Focus();
                TB_clave.SelectAll();
                SendKeys.Send("{BACKSPACE}");
            }
        }

        private void AplicaOferta_Click_4(object sender, EventArgs e)
        {
            if (cBoxVa.Checked == false & cBoxRe.Checked == false & cBoxVe.Checked == false & cBoxCo.Checked == false)
            {
                MessageBox.Show("Selecciona una Tienda para aplicar la Oferta");
            }
            if (cBoxVa.Checked)
            {
                if (string.IsNullOrEmpty(TB_clave.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbporcentaje.Text))
                {
                    MessageBox.Show("Inserta Porcentaje de Descuento");
                }
                else
                {
                    VallartaOferta();
                    //MessageBox.Show("Vallarta");
                }

            }
            if (cBoxRe.Checked)
            {
                if (string.IsNullOrEmpty(TB_clave.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbporcentaje.Text))
                {
                    MessageBox.Show("Inserta Porcentaje de Descuento");
                }
                else
                {
                    RenaOferta();
                    //MessageBox.Show("Rena");
                }

            }
            if (cBoxVe.Checked)
            {
                if (string.IsNullOrEmpty(TB_clave.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbporcentaje.Text))
                {
                    MessageBox.Show("Inserta Porcentaje de Descuento");
                }
                else
                {
                    VelazquezOferta();
                    //MessageBox.Show("Velazquez");
                }
            }
            if (cBoxCo.Checked)
            {
                if (string.IsNullOrEmpty(TB_clave.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbporcentaje.Text))
                {
                    MessageBox.Show("Inserta Porcentaje de Descuento");
                }
                else
                {
                    ColosoOferta();
                    //MessageBox.Show("Coloso");
                }
            }
            else
            {
                limpiarOferta();
            }

        }

        private void aplicarPrecio_Click_1(object sender, EventArgs e)
        {

            if (cBoxVaPrecio.Checked == false & cBoxRePrecio.Checked == false & cBoxVePrecio.Checked == false & cBoxCoPrecio.Checked == false)
            {
                MessageBox.Show("Selecciona una Tienda para aplicar la Oferta");
            }
            if (cBoxVaPrecio.Checked)
            {
                if (string.IsNullOrEmpty(TB_clave.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbPrecio1.Text))
                {
                    MessageBox.Show("Inserta Precio Menudeo");
                }
                else if (string.IsNullOrEmpty(tbPrecio2.Text))
                {
                    MessageBox.Show("Inserta Precio Mayoreo");
                }
                else
                {

                    VallartaPrecio();
                    //MessageBox.Show("Vallarta");
                }

            }
            if (cBoxRePrecio.Checked)
            {
                if (string.IsNullOrEmpty(TB_clave.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbPrecio1.Text))
                {
                    MessageBox.Show("Inserta Precio Menudeo");
                }
                else if (string.IsNullOrEmpty(tbPrecio2.Text))
                {
                    MessageBox.Show("Inserta Precio Mayoreo");
                }
                else
                {
                    RenaPrecio();
                    //MessageBox.Show("Rena");
                }

            }
            if (cBoxVePrecio.Checked)
            {
                if (string.IsNullOrEmpty(TB_clave.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbPrecio1.Text))
                {
                    MessageBox.Show("Inserta Precio Menudeo");
                }
                else if (string.IsNullOrEmpty(tbPrecio2.Text))
                {
                    MessageBox.Show("Inserta Precio Mayoreo");
                }
                else
                {
                    VelazquezPrecio();
                    //MessageBox.Show("Velazquez");
                }
            }
            if (cBoxCoPrecio.Checked)
            {
                if (string.IsNullOrEmpty(TB_clave.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbPrecio1.Text))
                {
                    MessageBox.Show("Inserta Precio Menudeo");
                }
                else if (string.IsNullOrEmpty(tbPrecio2.Text))
                {
                    MessageBox.Show("Inserta Precio Mayoreo");
                }
                {
                    ColosoPrecio();
                    //MessageBox.Show("Coloso");
                }
            }

        }

        private void cBoxTodas_CheckedChanged_2(object sender, EventArgs e)
        {
            if (cBoxTodas.Checked)
            {
                cBoxVa.Checked = true;
                cBoxRe.Checked = true;
                cBoxVe.Checked = true;
                cBoxCo.Checked = true;


            }
            else if (!cBoxTodas.Checked)
            {
                cBoxVa.Checked = false;
                cBoxRe.Checked = false;
                cBoxVe.Checked = false;
                cBoxCo.Checked = false;
            }
        }

        private void cBoxRe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cBoxTodasPrecio_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxTodasPrecio.Checked)
            {
                cBoxVaPrecio.Checked = true;
                cBoxRePrecio.Checked = true;
                cBoxVePrecio.Checked = true;
                cBoxCoPrecio.Checked = true;


            }
            else if (!cBoxTodasPrecio.Checked)
            {
                cBoxVaPrecio.Checked = false;
                cBoxRePrecio.Checked = false;
                cBoxVePrecio.Checked = false;
                cBoxCoPrecio.Checked = false;
            }
        }
    }
}
