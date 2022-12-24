<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="kullanıcı.aspx.cs" Inherits="Kargotakip.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btn_takip" runat="server" Height="83px" OnClick="btn_takip_Click" Text="Kargo Takip " Width="668px" />
        <p>
            <asp:Button ID="btn_kargo" runat="server" Height="85px" OnClick="btn_kargo_Click" Text="Kargo Hesapla" Width="671px" />
        </p>
        <p>
            <asp:Button ID="btn_iletisim" runat="server" Height="84px" Text="Kargo İletişim" Width="675px" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
