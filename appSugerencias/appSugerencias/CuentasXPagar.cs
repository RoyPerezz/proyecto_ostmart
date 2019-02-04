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
    public partial class CuentasXPagar : Form
    {
        public CuentasXPagar()
        {
            InitializeComponent();
        }

        String codprov = "";

        //********************************** OBTENGO LOS PROVEEDORES Y LOS ASIGNO A UN COMBOBOX******************************************************
        public void proveedores()
        {
           
            MySqlCommand cmd = new MySqlCommand("select nombre from proveed order by nombre",BDConexicon.prueba());
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                CB_proveedor.Items.Add(rd["nombre"].ToString());
            }

            rd.Close();

            

        }

        //***************************** obtener datos de la tabla cuenxpdet ******************************************************************************

        public void Cuentaspend()
        {
            MySqlCommand cmd = new MySqlCommand("select sum(importe)", BDConexicon.prueba());
            MySqlDataReader rd = cmd.ExecuteReader();

        }




        //***************************** LLENAR DATAGRIDVIEW CON LOS DATOS DE ESE PROVEEDOR A QUIEN SE LE VA A PAGAR****************************************

        public void llenarGrid()
        {
            MySqlCommand cmd = new MySqlCommand("select fecha,importe from cuenxpag where proveedor='"+CB_proveedor.SelectedItem.ToString()+"'", BDConexicon.prueba());
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                DG_historial.Rows.Add(rd["fecha"].ToString(),rd["importe"].ToString());
            }

        }





        private void CuentasXPagar_Load(object sender, EventArgs e)
        {
            proveedores();
        }

   

        private void CB_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //OBTENGO EL ID DEL PROVEEDOR SELECCIONADO EN EL COMBOBOX
            MySqlCommand cmd2 = new MySqlCommand("select proveedor from proveed where nombre='" + CB_proveedor.SelectedItem.ToString() + "'", BDConexicon.prueba());
            MySqlDataReader rd2 = cmd2.ExecuteReader();
            while (rd2.Read())
            {
                codprov = rd2["PROVEEDOR"].ToString();
            }

            //MessageBox.Show("CODIGO:"+codprov);
        }
    }
}
