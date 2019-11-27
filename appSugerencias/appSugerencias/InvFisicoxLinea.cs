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
        MySqlConnection con;


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
        private void InvFisicoxLinea_Load(object sender, EventArgs e)
        {
            CargarLineas();
        }
    }
}
