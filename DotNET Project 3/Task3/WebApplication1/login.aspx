<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Task3</title>
    <style>
        *{
            margin:0px;
            padding:0px;
            box-sizing:border-box;
        }
        
        body{
            width:80%;
            margin:auto;
            background-color:blanchedalmond;
            font-family:Cambria, Cochin, Georgia, Times, Times New Roman, serif;
            font-size:25px;
        }
        
        #username,
        #password{
            width:100%;
            padding:8px;
            border-radius:12px;
        }

        #login{
            padding:12px;
            margin-top:10px;
            border-radius:10px;
        }

        #login:hover{
            background-color:cornflowerblue;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server">Username: </asp:Label>
            <asp:TextBox runat="server" ID="username" ToolTip="Enter Name of User"></asp:TextBox>
            <br />
            <asp:Label runat="server">Password: </asp:Label>
            <asp:TextBox runat="server" ID="password" type="password" ToolTip="Enter Password"></asp:TextBox>
            <br />
            <asp:Button runat="server" ID="login" Text="Login" OnClick="LoginBtn"/>
        </div>
    </form>
</body>
</html>
