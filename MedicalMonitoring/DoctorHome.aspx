<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DoctorHome.aspx.cs" Inherits="MedicalMonitoring.DoctorHome" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">

        <h2>Welcome <%=Session["name"] %></h2>

        <h3>Patient List</h3>

        <asp:GridView runat="server" ID="gridview_patients" AutoGenerateColumns="false" CssClass="table">
            <Columns>

                <asp:BoundField DataField="name" HeaderText="Name"  />
                <asp:BoundField DataField="email" HeaderText="Email" />
                <asp:BoundField DataField="dob" HeaderText="DOB" />
                <asp:BoundField DataField="address" HeaderText="Address" />
                <asp:BoundField DataField="contact" HeaderText="Contact" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <a href="/ViewPatientData.aspx?patientid=<%#Eval("patientid") %>">View Data</a>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>
