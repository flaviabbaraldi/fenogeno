using Fenogeno.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenogeno.DataAccess
{
    public class DuvidaDAO
    {
        public void Inserir(Duvida obj)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"INSERT INTO DUVIDA (ID_ESPECIALISTA , ID_USUARIO, TEXTO) 
                                  VALUES (@ID_ESPECIALISTA, @ID_USUARIO, @TEXTO);";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@ID_ESPECIALISTA", SqlDbType.Int).Value = obj.Especialista.Cod;
                    cmd.Parameters.Add("@ID_USUARIO", SqlDbType.Int).Value = obj.Usuario.Id;                    
                    cmd.Parameters.Add("@TEXTO", SqlDbType.VarChar).Value = obj.Texto;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public List<Duvida> BuscarTodos()
        {
            var lstDuvidas = new List<Duvida>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"SELECT * FROM DUVIDA;";

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
                        var duvida = new Duvida()
                        {
                            Id = Convert.ToInt32(row["ID"]),
                            Especialista = new Especialista()
                            {
                                Cod = Convert.ToInt32(row["ID_ESPECIALISTA"]),
                            },
                            Usuario = new Usuario()
                            {
                                Id = Convert.ToInt32(row["ID_USUARIO"]),
                            },
                            DataHora = Convert.ToDateTime(row["DATAHORA"]),
                            Texto = row["TEXTO"].ToString()
                        };

                        lstDuvidas.Add(duvida);
                    }
                }
            }

            return lstDuvidas;
        }
        public List<Duvida> BuscarPorEspecialista(int codDuvida)
        {
            var lstDuvidas = new List<Duvida>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"SELECT * FROM DUVIDA WHERE ID_ESPECIALISTA = @ID_ESPECIALISTA;";

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
                        var duvida = new Duvida()
                        {
                            Id = Convert.ToInt32(row["ID"]),
                            Especialista = new Especialista()
                            {
                                Cod = Convert.ToInt32(row["ID_ESPECIALISTA"]),
                            },
                            Usuario = new Usuario()
                            {
                                Id = Convert.ToInt32(row["ID_USUARIO"]),
                            },
                            DataHora = Convert.ToDateTime(row["DATAHORA"]),
                            Texto = row["TEXTO"].ToString()
                        };

                        lstDuvidas.Add(duvida);
                    }
                }
            }

            return lstDuvidas;
        }

    }
}
