<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="WelcomeDoctorPage.aspx.cs" Inherits="Patient_Health_Monitoring_System.WelcomeDoctorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/WelcomepageDoctorStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 167px" class="header">
    <h2>Patient's Health Monitoring system using<br />
   Fog Centric IoT Technology</h2>
      
    </div>
        <div class="center" style="color:#992b7f;">
            <br />
            <a href="ViewPatientDetails.aspx">View All Patients Details</a><br /><br /><br />
            <a href="EmergencyCasePatient.aspx">View Emergency Patients Details</a>
        </div>
    </form>
</body>
</html>
