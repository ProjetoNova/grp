﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TempoGasto.aspx.cs" Inherits="NovaProjectWeb.View.pages.TempoGasto" %>

<!DOCTYPE html>
<html lang="en">

<head runat="server">

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>Nova Project</title>

    <link href="../bower_components/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="../bower_components/metisMenu/dist/metisMenu.min.css" rel="stylesheet">
    <link href="../dist/css/timeline.css" rel="stylesheet">
    <link href="../dist/css/sb-admin-2.css" rel="stylesheet">

    <link href="../bower_components/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">

</head>

<body>

    <div id="wrapper">

        <nav class="navbar navbar-default navbar-static-top" role="navigation" style="margin-bottom: 0">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="index.html">Nova Project</a>
            </div>

            <ul class="nav navbar-top-links navbar-right">
                <li class="dropdown">
                    <a class="dropdown-toggle" data-toggle="dropdown" href="#">
                        <i class="fa fa-user fa-fw"></i><i class="fa fa-caret-down"></i>
                    </a>
                    <ul class="dropdown-menu dropdown-user">
                        <li><a href="#"><i class="fa fa-user fa-fw"></i>Meu Perfil</a>
                        </li>
                        <li><a href="#"><i class="fa fa-gear fa-fw"></i>Configurações</a>
                        </li>
                        <li class="divider"></li>
                        <li><a href="login.aspx"><i class="fa fa-sign-out fa-fw"></i>Sair</a>
                        </li>
                    </ul>
                </li>
            </ul>

            <div class="navbar-default sidebar" role="navigation">
                <div class="sidebar-nav navbar-collapse">
                    <ul class="nav" id="side-menu">

                        <li>
                            <a href="index.aspx"><i class="fa fa-dashboard fa-fw"></i>Principal</a>
                        </li>
                        <li>
                            <a href="#"><i class="fa fa-files-o fa-fw"></i>Relatórios<span class="fa arrow"></span></a>
                            <ul class="nav nav-second-level">
                                <li>
                                    <a href="RelAtividade.aspx">Atividades Em Aberto</a>
                                </li>
                                <li>
                                    <a href="TipoAtividade.aspx">Tipos de Atividades</a>
                                </li>
                                <li>
                                    <a href="TempoGasto.aspx">Tempo Gasto por Atividade</a>
                                </li>
                                <li>
                                    <a href="RelProjeto.aspx">Projetos em Execução</a>
                                </li>

                            </ul>
                        </li>

                    </ul>
                </div>
            </div>
        </nav>

        <div id="page-wrapper">
            <div class="row">
                <form runat="server">
                    <div class="col-lg-12">
                        <h1 class="page-header">Atividades Por Colaborador</h1>
                        <div class="panel panel-default">

                            <div class="panel-body">
                                <div class="row">
                                    <div class="col-lg-4" style="width:100%">
                                        <div class="table-responsive">
                                            <%--<asp:GridView Width="100%" runat="server" ID="gridAtv" AutoGenerateColumns="False" OnSorting="gridAtv_Sorting"
                                                    OnSelectedIndexChanging="gridAtv_SelectedIndexChanging" CssClass="table table-bordered table-hover table-striped">
                                                <Columns>
                                                    <asp:BoundField DataField="NomeUsuario" HeaderText="NomeUsuario" SortExpression="NomeUsuario" />
                                                    <asp:BoundField DataField="NomeAtividade" HeaderText="NomeAtividade" SortExpression="NomeAtividade" />
                                                    <asp:BoundField DataField="TipoAtividade" HeaderText="TipoAtividade" SortExpression="TipoAtividade" />
                                                    <asp:BoundField DataField="DataInicio" HeaderText="DataInicio" SortExpression="DataInicio" />
                                                    <asp:BoundField DataField="DataPrevista" HeaderText="DataPrevista" SortExpression="DataPrevista" />
                                                    <asp:BoundField DataField="SituacaoAtividade" HeaderText="SituacaoAtividade" SortExpression="SituacaoAtividade" />
                                                </Columns>
                                            </asp:GridView>--%>
                                        </div>

                                    </div>
                                </div>

                            </div>

                        </div>

                    </div>
                </form>

            </div>

        </div>

    </div>

    <script src="../bower_components/jquery/dist/jquery.min.js"></script>
    <script src="../bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
    <script src="../bower_components/metisMenu/dist/metisMenu.min.js"></script>
    <script src="../dist/js/sb-admin-2.js"></script>

</body>

</html>
