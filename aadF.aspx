<%@ Page Language="C#" AutoEventWireup="true" CodeFile="aadF.aspx.cs" Inherits="aadF"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="extions/StyleSheet.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 212px;
        }
    </style>
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
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <table class="table-style">
            <tr>
                <td class="auto-style1">
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    
                </td>
                <td>رقم المركبة</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>الغرامة</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
