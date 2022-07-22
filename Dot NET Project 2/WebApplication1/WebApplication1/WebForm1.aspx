<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Task 1 AJAX Assignment</title>
<%--    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css" 
        integrity="sha384-xOolHFLEh07PJGoPkLv1IbcEPTNtaed2xpHsD9ESMhqIYd0nLMwNLD69Npy4HI+N" crossorigin="anonymous" />
     --%>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="nameOfStudent" runat="server" Text="label">Select the name of Student:</asp:Label>
            <br />
            <asp:DropDownList ID="dropDownMenu" runat="server">
            </asp:DropDownList>
            <br />
            <%--<asp:Button OnClick="Page_Load" Text ="Generate Info" runat="server" OnClientClick=""/>--%>
            <p id="name"></p>
            <p id="rollNumber"></p>
            <p id="Grade"></p>
        </div>
    </form>
</body>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
    <script>
        const option = document.getElementById("dropDownMenu");
        option.addEventListener("change", () => {
            let query = $("#dropDownMenu option:selected").index();
            $.ajax({
                url: 'WebForm1.aspx/searchStudent',
                type: 'post',
                data: JSON.stringify({ "query": query }),
                contentType: 'application/json',
                async: true,
                success: function (data) {
                    $("#name").text(data.d.name);
                    $("#rollNumber").text(data.d.rollNumber);
                    $("#Grade").text(data.d.grade);

                }
            });
        });

    </script>
</html>
