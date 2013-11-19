<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registroinstitucion.aspx.cs" Inherits="Laboratorio.Registroinstitucion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        REGISTRO INSTITUCION</p>
    <p>
        NOMBRE<asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
    </p>
    <p>
        E-MAIL<asp:TextBox ID="txtmail" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Registrar" Height="26px" />
    </p>
    <p>
        TELEFONO<asp:TextBox ID="txttelefono" runat="server"></asp:TextBox>
    </p>
    <p>
        DIRECCION<asp:TextBox ID="txtdireccion" runat="server"></asp:TextBox>
    </p>
    </asp:Content>
