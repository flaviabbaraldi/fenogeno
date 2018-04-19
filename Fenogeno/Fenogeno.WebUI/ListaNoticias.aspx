<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaNoticias.aspx.cs" Inherits="Fenogeno.WebUI.ListaNoticias" %>
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
                        <asp:GridView ID="grdNoticias" runat="server" AutoGenerateColumns="false"
                            Width="100%" CssClass="Grid"
                            AlternatingRowStyle-CssClass="alt"
                            PagerStyle-CssClass="pgr" OnSelectedIndexChanged="grdNoticias_SelectedIndexChanged">
                            <Columns>
                                <asp:TemplateField HeaderText="Título">
                                    <HeaderStyle Width="50%" />
                                    <ItemStyle Width="50%" />
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
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
