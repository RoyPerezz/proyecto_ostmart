using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class Rep_pagoproveedores : Form
    {

        string usuario = "";

        public Rep_pagoproveedores()
        {
           
        }

        public Rep_pagoproveedores(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        public string Sucursal()
        {

            string nombre = "";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT EMPRESA FROM ECONFIG", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nombre = dr["EMPRESA"].ToString();
            }
            dr.Close();
            con.Close();

            return nombre;

        }

        private void Rep_pagoproveedores_Load(object sender, EventArgs e)
        {

            string suc = Sucursal();
           
            if (suc.Equals("OSMART VALLARTA"))
            {
                CB_sucursal.SelectedIndex = 1;
            }

            if (suc.Equals("OSMART RENACIMIENTO"))
            {
                CB_sucursal.SelectedIndex = 2;
            }

            if (suc.Equals("OSMART VELAZQUEZ"))
            {
                CB_sucursal.SelectedIndex = 3;
            }

            if (suc.Equals("OSMART COLOSO"))
            {
                CB_sucursal.SelectedIndex = 4;
            }

            if (suc.Equals("PREGOT"))
            {
                CB_sucursal.SelectedIndex = 5;
            }






            DG_reporte.Columns["PROVEEDOR"].Width = 270;
            DG_reporte.Columns["PAGARA"].Width = 270;
            DG_reporte.Columns["BANCO"].Width = 120;
            DG_reporte.Columns["CUENTA"].Width = 170;
            DG_reporte.Columns["REFERENCIA"].Width = 170;

            if (usuario.Equals("INOCENCIO") || usuario.Equals("SISTEMAS") || usuario.Equals("SOPORTE")|| usuario.Equals("JAIME"))
            {
                CB_sucursal.Enabled = true;
            }
            else
            {
                CB_sucursal.Enabled = false;
            }

            
        }


        public MySqlConnection ElegirSucursal()
        {
            MySqlConnection con = null;
            string tienda = CB_sucursal.SelectedItem.ToString();
            if (tienda.Equals("BODEGA"))
            {
                con = BDConexicon.BodegaOpen();
            }
            if (tienda.Equals("VALLARTA"))
            {
                con = BDConexicon.VallartaOpen();
            }
            if (tienda.Equals("RENA"))
            {
                con = BDConexicon.RenaOpen();
            }

            if (tienda.Equals("COLOSO"))
            {
                con = BDConexicon.ColosoOpen();
            }

            if (tienda.Equals("VELAZQUEZ"))
            {
                con = BDConexicon.VelazquezOpen();
            }

            if (tienda.Equals("PREGOT"))
            {
                con = BDConexicon.Papeleria1Open();
            }

            return con;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            
            if (CB_sucursal.SelectedIndex==0)
            {
                MessageBox.Show("Elige la sucursal");
            }
            else
            {
                if (usuario.Equals("INOCENCIO") || usuario.Equals("SISTEMAS") || usuario.Equals("SOPORTE") || usuario.Equals("JAIME"))
                {
                    MySqlConnection sucursal = ElegirSucursal();

                    DG_reporte.Rows.Clear();
                    DateTime inicio = DT_inicio.Value;
                    DateTime fin = DT_fin.Value;


                    MySqlCommand cmd = new MySqlCommand("SELECT idreporte,nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,referencia,status FROM rd_rep_pagoproveedores WHERE fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "'", sucursal);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    double monto = 0;

                    while (dr.Read())
                    {
                        DataGridViewCheckBoxCell check = new DataGridViewCheckBoxCell();
                        if (dr["fecha_efe"].ToString().Equals("0000-00-00"))
                        {
                            DateTime fecha_efe = new DateTime();

                            if (dr["status"].ToString().Equals("0"))
                            {

                                monto = Convert.ToDouble(dr["monto"].ToString());
                                DG_reporte.Rows.Add(dr["idreporte"].ToString(), dr["nombreprov"].ToString(), dr["pagarA"].ToString(), String.Format("{0:0.##}", monto.ToString("C")), dr["banco"].ToString(), dr["cuenta"].ToString(), dr["fecha"].ToString(), fecha_efe, dr["tienda"].ToString(), dr["compra"].ToString(), dr["referencia"].ToString(), check.ThreeState=false);
                            }

                            if (dr["status"].ToString().Equals("1"))
                            {

                                monto = Convert.ToDouble(dr["monto"].ToString());
                                DG_reporte.Rows.Add(dr["idreporte"].ToString(), dr["nombreprov"].ToString(), dr["pagarA"].ToString(), String.Format("{0:0.##}", monto.ToString("C")), dr["banco"].ToString(), dr["cuenta"].ToString(), dr["fecha"].ToString(), fecha_efe, dr["tienda"].ToString(), dr["compra"].ToString(), dr["referencia"].ToString(), check.ThreeState=true);
                            }
                        }
                        else
                        {

                            DateTime fecha_efe = Convert.ToDateTime(dr["fecha_efe"].ToString());

                            if (dr["status"].ToString().Equals("0"))
                            {

                                monto = Convert.ToDouble(dr["monto"].ToString());
                                DG_reporte.Rows.Add(dr["idreporte"].ToString(), dr["nombreprov"].ToString(), dr["pagarA"].ToString(), String.Format("{0:0.##}", monto.ToString("C")), dr["banco"].ToString(), dr["cuenta"].ToString(), dr["fecha"].ToString(), fecha_efe, dr["tienda"].ToString(), dr["compra"].ToString(), dr["referencia"].ToString(), check.ThreeState=false);
                            }

                            if (dr["status"].ToString().Equals("1"))
                            {

                                monto = Convert.ToDouble(dr["monto"].ToString());
                                DG_reporte.Rows.Add(dr["idreporte"].ToString(), dr["nombreprov"].ToString(), dr["pagarA"].ToString(), String.Format("{0:0.##}", monto.ToString("C")), dr["banco"].ToString(), dr["cuenta"].ToString(), dr["fecha"].ToString(), fecha_efe, dr["tienda"].ToString(), dr["compra"].ToString(), dr["referencia"].ToString(), check.ThreeState=true);
                            }
                        }


                        //DateTime fecha_efe = Convert.ToDateTime(dr["fecha_efe"].ToString());

                        //monto = Convert.ToDouble(dr["monto"].ToString());
                        //DG_reporte.Rows.Add(dr["nombreprov"].ToString(), dr["pagarA"].ToString(), String.Format("{0:0.##}", monto.ToString("C")), dr["banco"].ToString(), dr["cuenta"].ToString(), dr["fecha"].ToString(), fecha_efe.ToString("dd-MM-yyyy"), dr["tienda"].ToString(), dr["compra"].ToString(),dr["referencia"].ToString());







                    }
                    dr.Close();
                    sucursal.Close();
                }
                else
                {
                    DG_reporte.Rows.Clear();
                    DateTime inicio = DT_inicio.Value;
                    DateTime fin = DT_fin.Value;



                    MySqlConnection con = BDConexicon.conectar();
                    MySqlCommand cmd = new MySqlCommand("SELECT idreporte,nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,referencia,status FROM rd_rep_pagoproveedores WHERE fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "'", con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    double monto = 0;

                    while (dr.Read())
                    {
                        DataGridViewCheckBoxCell check = new DataGridViewCheckBoxCell();
                        if (dr["fecha_efe"].ToString().Equals("0000-00-00"))
                        {
                            DateTime fecha_efe = new DateTime();

                            if (dr["status"].ToString().Equals("0"))
                            {

                                monto = Convert.ToDouble(dr["monto"].ToString());
                                DG_reporte.Rows.Add(dr["idreporte"].ToString(), dr["nombreprov"].ToString(), dr["pagarA"].ToString(), String.Format("{0:0.##}", monto.ToString("C")), dr["banco"].ToString(), dr["cuenta"].ToString(), dr["fecha"].ToString(), fecha_efe, dr["tienda"].ToString(), dr["compra"].ToString(), dr["referencia"].ToString(), check.ThreeState=false);
                            }

                            if (dr["status"].ToString().Equals("1"))
                            {

                                monto = Convert.ToDouble(dr["monto"].ToString());
                                DG_reporte.Rows.Add(dr["idreporte"].ToString(), dr["nombreprov"].ToString(), dr["pagarA"].ToString(), String.Format("{0:0.##}", monto.ToString("C")), dr["banco"].ToString(), dr["cuenta"].ToString(), dr["fecha"].ToString(), fecha_efe, dr["tienda"].ToString(), dr["compra"].ToString(), dr["referencia"].ToString(), check.ThreeState=true);
                            }
                        }
                        else
                        {

                            DateTime fecha_efe = Convert.ToDateTime(dr["fecha_efe"].ToString());

                            if (dr["status"].ToString().Equals("0"))
                            {

                                monto = Convert.ToDouble(dr["monto"].ToString());
                                DG_reporte.Rows.Add(dr["idreporte"].ToString(), dr["nombreprov"].ToString(), dr["pagarA"].ToString(), String.Format("{0:0.##}", monto.ToString("C")), dr["banco"].ToString(), dr["cuenta"].ToString(), dr["fecha"].ToString(), fecha_efe, dr["tienda"].ToString(), dr["compra"].ToString(), dr["referencia"].ToString(), check.ThreeState=false);
                            }

                            if (dr["status"].ToString().Equals("1"))
                            {

                                monto = Convert.ToDouble(dr["monto"].ToString());
                                DG_reporte.Rows.Add(dr["idreporte"].ToString(), dr["nombreprov"].ToString(), dr["pagarA"].ToString(), String.Format("{0:0.##}", monto.ToString("C")), dr["banco"].ToString(), dr["cuenta"].ToString(), dr["fecha"].ToString(), fecha_efe, dr["tienda"].ToString(), dr["compra"].ToString(), dr["referencia"].ToString(), check.ThreeState=true);
                            }
                        }




                    }
                    dr.Close();
                    con.Close();
                }






                double suma = 0;
                for (int i = 0; i < DG_reporte.RowCount; i++)
                {
                    //suma += Convert.ToDouble(DG_reporte.Rows[i].Cells[2].Value);
                    decimal digito = decimal.Parse(DG_reporte.Rows[i].Cells[3].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    string num = digito.ToString("G0");

                    suma += Convert.ToDouble(num);
                }

                DG_reporte.Rows.Add("", "", "TOTAL", String.Format("{0:0.##}", suma.ToString("C")), "", "", "", "");
                //DG_reporte.Columns[2].DefaultCellStyle.Format = "C2";
            }
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


        //ACTUALIZA EL ESTADO DEL CHECKBOX COLUM DEL DATAGRID
        private void BT_guardar_Click(object sender, EventArgs e)
        {

            MySqlConnection con = BDConexicon.conectar();
            for (int i = 0; i < DG_reporte.RowCount; i++)
            {
                string id = Convert.ToString(DG_reporte.Rows[i].Cells[0].Value);
                bool status =Convert.ToBoolean( DG_reporte.Rows[i].Cells[11].Value);

                if (status==true)
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE rd_rep_pagoproveedores SET status="+1+" WHERE idreporte='"+id+"'",con);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE rd_rep_pagoproveedores SET status="+0+" WHERE idreporte='" + id + "'", con);
                    cmd.ExecuteNonQuery();

                }
            }

            MessageBox.Show("Se ha actualizado el estado de los pagos");
        }
    }
}
