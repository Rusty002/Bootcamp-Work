<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Task2</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Welcome To Employee Database</h1>
        <div>
            <asp:GridView ID="myGrid" runat="server" BackColor="White" BorderColor="#E7E7FF"
                BorderStyle="None" BorderWidth="1px" CellPadding="3" Font-Names="Calibri" Font-Size="Larger"
                GridLines="Horizontal" AutoGenerateColumns="false" AllowPaging="true" PageSize="15" PagerSettings-Visible="true" 
                OnPageIndexChanging="myGrid_PageIndexChanging" OnSelectedIndexChanging="myGrid_SelectedIndexChanging" 
                OnRowEditing="myGrid_RowEditing" OnRowUpdating="myGrid_RowUpdating" OnRowDeleting="myGrid_RowDeleting" OnRowCancelingEdit="myGrid_RowCancelingEdit">
                <Columns>
                    <asp:BoundField HeaderText="ID of Employee" DataField="employeeID" />
                    <asp:BoundField HeaderText="Name Of Employee" DataField="employeeName" />
                    <asp:BoundField HeaderText="Role Of Employee" DataField="employeeRole" />
                    <%--<asp:ButtonField ButtonType="Button" Text="Edit" CommandName="editRow" />
                    <asp:ButtonField ButtonType="Button" Text="Delete" CommandName="deleteRow" />--%>
                    <asp:CommandField ShowSelectButton="true" ShowEditButton="true" ShowDeleteButton="true"/>
                </Columns>

                <PagerSettings Mode="NumericFirstLast" PageButtonCount="6" FirstPageText="First" LastPageText="Last" />

                <AlternatingRowStyle BackColor="#F7F7F7" />

                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />

                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />

                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />

                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />

                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />

                <SortedAscendingCellStyle BackColor="#F4F4FD" />

                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />

                <SortedDescendingCellStyle BackColor="#D8D8F0" />

                <SortedDescendingHeaderStyle BackColor="#3E3277" />

            </asp:GridView>
        </div>
    </form>
</body>
</html>
