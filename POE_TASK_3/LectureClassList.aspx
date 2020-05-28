<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LectureClassList.aspx.cs" Inherits="POE_TASK_3.LectureClassList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 280px;
            margin-top: 57px;
            width: 427px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        &nbsp;The class list<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="299px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="414px" DataSourceID="SqlDataSource1">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField HeaderText="Name" DataField="Name" SortExpression="Name" />
                    <asp:BoundField HeaderText="Surname" DataField="Surname" SortExpression="Surname" />
                    <asp:BoundField HeaderText="Mark" DataField="Mark" SortExpression="Mark" />
                    <asp:BoundField DataField="Percentage" HeaderText="Percentage" SortExpression="Percentage" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TasK3_School_dbConnectionString %>" SelectCommand="SELECT * FROM [Marks]"></asp:SqlDataSource>
        </div>
        <div>
        </div>
        <div>
        </div>
        <div>
            <asp:Button ID="btBack" runat="server" Text="Back" Width="127px" OnClick="btBack_Click" />
        </div>
    </form>
        </body>
</html>
