<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LerNoticia.aspx.cs" Inherits="Fenogeno.WebUI.LerNoticia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="form-group">
            <div class="col-md-12 text-center">
                <h1>
                    <asp:Label ID="lblTitulo" runat="server"></asp:Label>
                </h1>
                <h5>
                    <asp:Label ID="lblDescricao" runat="server" CssClass="control-label"></asp:Label>
                </h5>
            </div>
        </div>

        <div class="row">
            <div class="form-group">
                <div class="col-md-12 text-center">
                    <img runat="server" id="imgNoticia" alt="Generic placeholder image" width="500" height="400" />

                </div>
            </div>
        </div>

        <div class="row">
            <div class="form-group">
                <div class="col-md-12">
                    <p>
                        <asp:Literal ID="lblTexto" runat="server"></asp:Literal>
                    </p>
                </div>
            </div>
        </div>
    </div>

    <br />
     <asp:Panel ID="pnlMsgAlerta" runat="server" Visible="false">
                 <div class="col-md-12 text-center">
                        <div class="alert alert-danger" role="alert" style="margin-bottom: 0px !important;">
                            <strong>Alerta!</strong> Não foi possível inserir o comentário! Preencha o campo abaixo!
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
 
   
     
    <div class="row">
        <div class="form-group">
            <div class="col-md-12">
                <h3><b>Deseja fazer algum comentário?</b></h3>
                <asp:TextBox ID="txtComentario" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-12 text-right">
                <asp:Button ID="btnEnviar" runat="server" CssClass="btn btn-primary" Text="Enviar" OnClick="btnEnviar_Click" />
                <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-primary" Text="Cancelar" />
            </div>
        </div>
    </div>

    <div class="form-group">
            <div class="col-md-12">
                <asp:DataList ID="grdComentario" CssClass="table text-center" runat="server" RepeatColumns="1" RepeatLayout="Table">
                    <ItemTemplate>
                        <div class="form-group">
                            <div class="col-md-2">
                                <img class="img-circle" runat="server" src="Images/avatar_2x.png"  alt="Generic placeholder image" style="width: 100px;" />
            
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
