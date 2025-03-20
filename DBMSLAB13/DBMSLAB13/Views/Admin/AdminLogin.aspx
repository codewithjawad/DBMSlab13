<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="DBMSLAB13.Views.Admin.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin</title>
    <link rel="stylesheet" href="../../lib/Bootstrap/css/bootstrap.min.css"/>
    <style>
        * {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }
        body {
            background-color: whitesmoke;
            background-size: cover;
        }
    </style>
</head>
<body>
    <form runat="server">
        <div class="container-fluid">
            <div class="row" style="height:100px">
            </div>
            <div class="row">
                <div class="col-md-4"></div>
                <div class="col-md-4 bg-light rounded-3 mt-2 shadow-lg">
                    <h4 class="text-danger text-center mt-2">Shifa PharmaTrack System</h4>
                    <h4 class="text-success text-center">Login</h4>
                    <div class="mb-3">
                        <label for="CEmailTb" class="form-label">Email address</label>
                        <input type="email" class="form-control" runat="server" id="CEmailTb" aria-describedby="emailHelp" autocomplete="off" required="required"/>
                        <div id="emailHelp" class="form-text">We'll never share your email with anyone else.</div>
                    </div>
                    <div class="mb-3">
                        <label for="PassTb" class="form-label">Password</label>
                        <input type="password" class="form-control" runat="server" id="PassTb" required="required" autocomplete="off"/>
                    </div>
                    <div class="d-grid mb-3">
                        <label id="errormsg" runat="server" class="text-danger"></label>
                        <asp:Button ID="LoginBtn" runat="server" Text="Login" CssClass="btn btn-success btn-block" OnClick="LoginBtn_Click" />
                    </div>
                </div>
                <div class="col-md-4"></div>
            </div>
        </div>
    </form>
</body>
</html>
