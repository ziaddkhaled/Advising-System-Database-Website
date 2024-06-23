<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdvisorRegisteration.aspx.cs" Inherits="Advisor.AdvisorRegisteration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Sign in<br />
            Name:<br />
            <asp:TextBox ID="AdvisorName" runat="server"></asp:TextBox>
            <br />
            Password:<br />
            <asp:TextBox ID="SetPassword" runat="server"></asp:TextBox>
            <br />
            Email:<br />
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
            <br />
            Office:<br />
            <asp:TextBox ID="office" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Advisor_Register" Text="Sign In" />
        </div>
    </form>
</body>
</html>
