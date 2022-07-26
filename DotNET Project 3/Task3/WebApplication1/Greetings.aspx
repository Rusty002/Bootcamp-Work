<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Greetings.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Successful Login</title>
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
        #logout{
            padding:12px;
            margin-top:10px;
            border-radius:10px;
        }

        #logout:hover{
            background-color:cornflowerblue;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 runat="server">Hello <span id="user" runat="server"></span></h1>
        </div>
        <asp:Button runat="server" ID="logout" Text="Logout" OnClick="BtnLogout"/>
    </form>
</body>
</html>
