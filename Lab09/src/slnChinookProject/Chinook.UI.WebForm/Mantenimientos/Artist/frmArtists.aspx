<%@ Page Language="C#" AutoEventWireup="true" 
    MasterPageFile="~/Site.Master"
    CodeBehind="frmArtists.aspx.cs" Inherits="Chinook.UI.WebForm.frmArtists" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Artista:"></asp:Label>
        <asp:TextBox ID="txtFiltroByName" runat="server"></asp:TextBox>
        <asp:Button ID="btnConsultar" runat="server" Text="Buscar" OnClick="btnConsultar_Click" />
        <br />
        <hr />
            
        <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" />
        <asp:GridView ID="grdListado" runat="server">
        </asp:GridView>
        <br />
        <br />
    </div>
</asp:Content>    
