<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Index Page</title>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.12.1/css/jquery.dataTables.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.2/css/all.min.css" />
    <script type="text/javascript" src="https://cdn.datatables.net/1.12.1/js/jquery.dataTables.min.js"></script>
    <style>
        *{
            margin:0px;
            padding:0px;
            box-sizing:border-box;
        }
        
        body{
            width:80%;
            margin:auto;
            background-color:lightblue;
            font-family:Cambria, Cochin, Georgia, Times, Times New Roman, serif;
            font-size:25px;
            padding:5px;
            text-align:center;
        }
    </style>
</head>
<body>
    <form runat="server">
        <h1>Welcome to the Project</h1>
        <asp:Label ID="user" runat="server">User:</asp:Label>
        <asp:TextBox ID="name" runat="server" ></asp:TextBox>
        <br />
        <asp:Label ID="pass" runat="server">Password: </asp:Label>
        <asp:TextBox ID="word" runat="server"></asp:TextBox>
        <br />
        <asp:DropDownList ID="dropdown" runat="server">
            <asp:ListItem Enabled="true" Text="Option" Value="0">--Select An Option--</asp:ListItem>
            <asp:ListItem Enabled="true" Text="Admin" Value="1">Administrator</asp:ListItem>
            <asp:ListItem Enabled="true" Text="Accountant" Value="2">Accountant</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Login" Text="Login" runat="server" OnClick="Login_Click"/>
    </form>
</body>
</html>
