<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WelcomePage.aspx.cs" Inherits="Patient_Health_Monitoring_System.WelcomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type = "text/javascript" >
        function disableBackButton() {
            window.history.forward();
        }
        setTimeout("disableBackButton()", 0);
        window.onunload = function () {
            null
        };
    </script>
    <link href="css/styleforWelcomePage.css" rel="stylesheet" />
</head>
<body>

<div class="header">
  <h2>Patient's Health Monitoring system using<br />
   Fog Centric IoT Technology</h2>
</div>
<br>
<div class="row">
  <div class="column1" style="background-color:#a1c2c9;">
    <table>
        <tr> <td> <a href="ViewMyDetails.aspx">View My Details</a> </td> </tr>
        <tr> <td> <a href="BodySensors.aspx">Body Sensors</a></td> </tr>
        <tr> <td> <a href="CheckOwnHealthData.aspx">Check the Health Data</a> </td> </tr>
        <tr> <td> <a href="Home.aspx">Log Out</a> </td> </tr>
        </table>
  </div>
  <div class="column2" style="background-color:#c3dde3;">
    <h2> A Welcome Message from us...</h2>
    <p>It is our pleasure to welcome you to the website. We are committed to serving 
    our patients and their families and it is our mission to provide the very best medical care possible. 
    Patients often come to us with very complex medical needs that require extended recovery time. 
    We specialize in providing extended complex care and we understand the unique needs of our patient population. 
    Patients are given the time needed to recover allowing them to get back to better. 
    We offers extensive, high quality services from experienced, physicians in an environment where teamwork and a 
    commitment to service excellence is our top priority. Our experienced and dedicated team of 
    physicians, nurses and clinicians are committed to each patient as an individual thus ensuring 
    they receive the best possible care.</p>
  </div>
</div>
</body>
</html>
