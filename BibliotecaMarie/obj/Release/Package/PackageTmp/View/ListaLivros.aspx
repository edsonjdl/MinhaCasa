<%@ Page Title="Lista de livros" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="ListaLivros.aspx.cs" Inherits="BibliotecaMarie.View.ListaLivros" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Lista de Livros</h1>
    <br />
    <asp:Table ID="listaLivros" runat="server">
    </asp:Table>

</asp:Content>
