using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            DG_reporte.Columns["PAGARA"].Width = 270;
            DG_reporte.Columns["BANCO"].Width = 120;
            DG_reporte.Columns["CUENTA"].Width = 170;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {     
            DG_reporte.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;

            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT nombreprov,pagarA,monto,banco,cuenta,fecha,tienda,compra from rd_rep_pagoproveedores WHERE fecha between '"+inicio.ToString("yyyy-MM-dd")+"' and '"+fin.ToString("yyyy-MM-dd")+"'", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            double monto = 0;
            
                while (dr.Read())
                {
                monto = Convert.ToDouble(dr["monto"].ToString());
                    DG_reporte.Rows.Add(dr["nombreprov"].ToString(),dr["pagarA"].ToString(),monto , dr["banco"].ToString(), dr["cuenta"].ToString(), dr["fecha"].ToString(),dr["tienda"].ToString(),dr["compra"].ToString());
                }
           
           
            dr.Close();
            con.Close();
            double suma = 0;
            for (int i = 0; i < DG_reporte.RowCount; i++)
            {
                suma += Convert.ToDouble(DG_reporte.Rows[i].Cells[2].Value);
            }

            DG_reporte.Rows.Add("","TOTAL",suma,"","","","","");
            DG_reporte.Columns[2].DefaultCellStyle.Format = "C2";
        }

        public void EfectivoDisponible()
        {
            DateTime fecha = DT_fecha.Value;
            string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
            "where  fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

            MySqlConnection con = BDConexicon.conectar();
            double retiro = 0, efectivo = 0;

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                   
                    string concepto = dr["concepto2"].ToString();
                    if (concepto.Equals("RPPP"))
                    {
                        retiro = Convert.ToDouble(dr["Importe"].ToString());
                    }

                    if (concepto.Equals("Retir"))
                    {
                        efectivo = Convert.ToDouble(dr["Importe"].ToString());
                    }


                }
                
                dr.Close();
            }
            catch (Exception ex)
            {

               
            }

            double disponible = efectivo - retiro;
            TB_disponible.Text = String.Format("{0:0.##}", disponible.ToString("C"));


            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EfectivoDisponible();
        }

        public void Exportar()
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            excel.Cells.Range["C6:C100"].NumberFormat = "$#,##0.00";


            int indiceColumna = 0;

            foreach (DataGridViewColumn col in DG_reporte.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in DG_reporte.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in DG_reporte.Columns)
                {
                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                }



            }




            excel.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Exportar();
        }
    }
}
