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
    public partial class CuentasBancariasOS : Form
    {
        public CuentasBancariasOS()
        {
            InitializeComponent();
        }


        public void Limpiar()
        {
            TB_id.Text = "";
            CB_tienda.SelectedIndex = 0;
            CB_banco.SelectedIndex = 0;
            TB_cuenta.Text = "";
            TB_cliente.Text = "";
            DG_cuentas.Rows.Clear();

        }


        // INSERTA LOS REGISTROS EN LA TABLA rd_bancos_osmart
        public void RegistrarCuenta()
        {
            MySqlConnection con = BDConexicon.BodegaOpen();

            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO rd_bancos_osmart(tienda,banco,cuenta,clientebancario)VALUES(?tienda,?banco,?cuenta,?clientebancario)",con);
                cmd.Parameters.AddWithValue("?tienda",CB_tienda.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?banco", CB_banco.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?cuenta",TB_cuenta.Text);
                cmd.Parameters.AddWithValue("?clientebancario",TB_cliente.Text);
                cmd.ExecuteNonQuery();
                Limpiar();
                MessageBox.Show("Registro Guardado exitosamente");



            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al registrar cuentas bancarias osmart: "+ex);
            }
        }

        //BUSCA LAS CUENTAS POR BANCO, PARA MODIFICAR ALGUNA DE ELLAS, SI SE REQUIERE
        public void Buscar()
        {
            DG_cuentas.Rows.Clear();
            MySqlConnection con = BDConexicon.BodegaOpen();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT idreg,tienda,banco,cuenta,clientebancario FROM rd_bancos_osmart WHERE banco='" + CB_banco.SelectedItem.ToString() + "'", con);
                MySqlDataReader dr = cmd.ExecuteReader();



                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        DG_cuentas.Rows.Add(dr["idreg"].ToString(), dr["tienda"].ToString(), dr["banco"].ToString(), dr["cuenta"].ToString(), dr["clientebancario"].ToString());

                        
                    }
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("NO HAY CUENTAS REGISTRADAS");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al traer registros de la tabla rd_bancos_osmart, para su modificación: "+ex);
            }
            con.Close();
        }

        //ACTUALIZA LOS REGISTROS QUE SE MODIFICARON
        public void Modificar()
        {
            MySqlConnection con = BDConexicon.BodegaOpen();

            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE rd_bancos_osmart SET tienda='"+CB_tienda.SelectedItem.ToString()+"', banco='"+CB_banco.SelectedItem.ToString()+"', cuenta='"+TB_cuenta.Text+"'," +
                    " clientebancario='"+TB_cliente.Text+"' WHERE idreg='"+TB_id.Text+"'",con);
                cmd.ExecuteNonQuery();
                Limpiar();
                MessageBox.Show("El registro se ha actualizado");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar registro: "+ex);
               
            }
        }

       

        private void CuentasBancariasOS_Load(object sender, EventArgs e)
        {
            DG_cuentas.Columns["CLIENTE"].Width = 250;
            DG_cuentas.Columns["CUENTA"].Width = 200;
        }


        //####################################### BOTONES ###########################################################################################
        private void BT_registrar_Click(object sender, EventArgs e)
        {

            if (CB_tienda.SelectedIndex==0||CB_banco.SelectedIndex==0||TB_cuenta.Text.Equals("")||TB_cliente.Text.Equals(""))
            {
                MessageBox.Show("Favor de llenar todos los datos, para poder registrar una cuenta bancaria");
            }
            else
            {
                RegistrarCuenta();
            }
            
        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {


            if (CB_banco.SelectedIndex==0)
            {
                MessageBox.Show("Debes seleccionar un banco, para traer sus cuentas y modifcarlas");
            }
            else
            {
                Buscar();
            }
            
        }

        private void BT_modificar_Click(object sender, EventArgs e)
        {
            if (TB_id.Text.Equals(""))
            {
                MessageBox.Show("Debes seleccionar la cuenta que quieres modificar");
            }
            else
            {
                Modificar();
            }
            
        }

        private void BT_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        //###########################################################################################################################################

        private void DG_cuentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_id.Text = Convert.ToString(DG_cuentas.Rows[e.RowIndex].Cells[0].Value);
            CB_tienda.SelectedItem = Convert.ToString(DG_cuentas.Rows[e.RowIndex].Cells[1].Value);
            CB_banco.SelectedItem = Convert.ToString(DG_cuentas.Rows[e.RowIndex].Cells[2].Value);
            TB_cuenta.Text = Convert.ToString(DG_cuentas.Rows[e.RowIndex].Cells[3].Value);
            TB_cliente.Text = Convert.ToString(DG_cuentas.Rows[e.RowIndex].Cells[4].Value);
        }

        
    }
}
