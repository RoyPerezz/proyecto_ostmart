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
    public partial class VentasxTienda : Form
    {
        public VentasxTienda()
        {
            InitializeComponent();
        }

       // MySqlConnection conbodega;
        MySqlConnection convallarta;
        MySqlConnection conrena;
        MySqlConnection concoloso;
        MySqlConnection convelazquez;

        List<double> LisVallarta = new List<double>();
        List<double> LisRena = new List<double>();
        List<double> LisColoso = new List<double>();
        List<double> LisVelazquez = new List<double>();


        private void button1_Click(object sender, EventArgs e)
        {
            ventas();
        }

        public void ventas()
        {
            double importeDiaVa,importeDiaRe, importeDiaVe, importeDiaCo,importeDiaTo;
            double totalVa, totalRe, totalCo, totalVe, Total;

            //int dan;
            importeDiaTo = 0;
            DateTime fecha;

            string dia = DateTime.Now.ToString("dd");
            string mes = DateTime.Now.ToString("MM");
            string ano = DateTime.Now.ToString("yyyy");

            for( int i = Convert.ToInt32(dia); i <= 1; i--)
            {
                dgvVentas.Rows[i].Cells[0].Value = i.ToString() + "/" + mes + "/" + ano;
            }



            try
            {
                convallarta = BDConexicon.VallartaOpen();
                string comando = "SELECT ventas.F_EMISION AS 'Fecha', " +
                    "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) + SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100)) As 'Total' " +
                    "FROM(partvta LEFT JOIN ventas ON ventas.VENTA = partvta.VENTA) INNER JOIN prods ON partvta.ARTICULO = prods.ARTICULO " +
                    "WHERE ventas.ESTADO = 'CO' AND(ventas.TIPO_DOC = 'FAC' OR ventas.TIPO_DOC = 'DV' OR ventas.TIPO_DOC = 'REM') AND ventas.CIERRE = 0 " +
                    "GROUP BY ventas.F_EMISION " +
                    "ORDER BY ventas.F_EMISION";

                MySqlCommand cmd = new MySqlCommand(comando, convallarta);

                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();

                adaptador.Fill(dt);

                dgvVentas.Rows.Clear();
                totalVa = 0;

                foreach (DataRow item in dt.Rows)
                {
                    int n = dgvVentas.Rows.Add();
                
                    importeDiaVa = Convert.ToDouble(item["total"].ToString());
                    LisVallarta.Add(importeDiaVa);
                    totalVa = totalVa + importeDiaVa;
                    fecha = Convert.ToDateTime(item["fecha"].ToString());

                    //dgvVentas.Rows[n].Cells[0].Value = fecha.ToString("dd/MM/yyyy");
                    dgvVentas.Rows[n].Cells[1].Value = importeDiaVa.ToString("C");


                }
                convallarta.Close();
                int nn = dgvVentas.Rows.Add();
                dgvVentas.Rows[nn].Cells[0].Value = "TOTAL";
                dgvVentas.Rows[nn].Cells[1].Value = totalVa.ToString("C");
                LisVallarta.Add(totalVa);

            }
            catch (Exception)
            {
                MessageBox.Show("Vallarta sin conexion");
            }

           
            try
            {
                conrena = BDConexicon.RenaOpen();
                string comando = "SELECT ventas.F_EMISION AS 'Fecha', " +
                    "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) + SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100)) As 'Total' " +
                    "FROM(partvta LEFT JOIN ventas ON ventas.VENTA = partvta.VENTA) INNER JOIN prods ON partvta.ARTICULO = prods.ARTICULO " +
                    "WHERE ventas.ESTADO = 'CO' AND(ventas.TIPO_DOC = 'FAC' OR ventas.TIPO_DOC = 'DV' OR ventas.TIPO_DOC = 'REM') AND ventas.CIERRE = 0 " +
                    "GROUP BY ventas.F_EMISION " +
                    "ORDER BY ventas.F_EMISION";

                MySqlCommand cmdr = new MySqlCommand(comando, conrena);

                MySqlDataReader dr = cmdr.ExecuteReader();
                int y = 0;
                totalRe = 0;
                while (dr.Read())
                {
                    importeDiaRe = Convert.ToDouble(dr["total"].ToString());
                    LisRena.Add(importeDiaRe);
                    totalRe = totalRe + importeDiaRe;
                   
                    dgvVentas.Rows[y].Cells[2].Value = importeDiaRe.ToString("C");
                    y = y + 1;


                    
                }
                
                dgvVentas.Rows[y].Cells[2].Value = totalRe.ToString("C");
                LisRena.Add(totalRe);
                dr.Close();


        }
            catch (Exception)
            {
                MessageBox.Show("rena sin conexion");
            }

            try
            {
                convelazquez = BDConexicon.VelazquezOpen();
                string comando = "SELECT ventas.F_EMISION AS 'Fecha', " +
                    "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) + SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100)) As 'Total' " +
                    "FROM(partvta LEFT JOIN ventas ON ventas.VENTA = partvta.VENTA) INNER JOIN prods ON partvta.ARTICULO = prods.ARTICULO " +
                    "WHERE ventas.ESTADO = 'CO' AND(ventas.TIPO_DOC = 'FAC' OR ventas.TIPO_DOC = 'DV' OR ventas.TIPO_DOC = 'REM') AND ventas.CIERRE = 0 " +
                    "GROUP BY ventas.F_EMISION " +
                    "ORDER BY ventas.F_EMISION";

                MySqlCommand cmdr = new MySqlCommand(comando, convelazquez);

                MySqlDataReader dr = cmdr.ExecuteReader();
                int y = 0;
                totalVe = 0;
                while (dr.Read())
                {
                    importeDiaVe = Convert.ToDouble(dr["total"].ToString());
                    LisVelazquez.Add(importeDiaVe);
                    totalVe = totalVe + importeDiaVe;

                    dgvVentas.Rows[y].Cells[3].Value = importeDiaVe.ToString("C");
                    y = y + 1;



                }
                //conectar.Close();
                dr.Close();
                dgvVentas.Rows[y].Cells[3].Value = totalVe.ToString("C");
                LisVelazquez.Add(totalVe);
            }
            catch (Exception)
            {
                MessageBox.Show("Velazquez sin conexion");
            }


            try
            {
                concoloso = BDConexicon.ColosoOpen();
                string comando = "SELECT ventas.F_EMISION AS 'Fecha', " +
                    "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) + SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100)) As 'Total' " +
                    "FROM(partvta LEFT JOIN ventas ON ventas.VENTA = partvta.VENTA) INNER JOIN prods ON partvta.ARTICULO = prods.ARTICULO " +
                    "WHERE ventas.ESTADO = 'CO' AND(ventas.TIPO_DOC = 'FAC' OR ventas.TIPO_DOC = 'DV' OR ventas.TIPO_DOC = 'REM') AND ventas.CIERRE = 0 " +
                    "GROUP BY ventas.F_EMISION " +
                    "ORDER BY ventas.F_EMISION";

                MySqlCommand cmdr = new MySqlCommand(comando, concoloso);

                MySqlDataReader dr = cmdr.ExecuteReader();
                int y = 0;
                totalCo = 0;
                while (dr.Read())
                {
                    importeDiaCo = Convert.ToDouble(dr["total"].ToString());
                    LisColoso.Add(importeDiaCo);
                    totalCo = totalCo + importeDiaCo;

                    dgvVentas.Rows[y].Cells[4].Value = importeDiaCo.ToString("C");
                    y = y + 1;



                }
                //conectar.Close();
                dr.Close();
                dgvVentas.Rows[y].Cells[4].Value = totalCo.ToString("C");
                LisColoso.Add(totalCo);
            }
            catch (Exception)
            {
                MessageBox.Show("Velazquez sin conexion");
            }


            for (int i = 0; i <LisVallarta.Count ; i++)
            {
                //for (int k = 1; k < dgvVentas.Columns.Count - 1; k++)
                //{
                //    importeDiaTo = importeDiaTo + Convert.ToDouble(dgvVentas.Rows[i].Cells[k].Value);

                //}
                importeDiaTo = LisVallarta[i] + LisRena[i] +LisColoso[i] +LisVelazquez[i];

                dgvVentas.Rows[i].Cells[5].Value = importeDiaTo.ToString("C");
                importeDiaTo = 0;

            }
           
           

            //dgvVentas.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dgvVentas.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dgvVentas.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dgvVentas.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dgvVentas.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dia = DateTime.Now.ToString("dd");
            string mes = DateTime.Now.ToString("MM");
            string ano = DateTime.Now.ToString("yyyy");

            //int muestra;
            //muestra = Convert.ToInt32(dia);


            //for (int i = 0; i < muestra-1; i++)
            //{
            //    dgvVentas.Rows[i].Cells[0].Value = i.ToString() + "/" + mes + "/" + ano;
            //}

            
            
        }
        public void calculo()
        {
            double importeDiaTo = 0; ;
            //for (int i = 0; i < dgvVentas.Rows.Count; i++)
            //{
            //    for (int k = 1; k < dgvVentas.Columns.Count - 1; k++)
            //    {
            //        importeDiaTo = importeDiaTo + Convert.ToDouble(dgvVentas.Rows[i].Cells[k].Value);

            //    }
            //    dgvVentas.Rows[i].Cells[5].Value = importeDiaTo.ToString("C");
            //    importeDiaTo = 0;
            //}
            importeDiaTo =Convert.ToDouble( dgvVentas.Rows[0].Cells[1].Value);
            MessageBox.Show(importeDiaTo.ToString());
            
        }
    }
}
