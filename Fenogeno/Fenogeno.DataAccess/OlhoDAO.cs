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
    public class OlhoDAO
    {
        public List<Olho> BuscarTodos()
        {
            var lstOlhos = new List<Olho>();

            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=FENOGENO;
                                                        Data source = localhost;
                                                        Integrated Security=SSPI;"))
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
