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
    public partial class registroAsesoras : Form
    {
        public registroAsesoras()
        {
            InitializeComponent();
        }
        MySqlConnection con = null;
        string id = "";

        public void limpiar()
        {
            TB_id.Text = "";
            TB_usuario.Text = "";
            TB_nombre.Text = "";
            TB_apellidos.Text = "";
            CB_depto.SelectedIndex = 0;
            CB_puesto.SelectedIndex=0;
            DG_asesoras.Rows.Clear();
        }


        public void AgregarUsuario()
        {
            if (TB_usuario.Text.Equals("")||TB_nombre.Text.Equals("")||TB_apellidos.Text.Equals("")||CB_depto.SelectedItem.ToString().Equals("")||CB_puesto.SelectedItem.Equals(""))
            {
                MessageBox.Show("FAVOR DE LLENAR TODOS LOS CAMPOS DE REGISTRO");
            }
            else
            {
                con = BDConexicon.conectar();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO rd_asesoras_venta(usuario,nombre,apellidos,departamento,abrDepartamento,puesto)values(?usuario,?nombre,?apellidos,?departamento,?abrDepartamento,?puesto)", con);
                cmd.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = TB_usuario.Text;
                cmd.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = TB_nombre.Text;
                cmd.Parameters.Add("?apellidos", MySqlDbType.VarChar).Value = TB_apellidos.Text;
                cmd.Parameters.Add("?departamento", MySqlDbType.VarChar).Value = CB_depto.SelectedItem.ToString();
                cmd.Parameters.Add("?abrdepartamento", MySqlDbType.VarChar).Value = TB_linea.Text;
                cmd.Parameters.Add("?puesto", MySqlDbType.VarChar).Value = CB_puesto.SelectedItem.ToString();
                cmd.ExecuteNonQuery();
                con.Close();
                limpiar();
                MessageBox.Show("REGISTRO GUARDADO EXITOSAMENTE");
            }
        }

        private void BT_agregar_Click(object sender, EventArgs e)
        {

            AgregarUsuario();


        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {
            con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT idasesora,usuario,nombre,apellidos,departamento,puesto from rd_asesoras_venta where nombre='"+TB_nombre.Text+"'",con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DG_asesoras.Rows.Add(dr["idasesora"].ToString(),dr["usuario"].ToString(),dr["nombre"].ToString(),dr["apellidos"].ToString(),dr["departamento"].ToString(),dr["puesto"].ToString());

            }

            dr.Close();
            con.Close();
        }

        private void DG_asesoras_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           

            TB_id.Text = DG_asesoras.CurrentRow.Cells[0].Value.ToString();
            TB_usuario.Text=DG_asesoras.CurrentRow.Cells[1].Value.ToString();
            TB_nombre.Text = DG_asesoras.CurrentRow.Cells[2].Value.ToString();
            TB_apellidos.Text = DG_asesoras.CurrentRow.Cells[3].Value.ToString();
            CB_depto.SelectedItem = DG_asesoras.CurrentRow.Cells[4].Value.ToString();
            CB_puesto.SelectedItem = DG_asesoras.CurrentRow.Cells[5].Value.ToString();
        }

        private void BT_modificar_Click(object sender, EventArgs e)
        {
            con = BDConexicon.conectar();
            //string puesto = CB_puesto.SelectedItem.ToString();
            //MessageBox.Show(puesto);
            MySqlCommand cmd = new MySqlCommand("UPDATE rd_asesoras_venta SET usuario =?usuario, nombre=?nombre, apellidos=?apellidos, departamento=?departamento,abrDepartamento=?abrDepartamento, puesto=?puesto where idasesora='" + TB_id.Text+"'",con);
          
            cmd.Parameters.AddWithValue("?usuario", TB_usuario.Text);
            cmd.Parameters.AddWithValue("?nombre", TB_nombre.Text);
            cmd.Parameters.AddWithValue("?apellidos", TB_apellidos.Text);
            cmd.Parameters.AddWithValue("?departamento", CB_depto.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("?abrDepartamento", TB_linea.Text);
            cmd.Parameters.AddWithValue("?puesto", CB_puesto.SelectedItem.ToString());

          
            cmd.ExecuteNonQuery();
           
            con.Close();
            limpiar();
            DG_asesoras.DataSource = null;
            MessageBox.Show("REGISTRO MODIFICADO EXITOSAMENTE");
        }

        private void BT_eliminar_Click(object sender, EventArgs e)
        {
          
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿ESTA SEGURO QUE DESEA ELIMINAR EL USUARIO?.", "EliMINAR USUARIO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    if (string.IsNullOrEmpty(TB_id.Text))
                    {
                        MessageBox.Show("SELECCIONE UN USUARIO");

                    }
                    else
                    {

                        con = BDConexicon.conectar();
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM rd_asesoras_venta WHERE idasesora ='" + TB_id.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        limpiar();
                        MessageBox.Show("EL REGISTRO SE HA ELIMINADO");
                    }

                }
                
              
            

            }
            catch (Exception ex)
            {

                throw ex;
            }

            
        }


        public void CargarDepto()
        {
            con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("select descrip from lineas order by descrip",con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                CB_depto.Items.Add(dr["descrip"].ToString());
            }

            dr.Close();
            con.Close();

        }

        private void registroAsesoras_Load(object sender, EventArgs e)
        {

            CB_depto.Items.Add("");
            CargarDepto();

            CB_puesto.Items.Add("");
            CB_puesto.Items.Add("CUBRE");
            CB_puesto.Items.Add("ENCARGADA/O");

            DG_asesoras.Columns[4].Width = 150;
            DG_asesoras.Columns[5].Width = 150;
        }

        private void CB_puesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CB_depto_SelectedIndexChanged(object sender, EventArgs e)
        {

            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("select linea from lineas where descrip='"+CB_depto.SelectedItem.ToString()+"'",con);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                TB_linea.Text = dr["linea"].ToString();
            }
        }
    }
}
