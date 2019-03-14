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
            //btnA.DialogResult = DialogResult.OK;
        }

        public frm_VerificadorItems(string cadena)
        {
            InitializeComponent();
            if (cadena == "")
            {
                cadena = "xzSXVW";
            }
            busqueda = cadena;
            //lblBusqueda.Text = busqueda;
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

        //======================================================== 
        public void selectArticulos()
        {



            double precio1, precio2;
            //articulo  LIKE '%?articulo%'  OR
            MySqlCommand cmd = new MySqlCommand("SELECT articulo,descrip,precio1,precio2,existencia FROM prods  WHERE   articulo  LIKE '%"+ busqueda + "%' OR descrip LIKE '%" + busqueda + "%' LIMIT 50", BDConexicon.conectar());
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
                
                

                precio1 = Convert.ToDouble( item["precio1"]);
                precio2 = Convert.ToDouble(item["precio2"]);

                precio1 = precio1 + (precio1 * 0.16);
                precio2 = precio2 + (precio2 * 0.16);
                dgvArticulos.Rows[n].Cells[2].Value = precio1.ToString("0.00");
                dgvArticulos.Rows[n].Cells[3].Value = precio2.ToString("0.00");
                dgvArticulos.Rows[n].Cells[4].Value = item["existencia"].ToString();

            }

            foreach (DataGridViewColumn c in dgvArticulos.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Bold", 20F, GraphicsUnit.Pixel);
            }

            BDConexicon.ConectarClose();
            


        }

        private void dgvArticulos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string articulo;
                try
                {

                
                 articulo= Convert.ToString(dgvArticulos.Rows[dgvArticulos.CurrentRow.Index-1].Cells[0].Value);
                }
                catch(Exception er)
                {
                     articulo = "";
                }
                InterfaceComunicacion con = this.Owner as InterfaceComunicacion;
                 
                con.SetArticulo(articulo);
                this.Close();
                
        }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //InterfaceComunicacion con = this.Owner as InterfaceComunicacion;
            //string articulo = lblRespuesta.Text;
            //con.SetArticulo(articulo);

        }

        private void frm_VerificadorItems_KeyDown(object sender, KeyEventArgs e)
        {
          
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }

        private void btnA_KeyPress(object sender, KeyPressEventArgs ex)
        {
            

        }

        private void frm_VerificadorItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                MessageBox.Show("salir");
            }
        }
        //########## CIERRE ############
    }
}
