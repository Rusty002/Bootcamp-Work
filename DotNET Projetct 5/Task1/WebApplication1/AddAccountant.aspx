<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddAccountant.aspx.cs" Inherits="WebApplication1.AddAccountant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Accountant</title>
<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.12.1/css/jquery.dataTables.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.2/css/all.min.css" />
    <script type="text/javascript" src="https://cdn.datatables.net/1.12.1/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" src="AddAccountant.js"></script>
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
        @media (min-width: 576px) {
          .jumbotron {
            padding: 1rem 2rem;
          }
        }
        .errdiv {
          color: red;
          font-weight: bold;
        }

        label {
          margin-bottom: 0;
        }

        .tdaction {
          width: 15%;
        }

        .tdSr {
          width: 7%;
        }

        .jumbotron {
          margin-bottom: 0.5rem;
        }

        input.largerCheckbox {
          width: 20px;
          height: 20px;
        }
  </style>
</head>
<body>
  <div class="container">
    <div class="jumbotron text-center bg-success text-white">
      <h2>ADD Accountant</h2>
    </div>
    <div class="form-row">
      <div class="col-md-3">
        <label>Accountant Name: <span class="errdiv"> *</span></label>
        <input id="txtName" type="text" class="form-control txt txtName" placeholder="Enter Name of the Accountant" required />
        <input id="txtId" type="hidden" class="form-control txt"/>
      </div>
      <div class="col-md-3 col-sm-6 col-6">
        <label>Email:<span class="errdiv"> *</span></label>
        <input id="txtContact" data-type="email" type="text" minlength="1" maxlength="30"
          class="form-control txt txtContact" placeholder="Email of the Accountant" required />
      </div>
      <div class="col-md-3 col-sm-6 col-6">
        <label>Mobile Number:</label>
        <input id="txtAltNo" type="text" class="form-control txt txtAltNo" minlength="1" maxlength="20"
          placeholder="Mobile Number of the Accountant" />
      </div>
    </div>
    <div class="form-row">
      <div class="col-md-6 col-sm-7">
        <label>Address & Details<span class="errdiv"> *</span></label>
        <textarea id="txtAddress" class="form-control txt txtAddress" rows="3" minlength="15"
          placeholder="Enter Address" required></textarea>
      </div>
    </div>
    <div class="row pt-2">
      <div class="col-md-2">
        <button type="button" class="btn btn-success" id="btnSave">Save</button>
      </div>
      <div class="col-md-2">
        <button type="button" class="btn btn-secondary" id="btnClear">Clear</button>
      </div>
    </div>
    <div class="row pt-3">
      <div class="col-md-12 col-sm-12 col-12 p-2 ">
        <table id="tblData" class="table table-bordered table-hover table-striped">
          <thead>
            <tr>
              <th>Sr No</th>
              <th>Accountant Name</th>
              <th>Accountant Email</th>
              <th>Accountant Mobile</th>
              <th>Address and Details</th>
              <th class="text-center">Action</th>
            </tr>
          </thead>
          <tbody> 
          </tbody>
        </table>
      </div>
    </div>
  </div>   
</body>
</html>
