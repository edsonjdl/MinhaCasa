﻿<%@ Page Title="Envio de fotos" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="InsercaoImagens.aspx.cs" Inherits="BibliotecaMarie.View.InsercaoImagens" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

        <div>
            <table>
                 
                <tr>
                    <td>Nome da imagem:
                    </td>
                    <td>
                        <asp:TextBox ID="txtImageName" runat="server"></asp:TextBox></td>
                </tr>
                    
                <tr>
                    <td>Registrar imagem:</td>
                    <td>
                        <asp:FileUpload ID="ImageUpload" runat="server" /></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSave" Text="Salvar" runat="server" OnClick="btnSave_Click" /></td>
                </tr>
            </table>
            
            <table>
                <tr>
                    <td>
                        <asp:GridView ID="GrdDispalyImage" runat="server" AutoGenerateColumns="false">
                            <Columns>
                                <asp:BoundField DataField="filename" HeaderText="Image Name" />
                                <asp:TemplateField HeaderText="Image">
                                    <ItemTemplate>
                                        <asp:Image ID="imgdisplay" runat="server" ImageUrl='<%# "ImageHandler.ashx?ImID="+ Eval("IdImagem") %>' Height="150px" Width="150px" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>
                
        </div>

</asp:Content>
