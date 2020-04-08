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
    public partial class frm_ventasxhora : Form
    {
        public frm_ventasxhora()
        {
            InitializeComponent();
        }

        DateTime fecha;
        MySqlConnection con;


        private void button2_Click(object sender, EventArgs e)
        {
            lbl7_730.Text = "---";
            lbl73_80.Text = "---";
            lbl8_83.Text = "---";
            lbl83_90.Text = "---";
            lbl90_93.Text = "---";
            lbl93_10.Text = "---";
            lbl10_1030.Text = "---";
            lbl1030_11.Text = "---";
            lbl11_1130.Text = "---";
            lbl1130_12.Text = "---";
            lbl12_1230.Text = "---";
            lbl1230_13.Text = "---";
            lbl13_1330.Text = "---";
            lbl1330_14.Text = "---";
            lbl14_1430.Text = "---";
            lbl1430_15.Text = "---";
            lbl15_1530.Text = "---";
            lbl1530_16.Text = "---";
            lbl16_1630.Text = "---";
            lbl1630_17.Text = "---";
            lbl17_1730.Text = "---";
            lbl17_1730.Text = "---";
            lbl1730_18.Text = "---";
            lbl18_1830.Text = "---";
            lbl1830_19.Text = "---";
            lbl19_1930.Text = "---";
            lbl1930_20.Text = "---";
            lbl20_2030.Text = "---";
            lbl2030_21.Text = "---";


            dgvHoras.Rows.Clear();
        }

        public void agregarGrid()
        {
            fecha = dtHora.Value;
            dgvHoras.Rows.Add(cbTienda.Text, fecha.ToString("yyyy-MM-dd"), lbl7_730.Text,lbl73_80.Text,lbl8_83.Text,lbl83_90.Text,lbl90_93.Text,lbl93_10.Text,lbl10_1030.Text,lbl1030_11.Text,lbl11_1130.Text,lbl1130_12.Text,lbl12_1230.Text,lbl1230_13.Text,lbl13_1330.Text,lbl1330_14.Text,lbl14_1430.Text,lbl1430_15.Text,lbl15_1530.Text,lbl1530_16.Text,lbl16_1630.Text,lbl1630_17.Text,lbl17_1730.Text,lbl1730_18.Text,lbl18_1830.Text,lbl1830_19.Text,lbl19_1930.Text,lbl1930_20.Text,lbl20_2030.Text,lbl2030_21.Text);

        }

        private void frm_ventasxhora_Load(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            int x = 0;
            for (int i = 2015; i <= year; i++)
            {
                cbYear.Items.Add(i);
                x = x + 1;
            }
            cbYear.SelectedIndex = x - 1;

           

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

        private void button3_Click(object sender, EventArgs e)
        {

        }


        public void consultar()
        {
            


            fecha = dtHora.Value;

            //test();
            string comando;

            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '07:00' AND '07:30' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd7_730 = new MySqlCommand(comando, con);
            MySqlDataReader mdr7_730;

            mdr7_730 = cmd7_730.ExecuteReader();
            if (mdr7_730.Read())
            {

                lbl7_730.Text = mdr7_730.GetString("VENTAS");


            }

            mdr7_730.Close();

            //===================================================

            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '07:30' AND '08:00' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd730_8 = new MySqlCommand(comando, con);
            MySqlDataReader mdr730_8;

            mdr730_8 = cmd730_8.ExecuteReader();
            if (mdr730_8.Read())
            {

                lbl73_80.Text = mdr730_8.GetString("VENTAS");


            }

            mdr730_8.Close();

            //===================================================

            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '08:00' AND '08:30' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd8_830 = new MySqlCommand(comando, con);
            MySqlDataReader mdr8_830;

            mdr8_830 = cmd8_830.ExecuteReader();
            if (mdr8_830.Read())
            {

                lbl8_83.Text = mdr8_830.GetString("VENTAS");


            }

            mdr8_830.Close();

            //===================================================
             comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '08:30' AND '09:00' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd83_9 = new MySqlCommand(comando, con);
            MySqlDataReader mdr83_9;

            mdr83_9 = cmd83_9.ExecuteReader();
            if (mdr83_9.Read())
            {

                lbl83_90.Text = mdr83_9.GetString("VENTAS");


            }

            mdr83_9.Close();

            //===================================================
            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '09:00' AND '09:30' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd9_930 = new MySqlCommand(comando, con);
            MySqlDataReader mdr9_930;

            mdr9_930 = cmd9_930.ExecuteReader();
            if (mdr9_930.Read())
            {

                lbl90_93.Text = mdr9_930.GetString("VENTAS");


            }

            mdr9_930.Close();

            //===================================================
            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '09:30' AND '10:00' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd930_10 = new MySqlCommand(comando, con);
            MySqlDataReader mdr930_10;

            mdr930_10 = cmd930_10.ExecuteReader();
            if (mdr930_10.Read())
            {

                lbl93_10.Text = mdr930_10.GetString("VENTAS");


            }

            mdr930_10.Close();

            //===================================================

            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '10:00' AND '10:30' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd10_1030 = new MySqlCommand(comando, con);
            MySqlDataReader mdr10_1030;

            mdr10_1030 = cmd10_1030.ExecuteReader();
            if (mdr10_1030.Read())
            {

                lbl10_1030.Text = mdr10_1030.GetString("VENTAS");


            }

            mdr10_1030.Close();

            //===================================================

            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '10:30' AND '11:00' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd1030_11 = new MySqlCommand(comando, con);
            MySqlDataReader mdr1030_11;

            mdr1030_11 = cmd1030_11.ExecuteReader();
            if (mdr1030_11.Read())
            {

                lbl1030_11.Text = mdr1030_11.GetString("VENTAS");


            }

            mdr1030_11.Close();

            //===================================================

            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '11:00' AND '11:30' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd11_1130 = new MySqlCommand(comando, con);
            MySqlDataReader mdr11_1130;

            mdr11_1130 = cmd11_1130.ExecuteReader();
            if (mdr11_1130.Read())
            {

                lbl11_1130.Text = mdr11_1130.GetString("VENTAS");


            }

            mdr11_1130.Close();
            //===================================================


            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '11:30' AND '12:00' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd1130_12 = new MySqlCommand(comando, con);
            MySqlDataReader mdr1130_12;

            mdr1130_12 = cmd1130_12.ExecuteReader();
            if (mdr1130_12.Read())
            {

                lbl1130_12.Text = mdr1130_12.GetString("VENTAS");


            }

            mdr1130_12.Close();
            //===================================================


         


            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '12:00' AND '12:30' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd12_1230 = new MySqlCommand(comando, con);
            MySqlDataReader mdr12_1230;

            mdr12_1230 = cmd12_1230.ExecuteReader();
            if (mdr12_1230.Read())
            {

                lbl12_1230.Text = mdr12_1230.GetString("VENTAS");


            }

            mdr12_1230.Close();
            //===================================================



            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '12:30' AND '13:00' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd1230_13 = new MySqlCommand(comando, con);
            MySqlDataReader mdr1230_13;

            mdr1230_13 = cmd1230_13.ExecuteReader();
            if (mdr1230_13.Read())
            {

                lbl1230_13.Text = mdr1230_13.GetString("VENTAS");


            }

            mdr1230_13.Close();
            //===================================================

            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '13:00' AND '13:30' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd13_1330 = new MySqlCommand(comando, con);
            MySqlDataReader mdr13_1330;

            mdr13_1330 = cmd13_1330.ExecuteReader();
            if (mdr13_1330.Read())
            {

                lbl13_1330.Text = mdr13_1330.GetString("VENTAS");


            }

            mdr13_1330.Close();
            //===================================================



            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '13:30' AND '14:00' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd1330_14 = new MySqlCommand(comando, con);
            MySqlDataReader mdr1330_14;

            mdr1330_14 = cmd1330_14.ExecuteReader();
            if (mdr1330_14.Read())
            {

                lbl1330_14.Text = mdr1330_14.GetString("VENTAS");


            }

            mdr1330_14.Close();
            //===================================================

            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '14:00' AND '14:30' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd14_1430 = new MySqlCommand(comando, con);
            MySqlDataReader mdr14_1430;

            mdr14_1430 = cmd14_1430.ExecuteReader();
            if (mdr14_1430.Read())
            {

                lbl14_1430.Text = mdr14_1430.GetString("VENTAS");


            }

            mdr14_1430.Close();
            //===================================================


            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '14:30' AND '15:00' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd1430_15 = new MySqlCommand(comando, con);
            MySqlDataReader mdr1430_15;

            mdr1430_15 = cmd1430_15.ExecuteReader();
            if (mdr1430_15.Read())
            {

                lbl1430_15.Text = mdr1430_15.GetString("VENTAS");


            }

            mdr1430_15.Close();
            //===================================================


            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '15:00' AND '15:30' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd15_1530 = new MySqlCommand(comando, con);
            MySqlDataReader mdr15_1530;

            mdr15_1530 = cmd15_1530.ExecuteReader();
            if (mdr15_1530.Read())
            {

                lbl15_1530.Text = mdr15_1530.GetString("VENTAS");


            }

            mdr15_1530.Close();
            //===================================================


            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '15:30' AND '16:00' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd1530_16 = new MySqlCommand(comando, con);
            MySqlDataReader mdr1530_16;

            mdr1530_16 = cmd1530_16.ExecuteReader();
            if (mdr1530_16.Read())
            {

                lbl1530_16.Text = mdr1530_16.GetString("VENTAS");


            }

            mdr1530_16.Close();
            //===================================================


            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '16:00' AND '16:30' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd16_1630 = new MySqlCommand(comando, con);
            MySqlDataReader mdr16_1630;

            mdr16_1630 = cmd16_1630.ExecuteReader();
            if (mdr16_1630.Read())
            {

                lbl16_1630.Text = mdr16_1630.GetString("VENTAS");


            }

            mdr16_1630.Close();
            //===================================================

            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '16:30' AND '17:00' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd1630_17 = new MySqlCommand(comando, con);
            MySqlDataReader mdr1630_17;

            mdr1630_17 = cmd1630_17.ExecuteReader();
            if (mdr1630_17.Read())
            {

                lbl1630_17.Text = mdr1630_17.GetString("VENTAS");


            }

            mdr1630_17.Close();
            //===================================================

            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '17:00' AND '17:30' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd17_1730 = new MySqlCommand(comando, con);
            MySqlDataReader mdr17_1730;

            mdr17_1730 = cmd17_1730.ExecuteReader();
            if (mdr17_1730.Read())
            {

                lbl17_1730.Text = mdr17_1730.GetString("VENTAS");


            }

            mdr17_1730.Close();
            //===================================================

            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '17:30' AND '18:00' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd1730_18= new MySqlCommand(comando, con);
            MySqlDataReader mdr1730_18;

            mdr1730_18 = cmd1730_18.ExecuteReader();
            if (mdr1730_18.Read())
            {

                lbl1730_18.Text = mdr1730_18.GetString("VENTAS");


            }

            mdr1730_18.Close();
            //===================================================


            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '18:00' AND '18:30' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd18_1830 = new MySqlCommand(comando, con);
            MySqlDataReader mdr18_1830;

            mdr18_1830 = cmd18_1830.ExecuteReader();
            if (mdr18_1830.Read())
            {

                lbl18_1830.Text = mdr18_1830.GetString("VENTAS");


            }

            mdr18_1830.Close();
            //===================================================

            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '18:30' AND '19:00' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd1830_19 = new MySqlCommand(comando, con);
            MySqlDataReader mdr1830_19;

            mdr1830_19 = cmd1830_19.ExecuteReader();
            if (mdr1830_19.Read())
            {

                lbl1830_19.Text = mdr1830_19.GetString("VENTAS");


            }

            mdr1830_19.Close();
            //===================================================


            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '19:00' AND '19:30' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd19_1930 = new MySqlCommand(comando, con);
            MySqlDataReader mdr19_1930;

            mdr19_1930 = cmd19_1930.ExecuteReader();
            if (mdr19_1930.Read())
            {

                lbl19_1930.Text = mdr19_1930.GetString("VENTAS");


            }

            mdr19_1930.Close();
            //===================================================
            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '19:30' AND '20:00' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd1930_20 = new MySqlCommand(comando, con);
            MySqlDataReader mdr1930_20;

            mdr1930_20 = cmd1930_20.ExecuteReader();
            if (mdr1930_20.Read())
            {

                lbl1930_20.Text = mdr1930_20.GetString("VENTAS");


            }

            mdr1930_20.Close();
            //===================================================

            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '20:00' AND '20:30' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd20_2030 = new MySqlCommand(comando, con);
            MySqlDataReader mdr20_2030;

            mdr20_2030 = cmd20_2030.ExecuteReader();
            if (mdr20_2030.Read())
            {

                lbl20_2030.Text = mdr20_2030.GetString("VENTAS");


            }

            mdr20_2030.Close();
            //===================================================
            comando = "SELECT COUNT(VENTA) AS VENTAS FROM ventas WHERE USUHORA BETWEEN '20:30' AND '21:00' AND F_EMISION='" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd2030_21 = new MySqlCommand(comando, con);
            MySqlDataReader mdr2030_21;

            mdr2030_21 = cmd2030_21.ExecuteReader();
            if (mdr2030_21.Read())
            {

                lbl2030_21.Text = mdr2030_21.GetString("VENTAS");


            }

            mdr2030_21.Close();
            //===================================================

            agregarGrid();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkRed;
            button1.Enabled = false;
            try
            {
                con = conectar();
                consultar();
                con.Close();
            }catch(Exception er)
            {
                MessageBox.Show("Error con la conexion");
            }
            button1.Enabled = true;
            button1.BackColor = Color.DodgerBlue;
        }

        public int defineMesActual()
        {
            int mes = DateTime.Now.Month;
            string mescb = cbMeses.SelectedValue.ToString();
            string mesAux;

            int flag = 0;
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

        public string definemes(string mes)
        {

            string cadena;
            cadena = "";
            if (mes == "ENE")
            {
                cadena = " '2020-01-01' AND   '2020-01-31' ";

            }
            else if (mes == "FEB")
            {
                cadena = " '2020-02-01' AND   '2020-02-29'";

            }
            else if (mes == "MAR")
            {
                cadena = " '2020-03-01' AND   '2020-03-31'";

            }
            else if (mes == "ABR")
            {
                cadena = " '2020-04-01' AND   '2020-04-30' ";


            }
            else if (mes == "MAY")
            {
                cadena = " '2020-05-01' AND   '2020-05-31'";

            }
            else if (mes == "JUN")
            {
                cadena = " '2020-06-01' AND   '2020-06-30'";

            }
            else if (mes == "JUL")
            {
                cadena = " '2020-07-01' AND   '2020-07-31'";

            }
            else if (mes == "AGO")
            {
                cadena = " '2019-08-01'  AND   '2020-08-31'";

            }
            else if (mes == "SEP")
            {
                cadena = " '2020-09-01' AND   '2019-09-30'";

            }
            else if (mes == "OCT")
            {
                cadena = " '2020-10-01' AND   '2020-10-30'";

            }
            else if (mes == "NOV")
            {
                cadena = " '2020-11-01' AND   '2020-11-31'";

            }
            else if (mes == "DIC")
            {
                cadena = " '2020-12-01' AND   '2020-12-31'";


            }


            return cadena;
        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            excel.Range["A1:A1000"].NumberFormat = "@";
            int indiceColumna = 0;

            foreach (DataGridViewColumn col in dgvHoras.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in dgvHoras.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in dgvHoras.Columns)
                {
                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                }



            }




            excel.Visible = true;

        }
    }




}
