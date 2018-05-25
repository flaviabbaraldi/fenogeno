using Fenogeno.Models;
using System;
using System.Web;
using System.Web.UI;

namespace Fenogeno.WebUI
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            lnkLogin.Visible = HttpContext.Current.User == null || HttpContext.Current.User.GetType() != typeof(Usuario);
            lnkSair.Visible = HttpContext.Current.User != null && HttpContext.Current.User.GetType() == typeof(Usuario);
        }

        protected void lnkLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }

        protected void lnkSair_Click(object sender, EventArgs e)
        {
            FormsAuthenticationUtil.SignOut();
            Response.Redirect("~/Login.aspx");
        }
    }
}