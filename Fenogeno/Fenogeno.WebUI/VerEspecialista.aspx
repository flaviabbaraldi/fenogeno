<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VerEspecialista.aspx.cs" Inherits="Fenogeno.WebUI.VerEspecialista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <div class="container">
                        <div class="row">
                            <div class="form-group">
                                <div class="panel-body">
                                    <div class="col-md-7 text-left">
                                        <img runat="server" id="imgEspecialista" class="img-responsive" alt="Generic placeholder image" width="250" height="200" />
                                        <asp:Label ID="lblNome" runat="server" CssClass="control-label"></asp:Label>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-12">
                    <asp:Label ID="lblNomeEspecialista" runat="server" CssClass="control-label"></asp:Label>
                    <asp:TextBox ID="txtDuvida" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-12 text-right">
                    <asp:Button ID="btnEnviar" runat="server" Text="Enviar" CssClass="btn btn-primary" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-primary" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
