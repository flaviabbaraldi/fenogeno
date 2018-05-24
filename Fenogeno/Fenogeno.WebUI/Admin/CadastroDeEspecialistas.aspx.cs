using Fenogeno.DataAccess;
using Fenogeno.Models;
using System;
using System.IO;

namespace Fenogeno.WebUI
{
    public partial class CadastroDeEspecialistas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                var id = Convert.ToInt32(Request.QueryString["id"]);
                if (id > 0)
                {
                    var obj = new EspecialistaDAO().BuscarPorId(id);
                    if (obj != null)
                    {
                        txtCRM.Text = obj.CRM;
                        txtCPF.Text = obj.CPF;
                        txtNome.Text = obj.Nome;
                        txtEmail.Text = obj.Email;
                        txtTelefone.Text = obj.Telefone;
                        txtFormacao.Text = obj.Curso_f;
                        txtUniversidadeF.Text = obj.Universidade_c;
                        txtDuracaoF.Text = obj.Duracao_c;
                        txtAnoFI.Text = obj.Ano_inicio_c.HasValue ? obj.Ano_inicio_c.ToString() : string.Empty;
                        txtAnoFT.Text = obj.Ano_termino_c.HasValue ? obj.Ano_termino_c.ToString() : string.Empty;
                        txtArea.Text = obj.Area_e;
                        txtUniversidadeE.Text = obj.Universidade_e;
                        txtDuracaoE.Text = obj.Duracao_e;
                        txtAnoIE.Text = obj.Ano_inicio_e.HasValue ? obj.Ano_inicio_e.ToString() : string.Empty; ;
                        txtAnoT.Text = obj.Ano_termino_e.HasValue ? obj.Ano_termino_e.ToString() : string.Empty; ;
                    }
                }
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Salvar();
                LimparCampos();
                Response.Redirect("~/Admin/ListaEspecialistas.aspx");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/ListaEspecialistas.aspx");
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
            obj.Ano_inicio_c = !string.IsNullOrWhiteSpace(txtAnoFI.Text) ? Convert.ToInt32(txtAnoFI.Text.OnlyNumbers()) : new Nullable<int>();
            obj.Ano_termino_c = !string.IsNullOrWhiteSpace(txtAnoFT.Text) ? Convert.ToInt32(txtAnoFT.Text.OnlyNumbers()) : new Nullable<int>();
            obj.Area_e = txtArea.Text;
            obj.Universidade_e = txtUniversidadeE.Text;
            obj.Duracao_e = txtDuracaoE.Text;
            obj.Ano_inicio_e = !string.IsNullOrWhiteSpace(txtAnoIE.Text) ? Convert.ToInt32(txtAnoIE.Text.OnlyNumbers()) : new Nullable<int>();
            obj.Ano_termino_e = !string.IsNullOrWhiteSpace(txtAnoT.Text) ? Convert.ToInt32(txtAnoT.Text.OnlyNumbers()) : new Nullable<int>();
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