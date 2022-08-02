<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Items.aspx.cs" Inherits="WebApplication1.Items" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Items</title>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.12.1/css/jquery.dataTables.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.2/css/all.min.css" />
    <script type="text/javascript" src="https://cdn.datatables.net/1.12.1/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" src="https://cdn.datatables.net/1.12.1/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" src="items.js"></script>
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
                <asp:Label runat="server">Item ID:</asp:Label>
                <asp:TextBox runat="server" ID="itemId" type="number" ToolTip="ID of the item"></asp:TextBox>
            </div>
            <div class="col">
                <asp:Label runat="server">Item Type:</asp:Label>
                <asp:TextBox ID="itemType" runat="server" type="text" ToolTip="Type of the item"></asp:TextBox>
            </div>
            <div class="col">
                <asp:Label runat="server">Item Name:</asp:Label>
                <asp:TextBox ID="itemName" runat="server" ToolTip="Name of the item"></asp:TextBox>
            </div>
            <div class="col">
                <asp:Label runat="server">Item Brand:</asp:Label>
                <asp:TextBox ID="itemBrand" runat="server" ToolTip="Brand of the item"></asp:TextBox>
            </div>
            <div class="col">
                <button type="button" onclick="AddItem()">Add Item</button>
            </div>
          </div>
        <div>
            <table id="itemsTable" runat="server">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Item Type</th>
                        <th>Item Name</th>
                        <th>Item Brand</th>
                        <th>Actions</th>
                    </tr>
                </thead>
            </table>
        </div>
    </form>
</body>
</html>
