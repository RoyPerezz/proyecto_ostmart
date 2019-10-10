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
    public partial class form_existXlinea : Form
    {
        public form_existXlinea()
        {
            InitializeComponent();
        }

        MySqlConnection conbodega;
        MySqlConnection convallarta;
        MySqlConnection conrena;
        MySqlConnection concoloso;
        MySqlConnection convelazquez;
        MySqlConnection conpregot;
        DataTable master;


        private void form_existXlinea_Load(object sender, EventArgs e)
        {
            llenaComboBox();
        }

        public void llenaComboBox()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM LINEAS", BDConexicon.BodegaOpen());
            MySqlDataAdapter mysqladap = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            mysqladap.Fill(dt);

            cbLinea.ValueMember = "linea";
            cbLinea.DisplayMember = "Descrip";
            cbLinea.DataSource = dt;

            //existenciaLinea();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string linea = cbLinea.SelectedValue.ToString(); 
            MessageBox.Show(cbLinea.SelectedValue.ToString());
        }

        public void existenciaLinea()
        {
            string comando = "SELECT articulo,descrip,existencia FROM prods WHERE linea='"+ cbLinea.SelectedValue.ToString()  + "' and EXISTENCIA > 1";
            try
            {
                DataTable dtBodega = new DataTable();
                DataTable dtVallarta = new DataTable();
                DataTable dtRena = new DataTable();
                DataTable dtColoso = new DataTable();
                DataTable dtVelazquez = new DataTable();
                DataTable dtPregot = new DataTable();

                try
                {

                    conbodega = BDConexicon.BodegaOpen();
                    MySqlCommand cmdBodega = new MySqlCommand(comando, conbodega);
                    MySqlDataAdapter adBodega = new MySqlDataAdapter(cmdBodega);
                    adBodega.Fill(dtBodega);


                }
                catch (Exception)
                {

                    //LB_estadoBodega.Text = "Sin Conexión";
                    //LB_estadoBodega.ForeColor = Color.Red;
                }

                try
                {
                    convallarta = BDConexicon.VallartaOpen();
                    MySqlCommand cmdVallarta = new MySqlCommand(comando, convallarta);

                    MySqlDataAdapter adVallarta = new MySqlDataAdapter(cmdVallarta);
                    adVallarta.Fill(dtVallarta);
                }
                catch (Exception)
                {
                    //LB_estadoVallarta.Text = "Sin Conexión";
                    //LB_estadoVallarta.ForeColor = Color.Red;
                }

                try
                {
                    conrena = BDConexicon.RenaOpen();
                    MySqlCommand cmdRena = new MySqlCommand(comando, conrena);
                    MySqlDataAdapter adRena = new MySqlDataAdapter(cmdRena);
                    adRena.Fill(dtRena);
                }
                catch (Exception)
                {
                    //LB_Rena.Text = "Sin Conexión";
                    //LB_Rena.ForeColor = Color.Red;
                }


                try
                {

                    convelazquez = BDConexicon.VelazquezOpen();
                    MySqlCommand cmdVelazquez = new MySqlCommand(comando, convelazquez);
                    MySqlDataAdapter adVelazquez = new MySqlDataAdapter(cmdVelazquez);

                    adVelazquez.Fill(dtVelazquez);

                }
                catch (Exception)
                {

                    //LB_Coloso.Text = "Sin Conexión";
                    //LB_Coloso.ForeColor = Color.Red;
                }

                try
                {


                    concoloso = BDConexicon.ColosoOpen();
                    MySqlCommand cmdColoso = new MySqlCommand(comando, concoloso);
                    MySqlDataAdapter adColoso = new MySqlDataAdapter(cmdColoso);
                    adColoso.Fill(dtColoso);

                }
                catch (Exception)
                {
                    //LB_estadoVelazquez.Text = "Sin Conexión";
                    //LB_estadoVelazquez.ForeColor = Color.Red;

                }

                try
                {


                    conpregot = BDConexicon.Papeleria1Open();
                    MySqlCommand cmdPregot = new MySqlCommand(comando, conpregot);
                    MySqlDataAdapter adColoso = new MySqlDataAdapter(cmdPregot);
                    adColoso.Fill(dtPregot);

                }
                catch (Exception)
                {
                    //LB_pregot.Text = "Sin Conexión";
                    //LB_pregot.ForeColor = Color.Red;


                }

                //Combinar los 5 DataTables en DataTable master1

                DataTable master1 = dtBodega.AsEnumerable()
                .Union(dtVallarta.AsEnumerable())
                .Union(dtRena.AsEnumerable())
                .Union(dtVelazquez.AsEnumerable())
                .Union(dtColoso.AsEnumerable()).Union(dtPregot.AsEnumerable()).Distinct(DataRowComparer.Default).CopyToDataTable<DataRow>();

                master = repetidos(master1, "articulo");//se llama al metodo repetidos para que elimine los regitros iguales

                //Agrego las columnas al DaTable donde se mostrarán las existencias de los productos en cada sucursal
                // master.DefaultView.ToTable(true, "articulo");


                master.Columns.Add("BODEGA", typeof(String));
                master.Columns.Add("VALLARTA", typeof(String));
                master.Columns.Add("RENA", typeof(String));
                master.Columns.Add("VELAZQUEZ", typeof(String));
                master.Columns.Add("COLOSO", typeof(String));
                master.Columns.Add("PREGOT", typeof(String));

                master.Columns.Remove("existencia");




                // se recorren los datatables con los registros de cada suc.
                RecorreBodega(dtBodega);
                RecorreVallarta(dtVallarta);
                RecorreRena(dtRena);
                RecorreVelazquez(dtVelazquez);
                RecorreColoso(dtColoso);
                RecorrerPregot(dtPregot);






                dgvLinea.DataSource = master;

                //DG_existencias.Columns["ARTICULO"].SortMode = DataGridViewColumnSortMode.NotSortable;
                //DG_existencias.Columns["DESCRIPCION"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvLinea.Columns["BODEGA"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvLinea.Columns["VALLARTA"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvLinea.Columns["RENA"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvLinea.Columns["COLOSO"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvLinea.Columns["VELAZQUEZ"].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvLinea.Columns["PREGOT"].SortMode = DataGridViewColumnSortMode.NotSortable;

                dgvLinea.Columns["DESCRIPCION"].Width = 375;

                dgvLinea.Columns[2].HeaderCell.Style.BackColor = Color.Aqua;
                dgvLinea.Columns[3].HeaderCell.Style.BackColor = Color.DarkSeaGreen;
                dgvLinea.Columns[4].HeaderCell.Style.BackColor = Color.DeepSkyBlue;
                dgvLinea.Columns[5].HeaderCell.Style.BackColor = Color.DodgerBlue;

                dgvLinea.Columns[6].HeaderCell.Style.BackColor = Color.LightBlue;





                conbodega.Close();
                convallarta.Close();
                conrena.Close();
                concoloso.Close();

                convelazquez.Close();
                conpregot.Close();




            }
            catch (Exception)
            {

            }


        }


        public void RecorreBodega(DataTable dtBodega)
        {
            try
            {
                foreach (DataRow row in master.Rows)
                {


                    string valor = row["articulo"].ToString();

                    foreach (DataRow row1 in dtBodega.Rows)
                    {

                        if (valor.Equals(row1["articulo"].ToString()))

                        {

                            row["BODEGA"] = row1["existencia"].ToString();
                        }

                    }


                }
            }
            catch (Exception ex)
            {


            }

        }

        public void RecorreVallarta(DataTable DTVallarta)
        {
            try
            {
                foreach (DataRow row in master.Rows)
                {
                    string valor = row["articulo"].ToString();

                    foreach (DataRow row1 in DTVallarta.Rows)
                    {

                        if (valor.Equals(row1["articulo"].ToString()))

                        {

                            row["VALLARTA"] = row1["existencia"].ToString();
                        }

                    }


                }
            }
            catch (Exception ex)
            {


            }

        }

        public void RecorreRena(DataTable DTrena)
        {
            try
            {
                foreach (DataRow row in master.Rows)
                {
                    string valor = row["articulo"].ToString();

                    foreach (DataRow row1 in DTrena.Rows)
                    {

                        if (valor.Equals(row1["articulo"].ToString()))

                        {

                            row["RENA"] = row1["existencia"].ToString();
                        }

                    }


                }
            }
            catch (Exception ex)
            {


            }

        }

        public void RecorreColoso(DataTable DTcoloso)
        {
            try
            {
                foreach (DataRow row in master.Rows)
                {
                    string valor = row["articulo"].ToString();

                    foreach (DataRow row1 in DTcoloso.Rows)
                    {

                        if (valor.Equals(row1["articulo"].ToString()))

                        {

                            row["COLOSO"] = row1["existencia"].ToString();
                        }

                    }


                }
            }
            catch (Exception ex)
            {


            }

        }

        public void RecorreVelazquez(DataTable DTvelazquez)
        {
            try
            {
                foreach (DataRow row in master.Rows)
                {
                    string valor = row["articulo"].ToString();

                    foreach (DataRow row1 in DTvelazquez.Rows)
                    {

                        if (valor.Equals(row1["articulo"].ToString()))

                        {

                            row["VELAZQUEZ"] = row1["existencia"].ToString();
                        }

                    }


                }
            }
            catch (Exception ex)
            {


            }

        }

        public void RecorrerPregot(DataTable DTpregot)
        {
            try
            {
                foreach (DataRow row in master.Rows)
                {


                    string valor = row["articulo"].ToString();

                    foreach (DataRow row1 in DTpregot.Rows)
                    {

                        if (valor.Equals(row1["articulo"].ToString()))

                        {

                            row["PREGOT"] = row1["existencia"].ToString();
                        }

                    }


                }
            }
            catch (Exception ex)
            {


            }

        }

        //Este método auxiliar ayuda a eliminar los productos repetidos retornando un datatable de productos sin repetir
        public DataTable repetidos(DataTable dtData, string sColumnName)
        {
            try
            {
                DataTable distintos = dtData.DefaultView.ToTable(true, sColumnName);
                DataTable dtNew = new DataTable();
                foreach (DataColumn dcName in dtData.Columns)
                {
                    dtNew.Columns.Add(new DataColumn(dcName.Caption, dcName.DataType));
                }

                foreach (DataRow drRow in distintos.Rows)
                {
                    dtNew.ImportRow(dtData.Select(sColumnName + " = '" + drRow[0] + "'")[0]);
                }
                return dtNew;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void cbLinea_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cbLinea_SelectedIndexChanged(object sender, EventArgs e)
        {
            existenciaLinea();
        }
    }
}
