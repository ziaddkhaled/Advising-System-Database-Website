<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdvisorLogin.aspx.cs" Inherits="Advisor.AdvisorLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Log In&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="signIn" Text="SignIn" />
&nbsp;&nbsp;&nbsp; <br />
            Advisor ID:<br />
            <asp:TextBox ID="advisorID" runat="server"></asp:TextBox>
            <br />
            Password:<br />
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br  />
            <asp:Button ID="logIn" runat="server" OnClick="logIn_Click" Text="Log In" />
        </div>
    </form>
</body>
</html>
