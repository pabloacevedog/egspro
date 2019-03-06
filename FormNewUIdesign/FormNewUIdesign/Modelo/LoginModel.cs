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
                        cmd.CommandText = "SELECT password FROM usuarios WHERE username = @username";
                        cmd.Parameters.AddWithValue("@username", username);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                passwordBD = reader["password"].ToString();
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
                                                " usr.rut,  " +
                                                " usr.nombre,  " +
                                                " usr.apellidos,  " +
                                                " usr.username,  " +
                                                " usr.password,  " +
                                                " usr.telefono,  " +
                                                " usr.mail,  " +
                                                " usr.sexo,  " +
                                                " usr.edad,  " +
                                                " usr.imagen,  " +
                                                " prf.nombre AS perfil  " +
                                            " FROM usuarios AS usr  " +
                                            " INNER JOIN perfiles AS prf ON prf.id_perfil = usr.id_perfil  " +
                                            " WHERE username = @username " ;

                        cmd.Parameters.AddWithValue("@username", username);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                objetoUsuario.rut = reader["rut"].ToString();
                                objetoUsuario.nombre = reader["nombre"].ToString();
                                objetoUsuario.apellidos = reader["apellidos"].ToString();
                                objetoUsuario.username = reader["username"].ToString();
                                objetoUsuario.password = reader["password"].ToString();
                                objetoUsuario.telefono = reader["telefono"].ToString();
                                objetoUsuario.mail = reader["mail"].ToString();
                                objetoUsuario.sexo = reader["sexo"].ToString();
                                objetoUsuario.edad = reader["edad"].ToString();
                                objetoUsuario.img_perfil = reader["imagen"].ToString();
                                objetoUsuario.perfil = reader["perfil"].ToString();
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
