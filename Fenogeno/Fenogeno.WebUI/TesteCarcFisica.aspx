<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TesteCarcFisica.aspx.cs" Inherits="Fenogeno.WebUI.TesteCarcFisica" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <h2>Testes Características Físicas</h2>
            <div class="form-group">
                <div class="col-md-4">
                    <asp:Label ID="lblOlhos" runat="server" CssClass="control-label">Qual a cor dos seus olhos?</asp:Label>
                    <asp:DropDownList ID="ddlOlhos" runat="server" CssClass="form-control" />
                </div>
                <div class="col-md-4">
                    <asp:Label ID="lblOlhosP" runat="server" CssClass="control-label">Qual a cor dos olhos de seu parceiro?</asp:Label>
                    <asp:DropDownList ID="ddlOlhosP" runat="server" CssClass="form-control" />
                </div>
                <div class="col-md-1" style="padding-top: 20px;">
                    <asp:Button ID="btnOlhos" runat="server" Text="Calcular" CssClass="btn btn-danger" OnClick="btnCalcularOlhos_Click" />
                </div>
                <div class="col-md-3 text-center">
                     <asp:Panel ID="pnlRespO" runat="server" Visible="false">
                        <div class="form-group">
                            <div class="col-md-12 text-center">
                                <div class="alert alert-success" role="alert" style="margin-bottom: 0px !important;">
                                    <asp:Label ID="lblResultadoO" runat="server" CssClass="control-label"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </asp:Panel>
                    
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-4">
                    <asp:Label ID="lblcabelo" runat="server"
                        CssClass="control-label">Qual a cor natural do seu cabelo?</asp:Label>
                    <asp:DropDownList ID="ddlCabelo" runat="server" CssClass="form-control" />
                </div>
                <div class="col-md-4">
                    <asp:Label ID="lblCabeloP" runat="server"
                        CssClass="control-label">Qual a cor natural do cabelo do seu parceiro?</asp:Label>
                    <asp:DropDownList ID="ddlCabeloP" runat="server" CssClass="form-control" />
                </div>
                <div class="col-md-1" style="padding-top: 20px;">
                    <asp:Button ID="btnCabelo" runat="server" Text="Calcular" CssClass="btn btn-danger" OnClick="btnCalcularCabelo_Click" />
                </div>
                <div class="col-md-3">
                    <asp:Panel ID="pnlRespC" runat="server" Visible="false">
                        <div class="form-group">
                            <div class="col-md-12 text-center">
                                <div class="alert alert-success" role="alert" style="margin-bottom: 0px !important;">
                                    <asp:Label ID="lblResultadoC" runat="server" CssClass="control-label"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </asp:Panel>
                    
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-4">
                    <asp:Label ID="lblPele" runat="server"
                        CssClass="control-label">Qual a sua cor de pele?</asp:Label>
                    <asp:DropDownList ID="ddlPele" runat="server" CssClass="form-control" />
                </div>
                <div class="col-md-4">
                    <asp:Label ID="lblPeleP" runat="server"
                        CssClass="control-label"> Qual a cor de pele do seu parceiro?</asp:Label>
                    <asp:DropDownList ID="ddlPeleP" runat="server" CssClass="form-control" />
                </div>
                <div class="col-md-1" style="padding-top: 20px;">
                    <asp:Button ID="btnPele" runat="server" Text="Calcular" CssClass="btn btn-danger" OnClick="btnCalcularPele_Click" />
                </div>
                <div class="col-md-3">
                    <asp:Panel ID="pnlResP" runat="server" Visible="false">
                        <div class="form-group">
                            <div class="col-md-12 text-center">
                                <div class="alert alert-success" role="alert" style="margin-bottom: 0px !important;">
                                    <asp:Label ID="lblResultadoP" runat="server" CssClass="control-label"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </asp:Panel>
                </div>
            </div>

            <%--<div class="form-group">
                    <div class="col-md-6">
                        <asp:Label ID="lblAltura" runat="server"
                            CssClass="control-label">Qual sua altura?</asp:Label>
                        <asp:TextBox ID="txtAltura" runat="server" CssClass="form-control" />
                    </div>

                    <div class="col-md-6">
                        <asp:Label ID="lblAlturaP" runat="server"
                            CssClass="control-label">Qual a altura de seu parceiro?</asp:Label>
                        <asp:TextBox ID="txtAlturaP" runat="server" CssClass="form-control" />
                    </div>
                </div>--%>

            <asp:Panel ID="pnlMsgO" runat="server" Visible="false">
                <div class="form-group">
                    <div class="col-md-12 text-center">
                        <div class="alert alert-danger" role="alert" style="margin-bottom: 0px !important;">
                            <strong>Alerta!</strong> Selecione a cor dos olhos!
                        </div>
                    </div>
                </div>
            </asp:Panel>


            <asp:Panel ID="pnlMsgC" runat="server" Visible="false">
                <div class="form-group">
                    <div class="col-md-12 text-center">
                        <div class="alert alert-danger" role="alert" style="margin-bottom: 0px !important;">
                            <strong>Alerta!</strong> Selecione a cor do cabelo!
                        </div>
                    </div>
                </div>
            </asp:Panel>

            <asp:Panel ID="pnlMsgP" runat="server" Visible="false">
                <div class="form-group">
                    <div class="col-md-12 text-center">
                        <div class="alert alert-danger" role="alert" style="margin-bottom: 0px !important;">
                            <strong>Alerta!</strong> Selecione a cor da pele!
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <div class="form-group">
                <div class="col-md-12 text-right">
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-black" OnClick="btnCancelar_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
