<%@ Page Language="C#" MasterPageFile="~/SiteAdm.Master" AutoEventWireup="true" CodeBehind="ListaEspecialistas.aspx.cs" Inherits="Fenogeno.WebUI.ListaEspecialistas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <div class="form-group">
                <div class="col-md-12">
                    <h1>Especialistas</h1>
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
                    <asp:GridView ID="grdEspecialistas" runat="server" AutoGenerateColumns="false" Width="100%" CssClass="Grid" AlternatingRowStyle-CssClass="alt" PagerStyle-CssClass="pgr">
                        <Columns>
                            <asp:TemplateField HeaderText="CRM">
                                <HeaderStyle Width="10%" />
                                <ItemStyle Width="10%" />
                                <ItemTemplate>
                                    <asp:Label ID="lblCRM" runat="server" Text='<%# Bind("CRM") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Nome">
                                <HeaderStyle Width="25%" />
                                <ItemStyle Width="25%" />
                                <ItemTemplate>
                                    <asp:Label ID="lblNome" runat="server" Text='<%# Bind("Nome") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Formação">
                                <HeaderStyle Width="25%" />
                                <ItemStyle Width="25%" />
                                <ItemTemplate>
                                    <asp:Label ID="lblCurso_f" runat="server" Text='<%# Bind("Curso_f") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Especialização">
                                <HeaderStyle Width="25%" />
                                <ItemStyle Width="25%" />
                                <ItemTemplate>
                                    <asp:Label ID="lblArea_e" runat="server" Text='<%# Bind("Area_e") %>'></asp:Label>
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
        </div>
    </div>
</asp:Content>
