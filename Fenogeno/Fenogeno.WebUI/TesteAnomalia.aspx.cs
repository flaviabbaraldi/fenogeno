using Fenogeno.DataAccess;
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
            var lstAnomalia = new AnomaliaDAO().BuscarTodos();

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

            string campo1 = ddlAnomalia.SelectedValue;
            string campo2 = ddlAnomaliaP.SelectedValue;
            string campo3 = ddlAnomaliaF.SelectedValue;
            string campo4 = ddlAnomaliaFP.SelectedValue;

            if (rdoAnomaliaNao.Checked && rdoAnomaliaPNao.Checked && rdoAnomaliaFNao.Checked && rdoAnomaliaFPNao.Checked)
            {
                lblResultado.Text = "Não há probabilidades de seu filho portar alguma doença genética";
            }

            else if (rdoAnomaliaSim.Checked && (campo1 == "Polidactilia" || campo1 == "Doença de Huntington" || campo1 == "Doença de Hippel") && rdoAnomaliaPNao.Checked && rdoAnomaliaFSim.Checked && (campo3 == "Polidactilia" || campo3 == "Doença de Huntington" || campo3 == "Doença de Hippel") && rdoAnomaliaFPNao.Checked)
            {
                lblResultado.Text = "Seu filho tem 25% de chances de nascer com: " + campo1 + " e " + campo3;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPSim.Checked && (campo2 == "Polidactilia" || campo2 == "Doença de Huntington" || campo2 == "Doença de Hippel") && rdoAnomaliaFNao.Checked && rdoAnomaliaFPSim.Checked && (campo4 == "Polidactilia" || campo4 == "Doença de Huntington" || campo4 == "Doença de Hippel"))
            {
                lblResultado.Text = "Seu filho tem 25% de chances de nascer com: " + campo2 + " e " + campo4;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPNao.Checked && rdoAnomaliaFSim.Checked && (campo3 == "Polidactilia" || campo3 == "Doença de Huntington" || campo3 == "Doença de Hippel") && rdoAnomaliaFPNao.Checked)
            {
                lblResultado.Text = "Wellington é um nome estranho4: " + campo3;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPNao.Checked && rdoAnomaliaFNao.Checked && rdoAnomaliaFPSim.Checked && (campo4 == "Polidactilia" || campo4 == "Doença de Huntington" || campo4 == "Doença de Hippel"))
            {
                lblResultado.Text = "Wellington é um nome estranho5: " + campo4;
            }

            else if (rdoAnomaliaSim.Checked && (campo1 == "Polidactilia" || campo1 == "Doença de Huntington" || campo1 == "Doença de Hippel") && rdoAnomaliaPSim.Checked && (campo2 == "Polidactilia" || campo2 == "Doença de Huntington" || campo2 == "Doença de Hippel") && rdoAnomaliaFSim.Checked && (campo3 == "Polidactilia" || campo3 == "Doença de Huntington" || campo3 == "Doença de Hippel") && rdoAnomaliaFPSim.Checked && (campo4 == "Polidactilia" || campo4 == "Doença de Huntington" || campo4 == "Doença de Hippel"))
            {
                lblResultado.Text = "Wellington é um nome estranho6: " + campo1 + "," + campo2 + "," + campo3 + "e" + campo4;
            }

            else if (rdoAnomaliaSim.Checked && (campo1 == "Daltonismo" || campo1 == "Albinismo" || campo1 == "Hemofilia") && rdoAnomaliaPNao.Checked && rdoAnomaliaFSim.Checked && (campo3 == "Daltonismo" || campo3 == "Albinismo" || campo3 == "Hemofilia") && rdoAnomaliaFPNao.Checked)
            {
                lblResultado.Text = "Wellington é um nome estranho7: " + campo1 + " e " + campo3;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPSim.Checked && (campo2 == "Daltonismo" || campo2 == "Albinismo" || campo2 == "Hemofilia") && rdoAnomaliaFNao.Checked && rdoAnomaliaFPSim.Checked && (campo4 == "Daltonismo" || campo4 == "Albinismo" || campo4 == "Hemofilia"))
            {
                lblResultado.Text = "Wellington é um nome estranho8: " + campo2 + " e " + campo4;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPNao.Checked && rdoAnomaliaFSim.Checked && (campo3 == "Daltonismo" || campo3 == "Albinismo" || campo3 == "Hemofilia") && rdoAnomaliaFPNao.Checked)
            {
                lblResultado.Text = "Wellington é um nome estranho9: " + campo3;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPNao.Checked && rdoAnomaliaFNao.Checked && rdoAnomaliaFPSim.Checked && (campo4 == "Daltonismo" || campo4 == "Albinismo" || campo4 == "Hemofilia"))
            {
                lblResultado.Text = "Wellington é um nome estranho10: " + campo4;
            }

            else if (rdoAnomaliaSim.Checked && (campo1 == "Daltonismo" || campo1 == "Albinismo" || campo1 == "Hemofilia") && rdoAnomaliaPSim.Checked && (campo2 == "Daltonismo" || campo2 == "Albinismo" || campo2 == "Hemofilia") && rdoAnomaliaFSim.Checked && (campo3 == "Daltonismo" || campo3 == "Albinismo" || campo3 == "Hemofilia") && rdoAnomaliaFPSim.Checked && (campo4 == "Daltonismo" || campo4 == "Albinismo" || campo4 == "Hemofilia"))
            {
                lblResultado.Text = "Wellington é um nome estranho11: " + campo1 + "," + campo2 + "," + campo3 + "e" + campo4;
            }

            else if (rdoAnomaliaSim.Checked && (campo1 == "Polidactilia" || campo1 == "Doença de Huntington" || campo1 == "Doença de Hippel") && rdoAnomaliaPSim.Checked && (campo2 == "Daltonismo" || campo2 == "Albinismo" || campo2 == "Hemofilia") && rdoAnomaliaFSim.Checked && (campo3 == "Polidactilia" || campo3 == "Doença de Huntington" || campo3 == "Doença de Hippel") && rdoAnomaliaFPSim.Checked && (campo4 == "Daltonismo" || campo4 == "Albinismo" || campo4 == "Hemofilia"))
            {
                lblResultado.Text = "Wellington é um nome estranho12: " + campo1 + "," + campo2 + "," + campo3 + "e" + campo4;
            }

            else if (rdoAnomaliaSim.Checked && (campo1 == "Daltonismo" || campo1 == "Albinismo" || campo1 == "Hemofilia") && rdoAnomaliaPSim.Checked && (campo2 == "Polidactilia" || campo2 == "Doença de Huntington" || campo2 == "Doença de Hippel") && rdoAnomaliaFSim.Checked && (campo3 == "Daltonismo" || campo3 == "Albinismo" || campo3 == "Hemofilia") && rdoAnomaliaFPSim.Checked && (campo4 == "Polidactilia" || campo4 == "Doença de Huntington" || campo4 == "Doença de Hippel"))
            {
                lblResultado.Text = "Wellington é um nome estranho13: " + campo1 + "," + campo2 + "," + campo3 + "e" + campo4;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPNao.Checked && rdoAnomaliaFSim.Checked && (campo3 == "Polidactilia" || campo3 == "Doença de Huntington" || campo3 == "Doença de Hippel") && rdoAnomaliaFPSim.Checked && (campo4 == "Daltonismo" || campo4 == "Albinismo" || campo4 == "Hemofilia"))
            {
                lblResultado.Text = "Wellington é um nome estranho14: " + campo3 + "e" + campo4;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPNao.Checked && rdoAnomaliaFSim.Checked && (campo3 == "Daltonismo" || campo3 == "Albinismo" || campo3 == "Hemofilia") && rdoAnomaliaFPSim.Checked && (campo4 == "Polidactilia" || campo4 == "Doença de Huntington" || campo4 == "Doença de Hippel"))
            {
                lblResultado.Text = "Wellington é um nome estranho15: " + campo3 + "e" + campo4;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPNao.Checked && rdoAnomaliaFSim.Checked && (campo3 == "Polidactilia" || campo3 == "Doença de Huntington" || campo3 == "Doença de Hippel") && rdoAnomaliaFPSim.Checked && (campo4 == "Polidactilia" || campo4 == "Doença de Huntington" || campo4 == "Doença de Hippel"))
            {
                lblResultado.Text = "Wellington é um nome estranho16: " + campo3 + "e" + campo4;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPNao.Checked && rdoAnomaliaFSim.Checked && (campo3 == "Daltonismo" || campo3 == "Albinismo" || campo3 == "Hemofilia") && rdoAnomaliaFPSim.Checked && (campo4 == "Daltonismo" || campo4 == "Albinismo" || campo4 == "Hemofilia"))
            {
                lblResultado.Text = "Wellington é um nome estranho17: " + campo3 + "e" + campo4;
            }

            else if (rdoAnomaliaSim.Checked && (campo1 == "Polidactilia" || campo1 == "Doença de Huntington" || campo1 == "Doença de Hippel") && rdoAnomaliaPNao.Checked && rdoAnomaliaFSim.Checked && (campo3 == "Polidactilia" || campo3 == "Doença de Huntington" || campo3 == "Doença de Hippel") && rdoAnomaliaFPSim.Checked && (campo4 == "Daltonismo" || campo4 == "Albinismo" || campo4 == "Hemofilia"))
            {
                lblResultado.Text = "Wellington é um nome estranho18: " + campo1 + campo3 + "e" + campo4;
            }

            else if (rdoAnomaliaSim.Checked && (campo1 == "Polidactilia" || campo1 == "Doença de Huntington" || campo1 == "Doença de Hippel") && rdoAnomaliaPNao.Checked && rdoAnomaliaFSim.Checked && (campo3 == "Polidactilia" || campo3 == "Doença de Huntington" || campo3 == "Doença de Hippel") && rdoAnomaliaFPSim.Checked && (campo4 == "Polidactilia" || campo4 == "Doença de Huntington" || campo4 == "Doença de Hippel"))
            {
                lblResultado.Text = "Wellington é um nome estranho19: " + campo1 + campo3 + "e" + campo4;
            }

            else if (rdoAnomaliaSim.Checked && (campo1 == "Daltonismo" || campo1 == "Albinismo" || campo1 == "Hemofilia") && rdoAnomaliaPNao.Checked && rdoAnomaliaFSim.Checked && (campo3 == "Daltonismo" || campo3 == "Albinismo" || campo3 == "Hemofilia") && rdoAnomaliaFPSim.Checked && (campo4 == "Polidactilia" || campo4 == "Doença de Huntington" || campo4 == "Doença de Hippel"))
            {
                lblResultado.Text = "Wellington é um nome estranho20: " + campo1 + campo3 + "e" + campo4;
            }

            else if (rdoAnomaliaSim.Checked && (campo1 == "Daltonismo" || campo1 == "Albinismo" || campo1 == "Hemofilia") && rdoAnomaliaPNao.Checked && rdoAnomaliaFSim.Checked && (campo3 == "Daltonismo" || campo3 == "Albinismo" || campo3 == "Hemofilia") && rdoAnomaliaFPSim.Checked && (campo4 == "Daltonismo" || campo4 == "Albinismo" || campo4 == "Hemofilia"))
            {
                lblResultado.Text = "Wellington é um nome estranho21: " + campo1 + campo3 + "e" + campo4;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPSim.Checked && (campo2 == "Polidactilia" || campo2 == "Doença de Huntington" || campo2 == "Doença de Hippel") && rdoAnomaliaFSim.Checked && (campo3 == "Daltonismo" || campo3 == "Albinismo" || campo3 == "Hemofilia") && rdoAnomaliaFPSim.Checked && (campo4 == "Polidactilia" || campo4 == "Doença de Huntington" || campo4 == "Doença de Hippel"))
            {
                lblResultado.Text = "Wellington é um nome estranho22: " + campo2 + campo3 + "e" + campo4;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPSim.Checked && (campo2 == "Polidactilia" || campo2 == "Doença de Huntington" || campo2 == "Doença de Hippel") && rdoAnomaliaFSim.Checked && (campo3 == "Polidactilia" || campo3 == "Doença de Huntington" || campo3 == "Doença de Hippel") && rdoAnomaliaFPSim.Checked && (campo2 == "Polidactilia" || campo2 == "Doença de Huntington" || campo2 == "Doença de Hippel"))
            {
                lblResultado.Text = "Wellington é um nome estranho23: " + campo2 + campo3 + "e" + campo4;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPSim.Checked && (campo2 == "Daltonismo" || campo2 == "Albinismo" || campo2 == "Hemofilia") && rdoAnomaliaFSim.Checked && (campo3 == "Polidactilia" || campo3 == "Doença de Huntington" || campo3 == "Doença de Hippel") && rdoAnomaliaFPSim.Checked && (campo4 == "Daltonismo" || campo4 == "Albinismo" || campo4 == "Hemofilia"))
            {
                lblResultado.Text = "Wellington é um nome estranho24: " + campo2 + campo3 + "e" + campo4;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPSim.Checked && (campo2 == "Daltonismo" || campo2 == "Albinismo" || campo2 == "Hemofilia") && rdoAnomaliaFSim.Checked && (campo3 == "Daltonismo" || campo3 == "Albinismo" || campo3 == "Hemofilia") && rdoAnomaliaFPSim.Checked && (campo4 == "Daltonismo" || campo4 == "Albinismo" || campo4 == "Hemofilia"))
            {
                lblResultado.Text = "Wellington é um nome estranho25: " + campo2 + campo3 + "e" + campo4;
            }


            else
            {
                lblResultado.Text = "Nenhuma combinação foi encontrada!";
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
    }
}