<%@ Page Language="C#" AutoEventWireup="true" 
    MasterPageFile="~/BinaryMaster.Master"
    CodeBehind="frmArtists.aspx.cs" Inherits="Chinook.UI.WebForm.frmArtists" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <div class="navbar-form navbar-left" role="search">
        <div class="form-group">
            <asp:TextBox ID="txtFiltroByName" runat="server" CssClass="form-control" Width="300px"  PlaceHolder="Buscar por Nombre"></asp:TextBox>
        </div>
          <asp:Button ID="btnConsultar" runat="server" Text="Buscar" OnClick="btnConsultar_Click" CssClass="btn btn-danger" />
   
        <br />
        <br />  

        <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" CssClass="btn btn-primary" />
        <asp:GridView ID="grdListado" runat="server"
            CssClass="table table-striped table-bordered table-hover"
            AutoGenerateColumns="false"
            AllowPaging="true" PageSize="5"
            OnPageIndexChanging="grdListado_PageIndexChanging"
            >
            <Columns>
                <asp:BoundField DataField="ArtistId" HeaderText="Código" />
                <asp:BoundField DataField="Name" HeaderText="Nombre" />
                <%--Control que permite implmentar un enlace (link)
                    Cuando son mas de 1 parametro, debe estar separados
                    por comas y en el template del url
                    deben estar definidas las posiciones
            DataNavigateUrlFormatString="frmArtistEdit.aspx?id={0}&nombre={1}"
                    
                    --%>
                <%--<asp:HyperLinkField HeaderText="Editar"
                    Text="Editar"
                    DataNavigateUrlFormatString
                        ="frmArtistEdit.aspx?id={0}"
                    DataNavigateUrlFields="ArtistId"
                    />--%>
                <asp:TemplateField HeaderText="Editar">
                    <ItemTemplate>
                        <a href="frmArtistEdit.aspx?id=<%#Eval("ArtistId") %>"
                            >
                            <img src="~/Content/tema/binary/assets/img/edit-icon.png"
                                class="img-editar"
                                runat="server" />                        
                        </a>
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>        
        </asp:GridView>
        <br />
        <br />
    </div>
</asp:Content>    
