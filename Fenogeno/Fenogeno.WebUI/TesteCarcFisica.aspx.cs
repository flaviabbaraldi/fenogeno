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
            //cria uma lista vazia
            var lstOlhos = new List<Olho>();

            //adiciona um item default
            lstOlhos.Add(new Olho()
            {
                Descricao = "-- [SELECIONE] --"
            });

            //adiciona na lista os itens que vierem do banco de dados
            lstOlhos.AddRange(new OlhoDAO().BuscarTodos());


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
            //cria uma lista vazia
            var lstCabelo = new List<Cabelo>();

            //adiciona um item default
            lstCabelo.Add(new Cabelo()
            {
                Descricao = "-- [SELECIONE] --"
            });

            //adiciona na lista os itens que vierem do banco de dados
            lstCabelo.AddRange(new CabeloDAO().BuscarTodos());

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
            //cria uma lista vazia
            var lstPele = new List<Pele>();

            //adiciona um item default
            lstPele.Add(new Pele()
            {
                Descricao = "-- [SELECIONE] --"
            });

            //adiciona na lista os itens que vierem do banco de dados
            lstPele.AddRange(new PeleDAO().BuscarTodos());

            ddlPele.DataTextField = "Descricao";
            ddlPele.DataValueField = "Descricao";
            ddlPele.DataSource = lstPele.OrderBy(o => o.Descricao).ToList();
            ddlPele.DataBind();

            ddlPeleP.DataTextField = "Descricao";
            ddlPeleP.DataValueField = "Descricao";
            ddlPeleP.DataSource = lstPele.OrderBy(o => o.Descricao).ToList();
            ddlPeleP.DataBind();

        }



        protected void btnCalcularOlhos_Click(object sender, EventArgs e)
        {
            CalcularOlhos();
        }

        private void CalcularOlhos()
        {


            if (string.IsNullOrWhiteSpace(ddlOlhos.SelectedValue) || ddlOlhos.SelectedValue == "-- [SELECIONE] --" || string.IsNullOrWhiteSpace(ddlOlhosP.SelectedValue) || ddlOlhosP.SelectedValue == "-- [SELECIONE] --")
            {
                pnlMsgO.Visible = true;
                return;
            }

            string campo1 = ddlOlhos.SelectedValue;
            string campo2 = ddlOlhosP.SelectedValue;


            if ((campo1 == "Azul") && (campo2 == "Castanho"))
            {
                lblResultadoO.Text = "Seu filho tem 50% de chances de ter olhos azuis e 50% castanhos.";
            }
            else if ((campo1 == "Azul") && (campo2 == "Verde"))
            {
                lblResultadoO.Text = "Seu filho tem 50% de chances de ter olhos azuis e 50% verdes.";
            }
            else if ((campo1 == "Verde") && (campo2 == "Castanho"))
            {
                lblResultadoO.Text = "Seu filho tem 50% de chances de ter olhos castanhos, 37,5% verdes e 12,5% azuis.";
            }
            else if ((campo1 == "Castanho") && (campo2 == "Castanho"))
            {
                lblResultadoO.Text = "Seu filho tem 75% de chances de ter olhos castanhos, 18,75% verdes e 6,25% azuis. ";
            }
            else if ((campo1 == "Verde") && (campo2 == "Verde"))
            {
                lblResultadoO.Text = "Seu filho tem 75% de chances de ter olhos verdes, 25% azuis e 1% castanhos.";
            }
            else if ((campo1 == "Azul") && (campo2 == "Azul"))
            {
                lblResultadoO.Text = "Seu filho tem 99% de chances de ter olhos azuis e 1% verdes.";
            }
            else if ((campo1 == "Castanho") && (campo2 == "Azul"))
            {
                lblResultadoO.Text = "Seu filho tem 50% de chances de ter olhos azuis e 50% castanhos.";
            }
            else if ((campo1 == "Verde") && (campo2 == "Azul"))
            {
                lblResultadoO.Text = "Seu filho tem 50% de chances de ter olhos azuis e 50% verdes.";
            }
            else if ((campo1 == "Castanho") && (campo2 == "Verde"))
            {
                lblResultadoO.Text = "Seu filho tem 50% de chances de ter olhos castanhos, 37,5% verdes e 12,5% azuis.";
            }
            else
            {
                lblResultadoO.Text = "Nenhuma combinação foi encontrada!";
            }
        }

        //// private void LimparCampos()
        // {
        //     ddlCabelo.Text = string.Empty;
        //     ddlCabeloP.Text = string.Empty;
        //     ddlOlhos.Text = string.Empty;
        //     ddlOlhosP.Text = string.Empty;
        //     ddlPele.Text = string.Empty;
        //     ddlPeleP.Text = string.Empty;

        // }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            //LimparCampos();
            Response.Redirect("~/Teste.aspx");
        }

        protected void btnCalcularCabelo_Click(object sender, EventArgs e)
        {
            CalcularCabelo();

        }

        private void CalcularCabelo()
        {
            if (string.IsNullOrWhiteSpace(ddlCabelo.SelectedValue) || ddlCabelo.SelectedValue == "-- [SELECIONE] --" || string.IsNullOrWhiteSpace(ddlCabeloP.SelectedValue) || ddlCabeloP.SelectedValue == "-- [SELECIONE] --")
            {
                pnlMsgC.Visible = true;
                return;
            }


            string campo3 = ddlCabelo.SelectedValue;
            string campo4 = ddlCabeloP.SelectedValue;


            if ((campo3 == "Castanho") && (campo4 == "Castanho"))
            {
                lblResultadoC.Text = "A cor do cabelo do seu filho tem probabilidades de ser 50% castanho, 25% preto, 3% ruivo, 11% loiro escuro e 11% loiro claro";
            }
            else if ((campo3 == "Castanho") && (campo4 == "Loiro Escuro"))
            {
                lblResultadoC.Text = "A cor do cabelo do seu filho tem probabilidades de ser 50% castanho, 0% preto, 8% ruivo, 25% loiro escuro e 17% loiro claro";
            }
            else if ((campo3 == "Castanho") && (campo4 == "Loiro Claro"))
            {
                lblResultadoC.Text = "A cor do cabelo do seu filho tem probabilidades de ser 50% castanho, 0% preto, 0% ruivo, 16% loiro escuro e 34% loiro claro";
            }
            else if ((campo3 == "Castanho") && (campo4 == "Preto"))
            {
                lblResultadoC.Text = "A cor do cabelo do seu filho tem probabilidades de ser 50% castanho, 50% preto, 0% ruivo, 0% loiro escuro e 0% loiro claro";
            }
            else if ((campo3 == "Castanho") && (campo4 == "Ruivo"))
            {
                lblResultadoC.Text = "A cor do cabelo do seu filho tem probabilidades de ser 50% castanho, 0% preto, 16% ruivo, 34% loiro escuro e 0% loiro claro";
            }
            else if ((campo3 == "Loiro Escuro") && (campo4 == "Castanho"))
            {
                lblResultadoC.Text = "A cor do cabelo do seu filho tem probabilidades de ser 50% castanho, 0% preto, 8% ruivo, 25% loiro escuro e 17% loiro claro";
            }
            else if ((campo3 == "Loiro Escuro") && (campo4 == "Loiro Escuro"))
            {
                lblResultadoC.Text = "A cor do cabelo do seu filho tem probabilidades de ser 0% castanho, 0% preto, 25% ruivo, 50% loiro escuro e 25% loiro claro";
            }
            else if ((campo3 == "Loiro Escuro") && (campo4 == "Loiro Claro"))
            {
                lblResultadoC.Text = "A cor do cabelo do seu filho tem probabilidades de ser 0% castanho, 0% preto, 0% ruivo, 50% loiro escuro e 50% loiro claro";
            }
            else if ((campo3 == "Loiro Escuro") && (campo4 == "Preto"))
            {
                lblResultadoC.Text = "A cor do cabelo do seu filho tem probabilidades de ser 100% castanho, 0% preto, 0% ruivo, 0% loiro escuro e 0% loiro claro";
            }
            else if ((campo3 == "Loiro Escuro") && (campo4 == "Ruivo"))
            {
                lblResultadoC.Text = "A cor do cabelo do seu filho tem probabilidades de ser 0% castanho, 0% preto, 50% ruivo, 50% loiro escuro e 0% loiro claro";
            }
            else if ((campo3 == "Loiro Claro") && (campo4 == "Castanho"))
            {
                lblResultadoC.Text = "A cor do cabelo do seu filho tem probabilidades de ser 50% castanho, 0% preto, 0% ruivo, 16% loiro escuro e 34% loiro claro";
            }
            else if ((campo3 == "Loiro Claro") && (campo4 == "Loiro Escuro"))
            {
                lblResultadoC.Text = "A cor do cabelo do seu filho tem probabilidades de ser 0% castanho, 0% preto, 0% ruivo, 50% loiro escuro e 50% loiro claro";
            }
            else if ((campo3 == "Loiro Claro") && (campo4 == "Loiro Claro"))
            {
                lblResultadoC.Text = "A cor do cabelo do seu filho tem probabilidades de ser 0% castanho, 0% preto, 0% ruivo, 0% loiro escuro e 100% loiro claro";
            }
            else if ((campo3 == "Loiro Claro") && (campo4 == "Preto"))
            {
                lblResultadoC.Text = "A cor do cabelo do seu filho tem probabilidades de ser 100% castanho, 0% preto, 0% ruivo, 0% loiro escuro e 0% loiro claro";
            }
            else if ((campo3 == "Loiro Claro") && (campo4 == "Ruivo"))
            {
                lblResultadoC.Text = "A cor do cabelo do seu filho tem probabilidades de ser 0% castanho, 0% preto, 0% ruivo, 0% loiro escuro e 100% loiro claro";
            }
            else if ((campo3 == "Preto") && (campo4 == "Castanho"))
            {
                lblResultadoC.Text = "A cor do cabelo do seu filho tem probabilidades de ser 50% castanho, 50% preto, 0% ruivo, 0% loiro escuro e 0% loiro claro";
            }
            else if ((campo3 == "Preto") && (campo4 == "Loiro Escuro"))
            {
                lblResultadoC.Text = "A cor do cabelo do seu filho tem probabilidades de ser 100% castanho, 0% preto, 0% ruivo, 0% loiro escuro e 0% loiro claro";
            }
            else if ((campo3 == "Preto") && (campo4 == "Loiro Claro"))
            {
                lblResultadoC.Text = "A cor do cabelo do seu filho tem probabilidades de ser 100% castanho, 0% preto, 0% ruivo, 0% loiro escuro e 0% loiro claro";
            }
            else if ((campo3 == "Preto") && (campo4 == "Preto"))
            {
                lblResultadoC.Text = "A cor do cabelo do seu filho tem probabilidades de ser 0% castanho, 100% preto, 0% ruivo, 0% loiro escuro e 0% loiro claro";
            }
            else if ((campo3 == "Preto") && (campo4 == "Ruivo"))
            {
                lblResultadoC.Text = "A cor do cabelo do seu filho tem probabilidades de ser 100% castanho, 0% preto, 0% ruivo, 0% loiro escuro e 0% loiro claro";
            }
            else if ((campo3 == "Ruivo") && (campo4 == "Castanho"))
            {
                lblResultadoC.Text = "A cor do cabelo do seu filho tem probabilidades de ser 50% castanho, 0% preto, 16% ruivo, 34% loiro escuro e 0% loiro claro";
            }
            else if ((campo3 == "Ruivo") && (campo4 == "Loiro Escuro"))
            {
                lblResultadoC.Text = "A cor do cabelo do seu filho tem probabilidades de ser 0% castanho, 0% preto, 50% ruivo, 50% loiro escuro e 0% loiro claro";
            }
            else if ((campo3 == "Ruivo") && (campo4 == "Loiro Claro"))
            {
                lblResultadoC.Text = "A cor do cabelo do seu filho tem probabilidades de ser 0% castanho, 0% preto, 0% ruivo, 100% loiro escuro e 0% loiro claro";
            }
            else if ((campo3 == "Ruivo") && (campo4 == "Preto"))
            {
                lblResultadoC.Text = "A cor do cabelo do seu filho tem probabilidades de ser 100% castanho, 0% preto, 0% ruivo, 0% loiro escuro e 0% loiro claro";
            }
            else if ((campo3 == "Ruivo") && (campo4 == "Ruivo"))
            {
                lblResultadoC.Text = "A cor do cabelo do seu filho tem probabilidades de ser 0% castanho, 0% preto, 100% ruivo, 0% loiro escuro e 0% loiro claro";
            }
            else
            {
                lblResultadoC.Text = "Nenhuma combinação foi encontrada!";
            }

        }

        protected void btnCalcularPele_Click(object sender, EventArgs e)
        {
            CalcularPele();
        }

        private void CalcularPele()
        {
            string campo5 = ddlPele.SelectedValue;
            string campo6 = ddlPeleP.SelectedValue;

            if ((campo5 == "Pele Clara") && (campo6 == "Pele Clara"))
            {
                lblResultadoP.Text = "Seu filho tem 100% de chances de nascer com a pele clara";
            }
            else if ((campo5 == "Pele Clara") && (campo6 == "Pele Escura"))
            {
                lblResultadoP.Text = "Seu filho tem 50% de chances de ter pele clara e 50% de pele escura";
            }
            else if ((campo5 == "Pele Escura") && (campo6 == "Pele Clara"))
            {
                lblResultadoP.Text = "Seu filho tem 50% de chances de ter pele clara e 50% de pele escura";
            }
            else if ((campo5 == "Pele Escura") && (campo6 == "Pele Escura"))
            {
                lblResultadoP.Text = "Seu filho tem 100% de chances de nascer com a pele clara";
            }
            else
            {
                lblResultadoP.Text = "Nenhuma combinação foi encontrada!";
            }
        }
    }
}