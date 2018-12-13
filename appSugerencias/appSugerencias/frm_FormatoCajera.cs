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
    public partial class frm_FormatoCajera : Form
    {
        string Usuario;
        public frm_FormatoCajera()
        {
            InitializeComponent();
        }

        public frm_FormatoCajera(string usu)
        {
            InitializeComponent();
            Usuario = usu;
            lblUsuario.Text = Usuario;
        }

        private void frm_FormatoCajera_Load(object sender, EventArgs e)
        {
            textboxDescrip.Enabled = false;
            textboxPiezas.Enabled = false;
            textboxPrecio.Enabled = false;
            textboxProveedor.Enabled = false;
        }

        public void insertarArticulo(string comando)
        {

            MySqlCommand cmd = new MySqlCommand(comando, BDConexicon.conectar());
            cmd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = textBoxCodigo.Text;
            cmd.Parameters.Add("?cantidad", MySqlDbType.VarChar).Value = textboxCantidad.Text;
            cmd.Parameters.Add("?anomalia", MySqlDbType.VarChar).Value = comboboxAlter.Text.ToUpper();
            cmd.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = Usuario;
            cmd.Parameters.Add("?hora", MySqlDbType.VarChar).Value = DateTime.Now.ToString("HH:mm:ss");

            cmd.Parameters.Add("?fecha", MySqlDbType.Date).Value = DateTime.Now;
            cmd.Parameters.Add("?validado", MySqlDbType.VarChar).Value = 0;
            cmd.ExecuteNonQuery();
            limpiar();
            MessageBox.Show("Los datos se Guardaron");
        }


        public void limpiar()
        {
            textBoxCodigo.Text = "";
            textboxDescrip.Text = "";
            
            textboxPiezas.Text = "";
            textboxPrecio.Text = "";
            textboxProveedor.Text = "";
            textboxCantidad.Text = "";
            comboboxAlter.Text = null;
        }

        public void selecionar(string comando)
        {

            MySqlCommand cmd = new MySqlCommand(comando, BDConexicon.conectar());
            cmd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = textBoxCodigo.Text;
            MySqlDataReader mdr;
            mdr = cmd.ExecuteReader();

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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCodigo.Text))
            {
                MessageBox.Show("Especifique un articulo");
            }
            else if (string.IsNullOrEmpty(comboboxAlter.Text))
            {
                MessageBox.Show("Seleciona una anomalia");
            }
            else if (string.IsNullOrEmpty(textboxCantidad.Text))
            {
                MessageBox.Show("Espeficiar La cantidad de piezas con anomalias");
            }
            else
            {
                
                insertarArticulo("insert into RD_formatocajeras(articulo,cantidad,anomalia,usuario,hora,fecha,validado) values (?articulo,?cantidad,?anomalia,?usuario,?hora,?fecha,?validado)");
            }
        }
    }
}
