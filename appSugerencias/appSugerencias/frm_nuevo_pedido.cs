using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace appSugerencias
{
    public partial class frm_nuevo_pedido : Form
    {
        string guia = "", nota = "", com_pago = "";
        string rutaDestino = "";
        public frm_nuevo_pedido()
        {
            InitializeComponent();
        }


        MySqlConnection Conex;

        public frm_nuevo_pedido(int x,string id)
        {
            byte urge=1;
            byte va=1, re=1, co=1, ve=1, pm=1;
            string proveed="";
         

            InitializeComponent();
            if (x==1)
            {
                //MessageBox.Show("Nuevo");
            }
            else
            {
                //MessageBox.Show("Actualizacion");

                //tbIdPedido.Enabled = false;
                //tbIdPedido.Text = VARIABLES.intpedido.ToString();
                //tbPedido.Text = VARIABLES.titulo_pedido;
                //tbArea.Text = VARIABLES.area.ToString();
                //cbProveedor.Text = VARIABLES.proveedor.ToString();
                //tbLink.Text = VARIABLES.link_pedido.ToString();
                //tbCotiz.Text = VARIABLES.cotiz.ToString();
                //tbGuia.Text = VARIABLES.guia.ToString();
                //tbNota.Text = VARIABLES.nota.ToString();
                //tbComPago.Text = VARIABLES.comprobante_pago;
                //tbTipoPago.Text = VARIABLES.tipo_pago;
                //tbFormaPago.Text = VARIABLES.forma_pago;
                //tbObservaciones.Text = VARIABLES.observaciones;

                Conex = BDConexicon.VallartaOpen();

                string comando = "SELECT * FROM rd_pedido WHERE id_pedido='"+id+"'";
                // MySqlCommand cmd = new MySqlCommand("SELECT rd_traspaso.idtraspaso,rd_traspaso.estatus FROM rd_pedido   where rd_traspaso.fecha between '" + inicio + "'" + " and '" + fin + "' ", conex_pedido);

                MySqlCommand cmd = new MySqlCommand(comando, Conex);


                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();

                //lblConexion.Text = "Conectado";
                //lblConexion.ForeColor = Color.DarkGreen;
               

                adaptador.Fill(dt);
             
                //dgvPedidos.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    //int n = dgvPedidos.Rows.Add();

                    tbIdPedido.Text = item["id_pedido"].ToString();
                    tbPedido.Text = item["titulo_pedido"].ToString();
                    tbArea.Text = item["area"].ToString();
                    proveed= item["proveedor"].ToString();
                  
                    tbLink.Text= item["link_pedido"].ToString();

                    link.Links.Add(0, 0, item["link_pedido"].ToString());

                    tbCotiz.Text = item["cotiz"].ToString();
                    tbGuia.Text = item["guia"].ToString();
                    tbNota.Text= item["nota"].ToString();
                    tbComPago.Text = item["comprobante_pago"].ToString();
                
                    urge = Convert.ToByte ( item["pago_urge"].ToString());
                    va = Convert.ToByte(item["va"].ToString());
                    re = Convert.ToByte(item["re"].ToString());
                    co = Convert.ToByte(item["co"].ToString());
                    ve = Convert.ToByte(item["vl"].ToString());
                    pm = Convert.ToByte(item["pm"].ToString());

                    tbTipoPago.Text = item["tipo_pago"].ToString();
                     tbFormaPago.Text= item["forma_pago"].ToString();
                    tbObservaciones.Text = item["observaciones"].ToString();
                   

                }

                
                MySqlCommand cm= new MySqlCommand("SELECT NOMBRE FROM proveed WHERE PROVEEDOR='"+proveed+"'", Conex);

                MySqlDataAdapter adaptador1 = new MySqlDataAdapter(cm);
                System.Data.DataTable dt1 = new System.Data.DataTable();

                adaptador1.Fill(dt1);

                foreach (DataRow item in dt1.Rows)
                {
                    tbProveedor.Text = item["NOMBRE"].ToString();
                }

                Conex.Close();
                cbProveedor.Visible = false;
                tbProveedor.Visible = true;
                tbProveedor.Enabled = false;
                link.Visible = true;

                if (va == 1)
                {
                    cBoxVa.Checked=true;
                }
                else
                {
                    cBoxVa.Checked = false;
                }

                if (re == 1)
                {
                    cBoxRe.Checked = true;
                }
                else
                {
                    cBoxRe.Checked = false;
                }

                if (co == 1)
                {
                    cBoxCo.Checked = true;
                }
                else
                {
                    cBoxCo.Checked = false;
                }

                if (ve == 1)
                {
                    cBoxVl.Checked = true;
                }
                else
                {
                    cBoxVl.Checked = false;
                }


                if (pm == 1)
                {
                    cBoxPm.Checked = true;
                }
                else
                {
                    cBoxPm.Checked = false;
                }

                if (urge == 1)
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
            Conex = BDConexicon.VallartaOpen();
            tbIdPedido.Enabled = false;
            llenaComboProveedor();
            llenaComboArea();
            Conex.Close();

        }
        

        public void llenaComboProveedor()
        {
            cbProveedor.DataSource = null;
            
         

            MySqlCommand cmd = new MySqlCommand("SELECT PROVEEDOR,NOMBRE FROM proveed ", Conex);
            MySqlDataAdapter mysqladap = new MySqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();

            mysqladap.Fill(dt1);

            cbProveedor.ValueMember = "PROVEEDOR";
            cbProveedor.DisplayMember = "NOMBRE";
            cbProveedor.DataSource = dt1;
            Conex.Close();
        }

        public void llenaComboArea()
        {
            cbLinea.DataSource = null;
          

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM rd_pedido_area", Conex);
            MySqlDataAdapter mysqladap = new MySqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();

            mysqladap.Fill(dt1);

            cbLinea.ValueMember = "idarea";
            cbLinea.DisplayMember = "area";
            cbLinea.DataSource = dt1;
            Conex.Close();
        }

      
        public void guardaDatos()
        {
            string comando;

            DateTime fecha = dtDia.Value;



            //MessageBox.Show(fecha.ToString("yyyy-MM-dd"));
            try
            {

                comando = "INSERT INTO rd_pedido (titulo_pedido,fecha,area,proveedor,link_pedido,estatus,cotiz,nota,guia,comprobante_pago,pago_urge,tipo_pago,forma_pago,observaciones,va,re,vl,co,pm) values (?titulo_pedido,?fecha,?area,?proveedor,?link_pedido,?estatus,?cotiz,?nota,?guia,?comprobante_pago,?pago_urge,?tipo_pago,?forma_pago,?observaciones,?va,?re,?vl,?co,?pm)";

              

                MySqlCommand cmd = new MySqlCommand(comando, Conex);
                cmd.Parameters.Add("?titulo_pedido", MySqlDbType.VarChar).Value = tbPedido.Text; ;
                cmd.Parameters.Add("?fecha", MySqlDbType.VarChar).Value = fecha.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("?area", MySqlDbType.VarChar).Value = tbArea.Text;
                cmd.Parameters.Add("?proveedor", MySqlDbType.VarChar).Value = cbProveedor.SelectedValue.ToString();
                cmd.Parameters.Add("?link_pedido", MySqlDbType.VarChar).Value = tbLink.Text;
                cmd.Parameters.Add("?estatus", MySqlDbType.VarChar).Value ="CREADO";
                cmd.Parameters.Add("?cotiz", MySqlDbType.VarChar).Value = tbCotiz.Text;
                cmd.Parameters.Add("?nota", MySqlDbType.VarChar).Value = tbNota.Text;
                cmd.Parameters.Add("?guia", MySqlDbType.VarChar).Value =guardaarchivos(tbGuia.Text,guia,1);
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

            limpiar();
        }

        public void actualizaDatos()
        {
            string comando;

            DateTime fecha = dtDia.Value;
            //MessageBox.Show(fecha.ToString("yyyy-MM-dd"));
            try
            {

                comando = "UPDATE rd_pedido SET titulo_pedido=?titulo_pedido,area=?area,link_pedido=?link_pedido,cotiz=?cotiz,nota=?nota,guia=?guia,comprobante_pago=?comprobante_pago,pago_urge=?pago_urge,tipo_pago=?tipo_pago,forma_pago=?forma_pago,observaciones=?observaciones,va=?va,re=?re,vl=?vl,co=?co,pm=?pm WHERE id_pedido='" + tbIdPedido.Text+"'";
                                                                                                                                                                                                         



                MySqlCommand cmd = new MySqlCommand(comando, Conex);
                cmd.Parameters.Add("?titulo_pedido", MySqlDbType.VarChar).Value = tbPedido.Text; ;
                //cmd.Parameters.Add("?fecha", MySqlDbType.VarChar).Value = fecha.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("?area", MySqlDbType.VarChar).Value = tbArea.Text;
                //cmd.Parameters.Add("?proveedor", MySqlDbType.VarChar).Value = cbProveedor.Text;
                cmd.Parameters.Add("?link_pedido", MySqlDbType.VarChar).Value = tbLink.Text;
                //cmd.Parameters.Add("?estatus", MySqlDbType.VarChar).Value = "CREADO";
                cmd.Parameters.Add("?cotiz", MySqlDbType.VarChar).Value = tbCotiz.Text;
                cmd.Parameters.Add("?nota", MySqlDbType.VarChar).Value = tbNota.Text;

                bool x = tbGuia.Text.Contains("192.168.");
                if (x)
                {
                    cmd.Parameters.Add("?guia", MySqlDbType.VarChar).Value = tbGuia.Text;

                }
                else
                {
                    cmd.Parameters.Add("?guia", MySqlDbType.VarChar).Value = guardaarchivos(tbGuia.Text, guia, 1);
                }
                
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

            limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbIdPedido.Text == "")
            {
                Conex = BDConexicon.VallartaOpen();
                guardaDatos();
                Conex.Close();
            }
            else
            {
                Conex = BDConexicon.VallartaOpen();
                actualizaDatos();
                Conex.Close();
            }
        }
        public void limpiar()
        {
            tbIdPedido.Text = "";
            tbPedido.Text = "";
            tbArea.Text = "";
            cbProveedor.Text = "";
            tbLink.Text = "";
            tbCotiz.Text = "";

            cBoxVa.Enabled = true;
            cBoxRe.Enabled = true;
            cBoxCo.Enabled = true;
            cBoxVl.Enabled = true;
            cBoxPm.Enabled = true;
            cBoxUrge.Enabled = true;

            tbGuia.Text = "";
            tbNota.Text = "";
            tbComPago.Text = "";
            tbTipoPago.Text = "";
            tbFormaPago.Text = "";
            tbObservaciones.Text = "";


        }

        private void tbLink_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 

            OpenFileDialog open = new OpenFileDialog();



                open.Filter = "IMAGE FILE | *.jpg|PDF FILE | *.pdf";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    tbGuia.Text = open.FileName;
                }
                guia = open.FileName.Substring(open.FileName.LastIndexOf("\\") + 1);

            }
            catch (Exception ed)
            {
                MessageBox.Show("Error" + ed.Message);
            }

    //try
    //{


    //    OpenFileDialog open = new OpenFileDialog();
    //    if (open.ShowDialog() == DialogResult.OK)
    //    {
    //        tbGuia.Text = open.FileName;
    //    }


    //    guia = open.FileName.Substring(open.FileName.LastIndexOf("\\") + 1);


    //}
    //catch (Exception ed)
    //{
    //    MessageBox.Show("Error" + ed.Message);
    //}
}

        public string  guardaarchivos(string origen ,string archivo,int x)
        {

            string nuevonombre = "";

            string carpeta = "";

            string pdf = "";

            string fileName;
            string fileName2;

            string fullPath;

            string sourcePath;
            string targetPath;

            string sourceFile;
            string destFile;

           
            targetPath = "\\\\192.168.1.2\\doc\\"+carpeta;
            nuevonombre = tbIdPedido.Text;

            if (!Directory.Exists(targetPath))
            {

                DirectoryInfo di = Directory.CreateDirectory(targetPath);
            }

            bool a = archivo.Contains(".jpg");
            bool b = archivo.Contains(".pdf");

            if (x == 1)
            {
                nuevonombre = nuevonombre + "-GUIA.pdf";
            }
            else if (x == 2)
            {
                nuevonombre = nuevonombre + "-NOTA.pdf";
            }
            else if (x == 3)
            {
                nuevonombre = nuevonombre + "-COMPAGO.pdf";
            }


            if (a)
            {
                pdf = "ManejoPDF\\"+nuevonombre;
                ConvertJPG2PDF(@origen, pdf);

                fileName = nuevonombre;
                //fileName2 = "p.pdf";
                fullPath = Path.GetFullPath(@"ManejoPDF");


                sourceFile = Path.Combine(fullPath, fileName);
                destFile = Path.Combine(targetPath, fileName);

                File.Copy(sourceFile, destFile, true);
            }
            if (b)
            {

                fullPath = Path.GetDirectoryName(tbGuia.Text);
                sourceFile = Path.Combine(fullPath, guia);
                destFile = Path.Combine(targetPath, nuevonombre);

                File.Copy(sourceFile, destFile, true);
            }

            return targetPath + nuevonombre;

            ////--------------------------------------------


            //string destino = "";
            //string nuevonombree = "";

            //bool a = false;
            //bool b = archivo.Contains(".pdf");

            //bool c = archivo.Contains(".jpeg");
            //bool d = archivo.Contains(".jfif");
            //bool e = archivo.Contains(".jpg");
            //bool f = archivo.Contains(".jpe");
            //bool g = archivo.Contains(".bmp");
            //bool h = archivo.Contains(".png");


            //if (c)
            //{
            //    a = true;
            //}
            //else if (d)
            //{
            //    a = true;
            //}
            //else if (e)
            //{
            //    a = true;
            //}
            //else if (f)
            //{
            //    a = true;
            //}
            //else if (g)
            //{
            //    a = true;
            //}
            //else if (h)
            //{
            //    a = true;
            //}



            //nuevonombre = tbIdPedido.Text;

            //try
            //{
            //    if (a)
            //    {
            //        destino = "\\\\192.168.0.190\\img\\";

            //        if (x == 1)
            //        {
            //            nuevonombre = nuevonombre + "-GUIA.jpg";
            //        }
            //        else if (x == 2)
            //        {
            //            nuevonombre = nuevonombre + "-NOTA.jpg";
            //        }
            //        else if (x == 3)
            //        {
            //            nuevonombre = nuevonombre + "-COMPAGO.jpg";
            //        }

            //    }
            //    else if (b)
            //    {
            //        destino = "\\\\192.168.0.190\\doc\\";

            //        if (x == 1)
            //        {
            //            nuevonombre = nuevonombre + "-GUIA.pdf";
            //        }
            //        else if (x == 2)
            //        {
            //            nuevonombre = nuevonombre + "-NOTA.pdf";
            //        }
            //        else if (x == 3)
            //        {
            //            nuevonombre = nuevonombre + "-COMPAGO.pdf";
            //        }
            //    }

            //    System.Diagnostics.Process proc = new System.Diagnostics.Process();
            //    proc.EnableRaisingEvents = false;
            //    proc.StartInfo.FileName = "cmd";
            //    proc.StartInfo.RedirectStandardInput = true;
            //    proc.StartInfo.RedirectStandardOutput = true;
            //    proc.StartInfo.CreateNoWindow = true;
            //    proc.StartInfo.UseShellExecute = false;
            //    proc.Start();
            //    proc.StandardInput.WriteLine(@"del " + destino + nuevonombre);
            //    proc.StandardInput.WriteLine(@"copy " + origen + " " + destino + archivo);
            //    proc.StandardInput.WriteLine(@"ren " + destino + archivo + " " + nuevonombre);
            //    proc.StandardInput.Flush();
            //    proc.StandardInput.Close();
            //    // MessageBox.Show("Se detuvo MySql");
            //    proc.Close();

            //    return destino + nuevonombre;

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //    return null;
            //}


        }


        private void button5_Click(object sender, EventArgs e)
        {
            cbProveedor.SelectedIndex =Convert.ToInt32( tbArea.Text.ToString());
           // MessageBox.Show(cbProveedor.SelectedValue.ToString() +" - "+ cbProveedor.SelectedItem.ToString() +" - "+cbProveedor.SelectedIndex.ToString() +"-"+cbProveedor.Items.Count);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {


                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.EnableRaisingEvents = false;
                proc.StartInfo.FileName = "cmd";
                proc.StartInfo.RedirectStandardInput = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.UseShellExecute = false;
                proc.Start();
                proc.StandardInput.WriteLine(@tbGuia.Text);
                proc.StandardInput.Flush();
                proc.StandardInput.Close();
                // MessageBox.Show("Se detuvo MySql");
                proc.Close();




            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {


                OpenFileDialog open = new OpenFileDialog();
                if (open.ShowDialog() == DialogResult.OK)
                {
                    tbGuia.Text = open.FileName;
                }


                guia = open.FileName.Substring(open.FileName.LastIndexOf("\\") + 1);

                ConvertJPG2PDF(guia, "prueba.pdf");
            }
            catch (Exception ed)
            {
                MessageBox.Show("Error" + ed.Message);
            }

        }
       
        void ConvertJPG2PDF(string jpgfile, string pdf)
        {
            var document = new Document(iTextSharp.text.PageSize.A4, 25, 25, 25, 25);
            
            using (var stream = new FileStream(pdf, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                PdfWriter.GetInstance(document, stream);
                document.Open();
                using (var imageStream = new FileStream(jpgfile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    var image = Image.GetInstance(imageStream);
                    if (image.Height > iTextSharp.text.PageSize.A4.Height - 25)
                    {
                        image.ScaleToFit(iTextSharp.text.PageSize.A4.Width - 25, iTextSharp.text.PageSize.A4.Height - 25);
                    }
                    else if (image.Width > iTextSharp.text.PageSize.A4.Width - 25)
                    {
                        image.ScaleToFit(iTextSharp.text.PageSize.A4.Width - 25, iTextSharp.text.PageSize.A4.Height - 25);
                    }
                    image.Alignment = iTextSharp.text.Image.ALIGN_MIDDLE;
                    document.Add(image);
                }

                document.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tbArea.Text == "")
            {
                tbArea.Text = cbLinea.Text;
            }
            else
            {
                tbArea.Text =  tbArea.Text+ " - "+ cbLinea.Text;
            }
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            }catch(Exception ex)
            {
                MessageBox.Show("Enlace No valido :" + ex.Message);
            }
        }
    }
}
