<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApproveRejectCReq.aspx.cs" Inherits="Advisor.ApproveRejectCReq" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            request id:<br />
            <asp:TextBox ID="rId" runat="server"></asp:TextBox>
            <br />
            current semester code:<br />
            <asp:TextBox ID="semester_code" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="execute" runat="server" OnClick="execute_Click" Text="enter" />
            <br />
            <br />
            <asp:Button ID="back" runat="server" OnClick="back_Click" Text="back" />
        </div>
    </form>
</body>
</html>
