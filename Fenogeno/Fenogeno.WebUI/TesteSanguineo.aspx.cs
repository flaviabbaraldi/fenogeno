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

            if ((campo1 == "O") && (campo2 == "O") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "Seu filho tem 100% de chances de nascer O-";
            }

            if ((campo1 == "O") && (campo2 == "O") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 3";
            }

            if ((campo1 == "O") && (campo2 == "O") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 4";
            }

            if ((campo1 == "O") && (campo2 == "A") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 5";
            }

            if ((campo1 == "O") && (campo2 == "A") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 6";
            }

            if ((campo1 == "O") && (campo2 == "A") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 7";
            }

            if ((campo1 == "O") && (campo2 == "A") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 8";
            }

            if ((campo1 == "A") && (campo2 == "O") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 9";
            }

            if ((campo1 == "A") && (campo2 == "O") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 10";
            }

            if ((campo1 == "A") && (campo2 == "O") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 11";
            }

            if ((campo1 == "A") && (campo2 == "O") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 12";
            }

            if ((campo1 == "O") && (campo2 == "B") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 13";
            }

            if ((campo1 == "O") && (campo2 == "B") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 14";
            }

            if ((campo1 == "O") && (campo2 == "B") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 15";
            }

            if ((campo1 == "O") && (campo2 == "B") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 16";
            }

            if ((campo1 == "B") && (campo2 == "O") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 17";
            }

            if ((campo1 == "B") && (campo2 == "O") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 18";
            }

            if ((campo1 == "B") && (campo2 == "O") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 19";
            }

            if ((campo1 == "B") && (campo2 == "O") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 20";
            }

            if ((campo1 == "A") && (campo2 == "A") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 21";
            }

            if ((campo1 == "A") && (campo2 == "A") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 22";
            }

            if ((campo1 == "A") && (campo2 == "A") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 23";
            }

            if ((campo1 == "A") && (campo2 == "A") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 24";
            }

            if ((campo1 == "B") && (campo2 == "B") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 25";
            }

            if ((campo1 == "B") && (campo2 == "B") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 26";
            }

            if ((campo1 == "B") && (campo2 == "B") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 27";
            }

            if ((campo1 == "B") && (campo2 == "B") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 28";
            }

            if ((campo1 == "O") && (campo2 == "AB") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 29";
            }

            if ((campo1 == "O") && (campo2 == "AB") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 30";
            }

            if ((campo1 == "O") && (campo2 == "AB") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 31";
            }

            if ((campo1 == "O") && (campo2 == "AB") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 32";
            }

            if ((campo1 == "AB") && (campo2 == "O") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 33";
            }

            if ((campo1 == "AB") && (campo2 == "O") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 34";
            }

            if ((campo1 == "AB") && (campo2 == "O") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 35";
            }

            if ((campo1 == "AB") && (campo2 == "O") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 36";
            }

            if ((campo1 == "A") && (campo2 == "B") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 37";
            }

            if ((campo1 == "A") && (campo2 == "B") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 38";
            }

            if ((campo1 == "A") && (campo2 == "B") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 39";
            }

            if ((campo1 == "A") && (campo2 == "B") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 40";
            }

            if ((campo1 == "B") && (campo2 == "A") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 41";
            }

            if ((campo1 == "B") && (campo2 == "A") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 42";
            }

            if ((campo1 == "B") && (campo2 == "A") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 43";
            }

            if ((campo1 == "B") && (campo2 == "A") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 44";
            }

            if ((campo1 == "A") && (campo2 == "AB") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 45";
            }

            if ((campo1 == "A") && (campo2 == "AB") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 46";
            }

            if ((campo1 == "A") && (campo2 == "AB") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 47";
            }

            if ((campo1 == "A") && (campo2 == "AB") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 48";
            }

            if ((campo1 == "AB") && (campo2 == "A") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 49";
            }

            if ((campo1 == "AB") && (campo2 == "A") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 50";
            }

            if ((campo1 == "AB") && (campo2 == "A") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 51";
            }

            if ((campo1 == "AB") && (campo2 == "A") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 52";
            }

            if ((campo1 == "B") && (campo2 == "AB") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 53";
            }

            if ((campo1 == "B") && (campo2 == "AB") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 54";
            }

            if ((campo1 == "B") && (campo2 == "AB") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 55";
            }

            if ((campo1 == "B") && (campo2 == "AB") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 56";
            }

            if ((campo1 == "AB") && (campo2 == "B") && (campo3 == "+") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 57";
            }

            if ((campo1 == "AB") && (campo2 == "B") && (campo3 == "-") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 58";
            }

            if ((campo1 == "AB") && (campo2 == "B") && (campo3 == "+") && (campo4 == "-"))
            {
                lblResultado.Text = "CASO 59";
            }

            if ((campo1 == "AB") && (campo2 == "B") && (campo3 == "-") && (campo4 == "+"))
            {
                lblResultado.Text = "CASO 60";
            }
        }


    }
}