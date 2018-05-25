using Fenogeno.DataAccess;
using Fenogeno.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fenogeno.WebUI
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
                return;

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                pnlMsg.Visible = true;
                return;
            }

            Salvar();
            LimparCampos();
            //Response.Redirect("~/Default.aspx");
            pnlCadastro.Visible = true;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtSenhaConf.Text = string.Empty;
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtCidade.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtBairro.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtSenha.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtSenhaConf.Text))
                return false;

            return true;
        }

        private void Salvar()
        {
            var obj = new Usuario();
            obj.Nome = txtNome.Text;
            obj.Email = txtEmail.Text;
            obj.Cidade = txtCidade.Text;
            obj.Bairro = txtBairro.Text;
            obj.Senha = txtSenha.Text;
            obj.SenhaConf = txtSenhaConf.Text;
            obj.Foto = fupArquivo.FileName;

            if (fupArquivo.HasFile)
            {
                var fileName = Path.GetFileName(fupArquivo.FileName);
                fupArquivo.SaveAs(Server.MapPath(string.Format("~/Uploads/{0}", fileName)));
            }

            new UsuarioDAO().Inserir(obj);
        }



    }
}