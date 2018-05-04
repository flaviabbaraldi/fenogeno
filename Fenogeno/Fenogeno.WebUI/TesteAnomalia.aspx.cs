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

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            string campo1 = ddlAnomalia.SelectedValue;
            string campo2 = ddlAnomaliaP.SelectedValue;
            string campo3 = ddlAnomaliaF.SelectedValue;
            string campo4 = ddlAnomaliaFP.SelectedValue;

            if (rdoAnomaliaNao.Checked && rdoAnomaliaPNao.Checked && rdoAnomaliaFNao.Checked && rdoAnomaliaFPNao.Checked)
            {
                lblResultado.Text = "Não há probabilidades de seu filho portar alguma doença genética";
            }

            else if (rdoAnomaliaSim.Checked && (campo1 == "Polidactila" || campo1 == "Doença de Huntington" || campo1 == "Doença de Hippel") && rdoAnomaliaPNao.Checked && rdoAnomaliaFSim.Checked && (campo3 == "Polidactila" || campo3 == "Doença de Huntington" || campo3 == "Doença de Hippel") && rdoAnomaliaFPNao.Checked)
            {
                lblResultado.Text = "Wellington é um nome estranho2: " + campo1 + " e " + campo3;
            }

            else if (rdoAnomaliaNao.Checked && rdoAnomaliaPSim.Checked && (campo2 == "Polidactila" || campo2 == "Doença de Huntington" || campo2 == "Doença de Hippel") && rdoAnomaliaFNao.Checked &&  rdoAnomaliaFPSim.Checked && (campo4 == "Polidactila" || campo4 == "Doença de Huntington" || campo4 == "Doença de Hippel"))
            {
                lblResultado.Text = "Wellington é um nome estranho2: " + campo2 + " e " + campo4;
            }



        }
    }
}