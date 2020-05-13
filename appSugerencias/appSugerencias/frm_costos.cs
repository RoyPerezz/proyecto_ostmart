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
    

    public partial class frm_costos : Form
    {
        public frm_costos()
        {
            InitializeComponent();
        }
        DataGridView dgvGastos = new DataGridView();

        

        double IVA = 0.16;

        private void frm_costos_Load(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            int x=0;
            for (int i= 2015; i<=year; i++)
            {
                cbYear.Items.Add(i);
                x = x + 1;
            }
            cbYear.SelectedIndex = x-1;

            dgvGastos.Columns.Add("DESCRIPCION", "DESCRIPCION");
            dgvGastos.Columns.Add("TOTAL", "TOTAL");

            List<Item> mes = new List<Item>();
            List<Item> tienda = new List<Item>();

            tienda.Add(new Item("VALLARTA", "VALLARTA"));
            tienda.Add(new Item("RENA", "RENA"));
            tienda.Add(new Item("VELAZQUEZ", "DIEZ"));
            tienda.Add(new Item("COLOSO", "COLOSO"));
            tienda.Add(new Item("PREGOT", "PREGOT"));

            mes.Add(new Item("ENERO", "ENE"));
            mes.Add(new Item("FEBRERO", "FEB"));
            mes.Add(new Item("MARZO", "MAR"));
            mes.Add(new Item("ABRIL", "ABR"));
            mes.Add(new Item("MAYO", "MAY"));
            mes.Add(new Item("JUNIO", "JUN"));
            mes.Add(new Item("JULIO", "JUL"));
            mes.Add(new Item("AGOSTO", "AGO"));
            mes.Add(new Item("SEPTIEMBRE", "SEP"));
            mes.Add(new Item("OCTUBRE", "OCT"));
            mes.Add(new Item("NOVIEMBRE", "NOV"));
            mes.Add(new Item("DICIEMBRE", "DIC"));

            cbMeses.DisplayMember = "Name";
            cbMeses.ValueMember = "Value";
            cbMeses.DataSource = mes;


            cbTienda.DisplayMember = "Name";
            cbTienda.ValueMember = "Value";
            cbTienda.DataSource = tienda;

           

        }
        public void test()
        {
            string IP = "";
            string BD;
            string tienda;
            string prefijotienda;

            tienda = cbTienda.SelectedValue.ToString();

            if (tienda == "VALLARTA")
            {
                IP = "192.168.1.2";

            }
            else if (tienda == "RENA")
            {
                IP = "192.168.2.2";
            }
            else if (tienda == "COLOSO")
            {
                IP = "192.168.3.2";
            }
            else if (tienda == "DIEZ")
            {
                IP = "192.168.4.2";
            }
            else if (tienda == "PREGOT")
            {
                IP = "192.168.6.2";
            }

            BD = tienda + " " + cbMeses.SelectedValue.ToString() + " " + cbYear.Text.ToString();

            MessageBox.Show(IP + " ," + BD);
        }

        public void exportaGastos()
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            excel.Range["A1:A1000"].NumberFormat = "@";
            int indiceColumna = 0;

            foreach (DataGridViewColumn col in dgvGastos.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in dgvGastos.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in dgvGastos.Columns)
                {
                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                }



            }




            excel.Visible = true;

        }

        public void consultaGastos(int flag)
        {
           try
            {

                MySqlConnection con = conectar(); ;
                string cadena = definemes(cbMeses.SelectedValue.ToString(), cbYear.Text);

                string comando;
                comando = "";
                if (flag == 1)
                {
                     con = conectar();
                    comando = "SELECT  conegre.DESCRIP as DESCRIPCION, SUM(flujo.IMPORTE * flujo.tipo_cam) AS TOTAL FROM flujo INNER JOIN conegre ON flujo.concepto2 = conegre.CONCEPTO" +
                    " WHERE flujo.concepto <> 'CAM' AND flujo.concepto <> 'APERA' AND flujo.concepto <> 'CORTZ' AND flujo.ing_eg = 'E' AND " +
                    "flujo.concepto <> 'Retir' AND flujo.concepto <> 'CHEQ' AND flujo.concepto <> 'TARJ'  AND flujo.concepto <> 'DEV' GROUP BY flujo.concepto2 ORDER BY TOTAL DESC ";

                }
                else if (flag == 2)
                {
                     con = conectar2();
                    comando = "SELECT nombre_gasto AS DESCRIPCION,SUM(importe) AS TOTAL from rd_gastos_externos_pagos   where  fecha BETWEEN " + cadena+ " GROUP BY nombre_gasto ORDER BY TOTAL DESC";
                }
                
                MySqlCommand cmd = new MySqlCommand(comando, con);

                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();

                

                adaptador.Fill(dt);

                dgvGastos.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dgvGastos.Rows.Add();

                    dgvGastos.Rows[n].Cells[0].Value = item["DESCRIPCION"].ToString();
                    dgvGastos.Rows[n].Cells[1].Value = item["TOTAL"].ToString();

                }


                exportaGastos();

                dgvGastos.Rows.Clear();

                
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message);
            }
        }

        public void consultas()
        {
            
            double inventarioiva, inventariosys, inventariototal;
            double ventas;
            double gastosInternos,utilidadNeta,gastosExternos,utilidadBruta,gastosTotal;
            double costoVentasIVA, costoVentaSYS, costoTotal;
            double entradaIVA, entradaSYS, entradaTotal;
            utilidadBruta = 0;
            utilidadNeta = 0;
            ventas = 0;
            gastosInternos = 0;
            gastosExternos = 0;
            try
            {
                MySqlConnection con = conectar();

                //test();
                string comando = "SELECT SUM(flujo.IMPORTE * flujo.tipo_cam) AS Importe FROM flujo INNER JOIN conegre ON flujo.concepto2 = conegre.CONCEPTO " +
                    "WHERE flujo.concepto <> 'CAM' AND flujo.concepto <> 'APERA' AND flujo.concepto <> 'CORTZ' AND flujo.ing_eg = 'E' AND flujo.concepto <> 'Retir' AND " +
                    "flujo.concepto <> 'CHEQ' AND flujo.concepto <> 'TARJ' AND flujo.concepto <> 'DEV'";

                MySqlCommand cmdr = new MySqlCommand(comando, con);
                MySqlDataReader mdrr;

                mdrr = cmdr.ExecuteReader();
                if (mdrr.Read())
                {
                    gastosInternos = mdrr.GetDouble("Importe");
                    lblGastosInternos.Text = gastosInternos.ToString("C");



                }

                mdrr.Close();

                //##############################################################################################################

                //INVENTARIO

                inventariosys = 0;
                inventarioiva = 0;
                inventariototal = 0;

                comando = "SELECT SUM(EXISTENCIA * COSTO_U ) AS IMPORTE FROM prods WHERE EXISTENCIA >=1 AND IMPUESTO='IVA' ";

                MySqlCommand cmdr2 = new MySqlCommand(comando, con);
                MySqlDataReader mdrr2;

                mdrr2 = cmdr2.ExecuteReader();
                if (mdrr2.Read())
                {
                    inventarioiva = mdrr2.GetDouble("IMPORTE");
                }
                inventarioiva = inventarioiva + (inventarioiva * IVA);
                mdrr2.Close();

                comando = "SELECT SUM(EXISTENCIA * COSTO_U)  AS IMPORTE FROM prods WHERE EXISTENCIA >=1 AND IMPUESTO='SYS' ";

                MySqlCommand cmdr3 = new MySqlCommand(comando, con);
                MySqlDataReader mdrr3;

                mdrr3 = cmdr3.ExecuteReader();
                if (mdrr3.Read())
                {
                    inventariosys = mdrr3.GetFloat("IMPORTE");
                }

                mdrr3.Close();
                inventariototal = inventarioiva + inventariosys;
                lblinventario.Text = inventariototal.ToString("C");
                //#############################################################################################################
                //VENTAS

                comando = "SELECT  SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) + SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100)) As 'TOTAL' " +
                    "FROM(partvta LEFT JOIN ventas ON ventas.VENTA = partvta.VENTA) INNER JOIN prods ON partvta.ARTICULO = prods.ARTICULO WHERE ventas.ESTADO = 'CO' AND(ventas.TIPO_DOC = 'FAC' OR ventas.TIPO_DOC = 'DV' OR ventas.TIPO_DOC = 'REM') AND ventas.CIERRE = 0 ";

                MySqlCommand cmdrX = new MySqlCommand(comando, con);
                MySqlDataReader mdrrX;

                mdrrX = cmdrX.ExecuteReader();
                if (mdrrX.Read())
                {
                    ventas = mdrrX.GetDouble("TOTAL");
                    lblVentas.Text = ventas.ToString("C");



                }

                mdrrX.Close();

                //##############################################################################################################
                // COSTO VENTAS

                costoTotal = 0;
                costoVentasIVA = 0;
                costoVentaSYS = 0;
                comando = "SELECT SUM(partvta.CANTIDAD * partvta.COSTO ) AS IMPORTE FROM partvta INNER JOIN prods ON partvta.ARTICULO=prods.ARTICULO WHERE prods.IMPUESTO='IVA' ";

                MySqlCommand cmdr4 = new MySqlCommand(comando, con);
                MySqlDataReader mdrr4;

                mdrr4 = cmdr4.ExecuteReader();
                if (mdrr4.Read())
                {
                    costoVentasIVA = mdrr4.GetDouble("IMPORTE");
                }

                costoVentasIVA = costoVentasIVA + (costoVentasIVA * IVA);

                mdrr4.Close();

                comando = "SELECT SUM(partvta.CANTIDAD * partvta.COSTO  ) AS IMPORTE FROM partvta INNER JOIN prods ON partvta.ARTICULO=prods.ARTICULO WHERE prods.IMPUESTO='SYS' ";

                MySqlCommand cmdr5 = new MySqlCommand(comando, con);
                MySqlDataReader mdrr5;

                mdrr5 = cmdr5.ExecuteReader();
                if (mdrr5.Read())
                {
                    costoVentaSYS = mdrr5.GetFloat("IMPORTE");
                }

                mdrr5.Close();
                costoTotal = costoVentasIVA + costoVentaSYS;
                lblCostoVentas.Text = costoTotal.ToString("C");

                //###############################################################################################

                //INVENTARIO
                string cadena = definemes(cbMeses.SelectedValue.ToString(),cbYear.Text);
                entradaIVA = 0;
                entradaSYS = 0;
                entradaTotal = 0;

                comando = "SELECT SUM(movsinv.CANTIDAD * prods.COSTO_U) AS IMPORTE FROM movsinv  INNER JOIN prods ON prods.ARTICULO = movsinv.ARTICULO " +
                    "WHERE movsinv.ENT_SAL = 'E' AND movsinv.F_MOVIM BETWEEN " + cadena + " AND prods.IMPUESTO = 'IVA' ";

                MySqlCommand cmdr6 = new MySqlCommand(comando, con);
                MySqlDataReader mdrr6;

                mdrr6 = cmdr6.ExecuteReader();
                if (mdrr6.Read())
                {
                    entradaIVA = mdrr6.GetDouble("IMPORTE");
                }
                entradaIVA = entradaIVA + (entradaIVA * IVA);

                mdrr6.Close();

                comando = "SELECT SUM(movsinv.CANTIDAD * prods.COSTO_U ) AS IMPORTE FROM movsinv  INNER JOIN prods ON prods.ARTICULO = movsinv.ARTICULO WHERE movsinv.ENT_SAL = 'E' AND " +
                    "movsinv.F_MOVIM BETWEEN " + cadena + "AND prods.IMPUESTO = 'SYS'";


                MySqlCommand cmdr7 = new MySqlCommand(comando, con);
                MySqlDataReader mdrr7;

                mdrr7 = cmdr7.ExecuteReader();
                if (mdrr7.Read())
                {
                    if (mdrr7.IsDBNull(0))
                    {
                        entradaSYS = 0;
                    }
                    else
                    {
                        entradaSYS = mdrr7.GetFloat("IMPORTE");
                    }
                }

                mdrr7.Close();
                entradaTotal = entradaSYS + entradaIVA;
                lblentradaCosto.Text = entradaTotal.ToString("C");


                //======================================================================================
                //gastos externos
                //MessageBox.Show(cadena);
                MySqlConnection conx = conectar2();
                try
                {
                    comando = "SELECT SUM(importe) AS importe from rd_gastos_externos_pagos where  fecha BETWEEN " + cadena;

                    MySqlCommand cmdr8 = new MySqlCommand(comando, conx);
                    MySqlDataReader mdrr8;

                    mdrr8 = cmdr8.ExecuteReader();
                    if (mdrr8.Read())
                    {
                        gastosExternos = mdrr8.GetDouble("importe");
                        lblGastosExternos.Text = gastosExternos.ToString("C");



                    }

                    mdrr8.Close();
                }
                catch (Exception)
                {
                    lblGastosExternos.Text = "0";
                }
                conx.Close();
                //################################################################################################
                //OPERACIONES
                utilidadBruta = ventas - costoTotal;
                gastosTotal = gastosInternos + gastosExternos;
                utilidadNeta = utilidadBruta-gastosTotal ;

                lblGastosTotal.Text = gastosTotal.ToString("C");
                lblBruta.Text = utilidadBruta.ToString("C");
                lblUtilidadNeta.Text = utilidadNeta.ToString("C");
                con.Close();
        }
            catch
            {
                MessageBox.Show("Error al realizar la conexion");
            }

}

        private void button1_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;
            consultas();
            button1.Enabled = true;
      
        }
       public int defineMesActual()
        {
            int mes = DateTime.Now.Month;
            string mescb = cbMeses.SelectedValue.ToString();
            string mesAux;

            int flag=0;
            if (mes == 1)
            {
                mesAux = "ENE";
                if (mescb == mesAux)
                {
                    flag = 1;
                }
            }
            else if (mes == 2)
            {
                mesAux = "FEB";
                if (mescb == mesAux)
                {
                    flag = 1;
                }
            }
            else if (mes == 3)
            {
                mesAux = "MAR";
                if (mescb == mesAux)
                {
                    flag = 1;
                }
            }
            else if (mes == 4)
            {
                mesAux = "ABR";
                if (mescb == mesAux)
                {
                    flag = 1;
                }

            }
            else if (mes == 5)
            {
                mesAux = "MAY";
                if (mescb == mesAux)
                {
                    flag = 1;
                }

            }
            else if (mes == 6)
            {
                mesAux = "JUN";
                if (mescb == mesAux)
                {
                    flag = 1;
                }

            }
            else if (mes == 7)
            {
                mesAux = "JUL";
                if (mescb == mesAux)
                {
                    flag = 1;
                }

            }
            else if (mes == 8)
            {
                mesAux = "AGO";
                if (mescb == mesAux)
                {
                    flag = 1;
                }

            }
            else if (mes == 9)
            {
                mesAux = "SEP";
                if (mescb == mesAux)
                {
                    flag = 1;
                }

            }
            else if (mes == 10)
            {
                mesAux = "OCT";
                if (mescb == mesAux)
                {
                    flag = 1;
                }

            }
            else if (mes == 11)
            {
                mesAux = "NOV";
                if (mescb == mesAux)
                {
                    flag = 1;
                }

            }
            else if (mes == 12)
            {
                mesAux = "DIC";
                if (mescb == mesAux)
                {
                    flag = 1;
                }

            }
            return flag;
        }

        public  MySqlConnection conectar()
        {

            
            
            string IP = "";
            string BD = ""; ;
            string tienda;
            int flag = 0;

            string prefijotienda;

            tienda = cbTienda.SelectedValue.ToString();

            if (tienda == "VALLARTA")
            {
                IP = "192.168.1.2";

            }
            else if (tienda == "RENA")
            {
                IP = "192.168.2.2";
            }
            else if (tienda == "COLOSO")
            {
                IP = "192.168.3.2";
            }
            else if (tienda == "DIEZ")
            {
                IP = "192.168.4.2";
            }
            else if (tienda == "PREGOT")
            {
                IP = "192.168.6.2";
            }

            flag = defineMesActual();

            if (flag == 1)
            {
                BD = "MyBusinessDelta";
            }
            else
            {
                BD = tienda + " " + cbMeses.SelectedValue.ToString() + " " + cbYear.Text.ToString();
            }
            

            MySqlConnection con = new MySqlConnection("server=" + IP + "; database=" + BD + "; Uid=root; pwd=;");
            con.Open();

            

            return con;
           
        }


        public MySqlConnection conectar2()
        {



            string IP = "";
            string BD = ""; ;
            string tienda;
            //int flag = 0;

            string prefijotienda;

            tienda = cbTienda.SelectedValue.ToString();

            if (tienda == "VALLARTA")
            {
                IP = "192.168.1.2";

            }
            else if (tienda == "RENA")
            {
                IP = "192.168.2.2";
            }
            else if (tienda == "COLOSO")
            {
                IP = "192.168.3.2";
            }
            else if (tienda == "DIEZ")
            {
                IP = "192.168.4.2";
            }
            else if (tienda == "PREGOT")
            {
                IP = "192.168.6.2";
            }

            //flag = defineMesActual();

            //if (flag == 1)
            //{
            //    BD = "MyBusinessDelta";
            //}
            //else
            //{
            //    BD = tienda + " " + cbMeses.SelectedValue.ToString() + " " + cbYear.Text.ToString();
            //}

            BD = "MyBusinessDelta";

            MySqlConnection con = new MySqlConnection("server=" + IP + "; database=" + BD + "; Uid=root; pwd=;");
            con.Open();



            return con;

        }
        public string definemes(string mes, string Year)
        {
           
            string cadena;
            cadena = "";
            if (mes == "ENE")
            {
                cadena = "'"+Year+ "-01-01' AND "+   "'"+Year+"-01-31' ";

            }
            else if (mes == "FEB")
            {
                cadena = "'" + Year + "-02-01' AND"+ "'" + Year + "-02-29'";

            }
            else if (mes == "MAR")
            {
                cadena = "'" + Year + "-03-01' AND "+ "'" + Year + "-03-31'";

            }
            else if (mes == "ABR")
            {
                cadena = "'" + Year + "-04-01' AND "  +"'" + Year + "-04-30' ";


            }
            else if (mes == "MAY")
            {
                cadena = "'" + Year + "-05-01' AND "+ "'" + Year + "-05-31'";

            }
            else if (mes == "JUN")
            {
                cadena = "'" + Year + "-06-01' AND "+ "'" + Year + "  '-06-30'";

            }
            else if (mes == "JUL")
            {
                cadena = "'" + Year + "-07-01' AND " +"'" + Year + "-07-31'";

            }
            else if (mes == "AGO")
            {
                cadena = "'" + Year + "-08-01'  AND "+ "'" + Year + "-08-31'";

            }
            else if (mes == "SEP")
            {
                cadena = "'" + Year + "09-01' AND " + "'" + Year + "-09-30'";

            }
            else if (mes == "OCT")
            {
                cadena = "'" + Year + "-10-01' AND  "+ "'" + Year + "-10-30'";

            }
            else if (mes == "NOV")
            {
                cadena = "'" + Year + "-11-01' AND "+ "'" + Year + "-11-31'";

            }
            else if (mes == "DIC")
            {
                cadena = "'" + Year + "-12-01' AND  "+ "'" + Year + "-12-31'";


            }

            
            return cadena;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lblCostoVentas.Text == "---")
            {
                MessageBox.Show("No Generaste ninguna busqueda, para agregar");
            }
            else
            {
                dgvCosto.Rows.Add(cbTienda.Text, lblVentas.Text,lblCostoVentas.Text, lblGastosInternos.Text, lblUtilidadNeta.Text, lblinventario.Text  , lblentradaCosto.Text, cbMeses.SelectedValue.ToString() + " " + cbYear.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            excel.Range["A1:A1000"].NumberFormat = "@";
            int indiceColumna = 0;

            foreach (DataGridViewColumn col in dgvCosto.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in dgvCosto.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in dgvCosto.Columns)
                {
                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                }



            }




            excel.Visible = true;
        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            excel.Range["A1:A1000"].NumberFormat = "@";
            int indiceColumna = 0;

            foreach (DataGridViewColumn col in dgvCosto.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in dgvCosto.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in dgvCosto.Columns)
                {
                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                }



            }




            excel.Visible = true;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int mes = DateTime.Now.Month;
            string mescb = cbMeses.SelectedValue.ToString();
            string mesAux;
            if (mes == 1)
            {
                mesAux = "ENE";
                if (mescb == mesAux)
                {
                    MessageBox.Show("Mybusiness");
                }
            }
            else if (mes == 2)
            {
                mesAux = "FEB";
                if (mescb == mesAux)
                {
                    MessageBox.Show("Mybusiness");
                }
            }
            else if (mes == 3)
            {
                mesAux = "MAR";
                if (mescb == mesAux)
                {
                    MessageBox.Show("Mybusiness");
                }
            }
            else if (mes == 4)
            {
                mesAux = "ABR";
                if (mescb == mesAux)
                {
                    MessageBox.Show("Mybusiness");
                }

            }
            else if (mes == 5)
            {
                mesAux = "MAY";
                if (mescb == mesAux)
                {
                    MessageBox.Show("Mybusiness");
                }

            }
            else if (mes == 6)
            {
                mesAux = "JUN";
                if (mescb == mesAux)
                {
                    MessageBox.Show("Mybusiness");
                }

            }
            else if (mes == 7)
            {
                mesAux = "JUL";
                if (mescb == mesAux)
                {
                    MessageBox.Show("Mybusiness");
                }

            }
            else if (mes == 8)
            {
                mesAux = "AGO";
                if (mescb == mesAux)
                {
                    MessageBox.Show("Mybusiness");
                }

            }
            else if (mes == 9)
            {
                mesAux = "SEP";
                if (mescb == mesAux)
                {
                    MessageBox.Show("Mybusiness");
                }

            }
            else if (mes == 10)
            {
                mesAux = "OCT";
                if (mescb == mesAux)
                {
                    MessageBox.Show("Mybusiness");
                }

            }
            else if (mes == 11)
            {
                mesAux = "NOV";
                if (mescb == mesAux)
                {
                    MessageBox.Show("Mybusiness");
                }

            }
            else if (mes == 12)
            {
                mesAux = "DIC";
                if (mescb == mesAux)
                {
                    MessageBox.Show("Mybusiness");
                }

            }



            //cbMeses.SelectedItem.ToString();

            //MessageBox.Show(cbMeses.SelectedItem.ToString());

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            consultaGastos(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            consultaGastos(2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            test();
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public Item(string name, string value)
        {
            Name = name;
            Value = value;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
