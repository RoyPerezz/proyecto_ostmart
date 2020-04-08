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
    public partial class frm_pedido : Form
    {
        public frm_pedido()
        {
            InitializeComponent();
        }



        private void frm_pedido_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //busqueda();
            prueba();
        }

        public void prueba()
        {
            string comando= "SELECT * FROM rd_pedido ";
            string comando2 = "";
            string cadena = "";
         
            if (cbFiltro2.Text.Trim() != "")
            {

                if (cbFiltro.Text == "ESTADO")
                {
                    comando2 = " WHERE estatus LIKE '%" + cbFiltro2.Text + "%'";

                }
                else if(cbFiltro.Text == "PROVEEDOR")
                {
                    comando2 = " WHERE proveedor LIKE '%" + cbFiltro2.Text + "%'";

                }

              

            }

            cadena = comando + comando2;
            MessageBox.Show(cadena);

        }

        public void busqueda()
        {
                            MySqlConnection conex_pedido = BDConexicon.VallartaOpen();
            string comando = "SELECT * FROM rd_pedido ";
            // MySqlCommand cmd = new MySqlCommand("SELECT rd_traspaso.idtraspaso,rd_traspaso.estatus FROM rd_pedido   where rd_traspaso.fecha between '" + inicio + "'" + " and '" + fin + "' ", conex_pedido);

            MySqlCommand cmd = new MySqlCommand(comando, conex_pedido);


                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    System.Data.DataTable dt = new System.Data.DataTable();

                    //lblConexion.Text = "Conectado";
                    //lblConexion.ForeColor = Color.DarkGreen;

                    adaptador.Fill(dt);

                            dgvPedidos.Rows.Clear();

                            foreach (DataRow item in dt.Rows)
                            {
                                int n = dgvPedidos.Rows.Add();

                    dgvPedidos.Rows[n].Cells[0].Value = item["id_pedido"].ToString();
                    dgvPedidos.Rows[n].Cells[1].Value = item["titulo_pedido"].ToString();
                    dgvPedidos.Rows[n].Cells[2].Value = item["fecha"].ToString();
                    dgvPedidos.Rows[n].Cells[3].Value = item["periodo"].ToString();
                    dgvPedidos.Rows[n].Cells[4].Value = item["area"].ToString();
                    dgvPedidos.Rows[n].Cells[5].Value = item["proveedor"].ToString();
                    dgvPedidos.Rows[n].Cells[6].Value = item["link_pedido"].ToString();
                    dgvPedidos.Rows[n].Cells[7].Value = item["estatus"].ToString();
                    dgvPedidos.Rows[n].Cells[8].Value = item["cotiz"].ToString();
                    dgvPedidos.Rows[n].Cells[9].Value = item["nota"].ToString();
                    dgvPedidos.Rows[n].Cells[10].Value = item["guia"].ToString();
                    dgvPedidos.Rows[n].Cells[11].Value = item["comprobante_pago"].ToString();
                    dgvPedidos.Rows[n].Cells[12].Value = item["forma_pago"].ToString();
                    dgvPedidos.Rows[n].Cells[13].Value = item["tipo_pago"].ToString();
                    dgvPedidos.Rows[n].Cells[14].Value = item["observaciones"].ToString();

                }

                conex_pedido.Close();
        }








        private void button1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_nuevo_pedido);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_nuevo_pedido(1);
            frm.Show();

        }

        private void dgvPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            string idpedido = dgvPedidos.Rows[e.RowIndex].Cells[0].Value.ToString();

            VARIABLES.intpedido= Convert.ToInt32( dgvPedidos.Rows[e.RowIndex].Cells[0].Value.ToString());
            VARIABLES.titulo_pedido = dgvPedidos.Rows[e.RowIndex].Cells[1].Value.ToString();

            VARIABLES.area = dgvPedidos.Rows[e.RowIndex].Cells[4].Value.ToString();
            VARIABLES.proveedor = dgvPedidos.Rows[e.RowIndex].Cells[5].Value.ToString();
            VARIABLES.link_pedido = dgvPedidos.Rows[e.RowIndex].Cells[6].Value.ToString();
            VARIABLES.cotiz = dgvPedidos.Rows[e.RowIndex].Cells[8].Value.ToString();
            VARIABLES.nota = dgvPedidos.Rows[e.RowIndex].Cells[9].Value.ToString();
            VARIABLES.guia = dgvPedidos.Rows[e.RowIndex].Cells[10].Value.ToString();
            VARIABLES.comprobante_pago = dgvPedidos.Rows[e.RowIndex].Cells[11].Value.ToString();
            VARIABLES.tipo_pago = dgvPedidos.Rows[e.RowIndex].Cells[12].Value.ToString();
            VARIABLES.forma_pago = dgvPedidos.Rows[e.RowIndex].Cells[13].Value.ToString();
            VARIABLES.observaciones = dgvPedidos.Rows[e.RowIndex].Cells[14].Value.ToString();



            frm_nuevo_pedido hijo = new frm_nuevo_pedido(2);
            hijo.Show(this);
           // MessageBox.Show(idpedido.ToString());
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxArea.Checked == true)
            {
                dgvPedidos.Columns[4].Visible = false;
            }
            else if(cBoxArea.Checked == false)
            {
                dgvPedidos.Columns[4].Visible = true;
            }
            
        }

        private void cbFiltro_TextChanged(object sender, EventArgs e)
        {
            if (cbFiltro.Text == "ESTADO")
            {
                //cbFiltro2.Text = "1";
                llenaComboBoxEstado();
            }
            else if (cbFiltro.Text == "PROVEEDOR")
            {

                llenaComboProveedor();

            }

            else if (cbFiltro.Text == "AREA")
            {

                llenaComboArea();

            }
        }

        public void llenaComboArea()
        {
            cbFiltro2.DataSource = null;
            MySqlConnection conn;
            conn = BDConexicon.VallartaOpen();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM rd_pedido_area", conn);
            MySqlDataAdapter mysqladap = new MySqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();

            mysqladap.Fill(dt1);

            cbFiltro2.ValueMember = "idarea";
            cbFiltro2.DisplayMember = "area";
            cbFiltro2.DataSource = dt1;
            conn.Close();
        }

        public void llenaComboProveedor()
        {
            cbFiltro2.DataSource = null;
            MySqlConnection conn;
            conn = BDConexicon.VallartaOpen();

            MySqlCommand cmd = new MySqlCommand("SELECT PROVEEDOR,NOMBRE FROM proveed ", conn);
            MySqlDataAdapter mysqladap = new MySqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();

            mysqladap.Fill(dt1);

            cbFiltro2.ValueMember = "PROVEEDOR";
            cbFiltro2.DisplayMember = "NOMBRE";
            cbFiltro2.DataSource = dt1;
            conn.Close();
        }


        public void llenaComboBoxEstado()
        {
            cbFiltro2.DataSource = null;
            MySqlConnection conn;
            conn = BDConexicon.VallartaOpen();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM rd_pedido_estado", conn);
            MySqlDataAdapter mysqladap = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            mysqladap.Fill(dt);

            cbFiltro2.ValueMember = "idestado";
            cbFiltro2.DisplayMember = "estado";
            cbFiltro2.DataSource = dt;
            conn.Close();
        }


    }
}
