using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class RetirarEfectivoTiendas : Form
    {
        public RetirarEfectivoTiendas()
        {
            InitializeComponent();
        }


        double efeVA = 0;
        double retiroVA = 0;
        double efeRE = 0;
        double retiroRE = 0;
        double efeCO = 0;
        double retiroCO = 0;
        double efeVE = 0;
        double retiroVE = 0;
        double efePRE = 0;
        double retiroPRE = 0;

        //OBTIENE EL NUMERO DE MES DEL DATATIMEPICKER Y REGRESA EL NOMBRE DEL MES
        public string MesRespaldo(int mes)
        {

            string mesRespaldo = "";

            if (mes == 1)
            {
                mesRespaldo = "ENE";
            }
            if (mes == 2)
            {
                mesRespaldo = "FEB";
            }
            if (mes == 3)
            {
                mesRespaldo = "MAR";
            }
            if (mes == 4)
            {
                mesRespaldo = "ABR";
            }
            if (mes == 5)
            {
                mesRespaldo = "MAY";
            }
            if (mes == 6)
            {
                mesRespaldo = "JUN";
            }
            if (mes == 7)
            {
                mesRespaldo = "JUL";
            }
            if (mes == 8)
            {
                mesRespaldo = "AGO";
            }
            if (mes == 9)
            {
                mesRespaldo = "SEP";
            }
            if (mes == 10)
            {
                mesRespaldo = "OCT";
            }
            if (mes == 11)
            {
                mesRespaldo = "NOV";
            }
            if (mes == 12)
            {
                mesRespaldo = "DIC";
            }
            return mesRespaldo;
        }

        //##################### METODOS QUE TRAEN EL EFECTIVO DISPONIBLE DE CADA TIENDA##################################################
        public void EfectivoVA()
        {
            TB_efevallarta.Text = "";
            LB_va.ForeColor = Color.Black;
            DateTime fecha = DT_fecha.Value;
            string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
            "where  fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

            MySqlConnection con = null;

            if (CHK_mespasado.Checked==false)
            {

                try
                {
                    con = BDConexicon.VallartaOpen();
                }
                catch (Exception)
                {

                    LB_va.ForeColor = Color.Red;
                }
            }
            else
            {
                int mes = DT_fecha.Value.Month;
                int año = DT_fecha.Value.Year;

                string mesRespaldo = MesRespaldo(mes);
                try
                {
                    con = BDConexicon.RespaldoVA(mesRespaldo, año);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("EROR: "+ex);
                }
            }
                


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LB_va.ForeColor = Color.DarkGreen;
                    string concepto = dr["concepto2"].ToString();
                    if (concepto.Equals("RPPP")||concepto.Equals("RBAN"))
                    {
                        retiroVA += Convert.ToDouble(dr["Importe"].ToString());
                    }

                    if (concepto.Equals("Retir"))
                    {
                        efeVA = Convert.ToDouble(dr["Importe"].ToString());
                    }


                }

                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {

                LB_va.ForeColor = Color.Red;
            }

            double disponible = efeVA - retiroVA;
            

            TB_efevallarta.Text = String.Format("{0:0.##}", disponible.ToString("C"));
            efeVA = 0; retiroVA = 0;

           
        }

        public void EfectivoRE()
        {
            LB_re.ForeColor = Color.Black;
            DateTime fecha = DT_fecha.Value;
            
            string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
            "where fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

            MySqlConnection con = null;

            if (CHK_mespasado.Checked == false)
            {
                try
                {
                    con = BDConexicon.RenaOpen();
                }
                catch (Exception)
                {

                    LB_re.ForeColor = Color.Red;
                }
            }
            else
            {
                int mes = DT_fecha.Value.Month;
                int año = DT_fecha.Value.Year;

                string mesRespaldo = MesRespaldo(mes);
                try
                {
                    con = BDConexicon.RespaldoRE(mesRespaldo, año);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR: "+ex);
                }
            }


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LB_re.ForeColor = Color.DarkGreen;

                    string concepto = dr["concepto2"].ToString();
                    if (concepto.Equals("RPPP")|| concepto.Equals("RBAN"))
                    {
                        retiroRE += Convert.ToDouble(dr["Importe"].ToString());
                    }

                    if (concepto.Equals("Retir"))
                    {
                        efeRE = Convert.ToDouble(dr["Importe"].ToString());
                    }

                }
                
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {

                LB_re.ForeColor = Color.Red;
            }

            double disponible = efeRE - retiroRE;
            TB_eferena.Text = String.Format("{0:0.##}", disponible.ToString("C"));

            efeRE = 0; retiroRE = 0;
            
        }

        public void EfectivoCO()
        {
            LB_co.ForeColor = Color.Black;
            DateTime fecha = DT_fecha.Value;
            
            string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
            "where fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

            MySqlConnection con = null;

            if (CHK_mespasado.Checked == false)
            {
                try
                {
                    con = BDConexicon.ColosoOpen();
                }
                catch (Exception)
                {

                    LB_co.ForeColor = Color.Red;
                }
            }
            else
            {
                int mes = DT_fecha.Value.Month;
                int año = DT_fecha.Value.Year;

                string mesRespaldo = MesRespaldo(mes);
                try
                {
                    con = BDConexicon.RespaldoCO(mesRespaldo, año);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR: " + ex);
                }
            }


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LB_co.ForeColor = Color.DarkGreen;

                    string concepto = dr["concepto2"].ToString();
                    if (concepto.Equals("RPPP") || concepto.Equals("RBAN"))
                    {
                        retiroCO += Convert.ToDouble(dr["Importe"].ToString());
                    }

                    if (concepto.Equals("Retir"))
                    {
                        efeCO = Convert.ToDouble(dr["Importe"].ToString());
                    }

                }

                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {

                LB_co.ForeColor = Color.Red;
            }

            double disponible = efeCO - retiroCO;
            TB_efecoloso.Text = String.Format("{0:0.##}", disponible.ToString("C"));

            efeCO = 0; retiroCO = 0;

        }

        public void EfectivoVE()
        {
            LB_ve.ForeColor = Color.Black;
            DateTime fecha = DT_fecha.Value;
            
            string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
            "where fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

            MySqlConnection con = null;

            if (CHK_mespasado.Checked == false)
            {
                try
                {
                    con = BDConexicon.VelazquezOpen();
                }
                catch (Exception)
                {

                    LB_ve.ForeColor = Color.Red;
                }
            }
            else
            {
                int mes = DT_fecha.Value.Month;
                int año = DT_fecha.Value.Year;

                string mesRespaldo = MesRespaldo(mes);
                try
                {
                    con = BDConexicon.RespaldoVE(mesRespaldo, año);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR: " + ex);
                }
            }


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LB_ve.ForeColor = Color.DarkGreen;

                    string concepto = dr["concepto2"].ToString();
                    if (concepto.Equals("RPPP") || concepto.Equals("RBAN"))
                    {
                        retiroVE += Convert.ToDouble(dr["Importe"].ToString());
                    }

                    if (concepto.Equals("Retir"))
                    {
                        efeVE = Convert.ToDouble(dr["Importe"].ToString());
                    }

                }

                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {

                LB_ve.ForeColor = Color.Red;
            }

            double disponible = efeVE - retiroVE;
            TB_efevelazquez.Text = String.Format("{0:0.##}", disponible.ToString("C"));

            efeVE = 0; retiroVE = 0;

        }

        public void EfectivoPRE()
        {
            LB_pre.ForeColor = Color.Black;
            DateTime fecha = DT_fecha.Value;
     
            string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
            "where fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

            MySqlConnection con = null;

            if (CHK_mespasado.Checked == false)
            {
                try
                {
                    con = BDConexicon.Papeleria1Open();
                }
                catch (Exception)
                {

                    LB_pre.ForeColor = Color.Red;
                }
            }
            else
            {
                int mes = DT_fecha.Value.Month;
                int año = DT_fecha.Value.Year;

                string mesRespaldo = MesRespaldo(mes);
                try
                {
                    con = BDConexicon.RespaldoPRE(mesRespaldo, año);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR: " + ex);
                }
            }


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LB_pre.ForeColor = Color.DarkGreen;

                    string concepto = dr["concepto2"].ToString();
                    if (concepto.Equals("RPPP") || concepto.Equals("RBAN"))
                    {
                        retiroPRE += Convert.ToDouble(dr["Importe"].ToString());
                    }

                    if (concepto.Equals("Retir"))
                    {
                        efePRE = Convert.ToDouble(dr["Importe"].ToString());
                    }

                }

                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {

                LB_pre.ForeColor = Color.Red;
            }

            double disponible = efePRE - retiroPRE;
            TB_efepregot.Text = String.Format("{0:0.##}", disponible.ToString("C"));

            efePRE = 0; retiroPRE = 0;

        }
        //###############################################################################################################################

        private void RetirarEfectivoTiendas_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        //OBTENER CONSECUTIVO  DE FLUJO
        public int ConsecFLujo(string sucursal)
        {
            int consec = 1;
            MySqlConnection con = null;



            try
            {
                if (sucursal.Equals("VALLARTA"))
                {
                    con = BDConexicon.VallartaOpen();
                }

                if (sucursal.Equals("RENA"))
                {
                    con = BDConexicon.RenaOpen();
                }
                if (sucursal.Equals("COLOSO"))
                {
                    con = BDConexicon.ColosoOpen();
                }

                if (sucursal.Equals("VELAZQUEZ"))
                {
                    con = BDConexicon.VelazquezOpen();
                }

                if (sucursal.Equals("PREGOT"))
                {
                    con = BDConexicon.Papeleria1Open();
                }

                MySqlCommand cmd = new MySqlCommand("SELECT Consec FROM CONSEC WHERE Dato ='flujo'", con);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    consec += consec = Convert.ToInt32(dr["Consec"].ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al traer consecutivo de Abonos " + ex);
            }


            return consec;
        }



        public void RetiroVA()
        {
            int consecutivoFlujo = ConsecFLujo("VALLARTA");
            DateTime fecha = DT_fecha.Value;
             DateTime fechActual = DateTime.Now;
            double retiro = Convert.ToDouble(TB_pagoVA.Text);
            MySqlConnection con = BDConexicon.VallartaOpen();

            MySqlCommand flujo = new MySqlCommand("INSERT INTO flujo(FLUJO,ABONO,CONCEPTO,ING_EG,IMPORTE,FECHA,HORA,MONEDA,ESTACION,USUARIO,USUFECHA,USUHORA,Modulo,Venta,Corte,tipo_cam,Cargo,concepto2,banco,cheque,verificado)" +
                "VALUES(?FLUJO,?ABONO,?CONCEPTO,?ING_EG,?IMPORTE,?FECHA,?HORA,?MONEDA,?ESTACION,?USUARIO,?USUFECHA,?USUHORA,?Modulo,?Venta,?Corte,?tipo_cam,?Cargo,?concepto2,?banco,?cheque,?verificado)", con);
            flujo.Parameters.AddWithValue("?FLUJO", consecutivoFlujo);
            flujo.Parameters.AddWithValue("?ABONO", "0");
            flujo.Parameters.AddWithValue("?CONCEPTO", "RBAN");
            flujo.Parameters.AddWithValue("?ING_EG", "E");
            flujo.Parameters.AddWithValue("?IMPORTE", retiro);
            flujo.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
            flujo.Parameters.AddWithValue("?HORA", "");
            flujo.Parameters.AddWithValue("?MONEDA", "MN");
            flujo.Parameters.AddWithValue("?ESTACION", "");
            flujo.Parameters.AddWithValue("?USUARIO", "");
            flujo.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
            flujo.Parameters.AddWithValue("?USUHORA", "");
            flujo.Parameters.AddWithValue("?Modulo", "PAGOS");
            flujo.Parameters.AddWithValue("?Venta", "0");
            flujo.Parameters.AddWithValue("?Corte", "1");
            flujo.Parameters.AddWithValue("?tipo_cam", "1");
            flujo.Parameters.AddWithValue("?Cargo", "0");
            flujo.Parameters.AddWithValue("?concepto2", "RBAN");
            flujo.Parameters.AddWithValue("?banco", "");
            flujo.Parameters.AddWithValue("?cheque", "");
            flujo.Parameters.AddWithValue("?verificado", "0");
            flujo.ExecuteNonQuery();

            //ACTUALIZAR CONSECUTIVO DE FLUJO
            MySqlCommand consec = new MySqlCommand("UPDATE CONSEC SET Consec='" + consecutivoFlujo + "' WHERE Dato='flujo'", con);
            consec.ExecuteNonQuery();


            MySqlConnection conVA = BDConexicon.VallartaOpen();

            double efectivoVA = Convert.ToDouble(TB_pagoVA.Text);

            MySqlCommand cmd2 = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,tipo_pago,referencia)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?fecha_efe,?tienda,?compra,?tipo_pago,?referencia)", conVA);
            cmd2.Parameters.AddWithValue("?nombreprov", "OSMART");
            cmd2.Parameters.AddWithValue("?pagarA", CB_pagara.SelectedItem.ToString());
            cmd2.Parameters.AddWithValue("?monto", efectivoVA);
            cmd2.Parameters.AddWithValue("?banco", CB_bancosOsmart.SelectedItem.ToString());
            cmd2.Parameters.AddWithValue("?cuenta", CB_cuentasOsmart.SelectedItem.ToString());
            cmd2.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
            cmd2.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
            cmd2.Parameters.AddWithValue("?tienda", "VALLARTA");
            cmd2.Parameters.AddWithValue("?compra", "");
            cmd2.Parameters.AddWithValue("?tipo_pago", "EFE");
            cmd2.Parameters.AddWithValue("?referencia",TB_referencia.Text);
            cmd2.ExecuteNonQuery();
           


        }

        public void RetiroRE()
        {
            int consecutivoFlujo = ConsecFLujo("RENA");
            DateTime fecha = DT_fecha.Value;
            DateTime fechActual = DateTime.Now;
            double retiro = Convert.ToDouble(TB_pagoRE.Text);
            MySqlConnection con = BDConexicon.RenaOpen();

            MySqlCommand flujo = new MySqlCommand("INSERT INTO flujo(FLUJO,ABONO,CONCEPTO,ING_EG,IMPORTE,FECHA,HORA,MONEDA,ESTACION,USUARIO,USUFECHA,USUHORA,Modulo,Venta,Corte,tipo_cam,Cargo,concepto2,banco,cheque,verificado)" +
                "VALUES(?FLUJO,?ABONO,?CONCEPTO,?ING_EG,?IMPORTE,?FECHA,?HORA,?MONEDA,?ESTACION,?USUARIO,?USUFECHA,?USUHORA,?Modulo,?Venta,?Corte,?tipo_cam,?Cargo,?concepto2,?banco,?cheque,?verificado)", con);
            flujo.Parameters.AddWithValue("?FLUJO", consecutivoFlujo);
            flujo.Parameters.AddWithValue("?ABONO", "0");
            flujo.Parameters.AddWithValue("?CONCEPTO", "RBAN");
            flujo.Parameters.AddWithValue("?ING_EG", "E");
            flujo.Parameters.AddWithValue("?IMPORTE", retiro);
            flujo.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
            flujo.Parameters.AddWithValue("?HORA", "");
            flujo.Parameters.AddWithValue("?MONEDA", "MN");
            flujo.Parameters.AddWithValue("?ESTACION", "");
            flujo.Parameters.AddWithValue("?USUARIO", "");
            flujo.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
            flujo.Parameters.AddWithValue("?USUHORA", "");
            flujo.Parameters.AddWithValue("?Modulo", "PAGOS");
            flujo.Parameters.AddWithValue("?Venta", "0");
            flujo.Parameters.AddWithValue("?Corte", "1");
            flujo.Parameters.AddWithValue("?tipo_cam", "1");
            flujo.Parameters.AddWithValue("?Cargo", "0");
            flujo.Parameters.AddWithValue("?concepto2", "RBAN");
            flujo.Parameters.AddWithValue("?banco", "");
            flujo.Parameters.AddWithValue("?cheque", "");
            flujo.Parameters.AddWithValue("?verificado", "0");
            flujo.ExecuteNonQuery();

            //ACTUALIZAR CONSECUTIVO DE FLUJO
            MySqlCommand consec = new MySqlCommand("UPDATE CONSEC SET Consec='" + consecutivoFlujo + "' WHERE Dato='flujo'", con);
            consec.ExecuteNonQuery();



            MySqlConnection conRE = BDConexicon.RenaOpen();
            double efectivoRE = Convert.ToDouble(TB_pagoRE.Text);

            MySqlCommand cmd2 = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,tipo_pago,referencia)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?fecha_efe,?tienda,?compra,?tipo_pago,?referencia)", conRE);
            cmd2.Parameters.AddWithValue("?nombreprov", "OSMART");
            cmd2.Parameters.AddWithValue("?pagarA", CB_pagara.SelectedItem.ToString());
            cmd2.Parameters.AddWithValue("?monto", efectivoRE);
            cmd2.Parameters.AddWithValue("?banco", CB_bancosOsmart.SelectedItem.ToString());
            cmd2.Parameters.AddWithValue("?cuenta", CB_cuentasOsmart.SelectedItem.ToString());
            cmd2.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
            cmd2.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
            cmd2.Parameters.AddWithValue("?tienda", "RENA");
            cmd2.Parameters.AddWithValue("?compra", "");
            cmd2.Parameters.AddWithValue("?tipo_pago", "EFE");
            cmd2.Parameters.AddWithValue("?referencia", TB_referencia.Text);

            cmd2.ExecuteNonQuery();

            con.Close();
            conRE.Close();


        }

        public void RetiroCO()
        {
            int consecutivoFlujo = ConsecFLujo("COLOSO");
            DateTime fecha = DT_fecha.Value;
            DateTime fechActual = DateTime.Now;
            double retiro = Convert.ToDouble(TB_pagoCO.Text);
            MySqlConnection con = BDConexicon.ColosoOpen();

            MySqlCommand flujo = new MySqlCommand("INSERT INTO flujo(FLUJO,ABONO,CONCEPTO,ING_EG,IMPORTE,FECHA,HORA,MONEDA,ESTACION,USUARIO,USUFECHA,USUHORA,Modulo,Venta,Corte,tipo_cam,Cargo,concepto2,banco,cheque,verificado)" +
                "VALUES(?FLUJO,?ABONO,?CONCEPTO,?ING_EG,?IMPORTE,?FECHA,?HORA,?MONEDA,?ESTACION,?USUARIO,?USUFECHA,?USUHORA,?Modulo,?Venta,?Corte,?tipo_cam,?Cargo,?concepto2,?banco,?cheque,?verificado)", con);
            flujo.Parameters.AddWithValue("?FLUJO", consecutivoFlujo);
            flujo.Parameters.AddWithValue("?ABONO", "0");
            flujo.Parameters.AddWithValue("?CONCEPTO", "RBAN");
            flujo.Parameters.AddWithValue("?ING_EG", "E");
            flujo.Parameters.AddWithValue("?IMPORTE", retiro);
            flujo.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
            flujo.Parameters.AddWithValue("?HORA", "");
            flujo.Parameters.AddWithValue("?MONEDA", "MN");
            flujo.Parameters.AddWithValue("?ESTACION", "");
            flujo.Parameters.AddWithValue("?USUARIO", "");
            flujo.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
            flujo.Parameters.AddWithValue("?USUHORA", "");
            flujo.Parameters.AddWithValue("?Modulo", "PAGOS");
            flujo.Parameters.AddWithValue("?Venta", "0");
            flujo.Parameters.AddWithValue("?Corte", "1");
            flujo.Parameters.AddWithValue("?tipo_cam", "1");
            flujo.Parameters.AddWithValue("?Cargo", "0");
            flujo.Parameters.AddWithValue("?concepto2", "RBAN");
            flujo.Parameters.AddWithValue("?banco", "");
            flujo.Parameters.AddWithValue("?cheque", "");
            flujo.Parameters.AddWithValue("?verificado", "0");
            flujo.ExecuteNonQuery();

            //ACTUALIZAR CONSECUTIVO DE FLUJO
            MySqlCommand consec = new MySqlCommand("UPDATE CONSEC SET Consec='" + consecutivoFlujo + "' WHERE Dato='flujo'", con);
            consec.ExecuteNonQuery();

            MySqlConnection conCO = BDConexicon.ColosoOpen();

            double efectivoCO = Convert.ToDouble(TB_pagoCO.Text);

            MySqlCommand cmd2 = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,tipo_pago,referencia)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?fecha_efe,?tienda,?compra,?tipo_pago,?referencia)", conCO);
            cmd2.Parameters.AddWithValue("?nombreprov", "OSMART");
            cmd2.Parameters.AddWithValue("?pagarA", CB_pagara.SelectedItem.ToString());
            cmd2.Parameters.AddWithValue("?monto", efectivoCO);
            cmd2.Parameters.AddWithValue("?banco", CB_bancosOsmart.SelectedItem.ToString());
            cmd2.Parameters.AddWithValue("?cuenta", CB_cuentasOsmart.SelectedItem.ToString());
            cmd2.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
            cmd2.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
            cmd2.Parameters.AddWithValue("?tienda", "COLOSO");
            cmd2.Parameters.AddWithValue("?compra", "");
            cmd2.Parameters.AddWithValue("?tipo_pago", "EFE");
            cmd2.Parameters.AddWithValue("?referencia", TB_referencia.Text);
            cmd2.ExecuteNonQuery();

            con.Close();
            conCO.Close();


        }

        public void RetiroVE()
        {
            int consecutivoFlujo = ConsecFLujo("VELAZQUEZ");
            DateTime fecha = DT_fecha.Value;
            DateTime fechActual = DateTime.Now;
            double retiro = Convert.ToDouble(TB_pagoVE.Text);
            MySqlConnection con = BDConexicon.VelazquezOpen();

            MySqlCommand flujo = new MySqlCommand("INSERT INTO flujo(FLUJO,ABONO,CONCEPTO,ING_EG,IMPORTE,FECHA,HORA,MONEDA,ESTACION,USUARIO,USUFECHA,USUHORA,Modulo,Venta,Corte,tipo_cam,Cargo,concepto2,banco,cheque,verificado)" +
                "VALUES(?FLUJO,?ABONO,?CONCEPTO,?ING_EG,?IMPORTE,?FECHA,?HORA,?MONEDA,?ESTACION,?USUARIO,?USUFECHA,?USUHORA,?Modulo,?Venta,?Corte,?tipo_cam,?Cargo,?concepto2,?banco,?cheque,?verificado)", con);
            flujo.Parameters.AddWithValue("?FLUJO", consecutivoFlujo);
            flujo.Parameters.AddWithValue("?ABONO", "0");
            flujo.Parameters.AddWithValue("?CONCEPTO", "RBAN");
            flujo.Parameters.AddWithValue("?ING_EG", "E");
            flujo.Parameters.AddWithValue("?IMPORTE", retiro);
            flujo.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
            flujo.Parameters.AddWithValue("?HORA", "");
            flujo.Parameters.AddWithValue("?MONEDA", "MN");
            flujo.Parameters.AddWithValue("?ESTACION", "");
            flujo.Parameters.AddWithValue("?USUARIO", "");
            flujo.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
            flujo.Parameters.AddWithValue("?USUHORA", "");
            flujo.Parameters.AddWithValue("?Modulo", "PAGOS");
            flujo.Parameters.AddWithValue("?Venta", "0");
            flujo.Parameters.AddWithValue("?Corte", "1");
            flujo.Parameters.AddWithValue("?tipo_cam", "1");
            flujo.Parameters.AddWithValue("?Cargo", "0");
            flujo.Parameters.AddWithValue("?concepto2", "RBAN");
            flujo.Parameters.AddWithValue("?banco", "");
            flujo.Parameters.AddWithValue("?cheque", "");
            flujo.Parameters.AddWithValue("?verificado", "0");
            flujo.ExecuteNonQuery();

            //ACTUALIZAR CONSECUTIVO DE FLUJO
            MySqlCommand consec = new MySqlCommand("UPDATE CONSEC SET Consec='" + consecutivoFlujo + "' WHERE Dato='flujo'", con);
            consec.ExecuteNonQuery();

            MySqlConnection conVE = BDConexicon.VelazquezOpen();
            double efectivoVE = Convert.ToDouble(TB_pagoVE.Text);

            MySqlCommand cmd2 = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,tipo_pago,referencia)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?fecha_efe,?tienda,?compra,?tipo_pago,?referencia)", conVE);
            cmd2.Parameters.AddWithValue("?nombreprov", "OSMART");
            cmd2.Parameters.AddWithValue("?pagarA", CB_pagara.SelectedItem.ToString());
            cmd2.Parameters.AddWithValue("?monto", efectivoVE);
            cmd2.Parameters.AddWithValue("?banco", CB_bancosOsmart.SelectedItem.ToString());
            cmd2.Parameters.AddWithValue("?cuenta", CB_cuentasOsmart.SelectedItem.ToString());
            cmd2.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
            cmd2.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
            cmd2.Parameters.AddWithValue("?tienda", "VELAZQUEZ");
            cmd2.Parameters.AddWithValue("?compra", "");
            cmd2.Parameters.AddWithValue("?tipo_pago", "EFE");
            cmd2.Parameters.AddWithValue("?referencia", TB_referencia.Text);
            cmd2.ExecuteNonQuery();

            con.Close();
            conVE.Close();


        }

        public void RetiroPRE()
        {
            int consecutivoFlujo = ConsecFLujo("PREGOT");
            DateTime fecha = DT_fecha.Value;
            DateTime fechActual = DateTime.Now;
            double retiro = Convert.ToDouble(TB_pagoPRE.Text);
            MySqlConnection con = BDConexicon.Papeleria1Open();

            MySqlCommand flujo = new MySqlCommand("INSERT INTO flujo(FLUJO,ABONO,CONCEPTO,ING_EG,IMPORTE,FECHA,HORA,MONEDA,ESTACION,USUARIO,USUFECHA,USUHORA,Modulo,Venta,Corte,tipo_cam,Cargo,concepto2,banco,cheque,verificado)" +
                "VALUES(?FLUJO,?ABONO,?CONCEPTO,?ING_EG,?IMPORTE,?FECHA,?HORA,?MONEDA,?ESTACION,?USUARIO,?USUFECHA,?USUHORA,?Modulo,?Venta,?Corte,?tipo_cam,?Cargo,?concepto2,?banco,?cheque,?verificado)", con);
            flujo.Parameters.AddWithValue("?FLUJO", consecutivoFlujo);
            flujo.Parameters.AddWithValue("?ABONO", "0");
            flujo.Parameters.AddWithValue("?CONCEPTO", "RBAN");
            flujo.Parameters.AddWithValue("?ING_EG", "E");
            flujo.Parameters.AddWithValue("?IMPORTE", retiro);
            flujo.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
            flujo.Parameters.AddWithValue("?HORA", "");
            flujo.Parameters.AddWithValue("?MONEDA", "MN");
            flujo.Parameters.AddWithValue("?ESTACION", "");
            flujo.Parameters.AddWithValue("?USUARIO", "");
            flujo.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
            flujo.Parameters.AddWithValue("?USUHORA", "");
            flujo.Parameters.AddWithValue("?Modulo", "PAGOS");
            flujo.Parameters.AddWithValue("?Venta", "0");
            flujo.Parameters.AddWithValue("?Corte", "1");
            flujo.Parameters.AddWithValue("?tipo_cam", "1");
            flujo.Parameters.AddWithValue("?Cargo", "0");
            flujo.Parameters.AddWithValue("?concepto2", "RBAN");
            flujo.Parameters.AddWithValue("?banco", "");
            flujo.Parameters.AddWithValue("?cheque", "");
            flujo.Parameters.AddWithValue("?verificado", "0");
            flujo.ExecuteNonQuery();

            //ACTUALIZAR CONSECUTIVO DE FLUJO
            MySqlCommand consec = new MySqlCommand("UPDATE CONSEC SET Consec='" + consecutivoFlujo + "' WHERE Dato='flujo'", con);
            consec.ExecuteNonQuery();


            MySqlConnection conPRE = BDConexicon.Papeleria1Open();
            double efectivoPRE = Convert.ToDouble(TB_pagoPRE.Text);

            MySqlCommand cmd2 = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,tipo_pago,referencia)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?fecha_efe,?tienda,?compra,?tipo_pago,?referencia)", conPRE);
            cmd2.Parameters.AddWithValue("?nombreprov", "OSMART");
            cmd2.Parameters.AddWithValue("?pagarA", CB_pagara.SelectedItem.ToString());
            cmd2.Parameters.AddWithValue("?monto", efectivoPRE);
            cmd2.Parameters.AddWithValue("?banco", CB_bancosOsmart.SelectedItem.ToString());
            cmd2.Parameters.AddWithValue("?cuenta", CB_cuentasOsmart.SelectedItem.ToString());
            cmd2.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
            cmd2.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
            cmd2.Parameters.AddWithValue("?tienda", "PREGOT");
            cmd2.Parameters.AddWithValue("?compra", "");
            cmd2.Parameters.AddWithValue("?tipo_pago", "EFE");
            cmd2.Parameters.AddWithValue("?referencia", TB_referencia.Text);
            cmd2.ExecuteNonQuery();

            con.Close();
            conPRE.Close();

        }

        public void Depositar()
        {

           

            MySqlConnection con = BDConexicon.BodegaOpen();
            double cantidad = 0;
            DateTime fechaDT = DT_fecha.Value;
            DateTime fecha = DateTime.Now;
            DateTime hora = DateTime.Parse(DT_fecha.Value.ToString());



            double efectivoVA = 0;
            double efectivoRE = 0;
            double efectivoCO = 0;
            double efectivoVE = 0;
            double efectivoPRE = 0;



            if (TB_pagoVA.Text.Equals(""))
            {
                efectivoVA = 0;
            }
            else
            {
                decimal va = decimal.Parse(TB_pagoVA.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string s = va.ToString("G0");
                efectivoVA = Convert.ToDouble(s);

            }

            if (TB_pagoRE.Text.Equals(""))
            {
                efectivoRE = 0;
            }
            else
            {
                decimal re = decimal.Parse(TB_pagoRE.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string s1 = re.ToString("G0");
                efectivoRE = Convert.ToDouble(s1);
            }

            if (TB_pagoCO.Text.Equals(""))
            {
                efectivoCO = 0;
            }
            else
            {
                decimal co = decimal.Parse(TB_pagoCO.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string s2 = co.ToString("G0");
                efectivoCO = Convert.ToDouble(s2);
            }

            if (TB_pagoVE.Text.Equals(""))
            {
                efectivoVE= 0;
            }
            else
            {
                decimal ve = decimal.Parse(TB_pagoVE.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string s3 = ve.ToString("G0");
                efectivoVE = Convert.ToDouble(s3);
            }

            if (TB_pagoPRE.Text.Equals(""))
            {
                efectivoPRE = 0;
            }
            else
            {
                decimal pre = decimal.Parse(TB_pagoPRE.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string s4 = pre.ToString("G0");
                efectivoPRE = Convert.ToDouble(s4);

            }




            double monto = efectivoVA + efectivoRE + efectivoCO + efectivoVE + efectivoPRE;


            decimal saldo = decimal.Parse(TB_saldobanco.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string sal = saldo.ToString("G0");
           double saldoCuenta = Convert.ToDouble(sal);
            
            double total = monto + saldoCuenta;

            TB_saldobanco.Text = String.Format("{0:0.##}", total.ToString("C"));

            //INSERTA LO QUE QUEDA DEL EFECTIVO DISPONIBLE EN LA TABLA rd_historial_saldobancos
            MySqlCommand cmd = new MySqlCommand("INSERT INTO rd_historial_saldobancos(tienda,mov,ie,banco,cuenta,pagara,cantidad,fecha,hora) VALUES(?tienda,?mov,?ie,?banco,?cuenta,?pagara,?cantidad,?fecha,?hora) ", con);
                    cmd.Parameters.AddWithValue("?tienda", CB_tienda.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("?mov","RBAN");
                    cmd.Parameters.AddWithValue("?ie", "I");
                    cmd.Parameters.AddWithValue("?banco",CB_bancosOsmart.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("?cuenta", CB_cuentasOsmart.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("?pagara", CB_pagara.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("?cantidad", monto);
                    cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("?hora", hora.ToString("HH:mm"));
                    cmd.ExecuteNonQuery();





            if (CHK_va.Checked == true)
            {
                RetiroVA();
            }

            if (CHK_re.Checked == true)
            {
                RetiroRE();
            }

            if (CHK_co.Checked == true)
            {
                RetiroCO();
            }

            if (CHK_ve.Checked == true)
            {
                RetiroVE();
            }

            if (CHK_pre.Checked == true)
            {
                RetiroPRE();
            }



            MessageBox.Show("SE HA REALIZADO EL PASO DE EFECTIVO A LA CUENTA");

        }

        public void SaldoCuentaBancaria()
        {

            double sumar = 0, restar = 0;
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand("SELECT mov,ie,cantidad FROM rd_historial_saldobancos WHERE cuenta='"+CB_cuentasOsmart.SelectedItem.ToString()+"'",con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

              

                if (dr["ie"].ToString().Equals("I"))
                {
                    sumar += Convert.ToDouble(dr["cantidad"].ToString());
                }

                if (dr["ie"].ToString().Equals("E"))
                {
                    restar += Convert.ToDouble(dr["cantidad"].ToString());
                }

            }
           

            double saldo = sumar - restar;
            TB_saldobanco.Text = String.Format("{0:0.##}", saldo.ToString("C"));
            dr.Close();
            con.Close();
        }


        //############################### BOTONES ######################################################################################
        private void BT_efectivo_Click(object sender, EventArgs e)
        {
            
            EfectivoVA();
            EfectivoRE();
            EfectivoCO();
            EfectivoVE();
            EfectivoPRE();
        }

        private void BT_Aceptar_Click(object sender, EventArgs e)
        {
            Depositar();
            SaldoCuentaBancaria();



        }





        //##############################################################################################################################

        private void CB_tienda_SelectedIndexChanged(object sender, EventArgs e)
        {

            CB_bancosOsmart.Items.Clear();
            CB_bancosOsmart.Items.Add("");
            CB_bancosOsmart.SelectedIndex = 0;
            CB_cuentasOsmart.Items.Clear();
            CB_cuentasOsmart.Items.Add("");
            CB_cuentasOsmart.SelectedIndex = 0;
          

            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand("SELECT distinct banco FROM rd_bancos_osmart WHERE tienda='" + CB_tienda.SelectedItem.ToString() + "'", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_bancosOsmart.Items.Add(dr["banco"].ToString());
            }
            dr.Close();
            con.Close();

            
        }

        private void CB_bancosOsmart_SelectedIndexChanged(object sender, EventArgs e)
        {

            CB_cuentasOsmart.Items.Clear();

            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand("SELECT distinct cuenta FROM rd_bancos_osmart WHERE banco='" + CB_bancosOsmart.SelectedItem.ToString() + "' and tienda='"+CB_tienda.SelectedItem.ToString()+"'", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_cuentasOsmart.Items.Add(dr["cuenta"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void CB_cuentasOsmart_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand("SELECT clientebancario FROM rd_bancos_osmart WHERE cuenta='" + CB_cuentasOsmart.SelectedItem.ToString() + "'", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_pagara.Items.Add(dr["clientebancario"].ToString());
            }
            dr.Close();
            con.Close();

            SaldoCuentaBancaria();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string va = "";
            string re = "";
            string co = "";
            string ve = "";
            string pre = "";
            double efeva = 0;
            double efere = 0;
            double efeco = 0;
            double efeve = 0;
            double efepre = 0;

            //QUITO EL FORMATO DE MONEDA DE LAS CAJAS DE TEXTO DEL EFECTIVO DISPONIBLE EN TIENDAS
            try
            {
                decimal digito = decimal.Parse(TB_efevallarta.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                va = digito.ToString("G0");

                decimal digito2 = decimal.Parse(TB_eferena.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                re = digito2.ToString("G0");

                decimal digito3 = decimal.Parse(TB_efecoloso.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                co = digito3.ToString("G0");

                decimal digito4 = decimal.Parse(TB_efevelazquez.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                ve = digito4.ToString("G0");

                decimal digito5 = decimal.Parse(TB_efepregot.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                pre = digito5.ToString("G0");

                //GUARDO EL EFECTIVO DISPONIBLE EN TIENDAS EN ESTAS VARIABLES



                efeva = Convert.ToDouble(va);
                efere = Convert.ToDouble(re);
                efeco = Convert.ToDouble(co);
                efeve = Convert.ToDouble(ve);
                efepre = Convert.ToDouble(pre);

            }
            catch (Exception ex)
            {

                MessageBox.Show("CALCULA EL EFECTIVO QUE HAY DISPONIBLE EN LAS TIENDAS");
            }

            //GUARDO LA CANTIDAD QUE TOMA DE CADA TIENDA
            double pagoVA = 0;
            double pagoRE = 0;
            double pagoCO = 0;
            double pagoVE = 0;
            double pagoPRE = 0;


            if (!TB_pagoVA.Text.Equals(""))
            {
                pagoVA = Convert.ToDouble(TB_pagoVA.Text);
            }

            if (!TB_pagoRE.Text.Equals(""))
            {
                pagoRE = Convert.ToDouble(TB_pagoRE.Text);
            }

            if (!TB_pagoCO.Text.Equals(""))
            {
                pagoCO = Convert.ToDouble(TB_pagoCO.Text);
            }

            if (!TB_pagoVE.Text.Equals(""))
            {
                pagoVE = Convert.ToDouble(TB_pagoVE.Text);
            }

            if (!TB_pagoPRE.Text.Equals(""))
            {
                pagoPRE = Convert.ToDouble(TB_pagoPRE.Text);
            }

            double sumaPago = pagoVA + pagoRE + pagoCO + pagoVE + pagoPRE;
            double totalVA = efeva - pagoVA;
            double totalRE = efere - pagoRE;
            double totalCO = efeco - pagoCO;
            double totalVE = efeve - pagoVE;
            double totalPRE = efepre - pagoPRE;

            TB_efevallarta.Text = String.Format("{0:0.##}", totalVA.ToString("C"));
            TB_eferena.Text = String.Format("{0:0.##}", totalRE.ToString("C"));
            TB_efecoloso.Text = String.Format("{0:0.##}", totalCO.ToString("C"));
            TB_efevelazquez.Text = String.Format("{0:0.##}", totalVE.ToString("C"));
            TB_efepregot.Text = String.Format("{0:0.##}", totalPRE.ToString("C"));

            TB_abono.Text = String.Format("{0:0.##}", sumaPago.ToString("C"));

            sumaPago = 0; totalVA = 0; totalRE = 0; totalCO = 0; totalVE = 0; totalPRE = 0;
            efeva = 0; efere = 0; efeco = 0; efeve = 0; efepre = 0;

            if (!TB_pagoVA.Text.Equals(""))
            {
                CHK_va.Checked = true;
            }

            if (!TB_pagoRE.Text.Equals(""))
            {
                CHK_re.Checked = true;
            }

            if (!TB_pagoCO.Text.Equals(""))
            {
                CHK_co.Checked = true;
            }

            if (!TB_pagoVE.Text.Equals(""))
            {
                CHK_ve.Checked = true;
            }

            if (!TB_pagoPRE.Text.Equals(""))
            {
                CHK_pre.Checked = true;
            }
        }
    }
}
