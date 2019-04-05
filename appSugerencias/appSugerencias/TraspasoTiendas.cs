using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.Net;

namespace appSugerencias
{
    public partial class TraspasoTiendas : Form
    {
        string usuarioMyB;

        public TraspasoTiendas()
        {
            InitializeComponent();
        }

        public TraspasoTiendas(string usuario)
        {
            InitializeComponent();
            usuarioMyB = usuario;
            //lblUsuario.Text = usuarioMyB;
        }

        int idMovsinv;

        private void comboboxDepa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //################################################## RETORNA EL VALOR DE LA TIENDA ##############################################################
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
            return tienda;
        }
        public void CancelacionTraspaso(MySqlConnection conexionOpen)
        {
            //=================================================== ACTUALIZAR STATUS DEL TRASPASO ====================================================
            MySqlCommand ccmdRr = new MySqlCommand("UPDATE rd_traspaso SET estatus='CANCELADO' WHERE idtraspaso=?idtraspaso", conexionOpen);
            ccmdRr.Parameters.Add("?idtraspaso", MySqlDbType.VarChar).Value = txtId.Text;
            ccmdRr.ExecuteNonQuery();
            // BDConexicon.VallartaClose();

            BDConexicon.BodegaClose();
            BDConexicon.VallartaClose();
            BDConexicon.RenaClose();
            BDConexicon.VelazquezClose();
            BDConexicon.ColosoClose();
        }

        //################################################## METODO ALTA TRASPASO ##############################################################
        public void altaTraspaso(MySqlConnection conexionOpen)
        {
            int nItems = dgvItem.Rows.Count;
            string comando;
            int i = 0;
            List<string> itemArticulo = new List<string>();
            List<int> itemCantidad = new List<int>();
            List<int> itemExistencia = new List<int>();

            //=================================================== SELECCIONAR CONSECUTIVO BD DESTINO ====================================================
            MySqlCommand cmdr = new MySqlCommand("SELECT Consec FROM consec WHERE Dato='movsinv'", conexionOpen);
            MySqlDataReader mdrr;
            mdrr = cmdr.ExecuteReader();
            if (mdrr.Read())
            {
                idMovsinv = mdrr.GetInt32("Consec");

            }
            //BDConexicon.VelazquezClose();
            mdrr.Close();

            //=================================================== ACTUALIZAR  CONSECUTIVO BD ORIGEN ====================================================
            MySqlCommand cmdR = new MySqlCommand("UPDATE consec SET Consec=?Consec WHERE Dato='movsinv'", conexionOpen);
            cmdR.Parameters.Add("?Consec", MySqlDbType.VarChar).Value = idMovsinv + nItems;
            cmdR.ExecuteNonQuery();
            //BDConexicon.VelazquezClose();

            //=================================================== SELECCIONAR EXISTENCIA DE ITEM'S ====================================================
            for (i = 0; i < nItems; i++)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT EXISTENCIA  FROM  prods WHERE ARTICULO=?ARTICULO", conexionOpen);
                cmd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = dgvItem.Rows[i].Cells[0].Value.ToString();
                itemArticulo.Add(dgvItem.Rows[i].Cells[0].Value.ToString());
                itemCantidad.Add(Convert.ToInt32(dgvItem.Rows[i].Cells[2].Value.ToString()));
                MySqlDataReader mdr;
                mdr = cmd.ExecuteReader();

                while (mdr.Read())
                {

                    itemExistencia.Add(Convert.ToInt32(mdr["EXISTENCIA"].ToString()));

                }
                mdr.Close();
            }
           // BDConexicon.VelazquezClose();


            //=================================================== AFECTAR MOVIMIENTOS DEL INVENTARIO ====================================================
            comando = "INSERT INTO movsinv (consec, operacion, movimiento,ent_sal,tipo_movim,no_referen,articulo,f_movim,cantidad,existencia,almacen,exist_alm,usuario,usuhora,id_salida,id_entrada) values (?consec, ?operacion, ?movimiento,?ent_sal,?tipo_movim,?no_referen,?articulo,?f_movim,?cantidad,?existencia,?almacen,?exist_alm,?usuario,?usuhora,?id_salida,?id_entrada)";
            for (i = 0; i < nItems; i++)
            {
                idMovsinv = idMovsinv + 1;

                MySqlCommand cmd = new MySqlCommand(comando, conexionOpen);
                cmd.Parameters.Add("?consec", MySqlDbType.VarChar).Value = idMovsinv;
                cmd.Parameters.Add("?operacion", MySqlDbType.VarChar).Value = "EN";
                cmd.Parameters.Add("?movimiento", MySqlDbType.VarChar).Value = txtId.Text;
                cmd.Parameters.Add("?ent_sal", MySqlDbType.VarChar).Value = "E";
                cmd.Parameters.Add("?tipo_movim", MySqlDbType.VarChar).Value = "T+";
                cmd.Parameters.Add("?no_referen", MySqlDbType.VarChar).Value = txtId.Text;
                cmd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = itemArticulo[i].ToString(); ;

                cmd.Parameters.Add("?f_movim", MySqlDbType.Date).Value = DateTime.Now;

                cmd.Parameters.Add("?cantidad", MySqlDbType.Int32).Value = itemCantidad[i];
                cmd.Parameters.Add("?existencia", MySqlDbType.Int32).Value = itemExistencia[i] + itemCantidad[i];
                cmd.Parameters.Add("?almacen", MySqlDbType.VarChar).Value = "1";
                cmd.Parameters.Add("?exist_alm", MySqlDbType.Int32).Value = itemExistencia[i] + itemCantidad[i];

                cmd.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = usuarioMyB;
                cmd.Parameters.Add("?usuhora", MySqlDbType.VarChar).Value = "";

                cmd.Parameters.Add("?id_salida", MySqlDbType.VarChar).Value = "0";
                cmd.Parameters.Add("?id_entrada", MySqlDbType.VarChar).Value = txtId.Text;

                cmd.ExecuteNonQuery();

               // BDConexicon.VelazquezClose();

            }

            //=================================================== ACTUALIZAR EXISTENCIA DEL ALRTICULO ====================================================
            for (i = 0; i < nItems; i++)
            {
                MySqlCommand ccmdR = new MySqlCommand("UPDATE prods SET existencia=?existencia,alm1=?alm1 WHERE articulo=?articulo", conexionOpen);
                ccmdR.Parameters.Add("?existencia", MySqlDbType.Int32).Value = itemExistencia[i] + itemCantidad[i];
                ccmdR.Parameters.Add("?alm1", MySqlDbType.Int32).Value = itemExistencia[i] + itemCantidad[i];
                ccmdR.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = itemArticulo[i].ToString();
                ccmdR.ExecuteNonQuery();
                //BDConexicon.VelazquezClose();

            }


            BDConexicon.BodegaClose();
            BDConexicon.VallartaClose();
            BDConexicon.RenaClose();
            BDConexicon.VelazquezClose();
            BDConexicon.ColosoClose();



        }
        //########## CIERRE ############



        //################################################## METODO BAJA TRASPASO ##############################################################
        public void bajaTraspaso(MySqlConnection conexionOpen)
        {
            int nItems = dgvItem.Rows.Count;
            string comando;
            int i = 0;
            List<string> itemArticulo = new List<string>();
            List<int> itemCantidad = new List<int>();
            List<int> itemExistencia = new List<int>();
            
            //=================================================== SELECCIONAR CONSECUTIVO BD ORIGEN ====================================================
            MySqlCommand cmdr = new MySqlCommand("SELECT Consec FROM consec WHERE Dato='movsinv'", conexionOpen);
            MySqlDataReader mdrr;
            mdrr = cmdr.ExecuteReader();
            if (mdrr.Read())
            {
                idMovsinv = mdrr.GetInt32("Consec");

            }
            // BDConexicon.VallartaClose();
            mdrr.Close();

            //=================================================== ACTUALIZAR  CONSECUTIVO BD ORIGEN ====================================================
            MySqlCommand cmdR = new MySqlCommand("UPDATE consec SET Consec=?Consec WHERE Dato='movsinv'", conexionOpen);
            cmdR.Parameters.Add("?Consec", MySqlDbType.VarChar).Value = idMovsinv + nItems;
            cmdR.ExecuteNonQuery();
            
            //BDConexicon.VallartaClose();

            //=================================================== SELECCIONAR EXISTENCIA DE ITEM'S ====================================================
            for (i = 0; i < nItems; i++)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT EXISTENCIA  FROM  prods WHERE ARTICULO=?ARTICULO", conexionOpen);
                cmd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = dgvItem.Rows[i].Cells[0].Value.ToString();
                itemArticulo.Add(dgvItem.Rows[i].Cells[0].Value.ToString());
                itemCantidad.Add(Convert.ToInt32(dgvItem.Rows[i].Cells[2].Value.ToString()));
                MySqlDataReader mdr;
                mdr = cmd.ExecuteReader();

                while (mdr.Read())
                {
                   
                    itemExistencia.Add(Convert.ToInt32(mdr["EXISTENCIA"].ToString()));
                    
                }
                mdr.Close();
            }
           // BDConexicon.VallartaClose();


            //=================================================== AFECTAR MOVIMIENTOS DEL INVENTARIO ====================================================
            comando = "INSERT INTO movsinv (consec, operacion, movimiento,ent_sal,tipo_movim,no_referen,articulo,f_movim,cantidad,existencia,almacen,exist_alm,usuario,usuhora,id_salida,id_entrada) values (?consec, ?operacion, ?movimiento,?ent_sal,?tipo_movim,?no_referen,?articulo,?f_movim,?cantidad,?existencia,?almacen,?exist_alm,?usuario,?usuhora,?id_salida,?id_entrada)";
            for (i = 0; i < nItems; i++)
            {
                idMovsinv = idMovsinv + 1;

                MySqlCommand cmd = new MySqlCommand(comando, conexionOpen);
                cmd.Parameters.Add("?consec", MySqlDbType.VarChar).Value = idMovsinv;
                cmd.Parameters.Add("?operacion", MySqlDbType.VarChar).Value = "SA";
                cmd.Parameters.Add("?movimiento", MySqlDbType.VarChar).Value = txtId.Text;
                cmd.Parameters.Add("?ent_sal", MySqlDbType.VarChar).Value ="S";
                cmd.Parameters.Add("?tipo_movim", MySqlDbType.VarChar).Value = "T-";
                cmd.Parameters.Add("?no_referen", MySqlDbType.VarChar).Value = txtId.Text;
                cmd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = itemArticulo[i].ToString(); ;
            
                cmd.Parameters.Add("?f_movim", MySqlDbType.Date).Value = DateTime.Now;

                cmd.Parameters.Add("?cantidad", MySqlDbType.Int32 ).Value = itemCantidad[i];
                cmd.Parameters.Add("?existencia", MySqlDbType.Int32).Value = itemExistencia[i]-itemCantidad[i];
                cmd.Parameters.Add("?almacen", MySqlDbType.VarChar).Value = "1";
                cmd.Parameters.Add("?exist_alm", MySqlDbType.Int32).Value = itemExistencia[i] - itemCantidad[i];

                cmd.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = usuarioMyB;
                cmd.Parameters.Add("?usuhora", MySqlDbType.VarChar).Value = "";
                
                cmd.Parameters.Add("?id_salida", MySqlDbType.VarChar).Value = txtId.Text;
                cmd.Parameters.Add("?id_entrada", MySqlDbType.VarChar).Value = "0";
                
                cmd.ExecuteNonQuery();
                
                //BDConexicon.VallartaClose();

            }

            //=================================================== ACTUALIZAR EXISTENCIA DEL ALRTICULO ====================================================
            for (i = 0; i < nItems; i++)
            {
                MySqlCommand ccmdR = new MySqlCommand("UPDATE prods SET existencia=?existencia,alm1=?alm1 WHERE articulo=?articulo", conexionOpen);
                ccmdR.Parameters.Add("?existencia", MySqlDbType.Int32).Value = itemExistencia[i] - itemCantidad[i];
                ccmdR.Parameters.Add("?alm1", MySqlDbType.Int32).Value = itemExistencia[i] - itemCantidad[i];
                ccmdR.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = itemArticulo[i].ToString(); 
                ccmdR.ExecuteNonQuery();
                //BDConexicon.VallartaClose();

            }

            //=================================================== ACTUALIZAR STATUS DEL TRASPASO ====================================================
            MySqlCommand ccmdRr = new MySqlCommand("UPDATE rd_traspaso SET usuario_aplica=?usuario,estatus='APLICADO', observacion_aplica=?observaciones,fecha_aplica=?fecha_aplica WHERE idtraspaso=?idtraspaso", conexionOpen);
            ccmdRr.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = usuarioMyB;
            ccmdRr.Parameters.Add("?observaciones", MySqlDbType.VarChar).Value = txtObservaciones.Text.ToUpper();
            ccmdRr.Parameters.Add("?fecha_aplica", MySqlDbType.Date).Value = DateTime.Now;
            ccmdRr.Parameters.Add("?idtraspaso", MySqlDbType.VarChar).Value = txtId.Text;

            ccmdRr.ExecuteNonQuery();
           // BDConexicon.VallartaClose();

            BDConexicon.BodegaClose();
            BDConexicon.VallartaClose();
            BDConexicon.RenaClose();
            BDConexicon.VelazquezClose();
            BDConexicon.ColosoClose();
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

        //======================================================== ITEM'S TRASPASO
        public void itemTraspaso(string idTraspaso, MySqlConnection conexion)
        {


           


            MySqlCommand cmd = new MySqlCommand("SELECT * FROM rd_traspaso_articulos where fk_idtraspaso=?idtraspaso ", conexion);
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

            BDConexicon.BodegaClose();
            BDConexicon.VallartaClose();
            BDConexicon.RenaClose();
            BDConexicon.VelazquezClose();
            BDConexicon.ColosoClose();


        }
        //########## CIERRE ############

        //=========================================================== CABECERA DEL TRASPASO ==================================================
        public void selectDatosTraspaso(string idTraspaso, MySqlConnection conexion)
        {
            //MySqlConnection conexion = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM rd_traspaso where idtraspaso=?idtraspaso", conexion);
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
            BDConexicon.BodegaClose();
            BDConexicon.VallartaClose();
            BDConexicon.RenaClose();
            BDConexicon.VelazquezClose();
            BDConexicon.ColosoClose();
        }
        //########## CIERRE ############

        //################################################## SELECCIONA LOS TRASPASOS DE LA TIENDA ORIGEN ##############################################################
        public void selectDatos(MySqlConnection conexion)
        {

            

            
                DateTime Finicio = dtInicio.Value;
                DateTime Ffin = dtFin.Value;

                string inicio = getDate(Finicio);
                string fin = getDate(Ffin);


            
                MySqlCommand cmd = new MySqlCommand("SELECT rd_traspaso.idtraspaso,rd_traspaso.estatus FROM rd_traspaso   where rd_traspaso.fecha between '" + inicio + "'" + " and '" + fin + "' ", conexion);

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

                BDConexicon.BodegaClose();
                BDConexicon.VallartaClose();
                BDConexicon.RenaClose();
                 BDConexicon.VelazquezClose();
                BDConexicon.ColosoClose();

            
            
        }
        //########## CIERRE ############

        internal static String getDate(DateTime now)
        {
            String datePatt = @"yyyy-MM-dd";
            String snow = now.ToString(datePatt);
            return snow;
        }

        //######################## DEFINE LA CONSULTA DE LA TIENDA ORIGEN Y ENVIA LA CONEXION QUE CORRESPONDE ###########################################
        public void llamadaTiendas(string tienda)
        {
            

            limpiarTraspaso();
            // MessageBox.Show(cbTienda.Text);
            if (tienda == "BODEGA")
            {
                try
                {
                    selectDatos(BDConexicon.BodegaOpen());
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
                    selectDatos(BDConexicon.VallartaOpen());
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
                    selectDatos(BDConexicon.RenaOpen());
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
                    selectDatos(BDConexicon.VelazquezOpen());
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
                    selectDatos(BDConexicon.ColosoOpen());
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

        }
        //########## CIERRE ############

        private void button1_Click(object sender, EventArgs e)
        {

            llamadaTiendas(cbTienda.Text);

        }
        //########## CIERRE ############

        private void button2_Click(object sender, EventArgs e)
        {
            TextReader IP;
            IP = new StreamReader("IP.txt");
            string ipn = IP.ReadLine();
            MessageBox.Show(ipn);
            IP.Close();

        }
        //########## CIERRE ############

        //################################## DETERMINA EL ORIGEN DE LA TIENDA PARA LLAMAR A bajaTraspaso ###########################################
        public void  TiendaOrigen(string tienda)
        {
            if (tienda == "BODEGA")
            {
                bajaTraspaso(BDConexicon.BodegaOpen());
            }
            else if (tienda == "VALLARTA")
            {
                bajaTraspaso(BDConexicon.VallartaOpen() );
            }
            else if (tienda == "RENA")
            {
                bajaTraspaso(BDConexicon.RenaOpen() );
            }
            else if (tienda == "VELAZQUEZ")
            {
                bajaTraspaso(BDConexicon.VelazquezOpen() );
            }
            else if (tienda == "COLOSO")
            {
                bajaTraspaso(BDConexicon.ColosoOpen() );
            }


        }
        //########## CIERRE ############

        //################################## DETERMINA EL DESTINO DE LA TIENDA PARA LLAMAR A altaTraspaso ###########################################
        public void TiendaDestino(string tienda)
        {
            if (tienda == "BODEGA")
            {
                altaTraspaso(BDConexicon.BodegaOpen());
            }
            else if (tienda == "VALLARTA")
            {
                altaTraspaso(BDConexicon.VallartaOpen());
            }
            else if (tienda == "RENA")
            {
                
                altaTraspaso(BDConexicon.RenaOpen());
                
            }
            else if (tienda == "VELAZQUEZ")
            {
                altaTraspaso(BDConexicon.VelazquezOpen());
            }
            else if (tienda == "COLOSO")
            {
                altaTraspaso(BDConexicon.ColosoOpen());
            }


        }
        //########## CIERRE ############


        //################################################## CONSULTA EL TRASPASO AL QUE SE LE DIO DOBLE CLICK ##############################################################
        private void dgvTraspasos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //try
            //{

                string idTraspaso = dgvTraspasos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (cbTienda.Text == "BODEGA")
                {
                    selectDatosTraspaso(idTraspaso,BDConexicon.BodegaOpen());
                    itemTraspaso(idTraspaso, BDConexicon.BodegaOpen());
                    BDConexicon.BodegaClose();
                }
                else if (cbTienda.Text == "VALLARTA")
                {
                    selectDatosTraspaso(idTraspaso, BDConexicon.VallartaOpen());
                    itemTraspaso(idTraspaso,BDConexicon.VallartaOpen());
                    BDConexicon.VallartaClose();
                }
                else if (cbTienda.Text == "RENA")
                {
                    selectDatosTraspaso(idTraspaso, BDConexicon.RenaOpen());
                    itemTraspaso(idTraspaso, BDConexicon.RenaOpen());
                    BDConexicon.RenaClose();
                }
                else if (cbTienda.Text == "VELAZQUEZ")
                {
                    selectDatosTraspaso(idTraspaso, BDConexicon.VelazquezOpen());
                    itemTraspaso(idTraspaso, BDConexicon.VelazquezOpen());
                    BDConexicon.VelazquezClose();
                }
                else if (cbTienda.Text == "COLOSO")
                {
                    selectDatosTraspaso(idTraspaso, BDConexicon.ColosoOpen());
                    itemTraspaso(idTraspaso, BDConexicon.ColosoOpen());
                    BDConexicon.ColosoClose();
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

        //################################################## FORMATEA LA CELDA DEL GRID DE TRASPASOS ##############################################################
        private void dgvTraspasos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvTraspasos.Columns[e.ColumnIndex].Name == "status")
            {
                if (Convert.ToString(e.Value) == "APLICADO")
                {
                    e.CellStyle.BackColor = Color.LimeGreen;
                }
                if (Convert.ToString(e.Value) == "CANCELADO")
                {
                    e.CellStyle.BackColor = Color.LightCoral;
                }
            }
        }
        //########## CIERRE ############
        public Boolean CompruebaEnlaceTienda(string tienda)
        {
            Boolean flag=false;

            if (tienda == "BODEGA")
            {
                try
                {
                    BDConexicon.BodegaOpen();
                    BDConexicon.BodegaClose();
                    flag = true;
                }
                catch
                {
                    flag = false;
                }
            }
            else if (tienda == "VALLARTA")
            {
                try
                {
                    BDConexicon.VallartaOpen();
                    BDConexicon.VallartaClose();
                    flag = true;
                }
                catch
                {
                    flag = false;
                }

            }
            else if (tienda == "RENA")
            {
                try
                { 
                    BDConexicon.RenaOpen();
                    BDConexicon.RenaClose();
                    flag = true;
                }
                catch
                {
                    flag = false;
                }
                
            }
            else if (tienda == "VELAZQUEZ")
            {
                try
                {
                    BDConexicon.VelazquezOpen();
                    BDConexicon.VelazquezClose();
                    flag = true;
                }
                catch
                {
                    flag = false;
                }
            }
            else if (tienda == "COLOSO")
            {
                try
                {
                    BDConexicon.ColosoOpen();
                    BDConexicon.ColosoClose();
                    flag = true;
                }
                catch
                {
                    flag = false;
                }
            }

            return flag;
        }
        //################################################## APLICA EL TRASPASO ##############################################################
        private void button3_Click(object sender, EventArgs e)
        {
            
            if (txtOrigen.Text == "")
            {
                MessageBox.Show("Seleccione un Traspaso");
            }
            else if(txtEstatus.Text=="APLICADO" || txtEstatus.Text == "CANCELADO")
            {
                MessageBox.Show("El Estatus debe ser Solicitado");
            }
            else if(txtEstatus.Text=="SOLICITADO")
            {

                if (CompruebaEnlaceTienda(txtDestino.Text))
                {
                    TiendaOrigen(txtOrigen.Text);
                    TiendaDestino(txtDestino.Text);
                }
                else
                {
                    MessageBox.Show("Tienda destino No esta en linea!!!");
                }
                
                



                llamadaTiendas(cbTienda.Text);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Realmente desea cancelar el Traspaso","Cancelar Traspaso",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

            if(opcion== DialogResult.OK)
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("Seleccione un Traspaso");
                }
                else if(txtEstatus.Text == "APLICADO" || txtEstatus.Text == "CANCELADO")
                {
                    MessageBox.Show("El Estatus debe ser Solicitado");
                }
                else if (txtId.Text == "")
                {
                    MessageBox.Show("Seleccione un Traspaso!!!");
                }
                else if (txtEstatus.Text == "SOLICITADO")
                {


                    if (CompruebaEnlaceTienda(txtOrigen.Text))
                    {
                        TiendaCancelacion(txtOrigen.Text);
                        llamadaTiendas(cbTienda.Text);
                    }
                    else
                    {
                        MessageBox.Show("Tienda  No esta en linea!!!");
                    }
                }
                
            }
        }

        public void ImprimeReporte()
        {
            string id, usuario, usuario_aplic, fecha_sol, fecha_apli, origen, destino, motivo, observaciones, estatus;
            id = txtId.Text;
            usuario = txtUsuario.Text;
            origen = txtOrigen.Text;
            destino = txtDestino.Text;
            fecha_sol = txtFecha.Text;
            fecha_apli = lblFechaAplicacion.Text;
            motivo = txtMotivo.Text;
            estatus = txtEstatus.Text;
            usuario_aplic = lblUsuarioAplica.Text;

            observaciones = txtObservaciones.Text;
            try
            {
                Document doc = new Document(PageSize.A4);
                string filename = "TraspasosPDF\\TRASPASO " + id + " " + origen + ".pdf";
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@filename, FileMode.Create));

                doc.AddTitle("Prueba DaNxD");
                doc.AddCreator("DaN");

                // Abrimos el archivo
                doc.Open();

                iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                //######################################## ENCABEZADO ################################################################

                // Escribimos el encabezamiento en el documento
                Paragraph parrafoEnc = new Paragraph();
                parrafoEnc.Alignment = Element.ALIGN_CENTER;
                //parrafoEnc.Font = FontFactory.GetFont("Arial",14);
                parrafoEnc.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);

                Paragraph parrafo = new Paragraph();
                //parrafoEnc.Alignment = Element.ALIGN_CENTER;
                //parrafoEnc.Font = FontFactory.GetFont("Arial", 14);
                var normal = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                var negritas = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);



                parrafoEnc.Add("Traspaso de " + origen + " N. " + id);
                doc.Add(parrafoEnc);
                parrafoEnc.Clear();

                doc.Add(Chunk.NEWLINE);
                doc.Add(Chunk.NEWLINE);

                parrafo.Add(new Chunk("ID Traspaso: ", negritas));
                parrafo.Add(new Chunk(id, normal));
                doc.Add(parrafo);

                parrafo.Clear();


                parrafo.Add(new Chunk("Fecha de Creacion: ", negritas));
                parrafo.Add(new Chunk(fecha_sol, normal));
                doc.Add(parrafo);

                parrafo.Clear();

                parrafo.Add(new Chunk("Fecha de Aplicacion: ", negritas));
                parrafo.Add(new Chunk(fecha_apli, normal));
                doc.Add(parrafo);

                parrafo.Clear();

                parrafo.Add(new Chunk("Solicito: ", negritas));
                parrafo.Add(new Chunk(usuario, normal));
                doc.Add(parrafo);

                parrafo.Clear();

                parrafo.Add(new Chunk("Origen: ", negritas));
                parrafo.Add(new Chunk(origen, normal));

                parrafo.Add("         ");
                parrafo.Add(new Chunk("Destino: ", negritas));
                parrafo.Add(new Chunk(destino, normal));

                doc.Add(parrafo);

                parrafo.Clear();

                parrafo.Add(new Chunk("Motivo: ", negritas));
                parrafo.Add(new Chunk(motivo, normal));
                doc.Add(parrafo);

                parrafo.Clear();

                parrafo.Add(new Chunk("Aplico: ", negritas));
                parrafo.Add(new Chunk(lblUsuarioAplica.Text, normal));
                doc.Add(parrafo);

                parrafo.Clear();

                parrafo.Add(new Chunk("Observaciones: ", negritas));
                parrafo.Add(new Chunk(observaciones, normal));
                doc.Add(parrafo);

                parrafo.Clear();

                parrafo.Add(new Chunk("Estado: ", negritas));
                parrafo.Add(new Chunk(estatus, normal));
                doc.Add(parrafo);

                parrafo.Clear();

                doc.Add(Chunk.NEWLINE);
                doc.Add(Chunk.NEWLINE);

                parrafoEnc.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                parrafoEnc.Add("ARTICULOS DEL TRASPASO");
                doc.Add(parrafoEnc);
                doc.Add(Chunk.NEWLINE);
                // PRUEBA DAN
                PdfPTable table = new PdfPTable(dgvItem.Columns.Count);

                table.WidthPercentage = 100;
                float[] widths = new float[] { 30f, 100f, 30f };
                table.SetWidths(widths);
                table.SkipLastFooter = true;
                table.SpacingAfter = 10;


                //Encabezados
                for (int j = 0; j < dgvItem.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(dgvItem.Columns[j].HeaderText));

                }

                //flag the first row as a header
                table.HeaderRows = 1;

                for (int i = 0; i < dgvItem.Rows.Count; i++)
                {
                    for (int k = 0; k < dgvItem.Columns.Count; k++)
                    {
                        if (dgvItem[k, i].Value != null)
                        {
                            table.AddCell(new Phrase(dgvItem[k, i].Value.ToString()));
                        }
                    }
                }

                doc.Add(table);


                doc.Close();
                writer.Close();

                Process prc = new System.Diagnostics.Process();
                prc.StartInfo.FileName = filename;
                prc.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar archivo PDF o el archivo ya esta abierto.");
            }

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtOrigen.Text == "")
            {
                MessageBox.Show("Seleccione un Traspaso");
            }
            else if (txtEstatus.Text == "CANCELADO")
            {
                MessageBox.Show("El Estatus debe ser APLICADO");
            }
            else if (txtEstatus.Text=="SOLICITADO" || txtEstatus.Text == "APLICADO")
            {

                ImprimeReporte();           
            }
        }


        private void TraspasoTiendas_Load(object sender, EventArgs e)
        {

         
        }

        public void TiendaCancelacion(string tienda)
        {
            if (tienda == "BODEGA")
            {
                CancelacionTraspaso(BDConexicon.BodegaOpen());
            }
            else if (tienda == "VALLARTA")
            {
                CancelacionTraspaso(BDConexicon.VallartaOpen());
            }
            else if (tienda == "RENA")
            {
                CancelacionTraspaso(BDConexicon.RenaOpen());
            }
            else if (tienda == "VELAZQUEZ")
            {
                CancelacionTraspaso(BDConexicon.VelazquezOpen());
            }
            else if (tienda == "COLOSO")
            {
                CancelacionTraspaso(BDConexicon.ColosoOpen());
            }


        }
        //########## CIERRE ############

        private void button5_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(usuarioMyB);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //string host = Dns.GetHostName();
            //IPAddress[] ip = Dns.GetHostAddresses(host);
            //for(int i = 0; i < ip.Count(); i++)
            //{
            //    MessageBox.Show(ip[i].ToString());
            //}
            
        }
        //########## CIERRE ############
    }
    //########## CIERRE ############
}
