<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FormLog.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           
            Username:<asp:TextBox ID="username" runat="server"></asp:TextBox><br />
            Password:<asp:TextBox ID="password" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="LogIn" OnClick="Login_click" />
        </div>
    </form>
</body>
</html>
