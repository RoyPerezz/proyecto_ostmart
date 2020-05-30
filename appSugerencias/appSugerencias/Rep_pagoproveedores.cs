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
    public partial class Rep_pagoproveedores : Form
    {
        public Rep_pagoproveedores()
        {
            InitializeComponent();
        }

        private void Rep_pagoproveedores_Load(object sender, EventArgs e)
        {
            DG_reporte.Columns["PROVEEDOR"].Width = 270;
            DG_reporte.Columns["BANCO"].Width = 120;
            DG_reporte.Columns["CUENTA"].Width = 170;

        }

        private void button1_Click(object sender, EventArgs e)
        {     
            DG_reporte.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;

            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT nombreprov,monto,banco,cuenta,fecha from rd_rep_pagoproveedores WHERE fecha between '"+inicio.ToString("yyyy-MM-dd")+"' and '"+fin.ToString("yyyy-MM-dd")+"'", con);
            MySqlDataReader dr = cmd.ExecuteReader();

            
                while (dr.Read())
                {
                    DG_reporte.Rows.Add(dr["nombreprov"].ToString(), dr["monto"].ToString(), dr["banco"].ToString(), dr["cuenta"].ToString(), dr["fecha"].ToString());
                }
           
           
            dr.Close();
            con.Close();
        }
    }
}
