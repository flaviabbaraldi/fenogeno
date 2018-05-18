using Fenogeno.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fenogeno.WebUI
{
    public partial class TesteCarcFisica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

            CarregarOlhos();
            CarregarCabelo();
            CarregarPele();
        }

        private void CarregarOlhos()
        {
            var lstOlhos = new OlhoDAO().BuscarTodos();

            ddlOlhos.DataTextField = "Descricao";
            ddlOlhos.DataValueField = "Descricao";
            ddlOlhos.DataSource = lstOlhos.OrderBy(o => o.Descricao).ToList();
            ddlOlhos.DataBind();


            ddlOlhosP.DataTextField = "Descricao";
            ddlOlhosP.DataValueField = "Descricao";
            ddlOlhosP.DataSource = lstOlhos.OrderBy(o => o.Descricao).ToList();
            ddlOlhosP.DataBind();
        }

        private void CarregarCabelo()
        {
            var lstCabelo = new CabeloDAO().BuscarTodos();

            ddlCabelo.DataTextField = "Descricao";
            ddlCabelo.DataValueField = "Descricao";
            ddlCabelo.DataSource = lstCabelo.OrderBy(o => o.Descricao).ToList();
            ddlCabelo.DataBind();

            ddlCabeloP.DataTextField = "Descricao";
            ddlCabeloP.DataValueField = "Descricao";
            ddlCabeloP.DataSource = lstCabelo.OrderBy(o => o.Descricao).ToList();
            ddlCabeloP.DataBind();
        }

        private void CarregarPele()
        {
            var lstPele = new PeleDAO().BuscarTodos();

            ddlPele.DataTextField = "Descricao";
            ddlPele.DataValueField = "Descricao";
            ddlPele.DataSource = lstPele.OrderBy(o => o.Descricao).ToList();
            ddlPele.DataBind();

            ddlPeleP.DataTextField = "Descricao";
            ddlPeleP.DataValueField = "Descricao";
            ddlPeleP.DataSource = lstPele.OrderBy(o => o.Descricao).ToList();
            ddlPeleP.DataBind();

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
           
        }

        protected void btnOlhos_Click(object sender, EventArgs e)
        {
            string campo1 = ddlOlhos.SelectedValue;
            string campo2 = ddlOlhosP.SelectedValue;


            if ((campo1 == "Azul") && (campo2 == "Castanho"))
            {
                lblResultadoO.Text = "Seu filho tem 50% de chance de ter olhos azuis e 50% castanhos.";
            }
            else if ((campo1 == "Azul")&& (campo2 == "Verde"))
            {
                lblResultadoO.Text = "Seu filho tem 50% de chance de ter olhos azuis e 50% verdes.";
            }
            else if ((campo1 == "Verde") && (campo2 == "Castanho"))
            {
                lblResultadoO.Text = "Seu filho tem 50% de chance de ter olhos castanhos, 37,5% de chance de serem verdes e 12,5% de serem azuis.";
            }
            else if ((campo1 == "Castanho") && (campo2 == "Castanho"))
            {
                lblResultadoO.Text = "Seu filho tem 75% de chance de ter olhos castanhos, 18,75% de chance de serem verdes e 6,25% de serem azuis. ";
            }
            else if ((campo1 == "Verde") && (campo2 == "Verde"))
            {
                lblResultadoO.Text = "Seu filho tem 75% de chance de ter olhos verdes, 25% de chance de serem azuis e 1% de serem castanhos.";
            }
            else if ((campo1 == "Azul") && (campo2 == "Azul"))
            {
                lblResultadoO.Text = "Seu filho tem 99% de chance de ter olhos azuis e 1% de serem verdes.";
            }
            else if ((campo1 == "Castanho") && (campo2 == "Azul"))
            {
                lblResultadoO.Text = "Seu filho tem 50% de chance de ter olhos azuis e 50% castanhos.";
            }
            else if ((campo1 == "Verde") && (campo2 == "Azul"))
            {
                lblResultadoO.Text = "Seu filho tem 50% de chance de ter olhos azuis e 50% verdes.";
            }
            else if ((campo1 == "Castanho") && (campo2 == "Verde"))
            {
                lblResultadoO.Text = "Seu filho tem 50% de chance de ter olhos castanhos, 37,5% de chance de serem verdes e 12,5% de serem azuis.";
            }
            else
            {
                lblResultadoO.Text = "Nenhum resultado encontrado.";
            }
        }
    }
}