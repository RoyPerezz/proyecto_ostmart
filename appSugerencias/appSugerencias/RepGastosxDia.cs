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
    public partial class RepGastosxDia : Form
    {
        public RepGastosxDia()
        {
            InitializeComponent();
        }

        private void RepGastosxDia_Load(object sender, EventArgs e)
        {
            DG_gastos.Columns["CLAVE"].Width = 70;
            DG_gastos.Columns["HORA"].Width = 80;
            DG_gastos.Columns["IE"].Width = 30;
            DG_gastos.Columns["DESCRIPCION"].Width = 400;
        }

        public void Reporte()
        {
            MySqlConnection con = BDConexicon.conectar();
            DateTime fecha = DT_fecha.Value;
            double efectivo = 0;
            double retiro = 0;
            double disponible = 0;
            double monto = 0;
         
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM" +
                    " flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto where fecha = '"+fecha.ToString("yyyy-MM-dd")+"' AND flujo.concepto<>'CAM' AND flujo.ing_eg = 'E' and flujo.concepto<>'cortz' GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    monto = Convert.ToDouble(dr["Importe"].ToString());

                    if (dr["concepto2"].ToString().Equals("Retir"))
                    {
                        efectivo = Convert.ToDouble(dr["Importe"].ToString());
                    }


                    if (dr["concepto2"].ToString().Equals("RPPP"))
                    {
                        retiro = Convert.ToDouble(dr["Importe"].ToString());
                    }

                    DG_gastos.Rows.Add(dr["concepto2"].ToString(), dr["descrip"].ToString(),monto, dr["IE"].ToString(), dr["fecha"].ToString(), dr["hora"].ToString(), dr["usuario"].ToString(),dr["estacion"].ToString());
                  
                }


                disponible = efectivo - retiro;
                double suma = 0;
                for (int i = 0; i <DG_gastos.Rows.Count; i++)
                {
                    if (DG_gastos.Rows[i].Cells["CLAVE"].Value.Equals("Retir"))
                    {
                        DG_gastos.Rows[i].Cells["IMPORTE"].Value = disponible;
                    }
                    suma += Convert.ToDouble(DG_gastos.Rows[i].Cells["IMPORTE"].Value);
                }

                DG_gastos.Rows.Add("","GASTOS TOTALES", suma, "","","","","");
              
                dr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener datos del reporte :"+ex);
            }
            DG_gastos.Columns[2].DefaultCellStyle.Format = "C2";
            con.Close();
        }

        private void BT_aceptar_Click(object sender, EventArgs e)
        {
            Reporte();
        }
    }
}
