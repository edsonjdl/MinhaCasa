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

            <asp:Table ID="Table1" Height="400px" Width="600px"   runat="server">
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="4">
                        <asp:Image ID="nomeLivro" ImageUrl="~/Images/nomeLivro.png" runat="server" /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="4">
                        <asp:TextBox ID="tituloLivro" style="text-align:center;" Font-Size="X-Large" Width="650px" Height ="150px" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="4">
                        <asp:Image ID="langLivro" ImageUrl="~/Images/langLivro.png" runat="server" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="4">
                        <asp:DropDownList ID="listaIdiomas" style="padding-left: 250px;" Font-Size="XX-Large" Width="650px" Height ="77px" runat="server"></asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="4">
                        <asp:Image ID="nPageLivro" ImageUrl="~/Images/nPageLivro.png" runat="server" /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="4">
                        <asp:TextBox ID="nPaginas" style="text-align:center;" Font-Size="XX-Large" Width="650px" Height ="77px" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                           <asp:ImageButton ID="cadastroLiv2" ImageAlign="Right" Width="150px" ImageUrl="~/Images/btn_Registrar.png" OnClick="CadastrarLivro" runat="server">
                           </asp:ImageButton>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:ImageButton ID="cancelar" ImageAlign="Left" Width="150px" ImageUrl="~/Images/btn_Cancelar.png" PostBackUrl="~/Default.aspx" runat="server">
                           </asp:ImageButton>
                    </asp:TableCell> 
                </asp:TableRow>
        </asp:Table>

                </div>
        </div>
        
    </form>
</body>
</html>
