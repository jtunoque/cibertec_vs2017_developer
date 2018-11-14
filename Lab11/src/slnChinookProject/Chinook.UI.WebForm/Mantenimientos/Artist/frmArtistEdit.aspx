<%@ Page Title="" Language="C#" MasterPageFile="~/BinaryMaster.Master" 
    AutoEventWireup="true" CodeBehind="frmArtistEdit.aspx.cs" 
    Inherits="Chinook.UI.WebForm.Mantenimientos.Artist.frmArtistEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">

    <asp:HiddenField ID="hfID" runat="server" />

    <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" 
        OnClick="btnGuardar_Click" CssClass="btn btn-success" />

</asp:Content>
