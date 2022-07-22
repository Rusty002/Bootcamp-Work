<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
    <link href="StyleSheet.css" rel="stylesheet"/>
</head>
<body>
    <%--General Heading--%>
    <h1>Page1: This is a calculator</h1>

    <%--A General form for taking two input fields and mathematical operation--%>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server">x = </asp:Label>
            <asp:TextBox ID="firstNumber" runat="server" ToolTip="Enter a Number"></asp:TextBox>
            <br /><br />
            <asp:Label runat="server">y = </asp:Label>
            <asp:TextBox ID="secondNumber" runat="server" ToolTip="Enter a Number"></asp:TextBox>
            <br /><br />
            <asp:DropDownList ID="operations" runat="server">
                <asp:ListItem Enabled="true" Text="Select Operation" Value="-1"></asp:ListItem>
                <asp:ListItem Text="Addition" Value="1"></asp:ListItem>
                <asp:ListItem Text="Subtraction" Value="2"></asp:ListItem>
                <asp:ListItem Text="Division" Value="3"></asp:ListItem>
                <asp:ListItem Text="Multiplication" Value="4"></asp:ListItem>
            </asp:DropDownList>
            <br /><br />
            <asp:Button ID="calculateButton" runat="server" Text="Calculate" ToolTip="Perform the operation on numbers" OnClientClick="javaScript: return Validate()" OnClick="Calculate"/>
            <br /><br />
        </div>
    </form>
</body>
    <%--JavaScript Validation Function--%>
    <script type="text/javaScript">
        function Validate()
        {
            //Taking value of numbers and then checking them
            let x = document.getElementById("firstNumber").value;
            let y = document.getElementById("secondNumber").value;

            if (isNaN(x)) {

                alert("x is not a number");
                return false;

            }
            else if (isNaN(y))
            {
                alert("y is not a number");
                return false;
            }
            else if (document.getElementById("operations").value == -1){
                alert("You have not selected any operation");
                return false;
            }
            else
            {
                return true;
            }
        }
    </script>
</html>
