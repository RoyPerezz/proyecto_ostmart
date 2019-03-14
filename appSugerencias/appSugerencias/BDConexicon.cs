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

        public static MySqlConnection conectar()
        {



            
            string IP = optieneIp();
            MySqlConnection con = new MySqlConnection("server="+IP+"; database=PRUEBA_SISTEMAS; Uid=root; pwd=;");
            con.Open();



            return con;

        }

        public static MySqlConnection VallartaOpen()
        {


            

            MySqlConnection conVallarta = new MySqlConnection("server=192.168.1.2; database=PRUEBA_SISTEMAS; Uid=root; pwd=;");
            conVallarta.Open();
           


            return conVallarta;

        }


        public static MySqlConnection RenaOpen()
        {

            MySqlConnection conRena = new MySqlConnection("server=192.168.2.2; database=PRUEB_SISTEMAS; Uid=root; pwd=;");
            conRena.Open();



            return conRena;

        }

        public static MySqlConnection VelazquezOpen()
        {

            MySqlConnection conVelazquez = new MySqlConnection("server=192.168.4.2; database=PRUEBA_SISTEMAS; Uid=root; pwd=;");
            conVelazquez.Open();



            return conVelazquez;

        }



        public static MySqlConnection ColosoOpen()
        {

            MySqlConnection conColoso = new MySqlConnection("server=192.168.3.2; database=PRUEBA_SISTEMAS; Uid=root; pwd=;");
            conColoso.Open();



            return conColoso;

        }

        public static MySqlConnection BodegaOpen()
        {

            MySqlConnection conBodega = new MySqlConnection("server=192.168.0.190; database=MyBusinessDelta; Uid=root; pwd=;");
            conBodega.Open();



            return conBodega;

        }

        public static MySqlConnection VallartaClose()
        {

            MySqlConnection conVallarta = new MySqlConnection("server=192.168.1.2; database=PRUEBA_SISTEMAS; Uid=root; pwd=;");
            conVallarta.Close(); 



            return conVallarta;

        }

        public static MySqlConnection RenaClose()
        {

            MySqlConnection conRena = new MySqlConnection("server=192.168.2.2; database=PRUEBA_SISTEMAS; Uid=root; pwd=;");
            conRena.Close();



            return conRena;

        }

        public static MySqlConnection VelazquezClose()
        {

            MySqlConnection conVelazquez = new MySqlConnection("server=192.168.4.2; database=PRUEBA_SISTEMAS; Uid=root; pwd=;");
            conVelazquez.Close();



            return conVelazquez;

        }

        public static MySqlConnection ColosoClose()
        {

            MySqlConnection conColoso = new MySqlConnection("server=192.168.3.2; database=PRUEBA_SISTEMAS; Uid=root; pwd=;");
            conColoso.Close();



            return conColoso;

        }

        public static MySqlConnection BodegaClose()
        {

            MySqlConnection conBodega = new MySqlConnection("server=192.168.0.190; database=MyBusinessDelta; Uid=root; pwd=;");
            conBodega.Close();



            return conBodega;

        }

        public static MySqlConnection ConectarClose()
        {
            string IP = optieneIp();
            MySqlConnection con = new MySqlConnection("server="+IP+"; database=PRUEBA_SISTEMAS; Uid=root; pwd=;");
            con.Close();



            return con;

        }


    }
}
