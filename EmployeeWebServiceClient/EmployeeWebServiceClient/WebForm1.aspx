﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EmployeeWebServiceClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table style="font-family: Arial; border: 1px solid black;">
            <tr>
                <td>
                    <b>ID</b>
                </td>
                <td>
                    <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <b>Name</b>
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <b>Gender</b>
                </td>
                <td>
                    <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <b>City</b>
                </td>
                <td>
                    <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <b>Date Of Birth</b>
                </td>
                <td>
                    <asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <b>Employee Type</b>
                </td>
                <td>
                    <asp:DropDownList ID="ddlEmployeeType" runat="server" OnSelectedIndexChanged="ddlEmployeeType_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem Value="-1">Select Employee Type</asp:ListItem>
                        <asp:ListItem Value="1">Full Time Employee</asp:ListItem>
                        <asp:ListItem Value="2">Part Time Employee</asp:ListItem>

                    </asp:DropDownList>
                </td>
            </tr>

            <tr id="trAnnualSalary" runat="server" visible="false">
                <td>
                    <b>Annual Salary</b>
                </td>
                <td>
                    <asp:TextBox ID="txtAnnualSalary" runat="server"></asp:TextBox></td>
            </tr>

            <tr id="trHourlyPay" runat="server" visible="false">
                <td>
                    <b>Hourly Pay</b>
                </td>
                <td>
                    <asp:TextBox ID="txtHourlyPay" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr id="trHoursWorked" runat="server" visible="false">
                <td>
                    <b>Hours worked</b>
                </td>
                <td>
                    <asp:TextBox ID="txtHoursWorked" runat="server"></asp:TextBox>
                </td>
            </tr>


            <tr>
                <td>
                    <asp:Button ID="btnGetEmployee" runat="server" Text="Get Employee" OnClick="btnGetEmployee_Click" />
                </td>
                <td>
                    <asp:Button ID="btnSave" runat="server" Text="Save Employee" OnClick="btnSave_Click" />
                </td>
            </tr>

            <tr>
                <td colspan="2">
                    <asp:Label ID="lblMessage" ForeColor="Green" Font-Bold="true" runat="server"></asp:Label>
                </td>
            </tr>

        </table>
    </form>
</body>
</html>
