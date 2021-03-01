<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="LoginPage.aspx.cs" Inherits="Patient_Health_Monitoring_System.LoginPage" %>

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
    <link href="css/styleforLogin.css" rel="stylesheet" />
</head>
<body class="bg-img" >
    <form id="form1" runat="server" >
    <div style="text-align:center">
    <h2> Patient's Login </h2>
    <div  style="text-align:center">
     <img src="/images/img_avatar2.png" alt="Avatar" class="avatar" />
    </div>

  <div class="container" style="width: 623px; height: 225px;">

    <label for="uname"><b>Patient ID</b></label>
    <input type="text" runat="server" id="txt_username" autocomplete="off" placeholder="Enter Username" name="uname" required="required" />

    <label for="psw"><b>Password</b></label>
    <input type="password" runat="server" id="txt_pass" placeholder="Enter Password" name="psw" required="required" />
         
    <button type="submit" class="loginbtn" runat="server" id="btnLogin">Login</button>

    <button type="button" class="cancelbtn" runat="server" id="btnCancel">Cancel</button>
    
  </div>

  <div class="container" style="text-align:center">
    <b><span class="psw">Forgot <a href="#">password?</a></span>
    <span class="psw"><a href="RegistrationPage.aspx">New Registration</a></span></b>
  </div>
    </div>
    </form>
</body>
</html>
