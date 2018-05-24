<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Fenogeno.WebUI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div id="myCarousel" class="carousel slide" data-ride="carousel">
            <ol class="carousel-indicators">
                <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                <li data-target="#myCarousel" data-slide-to="2"></li>
            </ol>
            <div class="carousel-inner" role="listbox">
                <div class="item active">
                    <img src="<%= ResolveUrl("~/Images/Logo Nsdfseoticia.jpg") %>" alt="First slide">
                    <div class="container">
                        <div class="carousel-caption">
                            <h1></h1>
                            <p>Uma maneira mais fácil de entender a genética!</p>
                        </div>
                    </div>
                </div>
                <div class="item">
                    <img class="second-slide" src="<%= ResolveUrl("~/Images/pediatra.jpg") %>" alt="Second slide">
                    <div class="container">
                        <div class="carousel-caption">
                            <h1>Pediatria</h1>
                            <p>
                                Pediatria é a especialidade da Medicina dedicada ao cuidado da saúde de crianças, adolescentes e pré-adolescentes. Sua atuação abrange aspectos curativos, preventivos e de pesquisa.
                                O pediatra, além de tratar da saúde infantil, pode orientar as famílias sobre sobre questões como alimentação, aleitamento materno, vacinação e prevenção de acidentes.
                            </p>
                        </div>
                    </div>
                </div>
                <div class="item">
                    <img class="third-slide" src="<%= ResolveUrl("~/Images/ENG.jpg") %>" alt="Third slide">
                    <div class="container">
                        <div class="carousel-caption">
                            <h1>Engenharia Genética</h1>
                            <p>Engenharia genética são as técnicas de manipulação e recombinação dos genes, através de um conjunto de conhecimentos científicos (genética, biologia molecular, bioquímica, entre outros), que reformulam, reconstituem, reproduzem e até criam seres vivos. </p>
                        </div>
                    </div>
                </div>
            </div>
            <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>
    </div>
    <div class="container marketing">
        <div class="row">
            <div class="col-lg-4">
                <img class="img-circle" src="<%= ResolveUrl("~/Images/DNAA.jpg") %>" alt="Generic placeholder image" width="140" height="140" />
                <h2></h2>
                <p>Quer saber qual a possibilidade de seu filho nascer com alguma doença genética? </p>
                <br />
                <p><a class="btn btn-danger" href="#" role="button">Clique aqui! &raquo;</a></p>
            </div>
            <div class="col-lg-4">
                <img class="img-circle" src="<%= ResolveUrl("~/Images/especialista.jpg") %>" alt="Generic placeholder image" width="140" height="140">
                <h2></h2>
                <p>
                    Tem dúvidas sobre sua gestação e a saúde de seu bebê?<br />
                    Entre em contato com nossos especialistas!!
                </p>
                <p><a class="btn btn-danger" href="#" role="button">Clique aqui! &raquo;</a></p>
            </div>
        </div>
    </div>
</asp:Content>
