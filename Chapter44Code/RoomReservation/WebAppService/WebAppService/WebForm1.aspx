<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppService.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtA" runat="server"></asp:TextBox>*<asp:TextBox ID="txtB" runat="server"></asp:TextBox>
            <asp:Button ID="btnGetResult" runat="server" Text="=" OnClick="btnGetResult_Click" />
            <asp:TextBox ID="txtResult" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
