using Fenogeno.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenogeno.DataAccess
{
    public class ComentarioDAO
    {
        public void Inserir(Comentario obj)
        {
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=FENOGENO;
                                                        Data source = localhost;
                                                        Integrated Security=SSPI;"))
            {
                string strSQL = @"INSERT INTO COMENTARIO (ID, ID_NOTICIA , ID_USUARIO, DATAHORA, TEXTO) 
                                                                VALUES (@ID , @ID_NOTICIA, @ID_USUARIO, @DATAHORA, @TEXTO);";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;

                    cmd.Parameters.Add("@ID", SqlDbType.VarChar).Value = obj.Id;
                    cmd.Parameters.Add("@ID_NOTICIA", SqlDbType.VarChar).Value = obj.Noticia;
                    cmd.Parameters.Add("@ID_USUARIO", SqlDbType.VarChar).Value = obj.Usuario;
                    cmd.Parameters.Add("@DATAHORA", SqlDbType.VarChar).Value = obj.DataHora;
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

            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=FENOGENO;
                                                        Data source = localhost;
                                                        Integrated Security=SSPI;"))
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
                                Id = Convert.ToInt32(row["ID_NOTICIA"]),
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
    }
}
