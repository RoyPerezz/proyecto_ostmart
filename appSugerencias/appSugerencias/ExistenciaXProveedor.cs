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
    public partial class ExistenciaXProveedor : Form
    {

        MySqlConnection vallarta =BDConexicon.VallartaOpen();
        MySqlConnection rena = BDConexicon.RenaOpen();
        MySqlConnection coloso = BDConexicon.ColosoOpen();
        MySqlConnection velazquez = BDConexicon.VelazquezOpen();
        MySqlConnection bodega = BDConexicon.BodegaOpen();


        public ExistenciaXProveedor()
        {
            InitializeComponent();

            //COLOR DE FONDO A LOS HEADERS DE LAS COLUMNAS

            DG_vallarta.Columns[0].HeaderCell.Style.BackColor = Color.BlueViolet;
            DG_vallarta.Columns[1].HeaderCell.Style.BackColor = Color.BlueViolet;
            DG_vallarta.Columns[2].HeaderCell.Style.BackColor = Color.BlueViolet;

            //DG_productos.Columns[3].HeaderCell.Style.BackColor = Color.RoyalBlue;
            //DG_productos.Columns[4].HeaderCell.Style.BackColor = Color.RoyalBlue;
            //DG_productos.Columns[5].HeaderCell.Style.BackColor = Color.RoyalBlue;

            //DG_productos.Columns[6].HeaderCell.Style.BackColor = Color.BlanchedAlmond;
            //DG_productos.Columns[7].HeaderCell.Style.BackColor = Color.BlanchedAlmond;
            //DG_productos.Columns[8].HeaderCell.Style.BackColor = Color.BlanchedAlmond;

            //DG_productos.Columns[9].HeaderCell.Style.BackColor = Color.SpringGreen;
            //DG_productos.Columns[10].HeaderCell.Style.BackColor = Color.SpringGreen;
            //DG_productos.Columns[11].HeaderCell.Style.BackColor = Color.SpringGreen;

            //DG_productos.Columns[12].HeaderCell.Style.BackColor = Color.Turquoise;
            //DG_productos.Columns[13].HeaderCell.Style.BackColor = Color.Turquoise;
            //DG_productos.Columns[14].HeaderCell.Style.BackColor = Color.Turquoise;


            //ANCHO DE LAS COLUMNAS
            DG_vallarta.Columns[1].Width = 250;
            DG_rena.Columns[1].Width = 250;
            DG_coloso.Columns[1].Width = 250;
            DG_velazquez.Columns[1].Width = 250;
            DG_bodega.Columns[1].Width = 250;

            DG_vallarta.Columns[2].Width = 80;
            DG_rena.Columns[2].Width = 80;
            DG_coloso.Columns[2].Width = 80;
            DG_velazquez.Columns[2].Width = 80;
            DG_bodega.Columns[2].Width = 80;

        }

      


        //################################################ OBTIENE LOS PROVEEDORES #####################################################
        public void proveedores()
        {
            try
            {
              
                MySqlCommand cmd = new MySqlCommand("Select nombre from proveed order by nombre", vallarta);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    LB_status.ForeColor = Color.DarkGreen;
                    LB_status.Text = "Conectado";

                    while (dr.Read())
                    {
                        CB_proveedores.Items.Add(dr["nombre"].ToString());
                    }
                }
                dr.Close();
            }
            catch (Exception)
            {

                LB_status.Text = "Sin conexión";
                LB_status.ForeColor = Color.Red;
            }

           

           
        }



        

        public void ProductosVallarta()

        {

           
            MySqlCommand cmd = new MySqlCommand("select ARTICULO,DESCRIP,EXISTENCIA from prods where fabricante='" + CB_proveedores.SelectedItem.ToString() + "'", vallarta);

            

            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DG_vallarta.Rows.Add( dr["ARTICULO"].ToString(), dr["DESCRIP"].ToString(), dr["EXISTENCIA"].ToString() );
            }

            

            dr.Close();

        }

        public void ProductosRena()

        {


            MySqlCommand cmd = new MySqlCommand("select ARTICULO,DESCRIP,EXISTENCIA from prods where fabricante='" + CB_proveedores.SelectedItem.ToString() + "'", rena);



            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DG_rena.Rows.Add(dr["ARTICULO"].ToString(), dr["DESCRIP"].ToString(), dr["EXISTENCIA"].ToString());
            }



            dr.Close();

        }

        public void ProductosColoso()

        {


            MySqlCommand cmd = new MySqlCommand("select ARTICULO,DESCRIP,EXISTENCIA from prods where fabricante='" + CB_proveedores.SelectedItem.ToString() + "'", coloso);



            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DG_coloso.Rows.Add(dr["ARTICULO"].ToString(), dr["DESCRIP"].ToString(), dr["EXISTENCIA"].ToString());
            }



            dr.Close();

        }

        public void ProductosVelazquez()

        {


            MySqlCommand cmd = new MySqlCommand("select ARTICULO,DESCRIP,EXISTENCIA from prods where fabricante='" + CB_proveedores.SelectedItem.ToString() + "'", velazquez);



            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DG_velazquez.Rows.Add(dr["ARTICULO"].ToString(), dr["DESCRIP"].ToString(), dr["EXISTENCIA"].ToString());
            }



            dr.Close();

        }

        public void ProductosBodega()

        {


            MySqlCommand cmd = new MySqlCommand("select ARTICULO,DESCRIP,EXISTENCIA from prods where fabricante='" + CB_proveedores.SelectedItem.ToString() + "'", bodega);



            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DG_bodega.Rows.Add(dr["ARTICULO"].ToString(), dr["DESCRIP"].ToString(), dr["EXISTENCIA"].ToString());
            }



            dr.Close();

        }

        private void ExistenciaXProveedor_Load(object sender, EventArgs e)
        {
            proveedores();
        }

        private void CB_proveedores_SelectedIndexChanged(object sender, EventArgs e)
        {

            DG_vallarta.Rows.Clear();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT PROVEEDOR FROM proveed where NOMBRE='" + CB_proveedores.SelectedItem.ToString() + "'", vallarta);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    TB_proveedor.Text = dr["proveedor"].ToString();
                }

                dr.Close();
                ProductosVallarta();
                ProductosRena();
                ProductosColoso();
                ProductosVelazquez();
                ProductosBodega();
            }
            catch (Exception ex)
            {

                
            }
        
        }

        private void CB_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

            
           
        }


        public void ExportarExcel()
        {

        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {

        }
    }
}
