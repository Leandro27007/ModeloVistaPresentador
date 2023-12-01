<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ModelVistaPresentadorWebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Ejemplo ASP.Net con patron arquitectonico M.V.P</h1>
            <p class="lead">Demostracion MVP.</p>
        </section>

        <div class="row">
          
            <asp:Label  runat="server">Nombre</asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
             
            <br />
            <asp:Label runat="server">Puesto</asp:Label>
            <asp:TextBox ID="txtPuesto" runat="server"></asp:TextBox>

            <hr />
            <hr />
            <asp:Button ID="BotonAgregar" Text="Agregar" OnClick="btnAgregarEmpleado" style="background-color: seagreen" runat="server"/>

            <hr />
            <hr />

            <ul>
                <li>
                    <asp:Label AssociatedControlID="empleadosDropDownList" runat="server" >Empleados</asp:Label>

                    <asp:DropDownList ID="empleadosDropDownList" runat="server"
                        DataTextField="Nombre" DataValueField="Id">
                    </asp:DropDownList>
                </li>
            </ul>
        </div>
    </main>

</asp:Content>
