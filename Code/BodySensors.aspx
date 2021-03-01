<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BodySensors.aspx.cs" Inherits="Patient_Health_Monitoring_System.BodySensors" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/styleforBodySensors.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
        Patients Monitoring System using Fog Centric IoT Technology
            <div class="header-right">
                <a class="active" href="WelcomePage.aspx">Welcome Page</a>
            </div>
        </div>
     <div class="sidenav">
      <a href="ViewMyDetails.aspx">View My Details</a><br />
      <a href="CheckOwnHealthData.aspx">Check the Health Data</a><br />
      <a href="BodySensors.aspx">Body Sensors</a><br />
      <a href="HomePage.aspx">Logout</a>
    </div>
    <div class="main">
        <asp:Panel ID="Panel1" runat="server">
         <img src="images/heartbeatimg.gif"  style="height:280px;width:80%;" alt="Heart beat Graph" />
         <br /><br />

        <label for="Heartbeat"> Heart Beats :</label>
        <input type="text" runat="server" id="txtheartbeat" autocomplete="off" />

        <label for="temp"> Temperature :</label>
        <input type="text" runat="server" id="txttemp"  autocomplete="off" /><br />
              
        <br />
       
        <asp:Timer ID="Timer1" runat="server" Interval="3000" ontick="Timer1_Tick">
        </asp:Timer>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
