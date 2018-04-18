using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Fenogeno.Models;
using Fenogeno.DataAccess;

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
            obj.Subtitulo = txtdescricao.Text;
            obj.Texto = txtCorpo.Text;

            new NoticiaDAO().Inserir(obj);
        }
    }
}