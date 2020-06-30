﻿using MySql.Data.MySqlClient;
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
    public partial class Rep_CajaGral : Form
    {
        public Rep_CajaGral()
        {
            InitializeComponent();
        }

        private void Rep_CajaGral_Load(object sender, EventArgs e)
        {
            DG_reporte.Columns[0].Width = 80;
            DG_reporte.Columns[1].Width = 40;
            DG_reporte.Columns[2].Width = 200;


        }


        public void Saldo()
        {

            double ingreso = 0;
            double egreso = 0;
            for (int i = 0; i < DG_reporte.Rows.Count; i++)
            {
                string ie = Convert.ToString(DG_reporte.Rows[i].Cells[1].Value);


                decimal digito = decimal.Parse(DG_reporte.Rows[i].Cells[3].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string texto = digito.ToString("G0");
                double cantidad= Convert.ToDouble(texto);






              

                if (ie.Equals("I"))
                {
                    ingreso += cantidad;
                }

                if (ie.Equals("E"))
                {
                    egreso += cantidad;
                }
            }

            double saldo = ingreso - egreso;

            DG_reporte.Rows.Add("","","SALDO", String.Format("{0:0.##}", saldo.ToString("C")),"","");

            saldo = 0; ingreso = 0; egreso=0;
        }


        private void BT_aceptar_Click(object sender, EventArgs e)
        {
            DG_reporte.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM rd_historial_saldobancos WHERE BANCO = 'CAJA GENERAL' AND(fecha BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' and '"+fin.ToString("yyyy-MM-dd")+"')",con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

               double cantidad = Convert.ToDouble(dr["cantidad"].ToString());
                DateTime fecha = Convert.ToDateTime(dr["fecha"].ToString());
                DG_reporte.Rows.Add(dr["mov"].ToString(), dr["ie"].ToString(), dr["pagara"].ToString(), String.Format("{0:0.##}", cantidad.ToString("C")), fecha.ToString("dd-MM-yyyy"),dr["hora"].ToString());
            }
           
            dr.Close();
            con.Close();
            Saldo();


        }
    }
}