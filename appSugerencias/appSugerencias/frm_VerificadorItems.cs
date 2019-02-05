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
    public partial class frm_VerificadorItems : Form
    {
        string busqueda;
        public frm_VerificadorItems()
        {
            InitializeComponent();
        }

        public frm_VerificadorItems(string cadena)
        {
            InitializeComponent();
            busqueda = cadena;
            lblBusqueda.Text = busqueda;
            selectArticulos();
        }

        private void frm_VerificadorItems_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //selectArticulos();
            //string valorPrimerCelda = DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //string valor= dgvArticulos.Rows[]
        }

        //======================================================== ITEM'S TRASPASO
        public void selectArticulos()
        {




            //articulo  LIKE '%?articulo%'  OR
            MySqlCommand cmd = new MySqlCommand("SELECT articulo,descrip,precio1,precio2,existencia FROM prods  WHERE   articulo  LIKE '%"+lblBusqueda.Text+ "%' OR descrip LIKE '%" + lblBusqueda.Text + "%'", BDConexicon.conectar());
            //cmd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = txtArticulo.Text;
            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();

            adaptador.Fill(dt);

            dgvArticulos.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dgvArticulos.Rows.Add();

                dgvArticulos.Rows[n].Cells[0].Value = item["articulo"].ToString();
                dgvArticulos.Rows[n].Cells[1].Value = item["descrip"].ToString();
                dgvArticulos.Rows[n].Cells[2].Value = item["precio1"].ToString();
                dgvArticulos.Rows[n].Cells[3].Value = item["precio2"].ToString();
                dgvArticulos.Rows[n].Cells[4].Value = item["existencia"].ToString();

            }
           
            BDConexicon.ConectarClose();
            


        }

        private void dgvArticulos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                
                lblRespuesta.Text = Convert.ToString(dgvArticulos.Rows[dgvArticulos.CurrentRow.Index].Cells[0].Value);

                
            }
        }
        //########## CIERRE ############
    }
}
