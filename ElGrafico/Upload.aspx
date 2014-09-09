<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="ElGrafico.Upload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
    <link href="Content/fileinput.min.css" rel="stylesheet" />

    
    <script src="Scripts/fileinput.min.js"></script>

    <input id="input-1" type="file" class="file">

    <script>
        $("#input-id").fileinput();
    </script>
</asp:Content>
