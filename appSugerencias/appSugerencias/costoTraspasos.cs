using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace appSugerencias
{
    public partial class costoTraspasos : Form
    {
        public costoTraspasos()
        {
            InitializeComponent();
        }

        int idMovsinv;
        MySqlConnection conex_traspasos;
        MySqlConnection conex_datostraspaso;
        MySqlConnection conex_bajatraspaso;
        MySqlConnection conex_altatraspaso;
        MySqlConnection conex_cancelacion;
        MySqlConnection conex_prueba;

        private void button1_Click(object sender, EventArgs e)
        {
            llamadaTiendas(cbTienda.Text);
        }

        public void llamadaTiendas(string tienda)
        {


            limpiarTraspaso();
            // MessageBox.Show(cbTienda.Text);
            if (tienda == "BODEGA")
            {
                try
                {
                    conex_traspasos = BDConexicon.BodegaOpen();
                    selectDatos();
                    lblConexion.Text = "Conectado Bo";
                    lblConexion.ForeColor = Color.DarkGreen;

                }
                catch (Exception e)
                {
                    lblConexion.Text = "Sin Conexion Bo";
                    lblConexion.ForeColor = Color.Red;
                }

            }
            else if (tienda == "VALLARTA")
            {
                try
                {
                    conex_traspasos = BDConexicon.VallartaOpen();
                    selectDatos();
                    consultaTraspaso();
                    lblConexion.Text = "Conectado Va";
                    lblConexion.ForeColor = Color.DarkGreen;

                }
                catch (Exception e)
                {
                    lblConexion.Text = "Sin Conexion VA";
                    lblConexion.ForeColor = Color.Red;
                }

            }
            else if (tienda == "RENA")
            {
                try
                {
                    conex_traspasos = BDConexicon.RenaOpen();
                    selectDatos();
                    lblConexion.Text = "Conectado RE";
                    lblConexion.ForeColor = Color.DarkGreen;
                }
                catch (Exception e)
                {
                    lblConexion.Text = "Sin Conexion RE";
                    lblConexion.ForeColor = Color.Red;
                    limpiarTraspaso();
                }


            }
            else if (tienda == "VELAZQUEZ")
            {

                try
                {
                    conex_traspasos = BDConexicon.VelazquezOpen();
                    selectDatos();
                    lblConexion.Text = "Conectado VE";
                    lblConexion.ForeColor = Color.DarkGreen;
                }
                catch (Exception e)
                {
                    lblConexion.Text = "Sin Conexion VE";
                    lblConexion.ForeColor = Color.Red;
                    limpiarTraspaso();
                }

            }
            else if (tienda == "COLOSO")
            {

                try
                {
                    conex_traspasos = BDConexicon.ColosoOpen();
                    selectDatos();
                    lblConexion.Text = "Conectado CO";
                    lblConexion.ForeColor = Color.DarkGreen;
                }
                catch (Exception e)
                {
                    lblConexion.Text = "Sin Conexion CO";
                    lblConexion.ForeColor = Color.Red;
                    limpiarTraspaso();
                }

            }

            else if (tienda == "PREGOT")
            {

                try
                {
                    conex_traspasos = BDConexicon.Papeleria1Open();
                    selectDatos();
                    lblConexion.Text = "Conectado PA";
                    lblConexion.ForeColor = Color.DarkGreen;
                }
                catch (Exception e)
                {
                    lblConexion.Text = "Sin Conexion PA";
                    lblConexion.ForeColor = Color.Red;
                    limpiarTraspaso();
                }

            }

        }
        //########## CIERRE ############


        //========================================= LIMPIAR ===================================================
        public void limpiarTraspaso()
        {
            dgvTraspasos.Rows.Clear();
            dgvItem.Rows.Clear();
            txtId.Text = "";
            txtFecha.Text = "";
            txtUsuario.Text = "";
            txtEstatus.Text = "";
            txtOrigen.Text = "";
            txtDestino.Text = "";
            txtMotivo.Text = "";
            txtObservaciones.Text = "";
            lblUsuarioAplica.Text = "";
        }
        //########## CIERRE ############

        //################################################## SELECCIONA LOS TRASPASOS DE LA TIENDA ORIGEN ##############################################################
        public void selectDatos()
        {




            DateTime Finicio = dtInicio.Value;
            DateTime Ffin = dtFin.Value;

            string inicio = getDate(Finicio);
            string fin = getDate(Ffin);



            MySqlCommand cmd = new MySqlCommand("SELECT rd_traspaso.idtraspaso,rd_traspaso.estatus FROM rd_traspaso   where rd_traspaso.fecha between '" + inicio + "'" + " and '" + fin + "' ", conex_traspasos);

            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();

            lblConexion.Text = "Conectado";
            lblConexion.ForeColor = Color.DarkGreen;

            adaptador.Fill(dt);

            dgvTraspasos.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dgvTraspasos.Rows.Add();

                dgvTraspasos.Rows[n].Cells[0].Value = item["idtraspaso"].ToString();
                dgvTraspasos.Rows[n].Cells[1].Value = item["estatus"].ToString();

            }

            conex_traspasos.Close();


           

        }
        //########## CIERRE ############

        public void consultaTraspaso()
        {
            for(int i = 0; i <= dgvTraspasos.Rows.Count-1; i++)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT SUM(rd_traspaso_articulos.cantidad * COSTO_U) AS total FROM rd_traspaso_articulos " +
                    "INNER JOIN prods ON rd_traspaso_articulos.articulo = prods.ARTICULO WHERE rd_traspaso_articulos.fk_idtraspaso = " + dgvTraspasos.Rows[i].Cells[0].Value.ToString()+"'", conex_traspasos);
                MySqlDataReader mdr;
                mdr = cmd.ExecuteReader();

                if (mdr.Read())
                {
                   
                    dgvTraspasos.Rows[i].Cells[2].Value = mdr.GetString("total");
                }

                    //MessageBox.Show(dgvTraspasos.Rows[i].Cells[0].Value.ToString());

            }

        }







        internal static String getDate(DateTime now)
        {
            String datePatt = @"yyyy-MM-dd";
            String snow = now.ToString(datePatt);
            return snow;
        }

        private void dgvTraspasos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //try
            //{

            string idTraspaso = dgvTraspasos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (cbTienda.Text == "BODEGA")
            {
                conex_datostraspaso = BDConexicon.BodegaOpen();
                selectDatosTraspaso(idTraspaso);
                itemTraspaso(idTraspaso);
                conex_datostraspaso.Close();
            }
            else if (cbTienda.Text == "VALLARTA")
            {
                conex_datostraspaso = BDConexicon.VallartaOpen();
                selectDatosTraspaso(idTraspaso);
                itemTraspaso(idTraspaso);
                conex_datostraspaso.Close();
            }
            else if (cbTienda.Text == "RENA")
            {
                conex_datostraspaso = BDConexicon.RenaOpen();
                selectDatosTraspaso(idTraspaso);
                itemTraspaso(idTraspaso);
                conex_datostraspaso.Close();
            }
            else if (cbTienda.Text == "VELAZQUEZ")
            {
                conex_datostraspaso = BDConexicon.VelazquezOpen();
                selectDatosTraspaso(idTraspaso);
                itemTraspaso(idTraspaso);
                conex_datostraspaso.Close();
            }
            else if (cbTienda.Text == "COLOSO")
            {
                conex_datostraspaso = BDConexicon.ColosoOpen();
                selectDatosTraspaso(idTraspaso);
                itemTraspaso(idTraspaso);
                conex_datostraspaso.Close();
            }
            else if (cbTienda.Text == "PREGOT")
            {
                conex_datostraspaso = BDConexicon.Papeleria1Open();
                selectDatosTraspaso(idTraspaso);
                itemTraspaso(idTraspaso);
                conex_datostraspaso.Close();
            }
            //SE USA
            //itemTraspaso(idTraspaso); 
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Seleccione un rango Valido");
            //}
        }
        //########## CIERRE ############

        //=========================================================== CABECERA DEL TRASPASO ==================================================
        public void selectDatosTraspaso(string idTraspaso)
        {
            //MySqlConnection conexion = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM rd_traspaso where idtraspaso=?idtraspaso", conex_datostraspaso);
            cmd.Parameters.Add("?idtraspaso", MySqlDbType.VarChar).Value = idTraspaso;
            MySqlDataReader mdr;
            mdr = cmd.ExecuteReader();

            if (mdr.Read())
            {
                txtId.Text = mdr.GetString("idtraspaso");
                txtFecha.Text = mdr.GetString("fecha").Split(' ')[0];
                txtUsuario.Text = mdr.GetString("usuario");
                txtEstatus.Text = mdr.GetString("estatus");
                txtOrigen.Text = defineTienda(mdr.GetString("origen"));
                txtDestino.Text = defineTienda(mdr.GetString("destino"));
                txtMotivo.Text = mdr.GetString("motivo");

                if (mdr.IsDBNull(7))
                {
                    txtObservaciones.Text = "";
                }
                else
                {
                    lblUsuarioAplica.Text = mdr.GetString("usuario_aplica");
                }


                if (mdr.IsDBNull(8))
                {
                    txtObservaciones.Text = "";
                }
                else
                {
                    txtObservaciones.Text = mdr.GetString("observacion_aplica");
                }



                if (mdr.IsDBNull(9))
                {
                    lblFechaAplicacion.Text = "";
                }
                else
                {
                    lblFechaAplicacion.Text = mdr.GetDateTime("fecha_aplica").ToShortDateString();
                }





                //try
                //{
                //    txtObservaciones.Text = mdr.GetString("observacion_aplica");
                //}
                //catch(Exception ex)
                //{
                //    txtObservaciones.Text = "";
                //}

                //if (string.IsNullOrEmpty( mdr.GetString("observacion_aplica")))
                //{
                //    txtObservaciones.Text = "";
                //}
                //else
                //{
                //    txtObservaciones.Text = mdr.GetString("observacion_aplica");
                //}

                //if (string.IsNullOrEmpty(mdr.GetString("fecha_aplica")))
                //{
                //    lblFechaAplicacion.Text = ""; ;
                //}
                //else
                //{
                //    lblFechaAplicacion.Text = mdr.GetString("fecha_aplica");
                //}

                //if ( string.IsNullOrEmpty(mdr.GetString("usuario_aplica")))
                //{
                //    lblUsuarioAplica.Text = "";
                //}
                //else
                //{

                //    lblUsuarioAplica.Text = mdr.GetString("usuario_aplica");
                //}
            }
            else
            {
                MessageBox.Show("No se encotro el articulo");
            }
            mdr.Close();

        }
        //########## CIERRE ############

        //======================================================== ITEM'S TRASPASO
        public void itemTraspaso(string idTraspaso)
        {





            MySqlCommand cmd = new MySqlCommand("SELECT * FROM rd_traspaso_articulos where fk_idtraspaso=?idtraspaso ", conex_datostraspaso);
            cmd.Parameters.Add("?idtraspaso", MySqlDbType.VarChar).Value = idTraspaso;
            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();

            adaptador.Fill(dt);

            dgvItem.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dgvItem.Rows.Add();

                dgvItem.Rows[n].Cells[0].Value = item["articulo"].ToString();
                dgvItem.Rows[n].Cells[1].Value = item["descripcion"].ToString();
                dgvItem.Rows[n].Cells[2].Value = item["cantidad"].ToString();

            }




        }
        //########## CIERRE ############


        public string defineTienda(string tienda)
        {

            if (tienda == "BO")
            {
                tienda = "BODEGA";
            }
            else if (tienda == "VA")
            {
                tienda = "VALLARTA";
            }
            else if (tienda == "RE")
            {
                tienda = "RENA";
            }
            else if (tienda == "VE")
            {
                tienda = "VELAZQUEZ";
            }
            else if (tienda == "CO")
            {
                tienda = "COLOSO";
            }
            else if (tienda == "PREGOT")
            {
                tienda = "PREGOT";
            }
            return tienda;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            consultaTraspaso();
        }
    }
}
