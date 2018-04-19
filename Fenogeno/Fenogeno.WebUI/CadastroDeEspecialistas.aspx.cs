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
    public partial class CadastroDeEspecialistas : System.Web.UI.Page
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
                Response.Redirect("~/ListaEspecialistas.aspx");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ListaEspecialistas.aspx");
        }

        private void LimparCampos()
        {

            txtCRM.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtFormacao.Text = string.Empty;
            txtUniversidadeF.Text = string.Empty;
            txtDuracaoF.Text = string.Empty;
            txtAnoFI.Text = string.Empty;
            txtAnoFT.Text = string.Empty;
            txtArea.Text = string.Empty;
            txtUniversidadeE.Text = string.Empty;
            txtDuracaoE.Text = string.Empty;
            txtAnoIE.Text = string.Empty;
            txtAnoT.Text = string.Empty;
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtCRM.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtCPF.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtNome.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtTelefone.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtFormacao.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtUniversidadeF.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtDuracaoF.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtAnoFI.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtAnoFT.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtArea.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtUniversidadeE.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtDuracaoE.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtAnoIE.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtAnoT.Text))
                return false;


            return true;
        }

        private void Salvar()
        {

            var obj = new Especialista();
            obj.CRM = txtCRM.Text;
            obj.CPF = txtCPF.Text;
            obj.Nome = txtNome.Text;
            obj.Email = txtEmail.Text;
            obj.Telefone = txtTelefone.Text;
            obj.Curso_f = txtFormacao.Text;
            obj.Universidade_c = txtUniversidadeF.Text;
            obj.Duracao_c = txtDuracaoF.Text;
            obj.Ano_inicio_c = Convert.ToDateTime(txtAnoFI.Text);
            obj.Ano_termino_c = Convert.ToDateTime(txtAnoFT.Text);
            obj.Area_e = txtArea.Text;
            obj.Universidade_e = txtUniversidadeE.Text;
            obj.Duracao_e = txtDuracaoE.Text;
            obj.Ano_inicio_e = Convert.ToDateTime(txtAnoIE.Text);
            obj.Ano_termino_e = Convert.ToDateTime(txtAnoT.Text);
            obj.Foto = fupArquivo.FileName;


            if (fupArquivo.HasFile)
            {
                var fileName = Path.GetFileName(fupArquivo.FileName);
                fupArquivo.SaveAs(Server.MapPath(string.Format("~/Uploads/{0}", fileName)));
            }

            new EspecialistaDAO().Inserir(obj);


        }

       
    }
}