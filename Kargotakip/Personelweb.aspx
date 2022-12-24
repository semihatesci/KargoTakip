<%@ Page Title="" Language="C#" MasterPageFile="~/Personel.Master" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="Kargotakip.WebForm5" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <asp:Label ID="Label1" runat="server" Text="Adı Soyadı" Width="100px"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
       
        
 
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>Kurye</asp:ListItem>
    </asp:DropDownList>
       
        
 
    <asp:Label ID="Label2" runat="server" Text="Tc"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <asp:Label ID="Label3" runat="server" Text="Maaş"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    <asp:Button ID="Button1" runat="server" Height="72px" Text="Personel ekle" Width="127px" OnClick="Button1_Click" />
       
        
 
    <asp:Table ID="Table1" runat="server" Width="47px" Height="16px"></asp:Table>
       
        
 
    <asp:Label ID="Label4" runat="server" Text="Tc"></asp:Label>
    <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
    <asp:Button ID="Button2" runat="server" Text="Personel Sil" />
       
        
 
    </asp:Content>



