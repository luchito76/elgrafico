<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaRevistas.aspx.cs" Inherits="ElGrafico.ListaRevistas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="../Content/bootstrap-table.css" rel="stylesheet" />

    <div class="panel panel-primary" id="form">
        <div class="panel-heading">
            <h2 class="panel-title">Alta Alumnos</h2>
        </div>

        <div class="col-md-12">
            <table id="tbl1" data-toggle="table" class="drag_drop_grid GridSrc" data-pagination="true" data-search="true">
                <thead>
                    <tr>
                        <th data-field="IdRevista" data-align="center" data-sortable="true" data-visible="false">ID</th>
                        <th data-field="operate" data-formatter="operateFormatter1" data-align="center" data-sortable="true">N° Edición</th>
                        <th data-field="Fecha" data-align="center" data-sortable="true">Fecha</th>
                        <th data-field="Titulo" data-sortable="true" data-sorter-nombre="nombre">Título</th>
                        <th data-field="Deporte" data-sortable="true" data-sorter-nombre="nombre">Deporte</th>
                        <th data-field="Cantidad" data-sortable="true" data-sorter-nombre="nombre">Cantidad</th>
                        <th data-field="NombreTapa" data-sortable="true" data-sorter-nombre="nombre" data-visible="false">Tapa</th>
                        <th data-field="operate" data-formatter="operateFormatter" data-events="operateEvents" data-align="center">Tapa</th>
                    </tr>
                </thead>
            </table>
        </div>
    </div>

    <script src="../Scripts/bootstrap-table.js"></script>

    <script>        
        
        
        function operateFormatter(value, row, index) {
                      
            return [
            '<a class="ver ml10" href="javascript:void(0)" title="' + row.Titulo + '">',
                    '<img alt="" src=../imagenes/' + row.NombreTapa + ' width="100px" height="120px;"/>',
                '</a>'
                
            ].join('');
        }

        function operateFormatter1(value, row, index) {
                      
            return [
            '<a class="ver ml10" href="' + row.IdRevista +'">',
                    '<a href="EditarRevista.aspx?idRevista='+ row.IdRevista +'">'+ row.NumeroDeEdicion +'</a>',
                '</a>'
                
            ].join('');
        }

        window.operateEvents = {
            'click .ver': function (e, value, row, index) {                          
                window.location = 'EditarRevista.aspx?idRevista=' + row.IdRevista; 
            }
        };

    </script>

    <script>
        $('#tbl1').bootstrapTable({            
            data: <%= devuelveJson() %>
            });
    </script>

</asp:Content>
