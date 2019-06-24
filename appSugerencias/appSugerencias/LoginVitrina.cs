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
    public partial class LoginVitrina : Form
    {
        public LoginVitrina()
        {
            InitializeComponent();
           
        }

        public string var_usuario;

        string usuario, password;
        private int Asc(string s)
        {
            return Encoding.ASCII.GetBytes(s)[0] + 12;
        }



        public string cifraPass(string cadena)
        {
            char[] array = cadena.ToCharArray();
            char[] array2 = cadena.ToCharArray();
            int iaux;
            string palabra = "";
            for (int i = 0; i < cadena.Length; i++)
            {

                iaux = Asc(array[i].ToString());
                array2[i] = Convert.ToChar(iaux);
                palabra = palabra + array2[i];
            }

            return palabra;
        }

        public void seleccionar(string comando, string usu, string pass)
        {
            string area;

            MySqlConnection con = BDConexicon.V_rena();

            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = usu;
            cmd.Parameters.Add("?clave", MySqlDbType.VarChar).Value = pass;
            MySqlDataReader mdr;
            mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                //MessageBox.Show("HOLA USUARIO " + usu);
                this.Hide();
                area = mdr.GetString("area");

                Principal_vitrina ini = new Principal_vitrina(usu, area);
                //Principal ini = new Principal();

                ini.Show();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña erroneo");
            }
            mdr.Close();
            con.Close();
        }

        public void dan()
        {
            string[] separadas;


            if (TB_login.Text.Contains(' '))
            {
                separadas = TB_login.Text.Split(' ');

                usuario = separadas[0].ToUpper();
                password = cifraPass(separadas[1].ToUpper());
                seleccionar("select * from usuarios where usuario=?usuario and clave=?clave", usuario, password);

            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrecta");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                dan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Conectar al Servidor");
            }

        }

        private void textboxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            
        }

        private void BT_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                dan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Conectar al Servidor");
            }
        }

        private void TB_login_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    dan();
                }
                catch (Exception exr)
                {
                    MessageBox.Show("Error al Conectar al Servidor");
                }

            }
        }

       
    }
}
