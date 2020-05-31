using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class CuentasXPagar : Form
    {
        double saldo = 0;
        double importe = 0;
        double cargo = 0;
        double abono = 0;
        string tienda = "";
        DateTime fecha;
        MySqlConnection conectar;
        DataTable DTVallarta = new DataTable();
        DataTable DTRena = new DataTable();
        DataTable DTColoso = new DataTable();
        DataTable DTVelazquez = new DataTable();
        DataTable DTPregot = new DataTable();
        DataTable DTBodega = new DataTable();
        DataTable master = new DataTable();


        //############# OBTENGO EL REGISTRO DE CARGOS Y ABONOS DE CADA UNA DE LAS TIENDAS #####################################################################
        public void CuentasPendientesVA(string proveedor)
        {

            string consulta = "SELECT CUENXPAG, PROVEEDOR, FECHA, TIPO_DOC, NO_REFEREN, CARGO_AB, IMPORTE FROM CUENXPDET WHERE PROVEEDOR ='"+ proveedor + "'";
            //DATOS DE VALLLARTA
            try
            {
                MySqlConnection conVallarta = BDConexicon.VallartaOpen();
                MySqlCommand cmdVA = new MySqlCommand(consulta, conVallarta);
                MySqlDataAdapter adVA = new MySqlDataAdapter(cmdVA);
                adVA.Fill(DTVallarta);
                DataColumn col = new DataColumn();
                col.ColumnName = "TIENDA";
                col.DefaultValue = "VALLARTA";
                DTVallarta.Columns.Add(col);
                //LB_vallarta.Text = "CONECTADO";
            }
            catch (Exception ex)
            {
                
            }
        }

        public void CuentasPendientesRE(string proveedor)
        {

            string consulta = "SELECT CUENXPAG, PROVEEDOR, FECHA, TIPO_DOC, NO_REFEREN, CARGO_AB, IMPORTE FROM CUENXPDET WHERE PROVEEDOR ='" + proveedor + "'";

            try
            {
                //DATOS DE RENA
                MySqlConnection conRena = BDConexicon.RenaOpen();
                MySqlCommand cmdRE = new MySqlCommand(consulta, conRena);
                MySqlDataAdapter adRE = new MySqlDataAdapter(cmdRE);
                adRE.Fill(DTRena);
                DataColumn col = new DataColumn();
                col.ColumnName = "TIENDA";
                col.DefaultValue = "RENA";
                DTRena.Columns.Add(col);
                //LB_rena.Text = "CONECTADO";
            }
            catch (Exception ex)
            {
               
            }

        }

        public void CuentasPendientesCO(string proveedor)
        {

            string consulta = "SELECT CUENXPAG, PROVEEDOR, FECHA, TIPO_DOC, NO_REFEREN, CARGO_AB, IMPORTE FROM CUENXPDET WHERE PROVEEDOR ='" + proveedor + "'";
            try
            {
                //DATOS DE COLOSO
                MySqlConnection conColoso = BDConexicon.ColosoOpen();
                MySqlCommand cmdCO = new MySqlCommand(consulta, conColoso);
                MySqlDataAdapter adCO = new MySqlDataAdapter(cmdCO);
                adCO.Fill(DTColoso);
                DataColumn col = new DataColumn();
                col.ColumnName = "TIENDA";
                col.DefaultValue = "COLOSO";
                DTColoso.Columns.Add(col);
                //LB_coloso.Text = "CONECTADO";
            }
            catch (Exception ex)
            {

                
            }
        }

        public void CuentasPendientesVE(string proveedor)
        {

            string consulta = "SELECT CUENXPAG, PROVEEDOR, FECHA, TIPO_DOC, NO_REFEREN, CARGO_AB, IMPORTE FROM CUENXPDET WHERE PROVEEDOR ='" + proveedor + "'";
            try
            {
                //DATOS DE VELAZQUEZ
                MySqlConnection conVelazquez = BDConexicon.VelazquezOpen();
                MySqlCommand cmdVE = new MySqlCommand(consulta, conVelazquez);
                MySqlDataAdapter adVE = new MySqlDataAdapter(cmdVE);
                adVE.Fill(DTVelazquez);
                DataColumn col = new DataColumn();
                col.ColumnName = "TIENDA";
                col.DefaultValue = "VELAZQUEZ";
                DTVelazquez.Columns.Add(col);
                //LB_velazquez.Text = "CONECTADO";
            }
            catch (Exception ex)
            {
            }
        }

        public void CuentasPendientesPRE(string proveedor)
        {
            string consulta = "SELECT CUENXPAG, PROVEEDOR, FECHA, TIPO_DOC, NO_REFEREN, CARGO_AB, IMPORTE FROM CUENXPDET WHERE PROVEEDOR ='" + proveedor + "'";
            try
            {
                //DATOS DE PREGOT
                MySqlConnection conPregot = BDConexicon.Papeleria1Open();
                MySqlCommand cmdPRE = new MySqlCommand(consulta, conPregot);
                MySqlDataAdapter adPRE = new MySqlDataAdapter(cmdPRE);
                adPRE.Fill(DTPregot);
                DataColumn col = new DataColumn();
                col.ColumnName = "TIENDA";
                col.DefaultValue = "PREGOT";
                DTPregot.Columns.Add(col);
                //LB_pregot.Text = "CONECTADO";
            }
            catch (Exception ex)
            {

            }
        }

        public void CuentasPendientesBO(string proveedor)
        {

            string consulta = "SELECT CUENXPAG, PROVEEDOR, FECHA, TIPO_DOC, NO_REFEREN, CARGO_AB, IMPORTE FROM CUENXPDET WHERE PROVEEDOR ='" + proveedor + "'";
            try
            {
               
                //DATOS DE BODEGA
                MySqlConnection conBodega = BDConexicon.BodegaOpen();
                MySqlCommand cmdBO = new MySqlCommand(consulta, conBodega);
                MySqlDataAdapter adBO = new MySqlDataAdapter(cmdBO);
                adBO.Fill(DTBodega);
                DataColumn col = new DataColumn();
                col.ColumnName = "TIENDA";
                col.DefaultValue = "BODEGA";
                DTBodega.Columns.Add(col);
                              //LB_bodega.Text = "CONECTADO";
            }
            catch (Exception ex)
            {
                
            }

        }
 

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
            master.Merge(DTVallarta);
            master.Merge(DTRena);
            master.Merge(DTColoso);
            master.Merge(DTVelazquez);
            master.Merge(DTPregot);
            master.Merge(DTBodega);
            //master.DefaultView.Sort = "FECHA";
            DataView vista = master.DefaultView;
            vista.Sort = "FECHA";
            master = vista.ToTable();


          

            for (int i = 0; i < master.Rows.Count; i++)
            {
                importe = Convert.ToDouble(master.Rows[i]["IMPORTE"].ToString());
                fecha = Convert.ToDateTime(master.Rows[i]["FECHA"].ToString());
                tienda = master.Rows[i]["TIENDA"].ToString();
               
                if (master.Rows[i]["cargo_ab"].ToString().Equals("C"))
                {//SI LA OPERACION ES "C" ES UNA COMPRA Y SE SUMA AL SALDO
                    saldo += Convert.ToDouble(master.Rows[i]["IMPORTE"].ToString());
                    cargo = Convert.ToDouble(master.Rows[i]["IMPORTE"].ToString());
                    DG_datos.Rows.Add(master.Rows[i]["CUENXPAG"].ToString(), master.Rows[i]["PROVEEDOR"].ToString() + " " + CB_proveedor.SelectedItem.ToString(), fecha.ToString("dd/MM/yyyy"), master.Rows[i]["TIPO_DOC"].ToString(), master.Rows[i]["NO_REFEREN"].ToString(), master.Rows[i]["CARGO_AB"].ToString(), tienda,String.Format("{0:0.##}", cargo.ToString("C")), "", String.Format("{0:0.##}", saldo.ToString("C")));
                }

                else
                {
                    //PERO SI ES DIFERENTE DE "C"(UN ABONO, AJUSTE, DEVOLUCIO, ETC) SE RESTA DEL SALDO DE LA CUENTA

                    saldo -= Convert.ToDouble(master.Rows[i]["IMPORTE"].ToString());
                    abono = Convert.ToDouble(master.Rows[i]["IMPORTE"].ToString());
                    DG_datos.Rows.Add(master.Rows[i]["CUENXPAG"].ToString(), master.Rows[i]["PROVEEDOR"].ToString()+" "+CB_proveedor.SelectedItem.ToString(), fecha.ToString("dd/MM/yyyy"), master.Rows[i]["TIPO_DOC"].ToString(), master.Rows[i]["NO_REFEREN"].ToString(), master.Rows[i]["CARGO_AB"].ToString(), tienda,"", String.Format("{0:0.##}", abono.ToString("C")), String.Format("{0:0.##}", saldo.ToString("C")));

                }

                
               
            }

            DG_datos.Columns["IDMOV"].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_datos.Columns["PROV"].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_datos.Columns["FECHA_"].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_datos.Columns["TIPO_DOCUMENTO"].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_datos.Columns["REFERENCIA"].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_datos.Columns["MOVIMIENTO"].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_datos.Columns["SUCURSAL"].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_datos.Columns["COMPRA"].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_datos.Columns["PAGO"].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_datos.Columns["SALDO_"].SortMode = DataGridViewColumnSortMode.NotSortable;




        }



        //###################################### OBTENER LOS NOMBRES DE LOS PROVEEDORES #######################################################
        public void proveedores()
        {
            MySqlConnection BO = BDConexicon.BodegaOpen();

            try {

                MySqlCommand cmd = new MySqlCommand("SELECT nombre FROM proveed ORDER BY nombre ASC", BO);
                MySqlDataReader dr = cmd.ExecuteReader();
                  //LB_status.ForeColor = Color.DarkGreen;
                    //LB_status.Text = "Conectado";
                    while (dr.Read())
                    {

                        CB_proveedor.Items.Add(dr["nombre"].ToString());
                    }

                    dr.Close();
                
            } catch(Exception ex)
            {
                MessageBox.Show("NO HAY CONEXIÓN CON EL SERVIDOR DE BODEGA");
            }


            BO.Close();

           
           //conectar.Close();
          
        }

        //################################ PRUEBA AL INICIAR EL FORM QUE TIENDAS TIENEN CONEXION ##########################################
        public void ProbarConexiones()
        {
            try
            {
                MySqlConnection bo = BDConexicon.BodegaOpen();
                if (bo.State == ConnectionState.Open)
                {
                  
                    LB_bo.ForeColor = Color.DarkGreen;
                }
            }
            catch (Exception ex)
            {

               
                LB_bo.ForeColor = Color.Red;
            }
            try
            {
                MySqlConnection va = BDConexicon.VallartaOpen();
                if (va.State == ConnectionState.Open)
                {
                    //LB_vallarta.Text = "CONECTADO";
                    LB_va.ForeColor = Color.DarkGreen;
                }
            }
            catch (Exception ex)
            {
                //LB_vallarta.Text = "SIN CONEXIÓN";
                LB_va.ForeColor = Color.Red;

            }


            try
            {
                MySqlConnection re = BDConexicon.RenaOpen();
                if (re.State == ConnectionState.Open)
                {
                
                    LB_re.ForeColor = Color.DarkGreen;
                }
            }
            catch (Exception ex)
            {
              
                LB_re.ForeColor = Color.Red;

            }

            try
            {

                MySqlConnection co = BDConexicon.ColosoOpen();
                if (co.State == ConnectionState.Open)
                {
                    
                    LB_co.ForeColor = Color.DarkGreen;
                }
            }
            catch (Exception ex)
            {

              
                LB_co.ForeColor = Color.Red;
            }

            try
            {
                MySqlConnection ve = BDConexicon.VelazquezOpen();
                if (ve.State == ConnectionState.Open)
                {
                  
                    LB_ve.ForeColor = Color.DarkGreen;
                }
            }
            catch (Exception ex)
            {
              
                LB_ve.ForeColor = Color.Red;

            }


            try
            {
                MySqlConnection pre = BDConexicon.Papeleria1Open();
                if (pre.State == ConnectionState.Open)
                {
                    //LB_pregot.Text = "CONECTADO";
                    LB_pre.ForeColor = Color.DarkGreen;
                }
            }
            catch (Exception ex)
            {
                //LB_pregot.Text = "SIN CONEXIÓN";
                LB_pre.ForeColor = Color.Red;

            }

           
        }


      
        private void CuentasXPagar_Load(object sender, EventArgs e)
        {
            
            proveedores();
            DG_datos.Columns["PROV"].Width = 400;
            DG_datos.Columns["FECHA_"].Width = 125;
            DG_datos.Columns["TIPO_DOCUMENTO"].Width = 100;
            DG_datos.Columns["REFERENCIA"].Width = 230;
            DG_datos.Columns["MOVIMIENTO"].Width = 50;
            DG_datos.Columns["SUCURSAL"].Width = 150;
            DG_datos.Columns["COMPRA"].Width = 155;
            DG_datos.Columns["PAGO"].Width = 150;
            DG_datos.Columns["SALDO_"].Width = 150;
        }


        //############################### OBTIENE EL ID DEL PROVEEDOR CADA VEZ QUE SE SELECCIONA DEL COMBOBOX #######################################

        private void CB_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetarComponentes();
            MySqlConnection BO = BDConexicon.BodegaOpen();
            DG_datos.Rows.Clear();
            saldo = 0;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT PROVEEDOR FROM proveed where NOMBRE='" + CB_proveedor.SelectedItem.ToString() + "'", BO);
                MySqlDataReader d = cmd.ExecuteReader();
                //MessageBox.Show(conectar.State.ToString());
                while (d.Read())
                {

                    TB_proveedor.Text = d["proveedor"].ToString();

                }
                d.Close();
                //EstadoCuenta();
             
            }
            catch (Exception ex)
            {
               
            }
            BO.Close();
           
        }



     


            private void label2_Click(object sender, EventArgs e)
        {

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

       

        private void LB_pregot_Click(object sender, EventArgs e)
        {

        }

        private void LB_velazquez_Click(object sender, EventArgs e)
        {

        }

        private void LB_vallarta_Click(object sender, EventArgs e)
        {

        }

        private void LB_coloso_Click(object sender, EventArgs e)
        {

        }

        private void LB_rena_Click(object sender, EventArgs e)
        {

        }

        public void ResetarComponentes()
        {
        
            LB_bo.ForeColor = Color.Gray;
            LB_va.ForeColor = Color.Gray;
            LB_re.ForeColor = Color.Gray;
            LB_co.ForeColor = Color.Gray;
            LB_ve.ForeColor = Color.Gray;
            LB_pre.ForeColor = Color.Gray;
            DG_datos.Rows.Clear();
          
        }

        public void button1_Click(object sender, EventArgs e)
        {
            saldo = 0;
            DTBodega.Clear();
            DTVallarta.Clear();
            DTRena.Clear();
            DTColoso.Clear();
            DTVelazquez.Clear();
            DTPregot.Clear();
            master.Clear();
            ResetarComponentes();
            ProbarConexiones();
            string proveedor = TB_proveedor.Text;
            CuentasPendientesBO(proveedor);
            CuentasPendientesVA(proveedor);
            CuentasPendientesRE(proveedor);
            CuentasPendientesCO(proveedor);
            CuentasPendientesVE(proveedor);
            CuentasPendientesPRE(proveedor);
            EstadoCuenta();
            //LIMPIAR DATATABLES
            DTBodega.Clear();
            DTVallarta.Clear();
            DTRena.Clear();
            DTColoso.Clear();
            DTVelazquez.Clear();
            DTPregot.Clear();
            master.Clear();
            if (DG_datos.RowCount==0)
            {
                MessageBox.Show("NO HAY REGISTROS DE ESTE PROVEEDOR");
            }

            


        }

        private void TB_filtro_TextChanged_1(object sender, EventArgs e)
        {
            if (TB_filtro.Text == "")
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

        private void DG_datos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

            try
            {
                //double saldo = 0;

                //if (DG_datos.Rows.Count >0)
                //{
                //    //DG_datos.Rows[DG_datos.Rows.Count - 1].Selected = true;
                //    saldo = Convert.ToDouble(DG_datos.Rows[DG_datos.Rows.Count - 1].Cells[9]);
                //}

                //string compra = Convert.ToString(DG_datos.Rows[e.RowIndex].Cells[0].Value);
                //string tienda = Convert.ToString(DG_datos.Rows[e.RowIndex].Cells[6].Value);
                ////Abonos ab = new Abonos(compra, TB_proveedor.Text, CB_proveedor.SelectedItem.ToString(),tienda);
                //Abonos ab = new Abonos();
                //ab.Show();
            }
            catch (Exception ex)
            {

                
            }
        }

        private void BT_abonos_Click(object sender, EventArgs e)
        {
            if (DG_datos.Rows.Count>0)
            {
                int filas = DG_datos.RowCount;

                decimal digito = decimal.Parse(DG_datos.Rows[filas - 1].Cells[9].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string s = digito.ToString("G0");
                saldo = Convert.ToDouble(s);

                string prov = TB_proveedor.Text;
                string nombre = CB_proveedor.SelectedItem.ToString();
                Abonos ab = new Abonos(prov, nombre, saldo);
                ab.Show();
            }
            else
            {
                MessageBox.Show("Selecciona un proveedor y busca su estado de cuenta para poder aplicar un abono");
            }
        }
    }
}
