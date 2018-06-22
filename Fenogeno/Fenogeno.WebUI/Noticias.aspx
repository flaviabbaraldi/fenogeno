<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Noticias.aspx.cs" Inherits="Fenogeno.WebUI.Noticias" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        .table > tbody > tr > td, .table > tbody > tr > th, .table > tfoot > tr > td, .table > tfoot > tr > th, .table > thead > tr > td, .table > thead > tr > th {
            border: none !important;
        }
    </style>
    <div class="row">
        <div class="col-md-12">
            <h2>Notícias</h2>
            <asp:DataList ID="gridView" CssClass="table text-center" runat="server" RepeatColumns="1" RepeatLayout="Table">
                <ItemTemplate>
                    <div class="row">
                        <div class="col-md-4">
                            <img class="img-responsive" src="<%# ResolveUrl(string.Format("~/Uploads/{0}", (string)Eval("Foto"))) %>" />
                        </div>
                        <div class="col-md-8 text-left">
                            <div class="row">
                                <div class="col-md-12">
                                    <h3><%# Eval("Titulo") %></h3>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <h5><%# Eval("Subtitulo") %></h5>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <a class="btn btn-danger" href="<%# ResolveUrl(string.Format("~/LerNoticia.aspx?id={0}", Eval("Cod"))) %>">Ver mais...</a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <br />
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
</asp:Content>
