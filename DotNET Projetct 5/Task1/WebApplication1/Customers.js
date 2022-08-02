$(document).ready(function () {
    $.ajax({
        url: 'Customers.aspx/GetCustomers',
        method: 'post',
        dataType: 'json',
        contentType: 'application/json',
        async: false,
        success: function (data) {
            $('#customersTable').DataTable({
                data: JSON.parse(data.d),
                columns: [
                    {
                        "targets": 0, "data": "name", "searchable": true
                    },
                    { "targets": 1, "data": "mobileNumber", "sortable": true, "searchable": true },
                    { "targets": 2, "data": "Age", "sortable": true, "searchable": true },
                    {
                        "targets": 3,
                        'data':'Id',
                        "render": function (data, type, row, meta) {
                            var editButton = '<button type="button" class="btn action-btn btn-primary btn-sm edit-btn mr-1" onclcik="EditCustomer(' + data + ')">Edit</button>';
                            var deleteButton = '<button type="button" class="btn action-btn btn-danger btn-sm delete-btn remove" onclick="DeleteCustomer(' + data + ')">Delete</button>';
                            return editButton + " | " + deleteButton;
                        },
                        "sortable": false,
                        "searchable": false,
                        "visible": true
                    }
                ]
            });
        },
        Error: function () {
            alert("DataTable Failed to load Successfuly");
        }
    });
})

function AddCustomer() {
    var name = document.getElementById("cName").value;
    var mobile = document.getElementById("cMblNumber").value;
    var age = document.getElementById("cAge").value;
    var id = document.getElementById("cId").value;
    
    $.ajax({
        url: 'Customers.aspx/NewCustomer',
        method: 'post',
        dataType: 'json',
        data: JSON.stringify({ "name": name, "mobile": mobile, "age": age, "id": id }),
        contentType: 'application/json',
        async: false,
        success: function (data) {
            document.getElementById("cName").value = null;
            document.getElementById("cMblNumber").value = null;
            document.getElementById("cAge").value = null;
            document.getElementById("cId").value = null;
            var newTable = $('#customersTable').DataTable();
            newTable.destroy();
            $('#customersTable').DataTable({
                data: JSON.parse(data.d),
                columns: [
                    {
                        "targets": 0, "data": "name", "searchable": true
                    },
                    { "targets": 1, "data": "mobileNumber", "sortable": true, "searchable": true },
                    { "targets": 2, "data": "Age", "sortable": true, "searchable": true },
                    {
                        "targets": 3,
                        'data': 'Id',
                        "render": function (data, type, row, meta) {
                            var editButton = '<button type="button" class="btn action-btn btn-primary btn-sm edit-btn mr-1" onclcik="EditCustomer(' + data + ')">Edit</button>';
                            var deleteButton = '<button type="button" class="btn action-btn btn-danger btn-sm delete-btn remove" onclick="DeleteCustomer(' + data + ')">Delete</button>';
                            return editButton + " | " + deleteButton;
                        },
                        "sortable": false,
                        "searchable": false,
                        "visible": true
                    }
                ]
            });
            
        },
        Error: function () {
            alert("DataTable Failed to load Successfuly");
        }
    });
}


function DeleteCustomer(data) {
    var id = data;
    console.log(id);
    $.ajax({
        url: 'Customers.aspx/DeleteCustomer',
        method: 'post',
        dataType: 'json',
        data: JSON.stringify({ "id": id }),
        contentType: 'application/json',
        async: false,
        success: function (data) {
            var newTable = $('#customersTable').DataTable();
            newTable.destroy();
            $('#customersTable').DataTable({
                data: JSON.parse(data.d),
                columns: [
                    {
                        "targets": 0, "data": "name", "searchable": true
                    },
                    { "targets": 1, "data": "mobileNumber", "sortable": true, "searchable": true },
                    { "targets": 2, "data": "Age", "sortable": true, "searchable": true },
                    {
                        "targets": 3,
                        'data': 'Id',
                        "render": function (data, type, row, meta) {
                            var editButton = '<button type="button" class="btn action-btn btn-primary btn-sm edit-btn mr-1" onclcik="EditCustomer(' + data + ')">Edit</button>';
                            var deleteButton = '<button type="button" class="btn action-btn btn-danger btn-sm delete-btn remove" onclick="DeleteCustomer(' + data + ')">Delete</button>';
                            return editButton + " | " + deleteButton;
                        },
                        "sortable": false,
                        "searchable": false,
                        "visible": true
                    }
                ]
            });
        },
        Error: function () {
            alert("DataTable Failed to load Successfuly");
        }
    });
}