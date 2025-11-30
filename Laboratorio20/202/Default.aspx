<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_202._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>

        <div class="row">
            <div class="jumbotron">
                <h1>Matriz N x N con Diagonal Inversa</h1>
                <p class="lead">Ingrese una dimensión N para generar una matriz donde la diagonal inversa (antidiagonal) tiene el valor 1 y el resto 0.</p>
            </div>

            <div class="row">
                <div class="col-md-4">
                    <label for="<%=txtDimension.ClientID %>">Dimensión N:</label>
                    <asp:TextBox ID="txtDimension" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                </div>
                <div class="col-md-8">
                    <br />
                    <asp:Button ID="btnGenerar" runat="server" Text="Generar Matriz" 
                                OnClick="btnGenerar_Click" CssClass="btn btn-primary" />
                </div>
            </div>

            <hr />

            <div class="row">
                <div class="col-md-12">
                    <h3>Resultado:</h3>
                    <asp:Literal ID="litMatriz" runat="server"></asp:Literal>
                </div>
            </div>
            
        </div>
    </main>

</asp:Content>
