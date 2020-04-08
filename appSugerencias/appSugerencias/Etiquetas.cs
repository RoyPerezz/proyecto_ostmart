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
    public partial class Etiquetas : Form
    {
        public Etiquetas()
        {
            InitializeComponent();
        }


        public void Limpiar()
        {
            TB_clave.Text = "";
            TB_descrip.Text = "";
            TB_depto.Text = "";
            TB_ceros.Text = "";
            TB_Sin_etiqueta.Text = "";
            TB_borrosa.Text = "";
          
        }
       
   

        private void button1_Click(object sender, EventArgs e)
        {

            if (TB_ceros.Text.Equals("")&&TB_Sin_etiqueta.Text.Equals("")&&TB_borrosa.Text.Equals(""))
            {
                MessageBox.Show("Introduce la cantidad de etiquetas defectuosas donde corresponda");
            }else
            {
                MySqlConnection con = BDConexicon.conectar();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO rd_etiquetas(cajera,clave,descrip,depto,art_ceros,sin_etiqueta,borrosa,hora,fecha) VALUES(?cajera,?clave,?descrip,?depto,?art_ceros,?sin_etiqueta,?borrosa,?hora,?fecha)", con);
             
             
                cmd.Parameters.AddWithValue("?cajera",LB_cajera.Text);
                cmd.Parameters.AddWithValue("?clave", TB_clave.Text);
                cmd.Parameters.AddWithValue("?descrip", TB_descrip.Text);
                cmd.Parameters.AddWithValue("?depto", TB_depto.Text);
                cmd.Parameters.AddWithValue("?art_ceros", TB_ceros.Text);
                cmd.Parameters.AddWithValue("?sin_etiqueta", TB_Sin_etiqueta.Text);
                cmd.Parameters.AddWithValue("?borrosa", TB_borrosa.Text);
                DateTime hora = Convert.ToDateTime(DateTime.Now.ToString("h:mm:ss"));
                cmd.Parameters.AddWithValue("?hora", hora);
                DateTime fecha = DateTime.Now;
                cmd.Parameters.AddWithValue("?fecha", fecha);
                cmd.ExecuteNonQuery();
                Limpiar();
                MessageBox.Show("Registro guardado exitosamente");

                con.Close();
            }


           
        }

        private void Etiquetas_Load(object sender, EventArgs e)
        {
           
        }

    }
}
