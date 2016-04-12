    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DesignateApp.aspx.cs" Inherits="eRecruitment.Application.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

     <meta charset="utf-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1" />
  <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css" />
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
  <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>

    <style type="text/css">
        .newStyle1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        h2 {
        }
        .newStyle2 {
            color: #808080;
            font-family: Arial, Helvetica, sans-serif;
            font-size: 1.5em;
        }
        .newStyle2 {
        }
        .FNT1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .newStyle3 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .autoStyle5 {
        }
        .newStyle4 {
            font-family: Arial, Helvetica, sans-serif;
            color: #FF0000;
        }
        .newStyle5 {
            font-family: Arial, Helvetica, sans-serif;
            color: #FF0000;
        }
        .newStyle6 {
            font-size: xx-small;
            font-family: Arial, Helvetica, sans-serif;
        }
        .newStyle7 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .newStyle8 {
            font-family: Arial, Helvetica, sans-serif;
        }
       
        .newStyle9 {
            font-family: Arial, Helvetica, sans-serif;
            color: #FFFFFF;
            font-size: xx-large;
        }
        .newStyle10 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .newStyle11 {
        }
        .newStyle12 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .newStyle13 {
            font-family: Arial, Helvetica, sans-serif;
            color: #FFFFFF;
        }

        body {
            background-image: url(../../Images/building.png);
            background-repeat: no-repeat;
            background-size: cover cover;
        }
        
        .box.login
{
	height:255px;
    width:393px;
	position:absolute;
	left:406px;
	top:310px;
	margin:-130px 0 0 -166px;
}
.box
{
    background:#fefefe;
    border: 1px solid #C3D4DB;
	border-top:1px;
    -webkit-border-radius:5px;
    -moz-border-radius:5px;
    border-radius:5px;
    -moz-box-shadow:rgba(0,0,0,0.15) 0 0 1px;
    -webkit-box-shadow:rgba(0,0,0,0.15) 0 0 1px;
    box-shadow:rgba(0,0,0,0.15) 0 0 1px;
    color:#444;
    font:normal 12px/14px Arial, Helvetica, Sans-serif;
    margin:0 auto 30px;
	overflow:hidden;
}
.boxBody
{
    background:#fefefe;
    border-top:1px solid #dde0e8;
    border-bottom:1px solid #dde0e8;
    padding:10px 20px;
}

.box label
{
    display:block;
    font:14px/22px Arial, Helvetica, Sans-serif;
    margin:10px 0 0 6px;
}
        
        .auto-style152 {
            width: 90px;
        }
        
        .newStyle14 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 20px;
        }
        .auto-style153 {
            width: 100%;
            height: 54px;
        }
        .auto-style154 {
            font-size: x-large;
            text-align: right;
        }
        
    </style>
</head>
<body style="height: 607px">
    <form id="form1">
    <div>
    
        <table class="auto-style153" style="background-color: #222222; color: #9D9D9D; font-family: Arial, Helvetica, sans-serif;">
            <tr>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;<img id="MaybankLogo" alt="" src="../Images/graylogo.png" style="width:135px;height:28px;" /></td>
                <td class="auto-style154"><strong>E-recruitment&nbsp;&nbsp;&nbsp;&nbsp; </strong></td>
            </tr>
        </table>
        <br />
    
        <asp:SqlDataSource ID="SqlDataSourceUsers" runat="server" ConnectionString="<%$ ConnectionStrings:erecruitmentConnectionString %>" SelectCommand="SELECT * FROM [T_USER_ACCOUNTS]"  ></asp:SqlDataSource>
    
    </div>
    </form>
    <form id="LoginBox" runat="server" class="box login" draggable="false" defaultbutton="LogInBtn" style="left: 48%;">
        <div class="boxBody">
            <div class="login_area">
                <div>
                    <label class="newStyle14">
                        <strong>User Log-In</strong></label>
                    <label>
                    Username</label>
                    <asp:TextBox ID="EmailBox" runat="server" Font-Italic="True" Height="20px"  Width="92%"></asp:TextBox>
                </div>
                <div>
                    <label>
                    Password</label>
                    <asp:TextBox ID="PasswordBox" runat="server" Font-Italic="True" Height="20px" TextMode="Password" Width="92%"></asp:TextBox>
                    <br />
                    <table class="nav-justified">
                        <tr>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                    <br />
                    <table class="nav-justified">
                        <tr>
                            <td class="auto-style152"><asp:Button ID="LogInBtn" runat="server" CssClass="btn btn-success" OnClick="LogInBtn_Click" Text="Log-In" Width="69px" BackColor="#009900" BorderStyle="None" ForeColor="White" Height="30px" />
                    
                            </td>
                            <td> <asp:Button ID="ForgotButton" runat="server" Height="30px" OnClick="ForgotButton_Click" Text="Forgot Password" Width="140px" CssClass="btn btn-success" BackColor="#009900" BorderStyle="None" ForeColor="White" />
                            </td>
                            <td> <asp:Button ID="RegisterSB" runat="server" CssClass="btn btn-success" Height="30px" OnClick="RegisterSB_Click" Text="Register" Width="88px" BackColor="#009900" BorderStyle="None" ForeColor="White" />
                            </td>
                        </tr>
                    </table>
                </div>
                <div id="dvBtn" class="go_botton">
                    
                    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </p>
                    <p>
&nbsp;<strong><asp:Label ID="LogInStatus" runat="server" ForeColor="Red" Font-Names="Arial"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:Label ID="LogInCat" runat="server" ForeColor="Red" Font-Names="Arial"></asp:Label>
                    
                    </strong>
                    </p>
                    
                </div>
            </div>
        </div>
    </form>
    
</body>
</html>
