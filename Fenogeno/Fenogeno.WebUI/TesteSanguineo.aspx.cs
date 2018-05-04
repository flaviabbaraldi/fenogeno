using Fenogeno.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fenogeno.WebUI
{
    public partial class TesteSanguineo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            CarregarGrupoSanguineo();
            CarregarFatorRh();
        }

      private void CarregarGrupoSanguineo()
        {
            var lstGrupoSanguineo = new GrupoSanguineoDAO().BuscarTodos();

            ddlSangue.DataTextField = "Descricao";
            ddlSangue.DataValueField = "Id";
            ddlSangue.DataSource = lstGrupoSanguineo.OrderBy(o => o.Descricao).ToList();
            ddlSangue.DataBind(); 

            ddlSangueP.DataTextField = "Descricao";
            ddlSangueP.DataValueField = "Id";
            ddlSangueP.DataSource = lstGrupoSanguineo.OrderBy(o => o.Descricao).ToList();
            ddlSangueP.DataBind();
        }

        private void CarregarFatorRh()
        {
            var lstFatorRh = new FatorRhDAO().BuscarTodos();

            ddlRh.DataTextField = "Descricao";
            ddlRh.DataValueField = "Id";
            ddlRh.DataSource = lstFatorRh.OrderBy(o => o.Descricao).ToList();
            ddlRh.DataBind();

            ddlRhP.DataTextField = "Descricao";
            ddlRhP.DataValueField = "Id";
            ddlRhP.DataSource = lstFatorRh.OrderBy(o => o.Descricao).ToList();
            ddlRhP.DataBind();
        }


       
    }
}