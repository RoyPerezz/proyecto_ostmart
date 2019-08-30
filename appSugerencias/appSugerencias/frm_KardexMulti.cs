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
    public partial class frm_KardexMulti : Form
    {
        public frm_KardexMulti()
        {
            InitializeComponent();
        }

        MySqlConnection conex_kardex;

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = proBar.Value.ToString();
        }


        public void llamadaTiendas(string tienda)
        {


            
            if (tienda == "BODEGA")
            {
                try
                {
                    conex_kardex = BDConexicon.BodegaOpen();
                    // selectDatos();
                    conex_kardex.Close();

                    lblConexion.Text = "Conectado Bo";
                    lblConexion.ForeColor = Color.DarkGreen;

                }
                catch (Exception e)
                {
                    lblConexion.Text = "Sin Conexion Bo";
                    lblConexion.ForeColor = Color.Red;
                }

            }
            else if (tienda == "VALLARTA")
            {
                try
                {
                    conex_kardex = BDConexicon.VallartaOpen();
                    //selectDatos();
                    conex_kardex.Close();
                    lblConexion.Text = "Conectado Va";
                    lblConexion.ForeColor = Color.DarkGreen;

                }
                catch (Exception e)
                {
                    lblConexion.Text = "Sin Conexion VA";
                    lblConexion.ForeColor = Color.Red;
                }

            }
            else if (tienda == "RENA")
            {
                try
                {
                    conex_kardex = BDConexicon.RenaOpen();
                    //selectDatos();
                    conex_kardex.Close();
                    lblConexion.Text = "Conectado RE";
                    lblConexion.ForeColor = Color.DarkGreen;
                }
                catch (Exception e)
                {
                    lblConexion.Text = "Sin Conexion RE";
                    lblConexion.ForeColor = Color.Red;
                  
                }


            }
            else if (tienda == "VELAZQUEZ")
            {

                try
                {
                    conex_kardex = BDConexicon.VelazquezOpen();
                    //selectDatos();
                    conex_kardex.Close();
                    lblConexion.Text = "Conectado VE";
                    lblConexion.ForeColor = Color.DarkGreen;
                }
                catch (Exception e)
                {
                    lblConexion.Text = "Sin Conexion VE";
                    lblConexion.ForeColor = Color.Red;
                    
                }

            }
            else if (tienda == "COLOSO")
            {

                try
                {
                    conex_kardex = BDConexicon.ColosoOpen();
                    //selectDatos();
                    conex_kardex.Close();
                    lblConexion.Text = "Conectado CO";
                    lblConexion.ForeColor = Color.DarkGreen;
                }
                catch (Exception e)
                {
                    lblConexion.Text = "Sin Conexion CO";
                    lblConexion.ForeColor = Color.Red;
                 
                }

            }

            else if (tienda == "PREGOT")
            {

                try
                {
                    conex_kardex = BDConexicon.Papeleria1Open();
                    //selectDatos();
                    conex_kardex.Close();

                    lblConexion.Text = "Conectado PA";
                    lblConexion.ForeColor = Color.DarkGreen;
                }
                catch (Exception e)
                {
                    lblConexion.Text = "Sin Conexion PA";
                    lblConexion.ForeColor = Color.Red;
                    
                }

            }

        }
        //########## CIERRE ############

        private void frm_KardexMulti_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            llamadaTiendas(cbTienda.Text);
        }
    }
}
