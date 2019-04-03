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
    public partial class CuentasXPagar : Form
    {

        MySqlConnection conectar;


        public CuentasXPagar()
        {
            InitializeComponent();
            DG_datos.Columns[0].Width = 100;
            DG_datos.Columns[1].Width = 130;
            DG_datos.Columns[2].Width = 140;
            DG_datos.Columns[3].Width = 120;
            DG_datos.Columns[4].Width = 275;
            DG_datos.Columns[5].Width = 60;
            DG_datos.Columns[6].Width = 150;
            DG_datos.Columns[7].Width = 150;
        }

        double saldo = 0;
        double importe=0;
        DateTime fecha;
        public void EstadoCuenta()
        {
          
            MySqlCommand cmd = new MySqlCommand("select cp.cuenxpag,cp.proveedor,cp.fecha,cp.tipo_doc,cp.NO_REFEREN,cp.cargo_ab,cp.importe " +
              "from cuenxpdet cp where cp.proveedor ='" + TB_proveedor.Text + "' ORDER BY cp.FECHA", conectar);

            MySqlDataReader dr = cmd.ExecuteReader();
           
            while (dr.Read())
            {
                importe =Convert.ToDouble( dr["importe"].ToString());
                fecha = Convert.ToDateTime(dr["fecha"].ToString());
                if (dr["cargo_ab"].ToString().Equals("C"))
                {
                    saldo += Convert.ToDouble(dr["importe"].ToString());
                    //MessageBox.Show("Compra: "+aux);
                }

                else
                {


                    saldo -= Convert.ToDouble(dr["importe"].ToString());
                    //MessageBox.Show("Abono: " + aux);
                }



                DG_datos.Rows.Add(dr["cuenxpag"].ToString(), dr["proveedor"].ToString(), fecha.ToString("yyyy/MM/dd"), dr["tipo_doc"].ToString(), dr["no_referen"].ToString(), dr["cargo_ab"].ToString(), importe.ToString("C"), String.Format("{0:0.##}", saldo.ToString("C")));

            }
            //conectar.Close();
            dr.Close();

            DG_datos.Columns[0].Width = 100;
            DG_datos.Columns[1].Width = 130;
            DG_datos.Columns[2].Width = 140;
            DG_datos.Columns[3].Width = 120;
            DG_datos.Columns[4].Width = 275;
            DG_datos.Columns[5].Width = 60;
            DG_datos.Columns[6].Width = 150;
            DG_datos.Columns[7].Width = 150;

            
        }


        //################################## CARGA EN EL DATAGRID LOS DATOS DE LAS COMPRAS A ESE PROVEEDOR ###################################
        //public void CargarGrid()
        //{


        //    MySqlCommand cmd = new MySqlCommand("SELECT fecha as FECHA, cuenxpag as ID, factura as DESCRIPCION, importe as CARGO, saldo as SALDO from cuenxpag where proveedor='" + TB_proveedor.Text+"'", BDConexicon.conectar());
        //    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();


           

        //    da.Fill(dt);
        //    DG_datos.DataSource = dt;


        //    DG_datos.Columns[0].Width = 130;
        //    DG_datos.Columns[1].Width = 100;
        //    DG_datos.Columns[2].Width = 500;
        //    DG_datos.Columns[3].Width = 160;
        //    DG_datos.Columns[4].Width = 160;


        //    BDConexicon.ConectarClose();
          


        //}

        //###################################### OBTENER LOS NOMBRES DE LOS PROVEEDORES #######################################################
        public void proveedores()
        {
          

            try {

                MySqlCommand cmd = new MySqlCommand("SELECT nombre FROM proveed ORDER BY nombre ASC", conectar);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    LB_status.ForeColor = Color.DarkGreen;
                    LB_status.Text = "Conectado";
                    while (dr.Read())
                    {

                        CB_proveedor.Items.Add(dr["nombre"].ToString());
                    }

                    dr.Close();
                }
            } catch(Exception ex)
            {
                LB_status.ForeColor = Color.Red;
                LB_status.Text = "Sin Conexión";
            }
            
            
          

           
           //conectar.Close();
          
        }


        


        //############################################## CARGA LOS NOMBRES EN EL COMBOBOX  ######################################################
        private void CuentasXPagar_Load(object sender, EventArgs e)
        {
            //proveedores();
           
        }


        //############################### OBTIENE EL ID DEL PROVEEDOR CADA VEZ QUE SE SELECCIONA DEL COMBOBOX #######################################

        private void CB_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DG_datos.Rows.Clear();
            saldo = 0;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT PROVEEDOR FROM proveed where NOMBRE='" + CB_proveedor.SelectedItem.ToString() + "'", conectar);
                MySqlDataReader d = cmd.ExecuteReader();
                //MessageBox.Show(conectar.State.ToString());
                while (d.Read())
                {

                    TB_proveedor.Text = d["proveedor"].ToString();
                   
                }




               

                d.Close();
                EstadoCuenta();
             
            }
            catch (Exception ex)
            {
                //MessageBox.Show("COMBOBOX:"+ex);
            }

           
        }

  

        private void TB_filtro_TextChanged(object sender, EventArgs e)
        {
            if (TB_filtro.Text=="")
            {
                CB_proveedor.SelectedIndex = -1;
                DG_datos.DataSource = null;
            }
            else
            {
                int index = CB_proveedor.FindString(TB_filtro.Text.ToUpper());
                CB_proveedor.SelectedIndex = index;
               
            }




        }

        private void DG_datos_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string id = this.DG_datos.CurrentRow.Cells[0].Value.ToString();
            //    string des = this.DG_datos.CurrentRow.Cells[2].Value.ToString();
             double importe = Convert.ToDouble(this.DG_datos.CurrentRow.Cells[6].Value);
             double saldo = Convert.ToDouble(this.DG_datos.CurrentRow.Cells[7].Value);

            Desglose d = new Desglose();
            d.CuentXPagar(id);
            d.datoCuenta(id,importe,saldo);
            d.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void ElegirSucursar()
        {

            TB_filtro.Text = "";
            CB_proveedor.SelectedIndex=-1;
            DG_datos.DataSource = null;
            TB_proveedor.Text = "";
            LB_status.Text = "";

            if (CB_sucursal.SelectedItem.Equals("BODEGA"))
            {
                conectar = BDConexicon.BodegaOpen();
                proveedores();
            }

            if (CB_sucursal.SelectedItem.Equals("RENA"))
            {
                conectar = BDConexicon.RenaOpen();

              
                proveedores();
            }

            if (CB_sucursal.SelectedItem.Equals("COLOSO"))
            {
                
                    conectar = BDConexicon.ColosoOpen();
               
                
                proveedores();
            }

            if (CB_sucursal.SelectedItem.Equals("VELAZQUEZ"))
            {
                conectar = BDConexicon.VelazquezOpen();
                proveedores();
            }

            if (CB_sucursal.SelectedItem.Equals("VALLARTA"))
            {

                conectar = BDConexicon.VallartaOpen();
                proveedores();
            }
        }

        private void CB_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
          
                ElegirSucursar();
               
            }
            catch (Exception ex)
            {

                LB_status.ForeColor = Color.Red;
                LB_status.Text = "Sin Conexión";
            }
           
           
        }
    }
}
