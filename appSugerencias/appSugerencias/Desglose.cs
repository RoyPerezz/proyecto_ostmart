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
    public partial class Desglose : Form
    {
        public Desglose()
        {
            InitializeComponent();
        }

        string cuenxpag;
        string id, des;
      double importe,saldo=0;
        double abonos = 0;


        //############################## GUARDA EL ID DE LA CUENTA XPAGAR ####################################################
        public void CuentXPagar(string valor)
        {
            cuenxpag = valor;
        }

        //################################### GUARDA DATOS DE LA CUENTA X PAGAR Y LOS MANDA AL FORM DE DESGLOSE PARA PASARSELOS A LOS TEXTBOXS ########

        //public void datoCuenta(string id,string importe, string saldo)
        //{
        //    this.id = id;
        //    //this.des= des;
        //    this.importe = importe;
        //    this.saldo = saldo;
        //}
        private void Desglose_Load(object sender, EventArgs e)
        {
        //    TB_id.Text = id;
        //    //TB_descrip.Text = des;
        //    TB_importe.Text = string.Format("{0:C2}", importe);
        //    TB_saldo.Text = string.Format("{0:C2}", saldo); ;





            MySqlCommand cmd = new MySqlCommand("SELECT fecha, tipo_doc,cargo_ab,no_referen, importe from cuenxpdet where cuenxpag='" + cuenxpag + "'", BDConexicon.conectar());
            //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //DataTable dt = new DataTable();

            //da.Fill(dt);
            //DG_datos2.DataSource = dt;

            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {


                if (dr["cargo_ab"].ToString().Equals("C"))
                {
                    saldo += Convert.ToDouble(dr["importe"].ToString());
                }
                else
                {
                    saldo -= Convert.ToDouble(dr["importe"].ToString());
                }
                DG_datos2.Rows.Add(dr["fecha"].ToString(),dr["tipo_doc"].ToString(),dr["cargo_ab"].ToString(),dr["no_referen"].ToString(),dr["importe"].ToString(),saldo);
            }
            dr.Close();

            DG_datos2.Columns[0].Width = 130;
            DG_datos2.Columns[1].Width = 130;
            DG_datos2.Columns[3].Width = 330;
            //DG_datos2.Columns[4].Width = 200;

            //foreach (DataGridViewRow row in DG_datos2.Rows)
            //{
            //    abonos += Convert.ToDouble(row.Cells["importe"].Value);

            //}

            //TB_abono.Text = string.Format( "{0:C2}",abonos);
            BDConexicon.ConectarClose();
        }
    }
}
