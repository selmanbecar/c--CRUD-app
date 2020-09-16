using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace InternetPaketi.myclass
{
    class DB
    {

        public MySqlConnection con;
        public DB()
        {
            string host = "localhost";
            string db = "paketi";
            string port = "3306";
            string user = "root";
            string pass = "";
            string connectionString;
            connectionString = "SERVER=" + host + ";" + "DATABASE=" +
           db + ";" + "UID=" + user + ";" + "PASSWORD=" + pass + ";";

            con = new MySqlConnection(connectionString);
        }



    }
    class CRUD : DB
    {
        public string ime { set; get; }
        public string prezime { set; get; }
        public string adresa { set; get; }
        public string ugovor { set; get; }
        public string brzina { set; get; }



        

        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();


        public void Create_data()
        {
            con.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO `model`( `ime`, `prezime`, `adresa`, `ugovor`, `brzina`) VALUES (@name,@surname,@adress,@contract,@fast)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = ime;
                cmd.Parameters.Add("@surname", MySqlDbType.VarChar).Value = prezime;
                cmd.Parameters.Add("@adress", MySqlDbType.VarChar).Value = adresa;
                cmd.Parameters.Add("@contract", MySqlDbType.VarChar).Value = ugovor;
                cmd.Parameters.Add("@fast", MySqlDbType.VarChar).Value = brzina;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Delate_data()
        {
            con.Open();
            using(MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM model WHERE ime=@name";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = ime;

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Read_data()
        {
            dt.Clear();
            string query = "SELECT * FROM `model`";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ds);
            dt = ds.Tables[0];
        }

    }


}
