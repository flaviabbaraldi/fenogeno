<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Fenogeno.WebUI.Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <form runat="server" class="form-horizontal">
                <h2>Cadastro</h2>

                <asp:Panel ID="pnlMsg" runat="server" Visible="false">
                    <div class="form-group">
                        <div class="col-md-12 text-center">
                            <div class="alert alert-danger" role="alert" style="margin-bottom: 0px !important;">
                                <strong>Alerta!</strong> Não foi possível cadastrar o usuário! Verifique se todos os campos obrigatórios estão preenchidos!
                            </div>
                        </div>
                    </div>
                </asp:Panel>

                 
                <asp:Panel ID="pnlCadastro" runat="server" Visible="false">
                    <div class="form-group">
                        <div class="col-md-12 text-center">
                            <div class="alert alert-success" role="alert" style="margin-bottom: 0px !important;">
                                <strong>Parabéns!</strong> Usuário cadastrado com sucesso!
                            </div>
                        </div>
                    </div>
                </asp:Panel>

                <div class="form-group">
                    <div class="col-md-12">
                        <asp:Label ID="lblNome" runat="server" CssClass="control-label">*Nome:</asp:Label>
                        <asp:TextBox ID="txtNome" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-6">
                        <asp:Label ID="lblCidade" runat="server" CssClass="control-label">*Cidade:</asp:Label>
                        <asp:TextBox ID="txtCidade" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                        <asp:Label ID="lblBairro" runat="server" CssClass="control-label">Bairro:</asp:Label>
                        <asp:TextBox ID="txtBairro" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-12">
                        <asp:Label ID="lblEmail" runat="server" CssClass="control-label">*Email:</asp:Label>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-6">
                        <asp:Label ID="lblSenha" runat="server" CssClass="control-label">*Senha:</asp:Label>               
                        <asp:TextBox ID="txtSenha" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                         <asp:Label ID="lblSenhaConf" runat="server" CssClass="control-label">*Confirme sua senha:</asp:Label>               
                        <asp:TextBox ID="txtSenhaConf" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                    </div>
                </div>

                    <div class="form-group">
                    <div class="col-md-12">
                        <asp:FileUpload ID="fupArquivo" runat="server" />
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-12 text-right">
                        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" CssClass="btn btn-primary" OnClick="btnSalvar_Click"  />
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-primary" OnClick="btnCancelar_Click" />
                    </div>
                </div>

            </form>
        </div>
    </div>
</asp:Content>
