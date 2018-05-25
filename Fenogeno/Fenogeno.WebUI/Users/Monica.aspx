<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Monica.aspx.cs" Inherits="Fenogeno.WebUI.Monica" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <div class="container">
                        <div class="row">
                            <div class="panel-body">
                                <div class="col-md-7 text-left">
                                    <img class="img-responsive" src="Images/medicap.jpg" alt="Generic placeholder image" width="250" height="200" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-12">
                    <h4><b>Tem alguma dúvida?Pergunte a Doutora Mônica Sampaio</b></h4>
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
