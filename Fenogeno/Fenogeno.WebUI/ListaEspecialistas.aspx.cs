using Fenogeno.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fenogeno.WebUI
{
    public partial class ListaEspecialistas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            CarregarGridView();
        }

        private void CarregarGridView()
        {
            var lstEspecialistas = new List<Especialista>();

            using (SqlConnection conn =
                new SqlConnection(@"Initial Catalog=FENOGENO;
                        Data Source=localhost;
                        Integrated Security=SSPI;"))
            {

                string strSQL = @"SELECT * FROM ESPECIALISTA";

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
                            CRM = row["CRM"].ToString(),
                            CPF = row["CPF"].ToString(),
                            Nome = row["NOME"].ToString(),
                            Email = row["EMAIL"].ToString(),
                            Telefone = row["TELEFONE"].ToString(),
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

                    grdEspecialistas.DataSource = lstEspecialistas;

                    grdEspecialistas.DataBind();
                }
            }

        }


        protected void grdNoticias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CadastroDeEspecialistas.aspx");
        }
    }
}