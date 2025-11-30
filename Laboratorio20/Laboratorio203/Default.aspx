<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="Default.aspx.cs"
    Inherits="Laboratorio203._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div class="row">

            <h2>Mantenimiento de Productos (CRUD)</h2>
            <p>Funcionalidad similar al Laboratorio 14, Parte II.</p>
    
            <div style="margin-bottom: 20px;">
                <asp:Label runat="server" Text="Buscar por ID:"></asp:Label>
                <asp:TextBox ID="tstId" runat="server" CssClass="form-control"
                             Width="100px" TextMode="Number"></asp:TextBox>
                <asp:Button ID="tsbBuscar" runat="server" Text="🔍 Buscar"
                            OnClick="tsbBuscar_Click" CssClass="btn btn-info" />
            </div>

            <hr />

            <div style="width: 300px;">
                <div class="form-group">
                    <asp:Label runat="server" Text="Id:"></asp:Label>
                    <asp:TextBox ID="txtId" runat="server" ReadOnly="true"
                                 CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" Text="Nombre:"></asp:Label>
                    <asp:TextBox ID="txtNombre" runat="server" ReadOnly="true"
                                 CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" Text="Precio:"></asp:Label>
                    <asp:TextBox ID="txtPrecio" runat="server" ReadOnly="true"
                                 CssClass="form-control" TextMode="Number"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" Text="Stock:"></asp:Label>
                    <asp:TextBox ID="txtStock" runat="server" ReadOnly="true"
                                 CssClass="form-control" TextMode="Number"></asp:TextBox>
                </div>
            </div>

            <hr />

            <div style="margin-top: 15px;">
                <asp:Button ID="tsbNuevo" runat="server" Text="➕ Nuevo"
                            OnClick="tsbNuevo_Click" CssClass="btn btn-success" />
                <asp:Button ID="tsbGuardar" runat="server" Text="💾 Guardar"
                            OnClick="tsbGuardar_Click" Enabled="False"
                            CssClass="btn btn-primary" />
                <asp:Button ID="tsbCancelar" runat="server" Text="❌ Cancelar"
                            OnClick="tsbCancelar_Click" Enabled="False"
                            CssClass="btn btn-warning" />
                <asp:Button ID="tsbEliminar" runat="server" Text="🗑️ Eliminar"
                            OnClick="tsbEliminar_Click" Enabled="False"
                            CssClass="btn btn-danger" />
            </div>
    
            <div style="margin-top: 20px; display: block;">
                <asp:Literal ID="litMensaje" runat="server" EnableViewState="False"></asp:Literal>
            </div>


            <asp:HiddenField ID="hdnEstadoNuevo" runat="server" Value="false" />

        </div>
    </main>

</asp:Content>
