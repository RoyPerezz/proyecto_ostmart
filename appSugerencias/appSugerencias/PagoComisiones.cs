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
    public partial class PagoComisiones : Form

       
    {

        double extra = 0.0; //almacena la comision extra
        double total = 0.0;//al macena el total semanal
        double pagar = 0.0;//almacena la comision total a pagar a la cajera
        public PagoComisiones()
        {
            InitializeComponent();
        }



        public void getUsuarios() //obtiene los usuarios que tienen registros en la tabla rd_comisiones
        {
           
           
            MySqlCommand cmd = new MySqlCommand("select distinct usuario from rd_comisiones",BDConexicon.conectar());
            MySqlDataReader rd = cmd.ExecuteReader();

            while(rd.Read())
            {
                CB_usuario.Items.Add(rd[0].ToString());
            }
        }

        public void getComisiones()//obtiene las comisiones de un usuario durante la semana
        {

            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            MySqlCommand cmd = new MySqlCommand("select fecha, Ctotal from rd_comisiones where fecha between '"+inicio.ToString("yyyy-MM-dd")+"'"+" and '"+fin.ToString("yyyy-MM-dd")+"'"+" and usuario = '"+CB_usuario.SelectedItem+"'",BDConexicon.conectar());
            DataTable dt = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ad.Fill(dt);
            DGV_comisiones.DataSource = dt;
        }


        public void getComisionExtra()//obtiene la comision extra del usuario
        {
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            MySqlCommand cmd = new MySqlCommand("select sum(cantidad) from rd_formatocajeras where fecha between '"+inicio.ToString("yyyy-MM-dd")+"'"+" and '"+fin.ToString("yyyy-MM-dd")+"'"+" and usuario = '"+CB_usuario.SelectedItem+"'"+" and validado = '"+1+"'" ,BDConexicon.conectar());
            MySqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                TB_extra.Text = dr[0].ToString();
                extra = Convert.ToInt32(TB_extra.Text);
            }
        }

        public void PagarComision()
        {
            string t = "";
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            MySqlCommand cmd = new MySqlCommand("select sum(Ctotal) from rd_comisiones where fecha between '" + inicio.ToString("yyyy-MM-dd") + "'" + " and '" + fin.ToString("yyyy-MM-dd") + "'" + " and usuario ='" + CB_usuario.SelectedItem + "'", BDConexicon.conectar());
            MySqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                t = rd[0].ToString();
            }

            total = Convert.ToDouble(t);
            TB_semana.Text = Convert.ToString(total);
            TB_ctotal.Text = Convert.ToString(extra + total);
            pagar = extra + total;

           

        }

        public void limpiar()
        {
            CB_usuario.SelectedIndex = -1;
            TB_semana.Text = "";
            TB_extra.Text = "";
            TB_ctotal.Text = "";
            DGV_comisiones.Refresh();
        }

        public void Guardar()
        {
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            MySqlCommand cmd = new MySqlCommand("insert into rd_pagocomisiones(usuario,fecha_ini,fecha_fin,total_semana,extra,pagar_total) values(?usuario,?fecha_ini,?fecha_fin,?total_semana,?extra,?pagar_total)",BDConexicon.conectar());

            cmd.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = CB_usuario.SelectedItem;
            cmd.Parameters.Add("?fecha_ini", MySqlDbType.Date).Value = inicio.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("?fecha_fin", MySqlDbType.Date).Value = fin.ToString("yyyy-MM-dd");
            cmd.Parameters.Add("?total_semana", MySqlDbType.Double).Value = total;
            cmd.Parameters.Add("?extra", MySqlDbType.Int32).Value = extra;
            cmd.Parameters.Add("?pagar_total", MySqlDbType.Double).Value = pagar;

            cmd.ExecuteNonQuery();
            limpiar();
            MessageBox.Show("Registros guardados exitosamente");



        }

        private void PagoComisiones_Load(object sender, EventArgs e)
        {
            getUsuarios();
        }

        private void BTN_aceptar_Click(object sender, EventArgs e)
        {
            getComisiones();
            getComisionExtra();
            PagarComision();
        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
