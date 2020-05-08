<%@ Page Title="Lista de livros" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="ListaLivros.aspx.cs" Inherits="BibliotecaMarie.View.ListaLivros" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Lista de Livros</h1>
    <br />
    <!--
    <asp:Table ID="listaLivros" runat="server">
    </asp:Table>
    -->

        
    <!--Código pronto alterado.-->
    
     <!-- Esse trecho de código pode ser reutilizado para outros itens. Pode-se colocar placeholder para as informações das colunas. -->
    <asp:GridView ID="GrdDisplayImage" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Title" HeaderText="Livro" />
            <asp:TemplateField HeaderText="Capa do Livro">
                <ItemTemplate>
                    <asp:Image ID="imgdisplay" runat="server" ImageUrl='<%# "ImageHandler.ashx?ImID="+ Eval("IdImagem") %>' Height="5%"  />
                </ItemTemplate>
            </asp:TemplateField>
            <%--
            Adaptação para inserir nova coluna. No campo DataField, coloquei a referência do objeto Language tal como é possível
                obter através do código. O objeto Language se refere à propriedade Language1 tal como foi criada no Database Model.
                --%>
            <asp:BoundField DataField="Language.Language1" HeaderText="Idioma" />
        </Columns>
    </asp:GridView>

</asp:Content>
