using Fenogeno.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Fenogeno.DataAccess
{
    public class ComentarioDAO
    {
        public void Inserir(Comentario obj)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"INSERT INTO COMENTARIO (ID_NOTICIA , ID_USUARIO,TEXTO) 
                                  VALUES (@ID_NOTICIA, @ID_USUARIO, @TEXTO);";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@ID_NOTICIA", SqlDbType.Int).Value = obj.Noticia.Cod;
                    cmd.Parameters.Add("@ID_USUARIO", SqlDbType.Int).Value = obj.Usuario.Id;
                    cmd.Parameters.Add("@TEXTO", SqlDbType.VarChar).Value = obj.Texto;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public List<Comentario> BuscarTodos()
        {
            var lstComentarios = new List<Comentario>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"SELECT * FROM COMENTARIO;";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = strSQL;

                    var dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);
                    conn.Close();

                    foreach (DataRow row in dt.Rows)
                    {
                        var comentario = new Comentario()
                        {
                            Id = Convert.ToInt32(row["ID"]),
                            Noticia = new Noticia()
                            {
                                Cod = Convert.ToInt32(row["ID_NOTICIA"]),
                            },
                            Usuario = new Usuario()
                            {
                                Id = Convert.ToInt32(row["ID_USUARIO"]),
                            },
                            DataHora = Convert.ToDateTime(row["DATAHORA"]),
                            Texto = row["TEXTO"].ToString()
                        };

                        lstComentarios.Add(comentario);
                    }
                }
            }

            return lstComentarios;
        }

        public List<Comentario> BuscarPorNoticia(int codNoticia)
        {
            var lstComentarios = new List<Comentario>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"SELECT 
                                    C.*,
                                    U.NOME AS NOME_USUARIO
                                  FROM COMENTARIO C
                                  INNER JOIN USUARIO U ON (U.ID = C.ID_USUARIO)
                                  WHERE C.ID_NOTICIA = @ID_NOTICIA;";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@ID_NOTICIA", SqlDbType.Int).Value = codNoticia;
                    cmd.CommandText = strSQL;

                    var dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);
                    conn.Close();

                    foreach (DataRow row in dt.Rows)
                    {
                        var comentario = new Comentario()
                        {
                            Id = Convert.ToInt32(row["ID"]),
                            Noticia = new Noticia()
                            {
                                Cod = Convert.ToInt32(row["ID_NOTICIA"]),
                            },
                            Usuario = new Usuario()
                            {
                                Id = Convert.ToInt32(row["ID_USUARIO"]),
                                Nome = row["NOME_USUARIO"].ToString()
                            },
                            DataHora = Convert.ToDateTime(row["DATAHORA"]),
                            Texto = row["TEXTO"].ToString()
                        };

                        lstComentarios.Add(comentario);
                    }
                }
            }

            return lstComentarios;
        }
    }
}
