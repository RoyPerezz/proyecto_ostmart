using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace appSugerencias
{
    public partial class frm_recalcular : Form
    {
        public frm_recalcular()
        {
            InitializeComponent();
        }

        MySqlConnection conectar;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                OpenFileDialog open = new OpenFileDialog();
                if (open.ShowDialog() == DialogResult.OK)
                {
                    TBArchivo.Text = open.FileName;
                }

                CargarExcel();
            }
            catch (Exception ed)
            {
                MessageBox.Show("Error archivo de Excel / Cierre Archivo de Excel");
            }

        }


        public void CargarExcel()
        {
            string hoja = "Hoja1";
            string pathconn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + TBArchivo.Text + ";Extended Properties='Excel 12.0 Xml; HDR=YES;';";
            OleDbConnection conn = new OleDbConnection(pathconn);
            OleDbCommand oconn = new OleDbCommand("Select * from [" + hoja + "$]", conn);
            conn.Open();

            OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            DataTable data = new DataTable();
            sda.Fill(data);
            DGArticulos.DataSource = data;


        }


        public void recalcular()
        {
            int nitems = DGArticulos.Rows.Count;
            //MessageBox.Show(nitems.ToString());

            for (int i = 0; i < DGArticulos.Rows.Count; i++)
            {

                MessageBox.Show(DGArticulos[0, i].Value.ToString());
                MySqlCommand cmdart = new MySqlCommand("SUM( IF( almacen = 1 AND ent_sal = 'E', cantidad, 0 ) ) As ealm1,'" + DGArticulos[0, i].Value.ToString() + "'", conectar);
                MySqlDataReader mdrart;
                mdrart = cmdart.ExecuteReader();


                if (mdrart.Read())
                {
                }
            }

        }

        public void ElegirSucursar()
        {
            LBConexion.Text = "";
            try
            {

                conectar.Close();
            }
            catch (Exception ec)
            {

            }

            if (CBTienda.SelectedItem.Equals("BODEGA"))
            {
                conectar = BDConexicon.BodegaOpen();
               // proveedores();
            }

            if (CBTienda.SelectedItem.Equals("RENA"))
            {
                conectar = BDConexicon.RenaOpen();


                //proveedores();
            }

            if (CBTienda.SelectedItem.Equals("COLOSO"))
            {

                conectar = BDConexicon.ColosoOpen();


               // proveedores();
            }

            if (CBTienda.SelectedItem.Equals("VELAZQUEZ"))
            {
                conectar = BDConexicon.VelazquezOpen();
               // proveedores();
            }

            if (CBTienda.SelectedItem.Equals("VALLARTA"))
            {

                conectar = BDConexicon.VallartaOpen();
               // proveedores();
            }

        }

        private void frm_recalcular_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            recalcular();
        }
    }
}
