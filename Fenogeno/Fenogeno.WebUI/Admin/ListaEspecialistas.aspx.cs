using Fenogeno.DataAccess;
using Fenogeno.Models;
using System;
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

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/CadastroDeEspecialistas.aspx");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(((LinkButton)sender).CommandArgument))
            {
                var id = Convert.ToInt32(((LinkButton)sender).CommandArgument);
                if (id > 0)
                {
                    Response.Redirect(string.Format("CadastroDeEspecialistas.aspx?id={0}", id));
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
                    var obj = new Especialista() { Cod = id };
                    new EspecialistaDAO().Excluir(obj);
                    Response.Redirect("~/Admin/ListaEspecialistas");
                }
            }
        }

        private void CarregarGridView()
        {
            var lstEspecialistas = new EspecialistaDAO().BuscarTodos();
            grdEspecialistas.DataSource = lstEspecialistas;
            grdEspecialistas.DataBind();
        }
    }
}