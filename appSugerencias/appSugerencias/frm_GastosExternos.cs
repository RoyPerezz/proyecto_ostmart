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
    public partial class frm_GastosExternos : Form
    {
        public frm_GastosExternos()
        {
            InitializeComponent();
        }
        string usuario;

        public frm_GastosExternos(string Usuario)
        {
            InitializeComponent();
            usuario = Usuario;
        }
        
        MySqlConnection con;
        private void frm_GastosExternos_Load(object sender, EventArgs e)
        {
            llenaComboBox();
          
        }
        
        public void llenaComboBox()
        {
            MySqlConnection conn;
            conn = BDConexicon.BodegaOpen();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM rd_gastos_externos", conn);
            MySqlDataAdapter mysqladap = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            mysqladap.Fill(dt);

            cbGastos.ValueMember = "id_gasto";
            cbGastos.DisplayMember = "nombre_gasto";
            cbGastos.DataSource = dt;
            conn.Close();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DateTime fecha = dtGastos.Value;
            //MessageBox.Show(fecha.ToString("yyyy-MM-dd"));
            if (cbTienda.Text == "BODEGA")
            {
                try
                {
                    con = BDConexicon.BodegaOpen();
                    guardaDatos();
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            else if (cbTienda.Text == "VALLARTA")
            {
                try
                {
                    con = BDConexicon.VallartaOpen();
                    guardaDatos();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            else if (cbTienda.Text == "RENA")
            {
                try
                { 
                con = BDConexicon.RenaOpen();
                guardaDatos();
                con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            else if (cbTienda.Text == "COLOSO")
            {
                try
                {
                con = BDConexicon.ColosoOpen();
                guardaDatos();
                con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            else if (cbTienda.Text == "VELAZQUEZ")
            {
                try
                { 
                con = BDConexicon.VelazquezOpen();
                guardaDatos();
                con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            else if (cbTienda.Text == "PREGOT")
            {
                try
                { 
                con = BDConexicon.Papeleria1Open();
                guardaDatos();
                con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
           
        }

        public void limpiar()
        {

        }

        public void guardaDatos()
        {
            string comando;
            long idInsertado;
            DateTime fecha = dtGastos.Value;
            DateTime fecha_creacion = DateTime.Now;
            //MessageBox.Show(fecha.ToString("yyyy-MM-dd"));
            try
            {

                comando = "INSERT INTO rd_gastos_externos_pagos (fecha,hora,importe,id_gasto_externo,nombre_gasto,usuario,fecha_creacion,observacion) values (?fecha,?hora,?importe,?id,?gasto,?usuario,?fecha_creacion,?observ)";
               
                

                MySqlCommand cmd = new MySqlCommand(comando, con);
                cmd.Parameters.Add("?fecha", MySqlDbType.VarChar).Value = fecha.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("?hora", MySqlDbType.VarChar).Value = "";
                cmd.Parameters.Add("?importe", MySqlDbType.VarChar).Value = tbImporte.Text;
                cmd.Parameters.Add("?id", MySqlDbType.VarChar).Value = cbGastos.SelectedValue.ToString();
                cmd.Parameters.Add("?gasto", MySqlDbType.VarChar).Value = cbGastos.Text;
                cmd.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = usuario;
                cmd.Parameters.Add("?fecha_creacion", MySqlDbType.VarChar).Value = fecha_creacion.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("?observ", MySqlDbType.VarChar).Value = tbObservaciones.Text;



                cmd.ExecuteNonQuery();
                idInsertado = cmd.LastInsertedId;

                guardaDatosSaldoBancos(idInsertado);

                tbImporte.Text = "";
                tbObservaciones.Text = "";
                cbGastos.Text = "";
                CB_bancosOsmart.Text = "";
                CB_cuentasOsmart.Text = "";
                CB_pagara.Text = "";
                TB_saldobanco.Text = "";

                MessageBox.Show("Datos gregados con exito: " + idInsertado);
                
            }
            catch(Exception EX)
            {
                MessageBox.Show("Error" + EX.Message);
            }


           
        }

        public void guardaDatosSaldoBancos(long consecutivo)
        {

            DateTime fecha = dtGastos.Value;
            DateTime fecha_creacion = DateTime.Now;
           

            MySqlConnection conx;
            conx = BDConexicon.BodegaOpen();
            string comando;

            comando = "INSERT INTO rd_historial_saldobancos (tienda,mov,banco,cuenta,pagara,cantidad,fecha,hora,fk_gastoexterno,ie) values (?tienda,?mov,?banco,?cuenta,?pagara,?cantidad,?fecha,?hora,?fk_gastoexterno,?ie)";



            MySqlCommand cmd = new MySqlCommand(comando, conx);
            cmd.Parameters.Add("?tienda", MySqlDbType.VarChar).Value = cbTienda.Text;
            cmd.Parameters.Add("?mov", MySqlDbType.VarChar).Value = "GE";
            cmd.Parameters.Add("?banco", MySqlDbType.VarChar).Value = CB_bancosOsmart.Text;
            cmd.Parameters.Add("?cuenta", MySqlDbType.VarChar).Value = CB_cuentasOsmart.Text;
            cmd.Parameters.Add("?pagara", MySqlDbType.VarChar).Value = cbGastos.Text;
            cmd.Parameters.Add("?cantidad", MySqlDbType.VarChar).Value = tbImporte.Text;
            cmd.Parameters.Add("?fecha", MySqlDbType.VarChar).Value = fecha_creacion.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("?hora", MySqlDbType.VarChar).Value = fecha_creacion.ToString("HH:mm");
            cmd.Parameters.Add("?fk_gastoexterno", MySqlDbType.VarChar).Value = consecutivo;
            cmd.Parameters.Add("?ie", MySqlDbType.VarChar).Value = "E";



            cmd.ExecuteNonQuery();

            conx.Close();
        }

        public void SaldoCuentaBancaria()
        {

            double sumar = 0, restar = 0;
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand("SELECT mov,cantidad FROM rd_historial_saldobancos WHERE cuenta='" + CB_cuentasOsmart.SelectedItem.ToString() + "'", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                if (dr["mov"].ToString().Equals("RBAN"))
                {
                    sumar += Convert.ToDouble(dr["cantidad"].ToString());
                }

                if (dr["mov"].ToString().Equals("SPEI"))
                {
                    restar += Convert.ToDouble(dr["cantidad"].ToString());
                }


            }


            double saldo = sumar - restar;
            TB_saldobanco.Text = String.Format("{0:0.##}", saldo.ToString("C"));
            dr.Close();
            con.Close();
        }

        private void cbTienda_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_bancosOsmart.Items.Clear();
            CB_bancosOsmart.Items.Add("");
            CB_bancosOsmart.SelectedIndex = 0;

            CB_cuentasOsmart.Items.Clear();
            CB_cuentasOsmart.Items.Add("");
            CB_cuentasOsmart.SelectedIndex = 0;

           
            CB_pagara.Items.Clear();
            CB_pagara.Items.Add("");
            CB_pagara.SelectedIndex = 0;


            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand("SELECT distinct banco FROM rd_bancos_osmart WHERE tienda='" + cbTienda.SelectedItem.ToString() + "'", con);
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
            MySqlCommand cmd = new MySqlCommand("SELECT distinct cuenta FROM rd_bancos_osmart WHERE banco='" + CB_bancosOsmart.SelectedItem.ToString() + "' and tienda='" + cbTienda.SelectedItem.ToString() + "'", con);
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
    }
}
