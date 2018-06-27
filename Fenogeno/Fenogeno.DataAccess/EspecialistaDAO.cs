using Fenogeno.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Fenogeno.DataAccess
{
    public class EspecialistaDAO
    {
        public void Inserir(Especialista obj)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"INSERT INTO ESPECIALISTA (CRM, CPF, NOME, EMAIL, TELEFONE, CURSO_F, UNIVERSIDADE_C, DURACAO_C, ANO_INICIO_C, ANO_TERMINO_C, AREA_E, UNIVERSIDADE_E, DURACAO_E, ANO_INICIO_E, ANO_TERMINO_E, FOTO) 
                                  VALUES (@CRM, @CPF, @NOME, @EMAIL, @TELEFONE, @CURSO_F, @UNIVERSIDADE_C, @DURACAO_C, @ANO_INICIO_C, @ANO_TERMINO_C, @AREA_E, @UNIVERSIDADE_E, @DURACAO_E, @ANO_INICIO_E, @ANO_TERMINO_E, @FOTO);";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@CRM", SqlDbType.VarChar).Value = obj.CRM;
                    cmd.Parameters.Add("@CPF", SqlDbType.VarChar).Value = obj.CPF;
                    cmd.Parameters.Add("@NOME", SqlDbType.VarChar).Value = obj.Nome;
                    cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = obj.Email;
                    cmd.Parameters.Add("@TELEFONE", SqlDbType.VarChar).Value = obj.Telefone;
                    cmd.Parameters.Add("@CURSO_F", SqlDbType.VarChar).Value = obj.Curso_f;
                    cmd.Parameters.Add("@UNIVERSIDADE_C", SqlDbType.VarChar).Value = obj.Universidade_c;
                    cmd.Parameters.Add("@DURACAO_C", SqlDbType.VarChar).Value = obj.Duracao_c;
                    cmd.Parameters.Add("@ANO_INICIO_C", SqlDbType.Int).Value = obj.Ano_inicio_c;
                    cmd.Parameters.Add("@ANO_TERMINO_C", SqlDbType.Int).Value = obj.Ano_termino_c;
                    cmd.Parameters.Add("@AREA_E", SqlDbType.VarChar).Value = obj.Area_e;
                    cmd.Parameters.Add("@UNIVERSIDADE_E", SqlDbType.VarChar).Value = obj.Universidade_e;
                    cmd.Parameters.Add("@DURACAO_E", SqlDbType.VarChar).Value = obj.Duracao_e;
                    cmd.Parameters.Add("@ANO_INICIO_E", SqlDbType.Int).Value = obj.Ano_inicio_e;
                    cmd.Parameters.Add("@ANO_TERMINO_E", SqlDbType.Int).Value = obj.Ano_termino_e;
                    cmd.Parameters.Add("@FOTO", SqlDbType.VarChar).Value = obj.Foto;

                    foreach (SqlParameter parameter in cmd.Parameters)
                    {
                        if (parameter.Value == null)
                        {
                            parameter.Value = DBNull.Value;
                        }
                    }

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void Excluir(Especialista obj)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"DELETE FROM DUVIDA WHERE ID_ESPECIALISTA = @COD;
                                  DELETE FROM ESPECIALISTA WHERE COD = @COD;";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@COD", SqlDbType.Int).Value = obj.Cod;
                    cmd.CommandText = strSQL;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public Especialista BuscarPorId(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"SELECT * FROM ESPECIALISTA WHERE COD = @COD;";

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
                    var especialista = new Especialista()
                    {
                        Cod = Convert.ToInt32(row["COD"]),
                        CRM = row["CRM"].ToString(),
                        CPF = row["CPF"].ToString(),
                        Nome = row["NOME"].ToString(),
                        Email = row["EMAIL"].ToString(),
                        Telefone = row["TELEFONE"].ToString(),
                        Curso_f = row["CURSO_F"].ToString(),
                        Universidade_c = row["UNIVERSIDADE_C"].ToString(),
                        Duracao_c = row["DURACAO_C"].ToString(),
                        Ano_inicio_c = row["ANO_INICIO_C"] is DBNull ? new Nullable<int>() : Convert.ToInt32(row["ANO_INICIO_C"]),
                        Ano_termino_c = row["ANO_TERMINO_C"] is DBNull ? new Nullable<int>() : Convert.ToInt32(row["ANO_TERMINO_C"]),
                        Area_e = row["AREA_E"].ToString(),
                        Universidade_e = row["UNIVERSIDADE_E"].ToString(),
                        Duracao_e = row["DURACAO_E"].ToString(),
                        Ano_inicio_e = row["ANO_INICIO_E"] is DBNull ? new Nullable<int>() : Convert.ToInt32(row["ANO_INICIO_E"]),
                        Ano_termino_e = row["ANO_TERMINO_E"] is DBNull ? new Nullable<int>() : Convert.ToInt32(row["ANO_TERMINO_E"]),
                        Foto = row["FOTO"].ToString()
                    };

                    return especialista;
                }
            }
        }

        public List<Especialista> BuscarTodos()
        {
            var lstEspecialistas = new List<Especialista>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"SELECT * FROM ESPECIALISTA;";

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
                        var especialista = new Especialista()
                        {
                            Cod = Convert.ToInt32(row["COD"]),
                            CRM = row["CRM"].ToString(),
                            CPF = row["CPF"].ToString(),
                            Nome = row["NOME"].ToString(),
                            Email = row["EMAIL"].ToString(),
                            Telefone = row["TELEFONE"].ToString(),
                            Curso_f = row["CURSO_F"].ToString(),
                            Universidade_c = row["UNIVERSIDADE_C"].ToString(),
                            Duracao_c = row["DURACAO_C"].ToString(),
                            Ano_inicio_c = row["ANO_INICIO_C"] is DBNull ? new Nullable<int>() : Convert.ToInt32(row["ANO_INICIO_C"]),
                            Ano_termino_c = row["ANO_TERMINO_C"] is DBNull ? new Nullable<int>() : Convert.ToInt32(row["ANO_TERMINO_C"]),
                            Area_e = row["AREA_E"].ToString(),
                            Universidade_e = row["UNIVERSIDADE_E"].ToString(),
                            Duracao_e = row["DURACAO_E"].ToString(),
                            Ano_inicio_e = row["ANO_INICIO_E"] is DBNull ? new Nullable<int>() : Convert.ToInt32(row["ANO_INICIO_E"]),
                            Ano_termino_e = row["ANO_TERMINO_E"] is DBNull ? new Nullable<int>() : Convert.ToInt32(row["ANO_TERMINO_E"]),
                            Foto = row["FOTO"].ToString()
                        };

                        lstEspecialistas.Add(especialista);
                    }
                }
            }

            return lstEspecialistas;
        }
    }
}
