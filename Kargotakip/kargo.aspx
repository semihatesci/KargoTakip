<%@ Page Title="" Language="C#" MasterPageFile="~/Personel.Master" AutoEventWireup="true" CodeBehind="kargo.aspx.cs" Inherits="Kargotakip.kargo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="İsim"></asp:Label>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:Label ID="Label2" runat="server" Text="Kısa adres"></asp:Label>
<asp:TextBox ID="TextBox2" runat="server" Height="23px" style="margin-left: 0px" Width="154px"></asp:TextBox>
<asp:Label ID="Label3" runat="server" Text="il  "></asp:Label>
<asp:DropDownList ID="DropDownList2" runat="server" Height="20px" Width="91px">
    <asp:ListItem>Muğla</asp:ListItem>
    <asp:ListItem>İzmir</asp:ListItem>
    <asp:ListItem>Antalya</asp:ListItem>
    <asp:ListItem>İstanbul</asp:ListItem>
    <asp:ListItem>Ankara</asp:ListItem>
</asp:DropDownList>
<asp:Label ID="Label4" runat="server" Text="Tel"></asp:Label>
<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
<asp:CheckBox ID="CheckBox1" runat="server" Text="Eve teslim" />
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ekle" />
<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Sil" Width="156px" />
<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
<asp:Label ID="Label5" runat="server" Text="&lt;-Kargo no      "></asp:Label>
    <asp:Label ID="Label6" runat="server" Text="KARGO ARAMA SONUÇ EKRANI"></asp:Label>
<asp:ListBox ID="ListBox1" runat="server" Height="71px" Width="624px"></asp:ListBox>
<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="ara" />
<asp:TextBox ID="TextBox5" runat="server" Height="16px" OnTextChanged="TextBox5_TextChanged" style="margin-top: 0px" Width="206px"></asp:TextBox>

</asp:Content>
