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
    public partial class VentasXLinea : Form
    {
        public VentasXLinea()
        {
            InitializeComponent();
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

        private void VentasXLinea_Load(object sender, EventArgs e)
        {

            int year = DateTime.Now.Year;
            int x = 0;
            for (int i = 2015; i <= year; i++)
            {
                cbYear.Items.Add(i);
                x = x + 1;
            }
            cbYear.SelectedIndex = x - 1;

            //dgvGastos.Columns.Add("DESCRIPCION", "DESCRIPCION");
            //dgvGastos.Columns.Add("TOTAL", "TOTAL");

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

            llenaComboLinea();

        }

        public void llenaComboLinea()
        {
            MySqlConnection Conex = BDConexicon.conectar();
            cbLinea.DataSource = null;


            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Lineas", Conex);
            MySqlDataAdapter mysqladap = new MySqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();

            mysqladap.Fill(dt1);

            cbLinea.ValueMember = "Linea";
            cbLinea.DisplayMember = "Descrip";
            cbLinea.DataSource = dt1;
            Conex.Close();
        }

        public int defineMesActual()
        {
            int mes = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            string mescb = cbMeses.SelectedValue.ToString();
            string mesAux;

            int flag = 0;

            if (cbYear.Text == year.ToString())
            {
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
            }

            return flag;
        }

        public MySqlConnection conectar()
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
                cadena = "'" + Year + "-01-01' AND " + "'" + Year + "-01-31' ";

            }
            else if (mes == "FEB")
            {
                cadena = "'" + Year + "-02-01' AND" + "'" + Year + "-02-29'";

            }
            else if (mes == "MAR")
            {
                cadena = "'" + Year + "-03-01' AND " + "'" + Year + "-03-31'";

            }
            else if (mes == "ABR")
            {
                cadena = "'" + Year + "-04-01' AND " + "'" + Year + "-04-30' ";


            }
            else if (mes == "MAY")
            {
                cadena = "'" + Year + "-05-01' AND " + "'" + Year + "-05-31'";

            }
            else if (mes == "JUN")
            {
                cadena = "'" + Year + "-06-01' AND " + "'" + Year + "  '-06-30'";

            }
            else if (mes == "JUL")
            {
                cadena = "'" + Year + "-07-01' AND " + "'" + Year + "-07-31'";

            }
            else if (mes == "AGO")
            {
                cadena = "'" + Year + "-08-01'  AND " + "'" + Year + "-08-31'";

            }
            else if (mes == "SEP")
            {
                cadena = "'" + Year + "09-01' AND " + "'" + Year + "-09-30'";

            }
            else if (mes == "OCT")
            {
                cadena = "'" + Year + "-10-01' AND  " + "'" + Year + "-10-30'";

            }
            else if (mes == "NOV")
            {
                cadena = "'" + Year + "-11-01' AND " + "'" + Year + "-11-31'";

            }
            else if (mes == "DIC")
            {
                cadena = "'" + Year + "-12-01' AND  " + "'" + Year + "-12-31'";


            }


            return cadena;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consulta();
        }

        public void consulta()
        {
            double total=0;
            MySqlConnection con = conectar();

            //test();
            string comando = "SELECT prods.linea,lineas.descrip AS desclinea, " +
                "SUM(IF(ventas.tipo_doc = 'DV' OR ventas.tipo_doc = 'DEV', IF(partvta.invent <> 0, partvta.cantidad, 0), " +
                "(partvta.cantidad - partvta.a01))) AS cantvend, SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) As Importe," +
                " SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100)) As Impuesto, " +
                "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (1 + (partvta.impuesto / 100))) As Total " +
                "FROM((partvta LEFT JOIN ventas ON ventas.venta = partvta.venta) INNER JOIN prods ON partvta.articulo = prods.articulo) INNER JOIN lineas ON prods.linea = lineas.linea " +
                "WHERE ventas.estado = 'CO' AND (ventas.tipo_doc = 'FAC' Or ventas.tipo_doc = 'DV' Or ventas.tipo_doc = 'REM') AND ventas.cierre = 0 and lineas.Linea = '"+ cbLinea.SelectedValue.ToString() +"' GROUP BY lineas.linea ORDER BY lineas.linea";

            MySqlCommand cmdr = new MySqlCommand(comando, con);
            MySqlDataReader mdrr;

            mdrr = cmdr.ExecuteReader();
            if (mdrr.Read())
            {
                total = mdrr.GetDouble("Total");
                //MessageBox.Show(total.ToString("C"));



            }

            mdrr.Close();

            dgvLineas.Rows.Add(cbTienda.Text, cbMeses.SelectedValue.ToString() + " " + cbYear.Text, cbLinea.Text, total.ToString("C"));
                
        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            excel.Range["A1:A1000"].NumberFormat = "@";
            int indiceColumna = 0;

            foreach (DataGridViewColumn col in dgvLineas.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in dgvLineas.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in dgvLineas.Columns)
                {
                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                }



            }




            excel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;

            if (cbYear.Text == year.ToString())
            {
                MessageBox.Show("igual");
            }
            else
            {
                MessageBox.Show("diferente");
            }
            
        }
    }
}
