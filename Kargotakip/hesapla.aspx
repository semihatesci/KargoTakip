<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hesapla.aspx.cs" Inherits="Kargotakip.hesapla" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Mesafe"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" Height="45px" Width="186px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>300km</asp:ListItem>
            <asp:ListItem>450km</asp:ListItem>
            <asp:ListItem>600km</asp:ListItem>
            <asp:ListItem>900km</asp:ListItem>
        </asp:DropDownList>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Ağırlık"></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server" Height="30px" Width="70px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                <asp:ListItem>0-1</asp:ListItem>
                <asp:ListItem>1-3</asp:ListItem>
                <asp:ListItem>3-7</asp:ListItem>
                <asp:ListItem>7-15</asp:ListItem>
                <asp:ListItem>15-50</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:CheckBox ID="Alıcı" runat="server" Text="Şubeden alacak" OnCheckedChanged="Alıcı_CheckedChanged" />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Eve Teslim" OnCheckedChanged="CheckBox2_CheckedChanged" />
        </p>
        <p>
            <asp:CheckBox ID="CheckBox3" runat="server" Text="Sms irtibatlı" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Height="32px" OnClick="Button1_Click" Text="Hesapla" Width="183px" />
        </p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Height="21px" Width="162px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
