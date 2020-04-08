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
    public partial class frm_nuevo_pedido : Form
    {
        public frm_nuevo_pedido()
        {
            InitializeComponent();
        }

        public frm_nuevo_pedido(int x)
        {
            InitializeComponent();
            if (x==1)
            {
                MessageBox.Show("Nuevo");
            }
            else
            {
                //MessageBox.Show("Actualizacion");
                tbIdPedido.Enabled = false;
                tbIdPedido.Text = VARIABLES.intpedido.ToString();
                tbPedido.Text = VARIABLES.titulo_pedido;
                tbArea.Text = VARIABLES.area.ToString();
                cbProveedor.Text = VARIABLES.proveedor.ToString();
                tbLink.Text = VARIABLES.link_pedido.ToString();
                tbCotiz.Text = VARIABLES.cotiz.ToString();
                tbGuia.Text = VARIABLES.guia.ToString();
                tbNota.Text = VARIABLES.nota.ToString();
                tbComPago.Text = VARIABLES.comprobante_pago;
                tbTipoPago.Text = VARIABLES.tipo_pago;
                tbFormaPago.Text = VARIABLES.forma_pago;
                tbObservaciones.Text = VARIABLES.observaciones;



                if (VARIABLES.va == 1)
                {
                    cBoxVa.Checked=true;
                }
                else
                {
                    cBoxVa.Checked = false;
                }

                if (VARIABLES.re == 1)
                {
                    cBoxRe.Checked = true;
                }
                else
                {
                    cBoxRe.Checked = false;
                }

                if (VARIABLES.co == 1)
                {
                    cBoxCo.Checked = true;
                }
                else
                {
                    cBoxCo.Checked = false;
                }

                if (VARIABLES.vl == 1)
                {
                    cBoxVl.Checked = true;
                }
                else
                {
                    cBoxVl.Checked = false;
                }


                if (VARIABLES.pm == 1)
                {
                    cBoxPm.Checked = true;
                }
                else
                {
                    cBoxPm.Checked = false;
                }

                if (VARIABLES.urge == 1)
                {
                    cBoxUrge.Checked = true;
                }
                else
                {
                    cBoxUrge.Checked = false;
                }

            }

        }

        private void frm_nuevo_pedido_Load(object sender, EventArgs e)
        {

        }
        MySqlConnection con = BDConexicon.VallartaOpen();
        public void guardaDatos()
        {
            string comando;

            DateTime fecha = dtDia.Value;
            //MessageBox.Show(fecha.ToString("yyyy-MM-dd"));
            try
            {

                comando = "INSERT INTO rd_pedido (titulo_pedido,fecha,area,proveedor,link_pedido,estatus,cotiz,nota,guia,comprobante_pago,pago_urge,tipo_pago,forma_pago,observaciones,va,re,vl,co,pm) values (?titulo_pedido,?fecha,?area,?proveedor,?link_pedido,?estatus,?cotiz,?nota,?guia,?comprobante_pago,?pago_urge,?tipo_pago,?forma_pago,?observaciones,?va,?re,?vl,?co,?pm)";

              

                MySqlCommand cmd = new MySqlCommand(comando, con);
                cmd.Parameters.Add("?titulo_pedido", MySqlDbType.VarChar).Value = tbPedido.Text; ;
                cmd.Parameters.Add("?fecha", MySqlDbType.VarChar).Value = fecha.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("?area", MySqlDbType.VarChar).Value = tbArea.Text;
                cmd.Parameters.Add("?proveedor", MySqlDbType.VarChar).Value = cbProveedor.Text;
                cmd.Parameters.Add("?link_pedido", MySqlDbType.VarChar).Value = tbLink.Text;
                cmd.Parameters.Add("?link_pedido", MySqlDbType.VarChar).Value ="CREADO";
                cmd.Parameters.Add("?cotiz", MySqlDbType.VarChar).Value = tbCotiz.Text;
                cmd.Parameters.Add("?nota", MySqlDbType.VarChar).Value = tbNota.Text;
                cmd.Parameters.Add("?guia", MySqlDbType.VarChar).Value = tbGuia.Text;
                cmd.Parameters.Add("?comprobante_pago", MySqlDbType.VarChar).Value = tbComPago.Text;
                cmd.Parameters.Add("?tipo_pago", MySqlDbType.VarChar).Value = tbTipoPago.Text;
                cmd.Parameters.Add("?forma_pago", MySqlDbType.VarChar).Value = tbFormaPago.Text;
                cmd.Parameters.Add("?observaciones", MySqlDbType.VarChar).Value = tbObservaciones.Text;

                if (cBoxUrge.Checked)
                {
                    cmd.Parameters.Add("?pago_urge", MySqlDbType.VarChar).Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("?pago_urge", MySqlDbType.VarChar).Value = 0;

                }



                if (cBoxVa.Checked)
                {
                    cmd.Parameters.Add("?va", MySqlDbType.VarChar).Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("?va", MySqlDbType.VarChar).Value = 0;

                }

                if (cBoxRe.Checked)
                {
                    cmd.Parameters.Add("?re", MySqlDbType.VarChar).Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("?re", MySqlDbType.VarChar).Value = 0;

                }
                if (cBoxVl.Checked)
                {
                    cmd.Parameters.Add("?vl", MySqlDbType.VarChar).Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("?vl", MySqlDbType.VarChar).Value = 0;

                }


                if (cBoxCo.Checked)
                {
                    cmd.Parameters.Add("?co", MySqlDbType.VarChar).Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("?co", MySqlDbType.VarChar).Value = 0;

                }


                if (cBoxPm.Checked)
                {
                    cmd.Parameters.Add("?pm", MySqlDbType.VarChar).Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("?pm", MySqlDbType.VarChar).Value = 0;

                }



                cmd.ExecuteNonQuery();

                

                MessageBox.Show("Datos gregados con exito");

            }
            catch (Exception EX)
            {
                MessageBox.Show("Error" + EX.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            guardaDatos();
        }
    }
}
