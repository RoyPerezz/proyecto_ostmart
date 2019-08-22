using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace appSugerencias
{
    public partial class frm_Compras : Form
    {
        string Usuario;

        
        public frm_Compras()
        {
            InitializeComponent();
        }

        public frm_Compras(string usuario)
        {
            InitializeComponent();
            Usuario = usuario;
            
        }

        internal static String getDate(DateTime now)
        {
            String datePatt = @"yyyy-MM-dd";
            String snow = now.ToString(datePatt);
            return snow;
        }

        

        MySqlConnection conectar;
        double IVA = 1.16;
        int idMovsinv, idCompra, idPartcomp, idCuentasxPag, existenciaTotal, existenciaCompra, existenciaPrevia, itemsCompra, cantidadArticompra;
        double importeArticulo, IVAcompra, costoArticulo, importeCompra,importecompraSinIVA, TotalCompra;

        private void TBArchivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        string descripArtiCompra, lineaCompra,marcaCompra, fabricanteCompra, articuloCompra, idFabricante,impuesto;



        
        double impuestoCompra, costoArtiCompra, mayoreoArtiCompra, menudeoArtiCompra, descuento;
        



        private void button3_Click(object sender, EventArgs e)
        {
            string fecha = getDate(DateTime.Now);
            MessageBox.Show(fecha);
        }

        public void ElegirSucursar()
        {
            LBConexion.Text = "";
            try
            {

                conectar.Close();
            }
            catch (Exception ec)
            {

            }

            if (CBTienda.SelectedItem.Equals("BODEGA"))
                {
                    conectar = BDConexicon.BodegaOpen();
                    proveedores();
                }

                if (CBTienda.SelectedItem.Equals("RENA"))
                {
                    conectar = BDConexicon.RenaOpen();


                    proveedores();
                }

                if (CBTienda.SelectedItem.Equals("COLOSO"))
                {

                    conectar = BDConexicon.ColosoOpen();


                    proveedores();
                }

                if (CBTienda.SelectedItem.Equals("VELAZQUEZ"))
                {
                    conectar = BDConexicon.VelazquezOpen();
                    proveedores();
                }

                if (CBTienda.SelectedItem.Equals("VALLARTA"))
                {

                    conectar = BDConexicon.VallartaOpen();
                    proveedores();
                }

                if (CBTienda.SelectedItem.Equals("PREGOT"))
                {

                    conectar = BDConexicon.Papeleria1Open();
                    proveedores();
                }

        }

        public void proveedores()
        {


            try
            {

                MySqlCommand cmd = new MySqlCommand("SELECT nombre FROM proveed ORDER BY nombre ASC", conectar);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    LBConexion.ForeColor = Color.DarkGreen;
                    LBConexion.Text = "Conectado";
                    while (dr.Read())
                    {

                        CBFabricante.Items.Add(dr["nombre"].ToString());
                    }

                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                LBConexion.ForeColor = Color.Red;
                LBConexion.Text = "Sin Conexión";
            }
        }

        private void frm_Compras_Load(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CBFabricante.Items.Clear();
                ElegirSucursar();
                

            }
            catch (Exception ex)
            {

                LBConexion.ForeColor = Color.Red;
                LBConexion.Text = "Sin Conexión";
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog()==DialogResult.OK)
            {
                TBArchivo.Text = open.FileName;
            }

            CargarExcel();
            }
            catch(Exception ed)
            {
                MessageBox.Show("Error archivo de Excel / Cierre Archivo de Excel");
            }
        }

        public void CargarExcel()
        {
            string hoja = "Hoja1";
            string pathconn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + TBArchivo.Text + ";Extended Properties='Excel 12.0 Xml; HDR=YES;';";
            OleDbConnection conn = new OleDbConnection(pathconn);
            OleDbCommand oconn = new OleDbCommand("Select * from ["+ hoja +"$]", conn);
            conn.Open();

            OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            DataTable data = new DataTable();
            sda.Fill(data);
            DGCompra.DataSource = data;

            
        }

        

        //################################################## METODO CARGA COMPRA ##############################################################
        public void CargaCompra()
        {
            int nItems = DGCompra.Rows.Count;
            string comando;
            string Fecha = getDate(DateTime.Now);
            string Hora = DateTime.Now.ToString("hh:mm:ss");



            //####################################################### NO BORRAR ########################################

            //try
            //{
                //=================================================== MOVSINV ====================================================
                MySqlCommand cmdr = new MySqlCommand("SELECT Consec FROM consec WHERE Dato='movsinv'", conectar);
                MySqlDataReader mdrr;
                mdrr = cmdr.ExecuteReader();
                if (mdrr.Read())
                {
                    idMovsinv = mdrr.GetInt32("Consec");
                    idMovsinv = idMovsinv + 1;

                }

                mdrr.Close();



                MySqlCommand cmdc = new MySqlCommand("UPDATE consec SET Consec='" + (idMovsinv + DGCompra.Rows.Count) + "' WHERE Dato='movsinv'", conectar);
                cmdc.ExecuteNonQuery();

                //=================================================== COMPRA ====================================================
                MySqlCommand cmd_c = new MySqlCommand("SELECT Consec FROM consec WHERE Dato='Compra'", conectar);
                MySqlDataReader mdr_c;
                mdr_c = cmd_c.ExecuteReader();
                if (mdr_c.Read())
                {
                    idCompra = mdr_c.GetInt32("Consec");
                    idCompra = idCompra + 1;

                }

                mdr_c.Close();

                MySqlCommand cmdc2 = new MySqlCommand("UPDATE consec SET Consec='" + idCompra + "' WHERE Dato='Compra'", conectar);
                cmdc2.ExecuteNonQuery();

                //=================================================== PARTCOMP  ====================================================
                MySqlCommand cmdptc = new MySqlCommand("SELECT Consec FROM consec WHERE Dato='partcomp'", conectar);
                MySqlDataReader mdrptc;
                mdrptc = cmdptc.ExecuteReader();
                if (mdrptc.Read())
                {
                    idPartcomp = mdrptc.GetInt32("Consec");
                    idPartcomp = idPartcomp + 1;

                }

                mdrptc.Close();

                MySqlCommand cmdc3 = new MySqlCommand("UPDATE consec SET Consec='" + (idPartcomp + DGCompra.Rows.Count) + "' WHERE Dato='partcomp'", conectar);
                cmdc3.ExecuteNonQuery();

                //===================================================  CUENTAS X PAGAR ====================================================
                MySqlCommand cmdcpp = new MySqlCommand("SELECT Consec FROM consec WHERE Dato='cuenxpag'", conectar);
                MySqlDataReader mdrcpp;
                mdrcpp = cmdcpp.ExecuteReader();
                if (mdrcpp.Read())
                {
                    idCuentasxPag = mdrcpp.GetInt32("Consec");
                    idCuentasxPag = idCuentasxPag + 1;

                }

                mdrcpp.Close();

                MySqlCommand cmdc4 = new MySqlCommand("UPDATE consec SET Consec='" + idCuentasxPag + "' WHERE Dato='cuenxpag'", conectar);
                cmdc4.ExecuteNonQuery();


                //=================================================== INICIALIZAR VARIABLES DE LA COMPRA ====================================================




                if (string.IsNullOrEmpty(tbDescuento.Text))
                {
                    descuento = 0;

                }
                else
                {
                    descuento = Convert.ToInt32(tbDescuento.Text);
                }


                importeCompra = 0;
              importecompraSinIVA = 0;
             descuento = descuento * 0.01;
                itemsCompra = DGCompra.Rows.Count;

                MySqlCommand cmdpro = new MySqlCommand("SELECT PROVEEDOR FROM proveed WHERE NOMBRE='" + CBFabricante.Text + "'", conectar);
                MySqlDataReader mdrpro;
                mdrpro = cmdpro.ExecuteReader();
                if (mdrpro.Read())
                {
                    idFabricante = mdrpro.GetString("PROVEEDOR");

                }

                mdrpro.Close();
                //==============================================
                //  0-articulo
                //  1-desccripcion
                //  2-costo_u
                //  3-mayoreo
                //  4-menudeo
                //  5-IMPUESTO
                //  6-linea
                //  7-marca
                //  8-fabricante
                //  9-vallarta
                // 10-rena
                // 11-velazquez
                // 12-coloso
                // 13-bodega
                // 14-PREGOT
                //=============================================

                for (int i = 0; i < DGCompra.Rows.Count; i++)
                {
                    if (string.IsNullOrEmpty(DGCompra[0, i].Value.ToString()))
                    {
                        articuloCompra = "";
                    }
                    else
                    {
                        articuloCompra = DGCompra[0, i].Value.ToString();
                    }

                    if (string.IsNullOrEmpty(DGCompra[1, i].Value.ToString()))
                    {
                        descripArtiCompra = "";
                    }
                    else
                    {
                        descripArtiCompra = DGCompra[1, i].Value.ToString();
                    }


                    costoArtiCompra = Convert.ToDouble(DGCompra[2, i].Value);
                    costoArtiCompra = costoArtiCompra - (costoArtiCompra * descuento);
                    

                    mayoreoArtiCompra = Convert.ToDouble(DGCompra[3, i].Value);
                    

                    menudeoArtiCompra = Convert.ToDouble(DGCompra[4, i].Value);

                
                //revisa el impuesto no este en blanco

                if (string.IsNullOrEmpty(DGCompra[5, i].Value.ToString()))
                {
                    impuesto = "IVA";
                }
                else
                {
                    impuesto = DGCompra[5, i].Value.ToString();
                }

                // REVISAR ESTAS LINEAS DE CODIGO DAN
                    if (CBTienda.SelectedItem.Equals("BODEGA"))
                    {
                        if (string.IsNullOrEmpty(DGCompra[13, i].Value.ToString()))
                        {
                            existenciaCompra = 0;
                        }
                        else
                        {
                            existenciaCompra = Convert.ToInt32(DGCompra[13, i].Value);
                        }
                    }

                    if (CBTienda.SelectedItem.Equals("RENA"))
                    {
                        if (string.IsNullOrEmpty(DGCompra[10, i].Value.ToString()))
                        {
                            existenciaCompra = 0;
                        }
                        else
                        {
                            existenciaCompra = Convert.ToInt32(DGCompra[10, i].Value);
                        }
                    }

                    if (CBTienda.SelectedItem.Equals("COLOSO"))
                    {
                        if (string.IsNullOrEmpty(DGCompra[12, i].Value.ToString()))
                        {
                            existenciaCompra = 0;
                        }
                        else
                        {
                            existenciaCompra = Convert.ToInt32(DGCompra[12, i].Value);
                        }
                    }

                    if (CBTienda.SelectedItem.Equals("VELAZQUEZ"))
                    {
                        if (string.IsNullOrEmpty(DGCompra[11, i].Value.ToString()))
                        {
                            existenciaCompra = 0;
                        }
                        else
                        {
                            existenciaCompra = Convert.ToInt32(DGCompra[11, i].Value);
                        }
                    }

                    if (CBTienda.SelectedItem.Equals("VALLARTA"))
                    {

                        if (string.IsNullOrEmpty(DGCompra[9, i].Value.ToString()))
                        {
                            existenciaCompra = 0;
                        }
                        else
                        {
                            existenciaCompra = Convert.ToInt32(DGCompra[9, i].Value);
                        }
                    }

                if (CBTienda.SelectedItem.Equals("PREGOT"))
                {

                    if (string.IsNullOrEmpty(DGCompra[14, i].Value.ToString()))
                    {
                        existenciaCompra = 0;
                    }
                    else
                    {
                        existenciaCompra = Convert.ToInt32(DGCompra[14, i].Value);
                    }
                }

                if (string.IsNullOrEmpty(DGCompra[6, i].Value.ToString()))
                    {
                        lineaCompra = "SYS";
                    }
                    else
                    {
                        lineaCompra = DGCompra[6, i].Value.ToString();
                    }

                    if (string.IsNullOrEmpty(DGCompra[7, i].Value.ToString()))
                    {
                        marcaCompra = "SYS";
                    }
                    else
                    {
                        marcaCompra = DGCompra[7, i].Value.ToString();
                    }

                    if (string.IsNullOrEmpty(DGCompra[8, i].Value.ToString()))
                    {
                        fabricanteCompra = "SYS";
                    }
                    else
                    {
                        fabricanteCompra = DGCompra[8, i].Value.ToString();
                    }



                if (impuesto == "IVA" || impuesto == "iva")
                {
                    mayoreoArtiCompra = mayoreoArtiCompra / IVA;
                        menudeoArtiCompra = menudeoArtiCompra / IVA;

                        
                        costoArtiCompra = costoArtiCompra / IVA;
                }



                MySqlCommand cmdart = new MySqlCommand("SELECT EXISTENCIA FROM prods WHERE ARTICULO ='" + articuloCompra + "'", conectar);
                    MySqlDataReader mdrart;
                    mdrart = cmdart.ExecuteReader();


                    if (mdrart.Read())
                    {

                        existenciaPrevia = mdrart.GetInt32("EXISTENCIA");
                        importeArticulo = existenciaCompra * costoArtiCompra;
                        existenciaTotal = existenciaPrevia + existenciaCompra;
                        if (impuesto == "IVA" || impuesto == "iva")
                        {
                            importeCompra = importeCompra + importeArticulo;
                        }
                        else
                        {
                            importecompraSinIVA = importecompraSinIVA + importeArticulo;
                        }
                        

                        comando = "UPDATE prods SET EXISTENCIA='" + existenciaTotal + "', ALM1='" + existenciaTotal + "',DESCRIP='" + descripArtiCompra + "',FABRICANTE='" + fabricanteCompra + "',COSTO_U='" + costoArtiCompra + "',PRECIO1='" + menudeoArtiCompra + "', PRECIO2='" + mayoreoArtiCompra + "', IMPUESTO='" + impuesto + "' WHERE ARTICULO='" + articuloCompra + "'";
                    }
                    else
                    {
                        existenciaPrevia = 0;
                        importeArticulo = existenciaCompra * costoArtiCompra;
                        existenciaTotal = existenciaPrevia + existenciaCompra;
                        if (impuesto == "IVA" || impuesto == "iva")
                        {
                            importeCompra = importeCompra + importeArticulo;
                        }
                        else
                        {
                            importecompraSinIVA = importecompraSinIVA + importeArticulo;
                        }

                    comando = "INSERT INTO prods (ARTICULO,LINEA,MARCA,FABRICANTE,UNIDAD,IMPUESTO,INVENT,PARAVENTA,EXISTENCIA,ALM1,DESCRIP,COSTO_U,PRECIO1,PRECIO2)" +
                            " VALUES('" + articuloCompra + "','" + lineaCompra + "','" + marcaCompra + "','" + fabricanteCompra + "','PZA','"+impuesto+"','1','1','" + existenciaTotal + "','" + existenciaTotal + "','" + descripArtiCompra + "','" + costoArtiCompra + "','" + menudeoArtiCompra + "','" + mayoreoArtiCompra + "')";
                    }

                    mdrart.Close();

                    //################### EJECUTA INSERCCION O ACTUALIZACION EN PRODS #####################
                    MySqlCommand cmdprod = new MySqlCommand(comando, conectar);
                    cmdprod.ExecuteNonQuery();


                    //################## GUARDA EN PARTCOMP ##############################
                    comando = "INSERT INTO partcomp (COMPRA,TIPO_DOC,NO_REFEREN,ARTICULO,CANTIDAD,PRECIO,DESCUENTO,IMPUESTO,OBSERV,PARTIDA,ID_ENTRADA,Usuario,UsuFecha,UsuHora,PRCANTIDAD,PRDESCRIP) " +
                        "VALUES('" + idCompra + "','COM','" + idCompra + "','" + articuloCompra + "','" + existenciaCompra + "','" + costoArtiCompra + "','" + tbDescuento.Text + "','16','" + descripArtiCompra + "','0','" + idPartcomp + "','" + Usuario + "','" + Fecha + "','" + Hora + "','0','0')";

                    MySqlCommand cmdpart = new MySqlCommand(comando, conectar);
                    cmdpart.ExecuteNonQuery();



                    //################# GUARDAR EN MOVSINV #################################

                    comando = "INSERT INTO movsinv (CONSEC,OPERACION,MOVIMIENTO , ENT_SAL, TIPO_MOVIM, NO_REFEREN, ARTICULO, F_MOVIM,CANTIDAD,COSTO, EXISTENCIA, ALMACEN,EXIST_ALM,PRECIO_VTA, POR_COSTEA,Usuario,UsuFecha,UsuHora,ID_SALIDA,ID_ENTRADA) " +
                        "VALUES('" + idMovsinv + "','CO','" + idCompra + "','E','COM','" + idCompra + "','" + articuloCompra + "','" + Fecha + "','" + existenciaCompra + "','" + costoArtiCompra + "','" + existenciaTotal + "','1','" + existenciaTotal + "','" + costoArtiCompra + "','" + existenciaTotal + "','" + Usuario + "','" + Fecha + "','" + Hora + "','0','" + idPartcomp + "') ";

                    MySqlCommand cmdmov = new MySqlCommand(comando, conectar);
                    cmdmov.ExecuteNonQuery();




                    idMovsinv = idMovsinv + 1;

                    idPartcomp = idPartcomp + 1;

                }


                impuestoCompra = importeCompra * 0.16;
            
                TotalCompra = importeCompra + impuestoCompra+importecompraSinIVA;

                //########################### GENERAR COMPRA###############################

                comando = "INSERT INTO compras(COMPRA,TIPO_DOC,FACTURA,F_EMISION,F_VENC,PROVEEDOR,IMPORTE,DESCUENTO,IMPUESTO,COSTO,ALMACEN,ESTADO,OBSERV,TIPO_CAM,MONEDA,DESC1,DESC2,DESC3,DESC4,DESC5,DATOS,DESGLOSE,CUENXPAG,USUFECHA,USUHORA,vencimiento) " +
                    "VALUES('" + idCompra + "','COM','" + tbFactura.Text.ToUpper() + "','" + Fecha + "','" + Fecha + "','" + idFabricante + "','" + (importeCompra+importecompraSinIVA)  + "','" + tbDescuento.Text + "','" + impuestoCompra + "','0','1','CO','" + tbObservaciones.Text.ToUpper() + "','1','MN','MN','MN','MN','MN','MN','1','1','" + idCuentasxPag + "','" + Fecha + "','" + Hora + "','" + Fecha + "')";

                MySqlCommand cmdcom = new MySqlCommand(comando, conectar);
                cmdcom.ExecuteNonQuery();

                //######################### GUARDAR DATOS EN CUENXPAG ##############################
                comando = "INSERT INTO cuenxpag(CUENXPAG, PROVEEDOR, FECHA, TIPO_DOC, NO_REFEREN, FECHA_VENC, FACTURA, IMPORTE, MONEDA, SALDO, TIP_CAM, COMPRA, ESTADO, USUARIO, USUFECHA, USUHORA) " +
                    "VALUES('" + idCuentasxPag + "','" + idFabricante + "','" + Fecha + "','COM','" + idCompra + "','" + Fecha + "','" + tbFactura.Text.ToUpper() + "','" + TotalCompra + "','MN','" + TotalCompra + "','1','" + idCompra + "','P','" + Usuario + "','" + Fecha + "','" + Hora + "')";


                MySqlCommand cmdcuen = new MySqlCommand(comando, conectar);
                cmdcuen.ExecuteNonQuery();

                comando = "INSERT INTO cuenxpdet(CUENXPAG, PROVEEDOR, FECHA, TIPO_DOC, NO_REFEREN, Cargo_ab, IMPORTE,MONEDA, TIP_CAM,COMPRA, USUARIO, USUFECHA,USUHORA)" +
                    " VALUES('" + idCuentasxPag + "','" + idFabricante + "','" + Fecha + "','COM','" + tbFactura.Text.ToUpper() + "','C','" + TotalCompra + "','MN','1','" + idCompra + "','" + Usuario + "','" + Fecha + "','" + Hora + "')";

                MySqlCommand cmdpdet = new MySqlCommand(comando, conectar);
                cmdpdet.ExecuteNonQuery();



                if (CBTienda.SelectedItem.Equals("BODEGA"))
                {
                    lblBoId.Text = "-----";
                    lblBoImpor.Text = "-----";
                    lblProBo.Text = "-----";
                    lblBoId.Text = idCompra.ToString();
                    lblBoImpor.Text = TotalCompra.ToString();
                    lblProBo.Text = CBFabricante.Text;
                }

                if (CBTienda.SelectedItem.Equals("RENA"))
                {
                    lblReId.Text = "-----";
                    lblReImpor.Text = "-----";
                    lblProRe.Text = "-----";
                    lblReId.Text = idCompra.ToString();
                    lblReImpor.Text = TotalCompra.ToString();
                    lblProRe.Text = CBFabricante.Text;
                }

                if (CBTienda.SelectedItem.Equals("COLOSO"))
                {
                    lblCoId.Text = "-----";
                    lblCoImpor.Text = "-----";
                    lblProCo.Text = "-----";
                    lblCoId.Text = idCompra.ToString();
                    lblCoImpor.Text = TotalCompra.ToString();
                    lblProCo.Text = CBFabricante.Text;
                }

                if (CBTienda.SelectedItem.Equals("VELAZQUEZ"))
                {
                    lblVeId.Text = "-----";
                    lblVeImpor.Text = "-----";
                    lblProVe.Text = "-----";
                    lblVeId.Text = idCompra.ToString();
                    lblVeImpor.Text = TotalCompra.ToString();
                    lblProVe.Text = CBFabricante.Text;
                }

                if (CBTienda.SelectedItem.Equals("VALLARTA"))
                {
                    lblVaId.Text = "-----";
                    lblVaImpor.Text = "-----";
                    lblProVa.Text = "-----";
                    lblVaId.Text = idCompra.ToString();
                    lblVaImpor.Text = TotalCompra.ToString();
                    lblProVa.Text = CBFabricante.Text;

                }

                if (CBTienda.SelectedItem.Equals("PREGOT"))
                {
                    lblPaId.Text = "-----";
                    lblPaImpor.Text = "-----";
                    lblPaPro.Text = "-----";
                    lblPaId.Text = idCompra.ToString();
                    lblPaImpor.Text = TotalCompra.ToString();
                    lblPaPro.Text = CBFabricante.Text;

                }

            MessageBox.Show("Compra Registrada" + Environment.NewLine + "No. Compra: " + idCompra + Environment.NewLine + "Importe: " + TotalCompra);







                conectar.Close();
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Recargue la tienda");

            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(CBTienda.Text) )
            {

                MessageBox.Show("Seleccione una Tienda");
            }
            else if (string.IsNullOrEmpty(CBFabricante.Text))
            {

                MessageBox.Show("Seleccione una Proveedor");
            }
            else if (string.IsNullOrEmpty(tbFactura.Text))
            {
                MessageBox.Show("Especifique la Factura");
            }
            else if (string.IsNullOrEmpty(TBArchivo.Text))
            {
                MessageBox.Show("Cargue el archivo de excel");
            }
            else
            {
                
                CargaCompra();
                //MessageBox.Show(idMovsinv.ToString() + " + " + idCompra.ToString() + " + " + idPartcomp.ToString() + " + " + descuento.ToString());
            }
            
        }
        //########## CIERRE ############


    }
}
