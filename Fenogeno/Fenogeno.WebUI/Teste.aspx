<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Teste.aspx.cs" Inherits="Fenogeno.WebUI.Testes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
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
                            <h5>Quer saber quais são as probabilidades em relação a cor dos olhos, cabelo, pele que o seu filho tem de nascer? Esse é o teste perfeito para você!</h5>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <a class="btn btn-danger" href="TesteCarcFisica.aspx">Ver mais...</a>
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-4">
                    <img class="img-responsive" src="Images/Sangue.jpg" />
                </div>
                <div class="col-md-8">
                    <div class="row">
                        <div class="col-md-12">
                            <h3>Sanguíneo</h3>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <h5>Quer saber quais são os possíveis grupos sanguíneos que o seu filho pode pertencer? Esse é o teste perfeito para você!</h5>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <a class="btn btn-danger" href="TesteSanguineo.aspx">Ver mais...</a>
                        </div>
                    </div>
                </div>
            </div>
            <br />
            <div class="row">
                <div class="col-md-4">
                    <img class="img-responsive" src="Images/TesteAnomaliaFoto.jpg" />
                </div>
                <div class="col-md-8">
                    <div class="row">
                        <div class="col-md-12">
                            <h3>Doenças Genéticas</h3>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <h5>Quer saber se o seu filho tem possibilidade de desenvolver alguma doença genética? Esse é o teste perfeito para você!</h5>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <a class="btn btn-danger" href="TesteAnomalia.aspx">Ver mais...</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
