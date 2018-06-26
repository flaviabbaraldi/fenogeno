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
    public partial class TesteSanguineo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            CarregarGrupoSanguineo();
            CarregarFatorRh();
        }

        private void CarregarGrupoSanguineo()
        {
            //cria uma lista vazia
            var lstGrupoSanguineo = new List<GrupoSanguineo>();

            //adiciona um item default
            lstGrupoSanguineo.Add(new GrupoSanguineo()
            {
                Descricao = "-- [SELECIONE] --"
            });

            //adiciona na lista os itens que vierem do banco de dados
            lstGrupoSanguineo.AddRange(new GrupoSanguineoDAO().BuscarTodos());

            ddlSangue.DataTextField = "Descricao";
            ddlSangue.DataValueField = "Descricao";
            ddlSangue.DataSource = lstGrupoSanguineo.OrderBy(o => o.Descricao).ToList();
            ddlSangue.DataBind();

            ddlSangueP.DataTextField = "Descricao";
            ddlSangueP.DataValueField = "Descricao";
            ddlSangueP.DataSource = lstGrupoSanguineo.OrderBy(o => o.Descricao).ToList();
            ddlSangueP.DataBind();
        }

        private void CarregarFatorRh()
            
        {
            //cria uma lista vazia
            var lstFatorRh = new List<FatorRh>();

            //adiciona um item default
            lstFatorRh.Add(new FatorRh()
            {
                Descricao = " [SELECIONE] "
            });

            //adiciona na lista os itens que vierem do banco de dados
            lstFatorRh.AddRange(new FatorRhDAO().BuscarTodos());


            ddlRh.DataTextField = "Descricao";
            ddlRh.DataValueField = "Descricao";
            ddlRh.DataSource = lstFatorRh.OrderBy(o => o.Descricao).ToList();
            ddlRh.DataBind();

            ddlRhP.DataTextField = "Descricao";
            ddlRhP.DataValueField = "Descricao";
            ddlRhP.DataSource = lstFatorRh.OrderBy(o => o.Descricao).ToList();
            ddlRhP.DataBind();
        }

       
        protected void btnCalcularSangue_Click(object sender, EventArgs e)
        {
            CalcularSangue();
        }

        private void CalcularSangue()
        {
            if (string.IsNullOrWhiteSpace(ddlSangue.SelectedValue) || ddlSangue.SelectedValue == "-- [SELECIONE] --" || string.IsNullOrWhiteSpace(ddlSangueP.SelectedValue) || ddlSangueP.SelectedValue == "-- [SELECIONE] --")
            {
                pnlRespS.Visible = false;
                pnlMsgGS.Visible = true;
                return;
            }
            else
            {
                pnlMsgGS.Visible = false;
            }

            string campo1 = ddlSangue.SelectedValue;
            string campo2 = ddlSangueP.SelectedValue;

            if ((campo1 == "A") && (campo2 == "A"))
            {
                lblResultadoS.Text = "Seu filho tem probabilidades de ser do grupo O ou A, não podendo ser do AB ou B";
                pnlRespS.Visible = true;
            }
            else if ((campo1 == "A") && (campo2 == "AB"))
            {
                lblResultadoS.Text = "Seu filho pode ser do grupo A,B ou AB, não podendo ser do O";
                pnlRespS.Visible = true;
            }
            else if ((campo1 == "A") && (campo2 == "B"))
            {
                lblResultadoS.Text = "Seu filho pode ser de qualquer grupo, A, B, AB e O";
                pnlRespS.Visible = true;
            }
            else if ((campo1 == "A") && (campo2 == "O"))
            {
                lblResultadoS.Text = "Seu filho pode ser do grupo O ou A, não podendo ser do AB ou B";
                pnlRespS.Visible = true;
            }
            else if ((campo1 == "AB") && (campo2 == "A"))
            {
                lblResultadoS.Text = "Seu filho pode ser do grupo A, B ou AB, não podendo ser do O";
                pnlRespS.Visible = true;
            }
            else if ((campo1 == "AB") && (campo2 == "AB"))
            {
                lblResultadoS.Text = "Seu filho pode ser do grupo A, B ou AB, não podendo ser do O";
                pnlRespS.Visible = true;
            }
            else if ((campo1 == "AB") && (campo2 == "B"))
            {
                lblResultadoS.Text = "Seu filho pode ser do grupo A, B ou AB, não podendo ser do O";
                pnlRespS.Visible = true;
            }
            else if ((campo1 == "AB") && (campo2 == "O"))
            {
                lblResultadoS.Text = "Seu filho pode ser do grupo A ou B, não podendo ser do O ou AB";
                pnlRespS.Visible = true;
            }
            else if ((campo1 == "B") && campo2 == "A")
            {
                lblResultadoS.Text = "Seu filho pode ser de qualquer grupo, A, B, AB e O";
                pnlRespS.Visible = true;
            }
            else if ((campo1 == "B") && (campo2 == "AB"))
            {
                lblResultadoS.Text = "Seu filho pode ser do grupo A, B ou AB, não podendo ser do O";
                pnlRespS.Visible = true;
            }
            else if ((campo1 == "B") && campo2 == "B")
            {
                lblResultadoS.Text = "Seu filho pode ser do grupo O ou B, não podendo ser do A ou AB";
                pnlRespS.Visible = true;
            }
            else if ((campo1 == "B") && (campo2 == "O"))
            {
                lblResultadoS.Text = "Seu filho pode ser do grupo O ou B, não podendo ser do A ou AB";
                pnlRespS.Visible = true;
            }
            else if ((campo1 == "O") && campo2 == "A")
            {
                lblResultadoS.Text = "Seu filho pode ser do grupo O ou A, não podendo ser do AB ou B";
                pnlRespS.Visible = true;
            }
            else if ((campo1 == "O") && campo2 == "AB")
            {
                lblResultadoS.Text = "Seu filho pode ser do grupo A ou B, não podendo ser do O ou AB";
                pnlRespS.Visible = true;
            }
            else if ((campo1 == "O") && campo2 == "B")
            {
                lblResultadoS.Text = "Seu filho pode ser do grupo O ou B, não podendo ser do AB ou A";
                pnlRespS.Visible = true;
            }
            else if ((campo1 == "O") && campo2 == "O")
            {
                lblResultadoS.Text = "Seu filho pode ser do grupo O, não podendo ser do AB, A ou B";
                pnlRespS.Visible = true;
            }
            else
            {
                lblResultadoS.Text = "Nenhum resultado esperado!";
                pnlRespS.Visible = true;
            }
        }

        protected void btnCalcularRH_Click(object sender, EventArgs e)
        {
            CalcularRh();
        }

        private void CalcularRh()

        {

            if (string.IsNullOrWhiteSpace(ddlRh.SelectedValue) || ddlRh.SelectedValue == " [SELECIONE] " || string.IsNullOrWhiteSpace(ddlRhP.SelectedValue) || ddlRhP.SelectedValue == "[SELECIONE] ")
            {
                pnlRespR.Visible = false;
                pnlMsgFR.Visible = true;
                return;
            }
            else
            {
                pnlMsgFR.Visible = false;
            }

            string campo3 = ddlRh.SelectedValue;
            string campo4 = ddlRhP.SelectedValue;

            if ((campo3 == "+") && (campo4 == "-"))
            {
                lblResultadoR.Text = "Seu filho poderá ter fator RH + ou -";
                pnlRespR.Visible = true;
            }
            else if ((campo3 == "+") && (campo4 == "+"))
            {
                lblResultadoR.Text = "Seu filho poderá ter fator RH + ou -";
                pnlRespR.Visible = true;
            }
            else if ((campo3 == "-") && (campo4 == "+"))
            {
                lblResultadoR.Text = "Seu filho poderá ter fator RH + ou -";
                pnlRespR.Visible = true;
            }
            else if ((campo3 == "-") && (campo4 == "-"))
            {
                lblResultadoR.Text = "Seu filho terá fator RH -";
                pnlRespR.Visible = true;
            }
            else
            {
                lblResultadoR.Text = "Nenhuma combinação foi encontrado!";
                pnlRespR.Visible = true;
            }

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Teste.aspx");
        }

       
    }


}
