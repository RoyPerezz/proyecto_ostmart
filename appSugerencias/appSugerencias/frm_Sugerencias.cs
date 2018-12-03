using System;
//using System.Collections.Generic;
//using System.ComponentModel;
////using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
//using MySql.Data.Types;

namespace appSugerencias
{
    public partial class frm_Sugerencias : Form
    {
        public frm_Sugerencias()
        {
            InitializeComponent();
        }


        //public static MySqlConnection conectar()
        //{

        //    MySqlConnection con = new MySqlConnection("server=192.168.1.155; database=VALLARTA MAY 2016; Uid=root; pwd=;");
        //    con.Open();
        //    //MessageBox.Show("conectado..."+con.Database);


        //    return con;

        //}





       public void limpiar()
        {
            RT_Sugerencia.Text = "";
            TB_Nombre.Text = "";
            CB_cargo.SelectedIndex = -1;
            CB_tipo.SelectedIndex = -1;
        }


        public void insertar(string comando, MySqlConnection bd)
        {
           
            
            MySqlCommand cmd = new MySqlCommand(comando, bd);
            cmd.Parameters.Add("?texto", MySqlDbType.VarChar).Value = RT_Sugerencia.Text;
            cmd.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = TB_Nombre.Text;
            cmd.Parameters.Add("?fecha", MySqlDbType.Date).Value = DateTime.Now;
            cmd.Parameters.Add("?cargo", MySqlDbType.VarChar).Value = CB_cargo.SelectedItem.ToString();
            cmd.Parameters.Add("?tipo", MySqlDbType.VarChar).Value = CB_tipo.SelectedItem.ToString();
            cmd.ExecuteNonQuery();
            limpiar();
            MessageBox.Show("Tu sugerencia se ha guardado, muchas gracias");

        }

       

    

        private void bt_Guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RT_Sugerencia.Text))
            {
                MessageBox.Show("Escribe la sugerencia");
            } else if (string.IsNullOrEmpty(TB_Nombre.Text))
            {
                MessageBox.Show("Escribe el nombre");
            }
            else
            {
                MySqlConnection c = BDConexicon.conectar();
                insertar("insert into sugerencias(texto, usuario, fecha, cargo, tipo) values(?texto, ?usuario, ?fecha,?cargo,?tipo)", c);
            }

           
        }

        private void frm_Sugerencias_Load(object sender, EventArgs e)
        {

        }

        private void TB_Nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
