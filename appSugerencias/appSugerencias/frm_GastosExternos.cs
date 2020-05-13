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

                tbImporte.Text = "";
                tbObservaciones.Text = "";
                cbGastos.Text = "";

                MessageBox.Show("Datos gregados con exito");
                
            }
            catch(Exception EX)
            {
                MessageBox.Show("Error" + EX.Message);
            }


           
        }
    }
}
