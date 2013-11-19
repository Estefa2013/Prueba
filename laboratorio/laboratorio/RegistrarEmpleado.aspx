<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarEmpleado.aspx.cs" Inherits="Laboratorio.RegistrarEmpleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <p>
        CEDULA<asp:TextBox ID="txtcedula" runat="server"></asp:TextBox>
    </p>
    <p>
        NOMBRE<asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
    </p>
    <p>
        DIRECCION<asp:TextBox ID="txtdir" runat="server"></asp:TextBox>
    </p>
    <p>
        TELEFONO<asp:TextBox ID="txttel" runat="server"></asp:TextBox>
    </p>
    <p>
        CARGO<asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Doctor</asp:ListItem>
            <asp:ListItem>Laboratorista</asp:ListItem>
            <asp:ListItem>Jefe</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="btnguardar" runat="server" onclick="btnguardar_Click" 
            Text="Guardar" />
    </p>
</asp:Content>
