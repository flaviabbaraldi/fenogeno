using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using Fenogeno.Models;

namespace Fenogeno.DataAccess
{
    public class NoticiaDAO
    {

        public void Inserir(Noticia obj)
        {
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=FENOGENO;
                                                        Data source = localhost;
                                                        Integrated Security=SSPI;"))
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


        public List<Noticia> BuscarTodos()
        {
            var lstNoticias = new List<Noticia>();

            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=FENOGENO;
                                                        Data source = localhost;
                                                        Integrated Security=SSPI;"))
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
                            Id = Convert.ToInt32(row["ID"]),
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