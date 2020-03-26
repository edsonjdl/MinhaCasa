<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroLivros.aspx.cs" Inherits="BibliotecaMarie.View.CadastroLivros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div style="text-align:center; font-size:larger">
            <div style="margin: 0 auto; text-align:center;">

            <asp:Table ID="Table1" border="1" Width="700px"   runat="server">
                <asp:TableRow>
                    <asp:TableCell>Título do livro:</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="tituloLivro" Font-Size="X-Large" Width="650px" Height ="150px" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Idioma:</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:DropDownList ID="listaIdiomas" style="padding-left: 250px;" Font-Size="XX-Large" Width="650px" Height ="77px" runat="server"></asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Número de páginas:</asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="nPaginas"  Font-Size="XX-Large" Width="650px" Height ="77px" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Button ID="cadastroLiv" OnClick="CadastrarLivro" runat="server" Text="Registrar Livro" />
                    </asp:TableCell>

                </asp:TableRow>
        </asp:Table>

                </div>
        </div>
        
    </form>
</body>
</html>
