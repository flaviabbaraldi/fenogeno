<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Fenogeno.WebUI.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="row">
        <div class="col-md-12">
            <form>
                <div class="form-group">
                    <div class="col-md-12 text-center">
                        <asp:Label ID="lblEmail" runat="server"
                            CssClass="control-label">Email:</asp:Label>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" />
                    </div> 
                </div>
            </form>
        </div>
    </div>
    
</asp:Content>
