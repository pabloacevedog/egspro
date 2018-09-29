using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace FormNewUIdesign.Modelo
{
    public class UsersModel : ConexionMySql
    {
        public static DataTable ObtenerUsuarios()
        {
            DataTable tabla = new DataTable();
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
                                                " prf.Nombre AS Perfil  " +
                                            " FROM usuarios AS usr  " +
                                            " INNER JOIN perfiles AS prf ON prf.id = usr.perfil  " +
                                            " ORDER BY usr.Nombre ASC ";

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            tabla.Load(reader);

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
                Message.ShowMessage("Error MySql", "UsersModel.cs -> ObtenerUsuarios() \n" + e.Message, Message.MessageType.error);
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Error MySql", "UsersModel.cs -> ObtenerUsuarios() \n" + e2.Message, Message.MessageType.error);
            }
            return tabla;
        }


        public static Dictionary<string, string> ObtenerPerfiles()
        {
            Dictionary<string, string> resultado = new Dictionary<string, string>();
            try
            {
                using (MySqlConnection conn = ObtenerConexionBD())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = " SELECT  " +
                                                " Id,  " +
                                                " Nombre  " +
                                            " FROM perfiles " +
                                            " ORDER BY Id ASC ";

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            resultado.Add("0", "Seleccione");
                            while (reader.Read())
                            {
                                resultado.Add(reader["Id"].ToString(), reader["Nombre"].ToString());
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
                Message.ShowMessage("Error MySql", "UsersModel.cs -> ObtenerPerfiles() \n" + e.Message, Message.MessageType.error);
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Error MySql", "UsersModel.cs -> ObtenerPerfiles() \n" + e2.Message, Message.MessageType.error);
            }
            return resultado;
        }

        public static int GuardarUsuario(ObjetoUsuario NuevoUsuario)
        {
            int retorno = 0;
            try
            {
                using (MySqlConnection conn = ObtenerConexionBD())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        using (MySqlTransaction tran = conn.BeginTransaction())
                        {
                            cmd.Transaction = tran;
                            cmd.CommandText = " INSERT INTO usuarios (Rut, Nombre, Apellidos, Username, Password, Telefono, Mail, Sexo, Edad, Imagen, Perfil) " + 
                                              " VALUES (@Rut, @Nombre, @Apellidos, @Username, @Password, @Telefono, @Mail, @Sexo, @Edad, @Imagen, @Perfil) ";

                            cmd.Parameters.AddWithValue("@Rut", NuevoUsuario.rut);
                            cmd.Parameters.AddWithValue("@Nombre", NuevoUsuario.nombre);
                            cmd.Parameters.AddWithValue("@Apellidos", NuevoUsuario.apellidos);
                            cmd.Parameters.AddWithValue("@Username", NuevoUsuario.username);
                            cmd.Parameters.AddWithValue("@Password", NuevoUsuario.password);
                            cmd.Parameters.AddWithValue("@Telefono", NuevoUsuario.telefono);
                            cmd.Parameters.AddWithValue("@Mail", NuevoUsuario.mail);
                            cmd.Parameters.AddWithValue("@Sexo", NuevoUsuario.sexo);
                            cmd.Parameters.AddWithValue("@Edad", NuevoUsuario.edad);
                            cmd.Parameters.AddWithValue("@Imagen", NuevoUsuario.img_perfil);
                            cmd.Parameters.AddWithValue("@Perfil", NuevoUsuario.perfil);

                            retorno = cmd.ExecuteNonQuery();
                            tran.Commit();
                        }
                        
                        cmd.Dispose();
                    }
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (MySqlException e)
            {
                Message.ShowMessage("Error MySql", "UsersModel.cs -> GuardarUsuario() \n" + e.Message, Message.MessageType.error);
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Error MySql", "UsersModel.cs -> GuardarUsuario() \n" + e2.Message, Message.MessageType.error);
            }
            return retorno;
        }


        public static int EliminarUsuario(string rut)
        {
            int retorno = 0;
            try
            {
                using (MySqlConnection conn = ObtenerConexionBD())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        using (MySqlTransaction tran = conn.BeginTransaction())
                        {
                            cmd.Transaction = tran;
                            cmd.CommandText = " DELETE FROM usuarios WHERE Rut = @Rut ";

                            cmd.Parameters.AddWithValue("@Rut", rut);

                            retorno = cmd.ExecuteNonQuery();
                            tran.Commit();
                        }

                        cmd.Dispose();
                    }
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (MySqlException e)
            {
                Message.ShowMessage("Error MySql", "UsersModel.cs -> EliminarUsuario() \n" + e.Message, Message.MessageType.error);
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Error MySql", "UsersModel.cs -> EliminarUsuario() \n" + e2.Message, Message.MessageType.error);
            }
            return retorno;
        }


        public static string ObtenerIdPerfil(string nombre)
        {
            string resultado = "";
            try
            {
                using (MySqlConnection conn = ObtenerConexionBD())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = " SELECT Id " +
                                            " FROM perfiles " +
                                            " WHERE nombre = @nombre ";

                        cmd.Parameters.AddWithValue("@nombre", nombre);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                resultado = reader["Id"].ToString();
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
                Message.ShowMessage("Error MySql", "UsersModel.cs -> ObtenerIdPerfil() \n" + e.Message, Message.MessageType.error);
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Error MySql", "UsersModel.cs -> ObtenerIdPerfil() \n" + e2.Message, Message.MessageType.error);
            }
            return resultado;
        }



        public static string ObtenerImagenPerfilUsuario(string rut)
        {
            string resultado = "";
            try
            {
                using (MySqlConnection conn = ObtenerConexionBD())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = " SELECT Imagen " +
                                            " FROM usuarios " +
                                            " WHERE rut = @rut ";

                        cmd.Parameters.AddWithValue("@rut", rut);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                resultado = reader["Imagen"].ToString();
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
                Message.ShowMessage("Error MySql", "UsersModel.cs -> ObtenerImagenPerfilUsuario() \n" + e.Message, Message.MessageType.error);
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Error MySql", "UsersModel.cs -> ObtenerImagenPerfilUsuario() \n" + e2.Message, Message.MessageType.error);
            }
            return resultado;
        }



        public static int ActualizarUsuario(ObjetoUsuario datosUsuario)
        {
            int retorno = 0;
            try
            {
                using (MySqlConnection conn = ObtenerConexionBD())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        using (MySqlTransaction tran = conn.BeginTransaction())
                        {
                            cmd.Transaction = tran;
                            cmd.CommandText = " UPDATE usuarios " + 
                                                " SET Nombre = @Nombre, " + 
                                                " Apellidos = @Apellidos, " + 
                                                " Username = @Username, " + 
                                                " Password = @Password, " + 
                                                " Telefono = @Telefono, " + 
                                                " Mail = @Mail, " +
                                                " Sexo = @Sexo, " +
                                                " Edad = @Edad, " +
                                                " Imagen = @Imagen, " +
                                                " Perfil = @Perfil " +
                                              " WHERE Rut = @Rut ";

                            cmd.Parameters.AddWithValue("@Rut", datosUsuario.rut);
                            cmd.Parameters.AddWithValue("@Nombre", datosUsuario.nombre);
                            cmd.Parameters.AddWithValue("@Apellidos", datosUsuario.apellidos);
                            cmd.Parameters.AddWithValue("@Username", datosUsuario.username);
                            cmd.Parameters.AddWithValue("@Password", datosUsuario.password);
                            cmd.Parameters.AddWithValue("@Telefono", datosUsuario.telefono);
                            cmd.Parameters.AddWithValue("@Mail", datosUsuario.mail);
                            cmd.Parameters.AddWithValue("@Sexo", datosUsuario.sexo);
                            cmd.Parameters.AddWithValue("@Edad", datosUsuario.edad);
                            cmd.Parameters.AddWithValue("@Imagen", datosUsuario.img_perfil);
                            cmd.Parameters.AddWithValue("@Perfil", datosUsuario.perfil);

                            retorno = cmd.ExecuteNonQuery();
                            tran.Commit();
                        }

                        cmd.Dispose();
                    }
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (MySqlException e)
            {
                Message.ShowMessage("Error MySql", "UsersModel.cs -> ActualizarUsuario() \n" + e.Message, Message.MessageType.error);
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Error MySql", "UsersModel.cs -> ActualizarUsuario() \n" + e2.Message, Message.MessageType.error);
            }
            return retorno;
        }


        public static string ObtenerDirectorioFotosPerfil()
        {
            string resultado = "";
            try
            {
                using (MySqlConnection conn = ObtenerConexionBD())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = " SELECT valor " +
                                            " FROM constantes " +
                                            " WHERE nombre = @nombre ";

                        cmd.Parameters.AddWithValue("@nombre", "ruta_fotos_perfil");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                resultado = reader["valor"].ToString();
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
                Message.ShowMessage("Error MySql", "UsersModel.cs -> ObtenerIdPerfil() \n" + e.Message, Message.MessageType.error);
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Error MySql", "UsersModel.cs -> ObtenerIdPerfil() \n" + e2.Message, Message.MessageType.error);
            }
            return resultado;
        }
    }
}
