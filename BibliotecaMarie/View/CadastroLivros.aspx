<%@ Page Title="Cadastro de Livros" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroLivros.aspx.cs" Inherits="BibliotecaMarie.View.CadastroLivros" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div style="text-align: center; font-size: larger">
            <div style="margin: 0 auto; text-align: center;">

                <asp:Table ID="Table1" border="1" Height="100%" Width="100%" runat="server">
                    <asp:TableRow>
                        <asp:TableCell ColumnSpan="2">
                            <asp:Image ID="nomeLivro" Width="60%" Height="100%" ImageUrl="~/Images/nomeLivro.png" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell ColumnSpan="2">
                            <asp:TextBox ID="tituloLivro" Style="text-align: left;" Font-Size="X-Large" Width="600px" Height="77px"  runat="server"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell ColumnSpan="2">
                            <asp:Image ID="langLivro" Width="90%" Height="100%" ImageUrl="~/Images/langLivro.png" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell ColumnSpan="2">
                            <asp:DropDownList ID="listaIdiomas" Style="padding-left: 40%;" Font-Size="XX-Large" Width="90%" Height="77px" runat="server"></asp:DropDownList>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell ColumnSpan="2">
                            <asp:Image ID="nPageLivro" Width="90%" Height="100%" ImageUrl="~/Images/nPageLivro.png" runat="server" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell ColumnSpan="2">
                            <asp:TextBox ID="nPaginas" Style="text-align: center;" Font-Size="XX-Large" Width="90%" Height="77px" runat="server"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
 

                    <asp:TableRow ID="rowTablet1">
                        <asp:TableCell ColumnSpan="2">
                            Escolher uma foto:
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow ID="rowTablet2">
                        <asp:TableCell HorizontalAlign="Center" ColumnSpan="2">
                        <asp:FileUpload ID="ImageUpload" runat="server" />
                            </asp:TableCell>
                    </asp:TableRow>

                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:ImageButton ID="cadastroLiv2" ImageAlign="Right" Width="150px" ImageUrl="~/Images/btn_Registrar.png" OnClick="CadastrarLivro" runat="server"></asp:ImageButton>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:ImageButton ID="cancelar" ImageAlign="Left" Width="150px" ImageUrl="~/Images/btn_Cancelar.png" PostBackUrl="~/Default.aspx" runat="server"></asp:ImageButton>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>

            </div>
        </div>

</asp:Content>

