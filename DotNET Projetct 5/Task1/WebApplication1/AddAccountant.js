﻿var emptyRow = "<tr><td colspan='6' class='text-center'> No Accountants Added yet</td></tr>";
$(document).ready(function () {
    loadDataFromLocal();
    $('#tblData').on('click', '.btn-edit', function () {
        const name = $(this).parent().parent().find(".txtName").html();
        const contact = $(this).parent().parent().find(".txtContact").html();
        const altContact = $(this).parent().parent().find(".txtAltNo").html();
        const address = $(this).parent().parent().find(".txtAddress").html();
        const id = $(this).parent().parent().find(".txtName").attr("data-id");
        $("#txtName").val(name);
        $("#txtContact").val(contact);
        $("#txtAltNo").val(altContact);
        $("#txtAddress").val(address);
        $("#txtId").val(id);
        $("#btnSave").text("Update");
    });

    $('#tblData').on('click', '.btn-delete', function () {
        const id = $(this).parent().parent().find(".txtName").attr("data-id");
        deleteDataFromLocal(id);
    });

    $("#btnSave").click(function () {
        if ($("#txtId").val() == '') {
            addDataToLocal();
        } else {
            updateDataFromLocal();
        }
    });

    $("#btnClear").click(function () {
        clearForm();
    });
});

function clearForm() {
    $("#txtName").val("");
    $("#txtContact").val("");
    $("#txtAltNo").val("");
    $("#txtAddress").val("");
    $("#btnSave").text("Add");
}

function addEmptyRow() {
    if ($("#tblData tbody").children().children().length == 0) {
        $("#tblData tbody").append(emptyRow);
    }
}

function loadDataFromLocal() {
    let localDataAccountant = localStorage.getItem('localDataAccountant');
    if (localDataAccountant) {
        $("#tblData tbody").html("");
        let localArray = JSON.parse(localDataAccountant);
        let index = 1;
        localArray.forEach(element => {
            let dynamicTR = "<tr>";
            dynamicTR = dynamicTR + "<td> " + index + "</td>";
            dynamicTR = dynamicTR + "<td class='txtName'  data-id=" + element.id + ">" + element.name + "</td>";
            dynamicTR = dynamicTR + "<td class='txtContact'>" + element.contact + "</td>";
            dynamicTR = dynamicTR + "<td class='txtAltNo'>" + element.altContact + "</td>";
            dynamicTR = dynamicTR + "<td class='txtAddress'>" + element.address + "</td>";
            dynamicTR = dynamicTR + "    <td class='tdAction text-center'>";
            dynamicTR = dynamicTR + "        <button class='btn btn-sm btn-success btn-edit'> Edit</button>";
            dynamicTR = dynamicTR + "        <button class='btn btn-sm btn-danger btn-delete'> Delete</button>";
            dynamicTR = dynamicTR + "    </td>";
            dynamicTR = dynamicTR + " </tr>";
            $("#tblData tbody").append(dynamicTR);
            index++;
        });
    }
    addEmptyRow();
}

function addDataToLocal() {
    let localDataAccountant = localStorage.getItem('localDataAccountant');
    if (localDataAccountant) {
        let localArray = JSON.parse(localDataAccountant);
        const obj = {
            id: localArray.length + 1,
            name: $("#txtName").val(),
            contact: $("#txtContact").val(),
            altContact: $("#txtAltNo").val(),
            address: $("#txtAddress").val()
        };
        localArray.push(obj);
        localStorage.setItem('localDataAccountant', JSON.stringify(localArray));
        loadDataFromLocal();
    } else {
        const arryObj = [];
        const obj = {
            id: 1,
            name: $("#txtName").val(),
            contact: $("#txtContact").val(),
            altContact: $("#txtAltNo").val(),
            address: $("#txtAddress").val()
        };
        arryObj.push(obj);
        localStorage.setItem('localDataAccountant', JSON.stringify(arryObj));
        loadDataFromLocal();
    }
    clearForm();
}

function updateDataFromLocal() {
    let localDataAccountant = localStorage.getItem('localDataAccountant');
    let localArray = JSON.parse(localDataAccountant);
    const oldRecord = localArray.find(m => m.id == $("#txtId").val());
    oldRecord.name = $("#txtName").val();
    oldRecord.contact = $("#txtContact").val();
    oldRecord.altContact = $("#txtAltNo").val();
    oldRecord.address = $("#txtAddress").val();
    localStorage.setItem('localDataAccountant', JSON.stringify(localArray));
    loadDataFromLocal();
    clearForm();
}

function deleteDataFromLocal(id) {
    let localDataAccountant = localStorage.getItem('localDataAccountant');
    let localArray = JSON.parse(localDataAccountant);
    let i = 0;
    while (i < localArray.length) {
        if (localArray[i].id === Number(id)) {
            localArray.splice(i, 1);
        } else {
            ++i;
        }
    }
    localStorage.setItem('localDataAccountant', JSON.stringify(localArray));
    loadDataFromLocal();
}