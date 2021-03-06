﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ElGrafico._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <link href="Content/bootstrap-table.css" rel="stylesheet" />

    <div class="row clearfix">
        <div class="col-md-12 column">
            <%--<div class="css-shapes-preview"></div>--%>
            <h1 class="text-center text-info">Colección de Revistas El Gráfico
            </h1>
            <h3 class="text-center text-warning">Total de Revistas Cargadas: <%= total %> Revistas
            </h3>
        </div>
        <div class="jumbotron">
            <div class="col-md-12">
                <div id="container" style="min-width: 310px; height: 400px; margin: 0 auto">
                    <table id="tbl1" data-toggle="table" class="drag_drop_grid GridSrc" data-pagination="false" data-search="false" data-show-header="false" data-show-columns="false">
                        <thead>
                            <tr>
                                <th data-field="Deporte" data-align="center" data-sortable="true" data-visible="true">Deporte</th>
                                <th data-field="Total" data-align="center" data-sortable="true" data-visible="true">Total</th>
                            </tr>
                        </thead>
                    </table>
                </div>
            </div>
        </div>
    </div>


    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.2/jquery.min.js"></script>
    <script src="Scripts/bootstrap-table.js"></script>
    <script src="Scripts/highcharts.js"></script>
    <script src="Scripts/data.js"></script>
    <script src="Scripts/drilldown.js"></script>

    <script>
        $('#tbl1').bootstrapTable({            
            data: <%= devuelveJson() %>
            });
    </script>

    <script type="text/javascript">
        $(function () {
            $('#container').highcharts({
                data: {
                    table: document.getElementById('tbl1')
                },
                chart: {
                    type: 'column',
                    backgroundColor: {
                        linearGradient: [0, 0, 500, 500],
                        stops: [
                            [0, '#feffe8'],
                            [1, '#d6dbbf']
                        ]
                    },
                    borderWidth: 2,
                    plotBackgroundColor: 'rgba(255, 255, 255, .9)',
                    plotShadow: true,
                    plotBorderWidth: 1
                },
                title: {
                    text: 'Total de revistas por cada deporte'
                },
                yAxis: {
                    allowDecimals: false,
                    title: {
                        text: 'Cantidad de Revistas'
                    }
                },
                colors: ['#b0d4e3', '#0d233a', '#8bbc21', '#910000', '#1aadce', 
   '#492970', '#f28f43', '#77a1e5', '#c42525', '#a6c96a'],
                tooltip: {
                    formatter: function () {
                        return '<b>' + this.series.name + '</b><br/>' +
                            this.point.y + ' ' + this.point.name.toUpperCase();
                    }
                }
            });
        });
    </script>
</asp:Content>
