<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defalut.aspx.cs" Inherits="webForm4.Dafalut" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="JavaScript.js"></script>

</head>
<body>
    
    <form id ="form1" runat ="server">

        <div>
            <center>
                <h1>SEARCH RECORDS FROM DATABASE</h1>
                <hr />

           Search: <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
            <asp:Button ID="btSearch" runat="server" Text="Search" OnClick="btSearch_Click" />
            <hr />

            <asp:GridView ID="GridView1" runat="server" ShowHeaderWhenEmpty ="true" EmptyDataText ="No Record Found!">

            </asp:GridView>

            </center>

        </div>


    </form>

</body>
</html>
