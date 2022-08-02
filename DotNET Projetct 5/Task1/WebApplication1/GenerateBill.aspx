<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GenerateBill.aspx.cs" Inherits="WebApplication1.GenerateBill" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Generate Bill</title>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.12.1/css/jquery.dataTables.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.2/css/all.min.css" />
    <script type="text/javascript" src="https://cdn.datatables.net/1.12.1/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" src="GenerateBill.js"></script>
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

        strong {
          font-size: 24px !important;
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
      <h2>Generate Bill</h2>
    </div>
    <div class="form-row">
      <div class="col-md-3">
        <label>Item Name: <span class="errdiv"> *</span></label>
        <input id="txtName" type="text" class="form-control txt txtName" placeholder="Enter Name of the Item" required />
        <input id="txtId" type="hidden" class="form-control txt"/>
      </div>
      <div class="col-md-3 col-sm-6 col-6">
        <label>Market Price:<span class="errdiv"> *</span></label>
        <input id="txtContact" data-type="number" type="text" minlength="1" maxlength="10"
          class="form-control txt txtContact" placeholder="Price of the Item According to Market" required />
      </div>
      <div class="col-md-3 col-sm-6 col-6">
        <label>Discounted Price:</label>
        <input id="txtAltNo" type="text" class="form-control txt txtAltNo" minlength="1" maxlength="10"
          placeholder="Discounted Price Offered" />
      </div>
    </div>
    <div class="form-row">
      <div class="col-md-6 col-sm-7">
        <label>Quantity & Details<span class="errdiv"> *</span></label>
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
              <th>Item Name:</th>
              <th>Market Price:</th>
              <th>Discounted Price</th>
              <th>Quantity and Remarks</th>
              <th class="text-center">Action</th>
            </tr>
          </thead>
          <tbody> 
          </tbody>
        </table>
      </div>
    </div>
      <form>
      <div class="form-row align-items-center">
        <div class="col-sm-3 my-1">
          <label class="sr-only" for="inlineFormInputName">Total</label>
          <input type="number" class="form-control" id="total" placeholder="Enter Total Sum" required/>
        </div>
        <div class="col-auto my-1">
          <button type="submit" class="btn btn-primary" onclick="GenerateBill()">Generate Bill</button>
        </div>
      </div>
    </form>
  </div>

</body>
</html>