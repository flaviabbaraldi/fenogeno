using Fenogeno.DataAccess;
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
            var lstGrupoSanguineo = new GrupoSanguineoDAO().BuscarTodos();

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
            var lstFatorRh = new FatorRhDAO().BuscarTodos();

            ddlRh.DataTextField = "Descricao";
            ddlRh.DataValueField = "Descricao";
            ddlRh.DataSource = lstFatorRh.OrderBy(o => o.Descricao).ToList();
            ddlRh.DataBind();

            ddlRhP.DataTextField = "Descricao";
            ddlRhP.DataValueField = "Descricao";
            ddlRhP.DataSource = lstFatorRh.OrderBy(o => o.Descricao).ToList();
            ddlRhP.DataBind();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            string campo1 = ddlSangue.SelectedValue;
            string campo2 = ddlSangueP.SelectedValue;
            string campo3 = ddlRh.SelectedValue;
            string campo4 = ddlRhP.SelectedValue;

            if ((campo1 == "O") && (campo2 == "O") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "Seu filho tem 100% de chances de nascer O+";
            }

            else if ((campo1 == "O") && (campo2 == "O") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "Seu filho tem 100% de chances de nascer O-";
            }

            else if ((campo1 == "O") && (campo2 == "O") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "Seu filho tem 100% de chances de nascer O+";
            }

            else if ((campo1 == "O") && (campo2 == "O") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "Seu filho tem 100% de chances de nascer O+";
            }

            else if ((campo1 == "O") && (campo2 == "A") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "Seu filho tem 75% de chances de nascer A+ e 25% de chances de nascer O+";
            }

            else if ((campo1 == "O") && (campo2 == "A") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "Seu filho tem 75% de chances de nascer A- e 25% de chances de nascer O-";
            }

            else if ((campo1 == "O") && (campo2 == "A") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 7";
            }

            else if ((campo1 == "O") && (campo2 == "A") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 8";
            }

            else if ((campo1 == "A") && (campo2 == "O") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 9";
            }

            else if ((campo1 == "A") && (campo2 == "O") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 10";
            }

            else if ((campo1 == "A") && (campo2 == "O") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 11";
            }

            else if ((campo1 == "A") && (campo2 == "O") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 12";
            }

            else if ((campo1 == "O") && (campo2 == "B") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 13";
            }

            else if ((campo1 == "O") && (campo2 == "B") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 14";
            }

            else if ((campo1 == "O") && (campo2 == "B") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 15";
            }

            else if ((campo1 == "O") && (campo2 == "B") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 16";
            }

            else if ((campo1 == "B") && (campo2 == "O") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 17";
            }

            else if ((campo1 == "B") && (campo2 == "O") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 18";
            }

            else if ((campo1 == "B") && (campo2 == "O") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 19";
            }

            else if ((campo1 == "B") && (campo2 == "O") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 20";
            }

            else if ((campo1 == "A") && (campo2 == "A") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 21";
            }

            else if ((campo1 == "A") && (campo2 == "A") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 22";
            }

            else if ((campo1 == "A") && (campo2 == "A") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 23";
            }

            else if ((campo1 == "A") && (campo2 == "A") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 24";
            }

            else if ((campo1 == "B") && (campo2 == "B") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 25";
            }

            else if ((campo1 == "B") && (campo2 == "B") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 26";
            }

            else if ((campo1 == "B") && (campo2 == "B") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 27";
            }

            else if ((campo1 == "B") && (campo2 == "B") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 28";
            }

            else if ((campo1 == "O") && (campo2 == "AB") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 29";
            }

            else if ((campo1 == "O") && (campo2 == "AB") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 30";
            }

            else if ((campo1 == "O") && (campo2 == "AB") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 31";
            }

            else if ((campo1 == "O") && (campo2 == "AB") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 32";
            }

            else if ((campo1 == "AB") && (campo2 == "O") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 33";
            }

            else if ((campo1 == "AB") && (campo2 == "O") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 34";
            }

            else if ((campo1 == "AB") && (campo2 == "O") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 35";
            }

            else if ((campo1 == "AB") && (campo2 == "O") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 36";
            }

            else if ((campo1 == "A") && (campo2 == "B") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 37";
            }

            else if ((campo1 == "A") && (campo2 == "B") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 38";
            }

            else if ((campo1 == "A") && (campo2 == "B") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 39";
            }

            else if ((campo1 == "A") && (campo2 == "B") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 40";
            }

            else if ((campo1 == "B") && (campo2 == "A") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 41";
            }

            else if ((campo1 == "B") && (campo2 == "A") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 42";
            }

            else if ((campo1 == "B") && (campo2 == "A") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 43";
            }

            else if ((campo1 == "B") && (campo2 == "A") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 44";
            }

            else if ((campo1 == "A") && (campo2 == "AB") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 45";
            }

            else if ((campo1 == "A") && (campo2 == "AB") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 46";
            }

            else if ((campo1 == "A") && (campo2 == "AB") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 47";
            }

            else if ((campo1 == "A") && (campo2 == "AB") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 48";
            }

            else if ((campo1 == "AB") && (campo2 == "A") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 49";
            }

            else if ((campo1 == "AB") && (campo2 == "A") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 50";
            }

            else if ((campo1 == "AB") && (campo2 == "A") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 51";
            }

            else if ((campo1 == "AB") && (campo2 == "A") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 52";
            }

            else if ((campo1 == "B") && (campo2 == "AB") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 53";
            }

            else if ((campo1 == "B") && (campo2 == "AB") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 54";
            }

            else if ((campo1 == "B") && (campo2 == "AB") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 55";
            }

            else if ((campo1 == "B") && (campo2 == "AB") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 56";
            }

            else if ((campo1 == "AB") && (campo2 == "B") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 57";
            }

            else if ((campo1 == "AB") && (campo2 == "B") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 58";
            }

            else if ((campo1 == "AB") && (campo2 == "B") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 59";
            }

            else if ((campo1 == "AB") && (campo2 == "B") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 60";
            }

            else
            {
                lblResultado.Text = "Nenhuma combinação encontrada.";
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Teste.aspx");
        }
    }
}