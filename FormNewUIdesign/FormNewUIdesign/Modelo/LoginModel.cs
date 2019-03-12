using FormNewUIdesign.Funciones;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

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
                                                " prf.nombre AS perfil,  " +
                                                " prf.id_perfil " +
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
                                objetoUsuario.id_perfil = reader["id_perfil"].ToString();
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


        public static string ObtenerRutaBaseIconos()
        {
            string ruta = "";
            try
            {
                using (MySqlConnection conn = ObtenerConexionBD())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = " SELECT valor FROM constantes WHERE nombre = 'ruta_iconos_sistema' ";

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ruta = reader["valor"].ToString();
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
                Message.ShowMessage("Error MySql", "LoginModel.cs -> ObtenerRutaBaseIconos() \n" + e.Message, Message.MessageType.error);
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Error MySql", "LoginModel.cs -> ObtenerRutaBaseIconos() \n" + e2.Message, Message.MessageType.error);
            }
            return ruta;
        }



        public static List<OpcionesMenu> ObtenerPermisos(string id_perfil)
        {
            OpcionesMenu objetoMenu;
            List<OpcionesMenu> lista = new List<OpcionesMenu>();
            try
            {
                using (MySqlConnection conn = ObtenerConexionBD())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = " SELECT " +
                                                " m.id_menu, " +
                                                " m.identificador, " +
                                                " m.nombre, " +
                                                " m.icono, " +
                                                " m.orden, " +
                                                " CASE WHEN (SELECT COUNT(1) FROM submenu WHERE id_menu = m.id_menu) > 0 THEN 1 ELSE 0 END tieneSubmenu " +
                                          " FROM menu AS m " +
                                          " INNER JOIN permisos AS p ON p.id_menu = m.id_menu " +
                                          " INNER JOIN perfiles AS pe ON pe.id_perfil = p.id_perfil " +
                                          " WHERE pe.id_perfil = @id_perfil " + 
                                          " ORDER BY m.orden ASC ";

                        cmd.Parameters.AddWithValue("@id_perfil", id_perfil);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                objetoMenu = new OpcionesMenu();
                                objetoMenu.texto = reader["nombre"].ToString();
                                objetoMenu.id = reader["identificador"].ToString();
                                objetoMenu.imagen = Mixin.VG.ruta_base_iconos + reader["icono"].ToString();
                                objetoMenu.orden = reader["orden"].ToString();
                                objetoMenu.tieneSubmenu = reader["tieneSubmenu"].ToString();
                                objetoMenu.identificador = reader["id_menu"].ToString();
                                objetoMenu.tipo = "menu";
                                lista.Add(objetoMenu);
                                if (Convert.ToInt32(objetoMenu.tieneSubmenu) > 0)
                                {
                                    List<OpcionesMenu> listaSubmenu = ObtenerSubMenu(objetoMenu.identificador);
                                    foreach (OpcionesMenu item in listaSubmenu)
                                    {
                                        lista.Add(item);
                                    }
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
                Message.ShowMessage("Error MySql", "LoginModel.cs -> ObtenerPermisos() \n" + e.Message, Message.MessageType.error);
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Error MySql", "LoginModel.cs -> ObtenerPermisos() \n" + e2.Message, Message.MessageType.error);
            }
            return lista;
        }


        public static List<OpcionesMenu> ObtenerSubMenu(string id_menu)
        {
            OpcionesMenu objetoMenu;
            List<OpcionesMenu> lista = new List<OpcionesMenu>();
            try
            {
                using (MySqlConnection conn = ObtenerConexionBD())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = " SELECT nombre, identificador, icono, orden FROM submenu WHERE id_menu = @id_menu ";

                        cmd.Parameters.AddWithValue("@id_menu", id_menu);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                objetoMenu = new OpcionesMenu();
                                objetoMenu.texto = reader["nombre"].ToString();
                                objetoMenu.id = reader["identificador"].ToString();
                                objetoMenu.imagen = Mixin.VG.ruta_base_iconos + reader["icono"].ToString();
                                objetoMenu.orden = reader["orden"].ToString();
                                objetoMenu.tipo = "submenu";
                                lista.Add(objetoMenu);
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
                Message.ShowMessage("Error MySql", "LoginModel.cs -> ObtenerSubMenu() \n" + e.Message, Message.MessageType.error);
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Error MySql", "LoginModel.cs -> ObtenerSubMenu() \n" + e2.Message, Message.MessageType.error);
            }
            return lista;
        }

    }
}
