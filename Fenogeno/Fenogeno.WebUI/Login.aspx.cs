using Fenogeno.DataAccess;
using Fenogeno.Models;
using System;
using System.Web.Script.Serialization;

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
            if (!Validar())
            {
                pnlMsg.Visible = true;
                return;
            }

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

            Response.Redirect("~/Admin.aspx");
        }

        private bool Validar()
        {
            var aux = true;

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                aux &= false;

            if (string.IsNullOrWhiteSpace(txtSenha.Text))
                aux &= false;

            return aux;
        }
    }
}