
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPasswordConfirm.aspx.cs" Inherits="eRecruitment.Application.ForgotPasswordConfirm" %>

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
            width: 955px;
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
            width: 76%;
            margin-left: 40px;
        }
        .auto-style5 {
            font-family: Arial, Helvetica, sans-serif;
            width: 116px;
            height: 23px;
        }
        .auto-style8 {
            width: 267px;
        }
        .newStyle4 {
            font-family: Arial, Helvetica, sans-serif;
            color: #FF0000;
        }
        .auto-style12 {
            width: 116px;
            height: 30px;
        }
        .auto-style13 {
            width: 267px;
            height: 30px;
        }
        .auto-style14 {
            height: 30px;
        }
        .auto-style4 {
        }
        .auto-style15 {}
        .auto-style4 {
        }
        .newStyle3 {
        }
        .newStyle5 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style17 {
            font-family: Arial, Helvetica, sans-serif;
            width: 267px;
        }
        .auto-style36 {
            height: -15px;
            width: 462px;
            text-align: left;
        }
        .btn-success {}
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
                <td class="auto-style3"><span class="newStyle2">&nbsp;F</span><span class="auto-style7">ORGOT</span><span class="newStyle2"> P</span><span class="auto-style7">ASSWORD <hr class="auto-style36" />
                    </span></td>
            </tr>
        </table>
        <table class="auto-style4">
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style17">
                    Please answer your secret question:</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="newStyle5">Question:</td>
                <td class="auto-style17">
                    <asp:Label ID="SecretQuestionLabel" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr class="newStyle5">
                <td class="auto-style12">Answer:</td>
                <td class="auto-style13">
                    <asp:TextBox ID="SecretAnswerCon" runat="server" CssClass="auto-style15" Width="197px"></asp:TextBox>
                </td>
                <td class="auto-style14">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12"></td>
                <td class="auto-style13">
                </td>
                <td class="auto-style14">
                    
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:Button ID="Button1" runat="server" BackColor="#009900" BorderStyle="None" Font-Bold="False" ForeColor="White" Height="27px" Text="Back" CausesValidation="False" CssClass="btn btn-success" OnClick="Button1_Click1"/>
                </td>
                <td class="auto-style17">
                    <asp:Button ID="SubmitAnswer" runat="server" CssClass="btn btn-success" Height="27px" OnClick="SubmitAnswer_Click" Text="Submit" Width="70px" BackColor="#009900" BorderStyle="None" ForeColor="White" />
                </td>
                <td class="auto-style14">
                    
                    <asp:Label ID="ShowPassword" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    
        <br />
    
    </div>
    </form>
</body>
</html>
