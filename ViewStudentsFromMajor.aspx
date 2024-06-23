<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStudentsFromMajor.aspx.cs" Inherits="Advisor.ViewStudentsFromMajor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <br />
            major:<br />
            <asp:TextBox ID="major" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="view" runat="server" OnClick="viewClick" Text="View" />
            <br />
            <br />
            <asp:Button ID="back" runat="server" OnClick="back_Click" Text="back" />
            <br />
        </div>
    </form>
</body>
</html>
