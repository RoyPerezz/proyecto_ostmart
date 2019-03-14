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
    
    public partial class frm_Login : Form
    {
        public string var_usuario;

        public frm_Login()
        {
            InitializeComponent();
        }

        string usuario, password;
        private int Asc(string s)
        {
            return Encoding.ASCII.GetBytes(s)[0]+12;
        }

        

        public string cifraPass(string cadena)
        {
            char[] array = cadena.ToCharArray();
            char[] array2 = cadena.ToCharArray();
            int iaux;
            string palabra="";
            for (int i = 0; i < cadena.Length; i++)
            {
                
                iaux = Asc(array[i].ToString());
                array2[i]= Convert.ToChar(iaux);
                palabra = palabra + array2[i];
            }

            return palabra;
        }

        public void seleccionar(string comando, string usu, string pass)
        {
            string area;

            MySqlCommand cmd = new MySqlCommand(comando, BDConexicon.conectar());
            cmd.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = usu;
            cmd.Parameters.Add("?clave", MySqlDbType.VarChar).Value = pass;
            MySqlDataReader mdr;
            mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                //MessageBox.Show("HOLA USUARIO " + usu);
                this.Hide();
                area = mdr.GetString("area");
                
                Principal ini = new Principal(usu,area);
                //Principal ini = new Principal();

                ini.Show();
                
            }
            else
            {
                MessageBox.Show("Usuario o contraseña erroneo");
            }
        }

        public void dan()
        {
            string[] separadas;
            

            if (textboxLogin.Text.Contains(' '))
            {
                separadas = textboxLogin.Text.Split(' ');

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


            dan();

        }

        private void textboxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dan();
            }
        }
    }
}
