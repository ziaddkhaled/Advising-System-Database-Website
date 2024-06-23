<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteCourseFromGP.aspx.cs" Inherits="Advisor.DeleteCourseFromGP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            student id:<br />
            <asp:TextBox ID="student_id" runat="server"></asp:TextBox>
            <br />
            semester code:<br />
            <asp:TextBox ID="semester_code" runat="server"></asp:TextBox>
            <br />
            course id:<br />
            <asp:TextBox ID="course_id" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="deleteCourse" runat="server" OnClick="deleteCourse_Click" Text="delete" />
            <br />
            <br />
            <asp:Button ID="back" runat="server" OnClick="back_Click" Text="back" />
            <br />
        </div>
    </form>
</body>
</html>
