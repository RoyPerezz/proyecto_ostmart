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
        MySqlConnection conpregot;

        List<double> LisVallarta = new List<double>();
        List<double> LisRena = new List<double>();
        List<double> LisColoso = new List<double>();
        List<double> LisVelazquez = new List<double>();
        List<double> LisPregot = new List<double>();


        private void button1_Click(object sender, EventArgs e)
        {
            ventas();
        }

        public void ventas()
        {
            double importeDiaVa,importeDiaRe, importeDiaVe, importeDiaCo,importeDiaPre,importeDiaTo;
            double totalVa, totalRe, totalCo, totalVe, totalPre,Total;

            //int dan;
            importeDiaTo = 0;
            DateTime fecha;

            // string dia = DateTime.Now.ToString("dd");
            // string mes = DateTime.Now.ToString("MM");
            // string ano = DateTime.Now.ToString("yyyy");

            //MessageBox.Show(dia);
            // for( int i = Convert.ToInt32(dia); i < 0; i--)
            // {
            //     dgvVentas.Rows[i].Cells[0].Value = i.ToString() + "/" + mes + "/" + ano;
            // }



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
            catch (Exception ex)
            {
                for (int i = 0; i < dgvVentas.Rows.Count; i++)
                {

                    dgvVentas.Rows[i].Cells[1].Value = 0;
                    LisVallarta.Add(0);
                }
                LisVallarta.Add(0);
            
                MessageBox.Show("Vallarta sin conexion" + ex.Message);
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
            catch (Exception ex)
            {
                for (int i = 0; i < dgvVentas.Rows.Count; i++)
                {

                    dgvVentas.Rows[i].Cells[2].Value = 0;
                    LisRena.Add(0);
                }
                LisRena.Add(0);
                MessageBox.Show("rena sin conexion"+ ex.Message);



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
            catch (Exception ex)
            {
                for (int i = 0; i < dgvVentas.Rows.Count; i++)
                {

                    dgvVentas.Rows[i].Cells[3].Value = 0;
                    LisVelazquez.Add(0);
                }
                LisVelazquez.Add(0);
              
                MessageBox.Show("Velazquez sin conexion"+ ex.Message);
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
            catch (Exception ex)
            {
                for (int i = 0; i < dgvVentas.Rows.Count; i++)
                {

                    dgvVentas.Rows[i].Cells[4].Value = 0;
                    LisColoso.Add(0);
                }
                LisColoso.Add(0);
                
                MessageBox.Show("Coloso sin conexion" + ex.Message);
            }

            try
            {
                conpregot = BDConexicon.Papeleria1Open();
                string comando = "SELECT ventas.F_EMISION AS 'Fecha', " +
                    "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) + SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100)) As 'Total' " +
                    "FROM(partvta LEFT JOIN ventas ON ventas.VENTA = partvta.VENTA) INNER JOIN prods ON partvta.ARTICULO = prods.ARTICULO " +
                    "WHERE ventas.ESTADO = 'CO' AND(ventas.TIPO_DOC = 'FAC' OR ventas.TIPO_DOC = 'DV' OR ventas.TIPO_DOC = 'REM') AND ventas.CIERRE = 0 " +
                    "GROUP BY ventas.F_EMISION " +
                    "ORDER BY ventas.F_EMISION";

                MySqlCommand cmdr = new MySqlCommand(comando, conpregot);

                MySqlDataReader dr = cmdr.ExecuteReader();
                int y = 0;
                totalPre = 0;
                while (dr.Read())
                {
                    importeDiaPre = Convert.ToDouble(dr["total"].ToString());
                    LisPregot.Add(importeDiaPre);
                    totalPre = totalPre + importeDiaPre;

                    dgvVentas.Rows[y].Cells[5].Value = importeDiaPre.ToString("C");
                    y = y + 1;



                }
                //conectar.Close();
                dr.Close();
                dgvVentas.Rows[y].Cells[5].Value = totalPre.ToString("C");
                LisPregot.Add(totalPre);
            }
            catch (Exception ep)
            {
                for (int i = 0; i < dgvVentas.Rows.Count; i++)
                {

                    dgvVentas.Rows[i].Cells[5].Value = 0;
                    LisPregot.Add(0);
                }
                LisPregot.Add(0);
                MessageBox.Show("Pregot sin conexion" + ep.Message);
            }

           


            // SUMATORIA TOTAL DEL DIA DE TODAS LAS TIENDAS
            
            for (int i = 0; i <=dgvVentas.Rows.Count-1 ; i++)
            {
                int ii = 0;
                importeDiaTo = LisVallarta[i] + LisRena[i] +LisColoso[i] +LisVelazquez[i] + LisPregot[i];

                dgvVentas.Rows[i].Cells[6].Value = importeDiaTo.ToString("C");
                importeDiaTo = 0;
                ii++;
            }


            colocaFecha();
            

        }

        public void colocaFecha()
        {

            // string dia = DateTime.Now.ToString("dd");
            // string mes = DateTime.Now.ToString("MM");
            // string ano = DateTime.Now.ToString("yyyy");

            //MessageBox.Show(dia);
            // for( int i = Convert.ToInt32(dia); i < 0; i--)
            // {
            //     dgvVentas.Rows[i].Cells[0].Value = i.ToString() + "/" + mes + "/" + ano;
            // }
            string dia = DateTime.Now.ToString("dd");
            string mes = DateTime.Now.ToString("MM");
            string ano = DateTime.Now.ToString("yyyy");




            for (int i = 0; i < dgvVentas.Rows.Count - 1; i++)
            {
                int aux = Convert.ToInt32(dia);
                dgvVentas.Rows[i].Cells[0].Value = aux.ToString() + "/" + mes + "/" + ano;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            colocaFecha();


        }


        private void VentasxTienda_Load(object sender, EventArgs e)
        {

        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            excel.Range["A1:A1000"].NumberFormat = "@";
            int indiceColumna = 0;

            foreach (DataGridViewColumn col in dgvVentas.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in dgvVentas.Columns)
                {
                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                }



            }




            excel.Visible = true;
        }
    }
}
