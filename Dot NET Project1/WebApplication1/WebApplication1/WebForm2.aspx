<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Result Page</title>
    <link href="StyleSheet.css" rel="stylesheet"/>
</head>
<body>
    <form id="form2" runat="server">
        <%--Page 2 for showing result and numbers--%>
        <h1>This is Page 2 for showing the result of calculator</h1>
        <div>
            <asp:Label runat="server">x = </asp:Label>
            <asp:TextBox ID="firstNumber" runat="server" ToolTip="Enter a Number"></asp:TextBox>
            <br /><br />
            <asp:Label runat="server">y = </asp:Label>
            <asp:TextBox ID="secondNumber" runat="server" ToolTip="Enter a Number"></asp:TextBox>
            <br /><br />
            <asp:Label runat="server">Selected Operation was:</asp:Label>
            <asp:TextBox ID="selectedValue" runat="server" ToolTip="Opeaion"></asp:TextBox>
            <br /><br />
            <asp:Label runat="server">Answer = </asp:Label>
            <asp:TextBox ID="result" runat="server" ToolTip="Answer after calculation displayed on a new page"></asp:TextBox>
        </div>
    </form>
</body>
</html>
