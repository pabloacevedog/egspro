using MySql.Data.MySqlClient;
using System;

namespace FormNewUIdesign
{
    public class ConexionMySql
    {
        public static MySqlConnection ObtenerConexionBD()
        {


            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "egis_db";

            MySqlConnection conn = new MySqlConnection(builder.ToString());
            try
            {
                conn.Open();
            }
            catch (MySqlException e)
            {
                Message.ShowMessage("Error MySql", "ConexionMySql.cs -> ObtenerConexionBD() \n" + e.Message, Message.MessageType.error);
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Error MySql", "ConexionMySql.cs -> ObtenerConexionBD() \n" + e2.Message, Message.MessageType.error);
            }
            return conn;

        }
    }
}
