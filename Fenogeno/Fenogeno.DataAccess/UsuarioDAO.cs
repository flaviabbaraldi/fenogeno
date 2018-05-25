using Fenogeno.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Fenogeno.DataAccess
{
    public class UsuarioDAO
    {
        public void Inserir(Usuario obj)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"INSERT INTO USUARIO (NOME,EMAIL, CIDADE, BAIRRO, SENHA, FOTO) VALUES (@NOME, @EMAIL, @CIDADE, @BAIRRO, @SENHA, @FOTO);";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@NOME", SqlDbType.VarChar).Value = obj.Nome;
                    cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = obj.Email;
                    cmd.Parameters.Add("@CIDADE", SqlDbType.VarChar).Value = obj.Cidade;
                    cmd.Parameters.Add("@BAIRRO", SqlDbType.VarChar).Value = obj.Bairro;
                    cmd.Parameters.Add("@SENHA", SqlDbType.VarChar).Value = obj.Senha;
                    cmd.Parameters.Add("@FOTO", SqlDbType.VarChar).Value = obj.Foto ?? string.Empty;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public List<Usuario> BuscarTodos()
        {
            var lstUsuarios = new List<Usuario>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"SELECT * FROM USUARIO;";

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
                        var usuario = new Usuario()
                        {
                            Id = Convert.ToInt32(row["ID"]),
                            Nome = row["NOME"].ToString(),
                            Senha = row["SENHA"].ToString(),
                            Email = row["EMAIL"].ToString(),
                            Foto = row["FOTO"].ToString(),
                            Cidade = row ["CIDADE"].ToString(),
                            Bairro = row ["BAIRRO"].ToString(),
                        };
                        lstUsuarios.Add(usuario);
                    }
                }

            }

            return lstUsuarios;
        }

        public Usuario Logar(Usuario obj)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"SELECT TOP 1 * FROM USUARIO WHERE EMAIL = @EMAIL AND SENHA = @SENHA;";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = strSQL;
                    cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = obj.Email;
                    cmd.Parameters.Add("@SENHA", SqlDbType.VarChar).Value = obj.Senha;

                    var dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);
                    conn.Close();

                    if (!(dt != null && dt.Rows.Count > 0))
                        return null;

                    var row = dt.Rows[0];
                    var usuario = new Usuario()
                    {
                        Id = Convert.ToInt32(row["ID"]),
                        Nome = row["NOME"].ToString(),
                        Senha = row["SENHA"].ToString(),
                        Email = row["EMAIL"].ToString(),
                        Foto = row["FOTO"].ToString(),
                        Cidade = row["CIDADE"].ToString(),
                        Bairro = row["BAIRRO"].ToString(),
                    };

                    return usuario;
                }
            }
        }
    }
}
