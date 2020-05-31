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
    public partial class Abonos : Form
    {


        //VARIABLES GLOBALES
        int dia = 0, mes = 0, año = 0;
        string tienda = "";
        double efeVA = 0, efeRE = 0, efeCO = 0, efeVE = 0, efePRE = 0, saldo = 0;
        string compra = "", proveedor = "", nombre = "";
        int cont = 0;
        string mensaje = "";
        DataTable DTBodega = new DataTable();
        DataTable DTVallarta = new DataTable();
        DataTable DTRena = new DataTable();
        DataTable DTColoso = new DataTable();
        DataTable DTVelazquez = new DataTable();
        DataTable DTPregot = new DataTable();
        DataTable maestro = new DataTable();

        public Abonos(string proveedor, string nombre, double saldo)
        {
            InitializeComponent();
            this.proveedor = proveedor;
            this.nombre = nombre;
            this.saldo = saldo;
        }

        public void Bancos()
        {
            MySqlConnection con = BDConexicon.BodegaOpen();
            CB_banco.Items.Add("");
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT distinct banco FROM rd_cuentas_bancarias WHERE fk_proveedor='" + TB_proveedor.Text + "'", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                CB_banco.Items.Add("");
                while (dr.Read())
                {
                    CB_banco.Items.Add(dr["banco"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CARGAR BANCOS +" + ex);

            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_tipodoc.SelectedItem.ToString().Equals("EFECTIVO"))
            {
                TB_cod.Text = "EFE";
            }

            if (CB_tipodoc.SelectedItem.ToString().Equals("DEVOLUCION"))
            {
                TB_cod.Text = "DEV";
            }

            if (CB_tipodoc.SelectedItem.ToString().Equals("SPEI"))
            {
                TB_cod.Text = "SPEI";
            }

            if (CB_tipodoc.SelectedItem.ToString().Equals("SPEI"))
            {
                TB_cod.Text = "SPEI";
            }

            if (CB_tipodoc.SelectedItem.ToString().Equals("DESCUENTO"))
            {
                TB_cod.Text = "DESC";
            }

            if (CB_tipodoc.SelectedItem.ToString().Equals("DEPOSITO/EFECTIVO"))
            {
                TB_cod.Text = "DEPEFE";
            }

            if (CB_tipodoc.SelectedItem.ToString().Equals(""))
            {
                TB_cod.Text = "";
            }
        }


        public MySqlConnection ElegirSucursal()
        {
            MySqlConnection con = null;
            tienda = CB_sucursal.SelectedItem.ToString();
            if (tienda.Equals("BODEGA"))
            {
                con = BDConexicon.BodegaOpen();
            }
            if (tienda.Equals("VALLARTA"))
            {
                con = BDConexicon.VallartaOpen();
            }
            if (tienda.Equals("RENA"))
            {
                con = BDConexicon.RenaOpen();
            }

            if (tienda.Equals("COLOSO"))
            {
                con = BDConexicon.ColosoOpen();
            }

            if (tienda.Equals("VELAZQUEZ"))
            {
                con = BDConexicon.VelazquezOpen();
            }

            if (tienda.Equals("PREGOT"))
            {
                con = BDConexicon.Papeleria1Open();
            }

            return con;
        }


        public void Proveedores()
        {
            //MySqlConnection con = BDConexicon.BodegaOpen();

            //try
            //{
            //    MySqlCommand cmd = new MySqlCommand("SELECT NOMBRE FROM proveed order by NOMBRE", con);
            //    MySqlDataReader dr = cmd.ExecuteReader();

            //    while (dr.Read())
            //    {
            //        CB_proveedor.Items.Add(dr["NOMBRE"].ToString());
            //    }
            //    dr.Close();
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("Error, no se pudieron traer los proveedores: " + ex);
            //}

            //con.Close();
        }



        //OBTENER CONSECUTIVO DE ABONOS
        public int ConsecAbonos()
        {
            int consec = 1;
            MySqlConnection con = ElegirSucursal();
            try
            {

                MySqlCommand cmd = new MySqlCommand("SELECT Consec FROM CONSEC WHERE Dato ='ABONOPROV'", con);
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



        //TRAE EL SALDO DEL PROVEEDOR TRAS APLICAR EL ABONO
        public void SaldoProvedor(string proveedor)
        {
            string consulta = "SELECT CUENXPAG, PROVEEDOR, FECHA, TIPO_DOC, NO_REFEREN, CARGO_AB, IMPORTE FROM CUENXPDET WHERE PROVEEDOR ='" + proveedor + "'";

            //VALLARTA
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
                conVallarta.Close();
            }
            catch (Exception ex)
            {

            }

            //RENA
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
                conRena.Close();
            }
            catch (Exception ex)
            {

            }

            //COLOSO
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
                conColoso.Close();
            }
            catch (Exception ex)
            {


            }

            //VELAZQUEZ
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
                conVelazquez.Close();
            }
            catch (Exception ex)
            {
            }

            //PREGOT
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
                conPregot.Close();
            }
            catch (Exception ex)
            {

            }

            //BODEGA
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
                conBodega.Close();
            }
            catch (Exception ex)
            {

            }

            maestro.Merge(DTVallarta);
            maestro.Merge(DTRena);
            maestro.Merge(DTColoso);
            maestro.Merge(DTVelazquez);
            maestro.Merge(DTPregot);
            maestro.Merge(DTBodega);

            DataView vista = maestro.DefaultView;
            vista.Sort = "FECHA";
            maestro = vista.ToTable();

            for (int i = 0; i < maestro.Rows.Count; i++)
            {
                //importe = Convert.ToDouble(maestro.Rows[i]["IMPORTE"].ToString());
                //fecha = Convert.ToDateTime(maestro.Rows[i]["FECHA"].ToString());
          

                if (maestro.Rows[i]["cargo_ab"].ToString().Equals("C"))
                {//SI LA OPERACION ES "C" ES UNA COMPRA Y SE SUMA AL SALDO
                    saldo += Convert.ToDouble(maestro.Rows[i]["IMPORTE"].ToString());
                    //cargo = Convert.ToDouble(maestro.Rows[i]["IMPORTE"].ToString());
                   
                }

                else
                {
                    //PERO SI ES DIFERENTE DE "C"(UN ABONO, AJUSTE, DEVOLUCIO, ETC) SE RESTA DEL SALDO DE LA CUENTA

                    saldo -= Convert.ToDouble(maestro.Rows[i]["IMPORTE"].ToString());
                    //abono = Convert.ToDouble(maestro.Rows[i]["IMPORTE"].ToString());
                    

                }

                TB_saldo_proveedor.Text = String.Format("{0:0.##}", saldo.ToString("C"));


            }

        }

        //REALIZA EL ABONO A LA COMPRA E INSERTA LOS REGISTROS EN LAS RESPECTIVAS BD
        public void AplicarPago()
        {
            MySqlConnection con = ElegirSucursal();
            int consec = ConsecAbonos();
            DateTime fecha = DT_fecha.Value;
            DateTime hora = Convert.ToDateTime(DateTime.Now.ToString("h:mm:ss"));

            decimal digito = decimal.Parse(TB_abono.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string abono = digito.ToString("G0");
            //double monto = Convert.ToDouble(abono);

            //INSERTAR EL ABONO EN LA TABLA PAGOS
            MySqlCommand cmd = new MySqlCommand("INSERT INTO pagos(Abono,Proveedor, tipo_doc,No_referen,Importe,Moneda,TC,ImportBase,Cobrar,Banco,Fecha_dep,Autorizado,Por_apli,Aplicado,Observ,Concepto,Usuario,UsuFecha,UsuHora)" +
                "VALUES(?Abono,?Proveedor,?tipo_doc,?No_referen,?Importe,?Moneda,?TC,ImportBase,?Cobrar,?Banco,?Fecha_dep,?Autorizado,?Por_apli,?Aplicado,?Observ,?Concepto,?Usuario,?UsuFecha,?UsuHora)", con);
            cmd.Parameters.AddWithValue("?Abono", consec);
            cmd.Parameters.AddWithValue("?Proveedor", TB_proveedor.Text);
            cmd.Parameters.AddWithValue("?tipo_doc", TB_cod.Text);
            cmd.Parameters.AddWithValue("?No_referen", TB_referencia.Text);
            cmd.Parameters.AddWithValue("?Importe", abono);
            cmd.Parameters.AddWithValue("?Moneda", "MN");
            cmd.Parameters.AddWithValue("?TC", "1");
            cmd.Parameters.AddWithValue("?ImportBase", abono);
            cmd.Parameters.AddWithValue("?Cobrar", "");
            cmd.Parameters.AddWithValue("?Banco", "");
            cmd.Parameters.AddWithValue("?Fecha_dep", fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?Autorizado", "0");
            cmd.Parameters.AddWithValue("?Por_apli", "0");
            cmd.Parameters.AddWithValue("?Aplicado", "0");
            cmd.Parameters.AddWithValue("?Observ", "");
            cmd.Parameters.AddWithValue("?Concepto", "PROV");
            cmd.Parameters.AddWithValue("?Usuario", "");
            cmd.Parameters.AddWithValue("?UsuFecha", fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?UsuHora", hora);
            cmd.ExecuteNonQuery();


            //INSERTAR EL REGISTRO DEL PAGO EN LA TABLA CUENXPDET
            MySqlCommand cuenxpdet = new MySqlCommand("INSERT INTO CUENXPDET(CUENXPAG,PROVEEDOR,FECHA,TIPO_DOC,NO_REFEREN,Cargo_ab,IMPORTE,MONEDA,TIP_CAM,COMPRA,COBRADOR,OBSERV,CONTAB,ABONO,USUARIO,USUFECHA,USUHORA,ORDEN,poliza) " +
                "VALUES(?CUENXPAG,?PROVEEDOR,?FECHA,?TIPO_DOC,?NO_REFEREN,?Cargo_ab,?IMPORTE,?MONEDA,?TIP_CAM,?COMPRA,?COBRADOR,?OBSERV,?CONTAB,?ABONO,?USUARIO,?USUFECHA,?USUHORA,?ORDEN,?poliza)", con);
            cuenxpdet.Parameters.AddWithValue("?CUENXPAG", CB_cxpag.SelectedItem.ToString());
            cuenxpdet.Parameters.AddWithValue("?PROVEEDOR", TB_proveedor.Text);
            cuenxpdet.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
            cuenxpdet.Parameters.AddWithValue("?TIPO_DOC", CB_tipodoc.SelectedItem.ToString());
            cuenxpdet.Parameters.AddWithValue("?NO_REFEREN", TB_referencia.Text);
            cuenxpdet.Parameters.AddWithValue("?Cargo_ab", "A");
            cuenxpdet.Parameters.AddWithValue("?IMPORTE", abono);
            cuenxpdet.Parameters.AddWithValue("?MONEDA", "MN");
            cuenxpdet.Parameters.AddWithValue("?TIP_CAM", "1");
            cuenxpdet.Parameters.AddWithValue("?COMPRA", CB_cxpag.SelectedItem.ToString());
            cuenxpdet.Parameters.AddWithValue("?COBRADOR", "");
            cuenxpdet.Parameters.AddWithValue("?OBSERV", "");
            cuenxpdet.Parameters.AddWithValue("?CONTAB", "");
            cuenxpdet.Parameters.AddWithValue("?ABONO", consec);
            cuenxpdet.Parameters.AddWithValue("?USUARIO", "");
            cuenxpdet.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
            cuenxpdet.Parameters.AddWithValue("?USUHORA", hora);
            cuenxpdet.Parameters.AddWithValue("?ORDEN", "0");
            cuenxpdet.Parameters.AddWithValue("?poliza", "");
            cuenxpdet.ExecuteNonQuery();

            //ACTUALIZAR EL CONSECUTIVO DE LOS ABONOS EN LA TABLA CONSEC
            MySqlCommand actualizarConsec = new MySqlCommand("UPDATE consec SET Consec ='" + consec + "'" + " where Dato ='ABONOPROV'", con);
            actualizarConsec.ExecuteNonQuery();



            //OBTENGO EL SALDO DE LA COMPRA
            double saldo = 0;
            MySqlCommand saldoCompra = new MySqlCommand("SELECT SALDO FROM cuenxpag WHERE CUENXPAG='" + CB_cxpag.SelectedItem.ToString() + "'", con);
            MySqlDataReader salCompra = saldoCompra.ExecuteReader();
            while (salCompra.Read())
            {
                saldo = Convert.ToDouble(salCompra["SALDO"].ToString());
            }
            salCompra.Close();

            double pago = Convert.ToDouble(abono);
            double nuevoSaldo = saldo - pago;

            //AFECTAR EL SALDO DE LA COMPRA (RESTARLE EL ABONO QUE SE APLICÓ)
            MySqlCommand pagar = new MySqlCommand("UPDATE cuenxpag SET SALDO ='" + nuevoSaldo + "' WHERE CUENXPAG='" + CB_cxpag.SelectedItem.ToString() + "'", con);
            pagar.ExecuteNonQuery();


            //INSERTAR ABONO EN TABLA FLUJO

            if (CHK_va.Checked == true)
            {
                aplicarRetiroVA();
            }

            if (CHK_re.Checked == true)
            {
                aplicarRetiroRE();
            }

            if (CHK_co.Checked == true)
            {
                aplicarRetiroCO();
            }

            if (CHK_ve.Checked == true)
            {
                aplicarRetiroVE();
            }

            if (CHK_pre.Checked == true)
            {
                aplicarRetiroPRE();
            }





            //TRAER EL NUEVO SALDO DE LA COMPRA TRAS REALIZAR EL ABONO
            decimal digito2 = decimal.Parse(TB_saldocompra.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string saldocompra = digito2.ToString("G0");

            decimal digito3 = decimal.Parse(TB_abono.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string abonocompra = digito3.ToString("G0");

            double saldoComActual = Convert.ToDouble(saldocompra);
            double abonoCom = Convert.ToDouble(abonocompra);
            double nuevoSaldoCom = saldoComActual - abonoCom;

            TB_saldocompra.Text = String.Format("{0:0.##}", nuevoSaldoCom.ToString("C"));

            decimal digito4 = decimal.Parse(TB_saldo_proveedor.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string saldoprov = digito4.ToString("G0");

            double saldoActualProv = Convert.ToDouble(saldoprov);

            double nuevoSaldoProv = saldoActualProv - abonoCom;

            TB_saldo_proveedor.Text = String.Format("{0:0.##}", nuevoSaldoProv.ToString("C"));
            con.Close();

            //LIMPIAR ELEMENTOS
            TB_pagoVA.Text = "";
            TB_pagoRE.Text = "";
            TB_pagoCO.Text = "";
            TB_pagoVE.Text = "";
            TB_pagoPRE.Text = "";

            TB_referencia.Text = "";
            TB_abono.Text = "";
            CB_sucursal.SelectedIndex = 0;
            CB_cxpag.SelectedIndex = 0;
            CB_banco.SelectedIndex = 0;
            CB_cuenta.SelectedIndex = 0;
            CB_persona.SelectedIndex = 0;
            MessageBox.Show("ABONO APLICADO");
        }

        //BOTON PAGAR
        private void button2_Click(object sender, EventArgs e)
        {


            if (TB_cod.Text.Equals("")||CB_sucursal.SelectedIndex==0||CB_cxpag.SelectedIndex==0||CB_banco.SelectedIndex==0||CB_cuenta.SelectedIndex==0||CB_persona.SelectedIndex==0||TB_referencia.Text.Equals("")||TB_abono.Text.Equals(""))
            {
                MessageBox.Show("Favor de llenar los datos necesarios para realizar el abono");
            }
            else
            {
                AplicarPago();
            }
          
           
        }

        //BOTON TOMAR EFECTIVO
        private void button3_Click(object sender, EventArgs e)
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



        //############################## INSERTA EL DINERO TOMADO DEL EFECTIVO DISPOBIBLE EN TIENDAS EN LA TABLA FLUJO ###############################
        public void aplicarRetiroVA()
        {
            int consecutivoFlujo = ConsecFLujo("VALLARTA");
            DateTime fecha = DT_fecha.Value;
            double retiro = Convert.ToDouble(TB_pagoVA.Text);
            MySqlConnection con = BDConexicon.VallartaOpen();

            MySqlCommand flujo = new MySqlCommand("INSERT INTO flujo(FLUJO,ABONO,CONCEPTO,ING_EG,IMPORTE,FECHA,HORA,MONEDA,ESTACION,USUARIO,USUFECHA,USUHORA,Modulo,Venta,Corte,tipo_cam,Cargo,concepto2,banco,cheque,verificado)" +
                "VALUES(?FLUJO,?ABONO,?CONCEPTO,?ING_EG,?IMPORTE,?FECHA,?HORA,?MONEDA,?ESTACION,?USUARIO,?USUFECHA,?USUHORA,?Modulo,?Venta,?Corte,?tipo_cam,?Cargo,?concepto2,?banco,?cheque,?verificado)", con);
            flujo.Parameters.AddWithValue("?FLUJO", consecutivoFlujo);
            flujo.Parameters.AddWithValue("?ABONO", "0");
            flujo.Parameters.AddWithValue("?CONCEPTO", "RPPP");
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
            flujo.Parameters.AddWithValue("?concepto2", "RPPP");
            flujo.Parameters.AddWithValue("?banco", "");
            flujo.Parameters.AddWithValue("?cheque", "");
            flujo.Parameters.AddWithValue("?verificado", "0");
            flujo.ExecuteNonQuery();

            //ACTUALIZAR CONSECUTIVO DE FLUJO
            MySqlCommand consec = new MySqlCommand("UPDATE CONSEC SET Consec='"+consecutivoFlujo+"' WHERE Dato='flujo'",con);
            consec.ExecuteNonQuery();

            DateTime fechActual = DateTime.Now;
            MySqlCommand reporte = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,tienda,compra)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?tienda,?compra)", con);
            reporte.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
            reporte.Parameters.AddWithValue("?pagarA",CB_persona.SelectedItem.ToString());
            reporte.Parameters.AddWithValue("?monto", retiro);
            reporte.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
            reporte.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
            reporte.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
            reporte.Parameters.AddWithValue("?tienda",CB_sucursal.SelectedItem.ToString());
            reporte.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
            reporte.ExecuteNonQuery();
            con.Close();
        }

        public void aplicarRetiroRE()
        {
   
            DateTime fecha = DT_fecha.Value;
            double retiro = Convert.ToDouble(TB_pagoRE.Text);
            MySqlConnection con = BDConexicon.RenaOpen();
            int consecutivoFlujo = ConsecFLujo("RENA" +
                "");
            MySqlCommand flujo = new MySqlCommand("INSERT INTO flujo(FLUJO,ABONO,CONCEPTO,ING_EG,IMPORTE,FECHA,HORA,MONEDA,ESTACION,USUARIO,USUFECHA,USUHORA,Modulo,Venta,Corte,tipo_cam,Cargo,concepto2,banco,cheque,verificado)" +
                "VALUES(?FLUJO,?ABONO,?CONCEPTO,?ING_EG,?IMPORTE,?FECHA,?HORA,?MONEDA,?ESTACION,?USUARIO,?USUFECHA,?USUHORA,?Modulo,?Venta,?Corte,?tipo_cam,?Cargo,?concepto2,?banco,?cheque,?verificado)", con);
            flujo.Parameters.AddWithValue("?FLUJO", consecutivoFlujo);
            flujo.Parameters.AddWithValue("?ABONO", "0");
            flujo.Parameters.AddWithValue("?CONCEPTO", "RPPP");
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
            flujo.Parameters.AddWithValue("?concepto2", "RPPP");
            flujo.Parameters.AddWithValue("?banco", "");
            flujo.Parameters.AddWithValue("?cheque", "");
            flujo.Parameters.AddWithValue("?verificado", "0");
            flujo.ExecuteNonQuery();


            //ACTUALIZAR CONSECUTIVO DE FLUJO
            MySqlCommand consec = new MySqlCommand("UPDATE CONSEC SET Consec='" + consecutivoFlujo + "' WHERE Dato='flujo'",con);
            consec.ExecuteNonQuery();

            DateTime fechActual = DateTime.Now;
            MySqlCommand reporte = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,tienda,compra)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?tienda,?compra)", con);
            reporte.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
            reporte.Parameters.AddWithValue("?pagarA", CB_persona.SelectedItem.ToString());
            reporte.Parameters.AddWithValue("?monto", retiro);
            reporte.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
            reporte.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
            reporte.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
            reporte.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
            reporte.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
            reporte.ExecuteNonQuery();
            con.Close();
        }

        public void aplicarRetiroCO()
        {
            DateTime fecha = DT_fecha.Value;
            double retiro = Convert.ToDouble(TB_pagoCO.Text);
            MySqlConnection con = BDConexicon.ColosoOpen();
            int consecutivoFlujo = ConsecFLujo("COLOSO");
            MySqlCommand flujo = new MySqlCommand("INSERT INTO flujo(FLUJO,ABONO,CONCEPTO,ING_EG,IMPORTE,FECHA,HORA,MONEDA,ESTACION,USUARIO,USUFECHA,USUHORA,Modulo,Venta,Corte,tipo_cam,Cargo,concepto2,banco,cheque,verificado)" +
                "VALUES(?FLUJO,?ABONO,?CONCEPTO,?ING_EG,?IMPORTE,?FECHA,?HORA,?MONEDA,?ESTACION,?USUARIO,?USUFECHA,?USUHORA,?Modulo,?Venta,?Corte,?tipo_cam,?Cargo,?concepto2,?banco,?cheque,?verificado)", con);
            flujo.Parameters.AddWithValue("?FLUJO", consecutivoFlujo);
            flujo.Parameters.AddWithValue("?ABONO", "0");
            flujo.Parameters.AddWithValue("?CONCEPTO", "RPPP");
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
            flujo.Parameters.AddWithValue("?concepto2", "RPPP");
            flujo.Parameters.AddWithValue("?banco", "");
            flujo.Parameters.AddWithValue("?cheque", "");
            flujo.Parameters.AddWithValue("?verificado", "0");
            flujo.ExecuteNonQuery();

            //ACTUALIZAR CONSECUTIVO DE FLUJO
            MySqlCommand consec = new MySqlCommand("UPDATE CONSEC SET Consec='" + consecutivoFlujo + "' WHERE Dato='flujo'",con);
            consec.ExecuteNonQuery();

            DateTime fechActual = DateTime.Now;
            MySqlCommand reporte = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,tienda,compra)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?tienda,?compra)", con);
            reporte.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
            reporte.Parameters.AddWithValue("?pagarA", CB_persona.SelectedItem.ToString());
            reporte.Parameters.AddWithValue("?monto", retiro);
            reporte.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
            reporte.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
            reporte.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
            reporte.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
            reporte.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
            reporte.ExecuteNonQuery();
            con.Close();
        }

        public void aplicarRetiroVE()
        {
            DateTime fecha = DT_fecha.Value;
            double retiro = Convert.ToDouble(TB_pagoVE.Text);
            MySqlConnection con = BDConexicon.VelazquezOpen();
            int consecutivoFlujo = ConsecFLujo("VELAZQUEZ");
            MySqlCommand flujo = new MySqlCommand("INSERT INTO flujo(FLUJO,ABONO,CONCEPTO,ING_EG,IMPORTE,FECHA,HORA,MONEDA,ESTACION,USUARIO,USUFECHA,USUHORA,Modulo,Venta,Corte,tipo_cam,Cargo,concepto2,banco,cheque,verificado)" +
                "VALUES(?FLUJO,?ABONO,?CONCEPTO,?ING_EG,?IMPORTE,?FECHA,?HORA,?MONEDA,?ESTACION,?USUARIO,?USUFECHA,?USUHORA,?Modulo,?Venta,?Corte,?tipo_cam,?Cargo,?concepto2,?banco,?cheque,?verificado)", con);
            flujo.Parameters.AddWithValue("?FLUJO", consecutivoFlujo);
            flujo.Parameters.AddWithValue("?ABONO", "0");
            flujo.Parameters.AddWithValue("?CONCEPTO", "RPPP");
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
            flujo.Parameters.AddWithValue("?concepto2", "RPPP");
            flujo.Parameters.AddWithValue("?banco", "");
            flujo.Parameters.AddWithValue("?cheque", "");
            flujo.Parameters.AddWithValue("?verificado", "0");
            flujo.ExecuteNonQuery();

            //ACTUALIZAR CONSECUTIVO DE FLUJO
            MySqlCommand consec = new MySqlCommand("UPDATE CONSEC SET Consec='" + consecutivoFlujo + "' WHERE Dato='flujo'",con);
            consec.ExecuteNonQuery();

            DateTime fechActual = DateTime.Now;
            MySqlCommand reporte = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,tienda,compra)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?tienda,?compra)", con);
            reporte.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
            reporte.Parameters.AddWithValue("?pagarA", CB_persona.SelectedItem.ToString());
            reporte.Parameters.AddWithValue("?monto", retiro);
            reporte.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
            reporte.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
            reporte.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
            reporte.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
            reporte.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
            reporte.ExecuteNonQuery();
            con.Close();
        }

        public void aplicarRetiroPRE()
        {
            DateTime fecha = DT_fecha.Value;
            double retiro = Convert.ToDouble(TB_pagoPRE.Text);
            MySqlConnection con = BDConexicon.Papeleria1Open();
            int consecutivoFlujo = ConsecFLujo("RENA");
            MySqlCommand flujo = new MySqlCommand("INSERT INTO flujo(FLUJO,ABONO,CONCEPTO,ING_EG,IMPORTE,FECHA,HORA,MONEDA,ESTACION,USUARIO,USUFECHA,USUHORA,Modulo,Venta,Corte,tipo_cam,Cargo,concepto2,banco,cheque,verificado)" +
                "VALUES(?FLUJO,?ABONO,?CONCEPTO,?ING_EG,?IMPORTE,?FECHA,?HORA,?MONEDA,?ESTACION,?USUARIO,?USUFECHA,?USUHORA,?Modulo,?Venta,?Corte,?tipo_cam,?Cargo,?concepto2,?banco,?cheque,?verificado)", con);
            flujo.Parameters.AddWithValue("?FLUJO", consecutivoFlujo);
            flujo.Parameters.AddWithValue("?ABONO", "0");
            flujo.Parameters.AddWithValue("?CONCEPTO", "RPPP");
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
            flujo.Parameters.AddWithValue("?concepto2", "RPPP");
            flujo.Parameters.AddWithValue("?banco", "");
            flujo.Parameters.AddWithValue("?cheque", "");
            flujo.Parameters.AddWithValue("?verificado", "0");
            flujo.ExecuteNonQuery();

            //ACTUALIZAR CONSECUTIVO DE FLUJO
            MySqlCommand consec = new MySqlCommand("UPDATE CONSEC SET Consec='" + consecutivoFlujo + "' WHERE Dato='flujo'",con);
            consec.ExecuteNonQuery();

            DateTime fechActual = DateTime.Now;
            MySqlCommand reporte = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,tienda,compra)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?tienda,?compra)", con);
            reporte.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
            reporte.Parameters.AddWithValue("?pagarA", CB_persona.SelectedItem.ToString());
            reporte.Parameters.AddWithValue("?monto", retiro);
            reporte.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
            reporte.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
            reporte.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
            reporte.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
            reporte.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
            reporte.ExecuteNonQuery();
            con.Close();
        }
        //##########################################################################################################################################


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        //############################## EVENTOS DE COMBOBOX ###############################################
        private void CB_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MySqlConnection con = BDConexicon.BodegaOpen();
            //try
            //{
            //    MySqlCommand cmd = new MySqlCommand("SELECT PROVEEDOR FROM proveed WHERE NOMBRE ='"+CB_proveedor.SelectedItem.ToString()+"'", con);
            //    MySqlDataReader dr = cmd.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        TB_proveedor.Text=dr["PROVEEDOR"].ToString();
            //    }
            //    dr.Close();
            //}
            //catch (Exception ex)
            //{
                

            //}
            //con.Close();
        }

        private void CB_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sucursal = Convert.ToString(CB_sucursal.SelectedItem.ToString());
            MySqlConnection con = null;
            CB_cxpag.Items.Clear();
            CB_cxpag.Items.Add("");
            //CB_cxpag.SelectedIndex = 0;


            if (sucursal.Equals("BODEGA"))
            {
                try
                {
                    con = BDConexicon.BodegaOpen();
                    MySqlCommand cmd = new MySqlCommand("SELECT CUENXPAG FROM cuenxpag WHERE PROVEEDOR ='" + TB_proveedor.Text + "' AND SALDO>1 OR SALDO<0", con);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        CB_cxpag.Items.Add(dr["CUENXPAG"].ToString());
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR de conexión: "+ex);
                }
                con.Close();
            }

            if (sucursal.Equals("VALLARTA"))
            {
                try
                {
                    con = BDConexicon.VallartaOpen();
                    MySqlCommand cmd = new MySqlCommand("SELECT CUENXPAG FROM cuenxpag WHERE PROVEEDOR ='" + TB_proveedor.Text + "' AND SALDO>1 OR SALDO<0", con);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        CB_cxpag.Items.Add(dr["CUENXPAG"].ToString());
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR de conexión: " + ex);
                }
                con.Close();
            }

            if (sucursal.Equals("RENA"))
            {
                try
                {
                    con = BDConexicon.RenaOpen();
                    MySqlCommand cmd = new MySqlCommand("SELECT CUENXPAG FROM cuenxpag WHERE PROVEEDOR ='" + TB_proveedor.Text + "' AND SALDO>1 OR SALDO<0", con);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        CB_cxpag.Items.Add(dr["CUENXPAG"].ToString());
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR de conexión: " + ex);
                }
                con.Close();
            }

            if (sucursal.Equals("COLOSO"))
            {
                try
                {
                    con = BDConexicon.ColosoOpen();
                    MySqlCommand cmd = new MySqlCommand("SELECT CUENXPAG FROM cuenxpag WHERE PROVEEDOR ='" + TB_proveedor.Text + "' AND SALDO>1 OR SALDO<0", con);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        CB_cxpag.Items.Add(dr["CUENXPAG"].ToString());
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR de conexión: " + ex);
                }
                con.Close();
            }

            if (sucursal.Equals("VELAZQUEZ"))
            {
                try
                {
                    con = BDConexicon.VelazquezOpen();
                    MySqlCommand cmd = new MySqlCommand("SELECT CUENXPAG FROM cuenxpag WHERE PROVEEDOR ='" + TB_proveedor.Text + "' AND SALDO>1 OR SALDO<0", con);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        CB_cxpag.Items.Add(dr["CUENXPAG"].ToString());
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR de conexión: " + ex);
                }
                con.Close();
            }

            if (sucursal.Equals("PREGOT"))
            {
                try
                {
                    con = BDConexicon.Papeleria1Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT CUENXPAG FROM cuenxpag WHERE PROVEEDOR ='" + TB_proveedor.Text + "' AND SALDO>1 OR SALDO<0", con);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        CB_cxpag.Items.Add(dr["CUENXPAG"].ToString());
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR de conexión: " + ex);
                }
                con.Close();
            }

            
        }

        private void CB_cxpag_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sucursal = CB_sucursal.SelectedItem.ToString();
            MySqlConnection con = null;


            if (sucursal.Equals("BODEGA"))
            {
                try
                {
                    con = BDConexicon.BodegaOpen();
                    MySqlCommand cmd = new MySqlCommand("SELECT SALDO FROM cuenxpag WHERE CUENXPAG ='" + CB_cxpag.SelectedItem.ToString() + "'", con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    double saldocompra = 0;
                    while (dr.Read())
                    {
                        saldocompra = Convert.ToDouble(dr["SALDO"].ToString());
                        TB_saldocompra.Text = String.Format("{0:0.##}", saldocompra.ToString("C"));
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR de conexión: " + ex);
                }
                con.Close();
            }

            if (sucursal.Equals("VALLARTA"))
            {
                try
                {
                    con = BDConexicon.VallartaOpen();
                    MySqlCommand cmd = new MySqlCommand("SELECT SALDO FROM cuenxpag WHERE CUENXPAG ='" + CB_cxpag.SelectedItem.ToString() + "'", con);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        TB_saldocompra.Text=dr["SALDO"].ToString();
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR de conexión: " + ex);
                }
                con.Close();
            }

            if (sucursal.Equals("RENA"))
            {
                try
                {
                    con = BDConexicon.RenaOpen();
                    MySqlCommand cmd = new MySqlCommand("SELECT SALDO FROM cuenxpag WHERE CUENXPAG ='" + CB_cxpag.SelectedItem.ToString() + "'", con);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        TB_saldocompra.Text=dr["SALDO"].ToString();
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR de conexión: " + ex);
                }
                con.Close();
            }

            if (sucursal.Equals("COLOSO"))
            {
                try
                {
                    con = BDConexicon.ColosoOpen();
                    MySqlCommand cmd = new MySqlCommand("SELECT SALDO FROM cuenxpag WHERE CUENXPAG ='" + CB_cxpag.SelectedItem.ToString() + "'", con);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        TB_saldocompra.Text=dr["SALDO"].ToString();
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR de conexión: " + ex);
                }
                con.Close();
            }

            if (sucursal.Equals("VELAZQUEZ"))
            {
                try
                {
                    con = BDConexicon.VelazquezOpen();
                    MySqlCommand cmd = new MySqlCommand("SELECT SALDO FROM cuenxpag WHERE CUENXPAG ='" + CB_cxpag.SelectedItem.ToString() + "'", con);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        TB_saldocompra.Text=dr["SALDO"].ToString();
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR de conexión: " + ex);
                }
                con.Close();
            }

            if (sucursal.Equals("PREGOT"))
            {
                try
                {
                    con = BDConexicon.Papeleria1Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT SALDO FROM cuenxpag WHERE CUENXPAG ='" + CB_cxpag.SelectedItem.ToString() + "'", con);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        TB_saldocompra.Text=dr["SALDO"].ToString();
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR de conexión: " + ex);
                }
                con.Close();
            }

           
        }

        private void CB_banco_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_cuenta.Items.Clear();
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand("SELECT cuenta FROM rd_cuentas_bancarias WHERE banco ='"+CB_banco.SelectedItem.ToString()+"' and fk_proveedor='"+TB_proveedor.Text+"'",con);
            MySqlDataReader dr = cmd.ExecuteReader();
            CB_cuenta.Items.Add("");
            CB_cuenta.SelectedIndex = 0;
            while (dr.Read())
            {
                CB_cuenta.Items.Add(dr["cuenta"].ToString());
            }

            dr.Close();

            MySqlCommand cmd2 = new MySqlCommand("SELECT persona FROM rd_persona_parapagar WHERE fkproveedor='"+TB_proveedor.Text+"' and banco='"+CB_banco.SelectedItem.ToString()+"'",con);
            MySqlDataReader dr2 = cmd2.ExecuteReader();
            CB_persona.Items.Add("");
            CB_persona.SelectedIndex = 0;
            while (dr2.Read())
            {
                CB_persona.Items.Add(dr2["persona"].ToString());
            }
            dr2.Close();
            con.Close();
        }
        //################################################################################################

        //TRAE EL SALDO DEL PROVEEDOR
        public void SaldoProveedor()
        {
            MySqlConnection con = ElegirSucursal();

           // "SELECT cuenxpag.proveedor,proveed.nombre,SUM( cuenxpag.saldo * cuenxpag.tip_cam ) AS SALDO FROM cuenxpag INNER JOIN proveed USING(proveedor)" +
             //   " WHERE cuenxpag.saldo <> 0 GROUP BY cuenxpag.proveedor ORDER BY cuenxpag.proveedor, cuenxpag.moneda,cuenxpag.tipo_doc,cuenxpag.no_referen "

            MySqlCommand cmd = new MySqlCommand("SELECT SUM( cuenxpag.saldo * cuenxpag.tip_cam ) AS SALDO FROM cuenxpag cp INNER JOIN proveed p USING(p.proveedor) WHERE cp.PROVEEDOR='"+TB_proveedor.Text+"'", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                saldo = Convert.ToDouble(dr["SALDO"].ToString());
                
            }
            dr.Close();
            con.Close();
        }

        //EJECUTA LOS METODOS DE EFECTIVO
        public void button1_Click(object sender, EventArgs e)
        {
            TB_efevallarta.Text = "";
            TB_eferena.Text = "";
            TB_efecoloso.Text = "";
            TB_efevelazquez.Text = "";
            TB_efepregot.Text = "";
            try
            {
                EfectivoVA();
            }
            catch (Exception ex)
            {

                LB_va.ForeColor = Color.Red;
            }


            try
            {
                EfectivoRE();
            }
            catch (Exception ex)
            {

                LB_re.ForeColor = Color.Red;
            }

            try
            {
                EfectivoCO();
            }
            catch (Exception ex)
            {

                LB_co.ForeColor = Color.Red;
            }

            try
            {
              EfectivoVE();
               
            }
            catch (Exception ex)
            {

                LB_ve.ForeColor = Color.Red;
            }


            try
            {

                EfectivoPRE();
             

            }
            catch (Exception ex)
            {
                LB_pre.ForeColor = Color.Red;
            }

            if (cont>0)
            {
                MessageBox.Show("EL EFECTIVO AUN NO ESTÁ DISPONIBLE EN: "+mensaje);
            }

        }


        //############### LOS METODOS DE EFECTIVO TRAEN EL EFECTIVO DISPONIBLE EN LAS TIENDAS ###################################################
        public void EfectivoVA()
        {
            LB_va.ForeColor = Color.Black;
            double retiroVA = 0;
            DateTime fecha = DT_fecha.Value;
            string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
            "where  fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

            MySqlConnection con = BDConexicon.VallartaOpen();


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LB_va.ForeColor = Color.DarkGreen;
                    string concepto = dr["concepto2"].ToString();
                    if (concepto.Equals("RPPP"))
                    {
                        retiroVA = Convert.ToDouble(dr["Importe"].ToString());
                    }

                    if (concepto.Equals("Retir"))
                    {
                        efeVA = Convert.ToDouble(dr["Importe"].ToString());
                    }

                    
                }
                //else
                //{
                //    cont++;
                //    mensaje += " VALLARTA ";
                //}
                dr.Close();
            }
            catch (Exception ex)
            {

                LB_va.ForeColor = Color.Red;
            }

            double disponible = efeVA - retiroVA;
            TB_efevallarta.Text = String.Format("{0:0.##}", disponible.ToString("C"));


            con.Close();
        }

        public void EfectivoRE()
        {
            LB_re.ForeColor = Color.Black;
            DateTime fecha = DT_fecha.Value;
            double retiroRE = 0;
            string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
            "where fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

            MySqlConnection con = BDConexicon.RenaOpen();


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    LB_re.ForeColor = Color.DarkGreen;

                    string concepto = dr["concepto2"].ToString();
                    if (concepto.Equals("RPPP"))
                    {
                        retiroRE = Convert.ToDouble(dr["Importe"].ToString());
                    }

                    if (concepto.Equals("Retir"))
                    {
                        efeRE = Convert.ToDouble(dr["Importe"].ToString());
                    }
                   
                }
                //else
                //{
                //    cont++;
                //    mensaje += " RENA ";
                //}
                dr.Close();
            }
            catch (Exception ex)
            {

                LB_re.ForeColor = Color.Red;
            }

            double disponible = efeRE - retiroRE;
            TB_eferena.Text = String.Format("{0:0.##}", disponible.ToString("C"));

            con.Close();
        }

        public void EfectivoCO()
        {
            LB_co.ForeColor = Color.Black;
            double retiroCO = 0;
            DateTime fecha = DT_fecha.Value;
            string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
            "where fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

            MySqlConnection con = BDConexicon.ColosoOpen();


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LB_co.ForeColor = Color.DarkGreen;
                    string concepto = dr["concepto2"].ToString();
                    if (concepto.Equals("RPPP"))
                    {
                        retiroCO = Convert.ToDouble(dr["Importe"].ToString());
                    }

                    if (concepto.Equals("Retir"))
                    {
                        efeCO = Convert.ToDouble(dr["Importe"].ToString());
                    }

                   
                }
                //else
                //{
                //    cont++;
                //    mensaje += " COLOSO ";
                //}
                dr.Close();
            }
            catch (Exception ex)
            {

                LB_co.ForeColor = Color.Red;
            }
            double disponible = efeCO - retiroCO;
            TB_efecoloso.Text = String.Format("{0:0.##}", disponible.ToString("C"));

            con.Close();
        }

        public void EfectivoVE()
        {
            LB_ve.ForeColor = Color.Black;
            double retiroVE = 0;
            DateTime fecha = DT_fecha.Value;
            string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
            "where fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

            MySqlConnection con = BDConexicon.VelazquezOpen();


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LB_ve.ForeColor = Color.DarkGreen;

                    string concepto = dr["concepto2"].ToString();
                    if (concepto.Equals("RPPP"))
                    {
                        retiroVE = Convert.ToDouble(dr["Importe"].ToString());
                    }

                    if (concepto.Equals("Retir"))
                    {
                        efeVE = Convert.ToDouble(dr["Importe"].ToString());
                    }
                   
                }
                //else
                //{
                //    cont++;
                //    mensaje += " VELAZQUEZ ";
                //}
                dr.Close();
            }
            catch (Exception ex)
            {

                LB_ve.ForeColor = Color.Red;
            }

            double disponible = efeVE - retiroVE;
            TB_efevelazquez.Text = String.Format("{0:0.##}", disponible.ToString("C"));

            con.Close();
        }

        public void EfectivoPRE()
        {
            LB_pre.ForeColor = Color.Black;
            double retiroPRE = 0;
            DateTime fecha = DT_fecha.Value;
            string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
            "where fecha ='" +fecha.ToString("yyyy/MM/dd")  + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";


            MySqlConnection con = null;

            try
            {
                con = BDConexicon.Papeleria1Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LB_pre.ForeColor = Color.DarkGreen;

                    string concepto = dr["concepto2"].ToString();
                    if (concepto.Equals("RPPP"))
                    {
                        retiroPRE = Convert.ToDouble(dr["Importe"].ToString());
                    }

                    if (concepto.Equals("Retir"))
                    {
                        efePRE = Convert.ToDouble(dr["Importe"].ToString());
                    }
                    
                }
                //else
                //{
                //    cont++;
                //    mensaje += " PREGOT ";
                //}
                dr.Close();
            }
            catch (Exception ex)
            {

                LB_pre.ForeColor = Color.Red;
            }
            double disponible = efePRE - retiroPRE;
            TB_efepregot.Text = String.Format("{0:0.##}", disponible.ToString("C"));
          
            con.Close();

        }
        //######################################################################################################################################

        private void Porpagar_Load(object sender, EventArgs e)
        {
            TB_nombre.Text = nombre;
            TB_proveedor.Text = proveedor;
            TB_saldo_proveedor.Text = String.Format("{0:0.##}", saldo.ToString("C"));
            Bancos();
        }
    }
}
