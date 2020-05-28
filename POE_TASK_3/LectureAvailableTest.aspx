<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LectureAvailableTest.aspx.cs" Inherits="POE_TASK_3.LectureAvailableTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Memorandum"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <div>
            <asp:Label ID="Label2" runat="server" Font-Size="X-Large" Text="Question 1"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Question1" runat="server" Font-Size="Medium" Text="Question 1"></asp:Label>
            <br />
            <br />
&nbsp;Answer&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="QuestionAnswer1" runat="server" Font-Size="Medium" Text="Question 1"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <div>
            <asp:Label ID="Label3" runat="server" Font-Size="X-Large" Text="Question 2"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Question2" runat="server" Font-Size="Medium" Text="Question 1"></asp:Label>
            <br />
            <br />
&nbsp;Answer&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="QuestionAnswer2" runat="server" Font-Size="Medium" Text="Question 1"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <div>
            <asp:Label ID="Label4" runat="server" Font-Size="X-Large" Text="Question 3"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Question3" runat="server" Font-Size="Medium" Text="Question 3"></asp:Label>
            <br />
            <br />
&nbsp;Answer&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="QuestionAnswer3" runat="server" Font-Size="Medium" Text="Question 1"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <asp:Button ID="BtBack" runat="server" Text="Back" OnClick="BtBack_Click" />
    </form>
</body>
</html>
