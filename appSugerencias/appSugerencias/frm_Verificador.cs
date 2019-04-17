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
    public partial class frm_Verificador : Form,InterfaceComunicacion
    {


       
        double contador;
        int oferta;
        public frm_Verificador()
        {
            InitializeComponent();
            colocaLogo();
        }

        public void SetArticulo(string articulo)
        {
            txtArticulo.Text = articulo;
            //MessageBox.Show(articulo);
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

                
                    seleccionar("SELECT articulo, descrip, linea,precio1,precio2,existencia,fabricante, oferta FROM prods WHERE articulo=?articulo",txtArticulo.Text);

                }
            }

           


        }

        public void seleccionar(string comando, string articulo)
        {
            if (articulo == "...1")
            {
                this.Close();
            }

            double precio1;
            double precio2;
            DateTime fechaInicial;
            DateTime fechaFinal;
            DateTime fechaHoy = DateTime.Now;
            int porporcentaje, porcentaje;
            // oferta = 0;

            MySqlConnection con = BDConexicon.conectar();

            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = articulo;

            MySqlDataReader mdr;
            mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                pictureBox1.Hide();
                lbl1.Show();
                lbl2.Show();
                lbl3.Show();
                lbl4.Show();
                lbl5.Show();
                lbl6.Show();
                //lbl7.Show();
                lblArticulo.Text = articulo;
                oferta = mdr.GetInt32("oferta");



                lblDescripcion.Text = mdr.GetString("descrip");
                precio1 = mdr.GetDouble("Precio1") + (mdr.GetDouble("Precio1") * 0.16);
                precio2 = mdr.GetDouble("Precio2") + (mdr.GetDouble("Precio2") * 0.16);
                lblPrecio1.Text = precio1.ToString("0.00");
                lblPrecio2.Text = precio2.ToString("0.00");
                lblExistencia.Text = mdr.GetString("existencia");
                lblLinea.Text = mdr.GetString("linea");
                oferta = mdr.GetInt32("oferta");
                // lblFabricante.Text = mdr.GetString("fabricante");
                //lblOferta.Text = oferta.ToString();

                mdr.Close();

                if (oferta == 1)
                {


                    //MessageBox.Show("entro");
                    MySqlCommand cmdd = new MySqlCommand("SELECT fechainicial, fechafinal,porporcentaje,porcentaje FROM ofertas where articulo=?articulo", con);
                    cmdd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = articulo;

                    MySqlDataReader mdrr;
                    mdrr = cmdd.ExecuteReader();
                    if (mdrr.Read())
                    {
                        fechaInicial = mdrr.GetDateTime("fechainicial");
                        fechaFinal = mdrr.GetDateTime("fechafinal");
                        porporcentaje = mdrr.GetInt32("porporcentaje");
                        porcentaje = mdrr.GetInt32("porcentaje");
                        //MessageBox.Show("FechaHoy: "+fechaHoy);
                        //MessageBox.Show("FechaFinal: " + fechaFinal);
                        //fechaHoy >= fechaInicial &&
                        if (fechaHoy > fechaInicial || (fechaHoy.Year == fechaInicial.Year && fechaHoy.Month == fechaInicial.Month && fechaHoy.Day == fechaInicial.Day))
                        {


                            if (fechaHoy < fechaFinal || (fechaHoy.Year == fechaFinal.Year) && (fechaHoy.Day == fechaFinal.Day) && (fechaFinal.Month == fechaFinal.Month))
                            {

                                precio1 = precio1 - (porcentaje * precio1 / 100);
                                precio2 = precio2 - (porcentaje * precio2 / 100);
                                lblOferta1.Text = precio1.ToString("0.00");
                                lblOferta2.Text = precio2.ToString("0.00");
                                lblLeyendaOferta.Text = "Producto con Oferta";

                            }

                        }


                    }

                    mdrr.Close();
                }




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
            con.Close();
        }

        private void frm_Verificador_Load(object sender, EventArgs e)
        {
            try
            { 
                muestraTienda();
            
                pictureBox1.Image = Image.FromFile("imagenes\\logo.png");
            }
            catch(Exception ez)
            {
                MessageBox.Show("Sin Conexion con el Servidor");
                this.Close();
            }
        }
        public void colocaLogo()
        {
            lbl1.Hide();
            lbl2.Hide();
            lbl3.Hide();
            lbl4.Hide();
            lbl5.Hide();
            lbl6.Hide();
            lbl7.Hide();
            lblArticulo.Text = "";
            lblDescripcion.Text = "";
            lblPrecio1.Text = "";
            lblPrecio2.Text = "";
            lblExistencia.Text = "";
            lblLinea.Text = "";
            lblFabricante.Text = "";
            lblOferta1.Text = "";
            lblOferta2.Text = "";
            lblLeyendaOferta.Text = "";
            pictureBox1.Show();
            timer1.Stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            contador = contador + 1;
            //lblSegundos.Text = contador.ToString();

            if (contador > 30)
            {
                colocaLogo();
            }

        }


        public void muestraTienda()
        {

            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT EMPRESA FROM econfig ",con );
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
            con.Close();
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
                    frm_VerificadorItems hijo = new frm_VerificadorItems(txtArticulo.Text);
                    hijo.Show(this);
                }
            

        }

        private void txtArticulo_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtArticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
