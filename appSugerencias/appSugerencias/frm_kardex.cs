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
    public partial class frm_kardex : Form
    {
        string Articulo;
        int Flag,flag2;
       
        public frm_kardex()
        {
            InitializeComponent();
        }

        public frm_kardex(string art, int flag)
        {
            InitializeComponent();
            Articulo = art;
            Flag = flag;

        }

        public void selectDatos()
        {



            MySqlConnection con = BDConexicon.conectar();
            DateTime Finicio = dtInicio.Value;
            DateTime Ffin = dtFin.Value;

            string inicio = getDate(Finicio);
            string fin = getDate(Ffin);
            string comando;

            if (Flag == 1)
            {
                comando = "SELECT Usuario,TIPO_MOVIM,NO_REFEREN,F_MOVIM,ENT_SAL, CANTIDAD, EXISTENCIA from movsinv WHERE articulo='" + Articulo + "' ORDER BY consec desc LIMIT 50 ";
                tbArticulo.Hide();
                label3.Hide();
                flag2 = 1;
            }
            else
            {
                if (string.IsNullOrEmpty(tbArticulo.Text))
                {
                    comando = "SELECT Usuario,TIPO_MOVIM,NO_REFEREN,F_MOVIM,ENT_SAL, CANTIDAD, EXISTENCIA from movsinv WHERE articulo='" + Articulo + "' and  F_MOVIM between '" + inicio + "'" + " and '" + fin + "' ";
                }
                else
                {
                    flag2 = 0;
                    
                    Articulo = tbArticulo.Text;
                    comando = "SELECT Usuario,TIPO_MOVIM,NO_REFEREN,F_MOVIM,ENT_SAL, CANTIDAD, EXISTENCIA from movsinv WHERE articulo='" + Articulo + "' and  F_MOVIM between '" + inicio + "'" + " and '" + fin + "' ";

                }

            }

            MySqlCommand cmd = new MySqlCommand(comando, con);

            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();

            
            adaptador.Fill(dt);

            dgvArticulos.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dgvArticulos.Rows.Add();

                dgvArticulos.Rows[n].Cells[0].Value = item["Usuario"].ToString();
                dgvArticulos.Rows[n].Cells[1].Value = item["TIPO_MOVIM"].ToString();
                dgvArticulos.Rows[n].Cells[2].Value = item["NO_REFEREN"].ToString();
                dgvArticulos.Rows[n].Cells[3].Value = item["F_MOVIM"].ToString();
                dgvArticulos.Rows[n].Cells[4].Value = item["ENT_SAL"].ToString();
                if (item["ENT_SAL"].ToString() == "S")
                {
                    dgvArticulos.Rows[n].Cells[5].Value = "-" + item["CANTIDAD"].ToString();
                }
                else
                {
                    dgvArticulos.Rows[n].Cells[5].Value = item["CANTIDAD"].ToString();
                }

                dgvArticulos.Rows[n].Cells[6].Value = item["EXISTENCIA"].ToString();

            }







            con.Close();
        }
        //########## CIERRE ############
        internal static String getDate(DateTime now)
        {
            String datePatt = @"yyyy-MM-dd";
            String snow = now.ToString(datePatt);
            return snow;
        }

        private void frm_kardex_Load(object sender, EventArgs e)
        {

            selectDatos();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            selectDatos();
        }

        private void dgvArticulos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            //    if (this.dgvTraspasos.Columns[e.ColumnIndex].Name == "status")
            //    {
            //        if (Convert.ToString(e.Value) == "APLICADO")
            //        {
            //            e.CellStyle.BackColor = Color.LimeGreen;
            //        }
            //        if (Convert.ToString(e.Value) == "CANCELADO")
            //        {
            //            e.CellStyle.BackColor = Color.LightCoral;
            //        }


            //    }
            if (flag2 == 1)
            {
                if (e.RowIndex == 0)
                {
                    e.CellStyle.BackColor = Color.LimeGreen;

                }
            }
            else
            {
                if (e.RowIndex == dgvArticulos.Rows.Count-1)
                {
                    e.CellStyle.BackColor = Color.LimeGreen;

                }
            }
                
            
        }
    }
}
