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
                        lblCurso.Text = "Formação: " + especialista.Curso_f;
                        lblUniversidadeF.Text = "Universidade: " + especialista.Universidade_c;
                        lblDuracaoF.Text = "Duração: " + especialista.Duracao_c;
                        lblCursoE.Text = "Curso: " + especialista.Area_e;
                        lblUniversidadeE.Text = "Universidade: " + especialista.Universidade_e;
                        lblDuracaoE.Text = "Duração: " + especialista.Duracao_e;
                        imgEspecialista.Attributes.Add("src", ResolveUrl(string.Format("~/Uploads/{0}", especialista.Foto)));
                        lblNomeEspecialista.Text = "Tem alguma dúvida? Pergunte ao Doutor(a) " + especialista.Nome;
                    }
                }
            }
        }

        //private bool Validar()
        //{
        //    if (string.IsNullOrWhiteSpace(txtDuvida.Text))
        //        return false;
        //}

        //protected void btnEnviar_Click(object sender, EventArgs e)
        //{
        //    if (!Validar())
        //    {
        //        pnlMsg.Visible = true;
        //        return;
        //    }
        }
    }
}