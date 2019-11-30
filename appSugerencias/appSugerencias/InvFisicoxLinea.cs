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
    public partial class InvFisicoxLinea : Form
    {
        public InvFisicoxLinea()
        {
            InitializeComponent();
        }



        MySqlConnection con; //VARIABLE GLOBAL DE CONEXION A LA BD
        int cuantos = 0;//GUARDA CUANTOS PRODUCTOS HAY EN UNA LINEA

        //LLENA EL COMBOBOX CON LAS LINEAS DE PRODUCTOS
        public void CargarLineas()
        {
            con = BDConexicon.conectar();

            MySqlCommand cmd = new MySqlCommand("SELECT linea FROM lineas ORDER BY linea", con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                CB_lineas.Items.Add(dr["linea"].ToString());
            }

            dr.Close();
            con.Close();
        }
        //FIN LLENA EL COMBOBOX CON LAS LINEAS DE PRODUCTOS

        //CARGA LAS LINEA DE PRODUCTOS ENE L COMBOBOX AL INICIAR EL FORM
        private void InvFisicoxLinea_Load(object sender, EventArgs e)
        {
            CargarLineas();
        }
        //FIN CARGA LAS LINEA DE PRODUCTOS ENE L COMBOBOX AL INICIAR EL FORM

       
        private void BT_recalcular_Click(object sender, EventArgs e)
        {

            MySqlConnection con = BDConexicon.conectar();

            //OBTENER CANTIDAD DE ARTICULOS EN LA LINEA
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) as cuantos FROM PRODS WHERE LINEA ='"+CB_lineas.SelectedItem.ToString()+"'",con);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cuantos = Convert.ToInt32(dr["cuantos"].ToString());
            }
            else
            {
                MessageBox.Show("LA LINEA NO TIENE ARTICULOS");
            }
        
            dr.Close();
            con.Close();
            //FIN: OBTENER CANTIDAD DE ARTICULOS EN LA LINEA

            //TRAER EL ARTICULO, DESCRIPCION Y EXISTENCIA DE LA LINEA SELECCIONADA
            MySqlCommand cmd1 = new MySqlCommand("SELECT ARTICULO, DESCRIP, EXISTENCIA FROM PRODS WHERE LINEA ='"+CB_lineas.SelectedItem.ToString()+"'",con);
            DataTable productos = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd1);
            ad.Fill(productos);

           
            //FIN TRAER EL ARTICULO, DESCRIPCION Y EXISTENCIA DE LA LINEA SELECCIONADA
        }
    }
}
