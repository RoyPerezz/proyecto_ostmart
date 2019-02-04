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
    public partial class CotizacionTraspaso : Form
    {
        public CotizacionTraspaso()
        {
            InitializeComponent();
        }


        //########################### OBTIENE EL NOMBRE DE LA SUCURSAL ################################################################
        public void Sucursal()// obtiene el nombre de la sucursal, debe cambiar el método de conexión según la suc. donde se use
        {
            string sucursal = "";
            MySqlCommand cmd = new MySqlCommand("select empresa from econfig", BDConexicon.conectar());

            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                sucursal = rd[0].ToString();

                if (sucursal.Equals("OSMART VALLARTA"))
                {
                    TB_origen.Text = "VA";
                }
                if (sucursal.Equals("OSMART RENACIMIENTO"))
                {
                    TB_origen.Text = "RE";
                }
                if (sucursal.Equals("OSMART COLOSO"))
                {
                    TB_origen.Text = "CO";
                }
                if (sucursal.Equals("OSMART VELAZQUEZ"))
                {
                    TB_origen.Text = "VE";
                }
                if (sucursal.Equals("BODEGA"))
                {
                    TB_origen.Text = "BO";
                }
            }

            BDConexicon.ConectarClose();

        }


        private void CotizacionTraspaso_Load(object sender, EventArgs e)
        {
            Sucursal();
            DG_datos.Columns[2].Width = 330;
            DG_datos.Columns[3].Width = 75;
        }
    }
}
