<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TesteAnomalia.aspx.cs" Inherits="Fenogeno.WebUI.TesteAnomalia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <form runat="server" class="form-horizontal">
                <h2>Teste de Anomalia</h2>
                <div class="form-group">
                    <div class="col-md-12">
                        <div class="row">
                            <div class="col-md-12">
                                <asp:Label ID="lblAnomalia" runat="server"
                                    CssClass="control-label">Você tem algum caso de anomalia genética na sua família?</asp:Label>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-4">

                                <asp:RadioButton ID="rdSim" runat="server" GroupName="anomalia" />
                                Sim
                                <asp:RadioButton ID="rdNao" runat="server" GroupName="anomalia" />
                                Não
                                   
                                   
                            </div>
                            <div class="col-md-8">
                                <div class="row">
                                    <div class="col-md-3 text-right">
                                        <asp:Label ID="lblSeSim" runat="server" CssClass="control-label">*Se sim, qual?</asp:Label>
                                    </div>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="txtAnomalia" runat="server" CssClass="form-control" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-12">
                        <div class="row">
                            <div class="col-md-12">
                                <asp:Label ID="Label2" runat="server"
                                    CssClass="control-label">Seu parceiro tem algum caso de anomalia genética na família?</asp:Label>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-4">

                                <asp:RadioButton ID="rdP" runat="server" GroupName="parceiro" />
                                Sim
                                <asp:RadioButton ID="rdPN" runat="server" GroupName="parceiro" />
                                Não
                                   
                                   
                            </div>
                            <div class="col-md-8">
                                <div class="row">
                                    <div class="col-md-3 text-right">
                                        <asp:Label ID="lblParceiro" runat="server" CssClass="control-label">*Se sim, qual?</asp:Label>
                                    </div>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="txtParceiro" runat="server" CssClass="form-control" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-12">
                        <div class="row">
                            <div class="col-md-12">
                                <asp:Label ID="Label1" runat="server"
                                    CssClass="control-label">Existem algum caso de doença genética na sua família?</asp:Label>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-4">

                                <asp:RadioButton ID="rdd" runat="server" GroupName="genética" />
                                Sim
                                <asp:RadioButton ID="rddd" runat="server" GroupName="genética" />
                                Não
                                   
                                   
                            </div>
                            <div class="col-md-8">
                                <div class="row">
                                    <div class="col-md-3 text-right">
                                        <asp:Label ID="lblexiste" runat="server" CssClass="control-label">*Se sim, qual?</asp:Label>
                                    </div>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="txtexiste" runat="server" CssClass="form-control" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-12">
                        <div class="row">
                            <div class="col-md-12">
                                <asp:Label ID="Label3" runat="server"
                                    CssClass="control-label">Seu parceiro tem algum caso de anomalia genética na família do seu parceiro?</asp:Label>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-4">

                                <asp:RadioButton ID="rdSS" runat="server" GroupName="caso " />
                                Sim
                                <asp:RadioButton ID="rdNN" runat="server" GroupName="caso " />
                                Não
                                   
                                   
                            </div>
                            <div class="col-md-8">
                                <div class="row">
                                    <div class="col-md-3 text-right">
                                        <asp:Label ID="lblL" runat="server" CssClass="control-label">*Se sim, qual?</asp:Label>
                                    </div>
                                    <div class="col-md-9">
                                        <asp:TextBox ID="txtT" runat="server" CssClass="form-control" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-12 text-right">
                        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" CssClass="btn btn-primary" />
                    </div>

                </div>

            </form>
        </div>
    </div>
</asp:Content>
