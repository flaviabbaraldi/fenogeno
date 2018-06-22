<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Especialistas.aspx.cs" Inherits="Fenogeno.WebUI.Especialistas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        .table > tbody > tr > td, .table > tbody > tr > th, .table > tfoot > tr > td, .table > tfoot > tr > th, .table > thead > tr > td, .table > thead > tr > th {
            border: none !important;
            max-width: 25%;
            width: 25%;
        }

        span.glyphicon {
            padding-right: 10px;
        }
    </style>
    <div class="row">
        <div class="col-md-12">
            <h2>Especialistas</h2>
            <asp:DataList ID="gridView" CssClass="table text-center" runat="server" RepeatColumns="4" RepeatLayout="Table">
                <ItemTemplate>
                    <div class="form-group">
                        <div class="col-md-12 text-center">
                            <img class="img-circle" src="<%# ResolveUrl(string.Format("~/Uploads/{0}", (string)Eval("Foto"))) %>" alt="" width="140" height="140" />
                            <h4><%# Eval("Nome") %></h4>
                            <div class="form-group">
                                <div class="col-md-12">
                                    <span class="glyphicon glyphicon-book" aria-hidden="true"></span>
                                    <label class="control-label">Formação:</label>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-12">
                                    <span class="glyphicon glyphicon-ok" aria-hidden="true"></span>
                                    <span><%# Eval("Curso_f") %></span>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-12">
                                    <span class="glyphicon glyphicon-ok" aria-hidden="true"></span>
                                    <span><%# Eval("Universidade_c") %></span>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-12">
                                    <span class="glyphicon glyphicon-ok" aria-hidden="true"></span>
                                    <span><%# Eval("Duracao_c") %></span>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-12">
                                    <span class="glyphicon glyphicon-search" aria-hidden="true"></span>
                                    <label class="control-label">Especialização:</label>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-12">
                                    <span class="glyphicon glyphicon-ok" aria-hidden="true"></span>
                                    <span><%# Eval("Area_e") %></span>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-12">
                                    <span class="glyphicon glyphicon-ok" aria-hidden="true"></span>
                                    <span><%# Eval("Universidade_e") %></span>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-12">
                                    <span class="glyphicon glyphicon-ok" aria-hidden="true"></span>
                                    <span><%# Eval("Duracao_e") %></span>
                                </div>
                            </div>
                            <%--<div class="form-group">
                                    <div class="col-md-12">
                                        <span class="glyphicon glyphicon-plus" aria-hidden="true"></span>
                                        <label class="control-label">Curiosidades:</label>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-md-12">
                                        <span class="glyphicon glyphicon-heart" aria-hidden="true">Mais de 700 partos realizados</span>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-md-12">
                                        <span class="glyphicon glyphicon-heart" aria-hidden="true">Mais de 500 consultas realizadas</span>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-md-12">
                                        <span class="glyphicon glyphicon-heart" aria-hidden="true">Residente destaque 2010</span>
                                    </div>
                                </div>--%>
                            <div class="form-group">
                                <div class="col-md-12">
                                    <a href="<%# ResolveUrl(string.Format("~/VerEspecialista.aspx?id={0}", Eval("Cod"))) %>" class="btn btn-danger">Ver Mais...</a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <hr />
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
</asp:Content>
