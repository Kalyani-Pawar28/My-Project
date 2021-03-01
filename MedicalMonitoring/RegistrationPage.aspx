<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="RegistrationPage.aspx.cs" Inherits="Patient_Health_Monitoring_System.RegistrationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/styleforRegistration.css" rel="stylesheet" />
</head>
<body>
    <div class="bg-img">
    <form runat="server" id="registration" class="container">
        <div >
            <h1>Register Here...!</h1>
            <p>Please fill in this form to create an account.</p>

            <label for="user_id"><b>Patient ID</b></label>
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
            <input type="text" runat="server" placeholder="YYYY/MM/DD" id="dob" required="required" />
      
            <label for="gender"><b>Gender</b></label><br />
            <input type="radio" name="gender"  runat="server" id="male"  value ="male" /> Male
            <input type="radio" name="gender" runat="server" id="female" value="female"/> Female<br/><br />

            <label for="city"><b>Address</b></label>
            <input type="text" placeholder="Enter City" runat="server" id="city" required="required" />

            <label for="email"><b>Mobile Number</b></label>
            <input type="text" placeholder="Enter Mobile Number" runat="server" id="mno" required="required" />
            <hr/>

            <button type="submit" class="registerbtn" runat="server" id="btnRegister">Register</button>

             <div class="signin">
                <p>Already have an account? <a href="LoginPage.aspx">Sign in</a>.</p>
             </div>

        </div> 
    </form>

</div>
</body>
</html>
