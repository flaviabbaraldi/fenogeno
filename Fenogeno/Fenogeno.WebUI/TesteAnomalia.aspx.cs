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
    public partial class TesteAnomalia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            BuscarAnomalia();
        }

        private void BuscarAnomalia()
        {

            //cria uma lista vazia
            var lstAnomalia = new List<Anomalia>();

            //adiciona um item default
            lstAnomalia.Add(new Anomalia()
            {
                Descricao = "-- [SELECIONE] --"
            });

            //adiciona na lista os itens que vierem do banco de dados
            lstAnomalia.AddRange(new AnomaliaDAO().BuscarTodos());


            ddlAnomalia.DataTextField = "Descricao";
            ddlAnomalia.DataValueField = "Descricao";
            ddlAnomalia.DataSource = lstAnomalia.OrderBy(o => o.Descricao).ToList();
            ddlAnomalia.DataBind();

            ddlAnomaliaP.DataTextField = "Descricao";
            ddlAnomaliaP.DataValueField = "Descricao";
            ddlAnomaliaP.DataSource = lstAnomalia.OrderBy(o => o.Descricao).ToList();
            ddlAnomaliaP.DataBind();

            ddlAnomaliaF.DataTextField = "Descricao";
            ddlAnomaliaF.DataValueField = "Descricao";
            ddlAnomaliaF.DataSource = lstAnomalia.OrderBy(o => o.Descricao).ToList();
            ddlAnomaliaF.DataBind();

            ddlAnomaliaFP.DataTextField = "Descricao";
            ddlAnomaliaFP.DataValueField = "Descricao";
            ddlAnomaliaFP.DataSource = lstAnomalia.OrderBy(o => o.Descricao).ToList();
            ddlAnomaliaFP.DataBind();
        }

        private void Calcular()
        {
            if (((string.IsNullOrWhiteSpace(ddlAnomalia.SelectedValue) || ddlAnomalia.SelectedValue == "-- [SELECIONE] --") && rdoAnomaliaSim.Checked) || (!rdoAnomaliaSim.Checked && !rdoAnomaliaNao.Checked))
            {
                pnlResp.Visible = false;
                pnlMsgA.Visible = true;
                return;
            }
            else
            {
                pnlMsgA.Visible = false;
            }

            if (((string.IsNullOrWhiteSpace(ddlAnomaliaF.SelectedValue) || ddlAnomaliaF.SelectedValue == "-- [SELECIONE] --") && rdoAnomaliaFSim.Checked) || (!rdoAnomaliaFSim.Checked && !rdoAnomaliaFNao.Checked))
            {
                pnlResp.Visible = false;
                pnlMsgA.Visible = true;
                return;
            }
            else
            {
                pnlMsgA.Visible = false;
            }

            if (((string.IsNullOrWhiteSpace(ddlAnomaliaFP.SelectedValue) || ddlAnomaliaFP.SelectedValue == "-- [SELECIONE] --") && rdoAnomaliaFPSim.Checked) || (!rdoAnomaliaFPSim.Checked && !rdoAnomaliaFPNao.Checked))
            {
                pnlResp.Visible = false;
                pnlMsgA.Visible = true;
                return;
            }
            else
            {
                pnlMsgA.Visible = false;
            }
            if (((string.IsNullOrWhiteSpace(ddlAnomaliaP.SelectedValue) || ddlAnomaliaP.SelectedValue == "-- [SELECIONE] --") && rdoAnomaliaPSim.Checked) || (!rdoAnomaliaPSim.Checked && !rdoAnomaliaPNao.Checked))
            {
                pnlResp.Visible = false;
                pnlMsgA.Visible = true;
                return;
            }
            else
            {
                pnlMsgA.Visible = false;
            }

            string campo1 = ddlAnomalia.SelectedValue;
            string campo2 = ddlAnomaliaP.SelectedValue;
            string campo3 = ddlAnomaliaF.SelectedValue;
            string campo4 = ddlAnomaliaFP.SelectedValue;

            if (rdoAnomaliaNao.Checked && rdoAnomaliaPNao.Checked && rdoAnomaliaFNao.Checked && rdoAnomaliaFPNao.Checked)
            {
                lblResultado.Text = "Não há probabilidades de seu filho portar alguma doença genética";
                pnlResp.Visible = true;
            }

            else if (rdoAnomaliaSim.Checked && (campo1 == "Polidactilia" || campo1 == "Doença de Huntington" || campo1 == "Doença de Hippel") && rdoAnomaliaPNao.Checked && rdoAnomaliaFSim.Checked && (campo3 == "Polidactilia" || campo3 == "Doença de Huntington" || campo3 == "Doença de Hippel") && rdoAnomaliaFPNao.Checked)
            {
                lblResultado.Text = "Seu filho tem 11% de chances de nascer com: " + campo1 + " ou " + campo3;
                pnlResp.Visible = true;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPSim.Checked && (campo2 == "Polidactilia" || campo2 == "Doença de Huntington" || campo2 == "Doença de Hippel") && rdoAnomaliaFNao.Checked && rdoAnomaliaFPSim.Checked && (campo4 == "Polidactilia" || campo4 == "Doença de Huntington" || campo4 == "Doença de Hippel"))
            {
                lblResultado.Text = "Seu filho tem 11% de chances de nascer com: " + campo2 + " ou " + campo4;
                pnlResp.Visible = true;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPNao.Checked && rdoAnomaliaFSim.Checked && (campo3 == "Polidactilia" || campo3 == "Doença de Huntington" || campo3 == "Doença de Hippel") && rdoAnomaliaFPNao.Checked)
            {
                lblResultado.Text = "Seu filho tem 5% de chances de nascer com: " + campo3;
                pnlResp.Visible = true;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPNao.Checked && rdoAnomaliaFNao.Checked && rdoAnomaliaFPSim.Checked && (campo4 == "Polidactilia" || campo4 == "Doença de Huntington" || campo4 == "Doença de Hippel"))
            {
                lblResultado.Text = "Seu filho tem 5% de chances de nascer com: " + campo4;
                pnlResp.Visible = true;
            }

            else if (rdoAnomaliaSim.Checked && (campo1 == "Polidactilia" || campo1 == "Doença de Huntington" || campo1 == "Doença de Hippel") && rdoAnomaliaPSim.Checked && (campo2 == "Polidactilia" || campo2 == "Doença de Huntington" || campo2 == "Doença de Hippel") && rdoAnomaliaFSim.Checked && (campo3 == "Polidactilia" || campo3 == "Doença de Huntington" || campo3 == "Doença de Hippel") && rdoAnomaliaFPSim.Checked && (campo4 == "Polidactilia" || campo4 == "Doença de Huntington" || campo4 == "Doença de Hippel"))
            {
                lblResultado.Text = "Seu filho tem 99% de chances de nascer com: " + campo1 + "," + campo2 + "," + campo3 + "ou" + campo4;
                pnlResp.Visible = true;
            }

            else if (rdoAnomaliaSim.Checked && (campo1 == "Daltonismo" || campo1 == "Albinismo" || campo1 == "Hemofilia") && rdoAnomaliaPNao.Checked && rdoAnomaliaFSim.Checked && (campo3 == "Daltonismo" || campo3 == "Albinismo" || campo3 == "Hemofilia") && rdoAnomaliaFPNao.Checked)
            {
                lblResultado.Text = "Seu filho tem 11% de chances de nascer com: " + campo1 + " ou " + campo3;
                pnlResp.Visible = true;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPSim.Checked && (campo2 == "Daltonismo" || campo2 == "Albinismo" || campo2 == "Hemofilia") && rdoAnomaliaFNao.Checked && rdoAnomaliaFPSim.Checked && (campo4 == "Daltonismo" || campo4 == "Albinismo" || campo4 == "Hemofilia"))
            {
                lblResultado.Text = "Seu filho tem 11% de chances de nascer com: " + campo2 + " ou " + campo4;
                pnlResp.Visible = true;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPNao.Checked && rdoAnomaliaFSim.Checked && (campo3 == "Daltonismo" || campo3 == "Albinismo" || campo3 == "Hemofilia") && rdoAnomaliaFPNao.Checked)
            {
                lblResultado.Text = "Seu filho tem 5% de chances de nascer com: " + campo3;
                pnlResp.Visible = true;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPNao.Checked && rdoAnomaliaFNao.Checked && rdoAnomaliaFPSim.Checked && (campo4 == "Daltonismo" || campo4 == "Albinismo" || campo4 == "Hemofilia"))
            {
                lblResultado.Text = "Seu filho tem 5% de chances de nascer com: " + campo4;
                pnlResp.Visible = true;
            }

            else if (rdoAnomaliaSim.Checked && (campo1 == "Daltonismo" || campo1 == "Albinismo" || campo1 == "Hemofilia") && rdoAnomaliaPSim.Checked && (campo2 == "Daltonismo" || campo2 == "Albinismo" || campo2 == "Hemofilia") && rdoAnomaliaFSim.Checked && (campo3 == "Daltonismo" || campo3 == "Albinismo" || campo3 == "Hemofilia") && rdoAnomaliaFPSim.Checked && (campo4 == "Daltonismo" || campo4 == "Albinismo" || campo4 == "Hemofilia"))
            {
                lblResultado.Text = "Seu filho tem 99% de chances de nascer com: " + campo1 + "," + campo2 + "," + campo3 + "ou" + campo4;
                pnlResp.Visible = true;
            }

            else if (rdoAnomaliaSim.Checked && (campo1 == "Polidactilia" || campo1 == "Doença de Huntington" || campo1 == "Doença de Hippel") && rdoAnomaliaPSim.Checked && (campo2 == "Daltonismo" || campo2 == "Albinismo" || campo2 == "Hemofilia") && rdoAnomaliaFSim.Checked && (campo3 == "Polidactilia" || campo3 == "Doença de Huntington" || campo3 == "Doença de Hippel") && rdoAnomaliaFPSim.Checked && (campo4 == "Daltonismo" || campo4 == "Albinismo" || campo4 == "Hemofilia"))
            {
                lblResultado.Text = "Seu filho tem 99% de chances de nascer com: " + campo1 + "," + campo2 + "," + campo3 + "ou" + campo4;
                pnlResp.Visible = true;
            }

            else if (rdoAnomaliaSim.Checked && (campo1 == "Daltonismo" || campo1 == "Albinismo" || campo1 == "Hemofilia") && rdoAnomaliaPSim.Checked && (campo2 == "Polidactilia" || campo2 == "Doença de Huntington" || campo2 == "Doença de Hippel") && rdoAnomaliaFSim.Checked && (campo3 == "Daltonismo" || campo3 == "Albinismo" || campo3 == "Hemofilia") && rdoAnomaliaFPSim.Checked && (campo4 == "Polidactilia" || campo4 == "Doença de Huntington" || campo4 == "Doença de Hippel"))
            {
                lblResultado.Text = "Seu filho tem 99% de chances de nascer com: " + campo1 + "," + campo2 + "," + campo3 + " ou " + campo4;
                pnlResp.Visible = true;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPNao.Checked && rdoAnomaliaFSim.Checked && (campo3 == "Polidactilia" || campo3 == "Doença de Huntington" || campo3 == "Doença de Hippel") && rdoAnomaliaFPSim.Checked && (campo4 == "Daltonismo" || campo4 == "Albinismo" || campo4 == "Hemofilia"))
            {
                lblResultado.Text = "Seu filho tem 7% de chances de nascer com: " + campo3 + "ou" + campo4;
                pnlResp.Visible = true;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPNao.Checked && rdoAnomaliaFSim.Checked && (campo3 == "Daltonismo" || campo3 == "Albinismo" || campo3 == "Hemofilia") && rdoAnomaliaFPSim.Checked && (campo4 == "Polidactilia" || campo4 == "Doença de Huntington" || campo4 == "Doença de Hippel"))
            {
                lblResultado.Text = "Seu filho tem 7% de chances de nascer com: " + campo3 + "ou" + campo4;
                pnlResp.Visible = true;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPNao.Checked && rdoAnomaliaFSim.Checked && (campo3 == "Polidactilia" || campo3 == "Doença de Huntington" || campo3 == "Doença de Hippel") && rdoAnomaliaFPSim.Checked && (campo4 == "Polidactilia" || campo4 == "Doença de Huntington" || campo4 == "Doença de Hippel"))
            {
                lblResultado.Text = "Seu filho tem 7% de chances de nascer com: " + campo3 + "ou" + campo4;
                pnlResp.Visible = true;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPNao.Checked && rdoAnomaliaFSim.Checked && (campo3 == "Daltonismo" || campo3 == "Albinismo" || campo3 == "Hemofilia") && rdoAnomaliaFPSim.Checked && (campo4 == "Daltonismo" || campo4 == "Albinismo" || campo4 == "Hemofilia"))
            {
                lblResultado.Text = "Seu filho tem 7% de chances de nascer com: " + campo3 + "ou" + campo4;
                pnlResp.Visible = true;
            }

            else if (rdoAnomaliaSim.Checked && (campo1 == "Polidactilia" || campo1 == "Doença de Huntington" || campo1 == "Doença de Hippel") && rdoAnomaliaPNao.Checked && rdoAnomaliaFSim.Checked && (campo3 == "Polidactilia" || campo3 == "Doença de Huntington" || campo3 == "Doença de Hippel") && rdoAnomaliaFPSim.Checked && (campo4 == "Daltonismo" || campo4 == "Albinismo" || campo4 == "Hemofilia"))
            {
                lblResultado.Text = "Seu filho tem 25% de chances de nascer com: " + campo1 + campo3 + "ou" + campo4;
                pnlResp.Visible = true;
            }

            else if (rdoAnomaliaSim.Checked && (campo1 == "Polidactilia" || campo1 == "Doença de Huntington" || campo1 == "Doença de Hippel") && rdoAnomaliaPNao.Checked && rdoAnomaliaFSim.Checked && (campo3 == "Polidactilia" || campo3 == "Doença de Huntington" || campo3 == "Doença de Hippel") && rdoAnomaliaFPSim.Checked && (campo4 == "Polidactilia" || campo4 == "Doença de Huntington" || campo4 == "Doença de Hippel"))
            {
                lblResultado.Text = "Seu filho tem 25% de chances de nascer com: " + campo1 + campo3 + "ou" + campo4;
                pnlResp.Visible = true;
            }

            else if (rdoAnomaliaSim.Checked && (campo1 == "Daltonismo" || campo1 == "Albinismo" || campo1 == "Hemofilia") && rdoAnomaliaPNao.Checked && rdoAnomaliaFSim.Checked && (campo3 == "Daltonismo" || campo3 == "Albinismo" || campo3 == "Hemofilia") && rdoAnomaliaFPSim.Checked && (campo4 == "Polidactilia" || campo4 == "Doença de Huntington" || campo4 == "Doença de Hippel"))
            {
                lblResultado.Text = "Seu filho tem 25% de chances de nascer com: " + campo1 + campo3 + "ou" + campo4;
                pnlResp.Visible = true;
            }

            else if (rdoAnomaliaSim.Checked && (campo1 == "Daltonismo" || campo1 == "Albinismo" || campo1 == "Hemofilia") && rdoAnomaliaPNao.Checked && rdoAnomaliaFSim.Checked && (campo3 == "Daltonismo" || campo3 == "Albinismo" || campo3 == "Hemofilia") && rdoAnomaliaFPSim.Checked && (campo4 == "Daltonismo" || campo4 == "Albinismo" || campo4 == "Hemofilia"))
            {
                lblResultado.Text = "Seu filho tem 25% de chances de nascer com: " + campo1 + campo3 + "ou" + campo4;
                pnlResp.Visible = true;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPSim.Checked && (campo2 == "Polidactilia" || campo2 == "Doença de Huntington" || campo2 == "Doença de Hippel") && rdoAnomaliaFSim.Checked && (campo3 == "Daltonismo" || campo3 == "Albinismo" || campo3 == "Hemofilia") && rdoAnomaliaFPSim.Checked && (campo4 == "Polidactilia" || campo4 == "Doença de Huntington" || campo4 == "Doença de Hippel"))
            {
                lblResultado.Text = "Seu filho tem 25% de chances de nascer com: " + campo2 + campo3 + "ou" + campo4;
                pnlResp.Visible = true;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPSim.Checked && (campo2 == "Polidactilia" || campo2 == "Doença de Huntington" || campo2 == "Doença de Hippel") && rdoAnomaliaFSim.Checked && (campo3 == "Polidactilia" || campo3 == "Doença de Huntington" || campo3 == "Doença de Hippel") && rdoAnomaliaFPSim.Checked && (campo2 == "Polidactilia" || campo2 == "Doença de Huntington" || campo2 == "Doença de Hippel"))
            {
                lblResultado.Text = "Seu filho tem 25% de chances de nascer com: " + campo2 + campo3 + "ou" + campo4;
                pnlResp.Visible = true;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPSim.Checked && (campo2 == "Daltonismo" || campo2 == "Albinismo" || campo2 == "Hemofilia") && rdoAnomaliaFSim.Checked && (campo3 == "Polidactilia" || campo3 == "Doença de Huntington" || campo3 == "Doença de Hippel") && rdoAnomaliaFPSim.Checked && (campo4 == "Daltonismo" || campo4 == "Albinismo" || campo4 == "Hemofilia"))
            {
                lblResultado.Text = "Seu filho tem 25% de chances de nascer com: " + campo2 + campo3 + "ou" + campo4;
                pnlResp.Visible = true;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPSim.Checked && (campo2 == "Daltonismo" || campo2 == "Albinismo" || campo2 == "Hemofilia") && rdoAnomaliaFSim.Checked && (campo3 == "Daltonismo" || campo3 == "Albinismo" || campo3 == "Hemofilia") && rdoAnomaliaFPSim.Checked && (campo4 == "Daltonismo" || campo4 == "Albinismo" || campo4 == "Hemofilia"))
            {
                lblResultado.Text = "Seu filho tem 25% de chances de nascer com: " + campo2 + campo3 + "ou" + campo4;
                pnlResp.Visible = true;
            }
            else if (rdoAnomaliaSim.Checked && (campo1 == "Daltonismo" || campo1 == "Albinismo" || campo1 == "Hemofilia") && rdoAnomaliaPNao.Checked && rdoAnomaliaFNao.Checked && rdoAnomaliaFPSim.Checked && (campo4 == "Daltonismo" || campo4 == "Albinismo" || campo4 == "Hemofilia"))
            {
                lblResultado.Text = "Seu filho tem 11% de chances de nascer com: " + campo1 + " ou " + campo4;
                pnlResp.Visible = true;
            }


            else
            {
                lblResultado.Text = "Nenhuma combinação foi encontrada!";
                pnlResp.Visible = true;
            }

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Teste.aspx");
        }

    