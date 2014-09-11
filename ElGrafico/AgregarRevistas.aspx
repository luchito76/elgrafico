<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarRevistas.aspx.cs" Inherits="ElGrafico.AgregarRevistas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="Content/bootstrap-datetimepicker.css" rel="stylesheet" />
    <link href="Content/fileinput.min.css" rel="stylesheet" />

    <div class="panel panel-primary" id="form">
        <div class="panel-heading">
            <h2 class="panel-title">Alta Alumnos</h2>
        </div>

        <div class="form-group">
            <b>
                <asp:Label ID="lblNumeroEdicion" runat="server" Text="N° Edición" for="txtNumeroDeEdicion" class="col-sm-2 control-label">      
                </asp:Label></b>
            <div class="col-sm-3">
                <asp:TextBox runat="server" class="form-control" ID="txtNumeroDeEdicion" onkeypress="return numbersonly(event);" placeholder="N° de Edición"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvNumeropDeEdicion" runat="server" ErrorMessage="Ingrese N° Edición"
                    ControlToValidate="txtNumeroDeEdicion" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>

            <b>
                <asp:Label ID="lblFecha" runat="server" Text="Fecha" for="dtpFecha" class="col-sm-2 control-label">      
                </asp:Label></b>
            <div class="form-group">
                <div class="input-group date form_date col-md-3" data-date="" data-date-format="dd MM yyyy" data-link-field="dtp_input2" data-link-format="dd-mm-yyyy">
                    <asp:TextBox runat="server" ID="dtpFecha" class="form-control" data-date-format="dd/mm/yyyy" placeholder="dd/mm/aaaa">                    
                    </asp:TextBox>
                    <span class="input-group-addon"><span class="glyphicon glyphicon-calendar" /></span>
                </div>
                <input type="hidden" id="dtp_input2" value="" /><br />
            </div>
        </div>

        <div class="form-group">
            <b>
                <asp:Label ID="lblTitulo" runat="server" Text="Título" for="txtTitulo" class="col-sm-2 control-label">      
                </asp:Label></b>
            <div class="col-sm-3">
                <asp:TextBox runat="server" class="form-control" ID="txtTitulo" TextMode="MultiLine" placeholder="Título"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvTitulo" runat="server" ErrorMessage="Ingrese el Título" ControlToValidate="txtTitulo" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>

            <b>
                <asp:Label ID="lblDeporte" runat="server" Text="Deporte" for="txtDeporte" class="col-sm-2 control-label">      
                </asp:Label></b>
            <div class="col-sm-3">
                <asp:DropDownList ID="ddlDeportes" CssClass="form-control" DataTextField="nombre" DataValueField="idDeporte" runat="server"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvDeporte" runat="server" ErrorMessage="Ingrese Deporte" ControlToValidate="ddlDeportes" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="form-group">
            <b>
                <asp:Label ID="lblEstado" runat="server" Text="Estado" for="ddlEstado" class="col-sm-2 control-label">      
                </asp:Label></b>
            <div class="col-sm-3">
                <asp:DropDownList ID="ddlEstado" CssClass="form-control" DataTextField="nombre" DataValueField="idEstado" runat="server"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvEstado" runat="server" ErrorMessage="Ingrese Estado" ControlToValidate="ddlEstado" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>

            <b>
                <asp:Label ID="lblSubirArchivo" runat="server" Text="Subir Tapa" class="col-sm-2 control-label">      
                </asp:Label></b>
            <div class="col-md-3">
                <asp:FileUpload ID="FileUpload1" CssClass="file" runat="server" data-show-upload="false" data-show-remove="false" />
                <br />
                <button id="btnUpload" type="submit" runat="server" onserverclick="btnUpload_Click" class="btn btn-primary kv-fileinput-upload"><i class="glyphicon glyphicon-upload"></i>Upload</button>
                <asp:Label ID="lblMessage" runat="server" Text=""
                    Font-Names="Arial"></asp:Label>
            </div>
        </div>
    </div>

    <%--<asp:Image ID="Image1" runat="server" ImageUrl="AgregarRevistas.aspx?ImageID=1" Width="150px" Height="150px" />--%>

    <script src="Scripts/bootstrap-datetimepicker.js"></script>
    <script src="Scripts/fileinput.min.js"></script>

    <script>
        function numbersonly(e) {
            var unicode = e.charCode ? e.charCode : e.keyCode
            if (unicode != 8 && unicode != 44) {
                if (unicode < 48 || unicode > 57) //if not a number
                { return false } //disable key press    
            }
        }
    </script>

    <script>
        $("#FileUpload1").fileinput();
    </script>

    <script type="text/javascript">
        $(function () {
            $('.form_date').datetimepicker({
                language: 'es',
                weekStart: 1,
                todayBtn: 1,
                autoclose: 1,
                todayHighlight: 1,
                startView: 2,
                minView: 2,
                forceParse: 0
            });
        });


    </script>


</asp:Content>
