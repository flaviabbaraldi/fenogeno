using Fenogeno.DataAccess;
using System;

namespace Fenogeno.WebUI
{
    public partial class Especialistas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            var lst = new EspecialistaDAO().BuscarTodos();
            gridView.DataSource = lst;
            gridView.DataBind();
        }
    }
}