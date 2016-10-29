<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="assign4tryit.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            margin-top: 42px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            1.verfication</p>
        <p>
            Xmlpath<asp:TextBox ID="TextBox1" runat="server" style="margin-left: 85px" Width="243px"></asp:TextBox>
            <br />
        </p>
        <p>
            Xsdpath<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 84px" Width="258px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            2.XPathSearch</p>
        <p>
            Xmlpath<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            Xpath<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="Button" style="height: 26px" />
        </p>
        <p>
            Output<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
    <div>
    
    </div>
    </form>
</body>
</html>
