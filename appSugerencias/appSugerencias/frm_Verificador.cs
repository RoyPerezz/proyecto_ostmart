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
    public partial class frm_Verificador : Form
    {


       
        double contador;
        public frm_Verificador()
        {
            InitializeComponent();
        }

        

        
        

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (string.IsNullOrEmpty(txtArticulo.Text))
                {
                    MessageBox.Show("Inserte un Codigo");
                }
                else
                {

                
                    seleccionar("SELECT articulo, descrip, linea,precio1,precio2,existencia FROM prods WHERE articulo=?articulo",txtArticulo.Text);

                }
            }

           


        }

        public void seleccionar(string comando, string articulo)
        {


            double precio1;
            double precio2;
            pictureBox1.Hide();

            MySqlCommand cmd = new MySqlCommand(comando, BDConexicon.conectar());
            cmd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = articulo;
            
            MySqlDataReader mdr;
            mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                //MessageBox.Show("HOLA USUARIO " + usu);
                lblArticulo.Text = articulo;
                lblDescripcion.Text = mdr.GetString("descrip");
                precio1 = mdr.GetDouble("Precio1") + (mdr.GetDouble("Precio1") * 0.16);
                precio2 = mdr.GetDouble("Precio2") + (mdr.GetDouble("Precio2") * 0.16);
                lblPrecio1.Text = precio1.ToString("0.00");
                lblPrecio2.Text = precio2.ToString("0.00");
                lblExistencia.Text = mdr.GetString("existencia");
                lblLinea.Text = mdr.GetString("linea");


                //Principal ini = new Principal(usu);
                //Principal ini = new Principal();

                //ini.Show();

            }
            else
            {
                MessageBox.Show("Articulo no encontrado");
                pictureBox1.Show();
            }
            mdr.Close();
            txtArticulo.Text = "";
            contador = 0;
            timer1.Start();

            BDConexicon.ConectarClose();
        }

        private void frm_Verificador_Load(object sender, EventArgs e)
        {
            muestraTienda();
            
            pictureBox1.Image = Image.FromFile("imagenes\\logo.png");

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            contador = contador + 1;
            lblSegundos.Text = contador.ToString();

            if (contador > 5)
            {
                lblArticulo.Text = "";
                lblDescripcion.Text = "";
                lblPrecio1.Text = "";
                lblPrecio2.Text = "";
                lblExistencia.Text = "";
                lblLinea.Text = "";
                pictureBox1.Show();
                timer1.Stop();
            }

        }


        public void muestraTienda()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT EMPRESA FROM econfig ", BDConexicon.conectar());
            MySqlDataReader mdr;
            mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                if (mdr.IsDBNull(0))
                {
                    lblTienda.Text = "Bienvenidos";
                }
                else
                {
                    lblTienda.Text = mdr.GetString("EMPRESA").ToString();
                }
            }
            else
            {
                lblTienda.Text = "Bienvenidos";
            }
            mdr.Close();
            BDConexicon.ConectarClose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down)
            {
                // MessageBox.Show("abajo");
                frm_VerificadorItems app = new frm_VerificadorItems(txtArticulo.Text);
                AddOwnedForm(app);
                app.Show();
            }
               

        }

        private void txtArticulo_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
