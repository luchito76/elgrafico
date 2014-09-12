<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarColeccion.aspx.cs" Inherits="ElGrafico.Coleccion.AgregarColeccion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="panel panel-primary" id="form">
        <div class="panel-heading">
            <h2 class="panel-title">Agregar Colección</h2>
        </div>

        <div class="form-group">
            <b>
                <asp:Label ID="lblColeccionNueva" runat="server" Text="Colección Nueva?" for="option1" class="col-sm-2 control-label">      
                </asp:Label></b>
            <div class="col-sm-3">
                <label for="chkColeccionNueva" class="checkbox inline">
                    <%--<input id="chkColeccionNueva" type="checkbox" value="coleccionNueva" ServerChange="chkColeccionNueva_CheckedChanged"  runat="server" />--%>
                    <asp:CheckBox ID="chkColeccion" OnCheckedChanged="chkColeccionNueva_CheckedChanged" AutoPostBack="true" runat="server" />
                </label>
            </div>

            <div id="capaColeccionVieja" runat="server">
                <b>
                    <asp:Label ID="lblColeccion" runat="server" Text="Colecciones" for="ddlColeccion" class="col-sm-2 control-label">      
                    </asp:Label></b>
                <div class="col-sm-3">
                    <asp:DropDownList ID="ddlColeccion" CssClass="col-md-4 form-control" DataTextField="nombre" DataValueField="idColeccion"
                        OnSelectedIndexChanged="ddlColeccion_SelectedIndexChanged" AutoPostBack="true" runat="server">
                    </asp:DropDownList>
                </div>
            </div>
        </div>

        <div id="capaColeccionNueva" runat="server" class="form-group" visible="false">
            <b>
                <asp:Label ID="lblNombreColeccion" runat="server" Text="Nombre de Colección" for="txtNombreColeccion" class="col-sm-2 control-label">      
                </asp:Label></b>
            <div class="col-sm-3">
                <asp:TextBox runat="server" class="form-control" ID="txtNombreColeccion" placeholder="Nombre de Colección"></asp:TextBox>
            </div>


            <b>
                <asp:Label ID="lblEstado" runat="server" Text="Estado" for="ddlEstado" class="col-sm-2 control-label">      
                </asp:Label></b>
            <div class="col-sm-3">
                <asp:DropDownList ID="ddlEstado" CssClass="col-md-4 form-control" DataTextField="nombre" DataValueField="idEstado" runat="server"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvEstado" runat="server" ErrorMessage="Ingrese Estado" ControlToValidate="ddlEstado" ForeColor="Red"></asp:RequiredFieldValidator>
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
                <asp:Label ID="lblCapitulo" runat="server" Text="Capítulo" for="txtCapitulo" class="col-sm-2 control-label">      
                </asp:Label></b>
            <div class="col-sm-3">
                <asp:TextBox runat="server" class="form-control" ID="txtCapitulo" placeholder="Capítulo"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvCapitulo" runat="server" ErrorMessage="Ingrese Capítulo" ControlToValidate="txtCapitulo" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="form-group">
            <div class="col-sm-offset-2 col-sm-4">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" class="btn btn-primary" OnClick="btnGuardar_Click" />
            </div>
        </div>
    </div>



</asp:Content>
