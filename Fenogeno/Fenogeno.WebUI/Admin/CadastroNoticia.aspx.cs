using Fenogeno.DataAccess;
using Fenogeno.Models;
using System;
using System.IO;

namespace Fenogeno.WebUI
{
    public partial class CadastroNoticia : System.Web.UI.Page
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
                    var obj = new NoticiaDAO().BuscarPorId(id);
                    if (obj != null)
                    {
                        txtTitulo.Text = obj.Titulo;
                        txtdescricao.Text = obj.Subtitulo;
                        txtCorpo.Text = obj.Texto;
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
                Response.Redirect("~/Admin/ListaNoticias.aspx");
            }


            if (!Validar())
            {
                pnlMsg.Visible = true;
                return;
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Admin/ListaNoticias.aspx");
        }

        private void LimparCampos()
        {
            txtTitulo.Text = string.Empty;
            txtdescricao.Text = string.Empty;
            txtCorpo.Text = string.Empty;
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtdescricao.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtCorpo.Text))
                return false;

            return true;
        }

        private void Salvar()
        {
            var obj = new Noticia();
            obj.Titulo = txtTitulo.Text;
            obj.Subtitulo = txtdescricao.Text;
            obj.Texto = txtCorpo.Text;
            obj.Foto = fupArquivo.FileName;

            if (fupArquivo.HasFile)
            {
                var fileName = Path.GetFileName(fupArquivo.FileName);
                fupArquivo.SaveAs(Server.MapPath(string.Format("~/Uploads/{0}", fileName)));
            }

            new NoticiaDAO().Inserir(obj);
        }
    }
}