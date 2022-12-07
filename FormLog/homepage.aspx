<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="FormLog.homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <p> Buongiorno: <asp:Label ID="ReadCoocki" runat="server" Text="Label"></asp:Label>
               </p>
            <asp:Button ID="Btn_logout" runat="server" Text="LogOut" OnClick="LogOut_click" />
        </div>
    </form>
</body>
</html>
