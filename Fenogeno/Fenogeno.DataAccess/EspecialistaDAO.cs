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
    public class EspecialistaDAO
    {
        public void Inserir(Especialista obj)
        {
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=FENOGENO;
                                                        Data source = localhost;
                                                        Integrated Security=SSPI;"))
            {
                string strSQL = @"INSERT INTO ESPECIALISTA (CRM, CPF, NOME, EMAIL, TELEFONE, CURSO_F, UNIVERSIDADE_C, DURACAO_C, ANO_INICIO_C, ANO_TERMINO_C, AREA_E, 
                                                            UNIVERSIDADE_E, DURACAO_E, ANO_INICIO_E, ANO_TERMINO_E, FOTO) 
                                                                VALUES (@CRM, @CPF, @NOME, @EMAIL, @TELEFONE, @CURSO_F, @UNIVERSIDADE_C, @DURACAO_C, @ANO_INICIO_C, @ANO_TERMINO_C, @AREA_E, 
                                                            @UNIVERSIDADE_E, @DURACAO_E, @ANO_INICIO_E, @ANO_TERMINO_E, @FOTO);";

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
                    cmd.Parameters.Add("@ANO_INICIO_C", SqlDbType.VarChar).Value = obj.Ano_inicio_c;
                    cmd.Parameters.Add("@ANO_TERMINO_C", SqlDbType.VarChar).Value = obj.Ano_termino_c;
                    cmd.Parameters.Add("@AREA_E", SqlDbType.VarChar).Value = obj.Area_e;
                    cmd.Parameters.Add("@UNIVERSIDADE_E", SqlDbType.VarChar).Value = obj.Universidade_e;
                    cmd.Parameters.Add("@DURACAO_E", SqlDbType.VarChar).Value = obj.Duracao_e;
                    cmd.Parameters.Add("@ANO_INICIO_E", SqlDbType.VarChar).Value = obj.Ano_inicio_e;
                    cmd.Parameters.Add("@ANO_TERMINO_E", SqlDbType.VarChar).Value = obj.Ano_termino_e;
                    cmd.Parameters.Add("@FOTO", SqlDbType.VarChar).Value = obj.Foto;


                    conn.Open();

                    cmd.ExecuteNonQuery();

                    conn.Close();

                }
            }
        }

        public List<Especialista> BuscarTodos()
        {
            var lstEspecialistas = new List<Especialista>();

            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=FENOGENO;
                                                        Data source = localhost;
                                                        Integrated Security=SSPI;"))
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
                            CRM = Convert.ToInt32(row["CRM"]),
                            CPF = Convert.ToInt32(row["CPF"]),
                            Nome = row["NOME"].ToString(),
                            Email = row["EMAIL"].ToString(),
                            Telefone = Convert.ToInt32(row["TELEFONE"]),
                            Curso_f = row["CURSO_F"].ToString(),
                            Universidade_c = row["UNIVERSIDADE_C"].ToString(),
                            Duracao_c = row["DURACAO_C"].ToString(),
                            Ano_inicio_c = Convert.ToDateTime(row["ANO_INICIO_C"]),
                            Ano_termino_c = Convert.ToDateTime(row["ANO_TERMINO_C"]),
                            Area_e = row["AREA_E"].ToString(),
                            Universidade_e = row["UNIVERSIDADE_E"].ToString(),
                            Duracao_e = row["DURACAO_E"].ToString(),
                            Ano_inicio_e = Convert.ToDateTime(row["ANO_INICIO_E"]),
                            Ano_termino_e = Convert.ToDateTime(row["ANO_TERMINO_E"]),
                            Foto = row["FOTO"].ToString(),
                        };

                        lstEspecialistas.Add(especialista);
                    }
                }
            }

            return lstEspecialistas;
            
        }
    }
}
