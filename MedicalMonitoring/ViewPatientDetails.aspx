<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="ViewPatientDetails.aspx.cs" Inherits="Patient_Health_Monitoring_System.ViewPatientDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/styleforViewPatientDetails.css" rel="stylesheet" />
</head>
<body>
<form runat="server">
    <div class="header">
        Patients Monitoring System using Fog Centric IoT Technology
    </div>
    <div class="center">
       <label for="Patient ID">Enter Patient ID : </label>
       <input type="text" runat="server"  id="txtPtntID" autocomplete="off"/> <br /><br />
       <button type="submit" class="button" runat="server" id="btnClickhere"> Click Here !</button> 
    </div>
    <div>
        <asp:GridView runat="server" ID="gvPatntDetls" AutoGenerateColumns="false" CssClass="center">
            <Columns>
                <asp:BoundField DataField="FirstName" HeaderText="First Name" ItemStyle-Width="100px" />
                <asp:BoundField DataField="LastName" HeaderText="Last Name" ItemStyle-Width="100px" />
                <asp:BoundField DataField="Email" HeaderText="Email" ItemStyle-Width="100px" />
                <asp:BoundField DataField="DOB" HeaderText="DOB" DataFormatString="{0:d}" ItemStyle-Width="100px" />
                <asp:BoundField DataField="Address" HeaderText="Address" ItemStyle-Width="100px"  />
                <asp:BoundField DataField="Mobile_No" HeaderText="Mobile No." ItemStyle-Width="100px" />
            </Columns>

        </asp:GridView>
    </div>
    <div class="mid-right">
       <a href="WelcomeDoctorPage.aspx">Home</a>
    </div>

</form>
</body>
</html>
