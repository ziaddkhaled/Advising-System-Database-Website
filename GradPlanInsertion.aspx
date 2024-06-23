<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GradPlanInsertion.aspx.cs" Inherits="Advisor.GradPlanInsertion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Semester Code:<br />
            <asp:TextBox ID="semCode" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="back" runat="server" OnClick="back_Click" Text="back" />
            <br />
            expected graduation date:<br />
            <asp:TextBox ID="gradDate" runat="server"></asp:TextBox>
            <br />
            semester credit hours:<br />
            <asp:TextBox ID="semCredHours" runat="server"></asp:TextBox>
            <br />
            student id:<br />
            <asp:TextBox ID="studentID" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="insert_button" runat="server" OnClick="insert_button_Click" Text="Insert" />
            <br />
        </div>
    </form>
</body>
</html>
