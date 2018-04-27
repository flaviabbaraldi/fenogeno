<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TesteCarcFisica.aspx.cs" Inherits="Fenogeno.WebUI.TesteCarcFisica" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <form runat="server" class="form-horizontal">
                <h2>Testes Características Físicas</h2>
                <div class="form-group">
                    <div class="col-md-6">
                        <asp:Label ID="lblOlhos" runat="server"
                            CssClass="control-label">Qual a cor dos seus olhos?</asp:Label>
                        <asp:DropDownList ID="ddlOlhos" runat="server" CssClass="form-control"  />
                    </div>
                    <div class="col-md-6">
                        <asp:Label ID="lblOlhosP" runat="server"
                            CssClass="control-label">Qual a cor dos olhos de seu parceiro?</asp:Label>
                        <asp:DropDownList ID="ddlOlhosP" runat="server" CssClass="form-control" />
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-6">
                        <asp:Label ID="lblcabelo" runat="server"
                            CssClass="control-label">Qual a cor natural do seu cabelo?</asp:Label>
                        <asp:DropDownList ID="ddlCabelo" runat="server" CssClass="form-control" />
                    </div>

                    <div class="col-md-6">
                        <asp:Label ID="lblCabeloP" runat="server"
                            CssClass="control-label">Qual a cor natural do cabelo do seu parceiro?</asp:Label>
                        <asp:DropDownList ID="ddlCabeloP" runat="server" CssClass="form-control" />
                    </div>
                </div>
                <div class="form-group">

                    <div class="col-md-6">
                        <asp:Label ID="lblPele" runat="server"
                            CssClass="control-label">Qual a sua cor de pele?</asp:Label>
                        <asp:DropDownList ID="ddlPele" runat="server" CssClass="form-control" />
                    </div>

                    <div class="col-md-6">
                        <asp:Label ID="lblPeleP" runat="server"
                            CssClass="control-label"> Qual a cor de pele do seu parceiro?</asp:Label>
                        <asp:DropDownList ID="ddlPeleP" runat="server" CssClass="form-control" />
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-6">
                        <asp:Label ID="lblAltura" runat="server"
                            CssClass="control-label">Qual sua altura?</asp:Label>
                        <asp:TextBox ID="txtAltura" runat="server" CssClass="form-control" />
                    </div>

                    <div class="col-md-6">
                        <asp:Label ID="lblAlturaP" runat="server"
                            CssClass="control-label">Qual a altura de seu parceiro?</asp:Label>
                        <asp:DropDownList ID="ddlAtp" runat="server" CssClass="form-control" />
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-12 text-right">
                        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" CssClass="btn btn-primary" />
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-primary" />
                    </div>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
