<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="WebApplication1.Customers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customers</title>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.12.1/css/jquery.dataTables.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.2/css/all.min.css" />
    <script type="text/javascript" src="https://cdn.datatables.net/1.12.1/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" src="Customers.js?v=10"></script>
        <style>
        *{
            margin:0px;
            padding:0px;
            box-sizing:border-box;
        }
        
        body{
            width:90%;
            margin:auto;
            background-color:lightblue;
            font-family:Cambria, Cochin, Georgia, Times, Times New Roman, serif;
            padding:5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-row">
            <div class="col">
                <asp:Label runat="server">Customer ID:</asp:Label>
                <asp:TextBox id="cId" runat="server" type="text" ToolTip="ID of the Customer"></asp:TextBox>
            </div>
            <div class="col">
                <asp:Label runat="server">Customer Name:</asp:Label>
                <asp:TextBox runat="server" id="cName" type="text" ToolTip="Name of the Customer"></asp:TextBox>
            </div>
            <div class="col">
                <asp:Label runat="server">Customer Mobile Number:</asp:Label>
                <asp:TextBox id="cMblNumber" runat="server" type="text" ToolTip="Mobile Number of the Customer:"></asp:TextBox>
            </div>
            <div class="col">
                <asp:Label runat="server">Customer Age:</asp:Label>
                <asp:TextBox ID="cAge" runat="server" ToolTip="Age of the Customer" type="number"></asp:TextBox>
            </div>
            <div class="col">
                <button class="btn btn-primary btn-lg" type="button" onclick="AddCustomer()">New Customer</button>
            </div>
          </div>
        <div>
            <table id="customersTable">
                <thead>
                    <tr>
                        <th>Customer Name</th>
                        <th>Customer Mobile Number</th>
                        <th>Customer Age</th>
                        <th>Actions</th>
                    </tr>
                </thead>
                <tbody>
                </tbody>
            </table>
        </div>
    </form>
    
</body>
</html>
