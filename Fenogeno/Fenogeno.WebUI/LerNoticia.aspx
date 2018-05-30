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
     <br />
    <div class="row">
        <div class="form-group">
            <div class="col-md-12">
               <h3><b>Deseja fazer algum comentário?</b></h3>
                <asp:TextBox ID="txtComentario" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-12 text-right">
                <asp:Button ID="btnEnviar" runat="server" CssClass="btn btn-primary" Text="Enviar" />
                <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-primary" Text="Cancelar" />
            </div>
        </div>
    </div>
</asp:Content>
