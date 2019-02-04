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
    public partial class Traspasos : Form
    {
        public Traspasos()
        {
            InitializeComponent();
        }


        //################################# OBTIENE EL NOMBRE DE LA SUCURSAL ##############################################################

        public void Sucursal()
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
                if (sucursal.Equals("OSMART RENA"))
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





        private void Traspasos_Load(object sender, EventArgs e)
        {
            Sucursal();
            DG_datos.Columns[2].Width = 300;
            DG_datos.Columns[3].Width = 70;
        }

        private void BT_agregar_Click(object sender, EventArgs e)
        {

        }
    }
}
