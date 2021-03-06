﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TesteSanguineo.aspx.cs" Inherits="Fenogeno.WebUI.TesteSanguineo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12">
            <h2>Teste Sanguíneo</h2>
            <div class="form-group">

                <div class="col-md-4">
                    <asp:Label ID="lblGrupoS" CssClass="control-label" runat="server">Qual é o seu grupo sanguíneo?</asp:Label>
                    <asp:DropDownList ID="ddlSangue" runat="server" CssClass="form-control" />
                </div>
                <div class="col-md-4">
                    <asp:Label ID="lblGrupoSp" CssClass="control-label" runat="server">Qual é o grupo sanguíneo do seu parceiro?</asp:Label>
                    <asp:DropDownList ID="ddlSangueP" runat="server" CssClass="form-control" />
                </div>
                <div class="col-md-1" style="padding-top: 20px;">
                    <asp:Button ID="btnResultadoSangue" runat="server" Text="Calcular" CssClass="btn btn-danger" OnClick="btnCalcularSangue_Click" />
                </div>
                <div class="col-md-3 text-center">
                    <asp:Panel ID="pnlRespS" runat="server" Visible="false">
                        <div class="form-group">
                            <div class="col-md-12 text-center">
                                <div class="alert alert-success" role="alert" style="margin-bottom: 0px !important;">
                                      <asp:Label ID="lblResultadoS" runat="server" CssClass="control-label"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </asp:Panel>
                  
                </div>
            </div>
            <div class="form-group">

                <div class="col-md-4">
                    <asp:Label CssClass="control-label" runat="server">Qual seu fator RH?</asp:Label>
                    <asp:DropDownList ID="ddlRh" runat="server" CssClass="form-control" />
                </div>

                <div class="col-md-4">
                    <asp:Label CssClass="control-label" runat="server">Qual seu fator RH de seu parceiro?</asp:Label>
                    <asp:DropDownList ID="ddlRhP" runat="server" CssClass="form-control" />
                </div>
                <div class="col-md-1" style="padding-top: 20px;">
                    <asp:Button ID="btnResultadoRH" runat="server" Text="Calcular" CssClass="btn btn-danger" OnClick="btnCalcularRH_Click" />
                </div>
                <div class="col-md-3 text-center">
                    <asp:Panel ID="pnlRespR" runat="server" Visible="false">
                        <div class="form-group">
                            <div class="col-md-12 text-center">
                                <div class="alert alert-success" role="alert" style="margin-bottom: 0px !important;">
                                     <asp:Label ID="lblResultadoR" runat="server" CssClass="control-label"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </asp:Panel>
                
                </div>
            </div>

            <asp:Panel ID="pnlMsgGS" runat="server" Visible="false">
                <div class="form-group">
                    <div class="col-md-12 text-center">
                        <div class="alert alert-danger" role="alert" style="margin-bottom: 0px !important;">
                            <strong>Alerta!</strong> Selecione o grupo sanguíneo!
                        </div>
                    </div>
                </div>
            </asp:Panel>

             <asp:Panel ID="pnlMsgFR" runat="server" Visible="false">
                <div class="form-group">
                    <div class="col-md-12 text-center">
                        <div class="alert alert-danger" role="alert" style="margin-bottom: 0px !important;">
                            <strong>Alerta!</strong> Selecione o fator RH!
                        </div>
                    </div>
                </div>
            </asp:Panel>

            <div class="form-group">
                <div class="col-md-12 text-right">
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-black" OnClick="btnCancelar_Click"  />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
