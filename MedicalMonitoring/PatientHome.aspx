<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PatientHome.aspx.cs" Inherits="MedicalMonitoring.PatientHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Welcome <%=Session["name"] %></h2>
    <div>
        Token : <%=Session["token"] %> (Use this token in monitoring app)
    </div>


</asp:Content>
