using Fenogeno.DataAccess;
using Fenogeno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fenogeno.WebUI
{
    public partial class LerNoticia : System.Web.UI.Page
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
                    var noticia = new NoticiaDAO().BuscarPorId(id);
                    if (noticia != null)
                    {
                        lblTitulo.Text = noticia.Titulo;
                        lblDescricao.Text = noticia.Subtitulo;
                        lblTexto.Text = noticia.Texto;
                        imgNoticia.Attributes.Add("src", ResolveUrl(string.Format("~/Uploads/{0}", noticia.Foto)));

                        var lst = new ComentarioDAO().BuscarPorNoticia(noticia.Cod);
                        grdComentario.DataSource = lst;
                        grdComentario.DataBind();
                    }
                }
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Salvar();
                LimparCampos();
                //Response.Redirect(string.Format("~/LerNoticia.aspx?id={0}", Request.QueryString["id"]));

                pnlMsg.Visible = true;
                return;
            }

            if (!Validar())
            {
                pnlMsgAlerta.Visible = true;
                return;
            }
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtComentario.Text))
                return false;

            return true;
        }

        private void Salvar()
        {
            var obj = new Comentario();
            obj.Texto = txtComentario.Text;
            obj.DataHora = DateTime.Now;
            obj.Noticia = new Noticia() { Cod = Convert.ToInt32(Request.QueryString["ID"]) };
            obj.Usuario = new Usuario() { Id = ((Usuario)HttpContext.Current.User).Id };        
            
            new ComentarioDAO().Inserir(obj);
        }

        private void LimparCampos()
        {
            txtComentario.Text = string.Empty;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Noticias");
        }
    }
}