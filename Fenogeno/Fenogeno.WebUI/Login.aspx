<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Fenogeno.WebUI.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-6 col-md-offset-3">
            <form runat="server" class="form-horizontal">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Login
                    </div>
                    <div class="panel-body">
                        <div class="form-group">
                            <div class="col-md-12">
                                <asp:Label ID="lblEmail" runat="server"
                                    CssClass="control-label">Email:</asp:Label>
                                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" />
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-12">
                                <asp:Label ID="lblSenha" runat="server"
                                    CssClass="control-label">Senha:</asp:Label>
                                <asp:TextBox ID="txtSenha" runat="server" CssClass="form-control" TextMode="Password" />
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-12 text-center">
                              <a href="#">Já possui cadastro? Clique aqui para se cadastrar!</a>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-md-12">
                                <asp:Button ID="btnEntrar" runat="server" CssClass="btn btn-primary btn-block" Text="Entrar" />
                            </div>
                        </div>
                    </div>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
