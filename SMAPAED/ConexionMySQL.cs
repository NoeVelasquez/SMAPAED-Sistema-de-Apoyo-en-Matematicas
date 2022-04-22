using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace SMAPAED
{
    public class ConexionMySQL
    {
        static string conexionstring = "Server=localhost; Database=smapaed; User=root; port=3306; password=;";
        MySqlConnection con = new MySqlConnection(conexionstring);
        public int consultalogin(string usuario, string contraseña)
        {
            int count;
            con.Open();
            string Query = "Select count(*) from estudiante where usuario ='" + usuario + "' " +
                "and contraseña ='" + contraseña + "'";
            MySqlCommand cmd = new MySqlCommand(Query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return count;
        }
    }
}
