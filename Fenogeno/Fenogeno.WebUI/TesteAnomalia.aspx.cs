using Fenogeno.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fenogeno.WebUI
{
    public partial class TesteAnomalia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            BuscarAnomalia();
        }

        private void BuscarAnomalia()
        {
            var lstAnomalia = new AnomaliaDAO().BuscarTodos();

            ddlAnomalia.DataTextField = "Descricao";
            ddlAnomalia.DataValueField = "Id";
            ddlAnomalia.DataSource = lstAnomalia.OrderBy(o => o.Descricao).ToList();
            ddlAnomalia.DataBind();

            ddlAnomaliaP.DataTextField = "Descricao";
            ddlAnomaliaP.DataValueField = "Id";
            ddlAnomaliaP.DataSource = lstAnomalia.OrderBy(o => o.Descricao).ToList();
            ddlAnomaliaP.DataBind();

            ddlAnomaliaF.DataTextField = "Descricao";
            ddlAnomaliaF.DataValueField = "Id";
            ddlAnomaliaF.DataSource = lstAnomalia.OrderBy(o => o.Descricao).ToList();
            ddlAnomaliaF.DataBind();

            ddlAnomaliaFP.DataTextField = "Descricao";
            ddlAnomaliaFP.DataValueField = "Id";
            ddlAnomaliaFP.DataSource = lstAnomalia.OrderBy(o => o.Descricao).ToList();
            ddlAnomaliaFP.DataBind();
        }
        
    }
}