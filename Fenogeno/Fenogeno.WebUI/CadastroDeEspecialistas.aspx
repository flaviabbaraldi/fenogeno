<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroDeEspecialistas.aspx.cs" Inherits="Fenogeno.WebUI.CadastroDeEspecialistas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <form runat="server" class="form-horizontal">
                <h2>Cadastro de Especialistas</h2>

                <div class="row">

                    <br />
                    <div class="form-group">
                        <h4><b>Dados pessoais</b></h4>
                        <div class="col-md-12">
                            <asp:Label ID="lblNome" runat="server" CssClass="control-label">Nome:</asp:Label>
                            <asp:TextBox ID="txtNome" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-6">
                            <asp:Label ID="lblCPF" runat="server" CssClass="control-label">CPF:</asp:Label>
                            <asp:TextBox ID="txtCPF" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-md-6">
                            <asp:Label ID="lblCRM" runat="server" CssClass="control-label">CRM:</asp:Label>
                            <asp:TextBox ID="txtCRM" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-6">
                            <asp:Label ID="lblEmail" runat="server" CssClass="control-label">Email:</asp:Label>
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-md-6">
                            <asp:Label ID="lblTelefone" runat="server" CssClass="control-label">Telefone:</asp:Label>
                            <asp:TextBox ID="txtTelefone" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>


                    <div class="form-group">
                        <h4><b>Formação</b></h4>
                        <div class="col-md-6">
                            <asp:Label ID="lblCurso" runat="server" CssClass="control-label">Curso:</asp:Label>
                            <asp:TextBox ID="txtFormacao" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>

                        <div class="col-md-6">
                            <asp:Label ID="lblUniversidadeF" runat="server" CssClass="control-label">Universidade:</asp:Label>
                            <asp:TextBox ID="txtUniversidadeF" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-md-4">
                            <asp:Label ID="lblDuracaoF" runat="server" CssClass="control-label">Duração:</asp:Label>
                            <asp:TextBox ID="txtDuracaoF" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-md-4">
                            <asp:Label ID="lblAnoFI" runat="server" CssClass="control-label">Ano Início:</asp:Label>
                            <asp:TextBox ID="txtAnoFI" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-md-4">
                            <asp:Label ID="lblAnoFT" runat="server" CssClass="control-label">Ano Término:</asp:Label>
                            <asp:TextBox ID="txtAnoFT" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>



                    <div class="form-group">
                        <h4><b>Especialização</b></h4>
                        <div class="col-md-6">
                            <asp:Label ID="lblArea" runat="server" CssClass="control-label">Área:</asp:Label>
                            <asp:TextBox ID="txtArea" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>

                        <div class="col-md-6">
                            <asp:Label ID="lblUniversidadeE" runat="server" CssClass="control-label">Universidade:</asp:Label>
                            <asp:TextBox ID="txtUniversidadeE" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-4">
                            <asp:Label ID="lblDuracaoE" runat="server" CssClass="control-label">Duração:</asp:Label>
                            <asp:TextBox ID="txtDuracaoE" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>

                        <div class="col-md-4">
                            <asp:Label ID="lblAnoIE" runat="server" CssClass="control-label">Ano Início:</asp:Label>
                            <asp:TextBox ID="txtAnoIE" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="col-md-4">
                            <asp:Label ID="lblAnoIT" runat="server" CssClass="control-label">Ano Término:</asp:Label>
                            <asp:TextBox ID="txtAnoT" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>



                    <div class="form-group">
                        <div class="col-md-12 text-right">
                            <asp:Button ID="btnSalvar" runat="server" CssClass="btn btn-primary" Text="Salvar" />
                            <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-primary" Text="Cancelar" />
                        </div>
                    </div>


                </div>
            </form>
        </div>
    </div>
</asp:Content>
