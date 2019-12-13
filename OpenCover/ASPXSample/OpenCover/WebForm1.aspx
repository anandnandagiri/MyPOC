<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="OpenCoverDemoASPX.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <h1>  Open Cover Demo - ASP.NET Technologies </h1>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Hit Add" />
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Hit if true only" />
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Hit if both true and false" />
        </p>
        <asp:Label ID="lblsujith" name="lblsujith" runat="server" Visible="true" Text="..."></asp:Label>   </form>
</body>
</html>
