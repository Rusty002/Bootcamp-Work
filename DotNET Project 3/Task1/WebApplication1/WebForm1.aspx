<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Task1</title>
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
        }
        .container{
            position:center;
            width:25%;
            padding:50px;
            margin-top:20%;
            margin-left:40%;
            border-radius:15px;
            background-color:cadetblue
        }

        #counterBtn{
            width:25%;
            padding:25px;
            margin-left:40%;
            border-radius:8px;
            background-color:burlywood;
        }

        #counterBtn:hover{
            background-color:aquamarine;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:Label runat="server" ID="text" >Counter:</asp:Label>
            <asp:TextBox runat="server" ID="textbox" ToolTip="Value of Counter">0</asp:TextBox>
            
        </div>
        <asp:Button runat="server" ID="counterBtn" Text="Click to increase counter" OnClick="btnClickIncrement"/>
    </form>
</body>
</html>
