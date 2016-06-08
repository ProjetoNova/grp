<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RelAtividade.aspx.cs" Inherits="NovaProjectWeb.View.pages.RelAtividade" %>

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

    <script type = "text/javascript">
        function PrintPanel() {
            var panel = document.getElementById("<%=pnlContents.ClientID %>");
            var printWindow = window.open('', '', 'height=400,width=800');
            printWindow.document.write('<html><head>');
            printWindow.document.write('</head><body >');
            printWindow.document.write(panel.innerHTML);
            printWindow.document.write('</body></html>');
            printWindow.document.close();
            setTimeout(function () {
                printWindow.print();
            }, 500);
            return false;
        }
    </script>
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
                        <i class="fa fa-user fa-fw"></i>
                        <asp:Label runat="server" ID="labelNome"></asp:Label>  <i class="fa fa-caret-down"></i>
                    </a>
                    <ul class="dropdown-menu dropdown-user">
                     
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
                                    <a href="RelAtividade.aspx">Atividades em aberto</a>
                                </li>
                                <li>
                                    <a href="TipoAtividade.aspx">Tipos de atividades</a>
                                </li>
                                <%--<li>
                                    <a href="TempoGasto.aspx">Tempo Gasto por Atividade</a>
                                </li>--%>
                                <li>
                                    <a href="RelProjeto.aspx">Projetos em execução</a>
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
                     <asp:Button ID="btnPrint" runat="server" class="btn" Text="Imprimir" OnClientClick = "return PrintPanel();" />
                    <asp:Panel id="pnlContents" runat = "server">
                        <div class="col-lg-12">
                            
                            <h1 class="page-header">Atividades em aberto</h1>
                            <div class="panel panel-default">

                                <div class="panel-body">
                                    <div class="row">
                                        <div class="col-lg-4" style="width:100%">
                                            <div class="table-responsive">
                                            
                                                <asp:RadioButtonList ID="rdBtnList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="agrupar" >
                                                    <asp:ListItem Value="0" Selected="True">Por colaborador</asp:ListItem>
                                                    <asp:ListItem Value="1">Por projeto</asp:ListItem>
                                                </asp:RadioButtonList>
                                            
                                                <asp:GridView Width="100%" runat="server" ID="gridAtv" AutoGenerateColumns="False" OnSorting="gridAtv_Sorting"
                                                        OnSelectedIndexChanging="gridAtv_SelectedIndexChanging" CssClass="table table-bordered table-hover table-striped">
                                                    <Columns>
                                                        <asp:BoundField DataField="NomeUsuario" HeaderText="Nome do colaborador" SortExpression="NomeUsuario" />
                                                        <asp:BoundField DataField="NomeProjeto" HeaderText="Nome do projeto" SortExpression="NomeProjeto" />
                                                        <asp:BoundField DataField="NomeAtividade" HeaderText="Nome da atividade" SortExpression="NomeAtividade" />
                                                        <asp:BoundField DataField="TipoAtividade" HeaderText="Tipo da atividade" SortExpression="TipoAtividade" />
                                                        <asp:BoundField DataField="DataInicio" HeaderText="Data de inicio" SortExpression="DataInicio" />
                                                        <asp:BoundField DataField="DataPrevista" HeaderText="Data prevista" SortExpression="DataPrevista" />
                                                        <asp:BoundField DataField="SituacaoAtividade" HeaderText="Situacao da atividade" SortExpression="SituacaoAtividade" />
                                                     </Columns>
                                                </asp:GridView>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </asp:Panel>
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