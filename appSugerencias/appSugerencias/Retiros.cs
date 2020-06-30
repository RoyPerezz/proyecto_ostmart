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
    public partial class Retiros : Form
    {


        double importe = 0;
       

        public Retiros(string usuario)
        {
            InitializeComponent();
            LB_usuario.Text = usuario;
        }

        private void Retiros_Load(object sender, EventArgs e)
        {
            
        }

        //TRAE EL CONSECUTIVO DE FLUJO
        public int ConsecFlujo()
        {

            int consec = 1;
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT Consec FROM CONSEC WHERE Dato ='flujo'", con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                consec += consec = Convert.ToInt32(dr["Consec"].ToString());
            }

            return consec;
        }


        //INSERTA EL IMPORTE DE LA TARJETA EN FLUJO
        public void AfectarFlujo()
        {

            DateTime fecha = DateTime.Now;



            try
            {
                importe = Convert.ToDouble(TB_importe.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Verifica el formato del importe");
            }

            int consecFlujo = ConsecFlujo();
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO flujo(FLUJO,ABONO,CONCEPTO,ING_EG,IMPORTE,FECHA,HORA,MONEDA,ESTACION,USUARIO,USUFECHA,USUHORA,Modulo,Venta,Corte,tipo_cam,Cargo,concepto2,banco,cheque,verificado)" +
                "VALUES(?FLUJO,?ABONO,?CONCEPTO,?ING_EG,?IMPORTE,?FECHA,?HORA,?MONEDA,?ESTACION,?USUARIO,?USUFECHA,?USUHORA,?Modulo,?Venta,?Corte,?tipo_cam,?Cargo,?concepto2,?banco,?cheque,?verificado)",con);
            cmd.Parameters.AddWithValue("?FLUJO", consecFlujo);
            cmd.Parameters.AddWithValue("?ABONO", "0");
            cmd.Parameters.AddWithValue("?CONCEPTO","TARJ");
            cmd.Parameters.AddWithValue("?ING_EG", "E");
            cmd.Parameters.AddWithValue("?IMPORTE", importe);
            cmd.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?HORA", fecha.ToString("HH:mm:ss"));
            cmd.Parameters.AddWithValue("?MONEDA","MN");
            cmd.Parameters.AddWithValue("?ESTACION",CB_estacion.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("?USUARIO", LB_usuario.Text);
            cmd.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?USUHORA", fecha.ToString("HH:mm:ss"));
            cmd.Parameters.AddWithValue("?Modulo","PT");
            cmd.Parameters.AddWithValue("?Venta", "0");
            cmd.Parameters.AddWithValue("?Corte","1");
            cmd.Parameters.AddWithValue("?tipo_cam", "1");
            cmd.Parameters.AddWithValue("?Cargo", "0");
            cmd.Parameters.AddWithValue("?Concepto2", "TARJ");
            cmd.Parameters.AddWithValue("?banco", "");
            cmd.Parameters.AddWithValue("?cheque", "");
            cmd.Parameters.AddWithValue("?verificado", "0");
            cmd.ExecuteNonQuery();

            MySqlCommand update = new MySqlCommand("UPDATE CONSEC SET Consec='"+ consecFlujo+"' WHERE Dato='flujo'",con);
            update.ExecuteNonQuery();

            
            
            con.Close();


        }

        public void AfectarHistorialTarj()
        {
            DateTime fecha = DateTime.Now;
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO rd_historial_tarj(operacion,importe,estacion,usuario,fecha,hora)VALUES(?operacion,?importe,?estacion,?usuario,?fecha,?hora)", con);
            cmd.Parameters.AddWithValue("?operacion",TB_num_op.Text);
            cmd.Parameters.AddWithValue("?importe",importe);
            cmd.Parameters.AddWithValue("?estacion",CB_estacion.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("?usuario",LB_usuario.Text);
            cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?hora", fecha.ToString("HH:mm:ss"));
            cmd.ExecuteNonQuery();

            con.Close();
        }


        private void BT_aplicar_Click(object sender, EventArgs e)
        {
            if (CB_estacion.SelectedIndex==0||TB_num_op.Text.Equals("")||TB_importe.Text.Equals(""))
            {
                MessageBox.Show("Se deben llenar todos los datos");
            }
            else
            {
                AfectarFlujo();
                AfectarHistorialTarj();

                LB_operacion.Text = TB_num_op.Text;
                double importe = Convert.ToDouble(TB_importe.Text);
                LB_importe.Text = String.Format("{0:0.##}", importe.ToString("C"));
                TB_num_op.Text = "";
                TB_importe.Text = "";

                MessageBox.Show("Acción realizada con éxito");

            }
        }
    }
}
