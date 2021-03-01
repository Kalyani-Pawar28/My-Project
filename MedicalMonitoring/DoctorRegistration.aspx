<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="DoctorRegistration.aspx.cs" Inherits="Patient_Health_Monitoring_System.DoctorRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/styleforRegistration.css" rel="stylesheet" />
</head>
<body>
   <form>
<h1>Register</h1>
    <p>Please fill in this form to create an account.</p>
    <hr>
    <label for="user_id"><b>Doctor ID</b></label>
    <input type="text" runat="server" id="user_id" required="required" />

    <label for="password"><b>Password</b></label>
    <input type="password" placeholder="Enter Password"  runat="server" id="password" required="required" />

    <label for="fname"><b>First Name</b></label>
    <input type="text" placeholder="Enter First Name" runat="server" id="fname" required="required" />

    <label for="lname"><b>Last Name</b></label>
    <input type="text" placeholder="Enter Last Name" runat="server" id="lname" required="required" />

    <label for="email"><b>Email Address</b></label>
    <input type="text" placeholder="Enter Email Address"  runat="server" id="email" required="required" />

    <label for="dob"><b>Date of Birth</b></label>
    <input type="text" runat="server" placeholder="DD/MM/YYYY" id="dob" required="required" />
      
    <label for="gender"><b>Gender</b></label>
      <input type="radio" name="gender"  runat="server" id="male"  value ="male" /> Male<br>
  <input type="radio" name="gender" runat="server" id="female" value="female"/> Female<br>
   <br />
     <br />
    
    <label for="city"><b>Address</b></label>
    <input type="text" placeholder="Enter City" runat="server" id="city" required="required" />

    <label for="email"><b>Mobile Number</b></label>
    <input type="text" placeholder="Enter Mobile Number" runat="server" id="mno" required="required" />

    <label for="Specialist"><b>Specialist</b></label>
    <input type="text" placeholder="Enter Specialization" runat="server" id="specl" required="required" />

    <button type="submit" class="registerbtn" runat="server" id="btnRegister">Register</button>
  
  <div class="container signin">
    <p>Already have an account? <a href="LoginPage.aspx">Sign in</a>.</p>
  </div>
  
</form>
</body>
</html>
