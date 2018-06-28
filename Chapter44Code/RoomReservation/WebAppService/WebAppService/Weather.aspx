<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Weather.aspx.cs" Inherits="WebAppService.Weather" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label Text="输入查询城市:" runat="server"></asp:Label>
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" />
        </div>
        <div>
            <asp:Label ID="weatherMsg1" runat="server"></asp:Label>
            </br>
            <asp:Label ID="weatherMsg2" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
