<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExamenParcial._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Ingreso de Animal:</h1>
            <p class="lead">
                <asp:DropDownList ID="cmbAnimal" runat="server" OnSelectedIndexChanged="cmbAnimal_SelectedIndexChanged">
                </asp:DropDownList>
            </p>
            <p class="lead">Nombre Propio: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </p>
            <p class="lead">Especie:
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>
            <p class="lead">Tipo de Alimentación:
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </p>
            <p class="lead">Tiempo máximo de vida:
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </p>
            <p class="lead">
                <asp:Button ID="btnIngresoAnimal" runat="server" OnClick="btnIngresoAnimal_Click" Text="Ingresar Animal" />
            </p>
        </section>
    <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">&nbsp;</h2>
            <h1 id="aspnetTitle0">Ingreso de Reptiles: </h1>
                <p>Si vuela o no vuela:
                    <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList>
                </p>
                <p>Período de incubación:
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </p>
            <h1 id="aspnetTitle1">Ingreso de Aves:</h1>
                <p>
                    <asp:Label ID="Label1" runat="server" Text="Si es venenosa o no: "></asp:Label>
                    <asp:DropDownList ID="DropDownList2" runat="server">
                    </asp:DropDownList>
                </p>
                <p>Longitud máxima: <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </p>
            </section>
        </div>
    </main>

</asp:Content>
