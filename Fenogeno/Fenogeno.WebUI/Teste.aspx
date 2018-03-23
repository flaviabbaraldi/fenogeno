<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Teste.aspx.cs" Inherits="Fenogeno.WebUI.Testes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="row">
        <div class="col-md-12">
            <form runat="server" class="form-horizontal">
                <h2>Testes</h2>

                <div class="row">
                    <div class="col-md-4">
                        <img class="img-responsive" src="Images/teste_carcfisicas.jpg" />
                    </div>
                    <div class="col-md-8">
                        <div class="row">
                            <div class="col-md-12">
                                <h3>Características Físicas </h3>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <h5>Aqui você poderá saber as probabilidades em relação a cor dos olhos,
                                    cabelo, pele e altura que o seu filho(a) tende a nascer.</h5>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <a class="btn btn-primary" href="TesteCarcFisica.aspx">Ver mais...</a>
                            </div>
                        </div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-4">
                        <img class="img-responsive" src="Images/teste_sang.jpg" />
                    </div>
                    <div class="col-md-8">
                        <div class="row">
                            <div class="col-md-12">
                                <h3>Sanguíneo</h3>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <h5>Aqui você poderá saber as probabilidades em relação a tipagem sanguínea que o seu filho tende a nascer.</h5>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <a class="btn btn-primary" href="TesteSanguineo.aspx">Ver mais...</a>
                            </div>
                        </div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-md-4">
                        <img class="img-responsive" src="Images/teste_doençasgeneticas.jpg" />
                    </div>
                    <div class="col-md-8">
                        <div class="row">
                            <div class="col-md-12">
                                <h3>Doenças Genéticas</h3>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <h5>Aqui você poderá saber as probabilidades que o seu filho tem de desenvolver algum tipo de doenças genéticas.</h5>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <a class="btn btn-primary" href="TesteAnomalia.aspx">Ver mais...</a>
                            </div>
                        </div>
                    </div>
                </div>


            </form>
        </div>

    </div>
</asp:Content>
