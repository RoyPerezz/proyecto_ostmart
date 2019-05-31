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
    public partial class frm_clientes : Form
    {
        string IDCliente;

        public frm_clientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seleccionardatos();
        }
        public void seleccionardatos()
        {
            MySqlConnection conectar;
            conectar = BDConexicon.conectar();

            string comando = "SELECT CLIENTE,NOMBRE,RFC FROM clients WHERE RFC LIKE'%"+ tbRFCBusqueda.Text + "%'";

            MySqlCommand cmd = new MySqlCommand(comando,conectar);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            dgvRFC.Rows.Clear();

            foreach(DataRow item in dt.Rows)
            {
                int n = dgvRFC.Rows.Add();

                dgvRFC.Rows[n].Cells[0].Value = item["CLIENTE"].ToString();
                dgvRFC.Rows[n].Cells[1].Value = item["NOMBRE"].ToString();
                dgvRFC.Rows[n].Cells[2].Value = item["RFC"].ToString();
            }
            conectar.Close();
        }

        private void frm_clientes_Load(object sender, EventArgs e)
        {
         
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dgvRFC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IDCliente= dgvRFC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            buscaDatosCliente(IDCliente);
        }

        public void buscaDatosCliente(string idCliente)
        {
            MySqlConnection conectar;
            conectar = BDConexicon.conectar();
           
            string comando = "SELECT CLIENTE,RFC,NOMBRE,CALLE,COLONIA,numerointerior,numeroexterior,ESTADO,POBLA,PAIS,TELEFONO,CP,CORREO FROM  clients WHERE CLIENTE=?CLIENTE";

            MySqlCommand cmd = new MySqlCommand(comando, conectar);
            cmd.Parameters.Add("?CLIENTE", MySqlDbType.VarChar).Value=idCliente;
            MySqlDataReader mdr;
            mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                IDCliente = mdr.GetString("CLIENTE");
                tbRFC.Text = mdr.GetString("RFC");
                tbRS.Text = mdr.GetString("NOMBRE");
                tbCalle.Text = mdr.GetString("CALLE");
                tbColonia.Text = mdr.GetString("COLONIA");

                if (mdr.IsDBNull(6))
                {
                    tbInterior.Text = "";
                }
                else
                {
                    tbInterior.Text = mdr.GetString("numerointerior");
                }

                if (mdr.IsDBNull(7))
                {
                    tbExterior.Text = "";
                }
                else
                {
                    tbExterior.Text = mdr.GetString("numeroexterior");
                }
                
                tbEstado.Text = mdr.GetString("ESTADO");
                tbLocalidad.Text = mdr.GetString("POBLA");

                tbPais.Text = mdr.GetString("PAIS"); 
                tbTelefono.Text = mdr.GetString("TELEFONO");
                tbCP.Text = mdr.GetString("CP");
                tbEmail.Text = mdr.GetString("CORREO");




            }

            conectar.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            DialogResult opcion;
            opcion = MessageBox.Show("Realmente desea Eliminar el cliente, Esta opcion no se puede deshacer.", "Eliminar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcion == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(tbRFC.Text))
                {
                    MessageBox.Show("No esta Seleccionado ningun cliente");

                }
                else
                {
                    eliminaCliente();
                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbRFC.Text))
            {
                MessageBox.Show("El Campo RFC no puede estar en blanco");

            }
            else if (string.IsNullOrEmpty(tbRS.Text))
            {
                MessageBox.Show("El Campo Razon Social no puede estar en blanco");
            }
            else if (string.IsNullOrEmpty(tbCP.Text))
            {
                MessageBox.Show("El Campo Codigo Postal no puede estar en blanco");
            }
            else if (string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("El Campo Correo no puede estar en blanco");
            }
            else
            {
                //Nuevo Cliente
                guardaCliente(1);
                //seleccionardatos();
                MessageBox.Show("Cliente Guardado");
            }
        }

        public void guardaCliente(int Flag)
        {
            MySqlConnection conectar;
            conectar = BDConexicon.conectar();

            string comando;
            MySqlCommand cmd0 = new MySqlCommand("SELECT CLIENTE FROM clients WHERE CLIENTE=?CLIENTE", conectar);

            //1 nuevo cliente/ 2 actualiza
            if (Flag == 1)
            {
                cmd0.Parameters.Add("?CLIENTE", MySqlDbType.VarChar).Value = tbRFC.Text;
            }
            if (Flag == 2)
            {
                cmd0.Parameters.Add("?CLIENTE", MySqlDbType.VarChar).Value = IDCliente;
            }
                
            

            MySqlDataReader mdrcli;
            mdrcli = cmd0.ExecuteReader();
            
            if (mdrcli.Read())
            {
                 comando = "UPDATE clients SET CLIENTE=?CLIENTE,RFC=?RFC,NOMBRE=?NOMBRE,CALLE=?CALLE,COLONIA=?COLONIA,numerointerior=?NIN,numeroexterior=?NEX,POBLA=?POBLA,ESTADO=?ESTADO,PAIS=?PAIS,TELEFONO=?TEL,CP=?CP,CORREO=?EMAIL WHERE CLIENTE=?CLIENTEA";
                
            }
            else
            {
                comando = "INSERT INTO clients (CLIENTE,RFC, NOMBRE,CALLE,COLONIA,numerointerior,numeroexterior,POBLA,ESTADO,PAIS, TELEFONO,CP,CORREO) " +
                "values (?CLIENTE,?RFC,?NOMBRE,?CALLE,?COLONIA,?NIN,?NEX,?POBLA,?ESTADO,?PAIS,?TEL,?CP,?EMAIL)";
            }
            mdrcli.Close();
             
            
               

                MySqlCommand cmd = new MySqlCommand(comando, conectar);
            if (Flag == 1)
            {
                cmd.Parameters.Add("?CLIENTE", MySqlDbType.VarChar).Value = tbRFC.Text.ToUpper();
                cmd.Parameters.Add("?RFC", MySqlDbType.VarChar).Value = tbRFC.Text.ToUpper();
            }
            if (Flag ==2)
            {
                
                cmd.Parameters.Add("?CLIENTE", MySqlDbType.VarChar).Value = tbRFC.Text.ToUpper();
                cmd.Parameters.Add("?RFC", MySqlDbType.VarChar).Value = tbRFC.Text.ToUpper();
                cmd.Parameters.Add("?CLIENTEA", MySqlDbType.VarChar).Value = IDCliente;
                
            }
            
            
            cmd.Parameters.Add("?NOMBRE", MySqlDbType.VarChar).Value = tbRS.Text.ToUpper();
                cmd.Parameters.Add("?CALLE", MySqlDbType.VarChar).Value = tbCalle.Text.ToUpper();
                cmd.Parameters.Add("?COLONIA", MySqlDbType.VarChar).Value = tbColonia.Text.ToUpper();
                cmd.Parameters.Add("?NIN", MySqlDbType.VarChar).Value = tbInterior.Text.ToUpper();
                cmd.Parameters.Add("?NEX", MySqlDbType.VarChar).Value = tbExterior.Text .ToUpper();

                cmd.Parameters.Add("?POBLA", MySqlDbType.VarChar).Value = tbLocalidad.Text.ToUpper();

                cmd.Parameters.Add("?ESTADO", MySqlDbType.VarChar).Value = tbEstado.Text.ToUpper();
                cmd.Parameters.Add("?PAIS", MySqlDbType.VarChar).Value = tbPais.Text.ToUpper();
                cmd.Parameters.Add("?TEL", MySqlDbType.VarChar).Value = tbTelefono.Text.ToUpper();
                cmd.Parameters.Add("?CP", MySqlDbType.VarChar).Value = tbCP.Text;

                cmd.Parameters.Add("?EMAIL", MySqlDbType.VarChar).Value = tbEmail.Text;


                cmd.ExecuteNonQuery();


            conectar.Close();
            limpiar();
            
        }

        public void eliminaCliente()
        {
            try
            {

            
            MySqlConnection conectar;
            conectar = BDConexicon.conectar();

            MySqlCommand cmdart = new MySqlCommand("DELETE FROM clients WHERE CLIENTE ='" + tbRFC.Text + "'", conectar);
            cmdart.ExecuteNonQuery();
                seleccionardatos();
                limpiar();
                MessageBox.Show("Cliente Eliminado");

            }
            catch(Exception er)
            {
                MessageBox.Show("No se pudo eliminar el cliente");
            }


    }

        public void limpiar()
        {
            tbRFC.Text = "";
            tbRS.Text = "";
            tbCalle.Text = "";
            tbColonia.Text = "";
            tbInterior.Text = "";
            tbExterior.Text = "";
            tbLocalidad.Text = "";
            tbEstado.Text = "";
            tbPais.Text = "";
            tbTelefono.Text = "";
            tbCP.Text = "";
            tbEmail.Text = "";
            IDCliente = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbRFC.Text))
            {
                MessageBox.Show("El Campo RFC no puede estar en blanco");

            }
            else if (string.IsNullOrEmpty(tbRS.Text))
            {
                MessageBox.Show("El Campo Razon Social no puede estar en blanco");
            }
            else if (string.IsNullOrEmpty(tbCP.Text))
            {
                MessageBox.Show("El Campo Codigo Postal no puede estar en blanco");
            }
            else
            {
                //actualiza cliente
                guardaCliente(2);
                seleccionardatos();
                MessageBox.Show("Cliente Actualizado");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
