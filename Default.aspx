<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 307px;
        }
    </style>
    <link href="extions/StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <ul class="nav">
  <li><a href="Default.aspx">Home</a></li>
  <li><a href="#">About Us</a></li>
  <li><a href="#">Services</a></li>
  <li><a href="#">Products</a></li>
  <li><a href="#">Contact</a></li>
</ul>
    <form id="form1" runat="server">
    <div>


        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    رقم المركبة</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" Height="22px" Text="Button" OnClick="Button1_Click" />
                </td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
