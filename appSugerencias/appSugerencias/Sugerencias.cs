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
    public partial class Sugerencias : Form
    {
        public Sugerencias()
        {
            InitializeComponent();
        }

        private void Sugerencias_Load(object sender, EventArgs e)
        {

        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {



            if (TB_sugerencia.Text.Equals(""))
            {
                MessageBox.Show("Introduce tu sugerencia");
            }
            else
            {
                MySqlConnection con = BDConexicon.conectar();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO rd_sugerencias(cajera,sugerencia,fecha) VALUES (?cajera,?sugerencia,?fecha)", con);
                cmd.Parameters.AddWithValue("?cajera", LB_cajera.Text);
                cmd.Parameters.AddWithValue("?sugerencia", TB_sugerencia.Text.ToUpper());
                DateTime fecha = DateTime.Now;
                cmd.Parameters.AddWithValue("?fecha", fecha);
                cmd.ExecuteNonQuery();
                TB_sugerencia.Text = "";
                MessageBox.Show("Se ha guardado tu sugerencia, !muchas gracias!");
                con.Close();
            }
            
        }
    }
}
