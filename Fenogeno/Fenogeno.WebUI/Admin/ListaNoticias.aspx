<%@ Page Title="" Language="C#" MasterPageFile="~/SiteAdm.Master" AutoEventWireup="true" CodeBehind="ListaNoticias.aspx.cs" Inherits="Fenogeno.WebUI.ListaNoticias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <form runat="server" class="form-horizontal">
                <div class="form-group">
                    <div class="col-md-12">
                        <h1>Notícias</h1>
                        <hr />
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-12">
                        <asp:Button ID="btnCadastrar" runat="server" CssClass="btn btn-primary" Text="Cadastrar" OnClick="btnCadastrar_Click" />
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-12">
                        <asp:GridView ID="grdNoticias" runat="server" AutoGenerateColumns="false" Width="100%" CssClass="Grid" AlternatingRowStyle-CssClass="alt" PagerStyle-CssClass="pgr">
                            <Columns>
                                <asp:TemplateField HeaderText="Título">
                                    <HeaderStyle Width="35%" />
                                    <ItemStyle Width="35%" />
                                    <ItemTemplate>
                                        <asp:Label ID="lblTitulo" runat="server"
                                            Text='<%# Bind("Titulo") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Subtítulo">
                                    <HeaderStyle Width="50%" />
                                    <ItemStyle Width="50%" />
                                    <ItemTemplate>
                                        <asp:Label ID="lblSubtitulo" runat="server"
                                            Text='<%# Bind("Subtitulo") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="&nbsp;" ShowHeader="False">
                                    <HeaderStyle Width="15%" CssClass="text-center" />
                                    <ItemStyle Width="15%" CssClass="text-center" />
                                    <ItemTemplate>
                                        <asp:LinkButton ID="btnEditar" runat="server" Width="16px" Height="16px" ToolTip="Editar" OnClick="btnEditar_Click" CommandArgument='<%# Eval("Cod") %>'>
                                            <span class="glyphicon glyphicon-pencil" aria-hidden="true"></span>
                                        </asp:LinkButton>
                                        <asp:LinkButton ID="btnExcluir" runat="server" Width="16px" Height="16px" ToolTip="Excluir" OnClick="btnExcluir_Click" CommandArgument='<%# Eval("Cod") %>' OnClientClick='if (!confirm("Deseja realmente remover este registro?")) return false;'>
                                            <span class="glyphicon glyphicon-remove" aria-hidden="true"></span>
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
