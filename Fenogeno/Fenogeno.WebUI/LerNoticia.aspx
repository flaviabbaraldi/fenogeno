<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LerNoticia.aspx.cs" Inherits="Fenogeno.WebUI.LerNoticia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <form class="form-horizontal" runat="server">
                <h1>
                    <asp:Label ID="lblTitulo" runat="server"></asp:Label>
                </h1>
                <img class="img-responsive" src="Images/vacinas-gravidez.jpeg" />
                <br />
                <p>
                    <asp:Label ID="lblConteudo" runat="server"></asp:Label>
                </p>
            </form>
        </div>
    </div>
</asp:Content>
