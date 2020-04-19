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
        double saldo = 0;
        double importe = 0;
        DateTime fecha;
        MySqlConnection conectar;

        //###################################### EN EL CONSTRUCTOR SE CARGA EL TAMAÑO DE LAS COLUMNAS DEL DATAGRIDVIEW #################################
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

        //#################################### INSERTA EN EL DATAGRIDVIEW LOS DATOS CORRESPONDIENTES AL HISTORIAL DE PAGOS Y COMPRAS DEL PROVEEDOR ##############
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
                {//SI LA OPERACION ES "C" ES UNA COMPRA Y SE SUMA AL SALDO
                    saldo += Convert.ToDouble(dr["importe"].ToString());
                   
                }

                else
                {
                    //PERO SI ES DIFERENTE DE "C"(UN ABONO, AJUSTE, DEVOLUCIO, ETC) SE RESTA DEL SALDO DE LA CUENTA

                    saldo -= Convert.ToDouble(dr["importe"].ToString());
                   
                }


                //AQUI SE INSERTAN LAS FILAS AL DATAGRIDVIEW
                DG_datos.Rows.Add(dr["cuenxpag"].ToString(), dr["proveedor"].ToString(), fecha.ToString("dd/MM/yyyy"), dr["tipo_doc"].ToString(), dr["no_referen"].ToString(), dr["cargo_ab"].ToString(), importe.ToString("C"), String.Format("{0:0.##}", saldo.ToString("C")));

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

            DG_datos.Columns["IDPAGO"].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_datos.Columns["IDPROVEEDOR"].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_datos.Columns["FECHA_MOV"].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_datos.Columns["TIPO_DOC"].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_datos.Columns["REF"].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_datos.Columns["MOV"].SortMode = DataGridViewColumnSortMode.NotSortable;


        }



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

       
        private void label2_Click(object sender, EventArgs e)
        {

        }


        //################ AL ELEGIR UNA SUC. SE CONECTA A LA BD CORRESPONDIENTE #######################################
        public void ElegirSucursar()
        {

            try
            {
                conectar.Close();
            }
            catch (Exception ex)
            {

             
            }

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


           //############## EL METODO ELEGIRSUCURSAL() ES LLAMADO AL SELECCIONAR UN ITEM EN EL COMBOBOX ###############################
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

        private void DG_datos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = this.DG_datos.CurrentRow.Cells[0].Value.ToString();
            string des = this.DG_datos.CurrentRow.Cells[2].Value.ToString();
            //string imp = string.Format("{0:####.##}", this.DG_datos.CurrentRow.Cells[6].Value);
            string importe= Convert.ToString(this.DG_datos.CurrentRow.Cells[6].Value);
            //string sal = string.Format("{0:####.##}", this.DG_datos.CurrentRow.Cells[7].Value);
            string saldo = Convert.ToString(this.DG_datos.CurrentRow.Cells[7].Value);

            Desglose d = new Desglose();
            d.CuentXPagar(id);
            //d.datoCuenta(id, importe, saldo);
            d.Show();
        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {
            //ESTE BOTON EXPORTA EN EXCEL EL ESTADO DE CUENTA DE UN PROVEEDOR

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);



            int indiceColumna = 0;

            foreach (DataGridViewColumn col in DG_datos.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in DG_datos.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in DG_datos.Columns)
                {
                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                }



            }




            excel.Visible = true;

        }

        private void DG_datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
