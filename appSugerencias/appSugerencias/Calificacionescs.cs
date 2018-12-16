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
    public partial class Calificacionescs : Form
    {
        int suma, saludo, sonrisa, pedido, maquillaje, uniforme, gafete, peinado, area, caja, equipo, foco, cancelacion, merca, informacion, cobro;

        private void BT_validar_Click(object sender, EventArgs e)
        {
            calif();
            if (CB_usuario.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una cajera");
            }
            else if (saludo > 10)
            {
                MessageBox.Show("Saludo no puede ser mayor a 10%");
            }
            else if (TB_saludo.Text == "")
            {
                MessageBox.Show("Saludo no puede quedar sin calificación");
            }
            else if (sonrisa > 10)
            {
                MessageBox.Show("Sonrisa no puede ser mayor a 10%");
            }
            else if (TB_sonrisa.Text == "")
            {
                MessageBox.Show("Sonrisa no puede quedar sin calificación");
            }
            else if (pedido > 10)
            {
                MessageBox.Show("Pedido no puede ser mayor a 10%");

            }
            else if (TB_pedido.Text == "")
            {
                MessageBox.Show("Pedido no puede quedar sin calificación");
            }
            else if (maquillaje > 12)
            {
                MessageBox.Show("Maquillaje no puede ser mayor a 12%");
            }
            else if (TB_maquillaje.Text == "")
            {
                MessageBox.Show("Maquillaje no puede quedar sin calificación");
            }
            else if (uniforme > 5)
            {
                MessageBox.Show("Uniforme no puede ser mayor a 5%");
            }
            else if (TB_uniforme.Text == "")
            {
                MessageBox.Show("Uniforme no puede quedar sin calificación");
            }
            else if (gafete > 5)
            {
                MessageBox.Show("Gafete no puede ser mayor a 5%");
            }
            else if (TB_gafete.Text == "")
            {
                MessageBox.Show("Gafete no puede quedar sin calificación");
            }
            else if (peinado > 5)
            {
                MessageBox.Show("Peinado no puede ser mayor a 5%");
            }
            else if (TB_peinado.Text == "")
            {
                MessageBox.Show("Peinado no puede quedar sin calificación");
            }
            else if (area > 6)
            {
                MessageBox.Show("Área no puede ser mayor a 6%");
            }
            else if (TB_area.Text == "")
            {
                MessageBox.Show("Área no puede quedar sin calificación");
            }
            else if (caja > 6)
            {
                MessageBox.Show("Caja no puede ser mayor a 6%");
            }
            else if (TB_caja.Text == "")
            {
                MessageBox.Show("Caja no puede quedar sin calificación");
            }
            else if (equipo > 6)
            {
                MessageBox.Show("Equipo no puede ser mayor a 6%");
            }
            else if (TB_equipo.Text == "")
            {
                MessageBox.Show("Equipo no puede quedar sin calificación");
            }
            else if (foco > 4)
            {
                MessageBox.Show("Foco encendido no puede ser mayor a 4%");
            }
            else if (TB_foco.Text == "")
            {
                MessageBox.Show("Foco encendido no puede quedar sin calificación");
            }
            else if (cancelacion > 4)
            {
                MessageBox.Show("Cancelación por error no puede ser mayor a 4%");
            }
            else if (TB_cancelacion.Text == "")
            {
                MessageBox.Show("Cancelación por error no puede quedar sin calificación");
            }
            else if (merca > 6)
            {
                MessageBox.Show("Mercancía en caja no puede ser mayor a 6%");
            }
            else if (TB_merca.Text == "")
            {
                MessageBox.Show("Mercancía en caja puede quedar sin calificación");
            }
            else if (informacion > 6)
            {
                MessageBox.Show("Información no puede ser mayor a 6%");
            }
            else if (TB_informacion.Text == "")
            {
                MessageBox.Show("Información no puede quedar sin calificación");
            }
            else if (cobro > 5)
            {
                MessageBox.Show("Cobro no puede ser mayor a 5%");
            }
            else
            {
                BT_calcular.Enabled = true;
            }
        }

        public Calificacionescs()
        {
            InitializeComponent();
        }


        public void calif()
        {
            try { 
            saludo = Convert.ToInt32(TB_saludo.Text);
            sonrisa = Convert.ToInt32(TB_sonrisa.Text);
            pedido = Convert.ToInt32(TB_pedido.Text);

            maquillaje = Convert.ToInt32(TB_maquillaje.Text);
            uniforme = Convert.ToInt32(TB_uniforme.Text);
            gafete = Convert.ToInt32(TB_gafete.Text);
            peinado = Convert.ToInt32(TB_peinado.Text);

            area = Convert.ToInt32(TB_area.Text);
            caja = Convert.ToInt32(TB_caja.Text);
            equipo = Convert.ToInt32(TB_equipo.Text);

            foco = Convert.ToInt32(TB_foco.Text);
            cancelacion = Convert.ToInt32(TB_cancelacion.Text);
            merca = Convert.ToInt32(TB_merca.Text);

            informacion = Convert.ToInt32(TB_informacion.Text);
            cobro = Convert.ToInt32(TB_cobro.Text);
            }catch(Exception e)
            {
                MessageBox.Show("Debes llenar todas las calificaciónes");
            }
        }


        public void llenado()
        {
            TB_saludo.Text = "10";
            TB_sonrisa.Text = "10";
            TB_pedido.Text = "10";
            TB_maquillaje.Text = "12";
            TB_uniforme.Text = "5";
            TB_gafete.Text = "5";
            TB_peinado.Text = "5";
            TB_area.Text = "6";
            TB_caja.Text = "6";
            TB_equipo.Text = "6";
            TB_foco.Text = "4";
            TB_cancelacion.Text = "4";
            TB_merca.Text = "6";
            TB_informacion.Text = "6";
            TB_cobro.Text = "5";

            
        }

        public int calcularPromedio()//realiza la sumatoria de los porcentajes 
        {
             suma = 0;
       
            saludo = Convert.ToInt32(TB_saludo.Text);
            sonrisa = Convert.ToInt32(TB_sonrisa.Text);
            pedido = Convert.ToInt32(TB_pedido.Text);

            maquillaje = Convert.ToInt32(TB_maquillaje.Text);
            uniforme = Convert.ToInt32(TB_uniforme.Text);
            gafete = Convert.ToInt32(TB_gafete.Text);
            peinado = Convert.ToInt32(TB_peinado.Text);

            area = Convert.ToInt32(TB_area.Text);
            caja = Convert.ToInt32(TB_caja.Text);
            equipo = Convert.ToInt32(TB_equipo.Text);

            foco = Convert.ToInt32(TB_foco.Text);
            cancelacion = Convert.ToInt32(TB_cancelacion.Text);
            merca = Convert.ToInt32(TB_merca.Text);

            informacion = Convert.ToInt32(TB_informacion.Text);
            cobro = Convert.ToInt32(TB_cobro.Text);

            suma = saludo + sonrisa + pedido + maquillaje + uniforme + gafete + peinado + area + caja + equipo + foco + cancelacion + merca + informacion + cobro;

            return suma;
        }

        public void cajeras()
        {
            
            MySqlCommand cmd = new MySqlCommand("select usuario from usuarios where area = '"+"cajas"+"'",BDConexicon.conectar());
            MySqlDataReader rd = cmd.ExecuteReader();
            Console.WriteLine(rd);
            while(rd.Read())
            {

                CB_usuario.Items.Add(rd[0].ToString());
            }
            

        }

        public void clientesAtendidos()
        {
            DateTime fecha = DT_fecha.Value;
            String f = FormatoFecha.getDate(fecha);
            MySqlCommand cmd = new MySqlCommand("select count(venta) as Tventas from ventas where usuario ='"+CB_usuario.SelectedItem.ToString()+"' and f_emision ='"+f+"'",BDConexicon.conectar());
            MySqlDataReader rd = cmd.ExecuteReader();

            int clientes = 0;
            while(rd.Read())
            {
                clientes = Convert.ToInt32(rd["Tventas"]);
            }

            TB_clientes.Text = Convert.ToString(clientes);
        }

        public void comisionCliente()
        {
            int clientes = Convert.ToInt32(TB_clientes.Text);
            double comisionClientes = 0.0;

            comisionClientes = clientes * 0.1;

            TB_Ccliente.Text = Convert.ToString(comisionClientes);
        }

        public void comisionTotal()
        {
            double comisionT = 0.0;
            double comisionN = Convert.ToDouble(TB_neta.Text);
            double cCliente = Convert.ToDouble(TB_Ccliente.Text);
            comisionT = comisionN + cCliente;
            TB_Ctotal.Text = Convert.ToString(comisionT);
        }


        public void limpiar()
        {
            CB_usuario.SelectedIndex = -1;
            TB_saludo.Text = "";
            TB_sonrisa.Text = "";
            TB_pedido.Text = "";
            TB_maquillaje.Text = "";
            TB_uniforme.Text = "";
            TB_gafete.Text = "";
            TB_peinado.Text = "";
            TB_area.Text = "";
            TB_caja.Text = "";
            TB_equipo.Text = "";
            TB_foco.Text = "";
            TB_cancelacion.Text = "";
            TB_merca.Text = "";
            TB_informacion.Text = "";
            TB_cobro.Text = "";
            TB_promedio.Text = "";
            TB_ventaT.Text = "";
            TB_bruta.Text = "";
            TB_neta.Text = "";
            TB_clientes.Text = "";
            TB_Ccliente.Text = "";
            TB_Ctotal.Text = "";

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //guarda registro calificaciones y comisiones

            MySqlCommand cmd = new MySqlCommand("insert into rd_comisiones(usuario, fecha, saludo, sonrisa, pedido, maquillaje, uniforme, gafete, peinado, area, equipo, foco," +
               "cancelacion, merc_caja, informacion, cobro, promedio, Vtotales, Cbruta, Cneta, cant_clientes,Ccliente,Ctotal) values(?usuario, ?fecha, ?saludo, ?sonrisa, ?pedido, ?maquillaje, ?uniforme, ?gafete, ?peinado, ?area, ?equipo, ?foco, ?cancelacion, ?merc_caja, ?informacion, ?cobro, ?promedio, ?Vtotales, ?Cbruta, ?Cneta, ?cant_clientes,?Ccliente,?Ctotal)", BDConexicon.conectar());


            double Vtotales = totalVentaDia();
            double Cbruta = comisionBruta();
            double Cneta = comisionNeta();
            double Ccliente = comisionCliente();
            double Ctotal = comisionTotal();
            int promedio = calcularPromedio();

            DateTime fecha = DT_fecha.Value;
            cmd.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = CB_usuario.SelectedItem.ToString();
            cmd.Parameters.Add("?fecha", MySqlDbType.Date).Value = fecha.ToString("yyyy-MM-dd"); ;
            cmd.Parameters.Add("?saludo", MySqlDbType.Int32).Value = saludo;
            cmd.Parameters.Add("?sonrisa", MySqlDbType.Int32).Value = sonrisa;
            cmd.Parameters.Add("?pedido", MySqlDbType.Int32).Value = pedido;
            cmd.Parameters.Add("?maquillaje", MySqlDbType.Int32).Value = maquillaje;
            cmd.Parameters.Add("?uniforme", MySqlDbType.Int32).Value = uniforme;
            cmd.Parameters.Add("?gafete", MySqlDbType.Int32).Value = gafete;
            cmd.Parameters.Add("?peinado", MySqlDbType.Int32).Value = peinado;
            cmd.Parameters.Add("?area", MySqlDbType.Int32).Value = area;
            cmd.Parameters.Add("?equipo", MySqlDbType.Int32).Value = equipo;
            cmd.Parameters.Add("?foco", MySqlDbType.Int32).Value = foco;
            cmd.Parameters.Add("?cancelacion", MySqlDbType.Int32).Value = cancelacion;
            cmd.Parameters.Add("?merc_caja", MySqlDbType.Int32).Value = merca;
            cmd.Parameters.Add("?informacion", MySqlDbType.Int32).Value = informacion;
            cmd.Parameters.Add("?cobro", MySqlDbType.Int32).Value = cobro;
            cmd.Parameters.Add("?promedio", MySqlDbType.Int32).Value = promedio;
            cmd.Parameters.Add("?Vtotales", MySqlDbType.Double).Value = Vtotales;
            cmd.Parameters.Add("?Cbruta", MySqlDbType.Double).Value = Cbruta;
            cmd.Parameters.Add("?CNeta", MySqlDbType.Double).Value = Cneta;
            cmd.Parameters.Add("?cant_clientes", MySqlDbType.Int32).Value = TB_clientes.Text;
            cmd.Parameters.Add("?Ccliente", MySqlDbType.Double).Value = Ccliente;
            cmd.Parameters.Add("?Ctotal", MySqlDbType.Double).Value = Ctotal;

            cmd.ExecuteNonQuery();
            limpiar();
            MessageBox.Show("Registros guardados exitosamente");

        }

        public double totalVentaDia()//calcula las venta total de cada vendedora por dia   
        {
            DateTime fecha = DT_fecha.Value;
            String f = FormatoFecha.getDate(fecha);
           
            double total = 0.0;
            MySqlCommand cmd = new MySqlCommand("select sum(importe) as total from ventas where usuario ='"+CB_usuario.SelectedItem.ToString()+"' and f_emision ='"+f+"'", BDConexicon.conectar());
            MySqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                try
                {
                    total = Convert.ToDouble(rd["total"]);
                }catch(Exception e)
                {
                    MessageBox.Show("No hay registros para su solicitud, verifique el nombre de la cajera y la fecha");
                }
                
            }
            return total;
        }

        public double sumaImpuesto()
        {
            DateTime fecha = DT_fecha.Value;
            String f = FormatoFecha.getDate(fecha);

            double impuesto = 0.0;
            MySqlCommand cmd = new MySqlCommand("select sum(impuesto) as impuesto from ventas where usuario ='" + CB_usuario.SelectedItem.ToString() + "' and f_emision ='" + f + "'", BDConexicon.conectar());
            MySqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                try
                {
                    impuesto = Convert.ToDouble(rd["impuesto"]);
                }catch(Exception e)
                {

                }
            }
            return impuesto;
        }

        public double comisionBruta()//Calcula la comision bruta con base a las ventas totales
        {
            double cBruta = 0.0;
            double totalV = Convert.ToDouble(TB_ventaT.Text);

            cBruta = totalV * 0.0024;
            TB_bruta.Text = Convert.ToString(cBruta);

            return cBruta;
        }

        public void comisionNeta()
        {
            double cNeta = 0.0;
            double cBruta = comisionBruta();
            double promedio = Convert.ToDouble(TB_promedio.Text);
            cNeta = cBruta * (promedio / 100);
            TB_neta.Text = Convert.ToString(cNeta);

        }
      



        private void Calificacionescs_Load(object sender, EventArgs e)
        {
            cajeras();

            //throw new NotImplementedException();
            
        }

        private void BT_calcular_Click(object sender, EventArgs e)
        {
            double t = totalVentaDia();
            double imp = sumaImpuesto();
            double ventaT = t + imp;

            int suma = calcularPromedio();
            TB_promedio.Text = Convert.ToString(suma);
            TB_ventaT.Text = Convert.ToString(ventaT);
            comisionBruta();
            comisionNeta();
            clientesAtendidos();
            comisionCliente();
            comisionTotal();
            BT_guardar.Enabled = true;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            llenado();
            BT_validar.Enabled = true;
            
        }
    }
}
