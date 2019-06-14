<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MessageFetchForm.aspx.cs" Inherits="HelloServiceClient.MessageFetchForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" Width="319px"></asp:TextBox> <asp:Button ID="Button1" runat="server" Text="Get Message" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="LblMessage" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
