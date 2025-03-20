<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="~/Views/Admin/Employee_Info.aspx.cs" Inherits="DBMSLAB13.EmployeeInformation" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Information</title>
    <link rel="stylesheet" href="../../lib/Bootstrap/css/bootstrap.min.css"/>
    <style>
       .container {
            position:relative;           
            left:-50px;
        }
        .form-control {
            width: 100%;
        }
        #emplist {
            width: 100%;
            text-align:center;
        }
    </style>
</head>
<body>
     <form id="form1" runat="server">
            <nav class="navbar navbar-expand-lg bg-danger">
            <div class="container-fluid">
                <a class="navbar-brand text-light" href="#">Navbar</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                        <li class="nav-item">
                            <a class="nav-link text-light" href="Employee_Info.aspx">Home</a>
                        </li>
                        <li class="nav-item">
                             <a class="nav-link text-light" href="AdminLogin.aspx">Logout</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
        <div class="container">
            <div class="row">
                <div class="col-md-3" style="position:relative">
                    <h4 class="text-center mb-4 text-success">Employee Information</h4>
                 <%--   <div class="mb-3">
                        <label for="txtEmployeeID" class="form-label" min="50">Employee ID:</label>
                        <asp:TextBox ID="txtEmployeeID" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>--%>
                    <div class="mb-3">
                        <label for="txtName" class="form-label">Employee Name:</label>
                        <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="txtAddress" class="form-label">Employee Address:</label>
                        <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="txtphone" class="form-label">Employee Phone:</label>
                        <asp:TextBox ID="txtphone" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="txtEmail" class="form-label">Employee Email:</label>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="txtdob" class="form-label">Employee DOB:</label>
                        <asp:TextBox ID="txtdob" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="txtdoj" class="form-label">Employee DOJ:</label>
                        <asp:TextBox ID="txtdoj" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="txtposition" class="form-label">Employee Position:</label>
                        <asp:TextBox ID="txtposition" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="empsalary" class="form-label">Employee Salary:</label>
                        <asp:TextBox ID="empsalary" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="mb-2">
                        <asp:Button ID="btnInsert" runat="server" Text="INSERT" OnClick="btnInsert_OnClick" CssClass="btn btn-warning me-2" />
                        <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" OnClick="btnUpdate_OnClick" CssClass="btn btn-primary me-2" />
                        <asp:Button ID="btnDelete" runat="server" Text="DELETE" OnClick="btnDelete_OnClick" CssClass="btn btn-danger me-2" />
                    </div>
                    <div>
                        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                    </div>
                </div>
                <div class="col-md-9">
                    <h4 class="text-center mb-4 text-success">Employee List</h4>
                <asp:GridView ID="emplist" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" AutoGenerateSelectButton="True" OnSelectedIndexChanged="emplist_SelectedIndexChanged">
                <FooterStyle BackColor="#CCCCCC"></FooterStyle>
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White"></HeaderStyle>
                <PagerStyle HorizontalAlign="Left" BackColor="#CCCCCC" ForeColor="Black"></PagerStyle>
                <RowStyle BackColor="White"></RowStyle>
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White"></SelectedRowStyle>
                <SortedAscendingCellStyle BackColor="#F1F1F1"></SortedAscendingCellStyle>
                <SortedAscendingHeaderStyle BackColor="#808080"></SortedAscendingHeaderStyle>
                <SortedDescendingCellStyle BackColor="#CAC9C9"></SortedDescendingCellStyle>
                <SortedDescendingHeaderStyle BackColor="#383838"></SortedDescendingHeaderStyle>
            </asp:GridView>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
