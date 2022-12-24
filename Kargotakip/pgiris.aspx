<%@ Page Title="" Language="C#" MasterPageFile="~/Personel.Master" AutoEventWireup="true" CodeBehind="pgiris.aspx.cs" Inherits="Kargotakip.deneme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Label ID="Label1" runat="server" Text="Tc"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Text="Adısoyadı"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
    <asp:Label ID="Label3" runat="server" Text="görevi"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    maaş<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ekle" Width="136px" />
    
    <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="363px" Height="182px"></asp:ListBox>
    
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    <asp:Button ID="Button2" runat="server" Height="24px" Text="Sil" OnClick="Button2_Click" />
    
</asp:Content>

