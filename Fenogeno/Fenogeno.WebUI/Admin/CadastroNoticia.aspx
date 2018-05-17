<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroNoticia.aspx.cs" Inherits="Fenogeno.WebUI.CadastroNoticia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <form runat="server" class="form-horizontal">
                <h2>Cadastro de Notícias</h2>
                <div class="form-group">
                    <div class="col-md-12">
                        <asp:Label ID="lblTitulo" runat="server" CssClass="control-label">Título:</asp:Label>
                        <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-12">
                        <asp:Label ID="lblDescricao" runat="server" CssClass="control-label">Descrição:</asp:Label>
                        <asp:TextBox ID="txtdescricao" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="5"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-12">
                        <asp:Label ID="lblCorpo" runat="server" CssClass="control-label">Corpo da Notícia:</asp:Label>
                        <asp:TextBox ID="txtCorpo" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="10"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-12">
                        <asp:FileUpload ID="fupArquivo" runat="server" />
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-12 text-right">
                        <asp:Button ID="btnSalvar" runat="server" CssClass="btn btn-primary" Text="Salvar" OnClick="btnSalvar_Click" />
                        <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-primary" Text="Cancelar" OnClick="btnCancelar_Click" />
                    </div>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
