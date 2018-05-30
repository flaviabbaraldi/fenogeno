using Fenogeno.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fenogeno.WebUI
{
    public partial class VerEspecialista : System.Web.UI.Page
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
                    var especialista = new EspecialistaDAO().BuscarPorId(id);
                    if (especialista != null)
                    {
                        lblNome.Text = especialista.Nome;
                        //lblFormação.Text = especialista.Curso_f;
                        imgEspecialista.Attributes.Add("src", ResolveUrl(string.Format("~/Uploads/{0}", especialista.Foto)));
                        lblNomeEspecialista.Text = "Tem alguma dúvida? Pergunte ao Doutor(a) " + especialista.Nome;
                    }
                }
            }
        }

        
    }
}