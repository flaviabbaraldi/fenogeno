<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Especialista.aspx.cs" Inherits="Fenogeno.WebUI.Especialista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <form runat="server" class="form-horizontal">
                <h2>Especialistas</h2>

                <div class="container marketing">
                    <div class="row">
                        <div class="col-md-3 text-center">
                            <img class="img-circle" src="Images/medico.jpg" alt="Generic placeholder image" width="140" height="140" />
                            <h4>Victor Fernandes</h4>
                            <asp:Label ID="lblmedico" CssClass="control-label" runat="server">Obstetra</asp:Label>
                        </div>

                        <div class="col-md-3 text-center">
                            <img class="img-circle" src="Images/medicap.jpg" alt="Generic placeholder image" width="140" height="140" />
                            <h4>Mônica Sampaio</h4>
                            <asp:Label ID="lblmedica" CssClass="control-label" runat="server">Pediatra</asp:Label>
                        </div>

                        <div class="col-md-3 text-center">
                            <img class="img-circle" src="Images/medicagineco.jpg" alt="Generic placeholder image" width="140" height="140" />
                            <h4>Ana Carolina Menezes</h4>
                            <asp:Label ID="lblgineco" CssClass="control-label" runat="server">Ginecologista</asp:Label>
                        </div>

                        <div class="col-md-3 text-center">
                            <img src="Images/homens-gravata-slim.jpg" class="img-circle" alt="Generic placeholder image" width="140" height="140" />

                            <h4>Gustavo Torres</h4>
                            <asp:Label ID="Label1" CssClass="control-label" runat="server">Engenheiro Genético</asp:Label>
                        </div>
                    </div>
                    <br />
                    <div class="form-group">
                       <div class="col-md-12">

                           <asp:Label CssClass="control-label" runat="server"><b>Tem alguma dúvida?Pergunte aos especialistas:</b></asp:Label>
                           <br />
                            <asp:Label ID="lblEspecialista" runat="server"
                            CssClass="control-label"><b> Selecione um especialista:</b></asp:Label>

                        <asp:DropDownList ID="ddlEspecialista" runat="server" CssClass="form-control" />
                           <asp:TextBox Id="txtDuvida" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>

                       </div>
                    </div>

                       <div class="form-group">
                    <div class="col-md-12 text-right">
                        <asp:Button ID="btnEnviar" runat="server" Text="Enviar" CssClass="btn btn-primary" />
                    </div>
                </div>

                </div>
            </form>
        </div>
    </div>
</asp:Content>
