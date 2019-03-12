using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace FormNewUIdesign.Modelo
{
    public class UsersModel : ConexionMySql
    {
        public static List<ObjetoUsuario> ObtenerUsuarios()
        {
            List<ObjetoUsuario> lista = new List<ObjetoUsuario>();
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
                                                " CASE WHEN usr.sexo = 'F' THEN 'Femenino' ELSE 'Masculino' END sexo ,  " +
                                                " usr.edad,  " +
                                                " prf.nombre AS perfil  " +
                                            " FROM usuarios AS usr  " +
                                            " INNER JOIN perfiles AS prf ON prf.id_perfil = usr.id_perfil  " +
                                            " ORDER BY usr.nombre ASC ";

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ObjetoUsuario objetoUsuario = new ObjetoUsuario();
                                objetoUsuario.rut = reader["rut"].ToString();
                                objetoUsuario.nombre = reader["nombre"].ToString();
                                objetoUsuario.apellidos = reader["apellidos"].ToString();
                                objetoUsuario.username = reader["username"].ToString();
                                objetoUsuario.password = reader["password"].ToString();
                                objetoUsuario.telefono = reader["telefono"].ToString();
                                objetoUsuario.mail = reader["mail"].ToString();
                                objetoUsuario.sexo = reader["sexo"].ToString();
                                objetoUsuario.edad = reader["edad"].ToString();
                                objetoUsuario.perfil = reader["perfil"].ToString();

                                lista.Add(objetoUsuario);
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
                Message.ShowMessage("Error MySql", "UsersModel.cs -> ObtenerUsuarios() \n" + e.Message, Message.MessageType.error);
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Error MySql", "UsersModel.cs -> ObtenerUsuarios() \n" + e2.Message, Message.MessageType.error);
            }
            return lista;
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
                                                " id_perfil,  " +
                                                " nombre  " +
                                            " FROM perfiles " +
                                            " ORDER BY id_perfil ASC ";

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            resultado.Add("0", "Seleccione");
                            while (reader.Read())
                            {
                                resultado.Add(reader["id_perfil"].ToString(), reader["nombre"].ToString());
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
                            cmd.CommandText = " INSERT INTO usuarios (rut, nombre, apellidos, username, password, telefono, mail, sexo, edad, imagen, id_perfil) " +
                                              " VALUES (@Rut, @Nombre, @Apellidos, @Username, @Password, @Telefono, @Mail, @Sexo, @Edad, @Imagen, @Id_perfil) ";

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
                            cmd.Parameters.AddWithValue("@Id_perfil", NuevoUsuario.perfil);

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
                            cmd.CommandText = " DELETE FROM usuarios WHERE rut = @Rut ";

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
                        cmd.CommandText = " SELECT id_perfil " +
                                            " FROM perfiles " +
                                            " WHERE nombre = @nombre ";

                        cmd.Parameters.AddWithValue("@nombre", nombre);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                resultado = reader["id_perfil"].ToString();
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
                        cmd.CommandText = " SELECT imagen " +
                                            " FROM usuarios " +
                                            " WHERE rut = @rut ";

                        cmd.Parameters.AddWithValue("@rut", rut);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                resultado = reader["imagen"].ToString();
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
                                                " SET nombre = @Nombre, " +
                                                " apellidos = @Apellidos, " +
                                                " username = @Username, " +
                                                " password = @Password, " +
                                                " telefono = @Telefono, " +
                                                " mail = @Mail, " +
                                                " sexo = @Sexo, " +
                                                " edad = @Edad, " +
                                                " imagen = @Imagen, " +
                                                " id_perfil = @Id_perfil " +
                                              " WHERE rut = @Rut ";

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
                            cmd.Parameters.AddWithValue("@Id_perfil", datosUsuario.perfil);

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


        public static bool ExisteUsername(string username, string rut)
        {
            bool resultado = false;
            try
            {
                using (MySqlConnection conn = ObtenerConexionBD())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        if (rut != "")
                        {
                            cmd.CommandText = " SELECT COUNT(1) AS username " +
                                            " FROM usuarios " +
                                            " WHERE username = @username " +
                                            " AND rut <> @rut ";

                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@rut", rut);
                        }
                        else
                        {
                            cmd.CommandText = " SELECT COUNT(1) AS username " +
                                            " FROM usuarios " +
                                            " WHERE username = @username ";

                            cmd.Parameters.AddWithValue("@username", username);
                        }

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (Convert.ToInt32(reader["username"].ToString()) > 0)
                                {
                                    resultado = true;
                                }
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
                Message.ShowMessage("Error MySql", "UsersModel.cs -> ExisteUsername() \n" + e.Message, Message.MessageType.error);
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Error MySql", "UsersModel.cs -> ExisteUsername() \n" + e2.Message, Message.MessageType.error);
            }
            return resultado;
        }


        public static bool ExisteRut(string rut)
        {
            bool resultado = false;
            try
            {
                using (MySqlConnection conn = ObtenerConexionBD())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = " SELECT COUNT(1) AS rut " +
                                            " FROM usuarios " +
                                            " WHERE rut = @rut ";

                        cmd.Parameters.AddWithValue("@rut", rut);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (Convert.ToInt32(reader["rut"].ToString()) > 0)
                                {
                                    resultado = true;
                                }
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
                Message.ShowMessage("Error MySql", "UsersModel.cs -> ExisteRut() \n" + e.Message, Message.MessageType.error);
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Error MySql", "UsersModel.cs -> ExisteRut() \n" + e2.Message, Message.MessageType.error);
            }
            return resultado;
        }


        public static List<ObjetoUsuario> BuscarUsuarios(ObjetoUsuario filtros)
        {
            List<ObjetoUsuario> lista = new List<ObjetoUsuario>();
            try
            {
                using (MySqlConnection conn = ObtenerConexionBD())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        string query = " SELECT  " +
                                            " usr.rut,  " +
                                            " usr.nombre,  " +
                                            " usr.apellidos,  " +
                                            " usr.username,  " +
                                            " usr.password,  " +
                                            " usr.telefono,  " +
                                            " usr.mail,  " +
                                            " CASE WHEN usr.sexo = 'F' THEN 'Femenino' ELSE 'Masculino' END sexo ,  " +
                                            " usr.edad,  " +
                                            " prf.nombre AS perfil  " +
                                        " FROM usuarios AS usr  " +
                                        " INNER JOIN perfiles AS prf ON prf.id_perfil = usr.id_perfil  " +
                                        " WHERE 1 = 1 ";
                        if (filtros.rut != null && filtros.rut != "" && filtros.rut != "Ingrese rut")
                        {
                            query = query + " AND usr.rut LIKE '%" + filtros.rut + "%'";
                        }
                        if (filtros.nombre != null && filtros.nombre != "" && filtros.nombre != "Ingrese nombre")
                        {
                            query = query + " AND usr.nombre LIKE '%" + filtros.nombre + "%'";
                        }
                        if (filtros.apellidos != null && filtros.apellidos != "" && filtros.apellidos != "Ingrese apellido(s)")
                        {
                            query = query + " AND usr.apellidos LIKE '%" + filtros.apellidos + "%'";
                        }
                        if (filtros.mail != null && filtros.mail != "" && filtros.mail != "Ingrese correo")
                        {
                            query = query + " AND usr.mail LIKE '%" + filtros.mail + "%'";
                        }
                        if (filtros.username != null && filtros.username != "" && filtros.username != "Ingrese username")
                        {
                            query = query + " AND usr.username LIKE '%" + filtros.username + "%'";
                        }
                        if (filtros.id_perfil != null && filtros.id_perfil != "" && filtros.id_perfil != "0")
                        {
                            query = query + " AND usr.id_perfil = '" + filtros.id_perfil + "'";
                        }
                        if (filtros.sexo != null && filtros.sexo != "" && filtros.sexo != "0")
                        {
                            query = query + " AND usr.sexo ='" + filtros.sexo + "'";
                        }

                        query = query + " ORDER BY usr.nombre ASC ";

                        cmd.CommandText = query;

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ObjetoUsuario objetoUsuario = new ObjetoUsuario();
                                objetoUsuario.rut = reader["rut"].ToString();
                                objetoUsuario.nombre = reader["nombre"].ToString();
                                objetoUsuario.apellidos = reader["apellidos"].ToString();
                                objetoUsuario.username = reader["username"].ToString();
                                objetoUsuario.password = reader["password"].ToString();
                                objetoUsuario.telefono = reader["telefono"].ToString();
                                objetoUsuario.mail = reader["mail"].ToString();
                                objetoUsuario.sexo = reader["sexo"].ToString();
                                objetoUsuario.edad = reader["edad"].ToString();
                                objetoUsuario.perfil = reader["perfil"].ToString();

                                lista.Add(objetoUsuario);
                            }
                        }
                        cmd.Dispose();
                    }
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch (MySqlException e)
            {
                Message.ShowMessage("Error MySql", "UsersModel.cs -> BuscarUsuarios() \n" + e.Message, Message.MessageType.error);
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Error MySql", "UsersModel.cs -> BuscarUsuarios() \n" + e2.Message, Message.MessageType.error);
            }
            return lista;
        }
    }
}
