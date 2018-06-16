<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TesteAnomalia.aspx.cs" Inherits="Fenogeno.WebUI.TesteAnomalia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <h2>Teste de Anomalia</h2>
            <div class="form-group">
                <div class="col-md-12">
                    <div class="row">
                        <div class="col-md-12">
                            <asp:Label ID="lblAnomalia" runat="server"
                                CssClass="control-label">Você é portador de alguma anomalia genética?</asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-4">
                            <asp:RadioButton ID="rdoAnomaliaSim" runat="server" GroupName="anomalia" />
                            Sim
                                <asp:RadioButton ID="rdoAnomaliaNao" runat="server" GroupName="anomalia" />
                            Não
                        </div>
                        <div class="col-md-8">
                            <div class="row">
                                <div class="col-md-3 text-right">
                                    <asp:Label ID="lblSeSim" runat="server" CssClass="control-label">*Se sim, qual?</asp:Label>
                                </div>
                                <div class="col-md-9">
                                    <asp:DropDownList ID="ddlAnomalia" runat="server" CssClass="form-control" />
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
                                CssClass="control-label">Seu parceiro é portador de alguma anomalia genética?</asp:Label>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-md-4">

                            <asp:RadioButton ID="rdoAnomaliaPSim" runat="server" GroupName="parceiro" />
                            Sim
                                <asp:RadioButton ID="rdoAnomaliaPNao" runat="server" GroupName="parceiro" />
                            Não
                                   
                                   
                        </div>
                        <div class="col-md-8">
                            <div class="row">
                                <div class="col-md-3 text-right">
                                    <asp:Label ID="lblParceiro" runat="server" CssClass="control-label">*Se sim, qual?</asp:Label>
                                </div>
                                <div class="col-md-9">
                                    <asp:DropDownList ID="ddlAnomaliaP" runat="server" CssClass="form-control" />
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
                                CssClass="control-label">Existe algum caso de anomalia genética na sua família?</asp:Label>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-md-4">

                            <asp:RadioButton ID="rdoAnomaliaFSim" runat="server" GroupName="genética" />
                            Sim
                                <asp:RadioButton ID="rdoAnomaliaFNao" runat="server" GroupName="genética" />
                            Não
                                   
                                   
                        </div>
                        <div class="col-md-8">
                            <div class="row">
                                <div class="col-md-3 text-right">
                                    <asp:Label ID="lblexiste" runat="server" CssClass="control-label">*Se sim, qual?</asp:Label>
                                </div>
                                <div class="col-md-9">
                                    <asp:DropDownList ID="ddlAnomaliaF" runat="server" CssClass="form-control" />
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
                                CssClass="control-label">Existe algum caso de anomalia genética na família de seu parceiro?</asp:Label>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-md-4">

                            <asp:RadioButton ID="rdoAnomaliaFPSim" runat="server" GroupName="caso " />
                            Sim
                                <asp:RadioButton ID="rdoAnomaliaFPNao" runat="server" GroupName="caso " />
                            Não
                                   
                                   
                        </div>
                        <div class="col-md-8">
                            <div class="row">
                                <div class="col-md-3 text-right">
                                    <asp:Label ID="lblL" runat="server" CssClass="control-label">*Se sim, qual?</asp:Label>
                                </div>
                                <div class="col-md-9">
                                    <asp:DropDownList ID="ddlAnomaliaFP" runat="server" CssClass="form-control" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-12 text-right">
                    <asp:Button ID="btnSalvar" runat="server" Text="Calcular" CssClass="btn btn-primary" OnClick="btnCalcular_Click" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-primary" OnClick="btnCancelar_Click" />
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-12 text-center">
                    <asp:Label ID="lblResultado" runat="server" CssClass="control-label"></asp:Label>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
