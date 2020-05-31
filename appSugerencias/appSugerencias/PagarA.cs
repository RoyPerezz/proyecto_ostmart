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
    public partial class PagarA : Form      
    {
        string proveedor = "", nombre = "", banco = "";

        private void BT_registrar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = BDConexicon.BodegaOpen();

            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO rd_persona_parapagar(fkproveedor,nombreprov,banco,persona)VALUES(?fkproveedor,?nombreprov,?banco,?persona)",con);
                cmd.Parameters.AddWithValue("?fkproveedor",TB_proveedor.Text);
                cmd.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
                cmd.Parameters.AddWithValue("?banco", TB_banco.Text);
                cmd.Parameters.AddWithValue("?persona", TB_persona.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha registrado a la persona correctamente");

            }
            catch (Exception ex)
            {
;               MessageBox.Show("Error añ registrar a la persona "+ex);
            }
        }

        public PagarA(string proveedor, string nombre,string banco)
        {
            InitializeComponent();
            this.proveedor = proveedor;
            this.nombre = nombre;
            this.banco = banco;
        }

        private void PagarA_Load(object sender, EventArgs e)
        {
            TB_proveedor.Text = proveedor;
            TB_nombre.Text = nombre;
            TB_banco.Text = banco;
        }
    }
}
