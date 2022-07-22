<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Task 2: Intellisense</title>
</head>
<body>
    <h1>Task 2: Intellisense</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="input" runat="server">Enter Data here:
                <br />
                <asp:TextBox ID="inputData" runat="server" ToolTip="Enter the Model of car Here"></asp:TextBox>
                <div id="result"></div>
            </asp:Label>
        </div>
    </form>
</body>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
    <script>
        const carData = document.getElementById("inputData");
        carData.addEventListener("input", function () {
            let carD = document.getElementById("inputData").value;
            $.ajax({
                url: 'WebForm1.aspx/SearchCar',
                type: 'post',
                data: JSON.stringify({ "carData": carD }),
                contentType: 'application/json',
                async: true,
                success: function (data) {
                    if (data.d != []) {

                        //Removing the previous content on fetching new data

                        $("#result").empty()
                       
                        //Looping over fetched results to display it in dropdown box and a list below the searchbox

                        let carArr = data.d;
                        carArr.forEach((car) => {
                            
                            let listItem = document.createElement("li");
                           
                            listItem.innerText = car;
                            
                            result.appendChild(listItem);
                        })
                    }
                }

            })
        })
    </script>
</html>
