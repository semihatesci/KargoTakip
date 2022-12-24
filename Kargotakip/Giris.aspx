<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="Kargotakip.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Button ID="btn_personel" runat="server" Height="184px" OnClick="Button2_Click" Text="Personel Girişi" Width="1020px" />
        </p>
        <p style="width: 953px">
            &nbsp;</p>
        <p>
            <asp:Button ID="btn_kullanıcı" runat="server" Height="175px" OnClick="btn_kullanıcı_Click" style="margin-bottom: 0px" Text="Kulanıcı Girişi" Width="1002px" />
        </p>
       
    </form>
</body>
</html>
