using Fenogeno.DataAccess;
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
                        lblTexto.Text = noticia.Texto;
                        imgNoticia.Attributes.Add("src", ResolveUrl(string.Format("~/Uploads/{0}", noticia.Foto)));

                    }
                }
            }
        }
    }
}