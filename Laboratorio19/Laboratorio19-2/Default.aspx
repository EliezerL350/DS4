<%@ Page Title="Home Page" Async="true" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio19_2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div class="row">
            
            <asp:Button ID="btnObtener" runat="server" Text="Obtener todos los datos" OnClick="btnObtener_Click" />

            <br /><br />

            <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
            
        </div>
    </main>

</asp:Content>
