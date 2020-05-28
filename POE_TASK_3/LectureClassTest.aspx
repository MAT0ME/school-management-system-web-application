<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LectureClassTest.aspx.cs" Inherits="POE_TASK_3.LectureClassTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 163px;
        }
        .auto-style2 {
            margin-left: 346px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            Question 1<br />
            <asp:TextBox ID="tbQuestion1" runat="server" Width="855px"></asp:TextBox>
            <br />
            <br />
            Option 1&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbQ1o1" runat="server" Width="132px"></asp:TextBox>
            <br />
            Option 2&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbQ1o2" runat="server" Width="133px"></asp:TextBox>
            <br />
            Correct Answer&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbQ1o3" runat="server" Width="130px"></asp:TextBox>
            <br />
        </div>
        <p>
            &nbsp;</p>
        <div>
            Question 2<br />
            <asp:TextBox ID="tbQuestion2" runat="server" Width="855px" OnTextChanged="tbQuestion2_TextChanged"></asp:TextBox>
            <br />
            <br />
            Option 1&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbQ2o1" runat="server" Width="132px"></asp:TextBox>
            <br />
            Option 2&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbQ2o2" runat="server" Width="133px"></asp:TextBox>
            <br />
            Correct Answer&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbQ2o3" runat="server" Width="130px"></asp:TextBox>
            <br />
        </div>
        <p>
            &nbsp;</p>
        <div>
            Question 3<br />
            <asp:TextBox ID="tbQuestion3" runat="server" Width="855px"></asp:TextBox>
            <br />
            <br />
            Option 1&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbQ3o1" runat="server" Width="132px"></asp:TextBox>
            <br />
            Option 2&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbQ3o2" runat="server" Width="133px"></asp:TextBox>
            <br />
            Correct Answer&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbQ3o3" runat="server" Width="130px"></asp:TextBox>
            <br />
        </div>
        <p>
            &nbsp;</p>
        <div>
            <br />
            <br />
            <br />
            <asp:Button ID="btSave" runat="server" CssClass="auto-style2" Text="Save" Width="156px" OnClick="btSave_Click" />
            <asp:Button ID="btBack" runat="server" CssClass="auto-style1" Text="Back" Width="156px" OnClick="btBack_Click" />
            <br />
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
