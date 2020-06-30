using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace appSugerencias
{
    public partial class frm_proveed : Form
    {
        public frm_proveed()
        {
            InitializeComponent();
        }

        
        private void button6_Click(object sender, EventArgs e)
        {

            string id = obtieneid();
           
            MessageBox.Show(id);
        }



        public string obtieneid()
        {
            MySqlConnection conectar;
            conectar = BDConexicon.conectar();

            string comando = "SELECT Consec FROM consec WHERE Dato='Proveed'";

            int idproveed=0;
            string valor;
            MySqlCommand cmd = new MySqlCommand(comando, conectar);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            dgvRFC.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dgvRFC.Rows.Add();

                idproveed = Convert.ToInt32(item["Consec"].ToString());
               
            }
            conectar.Close();

            idproveed = idproveed + 1;

            comando = "";


            valor = "00" + idproveed;
            return valor;
        }

        public void guardaCliente()
        {
            MySqlConnection conectar;
            conectar = BDConexicon.conectar();

            string comando;
            // MySqlCommand cmd0 = new MySqlCommand("SELECT CLIENTE FROM clients WHERE CLIENTE=?CLIENTE", conectar);

            ////1 nuevo cliente/ 2 actualiza
            //if (Flag == 1)
            //{
            //    cmd0.Parameters.Add("?CLIENTE", MySqlDbType.VarChar).Value = tbRFC.Text;
            //}
            //if (Flag == 2)
            //{
            //    cmd0.Parameters.Add("?CLIENTE", MySqlDbType.VarChar).Value = IDCliente;
            //}



            //MySqlDataReader mdrcli;
            //mdrcli = cmd0.ExecuteReader();

            //if (mdrcli.Read())
            //{
            //    comando = "UPDATE clients SET CLIENTE=?CLIENTE,RFC=?RFC,NOMBRE=?NOMBRE,CALLE=?CALLE,COLONIA=?COLONIA,numerointerior=?NIN,numeroexterior=?NEX,POBLA=?POBLA,ESTADO=?ESTADO,PAIS=?PAIS,TELEFONO=?TEL,CP=?CP,CORREO=?EMAIL WHERE CLIENTE=?CLIENTEA";

            //}
            //else
            //{
            //    comando = "INSERT INTO clients (CLIENTE,RFC, NOMBRE,CALLE,COLONIA,numerointerior,numeroexterior,POBLA,ESTADO,PAIS, TELEFONO,CP,CORREO) " +
            //    "values (?CLIENTE,?RFC,?NOMBRE,?CALLE,?COLONIA,?NIN,?NEX,?POBLA,?ESTADO,?PAIS,?TEL,?CP,?EMAIL)";
            //}
            //mdrcli.Close();

            comando = "INSERT INTO proveed (PROVEEDOR,NOMBRE,CALLE,COLONIA,POBLA,ESTADO,PAIS, TELEFONO,RFC,CP,MAIL) " +
             "values (?PROVEEDOR,?RFC,?NOMBRE,?CALLE,?COLONIA,?POBLA,?ESTADO,?PAIS,?TEL,?CP,?EMAIL)";


           MySqlCommand cmd = new MySqlCommand(comando, conectar);
            //if (Flag == 1)
            //{
            //    cmd.Parameters.Add("?CLIENTE", MySqlDbType.VarChar).Value = tbRFC.Text.ToUpper();
            cmd.Parameters.Add("?PROVEEDOR", MySqlDbType.VarChar).Value = obtieneid(); ;
            cmd.Parameters.Add("?RFC", MySqlDbType.VarChar).Value = tbRFC.Text.ToUpper();
            //}
            //if (Flag == 2)
            //{

            //    cmd.Parameters.Add("?CLIENTE", MySqlDbType.VarChar).Value = tbRFC.Text.ToUpper();
            //    cmd.Parameters.Add("?RFC", MySqlDbType.VarChar).Value = tbRFC.Text.ToUpper();
            //   // cmd.Parameters.Add("?CLIENTEA", MySqlDbType.VarChar).Value = IDCliente;

            //}


            cmd.Parameters.Add("?NOMBRE", MySqlDbType.VarChar).Value = tbRS.Text.ToUpper();
            cmd.Parameters.Add("?CALLE", MySqlDbType.VarChar).Value = tbCalle.Text.ToUpper();
            cmd.Parameters.Add("?COLONIA", MySqlDbType.VarChar).Value = tbColonia.Text.ToUpper();
            //cmd.Parameters.Add("?NIN", MySqlDbType.VarChar).Value = tbInterior.Text.ToUpper();
            //cmd.Parameters.Add("?NEX", MySqlDbType.VarChar).Value = tbExterior.Text.ToUpper();

            cmd.Parameters.Add("?POBLA", MySqlDbType.VarChar).Value = tbLocalidad.Text.ToUpper();

            cmd.Parameters.Add("?ESTADO", MySqlDbType.VarChar).Value = tbEstado.Text.ToUpper();
            cmd.Parameters.Add("?PAIS", MySqlDbType.VarChar).Value = tbPais.Text.ToUpper();
            cmd.Parameters.Add("?TEL", MySqlDbType.VarChar).Value = tbTelefono.Text.ToUpper();
            cmd.Parameters.Add("?CP", MySqlDbType.VarChar).Value = tbCP.Text;

            cmd.Parameters.Add("?EMAIL", MySqlDbType.VarChar).Value = tbEmail.Text;


            cmd.ExecuteNonQuery();


            conectar.Close();
           // limpiar();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            guardaCliente();
        }
    }
}
