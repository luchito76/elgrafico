<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaRevistas.aspx.cs" Inherits="ElGrafico.ListaRevistas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="Content/bootstrap-table.css" rel="stylesheet" />

    <div class="panel panel-primary" id="form">
        <div class="panel-heading">
            <h2 class="panel-title">Alta Alumnos</h2>
        </div>

        <div class="col-md-12">
            <table id="tbl1" data-toggle="table" class="drag_drop_grid GridSrc" data-pagination="true" data-search="true">
                <thead>
                    <tr>
                        <th data-field="NumeroDeEdicion" data-align="center" data-sortable="true">N° Edición</th>
                        <th data-field="Fecha" data-align="center" data-sortable="true">Fecha</th>
                        <th data-field="Titulo" data-sortable="true" data-sorter-nombre="nombre">Título</th>
                    </tr>
                </thead>
            </table>
        </div>
    </div>

    <script src="Scripts/bootstrap-table.js"></script>

    <script>
         $('#tbl1').bootstrapTable({            
            data: <%= devuelveJson() %>
            });
    </script>
</asp:Content>
