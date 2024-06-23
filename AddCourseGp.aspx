<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCourseGp.aspx.cs" Inherits="Advisor.AddCourseGp" %>

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
            course name:<br />
            <asp:TextBox ID="course_name" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="addCourse_Click" Text="enter" />
            <br />
            <br />
            <asp:Button ID="back" runat="server" OnClick="back_Click" Text="back" />
        </div>
    </form>
</body>
</html>
