<%@ Page Title="Mandar respostas dos reveres" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="RespostaDever.aspx.cs" Inherits="BibliotecaMarie.View.RespostaDever" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Envio de respostas</h1>
    <br />
    <asp:Table ID="Table1" runat="server">
        <asp:TableRow>
            <asp:TableCell>
                Nome do dever:
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="nomeDever" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
            Exercício:
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="exercicio" runat="server"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                Desenho:
            </asp:TableCell>
            <asp:TableCell>

            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>

</asp:Content>
