<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Extracciones.aspx.cs" Inherits="Laboratorio.Extracciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;</p>
    <p>
        Cliente&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList 
            ID="DropDownList1" runat="server" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        Lugar de atencion 
        <asp:DropDownList ID="ddllugar" runat="server" AutoPostBack="True" 
            onselectedindexchanged="ddllugar_SelectedIndexChanged">
            <asp:ListItem>local</asp:ListItem>
            <asp:ListItem>domicilio</asp:ListItem>
            <asp:ListItem>institucion</asp:ListItem>
        </asp:DropDownList>
    &nbsp;INSTUTUCIONES<asp:DropDownList ID="DropDownList3" runat="server" 
            onselectedindexchanged="DropDownList3_SelectedIndexChanged" Visible="False">
        </asp:DropDownList>
    </p>
    <p>
        Urgencia
        <asp:CheckBox ID="checkUrgencia" runat="server" />
    </p>
    <p>
        Tipo de analisis&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        Azucar<asp:CheckBox ID="checkAzucar" runat="server" />
    </p>
    <p>
        &nbsp;Colesterol<asp:CheckBox ID="CheckColesterol" 
            runat="server" />
    </p>
    <p>
        TSH<asp:CheckBox ID="CheckTsh" runat="server" />
    </p>
    <p>
        Encargado&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>Doctor</asp:ListItem>
            <asp:ListItem>Laboratorista</asp:ListItem>
            <asp:ListItem>Jefe</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        ENTREGA<asp:CheckBox ID="CheckBox1" runat="server" />
    </p>
    <p>
        <asp:Label ID="lblcosto" runat="server" Text="costo"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Cargar lista pendientes" />
    </p>
    <p>
        Costo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="Ingresar nuevo" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
