using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Fenogeno.WebUI
{
    public partial class CadastroNoticia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Salvar();
                LimparCampos();
                Response.Redirect("~/Noticia.aspx");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Noticia.aspx");
        }

        private void LimparCampos()
        {
            txtTitulo.Text = string.Empty;
            txtdescricao.Text = string.Empty;
            txtCorpo.Text = string.Empty;
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtdescricao.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtCorpo.Text))
                return false;

            return true;
        }

        private void Salvar()
        {
            var obj = new Noticia();
            obj.Titulo = txtTitulo.Text;
            obj.Descricao = txtdescricao.Text;
            obj.Corpo = txtCorpo.Text;

            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=FENOGENO; 
                                                             Data Source=localhost;
                                                             Integrated Security=SSPI;"))
            {
                string strSQL = @"INSERT INTO NOTICIA (TITULO, DESCRICAO, CORPO_TEXTO, FOTO)
                                    VALUES(@TITULO, @DESCRICAO, @CORPO_TEXTO, @FOTO)";

                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;

                    cmd.Parameters.Add("@TITULO", qlDbType.Varchar).Value = obj.
                }
            }
        }



    }
}