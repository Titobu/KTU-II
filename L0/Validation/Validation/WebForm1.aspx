﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Validation.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Konkurso dalyvio registracija:"></asp:Label>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Vardas:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Vardas yra privalomas" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Amžius:"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Neteisinga metų reikšmė" ForeColor="Red" MaximumValue="25" MinimumValue="14" Type="Integer">*</asp:RangeValidator>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Programavimo kalba:"></asp:Label>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" DataSourceID="XmlDataSource1" DataTextField="pavadinimas" DataValueField="pavadinimas">
        </asp:CheckBoxList>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/languages.xml"></asp:XmlDataSource>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Registruotis" />
    </form>
</body>
</html>
