<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewMyDetails.aspx.cs" Inherits="Patient_Health_Monitoring_System.ViewMyDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/styleforViewDetails.css" rel="stylesheet" />
</head>
<body>
 <div class="header">
    Patients Monitoring System using Fog Centric IoT Technology
     <div class="header-right">
       <a class="active" href="WelcomePage.aspx">Welcome Page</a>
     </div>
 </div>
 <div class="sidenav">
  <a href="CheckOwnHealthData.aspx">Check the Health Data</a><br />
  <a href="BodySensors.aspx">Body Sensors</a><br />
  <a href="HomePage.aspx">Logout</a>
</div>
 <div class="main">
 <div class="row">

    <div class="col-25">  <label for="user id">Patient ID :</label> </div>
    <div class="col-75">  <input type="text" runat="server" id="userid" name="User ID" placeholder="User Id" autocomplete="off" disabled="disabled" /></div>

     <div class="col-25"><label for="first name">First Name :</label></div>
     <div class="col-75"><input type="text" runat="server" id="frstname" name="First Name" placeholder="First Name" autocomplete="off" disabled="disabled" /></div>

     <div class="col-25"><label>Last Name :</label></div>
     <div class="col-75"><input type="text" runat="server" id="lstname" name="Last Name" placeholder="Last Name" autocomplete="off" disabled="disabled" /></div>

     <div class="col-25"><label>Email Address :</label></div>
     <div class="col-75"><input type="text" runat="server" id="email" name="email" placeholder="Email Address" disabled="disabled" /></div>

     <div class="col-25"><label>Birth Date :</label></div>
     <div class="col-75"><input type="text" runat="server" id="brtdate" name="brtdate" placeholder="DOB" disabled="disabled" /></div>

     <div class="col-25"><label>Gender :</label></div>
     <div class="col-75"><input type="text" runat="server" id="gen" name="gender" disabled="disabled" /></div>

     <div class="col-25"> <label>City :</label></div>
     <div class="col-75"><input type="text" runat="server" id="city" name="city" placeholder="City" disabled="disabled" /></div>

     <div class="col-25"><label>Mobile Number :</label></div>
    <div class="col-75"> <input type="text" runat="server" id="mno" name="mno" placeholder="Mobile No." disabled="disabled"/></div>

 
 
 </div>
    
  </div>
</body>
</html>
