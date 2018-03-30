<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TesteSanguineo.aspx.cs" Inherits="Fenogeno.WebUI.TesteSanguineo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <form runat="server" class="form-horizontal">
                <h2>Teste Sanguíneo</h2>
                <div class="form-group">

                    <div class="col-md-6">
                        <asp:Label CssClass="control-label" runat="server">Qual seu tipo sanguíneo?</asp:Label>
                        <asp:DropDownList ID="ddlSangue" runat="server" CssClass="form-control" />


                    </div>
                    <div class="col-md-6">
                        <asp:Label CssClass="control-label" runat="server">Qual seu tipo sanguíneo de seu parceiro?</asp:Label>
                        <asp:DropDownList ID="ddlSanguineo" runat="server" CssClass="form-control" />
                    </div>
                </div>
                <div class="form-group">

                    <div class="col-md-6">
                        <asp:Label CssClass="control-label" runat="server">Qual seu fator RH?</asp:Label>
                        <asp:DropDownList ID="ddlRh" runat="server" CssClass="form-control" />
                    </div>

                    <div class="col-md-6">
                        <asp:Label CssClass="control-label" runat="server">Qual seu fator RH de seu parceiro?</asp:Label>
                        <asp:DropDownList ID="ddlRhParc" runat="server" CssClass="form-control" />
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
