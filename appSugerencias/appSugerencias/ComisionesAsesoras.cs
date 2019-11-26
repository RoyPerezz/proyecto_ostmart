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
    public partial class ComisionesAsesoras : Form
    {
        public ComisionesAsesoras()
        {
            InitializeComponent();
        }


        MySqlConnection con;
        double ventasXlinea = 0;
        double comisionBruta = 0;
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
            MySqlCommand cmd = new MySqlCommand("SELECT SUM((PARTVTA.precio *(PARTVTA.cantidad - PARTVTA.a01)* (1 - (PARTVTA.descuento / 100)) * VENTAS.tipo_cam) * (1 + (PARTVTA.impuesto / 100) )) As Total " +
                "FROM VENTAS INNER JOIN PARTVTA ON VENTAS.venta = PARTVTA.venta INNER JOIN PRODS ON PRODS.articulo = PARTVTA.articulo" +
                " WHERE PRODS.LINEA = '"+TB_iniciales.Text+"' AND PARTVTA.USUFECHA = '"+fecha.ToString("yyyy-MM-dd")+"'",con);

            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ventasXlinea = Convert.ToDouble(dr["Total"].ToString());
            }
            dr.Close();
            con.Close();
            return ventasXlinea;

            
        }

        private void CB_asesora_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("select departamento,abrDepartamento, puesto " +
                "from rd_asesoras_venta where usuario='" + CB_asesora.SelectedItem.ToString()+"'",con);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                TB_depto.Text = dr["departamento"].ToString();
                TB_iniciales.Text= dr["abrDepartamento"].ToString();
                TB_puesto.Text = dr["puesto"].ToString();
            }
            dr.Close();
            con.Close();
        }

   
        public double CalcularComisionBruta()
        {

            string puesto = "";
            double ventaTotalLinea = 0;
            con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("select puesto from rd_asesoras_venta where usuario='" + CB_asesora.SelectedItem.ToString()+"'",con);
            MySqlDataReader dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                puesto = dr["puesto"].ToString();
            }

            dr.Close();

            ventaTotalLinea = VentasxLinea();
            if (puesto.Equals("CUBRE"))
            {
               

                comisionBruta = ventaTotalLinea * 0.005;
            }
            else
            {
                comisionBruta = ventaTotalLinea * 0.006;
            }

            return comisionBruta;
        }

        public void Limpiar()
        {
            CB_asesora.SelectedIndex = 0;
            TB_depto.Text = "";
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

        }


        private void BT_guardar_Click(object sender, EventArgs e)
        {

            DateTime fecha = DT_fecha.Value;
            con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO rd_comisionneta_asesoras(usuario,departamento,puesto,fecha,area_limpia,area_surtida,presentacion,precios,etiquetas,pedido_clientes,promedio,ventaxLinea,cb,cn) values(?usuario,?departamento,?puesto,?fecha,?area_limpia,?area_surtida,?presentacion,?precios,?etiquetas,?pedido_clientes,?promedio,?ventaxLinea,?cb,?cn)",con);
            cmd.Parameters.AddWithValue("?usuario",CB_asesora.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("?departamento", TB_depto.Text);
            cmd.Parameters.AddWithValue("?puesto", TB_puesto.Text);
            cmd.Parameters.AddWithValue("?fecha",fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?area_limpia",TB_Alimpia.Text);
            cmd.Parameters.AddWithValue("?area_surtida", TB_Asurtida.Text);
            cmd.Parameters.AddWithValue("?presentacion",TB_presentacion.Text);
            cmd.Parameters.AddWithValue("?precios",TB_precios.Text);
            cmd.Parameters.AddWithValue("?etiquetas", TB_etiquetas.Text);
            cmd.Parameters.AddWithValue("?pedido_clientes",TB_pedidosC.Text );
            cmd.Parameters.AddWithValue("?promedio", TB_promedio.Text);
            cmd.Parameters.AddWithValue("?ventaxLinea",TB_ventaXLinea.Text);
            cmd.Parameters.AddWithValue("?cb", TB_ComisionB.Text);
            cmd.Parameters.AddWithValue("?cn", TB_comisionN.Text);
            cmd.ExecuteNonQuery();
            Limpiar();
            MessageBox.Show("EL REGISTRO SE HA GUARDADO EXITOSAMENTE");
        }

        double Cneta;
        public double CalcularComisionNeta()
        {

            
           Cneta = comisionBruta * (promedio/100);
            return Cneta;

        }
        private void BT_calcular_Click(object sender, EventArgs e)
        {
            
            TB_promedio.Text = Convert.ToString(CalcularPromedio());
            TB_ventaXLinea.Text = Convert.ToString(VentasxLinea());
            TB_ComisionB.Text = Convert.ToString(CalcularComisionBruta());
            TB_comisionN.Text=Convert.ToString(CalcularComisionNeta());
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
