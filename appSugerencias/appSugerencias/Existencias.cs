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
    public partial class Existencias : Form
        

    {
        string Usuario;
        string Area;

        public Existencias()
        {
            InitializeComponent();
        }

        public Existencias(string usuario, string area)
        {
            InitializeComponent();
            Usuario = usuario;
            Area = area;
        }


        public void Vallarta()
        {
            
            try
            {


                MySqlCommand cmd = new MySqlCommand("select existencia from prods where articulo='" + TB_articulo.Text + "'", BDConexicon.VallartaOpen());
                MySqlDataReader rd = cmd.ExecuteReader();

                //while (rd.Read())
                //{
                //    TB_vallarta.Text = rd[0].ToString();
                //    LB_vallarta.Text = "Conectado";
                //}

                if (rd.Read())
                {

                    TB_vallarta.Text = rd[0].ToString();
                    LB_vallarta.Text = "Conectado";
                    LB_vallarta.ForeColor = Color.DarkGreen;
                }
                else
                {
                    LB_vallarta.Text = "No existe";
                    LB_vallarta.ForeColor = Color.Red;
                }
                rd.Close();
            }
            catch (Exception e)
            {
                LB_vallarta.Text = "Sin conexion";
                LB_vallarta.ForeColor = Color.Red;
            }
            BDConexicon.VallartaClose();
        }

        public void Velazquez()
        {

            try { 
            MySqlCommand cmd = new MySqlCommand("select existencia from prods where articulo='" + TB_articulo.Text + "'", BDConexicon.VelazquezOpen());
            MySqlDataReader rd = cmd.ExecuteReader();

            //while (rd.Read())
            //{
            //    TB_velazquez.Text = rd[0].ToString();
            //        LB_velazquez.Text = "Conectado";
            // }

                if (rd.Read())
                {
                    TB_velazquez.Text = rd[0].ToString();
                    LB_velazquez.Text = "Conectado";
                    LB_velazquez.ForeColor = Color.DarkGreen;
                }
                else
                {
                    LB_velazquez.Text = "No existe";
                    LB_velazquez.ForeColor = Color.Red;
                }
                rd.Close();
            }
            catch (Exception e)
            {
                LB_velazquez.Text = "Sin conexion";
                LB_velazquez.ForeColor = Color.Red;
            }

            BDConexicon.VelazquezClose();
        }

        public void Rena()
        {
            try { 
            MySqlCommand cmd = new MySqlCommand("select existencia from prods where articulo='" + TB_articulo.Text + "'", BDConexicon.RenaOpen());
            MySqlDataReader rd = cmd.ExecuteReader();

            //while (rd.Read())
            //{
            //    TB_rena.Text = rd[0].ToString();
            //        LB_rena.Text = "Conectado";
            //}

                if (rd.Read())
                {
                    TB_rena.Text = rd[0].ToString();
                    LB_rena.Text = "Conectado";
                    LB_rena.ForeColor = Color.DarkGreen;
                }
                else
                {
                    LB_rena.Text = "No existe";
                    LB_rena.ForeColor = Color.Red;
                }
                rd.Close();
                

            }
            catch (Exception e)
            {
                LB_rena.Text = "Sin conexion";
                LB_rena.ForeColor = Color.Red;
            }

            BDConexicon.RenaClose();
        }

        public void Coloso()
        {
            try { 
            MySqlCommand cmd = new MySqlCommand("select existencia from prods where articulo='" + TB_articulo.Text + "'", BDConexicon.ColosoOpen());
            MySqlDataReader rd = cmd.ExecuteReader();

            //while (rd.Read())
            //{
            //    TB_coloso.Text = rd[0].ToString();
            //    LB_coloso.Text = "Conectado";
            //}


                if (rd.Read())
                {
                    TB_coloso.Text = rd[0].ToString();
                    LB_coloso.Text = "Conectado";
                    LB_coloso.ForeColor = Color.DarkGreen;
                }
                else
                {
                    LB_coloso.Text = "No existe";
                    LB_coloso.ForeColor = Color.Red;
                }
                rd.Close();
               
            }
            
            catch (Exception e)
            {
                LB_coloso.Text = "Sin conexion";
                LB_coloso.ForeColor = Color.Red;
            }
            
            BDConexicon.ColosoClose();
        }

        //public void Bodega()
        //{
        //    try
        //    {
        //        MySqlCommand cmd = new MySqlCommand("select existencia from prods where articulo='" + TB_articulo.Text + "'",BDConexicon.BodegaOpen());
        //        MySqlDataReader rd = cmd.ExecuteReader();

        //        //while (rd.Read())
        //        //{
        //        //    TB_bodega.Text = rd[0].ToString();
        //        //    Lb_bodega.Text = "Conectado";
        //        //}

        //        if (rd.Read())
        //        {
        //            TB_bodega.Text = rd[0].ToString();
        //            Lb_bodega.Text = "Conectado";
        //            Lb_bodega.ForeColor = Color.DarkGreen;
        //        }
        //        else
        //        {
        //            Lb_bodega.Text = "No existe";
        //            Lb_bodega.ForeColor = Color.Red;
        //        }
               
        //    }
        //    catch (Exception e)
        //    {
        //        Lb_bodega.Text = "Sin conexion";
        //        Lb_bodega.ForeColor = Color.Red;
        //    }
        //}


        public void DatosProducto()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select descrip, precio1,precio2, costo_u, existencia,fabricante from prods where articulo ='" + TB_articulo.Text + "'", BDConexicon.BodegaOpen());
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    TB_desc.Text = rd["DESCRIP"].ToString();

                    double precio1 = Convert.ToDouble(rd["PRECIO1"].ToString());
                    double ivaPrecio1 = precio1 + precio1 * 0.16;

                    double precio2 = Convert.ToDouble(rd["PRECIO2"].ToString());
                    double ivaPrecio2 = precio2 + precio2 * 0.16;

                    TB_precio1.Text = ivaPrecio1.ToString();
                    TB_precio2.Text = ivaPrecio2.ToString();

                    TB_bodega.Text = rd["existencia"].ToString();
                    Lb_bodega.Text = "Conectado";
                    Lb_bodega.ForeColor = Color.DarkGreen;


                    double costo = Convert.ToDouble(rd["COSTO_U"].ToString());
                    double IvaCosto = costo + costo * 0.16;

                    TB_costo.Text = IvaCosto.ToString();
                    TB_fabricante.Text = rd["fabricante"].ToString();
                }
                rd.Close();
            }
            catch (Exception e)
            {
                Lb_bodega.Text = "Sin conexion";
                Lb_bodega.ForeColor = Color.Red;
            }

            BDConexicon.BodegaClose();
        }




        private void BTN_aceptar_Click(object sender, EventArgs e)
        {



          
            if (TB_articulo.Text.Equals(""))
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
                //Bodega();
                Vallarta();
                Rena();
                Velazquez();
                
                Coloso();
                
                

            }



        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }





        private void Existencias_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

    



        private void cBoxTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxTodas.Checked)
            {
                cBoxVa.Checked = true;
                cBoxRe.Checked = true;
                cBoxVe.Checked = true;
                cBoxCo.Checked = true;
            }else if (!cBoxTodas.Checked)
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
            try
            {
                DateTime Finicio = dt_Inicio.Value;
                DateTime Ffin = dt_Fin.Value;

                string inicio = getDate(Finicio);
                string fin = getDate(Ffin);



                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET oferta=1  WHERE articulo=?articulo", BDConexicon.VallartaOpen());
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();

                MySqlCommand cmdo = new MySqlCommand("DELETE FROM ofertas WHERE articulo=?articulo", BDConexicon.VallartaOpen());
                cmdo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                MySqlDataReader mdr;
                mdr = cmdo.ExecuteReader();
                mdr.Close();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO ofertas(articulo,fechainicial,fechafinal,porporcentaje,porcentaje) VALUES(?articulo,?fechainicial,?fechafinal,?porporcentaje,?porcentaje)", BDConexicon.VallartaOpen());
                cmd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                cmd.Parameters.Add("?fechainicial", MySqlDbType.VarChar).Value = inicio;
                cmd.Parameters.Add("?fechafinal", MySqlDbType.VarChar).Value = fin;
                cmd.Parameters.Add("?porporcentaje", MySqlDbType.Int16).Value = 1;
                cmd.Parameters.Add("?porcentaje", MySqlDbType.Float).Value = (float)Convert.ToDouble(tbporcentaje.Text);
                cmd.ExecuteNonQuery();

                //limpiarOferta();

                lblVa.Text = "OK";
                //MessageBox.Show("Los datos se Guardaron");
            }
            catch (Exception e)
            {
                lblVa.Text = "N/A";
                lblVa.ForeColor = Color.Red;
            }
            BDConexicon.VallartaClose();
        }


        public void RenaOferta()
        {
            try
            {
                DateTime Finicio = dt_Inicio.Value;
                DateTime Ffin = dt_Fin.Value;

                string inicio = getDate(Finicio);
                string fin = getDate(Ffin);



                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET oferta=1  WHERE articulo=?articulo", BDConexicon.RenaOpen());
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();

                MySqlCommand cmdo = new MySqlCommand("DELETE FROM ofertas WHERE articulo=?articulo", BDConexicon.RenaOpen());
                cmdo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                MySqlDataReader mdr;
                mdr = cmdo.ExecuteReader();
                mdr.Close();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO ofertas(articulo,fechainicial,fechafinal,porporcentaje,porcentaje) VALUES(?articulo,?fechainicial,?fechafinal,?porporcentaje,?porcentaje)", BDConexicon.RenaOpen());
                cmd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                cmd.Parameters.Add("?fechainicial", MySqlDbType.VarChar).Value = inicio;
                cmd.Parameters.Add("?fechafinal", MySqlDbType.VarChar).Value = fin;
                cmd.Parameters.Add("?porporcentaje", MySqlDbType.Int16).Value = 1;
                cmd.Parameters.Add("?porcentaje", MySqlDbType.Float).Value = (float)Convert.ToDouble(tbporcentaje.Text);
                cmd.ExecuteNonQuery();

                //limpiarOferta();

                lblRe.Text = "OK";
                //MessageBox.Show("Los datos se Guardaron");
            }
            catch (Exception e)
            {
                lblRe.Text = "N/A";
                lblRe.ForeColor = Color.Red;
            }
            BDConexicon.RenaClose();
        }

        public void VelazquezOferta()
        {
            try
            {
                DateTime Finicio = dt_Inicio.Value;
                DateTime Ffin = dt_Fin.Value;

                string inicio = getDate(Finicio);
                string fin = getDate(Ffin);



                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET oferta=1  WHERE articulo=?articulo", BDConexicon.VelazquezOpen());
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();

                MySqlCommand cmdo = new MySqlCommand("DELETE FROM ofertas WHERE articulo=?articulo", BDConexicon.VelazquezOpen());
                cmdo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                MySqlDataReader mdr;
                mdr = cmdo.ExecuteReader();
                mdr.Close();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO ofertas(articulo,fechainicial,fechafinal,porporcentaje,porcentaje) VALUES(?articulo,?fechainicial,?fechafinal,?porporcentaje,?porcentaje)", BDConexicon.VelazquezOpen());
                cmd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                cmd.Parameters.Add("?fechainicial", MySqlDbType.VarChar).Value = inicio;
                cmd.Parameters.Add("?fechafinal", MySqlDbType.VarChar).Value = fin;
                cmd.Parameters.Add("?porporcentaje", MySqlDbType.Int16).Value = 1;
                cmd.Parameters.Add("?porcentaje", MySqlDbType.Float).Value = (float)Convert.ToDouble(tbporcentaje.Text);
                cmd.ExecuteNonQuery();

                //limpiarOferta();

                lblVe.Text = "OK";
                //MessageBox.Show("Los datos se Guardaron");
            }
            catch (Exception e)
            {
                lblVe.Text = "N/A";
                lblVe.ForeColor = Color.Red;
            }

            BDConexicon.VelazquezClose();
        }

        public void ColosoOferta()
        {
            try
            {
                DateTime Finicio = dt_Inicio.Value;
                DateTime Ffin = dt_Fin.Value;

                string inicio = getDate(Finicio);
                string fin = getDate(Ffin);



                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET oferta=1  WHERE articulo=?articulo", BDConexicon.ColosoOpen());
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();

                MySqlCommand cmdo = new MySqlCommand("DELETE FROM ofertas WHERE articulo=?articulo", BDConexicon.ColosoOpen());
                cmdo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                MySqlDataReader mdr;
                mdr = cmdo.ExecuteReader();
                mdr.Close();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO ofertas(articulo,fechainicial,fechafinal,porporcentaje,porcentaje) VALUES(?articulo,?fechainicial,?fechafinal,?porporcentaje,?porcentaje)", BDConexicon.ColosoOpen());
                cmd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                cmd.Parameters.Add("?fechainicial", MySqlDbType.VarChar).Value = inicio;
                cmd.Parameters.Add("?fechafinal", MySqlDbType.VarChar).Value = fin;
                cmd.Parameters.Add("?porporcentaje", MySqlDbType.Int16).Value = 1;
                cmd.Parameters.Add("?porcentaje", MySqlDbType.Float).Value = (float)Convert.ToDouble(tbporcentaje.Text);
                cmd.ExecuteNonQuery();

               // limpiarOferta();

                lblCo.Text = "OK";
                //MessageBox.Show("Los datos se Guardaron");
            }
            catch (Exception e)
            {
                lblCo.Text = "N/A";
                lblCo.ForeColor = Color.Red;
            }

            BDConexicon.ColosoClose();
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
                panelPrecio.Enabled = true;
            }
            else
            {
                panelPrecio.Enabled = false;
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
        }

        private void AplicaOferta_Click_1(object sender, EventArgs e)
        {
            //if (cBoxVa.Checked == false & cBoxRe.Checked == false & cBoxVe.Checked == false & cBoxCo.Checked == false)
            //{
            //    MessageBox.Show("Selecciona una Tienda para aplicar la Oferta");
            //}
            //if (cBoxVa.Checked)
            //{
            //    if (string.IsNullOrEmpty(TB_articulo.Text))
            //    {
            //        MessageBox.Show("Inserta Codigo de Articulo");

            //    }
            //    else if (string.IsNullOrEmpty(tbporcentaje.Text))
            //    {
            //        MessageBox.Show("Inserta Porcentaje de Descuento");
            //    }
            //    else
            //    {
            //        VallartaOferta();
            //        //MessageBox.Show("Vallarta");
            //    }

            //}
            //if (cBoxRe.Checked)
            //{
            //    if (string.IsNullOrEmpty(TB_articulo.Text))
            //    {
            //        MessageBox.Show("Inserta Codigo de Articulo");

            //    }
            //    else if (string.IsNullOrEmpty(tbporcentaje.Text))
            //    {
            //        MessageBox.Show("Inserta Porcentaje de Descuento");
            //    }
            //    else
            //    {
            //        RenaOferta();
            //        //MessageBox.Show("Rena");
            //    }
                
            //}
            //if (cBoxVe.Checked)
            //{
            //    if (string.IsNullOrEmpty(TB_articulo.Text))
            //    {
            //        MessageBox.Show("Inserta Codigo de Articulo");

            //    }
            //    else if (string.IsNullOrEmpty(tbporcentaje.Text))
            //    {
            //        MessageBox.Show("Inserta Porcentaje de Descuento");
            //    }
            //    else
            //    {
            //        VelazquezOferta();
            //        //MessageBox.Show("Velazquez");
            //    }
            //}
            //if (cBoxCo.Checked)
            //{
            //    if (string.IsNullOrEmpty(TB_articulo.Text))
            //    {
            //        MessageBox.Show("Inserta Codigo de Articulo");

            //    }
            //    else if (string.IsNullOrEmpty(tbporcentaje.Text))
            //    {
            //        MessageBox.Show("Inserta Porcentaje de Descuento");
            //    }
            //    else
            //    {
            //        ColosoOferta();
            //        //MessageBox.Show("Coloso");
            //    }
            //}
            //else
            //{
            //    limpiarOferta();
            //}

        }

        //private void cBoxTodas_CheckedChanged_2(object sender, EventArgs e)
        //{
        //    if (cBoxTodas.Checked)
        //    {
        //        cBoxVa.Checked = true;
        //        cBoxRe.Checked = true;
        //        cBoxVe.Checked = true;
        //        cBoxCo.Checked = true;
        //    }
        //    else if (!cBoxTodas.Checked)
        //    {
        //        cBoxVa.Checked = false;
        //        cBoxRe.Checked = false;
        //        cBoxVe.Checked = false;
        //        cBoxCo.Checked = false;
        //    }
        //}

        private void AplicaOferta_Click_2(object sender, EventArgs e)
        {
            if (cBoxVa.Checked == false & cBoxRe.Checked == false & cBoxVe.Checked == false & cBoxCo.Checked == false)
            {
                MessageBox.Show("Selecciona una Tienda para aplicar la Oferta");
            }
            if (cBoxVa.Checked)
            {
                if (string.IsNullOrEmpty(TB_articulo.Text))
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
                if (string.IsNullOrEmpty(TB_articulo.Text))
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
                if (string.IsNullOrEmpty(TB_articulo.Text))
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
                if (string.IsNullOrEmpty(TB_articulo.Text))
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

        private void lblVe_Click(object sender, EventArgs e)
        {

        }

        private void borrarArticulo()
        {
            TB_articulo.Text = "";
            TB_desc.Text = "";
            TB_precio1.Text = "";
            TB_precio2.Text = "";
            TB_costo.Text = "";
            TB_fabricante.Text = "";

            TB_bodega.Text = "";
            TB_coloso.Text = "";
            TB_rena.Text = "";
            TB_vallarta.Text = "";
            TB_velazquez.Text = "";

            Lb_bodega.Text = "";
            LB_rena.Text = "";
            LB_coloso.Text = "";
            LB_vallarta.Text = "";
            LB_velazquez.Text = "";
        }

        private void BT_limpiar_Click(object sender, EventArgs e)
        {
            borrarArticulo();
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
                if (string.IsNullOrEmpty(TB_articulo.Text))
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
                if (string.IsNullOrEmpty(TB_articulo.Text))
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
                if (string.IsNullOrEmpty(TB_articulo.Text))
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
                if (string.IsNullOrEmpty(TB_articulo.Text))
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
                if (string.IsNullOrEmpty(TB_articulo.Text))
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
                if (string.IsNullOrEmpty(TB_articulo.Text))
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
                if (string.IsNullOrEmpty(TB_articulo.Text))
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
                if (string.IsNullOrEmpty(TB_articulo.Text))
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
            try
            {

                double Precio1 = Convert.ToDouble(tbPrecio1.Text);
                double Precio2 = Convert.ToDouble(tbPrecio2.Text);
                Precio1 = Precio1 / 1.16;
                Precio2 = Precio2 / 1.16;


                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET precio1=?precio1,precio2=?precio2  WHERE articulo=?articulo", BDConexicon.VallartaOpen());
                cmdoo.Parameters.Add("?precio1", MySqlDbType.VarChar).Value = Precio1;
                cmdoo.Parameters.Add("?precio2", MySqlDbType.VarChar).Value = Precio2;
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();
              

                lblVaPre.Text = "OK";
                lblVaPre.ForeColor = Color.DarkGreen;
                
            }
            catch (Exception e)
            {
                lblVaPre.Text = "N/A";
                lblVaPre.ForeColor = Color.Red;
            }
            BDConexicon.VallartaClose();
        }

        

        private void RenaPrecio()
        {
            try
            {

                double Precio1 = Convert.ToDouble(tbPrecio1.Text);
                double Precio2 = Convert.ToDouble(tbPrecio2.Text);
                Precio1 = Precio1 / 1.16;
                Precio2 = Precio2 / 1.16;


                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET precio1=?precio1,precio2=?precio2  WHERE articulo=?articulo", BDConexicon.RenaOpen());
                cmdoo.Parameters.Add("?precio1", MySqlDbType.VarChar).Value = Precio1;
                cmdoo.Parameters.Add("?precio2", MySqlDbType.VarChar).Value = Precio2;
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();


                lblRePre.Text = "OK";
                lblRePre.ForeColor = Color.DarkGreen;

            }
            catch (Exception e)
            {
                lblRePre.Text = "N/A";
                lblRePre.ForeColor = Color.Red;
            }
            BDConexicon.RenaClose();
        }

        private void VelazquezPrecio()
        {
            try
            {

                double Precio1 = Convert.ToDouble(tbPrecio1.Text);
                double Precio2 = Convert.ToDouble(tbPrecio2.Text);
                Precio1 = Precio1 / 1.16;
                Precio2 = Precio2 / 1.16;


                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET precio1=?precio1,precio2=?precio2  WHERE articulo=?articulo", BDConexicon.VelazquezOpen());
                cmdoo.Parameters.Add("?precio1", MySqlDbType.VarChar).Value = Precio1;
                cmdoo.Parameters.Add("?precio2", MySqlDbType.VarChar).Value = Precio2;
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();


                lblVePre.Text = "OK";
                lblVePre.ForeColor = Color.DarkGreen;

            }
            catch (Exception e)
            {
                lblVePre.Text = "N/A";
                lblVePre.ForeColor = Color.Red;
            }
            BDConexicon.VelazquezClose();
        }

        private void ColosoPrecio()
        {
            try
            {

                double Precio1 = Convert.ToDouble(tbPrecio1.Text);
                double Precio2 = Convert.ToDouble(tbPrecio2.Text);
                Precio1 = Precio1 / 1.16;
                Precio2 = Precio2 / 1.16;


                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET precio1=?precio1,precio2=?precio2  WHERE articulo=?articulo", BDConexicon.ColosoOpen());
                cmdoo.Parameters.Add("?precio1", MySqlDbType.VarChar).Value = Precio1;
                cmdoo.Parameters.Add("?precio2", MySqlDbType.VarChar).Value = Precio2;
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();


                lblCoPre.Text = "OK";
                lblCoPre.ForeColor = Color.DarkGreen;

            }
            catch (Exception e)
            {
                lblCoPre.Text = "N/A";
                lblCoPre.ForeColor = Color.Red;
            }
            BDConexicon.ColosoClose();
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

        private void BT_limpiar_Click_1(object sender, EventArgs e)
        {
            borrarArticulo();
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
        }

        private void TB_articulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TB_articulo.Text.Equals(""))
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
                    //Bodega();
                    Vallarta();
                    Rena();
                    Velazquez();

                    Coloso();



                }
            }

            if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                borrarArticulo();
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
                TB_articulo.Focus();
                TB_articulo.SelectAll();
                SendKeys.Send("{BACKSPACE}");
            }
        }
    }
}
