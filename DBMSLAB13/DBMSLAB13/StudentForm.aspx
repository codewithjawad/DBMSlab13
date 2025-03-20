<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentForm.aspx.cs" Inherits="DBMSLAB13.StudentForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Student ID</td>
                    <td><asp:TextBox id="txtbStdID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Student Name</td>
                    <td>
                        <asp:TextBox ID="txtbStdname" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Age</td>
                    <td>
                        <asp:TextBox ID="txtbStdage" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Grade</td>
                    <td>
                        <asp:TextBox ID="txtbStdgrade" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                <td>
                    <asp:Button runat="server" ID="btnadd" Text="Add" onclick="btnInsert_OnClick"/>
                    <asp:Button runat="server" ID="Button1" Text="Update" onclick="btnUpdate_OnClick"/>
                    <asp:Button runat="server" ID="Button2" Text="Delete" onclick="btnDelete_OnClick"/>
                </td>
                </tr>
            </table><br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" Height="100px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField datafield="" HeaderText="Student Id"/>
                    <asp:BoundField datafield="" HeaderText="Name"/>
                    <asp:BoundField datafield="" HeaderText="Age"/>
                    <asp:BoundField datafield="" HeaderText="Grade"/>
                </Columns>
            </asp:GridView>
            <br/>
            <asp:Label id="errormsg" forecolor="Red" runat="server"></asp:Label>
            
        </div>
    </form>
</body>
</html>
