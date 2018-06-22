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
                                    <div class="col-md-6 text-left">
                                        <img runat="server" id="imgEspecialista" class="img-responsive" alt="Generic placeholder image" width="250" height="200" />
                                        <div class="row">
                                            <div class="col-md-6 text-center">
                                                <b>
                                                    <asp:Label ID="lblNome" runat="server" CssClass="control-label" align="center"></asp:Label></b>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-md-3 text-left">
                                        <div class="row">
                                            <b>
                                                <asp:Label ID="lblFormacao" runat="server" CssClass="control-label" Text="Formação"></asp:Label></b>
                                        </div>
                                        <div class="row">
                                            <asp:Label ID="lblCurso" runat="server" CssClass="control-label"></asp:Label>
                                        </div>

                                        <div class="row">
                                            <asp:Label ID="lblUniversidadeF" runat="server" CssClass="control-label"></asp:Label>
                                        </div>
                                        <div class="row">
                                            <asp:Label ID="lblDuracaoF" runat="server" CssClass="control-label"></asp:Label>
                                        </div>
                                    </div>

                                    <div class="col-md-3">
                                        <div class="row">
                                            <b>
                                                <asp:Label ID="lblEspecializacao" runat="server" CssClass="control-label" Text="Especilização"></asp:Label></b>
                                        </div>
                                        <div class="row">
                                            <asp:Label ID="lblCursoE" runat="server" CssClass="control-label"></asp:Label>
                                        </div>
                                        <div class="row">
                                            <asp:Label ID="lblUniversidadeE" runat="server" CssClass="control-label"></asp:Label>
                                        </div>
                                        <div class="row">
                                            <asp:Label ID="lblDuracaoE" runat="server" CssClass="control-label"></asp:Label>
                                        </div>
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
                    <asp:Button ID="btnEnviar" runat="server" Text="Enviar" CssClass="btn btn-danger" OnClick="btnEnviar_Click" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-danger" OnClick="btnCancelar_Click" />
                </div>
            </div>
            <asp:Panel ID="pnlMsgAlerta" runat="server" Visible="false">
                <div class="form-group">
                    <div class="col-md-12 text-center">
                        <div class="alert alert-danger" role="alert" style="margin-bottom: 0px !important;">
                            <strong>Alerta!</strong> Não foi possível enviar sua dúvida!Tente novamente mais tarde!
                        </div>
                    </div>
                </div>
            </asp:Panel>

            <asp:Panel ID="pnlMsg" runat="server" Visible="false">
                <div class="col-md-12 text-center">
                    <div class="alert alert-success" role="alert" style="margin-bottom: 0px !important;">
                        <strong>Comentário inserido com sucesso!</strong>
                    </div>
                </div>
            </asp:Panel>
        </div>
    </div>
    <div class="form-group">
        <div class="col-md-12">
            <asp:DataList ID="grdComentario" CssClass="table text-center" runat="server" RepeatColumns="1" RepeatLayout="Table">
                <ItemTemplate>
                    <div class="form-group">
                        <div class="col-md-2">
                            <img class="img-circle" runat="server" src="Images/avatar_2x.png" alt="Generic placeholder image" style="width: 100px;" />

                        </div>
                        <div class="col-md-10 text-left">
                            <div class="form-group">
                                <div class="col-md-12">
                                    <label><%# Eval("Usuario.Nome") %></label>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-12">
                                    <label><%# Eval("DataHora") %></label>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-12">
                                    <span><%# Eval("Texto") %></span>
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
