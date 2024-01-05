<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin.aspx.cs" Inherits="admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            border: 1px solid #D2B48C;
            background-color: #EEE8AA;
            height: 99px;
        }
        .auto-style2 {
            width: 266px;
            text-align: right;
        }
        .auto-style3 {
            width: 266px;
            text-align: right;
            height: 48px;
        }
        .auto-style4 {
            height: 48px;
        }
    </style>
         <link href="extions/StyleSheet.css" rel="stylesheet" />

</head>


<body>
    <ul class="nav">
  <li><a href="admin.aspx">Home</a></li>
  <li><a href="#">About Us</a></li>
  <li><a href="#">Services</a></li>
  <li><a href="#">Products</a></li>
  <li><a href="#">Contact</a></li>
</ul>
    <form id="form1" runat="server">
    <div>
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">اضافة ادمن</td>
                <td>
                    <a href="addA.aspx">اضغط هنا</a>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">اضافة غرامة</td>
                <td class="auto-style4">
                   <a href="aadF.aspx">اضغط هنا</a>          

                </td>
            </tr>
            <tr>
                <td class="auto-style3">اضافة مواطن</td>
                <td class="auto-style4">
                    <a href="addC.aspx">اضغط هنا</a>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyNames="id" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="None">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="VehicleID" HeaderText="VehicleID" SortExpression="VehicleID" />
                <asp:BoundField DataField="Fines" HeaderText="Fines" SortExpression="Fines" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            </Columns>
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:myCon %>" DeleteCommand="DELETE FROM [Citizens] WHERE [id] = @id" InsertCommand="INSERT INTO [Citizens] ([VehicleID], [Fines], [Name]) VALUES (@VehicleID, @Fines, @Name)" SelectCommand="SELECT * FROM [Citizens]" UpdateCommand="UPDATE [Citizens] SET [VehicleID] = @VehicleID, [Fines] = @Fines, [Name] = @Name WHERE [id] = @id">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="VehicleID" Type="String" />
                <asp:Parameter Name="Fines" Type="Int32" />
                <asp:Parameter Name="Name" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="VehicleID" Type="String" />
                <asp:Parameter Name="Fines" Type="Int32" />
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
