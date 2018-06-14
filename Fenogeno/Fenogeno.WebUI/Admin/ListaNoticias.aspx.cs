using Fenogeno.DataAccess;
using Fenogeno.Models;
using System;
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
            Response.Redirect("~/Admin/CadastroNoticia.aspx");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(((LinkButton)sender).CommandArgument))
            {
                var id = Convert.ToInt32(((LinkButton)sender).CommandArgument);
                if (id > 0)
                {
                    Response.Redirect(string.Format("CadastroNoticia.aspx?id={0}", id));
                }
            }
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(((LinkButton)sender).CommandArgument))
            {
                var id = Convert.ToInt32(((LinkButton)sender).CommandArgument);
                if (id > 0)
                {
                    var obj = new Noticia() { Cod = id };
                    new NoticiaDAO().Excluir(obj);
                    Response.Redirect("~/Admin/ListaNoticias");
                }
            }
        }

        private void CarregarGridView()
        {
            var lstNoticias = new NoticiaDAO().BuscarTodos();
            grdNoticias.DataSource = lstNoticias;
            grdNoticias.DataBind();
        }
    }
}