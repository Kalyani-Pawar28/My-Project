<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoginDoctor.aspx.cs" Inherits="MedicalMonitoring.LoginDoctor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h1>Doctor Login</h1>
        <table>
            <tr>
                <td>Username</td>
                <td>
                    <asp:TextBox runat="server" ID="tb_username" />
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox TextMode="Password" runat="server" ID="tb_password" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button Text="Login" runat="server" ID="btn_login" OnClick="btn_login_Click" CssClass="btn btn-primary" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label Text="" ID="label_message" runat="server" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
