<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.Controllers.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Students</title>
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
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table id="studentsTable">
                <thead>
                    <tr>
                        <th>Student ID</th>
                        <th>First Name</th>
                        <th>Last Name</th>
                        <th>City</th>
                        <%--<th>Actions</th>--%>
                    </tr>
                </thead>
                <tbody>
                </tbody>
            </table>
        </div>
    </form>
    <script type="text/javascript">
        $(document).ready(function () {
            $.ajax({
                url: 'http://localhost:23463/api/values',
                method: 'get',
                dataType: 'json',
                contentType: 'application/json',
                async: false,
                success: function (data) {
                    $('#studentsTable').DataTable({
                        data: JSON.parse(data),
                        columns: [
                            {"targets": 0, "data": "StudentID", "searchable": true},
                            { "targets": 1, "data": "Fname", "sortable": true, "searchable": true },
                            { "targets": 2, "data": "Lname", "sortable": true, "searchable": true },
                            { "targets": 3, "data": "City", "sortable": true, "searchable": true }
                            //{
                            //    "targets": 4,
                            //    "data":"StudentID",
                            //    "render": function (data, type, row, meta) {
                            //        var editButton = '<button type="button" class="btn action-btn btn-primary btn-sm edit-btn mr-1" data-id="' + StudentID + '">Edit</button>';
                            //        var deleteButton = '<button type="button" class="btn action-btn btn-danger btn-sm delete-btn" data-id="' + StudentID + '">Delete</button>';
                            //        return editButton + " | " + deleteButton;
                            //    },
                            //    "sortable": false,
                            //    "searchable": false,
                            //    "visible": true
                            //}
                        ]
                    });
                },
                Error: function () {
                    alert("DataTable Failed to load Successfuly");
                }
            });
        })
    </script>
</body>
</html>

