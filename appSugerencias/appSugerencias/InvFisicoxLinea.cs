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
        string[] articulos;//GUARDA LOS ARTICULOS DE LA LINEA
        int[] entradas;//GUARDA LAS EXISTENCIAS DE LOS ARTICULOS DE LA LINEA
        int[] salidas;

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
          
            //FIN: OBTENER CANTIDAD DE ARTICULOS EN LA LINEA



            //TRAER EL ARTICULO DE LA LINEA SELECCIONADA
            int x = 0;
            articulos = new string[cuantos];
            MySqlCommand cmd1 = new MySqlCommand("SELECT ARTICULO FROM PRODS WHERE LINEA ='"+CB_lineas.SelectedItem.ToString()+"'ORDER BY ARTICULO",con);
            //DataTable productos = new DataTable();
            //MySqlDataAdapter ad = new MySqlDataAdapter(cmd1);
            //ad.Fill(productos);
            MySqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                articulos[x] = dr1["ARTICULO"].ToString();
                x++;
            }
            dr1.Close();
            //FIN TRAER EL ARTICULO DE LA LINEA SELECCIONADA


            for (int i = 0;  i< articulos.Length; i++)
            {
                MySqlCommand cmd2 = new MySqlCommand("SELECT SUM( IF( almacen = 1 AND ent_sal = 'E', cantidad, 0 ) ) As entradas FROM movsinv WHERE articulo ='" + articulos[i] + "'ORDER BY ARTICULO", con);
                MySqlDataReader dr2 = cmd2.ExecuteReader();

                while (dr2.Read())
                {
                    entradas[i] = Convert.ToInt32(dr2["entradas"].ToString());
                }
            }


            for (int j = 0; j < articulos.Length; j++)
            {
                MySqlCommand cmd2 = new MySqlCommand("SELECT SUM( IF( almacen = 1 AND ent_sal = 'S', cantidad, 0 ) ) As salidas FROM movsinv WHERE articulo ='" + articulos[j] + "'ORDER BY ARTICULO", con);
                MySqlDataReader dr2 = cmd2.ExecuteReader();

                while (dr2.Read())
                {
                    salidas[j] = Convert.ToInt32(dr2["salidas"].ToString());
                }
            }
        }
    }
}
