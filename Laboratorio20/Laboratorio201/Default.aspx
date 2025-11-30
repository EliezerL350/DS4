<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio201._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">ASP.NET</h1>
            <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
            <p><a href="http://www.asp.net" class="btn btn-primary btn-md">Learn more &raquo;</a></p>
        </section>

        <div class="row">
            <div class="container" style="padding: 20px;">
                <h2>Tabla de Multiplicar hasta el 25</h2>
    
                <div class="form-group">
                    <label>Ingrese un número:</label>
                    <asp:TextBox ID="txtNumero" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                </div>
                <br/>
    
                <asp:Button ID="btnCalcular" runat="server" Text="Generar Tabla" 
                            OnClick="btnCalcular_Click" CssClass="btn btn-primary" />
                <hr />


                <h3>Resultados:</h3>
                <asp:Literal ID="litResultado" runat="server"></asp:Literal>
            </div>
            
        </div>
    </main>

</asp:Content>
