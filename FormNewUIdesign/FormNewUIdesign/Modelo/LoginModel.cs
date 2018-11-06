using MySql.Data.MySqlClient;
using System;

namespace FormNewUIdesign.Modelo
{
    public class LoginModel : ConexionMySql
    {
        public static bool Login(string username, string password)
        {
            string passwordBD = "";
            bool login = false;
            try
            {
                using (MySqlConnection conn = ObtenerConexionBD())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT Password FROM usuarios WHERE Username = @username";
                        cmd.Parameters.AddWithValue("@username", username);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                passwordBD = reader["Password"].ToString();
                            }

                            reader.Close();
                            reader.Dispose();
                        }
                        cmd.Dispose();
                    }
                    conn.Close();
                    conn.Dispose();
                }

                if (password.Equals(passwordBD))
                {
                    login = true;
                }
            }
            catch (MySqlException e)
            {
                Message.ShowMessage("Login (Error MySql)", e.Message, Message.MessageType.error);
                login = false;
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Login (Error MySql)", e2.Message, Message.MessageType.error);
                login = false;
            }
            return login;
        }

        public static ObjetoUsuario ObtenerDatosUsuario(string username)
        {
            ObjetoUsuario objetoUsuario = new ObjetoUsuario();
            try
            {
                using (MySqlConnection conn = ObtenerConexionBD())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = " SELECT  " +
                                                " usr.Rut,  " +
                                                " usr.Nombre,  " +
                                                " usr.Apellidos,  " +
                                                " usr.Username,  " +
                                                " usr.Password,  " +
                                                " usr.Telefono,  " +
                                                " usr.Mail,  " +
                                                " usr.Sexo,  " +
                                                " usr.Edad,  " +
                                                " usr.Imagen,  " +
                                                " prf.Nombre AS Perfil  " +
                                            " FROM usuarios AS usr  " +
                                            " INNER JOIN perfiles AS prf ON prf.Id_perfil = usr.Id_perfil  " +
                                            " WHERE Username = @username " ;

                        cmd.Parameters.AddWithValue("@username", username);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                objetoUsuario.rut = reader["Rut"].ToString();
                                objetoUsuario.nombre = reader["Nombre"].ToString();
                                objetoUsuario.apellidos = reader["Apellidos"].ToString();
                                objetoUsuario.username = reader["Username"].ToString();
                                objetoUsuario.password = reader["Password"].ToString();
                                objetoUsuario.telefono = reader["Telefono"].ToString();
                                objetoUsuario.mail = reader["Mail"].ToString();
                                objetoUsuario.sexo = reader["Sexo"].ToString();
                                objetoUsuario.edad = reader["Edad"].ToString();
                                objetoUsuario.img_perfil = reader["Imagen"].ToString();
                                objetoUsuario.perfil = reader["Perfil"].ToString();
                            }

                            reader.Close();
                            reader.Dispose();
                        }
                        cmd.Dispose();
                    }
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (MySqlException e)
            {
                Message.ShowMessage("Error MySql", "LoginModel.cs -> ObtenerDatosUsuario() \n" + e.Message, Message.MessageType.error);
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Error MySql", "LoginModel.cs -> ObtenerDatosUsuario() \n" + e2.Message, Message.MessageType.error);
            }
            return objetoUsuario;
        }
    }
}
