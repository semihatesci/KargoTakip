<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="personel.aspx.cs" Inherits="Kargotakip.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Password1 {
            width: 123px;
            height: 16px;
            margin-left: 32px;
        }
        #Text1 {
            height: 16px;
            margin-left: 12px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Kulanıcıadı"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 7px"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Height="36px" Text="Şifre" Width="71px"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="117px"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" Height="68px" OnClick="Button1_Click" Text="Giriş" Width="270px" />
    </form>
</body>
</html>
