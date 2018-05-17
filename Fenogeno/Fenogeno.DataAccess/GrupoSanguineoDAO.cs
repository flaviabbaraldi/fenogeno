using Fenogeno.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Fenogeno.DataAccess
{
    public class GrupoSanguineoDAO
    {
        public List<GrupoSanguineo> BuscarTodos()
        {
            var lstGrupoSanguineo = new List<GrupoSanguineo>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                string strSQL = @"SELECT * FROM GRUPO_SANGUINEO;";

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
                        var gruposanguineo = new GrupoSanguineo()
                        {
                            Id = Convert.ToInt32(row["ID"]),
                            Descricao = row["DESCRICAO"].ToString()
                        };

                        lstGrupoSanguineo.Add(gruposanguineo);
                    }
                }
            }

            return lstGrupoSanguineo;
        }
    }
}
