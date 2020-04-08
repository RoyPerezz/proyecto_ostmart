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
    public partial class frm_CreaGastosExterno : Form
    {
        public frm_CreaGastosExterno()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tbGastos.CharacterCasing = CharacterCasing.Upper;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                MySqlConnection con;
                con = BDConexicon.conectar();
                MySqlCommand cmdR = new MySqlCommand("INSERT INTO  rd_gastos_externos (nombre_gasto) VALUES (?nombre)", con);
                cmdR.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = tbGastos.Text;
                cmdR.ExecuteNonQuery();
                MessageBox.Show("Datos Guardados con Exito");
                dgvGastos.Rows.Clear();
                consultaGastos();
                tbGastos.Text = "";
            }catch(Exception er)
            {
                MessageBox.Show("Error"+er.Message);
            }


        }

        public void consultaGastos()
        {
            try
            {
                MySqlConnection con = BDConexicon.conectar();

                //string cadena = definemes(cbMeses.SelectedValue.ToString(), cbYear.Text);

                string comando;
                comando = "";
                
             
                    comando = "SELECT id_gasto, nombre_gasto from rd_gastos_externos";
                

                MySqlCommand cmd = new MySqlCommand(comando, con);

                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();



                adaptador.Fill(dt);

                dgvGastos.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dgvGastos.Rows.Add();

                    dgvGastos.Rows[n].Cells[0].Value = item["id_gasto"].ToString();
                    dgvGastos.Rows[n].Cells[1].Value = item["nombre_gasto"].ToString();

                }


                //exportaGastos();

                //dgvGastos.Rows.Clear();


            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message);
            }
        }




        private void frm_CreaGastosExterno_Load(object sender, EventArgs e)
        {
            consultaGastos();
        }
    }
}
