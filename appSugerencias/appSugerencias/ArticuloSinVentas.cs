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

            MySqlCommand cmd = new MySqlCommand(comando, BDConexicon.VallartaOpen());
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

        public void insertarArticulo(string comando )
        {
            
            MySqlCommand cmd = new MySqlCommand(comando, BDConexicon.VallartaOpen());
            cmd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = textBoxCodigo.Text;
            cmd.Parameters.Add("?motivo", MySqlDbType.VarChar).Value = textboxNoSeVende.Text.ToUpper();
            cmd.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = textboxUsuario.Text.ToUpper(); ;
            cmd.Parameters.Add("?departamento", MySqlDbType.VarChar).Value = comboboxDepa.Text;
            cmd.Parameters.Add("?fecha", MySqlDbType.Date).Value = DateTime.Now;
            cmd.ExecuteNonQuery();
            limpiar();
            MessageBox.Show("Los datos se Guardaron");
        }

        public void limpiar()
        {
            textBoxCodigo.Text = "";
            textboxDescrip.Text = "";
            textboxNoSeVende.Text = "";
            textboxPiezas.Text = "";
            textboxPrecio.Text = "";
            textboxProveedor.Text = "";
            textboxUsuario.Text="";
            comboboxDepa.Text = null;
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
            if (string.IsNullOrEmpty(textBoxCodigo.Text))
            {
                MessageBox.Show("Especifica un articulo");
            }
            else
            {
                selecionar("select * from prods where articulo =?articulo");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCodigo.Text))
            {
                MessageBox.Show("Especifica un articulo");
            }
            else if (string.IsNullOrEmpty(textboxNoSeVende.Text))
            {
                MessageBox.Show("Especifique un motivo");
            }
            else if (string.IsNullOrEmpty(textboxUsuario.Text))
            {
                MessageBox.Show("Especifique un Usuario");
            }
            else if (string.IsNullOrEmpty(comboboxDepa.Text))
            {
                MessageBox.Show("Seleccione un Departamento");
            }
            else
            {
                insertarArticulo("insert into RD_sinventas(articulo,motivo,departamento,usuario,fecha) values (?articulo,?motivo,?departamento,?usuario,?fecha)");
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboboxDepa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
