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
    public partial class VentasTarjeta : Form
    {
        public VentasTarjeta()
        {
            InitializeComponent();
        }

        public void SaldoCuentaBancaria()
        {

            double sumar = 0, restar = 0;
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand("SELECT mov,ie,cantidad FROM rd_historial_saldobancos WHERE cuenta='" + CB_cuenta.SelectedItem.ToString() + "'", con);
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
            TB_saldo.Text = String.Format("{0:0.##}", saldo.ToString("C"));
            dr.Close();
            con.Close();
        }

        //AGREGAR AL COMBOBOX BANCOS, LOS BANCOS DE ESA TIENDA
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DG_tarjetas.Rows.Clear();
            LB_mensaje.Text = "";
            CB_banco.Items.Clear();
            CB_banco.Items.Add("");
            CB_banco.SelectedIndex = 0;
            CB_cuenta.Items.Clear();
            CB_cuenta.Items.Add("");
            CB_cuenta.SelectedIndex = 0;
            TB_saldo.Text = "";
           

            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT banco FROM rd_bancos_osmart WHERE tienda='" + CB_sucursal.SelectedItem.ToString()+"'",con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                CB_banco.Items.Add(dr["banco"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void CB_banco_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_cuenta.Items.Clear();
            CB_cuenta.Items.Add("");
            CB_cuenta.SelectedIndex = 0;
            TB_saldo.Text = "";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand("SELECT cuenta FROM rd_bancos_osmart where banco='" + CB_banco.SelectedItem.ToString() + "' and tienda='"+CB_sucursal.SelectedItem.ToString()+"'", con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                CB_cuenta.Items.Add(dr["cuenta"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void CB_cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaldoCuentaBancaria();
        }

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


        public void LlenarGrid()
        {
            DG_tarjetas.Rows.Clear();

            DateTime fecha = DT_fecha.Value;
            int mes = DT_fecha.Value.Month;
            int año = DT_fecha.Value.Year;
            MySqlConnection con = null;

            try
            {
                if (CHK_mespasado.Checked == true)
            {
                string mesRespaldo = MesRespaldo(mes);

                if (CB_sucursal.SelectedItem.ToString().Equals("VALLARTA"))
                {
                   
                   con = BDConexicon.RespaldoVA(mesRespaldo, año);
                   
                
                }
                if (CB_sucursal.SelectedItem.ToString().Equals("RENA"))
                {
                    con = BDConexicon.RespaldoRE(mesRespaldo, año);
                }
                if (CB_sucursal.SelectedItem.ToString().Equals("VELAZQUEZ"))
                {
                    con = BDConexicon.RespaldoVE(mesRespaldo, año);
                }
                if (CB_sucursal.SelectedItem.ToString().Equals("COLOSO"))
                {
                    con = BDConexicon.RespaldoCO(mesRespaldo, año);
                }
                if (CB_sucursal.SelectedItem.ToString().Equals("PREGOT"))
                {
                   con = BDConexicon.RespaldoPRE(mesRespaldo, año);
                }
                }
                else
                {
                    if (CB_sucursal.SelectedItem.ToString().Equals("VALLARTA"))
                    {
                        con = BDConexicon.VallartaOpen();
                    }
                    if (CB_sucursal.SelectedItem.ToString().Equals("RENA"))
                    {
                        con = BDConexicon.RenaOpen();
                    }
                    if (CB_sucursal.SelectedItem.ToString().Equals("VELAZQUEZ"))
                    {
                        con = BDConexicon.VelazquezOpen();
                    }
                    if (CB_sucursal.SelectedItem.ToString().Equals("COLOSO"))
                    {
                        con = BDConexicon.ColosoOpen();
                    }
                    if (CB_sucursal.SelectedItem.ToString().Equals("PREGOT"))
                    {
                        con = BDConexicon.Papeleria1Open();
                    }
                }

                int estado = 0;
                MySqlCommand cmd = new MySqlCommand("SELECT operacion,importe,estacion,usuario,fecha,hora,estado FROM rd_historial_tarj WHERE fecha='" + fecha.ToString("yyyy-MM-dd") + "'", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    estado = Convert.ToInt32(dr["estado"].ToString());
                    double importe = Convert.ToDouble(dr["importe"].ToString());
                    DG_tarjetas.Rows.Add(dr["operacion"].ToString(), importe, dr["estacion"].ToString(), dr["usuario"].ToString(), dr["fecha"].ToString(), dr["hora"].ToString());
                }
                dr.Close();
                con.Close();

                LB_status.Text = "Conectado";
                LB_status.ForeColor = Color.DarkGreen;

                double sum = 0;

                for (int i = 0; i < DG_tarjetas.Rows.Count; i++)
                {

                    sum += sum = Convert.ToDouble(DG_tarjetas.Rows[i].Cells[1].Value);

                }

                DG_tarjetas.Rows.Add("TOTAL", sum, "", "", "", "");
                //String.Format("{0:0.##}", sum.ToString("C")
                DG_tarjetas.Columns[1].DefaultCellStyle.Format = "C2";


                if (estado==1)
                {
                    LB_mensaje.Text = "El monto de esta fecha ya se pasó a la cuenta de banco";
                    
                }
            }
            catch (Exception ex)
            {

                LB_status.Text = "Sin conexión";
                LB_status.ForeColor = Color.Red;
                MessageBox.Show("Error al traer los datos: "+ex);
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (CB_sucursal.SelectedIndex==-1)
            {
                MessageBox.Show("Elige una sucursal");
            }
            else
            {
                LlenarGrid();
            }
           
        }






        private void BT_aceptar_Click(object sender, EventArgs e)
        {
            if (CB_banco.SelectedIndex==0||CB_cuenta.SelectedIndex==0)
            {
                MessageBox.Show("Debes seleccionar el banco y la cuenta a la que se va a transferir el dinero");
            }
            else
            {

                if (LB_mensaje.Text.Equals(""))
                {
                    int ultima = DG_tarjetas.Rows.Count;
                    string total = Convert.ToString(DG_tarjetas.Rows[ultima - 1].Cells[1].Value);
                    double totalTarj = Convert.ToDouble(total);

                    decimal digito = decimal.Parse(TB_saldo.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    string saldo = digito.ToString("G0");



                    double saldoCuenta = Convert.ToDouble(saldo);

                    double nuevoSaldo = totalTarj + saldoCuenta;
                    TB_saldo.Text = String.Format("{0:0.##}", nuevoSaldo.ToString("C"));


                    DateTime fecha = DateTime.Now;


                    try
                    {

                        MySqlConnection con = BDConexicon.BodegaOpen();
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO rd_historial_saldobancos(tienda,mov,banco,cuenta,pagara,cantidad,fecha,hora)VALUES(?tienda,?mov,?banco,?cuenta,?pagara,?cantidad,?fecha,?hora)", con);
                        cmd.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?mov", "TARJ");
                        cmd.Parameters.AddWithValue("?banco", CB_banco.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?pagara", "CUENTA OSMART");
                        cmd.Parameters.AddWithValue("?cantidad", totalTarj);
                        cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("?hora", fecha.ToString("HH:mm:ss"));
                        cmd.ExecuteNonQuery();

                        con.Close();


                        MySqlConnection conectar = null;

                        if (CHK_mespasado.Checked==true)
                        {
                            int mes = DT_fecha.Value.Month;
                            int año = DT_fecha.Value.Year;
                            string mesRespaldo = MesRespaldo(mes);
                            if (CB_sucursal.SelectedItem.ToString().Equals("VALLARTA"))
                            {
                                conectar = BDConexicon.RespaldoVA(mesRespaldo,año);
                            }

                            if (CB_sucursal.SelectedItem.ToString().Equals("RENA"))
                            {
                                conectar = BDConexicon.RespaldoRE(mesRespaldo,año);
                            }

                            if (CB_sucursal.SelectedItem.ToString().Equals("VELAZQUEZ"))
                            {
                                conectar = BDConexicon.RespaldoVE(mesRespaldo,año);
                            }

                            if (CB_sucursal.SelectedItem.ToString().Equals("COLOSO"))
                            {
                                conectar = BDConexicon.RespaldoCO(mesRespaldo,año);
                            }

                            if (CB_sucursal.SelectedItem.ToString().Equals("PREGOT"))
                            {
                                conectar = BDConexicon.RespaldoPRE(mesRespaldo,año);
                            }
                        }
                        else
                        {
                            if (CB_sucursal.SelectedItem.ToString().Equals("VALLARTA"))
                            {
                                conectar = BDConexicon.VallartaOpen();
                            }

                            if (CB_sucursal.SelectedItem.ToString().Equals("RENA"))
                            {
                                conectar = BDConexicon.RenaOpen();
                            }

                            if (CB_sucursal.SelectedItem.ToString().Equals("VELAZQUEZ"))
                            {
                                conectar = BDConexicon.VelazquezOpen();
                            }

                            if (CB_sucursal.SelectedItem.ToString().Equals("COLOSO"))
                            {
                                conectar = BDConexicon.ColosoOpen();
                            }

                            if (CB_sucursal.SelectedItem.ToString().Equals("PREGOT"))
                            {
                                conectar = BDConexicon.Papeleria1Open();
                            }
                        }

                        DateTime fechaDT = DT_fecha.Value;
                        MySqlCommand actualizarEstado = new MySqlCommand("UPDATE rd_historial_tarj SET estado = " + 1 + " WHERE fecha='" + fechaDT.ToString("yyyy-MM-dd") + "'", conectar);
                        actualizarEstado.ExecuteNonQuery();

                        conectar.Close();
                        MessageBox.Show("Transferencia realizada con exito");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Ocurrió el siguiente error al intentar realizar la transferencia: " + ex);
                    }

                }
                else
                {
                    MessageBox.Show("No puedes realizar esta transferencia, porque ya se realizó anteriormente");
                }
               
            }


        }
    }
}
