using Fenogeno.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Fenogeno.DataAccess
{
    public class NoticiaDAO
    {
        public void Inserir(Noticia obj)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"INSERT INTO NOTICIA (TITULO, DESCRICAO, CORPO_TEXTO, FOTO) VALUES (@TITULO, @DESCRICAO, @CORPO_TEXTO, @FOTO);";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@TITULO", SqlDbType.VarChar).Value = obj.Titulo;
                    cmd.Parameters.Add("@DESCRICAO", SqlDbType.VarChar).Value = obj.Subtitulo;
                    cmd.Parameters.Add("@CORPO_TEXTO", SqlDbType.VarChar).Value = obj.Texto;
                    cmd.Parameters.Add("@FOTO", SqlDbType.VarChar).Value = obj.Foto ?? string.Empty;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void Excluir(Noticia obj)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"DELETE FROM NOTICIA WHERE COD = @COD;";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@COD", SqlDbType.Int).Value = obj.Cod;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public Noticia BuscarPorId(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"SELECT * FROM NOTICIA WHERE COD = @COD;";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@COD", SqlDbType.Int).Value = id;
                    cmd.CommandText = strSQL;

                    var dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);
                    conn.Close();

                    if (!(dt != null && dt.Rows.Count > 0))
                        return null;

                    var row = dt.Rows[0];
                    var noticia = new Noticia()
                    {
                        Cod = Convert.ToInt32(row["COD"]),
                        Titulo = row["TITULO"].ToString(),
                        Subtitulo = row["DESCRICAO"].ToString(),
                        Texto = row["CORPO_TEXTO"].ToString(),
                        Foto = row["FOTO"].ToString(),
                    };

                    return noticia;
                }
            }
        }

        public List<Noticia> BuscarTodos()
        {
            var lstNoticias = new List<Noticia>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"SELECT * FROM NOTICIA;";

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
                        var noticia = new Noticia()
                        {
                            Cod = Convert.ToInt32(row["COD"]),
                            Titulo = row["TITULO"].ToString(),
                            Subtitulo = row["DESCRICAO"].ToString(),
                            Texto = row["CORPO_TEXTO"].ToString(),
                            Foto = row["FOTO"].ToString(),
                        };

                        lstNoticias.Add(noticia);
                    }
                }
            }

            return lstNoticias;

        }
    }
}