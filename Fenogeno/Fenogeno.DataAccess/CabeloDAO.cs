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
    public class CabeloDAO
    {
        public List<Cabelo> BuscarTodos()
        {
            var lstCabelo = new List<Cabelo>();

            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=FENOGENO;
                                                        Data source = localhost;
                                                        Integrated Security=SSPI;"))
            {
                string strSQL = @"SELECT * FROM CABELO;";

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
                        var cabelo = new Cabelo()
                        {
                            Id = Convert.ToInt32(row["ID"]),
                            Descricao = row["DESCRICAO"].ToString()
                        };

                        lstCabelo.Add(cabelo);
                    }
                }
            }

            return lstCabelo;
        }
    }
}
