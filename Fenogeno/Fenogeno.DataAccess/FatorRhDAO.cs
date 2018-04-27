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
    public class FatorRhDAO
    {
        public List<FatorRh> BuscarTodos()
        {
            var lstFatorRh = new List<FatorRh>();

            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=FENOGENO;
                                                        Data source = localhost;
                                                        Integrated Security=SSPI;"))
            {
                string strSQL = @"SELECT * FROM FATOR_RH;";

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
                        var fatorrh = new FatorRh()
                        {
                            Id = Convert.ToInt32(row["ID"]),
                            Descricao = row["DESCRICAO"].ToString()
                        };

                        lstFatorRh.Add(fatorrh);
                    }
                }
            }

            return lstFatorRh;
        }
    }
}
