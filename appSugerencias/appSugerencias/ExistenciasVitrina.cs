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
        MySqlConnection bodega;

        private void ExistenciasVitrina_Load(object sender, EventArgs e)
        {

        }


        //################################################  ESTE METODO TRAE LOS DATOS DEL PRODUCTO DE LA BD LOCAL  ###################################################
        public void DatosProducto()
        {
            vRena = BDConexicon.V_rena();

            try
            {
                string consulta = "SELECT descrip,precio1,precio2,costo_u,fabricante,existencia from prods where articulo='" + TB_clave.Text + "'";
                MySqlCommand cmd = new MySqlCommand(consulta, vRena);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    TB_descripcion.Text = dr["descrip"].ToString();
                    TB_menudeo.Text = dr["precio1"].ToString();
                    TB_mayoreo.Text = dr["precio2"].ToString();
                    TB_costo.Text = dr["costo_u"].ToString();
                    TB_fabricante.Text = dr["fabricante"].ToString();
                    TB_rena.Text = dr["existencia"].ToString();

                }
                else
                {
                    TB_rena.ForeColor = Color.Red;
                    TB_rena.Text = "No existe";
                    MessageBox.Show("EL PRODUCTO NO EXISTE EN TU SUCURSAL, O LA CLAVE FUE MAL ESCRITA");
                }

                dr.Close();
                vRena.Close();
            }
            catch (Exception)
            {
                TB_vallarta.ForeColor = Color.Red;
                TB_vallarta.Text = "Sin Conexión";

            }






        }


        public void ExistenciaVA()
        {
            try
            {
                vVallarta = BDConexicon.V_vallarta();
                string consulta = "SELECT existencia from prods where articulo='" + TB_clave.Text + "'";
                MySqlCommand cmd = new MySqlCommand(consulta, vVallarta);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    TB_vallarta.Text = dr["existencia"].ToString();
                }
                else
                {
                    TB_vallarta.ForeColor = Color.Red;
                    TB_vallarta.Text = "No existe";
                }

                dr.Close();
                vVallarta.Close();
            }
            catch (Exception ex)
            {
                TB_vallarta.ForeColor = Color.Red;
                TB_vallarta.Text = "Sin conexion";
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
            ExistenciaVA();
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
                ExistenciaVA();
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

       
    }
}
