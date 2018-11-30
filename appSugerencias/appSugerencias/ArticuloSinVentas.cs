using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace appSugerencias
{
    public partial class ArticuloSinVentas : Form
    {
        public ArticuloSinVentas()
        {
            InitializeComponent();
        }



        public void selecionar(string comando)
        {

            MySqlCommand cmd = new MySqlCommand(comando, BDConexicon.conectar());
            cmd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = textBoxCodigo.Text;
            MySqlDataReader mdr;
            mdr=cmd.ExecuteReader();

            if (mdr.Read())
            {
                textboxDescrip.Text = mdr.GetString("DESCRIP");
                textboxPrecio.Text = mdr.GetFloat("PRECIO1").ToString();
                textboxProveedor.Text = mdr.GetString("FABRICANTE");
                textboxPiezas.Text = mdr.GetInt32("EXISTENCIA").ToString();
            }
            else
            {
                MessageBox.Show("No se encotro el articulo");
            }
            

        }

        public void insertarArticulo( string comando)
        {

        }



















        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ArticuloSinVentas_Load(object sender, EventArgs e)
        {
            textboxDescrip.Enabled = false;
            textboxProveedor.Enabled = false;
            textboxPrecio.Enabled = false;
            textboxPiezas.Enabled = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            selecionar("select * from prods where articulo =?articulo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            insertarArticulo("");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
