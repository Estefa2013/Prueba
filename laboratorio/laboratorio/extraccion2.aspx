<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="extraccion2.aspx.cs" Inherits="Laboratorio.extraccion2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        Lista de analisis pendientes</p>
    <p>
        CODIGO<asp:DropDownList 
            ID="DropDownList1" runat="server" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:Button ID="btnfiltrar" runat="server" onclick="btnfiltrar_Click" 
            Text="Filtrar" />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Listar" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        RESULTADO AZUCAR<asp:TextBox ID="txtazucar" runat="server"></asp:TextBox>
    </p>
    <p>
        RESULTADO COLESTEROL<asp:TextBox ID="txtcolesterol" runat="server"></asp:TextBox>
        <asp:Button ID="btningresar" runat="server" onclick="btningresar_Click" 
            Text="Ingresar" />
    </p>
    <p>
        RESULTADO TSH<asp:TextBox ID="txttsh" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
