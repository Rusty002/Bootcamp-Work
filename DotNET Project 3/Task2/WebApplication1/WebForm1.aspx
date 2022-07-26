<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Task2</title>
    <style>
        *{
            margin:0px;
            padding:0px;
            box-sizing:border-box;
        }
        
        body{
            width:80%;
            margin:auto;
            background-color:blanchedalmond;
            font-family:Cambria, Cochin, Georgia, Times, Times New Roman, serif;
            font-size:25px;
        }

        #username,
        #password{
            padding:5px;
            width:100%;
            border-radius:15px;
        }
        #submit,
        #viewState,
        #hiddenState{
            padding:8px;
            width:30%;
            margin-left:15px;
            margin-top:10px;
            border-radius:12px;
        }

        #submit:hover,
        #viewState:hover,
        #hiddenState:hover{
            background-color:forestgreen;
        }


        
    </style>
    <script>
        function saveHidden() {
            var tempuser = document.getElementById("username").value;
            var temppass = document.getElementById("password").value;
            document.getElementById("userField").value = tempuser;
            document.getElementById("passwordField").value = temppass;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" >Username:</asp:Label>
            <asp:TextBox runat="server" ID="username" ToolTip="Enter name of User"></asp:TextBox>
            <br />
            <asp:Label runat="server" >Password:</asp:Label>
            <asp:TextBox type="password" runat="server" ID="password" ToolTip="Enter an Alphanumeric Password"></asp:TextBox>
            <br />
            <asp:Button runat="server" ID="submit" Text="Submit" OnClick="SubmitClear" onclientclick="javascript: return saveHidden()"/>
            <asp:Button runat="server" ID="viewState" Text="Restore With View State" OnClick="RestoreViewState"/>
            <asp:Button runat="server" ID="hiddenState" Text="Restore with Hidden Fields"  OnClick="RestoreWithHidden"/>
            <asp:HiddenField ID="userField" runat="server"/>
            <asp:HiddenField ID="passwordField" runat="server" />
        </div>
    </form>
    
</body>
</html>
