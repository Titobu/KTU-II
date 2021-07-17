<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="L1U1_Kvadratai_kvadrate.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="L1U1 Kvadratai kvadrate"></asp:Label>
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Skaičiuoti" />
        </div>
    </form>
        <asp:Label ID="Label2" runat="server" Text="Pradiniai duomenys:"></asp:Label>
        <asp:Table ID="Table1" runat="server">
        </asp:Table>
    
</body>
</html>
