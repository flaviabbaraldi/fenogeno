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
    public partial class ListaNoticias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            CarregarGridView();
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CadastroNoticia.aspx");
        }

        private void CarregarGridView()
        {
            var lstNoticias = new List<Noticia>();

            using (SqlConnection conn =
                new SqlConnection(@"Initial Catalog=FENOGENO;
                        Data Source=localhost;
                        Integrated Security=SSPI;"))
            {
                string strSQL = @"SELECT * FROM NOTICIA";

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
                        var noticia = new Noticia()
                        {
                            Id = Convert.ToInt32(row["COD"]),
                            Titulo = row["TITULO"].ToString(),
                            Subtitulo = row["DESCRICAO"].ToString(),
                            Texto = row["CORPO_TEXTO"].ToString(),
                            Foto = row["FOTO"].ToString(),

                        };

                        lstNoticias.Add(noticia);
                    }
                    grdNoticias.DataSource = lstNoticias;

                    grdNoticias.DataBind();

                }
            }

        }

        protected void grdNoticias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}