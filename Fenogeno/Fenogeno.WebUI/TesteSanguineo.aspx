<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TesteSanguineo.aspx.cs" Inherits="Fenogeno.WebUI.TesteSanguineo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <form runat="server" class="form-horizontal">
                <h2>Teste Sanguíneo</h2>
                <div class="form-group">

                    <div class="col-md-6">
                        <asp:Label CssClass="control-label" runat="server">Qual é o seu grupo sanguíneo?</asp:Label>
                        <asp:DropDownList ID="ddlSangue" runat="server" CssClass="form-control" />


                    </div>
                    <div class="col-md-6">
                        <asp:Label CssClass="control-label" runat="server">Qual é o grupo sanguíneo do seu parceiro?</asp:Label>
                        <asp:DropDownList ID="ddlSangueP" runat="server" CssClass="form-control" />
                    </div>
                </div>
                <div class="form-group">

                    <div class="col-md-6">
                        <asp:Label CssClass="control-label" runat="server">Qual seu fator RH?</asp:Label>
                        <asp:DropDownList ID="ddlRh" runat="server" CssClass="form-control" />
                    </div>

                    <div class="col-md-6">
                        <asp:Label CssClass="control-label" runat="server">Qual seu fator RH de seu parceiro?</asp:Label>
                        <asp:DropDownList ID="ddlRhP" runat="server" CssClass="form-control" />
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-12 text-right">
                        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" CssClass="btn btn-primary" OnClick="btnSalvar_Click" />
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-primary" OnClick="btnCancelar_Click" />
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-12">
                        <asp:Label ID="lblResultado" runat="server" CssClass="control-label"></asp:Label>
                    </div>
                </div>

            </form>
        </div>
    </div>
</asp:Content>
