<%@ Page Title="Lista de livros" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="ListaLivros.aspx.cs" Inherits="BibliotecaMarie.View.ListaLivros" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Lista de Livros</h1>
    <br />
    <!--
    <asp:Table ID="listaLivros" runat="server">
    </asp:Table>
    -->

        <!--
    Código pronto alterado.
    -->

    <asp:GridView ID="GrdDisplayImage" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="itemname" HeaderText="Image Name" />
            <asp:TemplateField HeaderText="Image">
                <ItemTemplate>
                    <asp:Image ID="imgdisplay" runat="server" ImageUrl='<%# "ImageHandler.ashx?ImID="+ Eval("IdImagem") %>' Height="150px" Width="150px" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>
