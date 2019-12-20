using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class ComisionesAsesoras : Form
    {
        public ComisionesAsesoras()
        {
            InitializeComponent();
        }

        ArrayList deptos = new ArrayList();
        MySqlConnection con;
        double ventasXlinea = 0;
        double comisionBruta = 0;
        double mascotas = 0, fiesta = 0, bolsa_dama = 0, sanValentin = 0, cosmeticos = 0, cosvip = 0, navideños = 0, barbie = 0, bolsa_regalo = 0, febrero = 0, playa = 0;
        double bisuteria = 0, bolsa_plastico = 0, escolar = 0, halloween = 0, juguetes = 0, montables = 0, mostrador = 0, patrio = 0, peluches = 0, plasticos = 0, resina_relojes = 0;
        double serie = 0, mayo = 0, sombrillas = 0;
        int index = 0;
        double ventasLineas = 0;
        private void ComisionesAsesoras_Load(object sender, EventArgs e)
        {
            TB_promedio.Enabled = false;
            BT_calcular.Enabled = false;
            BT_guardar.Enabled = false;
            CB_asesora.Items.Add("");
            CargarAsesoras();
        }

        public void CargarAsesoras()
        {
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT usuario from rd_asesoras_venta order by usuario",con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                CB_asesora.Items.Add(dr["usuario"].ToString());
            }

            dr.Close();
            con.Close();
        }


        int areaLimpia, areaSurtida, presentacion, precios, etiquetas, pedidosCliente;
        double promedio = 0;

        public double CalcularPromedio()
        {

            promedio =Convert.ToDouble( areaLimpia + areaSurtida + presentacion + precios + etiquetas + pedidosCliente);

            return promedio;
        }

        public double VentasxLinea()
        {
           
            DateTime fecha = DT_fecha.Value;
            con = BDConexicon.conectar();
            MySqlDataReader dr;
         
            double suma = 0;
           

            if (CBX_mascotas.Checked==false && CBX_fiesta.Checked==false && CBX_bolsa_dama.Checked==false && CBX_sanvalentin.Checked==false && CBX_cosmeticos.Checked==false && CBX_cosvip.Checked==false && CBX_navideño.Checked==false && CBX_barbie.Checked==false && CBX_bolsa_regalo.Checked==false && CBX_14febrero.Checked==false && CBX_playa.Checked==false && CBX_bisuteria.Checked==false && CBX_bolsa_plastico.Checked==false && CBX_escolar.Checked==false && CBX_halloween.Checked==false  && CBX_jugueteria.Checked==false && CBX_montables.Checked==false && CBX_mostrador.Checked==false && CBX_patrio.Checked==false && CBX_peluches.Checked==false && CBX_plasticos.Checked==false && CBX_relojes.Checked==false && CBX_serie.Checked==false && CBX_sombrillas.Checked == false && CBX_10mayo.Checked == false)
            {
                MessageBox.Show("DEBES SELECCIONAR AL MENOS UN DEPARTAMENTO PARA PAGAR COMISION");
            }else
            {
                if (CBX_mascotas.Checked)
                {
                    index++;
                    MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                    "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                    " WHERE PRODS.LINEA = 'MASCOTAS' AND PARTVTA.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "'", con);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (string.IsNullOrEmpty(dr["Total"].ToString()))
                        {
                            mascotas = 0;
                        }
                        else
                        {
                            mascotas = Convert.ToDouble(dr["Total"].ToString());
                        }


                    }
                    dr.Close();

                    MySqlCommand dep = new MySqlCommand("insert into rd_asesora_deptos(usuario, departamento, fecha) values(?usuario,?departamento,?fecha)",con);
                    dep.Parameters.AddWithValue("?usuario",CB_asesora.SelectedItem.ToString());
                    dep.Parameters.AddWithValue("?departamento"," -MASCOTAS- ");
                    dep.Parameters.AddWithValue("?fecha",fecha.ToString("yyyy-MM-dd"));
                    dep.ExecuteNonQuery();
                  
                }

                if (CBX_fiesta.Checked)
                {
                    index++;
                    MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                    "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                    " WHERE PRODS.LINEA = 'ARTPFIESTA' AND PARTVTA.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "'", con);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (string.IsNullOrEmpty(dr["Total"].ToString()))
                        {
                            fiesta = 0;
                        }
                        else
                        {
                            fiesta = Convert.ToDouble(dr["Total"].ToString());
                        }


                    }
                    dr.Close();

                    MySqlCommand dep = new MySqlCommand("insert into rd_asesora_deptos(usuario, departamento, fecha) values(?usuario,?departamento,?fecha)", con);
                    dep.Parameters.AddWithValue("?usuario", CB_asesora.SelectedItem.ToString());
                    dep.Parameters.AddWithValue("?departamento", " -ART. FIESTA- ");
                    dep.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    dep.ExecuteNonQuery();
                }

                if (CBX_bolsa_dama.Checked)
                {
                    index++;
                    MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                    "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                    " WHERE PRODS.LINEA = 'BPDAMA' AND PARTVTA.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "'", con);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (string.IsNullOrEmpty(dr["Total"].ToString()))
                        {
                            bolsa_dama = 0;
                        }
                        else
                        {
                            bolsa_dama = Convert.ToDouble(dr["Total"].ToString());
                        }


                    }
                    dr.Close();

                    MySqlCommand dep = new MySqlCommand("insert into rd_asesora_deptos(usuario, departamento, fecha) values(?usuario,?departamento,?fecha)", con);
                    dep.Parameters.AddWithValue("?usuario", CB_asesora.SelectedItem.ToString());
                    dep.Parameters.AddWithValue("?departamento", " -BOLSA DAMA- ");
                    dep.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    dep.ExecuteNonQuery();

                }


                if (CBX_sanvalentin.Checked)
                {
                    index++;
                    MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                    "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                    " WHERE PRODS.LINEA = 'BOLSA- FEB' AND PARTVTA.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "'", con);

                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {

                        if (string.IsNullOrEmpty(dr["Total"].ToString()))
                        {
                            sanValentin = 0;
                        }
                        else
                        {
                            sanValentin = Convert.ToDouble(dr["Total"].ToString());
                        }




                    }


                    dr.Close();

                    MySqlCommand dep = new MySqlCommand("insert into rd_asesora_deptos(usuario, departamento, fecha) values(?usuario,?departamento,?fecha)", con);
                    dep.Parameters.AddWithValue("?usuario", CB_asesora.SelectedItem.ToString());
                    dep.Parameters.AddWithValue("?departamento", " -SAN VALENTIN- ");
                    dep.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    dep.ExecuteNonQuery();
                }

                if (CBX_cosmeticos.Checked)
                {

                    index++;
                    MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                   "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                   " WHERE PRODS.LINEA = 'COSMET' AND PARTVTA.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "'", con);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (string.IsNullOrEmpty(dr["Total"].ToString()))
                        {
                            cosmeticos = 0;
                        }
                        else
                        {
                            cosmeticos = Convert.ToDouble(dr["Total"].ToString());
                        }


                    }
                    dr.Close();

                    MySqlCommand dep = new MySqlCommand("insert into rd_asesora_deptos(usuario, departamento, fecha) values(?usuario,?departamento,?fecha)", con);
                    dep.Parameters.AddWithValue("?usuario", CB_asesora.SelectedItem.ToString());
                    dep.Parameters.AddWithValue("?departamento", " -COSMETICOS- ");
                    dep.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    dep.ExecuteNonQuery();
                }

                if (CBX_cosvip.Checked)
                {

                    index++;
                    MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                   "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                   " WHERE PRODS.LINEA = 'COSVIP' AND PARTVTA.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "'", con);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (string.IsNullOrEmpty(dr["Total"].ToString()))
                        {
                            cosvip = 0;
                        }
                        else
                        {
                            cosvip = Convert.ToDouble(dr["Total"].ToString());
                        }


                    }
                    dr.Close();

                    MySqlCommand dep = new MySqlCommand("insert into rd_asesora_deptos(usuario, departamento, fecha) values(?usuario,?departamento,?fecha)", con);
                    dep.Parameters.AddWithValue("?usuario", CB_asesora.SelectedItem.ToString());
                    dep.Parameters.AddWithValue("?departamento", " -COSVIP- ");
                    dep.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    dep.ExecuteNonQuery();
                }

                if (CBX_navideño.Checked)
                {

                    index++;
                    MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                   "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                   " WHERE PRODS.LINEA = 'NAV' AND PARTVTA.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "'", con);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (string.IsNullOrEmpty(dr["Total"].ToString()))
                        {
                            navideños = 0;
                        }
                        else
                        {
                            navideños = Convert.ToDouble(dr["Total"].ToString());
                        }


                    }
                    dr.Close();

                    MySqlCommand dep = new MySqlCommand("insert into rd_asesora_deptos(usuario, departamento, fecha) values(?usuario,?departamento,?fecha)", con);
                    dep.Parameters.AddWithValue("?usuario", CB_asesora.SelectedItem.ToString());
                    dep.Parameters.AddWithValue("?departamento", " -ART. NAVIDEÑOS- ");
                    dep.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    dep.ExecuteNonQuery();
                }

                if (CBX_barbie.Checked)
                {

                    index++;
                    MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                   "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                   " WHERE PRODS.LINEA = 'BARBIE' AND PARTVTA.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "'", con);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (string.IsNullOrEmpty(dr["Total"].ToString()))
                        {
                            barbie = 0;
                        }
                        else
                        {
                            barbie = Convert.ToDouble(dr["Total"].ToString());
                        }


                    }
                    dr.Close();

                    MySqlCommand dep = new MySqlCommand("insert into rd_asesora_deptos(usuario, departamento, fecha) values(?usuario,?departamento,?fecha)", con);
                    dep.Parameters.AddWithValue("?usuario", CB_asesora.SelectedItem.ToString());
                    dep.Parameters.AddWithValue("?departamento", " -BARBIE- ");
                    dep.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    dep.ExecuteNonQuery();
                }

                if (CBX_bolsa_regalo.Checked)
                {

                    index++;
                    MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                   "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                   " WHERE PRODS.LINEA = 'BOLSA' AND PARTVTA.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "'", con);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (string.IsNullOrEmpty(dr["Total"].ToString()))
                        {
                            bolsa_regalo = 0;
                        }
                        else
                        {
                            bolsa_regalo = Convert.ToDouble(dr["Total"].ToString());
                        }


                    }
                    dr.Close();

                    MySqlCommand dep = new MySqlCommand("insert into rd_asesora_deptos(usuario, departamento, fecha) values(?usuario,?departamento,?fecha)", con);
                    dep.Parameters.AddWithValue("?usuario", CB_asesora.SelectedItem.ToString());
                    dep.Parameters.AddWithValue("?departamento", " -BOLSA REGALO- ");
                    dep.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    dep.ExecuteNonQuery();
                }

                if (CBX_14febrero.Checked)
                {

                    index++;
                    MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                   "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                   " WHERE PRODS.LINEA = 'FEB' AND PARTVTA.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "'", con);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (string.IsNullOrEmpty(dr["Total"].ToString()))
                        {
                            febrero = 0;
                        }
                        else
                        {
                            febrero = Convert.ToDouble(dr["Total"].ToString());
                        }


                    }
                    dr.Close();
                    MySqlCommand dep = new MySqlCommand("insert into rd_asesora_deptos(usuario, departamento, fecha) values(?usuario,?departamento,?fecha)", con);
                    dep.Parameters.AddWithValue("?usuario", CB_asesora.SelectedItem.ToString());
                    dep.Parameters.AddWithValue("?departamento", " -14 FEBRERO- ");
                    dep.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    dep.ExecuteNonQuery();
                }

                if (CBX_playa.Checked)
                {
                    index++;
                    MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                   "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                   " WHERE PRODS.LINEA = 'PLY' AND PARTVTA.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "'", con);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (string.IsNullOrEmpty(dr["Total"].ToString()))
                        {
                            playa = 0;
                        }
                        else
                        {
                            playa = Convert.ToDouble(dr["Total"].ToString());
                        }


                    }
                    dr.Close();
                    MySqlCommand dep = new MySqlCommand("insert into rd_asesora_deptos(usuario, departamento, fecha) values(?usuario,?departamento,?fecha)", con);
                    dep.Parameters.AddWithValue("?usuario", CB_asesora.SelectedItem.ToString());
                    dep.Parameters.AddWithValue("?departamento", " -ART. PLAYA- ");
                    dep.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    dep.ExecuteNonQuery();
                }

                if (CBX_bisuteria.Checked)
                {
                    index++;
                    MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                   "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                   " WHERE PRODS.LINEA = 'BISUTE' AND PARTVTA.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "'", con);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (string.IsNullOrEmpty(dr["Total"].ToString()))
                        {
                            bisuteria = 0;
                        }
                        else
                        {
                            bisuteria = Convert.ToDouble(dr["Total"].ToString());
                        }


                    }
                    dr.Close();
                    MySqlCommand dep = new MySqlCommand("insert into rd_asesora_deptos(usuario, departamento, fecha) values(?usuario,?departamento,?fecha)", con);
                    dep.Parameters.AddWithValue("?usuario", CB_asesora.SelectedItem.ToString());
                    dep.Parameters.AddWithValue("?departamento", " -BISUTERIA- ");
                    dep.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    dep.ExecuteNonQuery();

                }

                if (CBX_bolsa_plastico.Checked)
                {

                    index++;
                    MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                   "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                   " WHERE PRODS.LINEA = 'BPLASTC' AND PARTVTA.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "'", con);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (string.IsNullOrEmpty(dr["Total"].ToString()))
                        {
                            bolsa_plastico = 0;
                        }
                        else
                        {
                            bolsa_plastico = Convert.ToDouble(dr["Total"].ToString());
                        }


                    }
                    dr.Close();
                    MySqlCommand dep = new MySqlCommand("insert into rd_asesora_deptos(usuario, departamento, fecha) values(?usuario,?departamento,?fecha)", con);
                    dep.Parameters.AddWithValue("?usuario", CB_asesora.SelectedItem.ToString());
                    dep.Parameters.AddWithValue("?departamento", " -BOLSA PLASTICO- ");
                    dep.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    dep.ExecuteNonQuery();

                }

                if (CBX_escolar.Checked)
                {

                    index++;
                    MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                   "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                   " WHERE PRODS.LINEA = 'ESCOLA' AND PARTVTA.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "'", con);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (string.IsNullOrEmpty(dr["Total"].ToString()))
                        {
                            escolar = 0;
                        }
                        else
                        {
                            escolar = Convert.ToDouble(dr["Total"].ToString());
                        }


                    }
                    dr.Close();
                    MySqlCommand dep = new MySqlCommand("insert into rd_asesora_deptos(usuario, departamento, fecha) values(?usuario,?departamento,?fecha)", con);
                    dep.Parameters.AddWithValue("?usuario", CB_asesora.SelectedItem.ToString());
                    dep.Parameters.AddWithValue("?departamento", " -ESCOLAR- ");
                    dep.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    dep.ExecuteNonQuery();
                }

                if (CBX_halloween.Checked)
                {

                    index++;
                    MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                   "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                   " WHERE PRODS.LINEA = 'HAL' AND PARTVTA.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "'", con);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (string.IsNullOrEmpty(dr["Total"].ToString()))
                        {
                            halloween = 0;
                        }
                        else
                        {
                            halloween = Convert.ToDouble(dr["Total"].ToString());
                        }


                    }
                    dr.Close();
                    MySqlCommand dep = new MySqlCommand("insert into rd_asesora_deptos(usuario, departamento, fecha) values(?usuario,?departamento,?fecha)", con);
                    dep.Parameters.AddWithValue("?usuario", CB_asesora.SelectedItem.ToString());
                    dep.Parameters.AddWithValue("?departamento", " -HALLOWEEN- ");
                    dep.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    dep.ExecuteNonQuery();
                }

                if (CBX_jugueteria.Checked)
                {
                    index++;
                    MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                   "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                   " WHERE PRODS.LINEA = 'JUGUET' AND PARTVTA.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "'", con);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (string.IsNullOrEmpty(dr["Total"].ToString()))
                        {
                            juguetes = 0;
                        }
                        else
                        {
                            juguetes = Convert.ToDouble(dr["Total"].ToString());
                        }


                    }
                    dr.Close();
                    MySqlCommand dep = new MySqlCommand("insert into rd_asesora_deptos(usuario, departamento, fecha) values(?usuario,?departamento,?fecha)", con);
                    dep.Parameters.AddWithValue("?usuario", CB_asesora.SelectedItem.ToString());
                    dep.Parameters.AddWithValue("?departamento", " -JUGUETES- ");
                    dep.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    dep.ExecuteNonQuery();
                }

                if (CBX_montables.Checked)
                {

                    index++;
                    MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                   "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                   " WHERE PRODS.LINEA = 'MONTAB' AND PARTVTA.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "'", con);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (string.IsNullOrEmpty(dr["Total"].ToString()))
                        {
                            montables = 0;
                        }
                        else
                        {
                            montables = Convert.ToDouble(dr["Total"].ToString());
                        }


                    }
                    dr.Close();
                    MySqlCommand dep = new MySqlCommand("insert into rd_asesora_deptos(usuario, departamento, fecha) values(?usuario,?departamento,?fecha)", con);
                    dep.Parameters.AddWithValue("?usuario", CB_asesora.SelectedItem.ToString());
                    dep.Parameters.AddWithValue("?departamento", " -MONTABLES- ");
                    dep.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    dep.ExecuteNonQuery();
                }

                if (CBX_mostrador.Checked)
                {

                    index++;
                    MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                   "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                   " WHERE PRODS.LINEA = 'MOSTRA' AND PARTVTA.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "'", con);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (string.IsNullOrEmpty(dr["Total"].ToString()))
                        {
                            mostrador = 0;
                        }
                        else
                        {
                            mostrador = Convert.ToDouble(dr["Total"].ToString());
                        }


                    }
                    dr.Close();
                    MySqlCommand dep = new MySqlCommand("insert into rd_asesora_deptos(usuario, departamento, fecha) values(?usuario,?departamento,?fecha)", con);
                    dep.Parameters.AddWithValue("?usuario", CB_asesora.SelectedItem.ToString());
                    dep.Parameters.AddWithValue("?departamento", " -MOSTRADOR- ");
                    dep.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    dep.ExecuteNonQuery();
                }

                if (CBX_patrio.Checked)
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                   "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                   " WHERE PRODS.LINEA = 'PAT' AND PARTVTA.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "'", con);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (string.IsNullOrEmpty(dr["Total"].ToString()))
                        {
                            patrio = 0;
                        }
                        else
                        {
                            patrio = Convert.ToDouble(dr["Total"].ToString());
                        }


                    }
                    dr.Close();
                    MySqlCommand dep = new MySqlCommand("insert into rd_asesora_deptos(usuario, departamento, fecha) values(?usuario,?departamento,?fecha)", con);
                    dep.Parameters.AddWithValue("?usuario", CB_asesora.SelectedItem.ToString());
                    dep.Parameters.AddWithValue("?departamento", " -PATRIO- ");
                    dep.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    dep.ExecuteNonQuery();
                }

                if (CBX_peluches.Checked)
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                   "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                   " WHERE PRODS.LINEA = 'PELUCHE' AND PARTVTA.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "'", con);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (string.IsNullOrEmpty(dr["Total"].ToString()))
                        {
                            peluches = 0;
                        }
                        else
                        {
                            peluches = Convert.ToDouble(dr["Total"].ToString());
                        }


                    }
                    dr.Close();
                    MySqlCommand dep = new MySqlCommand("insert into rd_asesora_deptos(usuario, departamento, fecha) values(?usuario,?departamento,?fecha)", con);
                    dep.Parameters.AddWithValue("?usuario", CB_asesora.SelectedItem.ToString());
                    dep.Parameters.AddWithValue("?departamento", " -PELUCHE- ");
                    dep.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    dep.ExecuteNonQuery();
                }

                if (CBX_plasticos.Checked)
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                   "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                   " WHERE PRODS.LINEA = 'PLASTIC' AND PARTVTA.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "'", con);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (string.IsNullOrEmpty(dr["Total"].ToString()))
                        {
                            plasticos = 0;
                        }
                        else
                        {
                            plasticos = Convert.ToDouble(dr["Total"].ToString());
                        }


                    }
                    dr.Close();
                    MySqlCommand dep = new MySqlCommand("insert into rd_asesora_deptos(usuario, departamento, fecha) values(?usuario,?departamento,?fecha)", con);
                    dep.Parameters.AddWithValue("?usuario", CB_asesora.SelectedItem.ToString());
                    dep.Parameters.AddWithValue("?departamento", " -PLASTICOS- ");
                    dep.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    dep.ExecuteNonQuery();
                }

                if (CBX_relojes.Checked)
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                   "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                   " WHERE PRODS.LINEA = 'RESINA' AND PARTVTA.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "'", con);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (string.IsNullOrEmpty(dr["Total"].ToString()))
                        {
                            resina_relojes = 0;
                        }
                        else
                        {
                            resina_relojes = Convert.ToDouble(dr["Total"].ToString());
                        }


                    }
                    dr.Close();
                    MySqlCommand dep = new MySqlCommand("insert into rd_asesora_deptos(usuario, departamento, fecha) values(?usuario,?departamento,?fecha)", con);
                    dep.Parameters.AddWithValue("?usuario", CB_asesora.SelectedItem.ToString());
                    dep.Parameters.AddWithValue("?departamento", " -RELOJES Y RESINA- ");
                    dep.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    dep.ExecuteNonQuery();

                }

                if (CBX_serie.Checked)
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                   "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                   " WHERE PRODS.LINEA = 'SER' AND PARTVTA.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "'", con);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (string.IsNullOrEmpty(dr["Total"].ToString()))
                        {
                            serie = 0;
                        }
                        else
                        {
                            serie = Convert.ToDouble(dr["Total"].ToString());
                        }


                    }
                    dr.Close();
                    MySqlCommand dep = new MySqlCommand("insert into rd_asesora_deptos(usuario, departamento, fecha) values(?usuario,?departamento,?fecha)", con);
                    dep.Parameters.AddWithValue("?usuario", CB_asesora.SelectedItem.ToString());
                    dep.Parameters.AddWithValue("?departamento", " -SERIE- ");
                    dep.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    dep.ExecuteNonQuery();

                }

                if (CBX_10mayo.Checked)
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                   "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                   " WHERE PRODS.LINEA = 'MAY' AND PARTVTA.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "'", con);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (string.IsNullOrEmpty(dr["Total"].ToString()))
                        {
                            mayo = 0;
                        }
                        else
                        {
                            mayo = Convert.ToDouble(dr["Total"].ToString());
                        }


                    }
                    dr.Close();
                    MySqlCommand dep = new MySqlCommand("insert into rd_asesora_deptos(usuario, departamento, fecha) values(?usuario,?departamento,?fecha)", con);
                    dep.Parameters.AddWithValue("?usuario", CB_asesora.SelectedItem.ToString());
                    dep.Parameters.AddWithValue("?departamento", " -10 MAYO- ");
                    dep.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    dep.ExecuteNonQuery();

                }

                if (CBX_sombrillas.Checked)
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                   "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                   " WHERE PRODS.LINEA = 'SOMBRILLAS' AND PARTVTA.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "'", con);

                    dr = cmd.ExecuteReader();


                    while (dr.Read())
                    {
                        if (string.IsNullOrEmpty(dr["Total"].ToString()))
                        {
                            sombrillas = 0;
                        }
                        else
                        {
                            sombrillas = Convert.ToDouble(dr["Total"].ToString());
                        }


                    }
                    dr.Close();
                    MySqlCommand dep = new MySqlCommand("insert into rd_asesora_deptos(usuario, departamento, fecha) values(?usuario,?departamento,?fecha)", con);
                    dep.Parameters.AddWithValue("?usuario", CB_asesora.SelectedItem.ToString());
                    dep.Parameters.AddWithValue("?departamento", " -SOMBRILLAS- ");
                    dep.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    dep.ExecuteNonQuery();

                }
                con.Close();

                suma = mascotas + fiesta + bolsa_dama + sanValentin + cosmeticos + cosvip + navideños + barbie + bolsa_regalo + febrero + playa + bisuteria + bolsa_plastico + escolar + halloween + juguetes + montables + mostrador + patrio + peluches + plasticos + resina_relojes + serie + mayo + sombrillas;
                mascotas = 0; fiesta = 0; bolsa_dama = 0; sanValentin = 0; cosmeticos = 0; cosvip = 0; navideños = 0; barbie = 0; bolsa_regalo = 0; febrero = 0; playa = 0;
                bisuteria = 0; bolsa_plastico = 0; escolar = 0; halloween = 0; juguetes = 0; montables = 0; mostrador = 0; patrio = 0; peluches = 0; plasticos = 0; resina_relojes = 0;
                serie = 0; mayo = 0; sombrillas = 0;

            }

            return suma;
        }

        private void CB_asesora_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("select puesto " +
                "from rd_asesoras_venta where usuario='" + CB_asesora.SelectedItem.ToString()+"'",con);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
              
                TB_puesto.Text = dr["puesto"].ToString();
            }
            dr.Close();
            con.Close();
        }

   
       

        public void Limpiar()
        {
            CB_asesora.SelectedIndex = 0;
          
            TB_puesto.Text = "";
            TB_Alimpia.Text = "";
            TB_Asurtida.Text = "";
            TB_presentacion.Text = "";
            TB_precios.Text = "";
            TB_etiquetas.Text = "";
            TB_pedidosC.Text = "";
            TB_promedio.Text = "";
            TB_ventaXLinea.Text = "";
            TB_ComisionB.Text = "";
            TB_comisionN.Text = "";
            CBX_mascotas.Checked = false;
            CBX_bolsa_dama.Checked = false;
            CBX_sanvalentin.Checked = false;
            CBX_cosmeticos.Checked = false;
            CBX_cosvip.Checked = false;
            CBX_navideño.Checked = false;
            CBX_barbie.Checked = false;
            CBX_bolsa_regalo.Checked = false;
            CBX_14febrero.Checked = false;
            CBX_playa.Checked = false;
            CBX_bisuteria.Checked = false;
            CBX_bolsa_plastico.Checked = false;
            CBX_fiesta.Checked = false;
            CBX_jugueteria.Checked = false;
            CBX_montables.Checked = false;
            CBX_mostrador.Checked = false;
            CBX_patrio.Checked = false;
            CBX_peluches.Checked = false;
            CBX_plasticos.Checked = false;
            CBX_relojes.Checked = false;
            CBX_serie.Checked = false;
            CBX_10mayo.Checked = false;
            CBX_sombrillas.Checked = false;
            CBX_escolar.Checked = false;
            CBX_halloween.Checked = false;

        }

      
        private void BT_guardar_Click(object sender, EventArgs e)
        {
            //string dep = "";

            //foreach (string item in deptos)
            //{
            //    dep += item+" ";
            //}
            DateTime fecha = DT_fecha.Value;
            double cb = 0, cn = 0,vl=0;
            cb= double.Parse(TB_ComisionB.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            cn = double.Parse(TB_comisionN.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            vl = double.Parse(TB_ventaXLinea.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO rd_comisionneta_asesoras(usuario,puesto,fecha,area_limpia,area_surtida,presentacion,precios,etiquetas,pedido_clientes,promedio,ventaxLinea,cb,cn) values(?usuario,?puesto,?fecha,?area_limpia,?area_surtida,?presentacion,?precios,?etiquetas,?pedido_clientes,?promedio,?ventaxLinea,?cb,?cn)", con);
            cmd.Parameters.AddWithValue("?usuario",CB_asesora.SelectedItem.ToString());
            //cmd.Parameters.AddWithValue("?departamentos", dep);
            cmd.Parameters.AddWithValue("?puesto", TB_puesto.Text);
            cmd.Parameters.AddWithValue("?fecha",fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?area_limpia",TB_Alimpia.Text);
            cmd.Parameters.AddWithValue("?area_surtida", TB_Asurtida.Text);
            cmd.Parameters.AddWithValue("?presentacion",TB_presentacion.Text);
            cmd.Parameters.AddWithValue("?precios",TB_precios.Text);
            cmd.Parameters.AddWithValue("?etiquetas", TB_etiquetas.Text);
            cmd.Parameters.AddWithValue("?pedido_clientes",TB_pedidosC.Text );
            cmd.Parameters.AddWithValue("?promedio", TB_promedio.Text);
            cmd.Parameters.AddWithValue("?ventaxLinea",vl);
            cmd.Parameters.AddWithValue("?cb", cb);
            cmd.Parameters.AddWithValue("?cn", cn);
           
            cmd.ExecuteNonQuery();
            Limpiar();
            MessageBox.Show("EL REGISTRO SE HA GUARDADO EXITOSAMENTE");
            BT_guardar.Enabled = false;
            BT_calcular.Enabled = false;
        }



        public double CalcularComisionBruta()
        {

            string puesto = "";
            double ventaTotalLinea = 0;
            con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("select puesto from rd_asesoras_venta where usuario='" + CB_asesora.SelectedItem.ToString() + "'", con);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                puesto = dr["puesto"].ToString();
            }

            dr.Close();

            
            if (puesto.Equals("CUBRE"))
            {


                comisionBruta = ventasLineas * 0.005;
            }
            else
            {
                comisionBruta = ventasLineas * 0.006;
            }

            return comisionBruta;
        }


        double Cneta;
        public double CalcularComisionNeta()
        {

            
           Cneta = comisionBruta * (promedio/100);
            return Cneta;

        }
        private void BT_calcular_Click(object sender, EventArgs e)
        {
            Calificaciones();
            double prom = CalcularPromedio();
            ventasLineas = VentasxLinea();
            double comBruta = CalcularComisionBruta();
            double comNeta = CalcularComisionNeta();
            TB_promedio.Text = Convert.ToString(prom);
            TB_ventaXLinea.Text = Convert.ToString(String.Format("{0:0.##}", ventasLineas.ToString("C")));
            TB_ComisionB.Text = Convert.ToString(String.Format("{0:0.##}", comisionBruta.ToString("C")));
            TB_comisionN.Text=Convert.ToString(String.Format("{0:0.##}", comNeta.ToString("C")));
            BT_guardar.Enabled = true;
        }

        public void Calificaciones()
        {
            if (TB_Alimpia.Text.Equals("")||TB_Asurtida.Text.Equals("")||TB_presentacion.Text.Equals("")||TB_precios.Text.Equals("")||TB_etiquetas.Text.Equals("")||TB_pedidosC.Text.Equals(""))
            {
                MessageBox.Show("POR FAVOR, PONER TODAS LAS CALIFICACIONES");
            }
            else
            {
                areaLimpia = Convert.ToInt32(TB_Alimpia.Text);
                areaSurtida = Convert.ToInt32(TB_Asurtida.Text);
                presentacion = Convert.ToInt32(TB_presentacion.Text);
                precios = Convert.ToInt32(TB_precios.Text);
                etiquetas = Convert.ToInt32(TB_etiquetas.Text);
                pedidosCliente = Convert.ToInt32(TB_pedidosC.Text);
                BT_calcular.Enabled = true;
            }
        }
        private void BT_validar_Click(object sender, EventArgs e)
        {


            Calificaciones();
            if (CB_asesora.SelectedIndex==-1)
            {
                MessageBox.Show("DEBES SELECCIONAR A UNA ASESORA");
            }
         
            else if(areaLimpia > 15)
            {
                MessageBox.Show("ÁREA LIMPIA NO PUEDE SER MAYOR A 15%");
            }
            else if(areaSurtida >20)
            {
                MessageBox.Show("ÁREA SURTIDA NO PUEDE SER MAYOR A 20%");
            }
            else if (presentacion >15)
            {
                MessageBox.Show("PRESENTACION NO PUEDE SER MAYOR A 15%");
            }
            else if (precios >20)
            {
                MessageBox.Show("PRECIOS NO PUEDE SER MAYOR A 20%");
            }
            else if (etiquetas >15)
            {
                MessageBox.Show("ETIQUETASA NO PUEDE SER MAYOR A 15%");
            }
            else if (pedidosCliente >15)
            {
                MessageBox.Show("P. CLIENTE NO PUEDE SER MAYOR A 15%");
            }
            else
            {
               
            }
        }
    }
}
