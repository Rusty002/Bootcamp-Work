$(document).ready(function () {
        $.ajax({
            url: 'Items.aspx/GetItems',
            method: 'post',
            dataType: 'json',
            contentType: 'application/json',
            async: false,
            success: function (data) {
                $('#itemsTable').dataTable({
                    data: JSON.parse(data.d),
                    columns: [
                        {
                            "targets": 0, "data": "Id", "searchable": true
                        },
                        { "targets": 1, "data": "type", "sortable": true, "searchable": false },
                        { "targets": 2, "data": "name", "sortable": true, "searchable": true },
                        { "targets": 3, "data": "brand", "sortable": false, "searchable": true },
                        {
                            "targets": 4,
                            "data":"Id",
                            "render": function (data, type, row, meta) {
                                var editButton = '<button type="button" class="btn action-btn btn-primary btn-sm edit-btn mr-1" onclick="EditItem(' + data + ')">Edit</button>';
                                var deleteButton = '<button type="button" class="btn action-btn btn-danger btn-sm delete-btn" onclick="DeleteItem(' + data + ')">Delete</button>';
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

function AddItem() {
    var id = document.getElementById("itemId").value;
    var name = document.getElementById("itemName").value;
    var type = document.getElementById("itemType").value;
    var brand = document.getElementById("itemBrand").value;
    $.ajax({
        url: 'Items.aspx/AddItem',
        method: 'post',
        dataType: 'json',
        data: JSON.stringify({"id":id,"name":name,"type":type,"brand":brand}),
        contentType: 'application/json',
        async: false,
        success: function (data) {
            document.getElementById("itemId").value = null;
            document.getElementById("itemName").value = null;
            document.getElementById("itemType").value = null;
            document.getElementById("itemBrand").value = null;
            var newTable = $('#itemsTable').DataTable();
            newTable.destroy();
            $('#itemsTable').DataTable({
                data: JSON.parse(data.d),
                columns: [
                    {
                        "targets": 0, "data": "Id", "searchable": true
                    },
                    { "targets": 1, "data": "type", "sortable": true, "searchable": false },
                    { "targets": 2, "data": "name", "sortable": true, "searchable": true },
                    { "targets": 3, "data": "brand", "sortable": false, "searchable": true },
                    {
                        "targets": 4,
                        "data": id,
                        "render": function (data, type, row, meta) {
                            var editButton = '<button type="button" class="btn action-btn btn-primary btn-sm edit-btn mr-1" onclick="EditItem(' + data + ')">Edit</button>';
                            var deleteButton = '<button type="button" class="btn action-btn btn-danger btn-sm delete-btn" onclick="DeleteItem(' + data + ')">Delete</button>';
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

function DeleteItem(data) {
    var id = data;
    $.ajax({
        url: 'Items.aspx/DeleteItem',
        method: 'post',
        dataType: 'json',
        data: JSON.stringify({ "id": id}),
        contentType: 'application/json',
        async: false,
        success: function (data) {
            var newTable = $('#itemsTable').DataTable();
            newTable.destroy();
            $('#itemsTable').DataTable({
                data: JSON.parse(data.d),
                columns: [
                    {
                        "targets": 0, "data": "Id", "searchable": true
                    },
                    { "targets": 1, "data": "type", "sortable": true, "searchable": false },
                    { "targets": 2, "data": "name", "sortable": true, "searchable": true },
                    { "targets": 3, "data": "brand", "sortable": false, "searchable": true },
                    {
                        "targets": 4,
                        "data":"Id",
                        "render": function (data, type, row, meta) {
                            var editButton = '<button type="button" class="btn action-btn btn-primary btn-sm edit-btn mr-1" onclick="EditItem(' + data + ')">Edit</button>';
                            var deleteButton = '<button type="button" class="btn action-btn btn-danger btn-sm delete-btn" onclick="DeleteItem(' + data + ')">Delete</button>';
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