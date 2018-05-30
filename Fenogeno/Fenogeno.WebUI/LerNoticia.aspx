<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LerNoticia.aspx.cs" Inherits="Fenogeno.WebUI.LerNoticia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-3 text-center">
            <h1>
                <asp:Label ID="lblTitulo" runat="server"></asp:Label>
            </h1>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4 text-center">
            <img runat="server" id="imgNoticia" class="img-responsive" />
        </div>
        <div class="col-md-8">
            <p>
                <asp:Literal ID="lblTexto" runat="server"></asp:Literal>
            </p>
        </div>
    </div>
</asp:Content>
