<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dashboard.aspx.cs" Inherits="_Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="NameLabel" runat="server" Text=""></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Notifications" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Current Classes" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="Completed Classes" OnClick="Button3_Click" />
        <br />
        <asp:Label ID="NoteLabel" runat="server" Text=""></asp:Label>
    </div>
    </form>
    
</body>
</html>
