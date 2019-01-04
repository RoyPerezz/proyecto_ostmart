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
                }
                LB_vallarta.Text = "Conectado";

            }
            catch (Exception e)
            {
                LB_vallarta.Text = "Sin conexion";
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
            }
            }
            catch (Exception e)
            {

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
            }


            }
            catch (Exception e)
            {

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
            }
            }
            catch (Exception e)
            {

            }
        }

      


        private void BTN_aceptar_Click(object sender, EventArgs e)
        {

            if (TB_articulo.Text.Equals(""))
            {
                MessageBox.Show("Ingresa un artículo");
            }
            if (CB_sucursal.SelectedItem=="Vallarta")
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

            if (CB_sucursal.SelectedIndex==-1)
            {
                Vallarta();
                Velazquez();
                Rena();
                Coloso();
            }


        }
    }
}
