<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LectureMain.aspx.cs" Inherits="POE_TASK_3.LectureMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Lecture"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Image ID="Image1" runat="server" Height="259px" Width="409px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <div>
            <asp:Button ID="btSetTest" runat="server" Text="Set Test" Width="88px" OnClick="btSetTest_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btViewClassList" runat="server" Text="View Class Marks" Width="121px" OnClick="btViewClassList_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Back" />
        </div>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
