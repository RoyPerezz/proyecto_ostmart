using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public static MySqlConnection conectar()
        {


            //Esto es una conexion lalalalalla

            MySqlConnection conVallarta = new MySqlConnection("server=192.168.1.2; database=MyBusinessDelta; Uid=root; pwd=;");
            conVallarta.Open();



            return conVallarta;

        }

        public static MySqlConnection VallartaOpen()
        {


            //Esto es una conexion lalalalalla

            MySqlConnection conVallarta = new MySqlConnection("server=192.168.1.2; database=MyBusinessDelta; Uid=root; pwd=;");
            conVallarta.Open();
           


            return conVallarta;

        }


        public static MySqlConnection RenaOpen()
        {

            MySqlConnection con = new MySqlConnection("server=192.168.2.2; database=MyBusinessDelta; Uid=root; pwd=;");
            con.Open();



            return con;

        }

        public static MySqlConnection VelazquezOpen()
        {

            MySqlConnection con = new MySqlConnection("server=192.168.4.2; database=MyBusinessDelta; Uid=root; pwd=;");
            con.Open();



            return con;

        }



        public static MySqlConnection ColosoOpen()
        {

            MySqlConnection con = new MySqlConnection("server=192.168.3.2; database=MyBusinessDelta; Uid=root; pwd=;");
            con.Open();



            return con;

        }

        public static MySqlConnection BodegaOpen()
        {

            MySqlConnection conBodega = new MySqlConnection("server=192.168.0.190; database=MyBusinessDelta; Uid=root; pwd=;");
            conBodega.Open();



            return conBodega;

        }

        public static MySqlConnection VallartaClose()
        {

            MySqlConnection conVallarta = new MySqlConnection("server=192.168.1.2; database=MyBusinessDelta; Uid=root; pwd=;");
            conVallarta.Close(); 



            return conVallarta;

        }

        public static MySqlConnection RenaClose()
        {

            MySqlConnection conVallarta = new MySqlConnection("server=192.168.2.2; database=MyBusinessDelta; Uid=root; pwd=;");
            conVallarta.Close();



            return conVallarta;

        }

        public static MySqlConnection VelazquezClose()
        {

            MySqlConnection conVallarta = new MySqlConnection("server=192.168.4.2; database=MyBusinessDelta; Uid=root; pwd=;");
            conVallarta.Close();



            return conVallarta;

        }

        public static MySqlConnection ColosoClose()
        {

            MySqlConnection conVallarta = new MySqlConnection("server=192.168.3.2; database=MyBusinessDelta; Uid=root; pwd=;");
            conVallarta.Close();



            return conVallarta;

        }

        public static MySqlConnection BodegaClose()
        {

            MySqlConnection conBodega = new MySqlConnection("server=192.168.0.190; database=MyBusinessDelta; Uid=root; pwd=;");
            conBodega.Close();



            return conBodega;

        }



    }
}
