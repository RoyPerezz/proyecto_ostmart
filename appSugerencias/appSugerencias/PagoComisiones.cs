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
        public PagoComisiones()
        {
            InitializeComponent();
        }

       


        public void Comisiones()
        {
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;

            DataTable dt=null;
            DataColumn columna;
            DataRow fila;

            //MySqlCommand cmd = new MySqlCommand("Select DISTINCT Fecha,DISTINCT USUARIO,Ctotal from rd_calificaciones where Fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "'", BDConexicon.conectar());

            //MySqlDataReader dr = cmd.ExecuteReader();
            //string ColNom = "";
            //DG_comisiones.Columns.Add("CAJERA", "CAJERA");
            //while (dr.Read())
            //{
            //    ColNom = dr["Fecha"].ToString();
            //    DG_comisiones.Columns.Add(ColNom, ColNom);



            //    DG_comisiones.Rows.Add(dr["usuario"].ToString(),dr["Ctotal"].ToString());
            //}

            MySqlCommand cmd = new MySqlCommand("Select DISTINCT Fecha from rd_calificaciones where Fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "'", BDConexicon.conectar());
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            





        }

        private void PagoComisiones_Load(object sender, EventArgs e)
        {
           
        }

        private void BT_comisiones_Click(object sender, EventArgs e)
        {
            Comisiones();
        }
    }
}
