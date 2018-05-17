using Fenogeno.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Fenogeno.DataAccess
{
    public class OlhoDAO
    {
        public List<Olho> BuscarTodos()
        {
            var lstOlhos = new List<Olho>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"SELECT * FROM OLHOS;";

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
                        var olhos = new Olho()
                        {
                            Id = Convert.ToInt32(row["ID"]),
                            Descricao = row["DESCRICAO"].ToString()
                        };

                        lstOlhos.Add(olhos);
                    }
                }
            }

            return lstOlhos;
        }
    }
}
