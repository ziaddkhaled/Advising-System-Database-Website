<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateGradDate.aspx.cs" Inherits="Advisor.UpdateGradDate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            expected graduation date:<br />
            <asp:TextBox ID="expGradDate" runat="server"></asp:TextBox>
            <br />
            student id:<br />
            <asp:TextBox ID="sID" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="UpdateDate" runat="server" OnClick="UpdateDate_Click" Text="update" />
            <br />
            <br />
            <asp:Button ID="back" runat="server" OnClick="back_Click" Text="back" />
        </div>
    </form>
</body>
</html>
