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
    public partial class GenClaves : Form
    {
        public GenClaves()
        {
            InitializeComponent();
            DG_numeros.Columns[0].Width = 135;
        }
        MySqlConnection con;
       
       
        DataTable aux;
        DataTable master;
        MySqlConnection conbodega;
        MySqlConnection convallarta;
        MySqlConnection conrena;
        MySqlConnection convelazquez;
        MySqlConnection concoloso;


        public void Generar()
        {

            DG_numeros.Rows.Clear();
            Random rnd = new Random();

            DataTable DTbodega = new DataTable();
            DataTable DTvallarta = new DataTable();
            DataTable DTrena = new DataTable();
            DataTable DTcoloso = new DataTable();
            DataTable DTvelazquez = new DataTable();

            //**************************************** SE RELLENAN LOS DATATABLES CON LAS CLAVES DE ARTICULOS DE LAS TIENDAS ]*****************************



            try
            {
                conbodega = BDConexicon.BodegaOpen();
                MySqlCommand cmdBodega = new MySqlCommand("SELECT articulo AS ARTICULO from prods", conbodega);
                MySqlDataAdapter adBodega = new MySqlDataAdapter(cmdBodega);
                adBodega.Fill(DTbodega);
                TB_estatusBodega.BackColor = Color.Green;
                conbodega.Close();
            }
            catch (Exception)
            {

                TB_estatusBodega.BackColor = Color.Red;

            }


            try
            {
                convallarta = BDConexicon.V_vallarta();
                MySqlCommand cmdVallarta = new MySqlCommand("SELECT articulo AS ARTICULO from prods", convallarta);

                MySqlDataAdapter adVallarta = new MySqlDataAdapter(cmdVallarta);
                adVallarta.Fill(DTvallarta);
                TB_estatusVallarta.BackColor = Color.Green;

                convallarta.Close();
            }
            catch (Exception)
            {

                TB_estatusVallarta.BackColor = Color.Red;
            }

            try
            {
                conrena = BDConexicon.RenaOpen();
                MySqlCommand cmdRena = new MySqlCommand("SELECT articulo AS ARTICULO from prods", conrena);
                MySqlDataAdapter adRena = new MySqlDataAdapter(cmdRena);
                adRena.Fill(DTrena);
                TB_estatusRena.BackColor = Color.Green;
                conrena.Close();
            }
            catch (Exception)
            {

                TB_estatusRena.BackColor = Color.Red;
            }


            try
            {

                convelazquez = BDConexicon.VelazquezOpen();
                MySqlCommand cmdVelazquez = new MySqlCommand("SELECT articulo AS ARTICULO from prods", convelazquez);
                MySqlDataAdapter adVelazquez = new MySqlDataAdapter(cmdVelazquez);

                adVelazquez.Fill(DTvelazquez);
                TB_estatusVelazquez.BackColor = Color.Green;
                convelazquez.Close();
            }
            catch (Exception)
            {


                TB_estatusVelazquez.BackColor = Color.Red;
            }


            try
            {


                concoloso = BDConexicon.ColosoOpen();
                MySqlCommand cmdColoso = new MySqlCommand("SELECT articulo AS ARTICULO from prods", concoloso);
                MySqlDataAdapter adColoso = new MySqlDataAdapter(cmdColoso);
                adColoso.Fill(DTcoloso);
                TB_estatusColoso.BackColor = Color.Green;
                concoloso.Close();

            }
            catch (Exception)
            {

                TB_estatusColoso.BackColor = Color.Red;

            }


            //************************************* UNIR LOS DATATABLES EN UNO PROVISIONAL *****************************************************
            DataTable master1 = DTbodega.AsEnumerable()
                .Union(DTvallarta.AsEnumerable())
                .Union(DTrena.AsEnumerable())
                .Union(DTvelazquez.AsEnumerable())
                .Union(DTcoloso.AsEnumerable()).Distinct(DataRowComparer.Default).CopyToDataTable<DataRow>();

            //master = repetidos(master1, "articulo");
            
            string departamento = TB_depto.Text;
            string proveedor = TB_proveedor.Text;

            int clavesRep = 0;
            bool bandera = false;
            try
            {



                for (int i = 0; i < 50; i++)
                {

                    int n = rnd.Next(100000, 999999);
                    string numero = Convert.ToString(n);

                    foreach (DataRow row in master1.Rows)
                    {

                        string num = row["ARTICULO"].ToString();
                        if (numero.Equals(num))
                        {
                            bandera = true;
                            clavesRep++;

                        }

                    }
                    if (bandera == false)
                    {
                        DG_numeros.Rows.Add(TB_depto.Text + TB_proveedor.Text + Convert.ToString(numero));
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);

            }


            LB_generadas.Text = Convert.ToString(DG_numeros.RowCount);
            LB_rep.Text = Convert.ToString(clavesRep);




        }


        public void Resetar()
        {
            TB_estatusBodega.BackColor = Color.White;
            TB_estatusVallarta.BackColor = Color.White;
            TB_estatusRena.BackColor = Color.White;
            TB_estatusColoso.BackColor = Color.White;
            TB_estatusVelazquez.BackColor = Color.White;
            PB_proceso.Value = 0;
            DG_numeros.Rows.Clear();
            LB_mensaje.Text = "";
            LB_generadas.Text = "";
            LB_rep.Text = "";
        }

        private void BT_generar_Click(object sender, EventArgs e)
        {
            Resetar();
            Timer.Enabled = true;
           
        }



        public DataTable repetidos(DataTable dtData, string sColumnName)
        {
            try
            {
                DataTable distintos = dtData.DefaultView.ToTable(true, sColumnName);
                DataTable dtNew = new DataTable();
                foreach (DataColumn dcName in dtData.Columns)
                {
                    dtNew.Columns.Add(new DataColumn(dcName.Caption, dcName.DataType));
                }

                foreach (DataRow drRow in distintos.Rows)
                {
                    dtNew.ImportRow(dtData.Select(sColumnName + " = '" + drRow[0] + "'")[0]);
                }
                return dtNew;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        //private void BT_consultar_Click(object sender, EventArgs e)
        //{
        //    MySqlDataReader dr = null;
        //    MySqlConnection con;
        //    string valor = "";
        //    con = BDConexicon.VallartaOpen();
        //    foreach(DataGridViewRow row in DG_numeros.Rows)
        //    {
        //       valor= row.Cells[0].Value.ToString();
              
        //        MySqlCommand cmd = new MySqlCommand("SELECT descrip from prods where articulo ='"+valor+"'",con);
        //      dr = cmd.ExecuteReader();
        //       if(dr.Read())
        //        {
        //            //row.DefaultCellStyle.ForeColor = Color.Red;

        //        }
        //        else
        //        {

        //        }
        //        dr.Close();
        //    }
            
        //    con.Close();
        //    MessageBox.Show("Se ha generado el resultado de la verificación");
        //}

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            excel.Range["A1:A1000"].NumberFormat = "@";
            int indiceColumna = 0;

            foreach (DataGridViewColumn col in DG_numeros.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in DG_numeros.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in DG_numeros.Columns)
                {
                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                }



            }




            excel.Visible = true;
        }

        private void GenClaves_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            if (PB_proceso.Value<100)
            {
              
                PB_proceso.Value = PB_proceso.Value + 10;
                LB_mensaje.Text = "Generando Claves...";
            }
            else
            {
                Generar();
                Timer.Enabled = false;
                LB_mensaje.Text = "Proceso finalizado";
               
            }
        }
    }
}
