using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace appSugerencias
{
    class BDConexicon
    {
        MySqlConnection con;
        MySqlConnection conVallarta;
        MySqlConnection conRena;
        MySqlConnection conVelazquez;
        MySqlConnection conColoso;
        MySqlConnection conBodega;

        public static string optieneIp()
        {
            TextReader IP;
            IP = new StreamReader("IP.txt");
            string ipn = IP.ReadLine();
            IP.Close();
            return ipn;
        }

        public static string optieneIPPregot()
        {
            TextReader IP;
            IP = new StreamReader("IPPregot.txt");
            string ipn = IP.ReadLine();
            IP.Close();
            return ipn;
        }
        public static string optieneBd()
        {
            TextReader BD;
            BD = new StreamReader("BD.txt");
            string bdn = BD.ReadLine();
            BD.Close();
            return bdn;
        }

        public static MySqlConnection conectar()
        {




            string IP = optieneIp();
            string BD = optieneBd();
            MySqlConnection con = new MySqlConnection("server=" + IP + "; database=" + BD + "; Uid=root; pwd=;pooling = false; convert zero datetime=True;");
            con.Open();



            return con;

        }

        public static MySqlConnection VallartaOpen()
        {



            string BD = optieneBd();
            MySqlConnection conVallarta = new MySqlConnection("server=192.168.1.2; database=" + BD + "; Uid=root; pwd=;pooling = false; convert zero datetime=True;");
            conVallarta.Open();



            return conVallarta;

        }


        public static MySqlConnection RenaOpen()
        {

            string BD = optieneBd();
            MySqlConnection conRena = new MySqlConnection("server=192.168.2.2; database=" + BD + "; Uid=root; pwd=;pooling = false; convert zero datetime=True;");
            conRena.Open();



            return conRena;

        }

        public static MySqlConnection VelazquezOpen()
        {
            string BD = optieneBd();
            MySqlConnection conVelazquez = new MySqlConnection("server=192.168.4.2; database=" + BD + "; Uid=root; pwd=;pooling = false; convert zero datetime=True;");
            conVelazquez.Open();



            return conVelazquez;

        }



        public static MySqlConnection ColosoOpen()
        {

            string BD = optieneBd();
            MySqlConnection conColoso = new MySqlConnection("server=192.168.3.2; database=" + BD + "; Uid=root; pwd=;pooling = false; convert zero datetime=True;");
            conColoso.Open();

            return conColoso;


        }

        public static MySqlConnection BodegaOpen()
        {
           
                string BD = optieneBd();
                MySqlConnection conBodega = new MySqlConnection("server=192.168.0.190; database=" + BD + "; Uid=root; pwd=;pooling = false; convert zero datetime=True;");
                conBodega.Open();
           



            return conBodega;

        }

     



        public static MySqlConnection VallartaClose()
        {
            string BD = optieneBd();
            MySqlConnection conVallarta = new MySqlConnection("server=192.168.1.2; database=" + BD + "; Uid=root; pwd=;");
            conVallarta.Close(); 



            return conVallarta;

        }

    

        public static MySqlConnection RenaClose()
        {
            string BD = optieneBd();
            MySqlConnection conRena = new MySqlConnection("server=192.168.2.2; database=" + BD + "; Uid=root; pwd=;");
            conRena.Close();



            return conRena;

        }

        public static MySqlConnection VelazquezClose()
        {
            string BD = optieneBd();
            MySqlConnection conVelazquez = new MySqlConnection("server=192.168.4.2; database=" + BD + "; Uid=root; pwd=;");
            conVelazquez.Close();



            return conVelazquez;

        }

        public static MySqlConnection ColosoClose()
        {
            string BD = optieneBd();
            MySqlConnection conColoso = new MySqlConnection("server=192.168.3.2; database=" + BD + "; Uid=root; pwd=;");
            conColoso.Close();



            return conColoso;

        }

        public static MySqlConnection BodegaClose()
        {
            string BD = optieneBd();
            MySqlConnection conBodega = new MySqlConnection("server=192.168.0.190; database=" + BD + "; Uid=root; pwd=;");
            conBodega.Close();



            return conBodega;

        }

        public static MySqlConnection ConectarClose()
        {
            string IP = optieneIp();
            string BD = optieneBd();
            MySqlConnection con = new MySqlConnection("server="+IP+ "; database=" + BD + "; Uid=root; pwd=;");
            con.Close();



            return con;

        }

        //###################################### METODOS DE CONEXION A LAS VITRINAS ########################################################

        public static MySqlConnection V_vallarta()
        {


            string IP = optieneIp();
            string BD = optieneBd();
            MySqlConnection Vvallarta = new MySqlConnection("server=192.168.1.196; database=" + BD + "; Uid=root; pwd=;pooling = false; convert zero datetime=True;");
            Vvallarta.Open();



            return Vvallarta;

        }

        public static MySqlConnection V_rena()
        {


            //string IP = optieneIp();
            string BD = optieneBd();
            MySqlConnection Vrena = new MySqlConnection("server=192.168.2.3; database=" + BD + "; Uid=root; pwd=;pooling = false; convert zero datetime=True;");
            Vrena.Open();



            return Vrena;

        }

        public static MySqlConnection V_coloso()
        {


            string IP = optieneIp();
            string BD = optieneBd();
            MySqlConnection Vcoloso = new MySqlConnection("server=192.168.3.3; database=" + BD + "; Uid=root; pwd=;pooling = false; convert zero datetime=True;");
            Vcoloso.Open();



            return Vcoloso;

        }

        public static MySqlConnection V_velazquez()
        {


            string IP = optieneIp();
            string BD = optieneBd();
            MySqlConnection Vvelazquez = new MySqlConnection("server=192.168.4.3; database=" + BD + "; Uid=root; pwd=;pooling = false; convert zero datetime=True;");
            Vvelazquez.Open();



            return Vvelazquez;

        }


        //#################################################### PAPELERIA ##################################################################//

        public static MySqlConnection Papeleria1Open()
        {
            string BD = optieneBd();
            string IPP = optieneIPPregot();
            MySqlConnection conPapeleria1 = new MySqlConnection("server="+IPP+"; database=" + BD + "; Uid=root; pwd=;pooling = false; convert zero datetime=True;");
            conPapeleria1.Open();



            return conPapeleria1;

        }

        //################################## METODOS DE CONEXION A RESPALDOS ########################################################
 

        public static MySqlConnection RespaldoVA(string mes,int año)
        {
            string bd = "VALLARTA " + mes + " " + año;
            MySqlConnection conVallarta = new MySqlConnection("server=192.168.1.2; database=" + bd + "; Uid=root; pwd=;");
            conVallarta.Open();

            return conVallarta;

        }

        public static MySqlConnection RespaldoRE(string mes,int año)
        {
            string bd = "RENA " + mes + " " + año;
            MySqlConnection conRena = new MySqlConnection("server=192.168.2.2; database=" + bd + "; Uid=root; pwd=;");
            conRena.Open();

            return conRena;

        }

        public static MySqlConnection RespaldoCO(string mes,int año)
        {
            string bd = "COLOSO " + mes + " " + año;
            MySqlConnection conColoso = new MySqlConnection("server=192.168.3.2; database=" + bd + "; Uid=root; pwd=;");
            conColoso.Open();

            return conColoso;

        }

        public static MySqlConnection RespaldoVE(string mes,int año)
        {
            string bd = "DIEZ " + mes + " " + año;
            MySqlConnection conVelazquez = new MySqlConnection("server=192.168.4.2; database=" + bd + "; Uid=root; pwd=;");
            conVelazquez.Open();

            return conVelazquez;

        }

        public static MySqlConnection RespaldoPRE(string mes,int año)
        {
            string bd = "PREGOT " + mes + " " + año;
            MySqlConnection conPregot = new MySqlConnection("server=192.168.6.2; database=" + bd + "; Uid=root; pwd=;");
            conPregot.Open();

            return conPregot;

        }

        public static MySqlConnection Respconectar(string sucursal,string mes,int año)
        {




            string IP = optieneIp();
            string BD = optieneBd();
            MySqlConnection con = new MySqlConnection("server=" + IP + "; database="+sucursal+" "+mes+" "+año+"; Uid=root; pwd=;pooling = false; convert zero datetime=True;");
            con.Open();



            return con;

        }

    }
}
