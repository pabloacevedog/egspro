using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormNewUIdesign.Modelo
{
    public class GruposModel : ConexionMySql
    {
        public static string GenerarIdentificadorGrupo()
        {
            string resultado = "";
            try
            {
                using (MySqlConnection conn = ObtenerConexionBD())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = " SELECT UUID_SHORT() AS codigo ";

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                resultado = reader["codigo"].ToString();
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
                Message.ShowMessage("Error MySql", "GruposModel.cs -> GenerarIdentificadorGrupo() \n" + e.Message, Message.MessageType.error);
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Error MySql", "GruposModel.cs -> GenerarIdentificadorGrupo() \n" + e2.Message, Message.MessageType.error);
            }
            return resultado;
        }


        public static string ObtenerIdEtapa(string nombreEtapa)
        {
            string resultado = "";
            try
            {
                using (MySqlConnection conn = ObtenerConexionBD())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = " SELECT id_etapa FROM etapas WHERE nombre = '" + nombreEtapa + "'";

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                resultado = reader["id_etapa"].ToString();
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
                Message.ShowMessage("Error MySql", "GruposModel.cs -> ObtenerIdEtapa() \n" + e.Message, Message.MessageType.error);
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Error MySql", "GruposModel.cs -> ObtenerIdEtapa() \n" + e2.Message, Message.MessageType.error);
            }
            return resultado;
        }


        public static Dictionary<string, string> ObtenerProyectos()
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
                                                " id_proyecto,  " +
                                                " nombre  " +
                                            " FROM proyectos " +
                                            " ORDER BY nombre ASC ";

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            resultado.Add("0", "Seleccione");
                            while (reader.Read())
                            {
                                resultado.Add(reader["id_proyecto"].ToString(), reader["nombre"].ToString());
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
                Message.ShowMessage("Error MySql", "GruposModel.cs -> ObtenerProyectos() \n" + e.Message, Message.MessageType.error);
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Error MySql", "GruposModel.cs -> ObtenerProyectos() \n" + e2.Message, Message.MessageType.error);
            }
            return resultado;
        }


        public static bool ExisteIdentificadorGrupo(string identificador)
        {
            bool resultado = false;
            try
            {
                using (MySqlConnection conn = ObtenerConexionBD())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = " SELECT  COUNT(1) AS total " +
                                            " FROM grupos " +
                                            " WHERE identificador = '" + identificador + "' ";

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (Convert.ToInt32(reader["total"].ToString()) > 0)
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
                Message.ShowMessage("Error MySql", "GruposModel.cs -> ExisteIdentificadorGrupo() \n" + e.Message, Message.MessageType.error);
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Error MySql", "GruposModel.cs -> ExisteIdentificadorGrupo() \n" + e2.Message, Message.MessageType.error);
            }
            return resultado;
        }


        public static int GuardarGrupo(ObjetoGrupo nuevoGrupo)
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
                            cmd.CommandText = " INSERT INTO grupos (identificador, nombre, razon_social, personalidad_juridica, nombre_presidente, contacto_presidente, id_proyecto) " +
                                              " VALUES (@Identificador, @Nombre, @Razon_social, @Personalidad_juridica, @Nombre_presidente, @Contacto_presidente, @Id_proyecto) ";

                            cmd.Parameters.AddWithValue("@Identificador", nuevoGrupo.Identificador);
                            cmd.Parameters.AddWithValue("@Nombre", nuevoGrupo.Nombre);
                            cmd.Parameters.AddWithValue("@Razon_social", nuevoGrupo.Razon_social);
                            cmd.Parameters.AddWithValue("@Personalidad_juridica", nuevoGrupo.Personalidad_juridica);
                            cmd.Parameters.AddWithValue("@Nombre_presidente", nuevoGrupo.Nombre_presidente);
                            cmd.Parameters.AddWithValue("@Contacto_presidente", nuevoGrupo.Contacto_presidente);
                            cmd.Parameters.AddWithValue("@Id_proyecto", nuevoGrupo.Id_proyecto);

                            cmd.ExecuteNonQuery();
                            retorno = Convert.ToInt32(cmd.LastInsertedId);
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
                Message.ShowMessage("Error MySql", "GruposModel.cs -> GuardarGrupo() \n" + e.Message, Message.MessageType.error);
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Error MySql", "GruposModel.cs -> GuardarGrupo() \n" + e2.Message, Message.MessageType.error);
            }
            return retorno;
        }


        public static int GuardarEstadoEtapa(string id_grupo, string id_etapa, string estado)
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
                            cmd.CommandText = " INSERT INTO grupos_etapas (id_etapa, id_grupo, estado) " +
                                              " VALUES (@Id_etapa, @Id_grupo, @Estado) ";

                            cmd.Parameters.AddWithValue("@Id_etapa", id_etapa);
                            cmd.Parameters.AddWithValue("@Id_grupo", id_grupo);
                            cmd.Parameters.AddWithValue("@Estado", estado);

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
                Message.ShowMessage("Error MySql", "GruposModel.cs -> GuardarEstadoEtapas() \n" + e.Message, Message.MessageType.error);
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Error MySql", "GruposModel.cs -> GuardarEstadoEtapas() \n" + e2.Message, Message.MessageType.error);
            }
            return retorno;
        }


        public static List<ObjetoGrupo> ObtenerGrupos()
        {
            List<ObjetoGrupo> lista = new List<ObjetoGrupo>();
            try
            {
                using (MySqlConnection conn = ObtenerConexionBD())
                {
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = " SELECT  " +
                                            " gp.identificador, " +
                                            " gp.nombre, " +
                                            " gp.razon_social, " +
                                            " gp.personalidad_juridica, " +
                                            " gp.nombre_presidente, " +
                                            " gp.contacto_presidente, " +
                                            " pr.nombre AS proyecto, " +
                                            " CASE " +
                                                " WHEN (SELECT ge.estado FROM grupos_etapas AS ge  " +
                                                    " JOIN etapas AS et ON et.id_etapa = ge.id_etapa  " +
                                                    " WHERE ge.id_grupo = gp.id_grupo AND et.id_etapa = 1) = 1 THEN 'Completa' " +
                                                " ELSE 'Incompleta' " +
                                            " END AS Etapa_crear_grupo, " +
                                            " CASE " +
                                                " WHEN (SELECT ge.estado FROM grupos_etapas AS ge  " +
                                                    " JOIN etapas AS et ON et.id_etapa = ge.id_etapa  " +
                                                    " WHERE ge.id_grupo = gp.id_grupo AND et.id_etapa = 2) = 1 THEN 'Completa' " +
                                                " ELSE 'Incompleta' " +
                                            " END AS Etapa_reg_postulantes, " +
                                            " CASE " +
                                                " WHEN (SELECT ge.estado FROM grupos_etapas AS ge  " +
                                                    " JOIN etapas AS et ON et.id_etapa = ge.id_etapa  " +
                                                    " WHERE ge.id_grupo = gp.id_grupo AND et.id_etapa = 3) = 1 THEN 'Completa' " +
                                                " ELSE 'Incompleta' " +
                                            " END AS Etapa_add_docs, " +
                                            " CASE " +
                                                " WHEN (SELECT ge.estado FROM grupos_etapas AS ge  " +
                                                    " JOIN etapas AS et ON et.id_etapa = ge.id_etapa  " +
                                                    " WHERE ge.id_grupo = gp.id_grupo AND et.id_etapa = 4) = 1 THEN 'Completa' " +
                                                " ELSE 'Incompleta' " +
                                            " END AS Etapa_add_formats " +
                                        " FROM grupos AS gp " +
                                        " JOIN proyectos AS pr ON pr.id_proyecto = gp.id_proyecto " ;

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ObjetoGrupo obj = new ObjetoGrupo();
                                obj.Identificador = reader["identificador"].ToString();
                                obj.Nombre = reader["nombre"].ToString();
                                obj.Razon_social = reader["razon_social"].ToString();
                                obj.Personalidad_juridica = reader["personalidad_juridica"].ToString();
                                obj.Nombre_presidente = reader["nombre_presidente"].ToString();
                                obj.Contacto_presidente = reader["contacto_presidente"].ToString();
                                obj.Proyecto = reader["proyecto"].ToString();
                                obj.Etapa_crear_grupo = reader["Etapa_crear_grupo"].ToString();
                                obj.Etapa_reg_postulantes = reader["Etapa_reg_postulantes"].ToString();
                                obj.Etapa_add_docs = reader["Etapa_add_docs"].ToString();
                                obj.Etapa_add_formats = reader["Etapa_add_formats"].ToString();
                                lista.Add(obj);
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
                Message.ShowMessage("Error MySql", "GruposModel.cs -> ObtenerGrupos() \n" + e.Message, Message.MessageType.error);
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Error MySql", "GruposModel.cs -> ObtenerGrupos() \n" + e2.Message, Message.MessageType.error);
            }
            return lista;
        }


        public static int EliminarGrupo(string identificador)
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
                            cmd.CommandText = " DELETE ge FROM grupos_etapas AS ge INNER JOIN grupos AS g ON g.id_grupo = ge.id_grupo WHERE g.identificador = @identificador; " + 
                                                " DELETE FROM grupos WHERE identificador = @Identificador ";

                            cmd.Parameters.AddWithValue("@Identificador", identificador);

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
                Message.ShowMessage("Error MySql", "GruposModel.cs -> EliminarGrupo() \n" + e.Message, Message.MessageType.error);
            }
            catch (Exception e2)
            {
                Message.ShowMessage("Error MySql", "GruposModel.cs -> EliminarGrupo() \n" + e2.Message, Message.MessageType.error);
            }
            return retorno;
        }
    }
}
