<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="WebApplication1.Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Details</title>
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
            margin-top:15%;
        }

        div{
            border:3px solid black;           
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>The Details of the Employee are:</p>
            <p>ID: <span id="ID" runat="server"></span></p>
            <p>Name: <span id="name" runat="server"></span></p>
            <p>Role: <span id="roll" runat="server"></span></p>
            <p>Salary: <span id="salary" runat="server"></span></p>
            <p>Address: <span id="location" runat="server"></span></p>
        </div>
    </form>
</body>
</html>
