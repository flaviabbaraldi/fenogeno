<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Teste.aspx.cs" Inherits="Fenogeno.WebUI.Teste" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <form runat="server" class="form-horizontal">
                <h2>Teste Fenótipo</h2>
                <div class="form-group">
                    <div class="col-md-6">
                        <asp:Label ID="lblOlhos" runat="server"
                            CssClass="control-label">Qual a cor dos seus olhos?</asp:Label>
                        <asp:DropDownList ID="ddlOlhos" runat="server" CssClass="form-control" />
                    </div>
                    <div class="col-md-6">
                        <asp:Label ID="lblOlhosP" runat="server"
                            CssClass="control-label">Qual a cor dos olhos de seu parceiro?</asp:Label>
                        <asp:DropDownList ID="ddlolhOlhosP" runat="server" CssClass="form-control" />
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-6">
                        <asp:Label ID="lblcabelo" runat="server"
                            CssClass="control-label">Qual a cor natural do seu cabelo?</asp:Label>
                        <asp:DropDownList ID="ddlCabelo" runat="server" CssClass="form-control" />
                    </div>

                    <div class="col-md-6">
                        <asp:Label ID="lblCabeloP" runat="server"
                            CssClass="control-label">Qual a cor natural do cabelo do seu parceiro?</asp:Label>
                        <asp:DropDownList ID="ddlCabeloP" runat="server" CssClass="form-control" />
                    </div>
                </div>

                <div class="form-group">

                    <div class="col-md-6">
                        <asp:Label ID="lblPele" runat="server"
                            CssClass="control-label">Qual a sua cor de pele?</asp:Label>
                        <asp:DropDownList ID="ddlPele" runat="server" CssClass="form-control" />
                    </div>

                    <div class="col-md-6">
                        <asp:Label ID="lblPeleP" runat="server"
                            CssClass="control-label"> Qual a cor de pele do seu parceiro?</asp:Label>
                        <asp:DropDownList ID="ddlPeleP" runat="server" CssClass="form-control" />
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-6">
                        <asp:Label ID="lblAltura" runat="server"
                            CssClass="control-label">Qual sua altura?</asp:Label>
                        <asp:TextBox ID="txtAltura" runat="server" CssClass="form-control" />
                    </div>

                    <div class="col-md-6">
                        <asp:Label ID="lblAlturaP" runat="server"
                            CssClass="control-label">Qual a altura de seu parceiro?</asp:Label>
                        <asp:TextBox ID="txtAlturaP" runat="server" CssClass="form-cotrol" />
                    </div>
                </div>

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

                                <input id="Sim" type="radio" checked="checked" />
                                Sim
                                    <input id="Não" type="radio" />
                                Não
                                   
                                   
                            </div>
                            <div class="col-md-8">
                                <div class="row">
                                    <div class="col-md-3 text-right">
                                        <label class="control-label">*Se sim, qual?</label>
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
                                <label class="control-label">Seu parceiro tem algum caso de anomalia genética na  família?</label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">

                                <input id="Radio1" type="radio" />
                                Sim
                                    <input id="Radio2" type="radio" checked="checked" />
                                Não
                                   
                                   
                            </div>
                            <div class="col-md-8">
                                <div class="row">
                                    <div class="col-md-3 text-right">
                                        <label class="control-label">*Se sim, qual?</label>
                                    </div>
                                    <div class="col-md-9">
                                        <input type="text" class="form-control" />
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
                                <label class="control-label">Existe algum caso de doença genética na sua família?</label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">

                                <input id="Radio3" type="radio" checked="checked" />
                                Sim
                                    <input id="Radio4" type="radio" />
                                Não
                                   
                                   
                            </div>
                            <div class="col-md-8">
                                <div class="row">
                                    <div class="col-md-3 text-right">
                                        <label class="control-label">*Se sim, qual?</label>
                                    </div>
                                    <div class="col-md-9">
                                        <input type="text" class="form-control" />
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
                                <label class="control-label">Existe algum caso de doença genética na família do seu parceiro?</label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">

                                <input id="Radio5" type="radio" checked="checked" />
                                Sim
                                    <input id="Radio6" type="radio" />
                                Não
                                   
                                   
                            </div>
                            <div class="col-md-8">
                                <div class="row">
                                    <div class="col-md-3 text-right">
                                        <label class="control-label">*Se sim, qual?</label>
                                    </div>
                                    <div class="col-md-9">
                                        <input type="text" class="form-control" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="form-group">

                    <div class="col-md-6">
                        <label class="control-label">
                            Qual seu tipo sanguíneo?

                        </label>
                        <select id="Select6" class="form-control">
                            <option>A Positivo</option>

                        </select>
                    </div>
                    <div class="col-md-6">
                        <label class="control-label">
                            Qual o tipo sanguíneo do seu parceiro?

                        </label>
                        <select id="Select7" class="form-control">
                            <option>O Negativo</option>

                        </select>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-12 text-right">
                        <input id="Button1" type="button" value="Enviar" class="btn btn-primary" />
                    </div>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
