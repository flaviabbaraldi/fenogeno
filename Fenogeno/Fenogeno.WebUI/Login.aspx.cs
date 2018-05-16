using Fenogeno.DataAccess;
using Fenogeno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fenogeno.WebUI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            var usuarioLogado = new UsuarioDAO().Logar(new Usuario()
            {
                Email = txtEmail.Text,
                Senha = txtSenha.Text
            });

            if (usuarioLogado == null)
            {
                Response.Redirect("~/Login.aspx");
            }

            var userData = new JavaScriptSerializer().Serialize(usuarioLogado);
            FormsAuthenticationUtil.SetCustomAuthCookie(usuarioLogado.Email, userData, false);

            Response.Redirect("~/Default.aspx");
        }
    }
}