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
        public Existencias()
        {
            InitializeComponent();
        }


        public void Vallarta()
        {
            
            try
            {


                MySqlCommand cmd = new MySqlCommand("select existencia from prods where articulo='" + TB_articulo.Text + "'", BDConexicon.conectar());
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    TB_vallarta.Text = rd[0].ToString();
                    LB_vallarta.Text = "Conectado";
                }
               

            }
            catch (Exception e)
            {
                LB_vallarta.Text = "Sin conexion";
                LB_vallarta.ForeColor = Color.Red;
            }
        }

        public void Velazquez()
        {

            try { 
            MySqlCommand cmd = new MySqlCommand("select existencia from prods where articulo='" + TB_articulo.Text + "'", BDConexicon.Velazquez());
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                TB_velazquez.Text = rd[0].ToString();
                    LB_velazquez.Text = "Conectado";
                }
                
            }
            catch (Exception e)
            {
                LB_velazquez.Text = "Sin conexion";
                LB_velazquez.ForeColor = Color.Red;
            }
        }

        public void Rena()
        {
            try { 
            MySqlCommand cmd = new MySqlCommand("select existencia from prods where articulo='" + TB_articulo.Text + "'", BDConexicon.Rena());
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                TB_rena.Text = rd[0].ToString();
                    LB_rena.Text = "Conectado";
                }
               
                

            }
            catch (Exception e)
            {
                LB_rena.Text = "Sin conexion";
                LB_rena.ForeColor = Color.Red;
            }
        }

        public void Coloso()
        {
            try { 
            MySqlCommand cmd = new MySqlCommand("select existencia from prods where articulo='" + TB_articulo.Text + "'", BDConexicon.Coloso());
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                TB_coloso.Text = rd[0].ToString();
                LB_coloso.Text = "Conectado";
            }
               
            }
            catch (Exception e)
            {
                LB_coloso.Text = "Sin conexion";
                LB_coloso.ForeColor = Color.Red;
            }
        }

        public void Bodega()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("select existencia from prods where articulo='" + TB_articulo.Text + "'",BDConexicon.Bodega());
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    TB_bodega.Text = rd[0].ToString();
                    Lb_bodega.Text = "Conectado";
                }
               
            }
            catch (Exception e)
            {
                Lb_bodega.Text = "Sin conexion";
                Lb_bodega.ForeColor = Color.Red;
            }
        }




        private void BTN_aceptar_Click(object sender, EventArgs e)
        {



          
            if (TB_articulo.Text.Equals(""))
            {
                MessageBox.Show("Ingresa un artículo");
            }
            else
            {

                if (CB_sucursal.SelectedItem == "Vallarta")
                {
                    Vallarta();
                }

                if (CB_sucursal.SelectedItem == "Velazquez")
                {
                    Velazquez();
                }

                if (CB_sucursal.SelectedItem == "Rena")
                {
                    Rena();
                }

                if (CB_sucursal.SelectedItem == "Coloso")
                {
                    Coloso();
                }

                if (CB_sucursal.SelectedIndex == -1)
                {
                    Vallarta();
                    Velazquez();
                    Rena();
                    Coloso();
                    Bodega();
                }
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
            DateTime Finicio = dt_Inicio.Value;
            DateTime Ffin = dt_Fin.Value;

            string inicio = getDate(Finicio);
            string fin = getDate(Ffin);

            MySqlCommand cmdo = new MySqlCommand("DELETE FROM ofertas WHERE articulo=?articulo", BDConexicon.conectar());
            cmdo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
            MySqlDataReader mdr;
            mdr = cmdo.ExecuteReader();

            MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET oferta=1  WHERE articulo=?articulo", BDConexicon.conectar());
            cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
            MySqlDataReader mdrr;
            mdrr = cmdoo.ExecuteReader();


            MySqlCommand cmd = new MySqlCommand("INSERT INTO ofertas(articulo,fechainicial,fechafinal,porporcentaje,porcentaje) VALUES(?articulo,?fechainicial,?fechafinal,?porporcentaje,?porcentaje)", BDConexicon.conectar());
            cmd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
            cmd.Parameters.Add("?fechainicial", MySqlDbType.VarChar).Value = inicio;
            cmd.Parameters.Add("?fechafinal", MySqlDbType.VarChar).Value = fin ;
            cmd.Parameters.Add("?porporcentaje", MySqlDbType.Int16).Value = 1;
            cmd.Parameters.Add("?porcentaje", MySqlDbType.Float).Value = (float)Convert.ToDouble(tbporcentaje.Text);
            cmd.ExecuteNonQuery();

            limpiarOferta();

            MessageBox.Show("Los datos se Guardaron");
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
            if(cBoxVa.Checked==false & cBoxRe.Checked == false & cBoxVe.Checked == false & cBoxCo.Checked == false )
            {
                MessageBox.Show("Selecciona una Tienda para aplicar la Oferta");
            }
            if (cBoxVa.Checked)
            {
                if (string.IsNullOrEmpty(TB_articulo.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if(string.IsNullOrEmpty(tbporcentaje.Text))
                {
                    MessageBox.Show("Inserta Porcentaje de Descuento");
                }
                else
                {
                    VallartaOferta();
                }

            }
             if (cBoxRe.Checked)
            {
                MessageBox.Show("Rena");
            }
             if (cBoxVe.Checked)
            {
                MessageBox.Show("Velazquez");
            }
             if (cBoxCo.Checked)
            {
                MessageBox.Show("Coloso");
            }
            
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void Existencias_Load_1(object sender, EventArgs e)
        {

        }
    }
}
