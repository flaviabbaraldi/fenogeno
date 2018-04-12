<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroNoticia.aspx.cs" Inherits="Fenogeno.WebUI.CadastroNoticia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <form runat="server" class="form-horizontal">
                <h2>Cadastro de Notícias</h2>
                <div class="row">

                    <div class="form-group">                    
                    <div class="col-md-12">
                        <asp:Label ID="lblTitulo" runat="server" CssClass="control-label">Título:</asp:Label>
                        <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                        </div>

                    <div class="form-group">                  
                    <div class="col-md-12">
                        <asp:Label ID="lblDescricao" runat="server" CssClass="control-label">Descrição:</asp:Label>
                        <asp:TextBox ID="txtdescricao" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                          </div>

                    <div class="form-group">                  
                    <div class="col-md-12">
                        <asp:Label ID="lblCorpo" runat="server" CssClass="control-label">Corpo da Notícia:</asp:Label>
                        <asp:TextBox ID="txtCorpo" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                    </div>
                          </div>
                </div>

            </form>
        </div>
    </div>
</asp:Content>
