<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CallWebService.aspx.cs" Inherits="WebForm1.CallWebService" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="输入字符串"></asp:Label>
        <asp:textbox id="tbInput" runat="server"></asp:textbox>
        <asp:Button ID="Button1" runat="server" Text="确定" OnClick="Button1_Click" />
        <asp:Label ID="Label2" runat="server" Text="结果是"></asp:Label>
        <asp:textbox ID="tbResult" runat="server"></asp:textbox>
    </div>
    </form>
</body>
</html>

