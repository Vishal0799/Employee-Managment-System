<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EditEmployee.aspx.cs" Inherits="project1.EditEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td>Enter Employee Id</td>
            <td>&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2">Entern Employee Id</td>
            <td colspan="2">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">Enter Employee Name</td>
            <td colspan="2">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">Enter Employee Father Name</td>
            <td colspan="2">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">Gender</td>
            <td colspan="2">
                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="Male" />
&nbsp;&nbsp;
                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="Female" />
            &nbsp;
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">Enter Employee Contact No.</td>
            <td colspan="2">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">Enter Employee Adress</td>
            <td colspan="2">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">Enter Employee City</td>
            <td colspan="2">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Rajasthan</asp:ListItem>
                    <asp:ListItem>Gujrat</asp:ListItem>
                    <asp:ListItem>Delhi</asp:ListItem>
                    <asp:ListItem>Tamil Nadu</asp:ListItem>
                    <asp:ListItem>Madhya Pradesh</asp:ListItem>
                    <asp:ListItem>Uttar Pradesh</asp:ListItem>
                </asp:DropDownList>
            &nbsp;&nbsp;
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="Delete" />
            </td>
            <td colspan="2">
                <asp:Button ID="Button3" runat="server" Text="Edit" OnClick="Button3_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
