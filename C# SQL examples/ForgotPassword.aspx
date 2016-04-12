<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="eRecruitment.Application.ForgotPassword" %>

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

        .auto-style1 {
            width: 98%;
            margin-left: 20px;
        }
        .auto-style3 {
            font-family: Arial, Helvetica, sans-serif;
            font-weight: bold;
        }
        .newStyle2 {
            color: #808080;
            font-family: Arial, Helvetica, sans-serif;
            font-size: 1.5em;
        }
        .auto-style7 {
            color: #808080;
            font-family: Arial, Helvetica, sans-serif;
            font-size: 1em;
        }
        .auto-style4 {
            width: 75%;
            margin-left: 40px;
        }
        .auto-style5 {
            font-family: Arial, Helvetica, sans-serif;
            width: 98px;
        }
        .auto-style8 {
            width: 235px;
        }
        .auto-style9 {
            font-size: 80%;
        }
        .newStyle4 {
            font-family: Arial, Helvetica, sans-serif;
            color: #FF0000;
        }
        .auto-style6 {
            width: 98px;
        }
        .newStyle3 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .newStyle5 {
            font-family: Arial, Helvetica, sans-serif;
            color: #FF0000;
        }
        .auto-style12 {
            width: 98px;
            height: 30px;
        }
        .auto-style13 {
            width: 235px;
            height: 30px;
        }
        .auto-style14 {
            height: 30px;
        }
        .auto-style36 {
            height: -15px;
            width: 462px;
            text-align: left;
        }
        .auto-style41 {
            width: 100%;
            height: 54px;
        }
        .auto-style42 {
            text-align: right;
        }
        .auto-style43 {
            font-size: x-large;
        }
        .auto-style44 {
            width: 98px;
            height: 27px;
        }
        .auto-style45 {
            width: 235px;
            height: 27px;
        }
        .auto-style46 {
            height: 27px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style41" style="background-color: #222222; color: #9D9D9D; font-family: Arial, Helvetica, sans-serif;">
            <tr>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;<img id="MaybankLogo" alt="" src="../Images/graylogo.png" style="width:135px;height:28px;" /></td>
                <td class="auto-style42"><strong><span class="auto-style43">E-recruitment&nbsp;&nbsp;&nbsp;</span>&nbsp; </strong></td>
            </tr>
        </table>
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style3"><span class="newStyle2">&nbsp;F</span><span class="auto-style7">ORGOT</span><span class="newStyle2"> P</span><span class="auto-style7">ASSWORD<hr class="auto-style36" />
                    </span></td>
            </tr>
        </table>
        <table class="auto-style4">
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">User E-mail :</td>
                <td class="auto-style8">
                    <asp:TextBox ID="EmailBoxF" runat="server" Font-Italic="True" Height="20px"  Width="90%"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RFVForgot" runat="server" ControlToValidate="EmailBoxF" CssClass="newStyle4 auto-style9" ErrorMessage="Please enter your E-mail" Font-Italic="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style44">
                    <asp:Button ID="Button1" runat="server" BackColor="#009900" BorderStyle="None" CssClass="btn btn-success" Font-Bold="False" ForeColor="White" Height="27px" OnClick="Button1_Click" Text="Back" CausesValidation="False" />
                </td>
                <td class="auto-style45">
                    <asp:Button ID="SendPass" runat="server" Height="27px" OnClick="SendPass_Click" Text="Submit" Width="69px" BackColor="#009900" BorderStyle="None" ForeColor="White" CssClass="btn btn-success" />
                </td>
                <td class="auto-style46">
                    <asp:Label ID="PassStat" runat="server"></asp:Label>
                    
                </td>
            </tr>
            <tr>
                <td class="auto-style12"></td>
                <td class="auto-style13">
                </td>
                <td class="auto-style14">
                    
                </td>
            </tr>
        </table>
    
        <br />
        <br />
    
        <br />
    
    </div>
    </form>
</body>
</html>
