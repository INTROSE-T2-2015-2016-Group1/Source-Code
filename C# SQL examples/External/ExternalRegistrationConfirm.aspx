<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExternalRegistrationConfirm.aspx.cs" Inherits="eRecruitment.Application.External.ExternalRegistrationConfirm" %>

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
        .auto-style9 {
            width: 149px;
        }
        .auto-style33 {
            width: 250px;
        }
        .auto-style25 {
            width: 149px;
            height: 31px;
        }
        .auto-style26 {
            width: 250px;
            height: 31px;
        }
        .auto-style12 {
            width: 149px;
            height: 22px;
        }
        .auto-style13 {
            width: 250px;
            height: 22px;
        }
        .auto-style18 {
            width: 149px;
            height: 33px;
        }
        .auto-style19 {
            width: 250px;
            height: 33px;
        }
        .auto-style21 {
            width: 149px;
            height: 34px;
        }
        .auto-style22 {
            width: 250px;
            height: 34px;
        }
        .newStyle3 {
            margin-left: 40px;
        }
        .newStyle3 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .newStyle3 {
        }
        .auto-style34 {
            font-family: Arial, Helvetica, sans-serif;
            color: #FF0000;
            margin-left: 40px;
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
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style41" style="background-color: #222222; color: #9D9D9D; font-family: Arial, Helvetica, sans-serif;">
            <tr>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;<img id="MaybankLogo" alt="" src="../../Images/graylogo.png" style="width:135px;height:28px;" /></td>
                <td class="auto-style42"><strong><span class="auto-style43">E-recruitment&nbsp;&nbsp;&nbsp;</span>&nbsp; </strong></td>
            </tr>
        </table>
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style3"><span class="newStyle2">&nbsp;E</span><span class="auto-style7">XTERNAL <span class="newStyle2">A</span>PPLICANT</span><span class="newStyle2"> R</span><span class="auto-style7">EGISTER </span><span class="newStyle2">C</span><span class="auto-style7">ONFIRMATION&nbsp;&nbsp;
                    <hr class="auto-style36" />
                    </span></td>
            </tr>
        </table>
        <span class="auto-style34"><em>This information <strong>CANNOT</strong> be changed after completion<br />
        <br />
        </em></span>
        <br />
        <table class="newStyle3">
            <tr>
                <td class="auto-style18">First Name:</td>
                <td class="auto-style19">
                    <asp:Label ID="FirstNameLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style18">Middle Name:</td>
                <td>
                    <asp:Label ID="MiddleNameLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style18">Last Name:</td>
                <td class="auto-style19">
                    <asp:Label ID="LastNameLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style25">Nickname:</td>
                <td class="auto-style26">
                    <asp:Label ID="NickNameLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style18">Email Address:</td>
                <td class="auto-style19">
                    <asp:Label ID="EmailLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style12"></td>
                <td class="auto-style13"></td>
            </tr>
            <tr>
                <td class="auto-style18">Birth Date:</td>
                <td class="auto-style19">
                    <asp:Label ID="BDayLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style18">Birth Place:</td>
                <td class="auto-style19">
                    <asp:Label ID="BPlaceLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style18">Sex:</td>
                <td class="auto-style19">
                    <asp:Label ID="GenderLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style18">Sercret Question: </td>
                <td class="auto-style19">
                    <asp:Label ID="QuestionLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style21">Answer:</td>
                <td class="auto-style22">
                    <asp:Label ID="AnswerLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="BackB" runat="server" BackColor="#009900" BorderStyle="None" CssClass="btn btn-success" Font-Bold="True" ForeColor="White" Height="27px" OnClick="BackB_Click" Text="Back" Width="65px" CausesValidation="False" />
                </td>
                <td class="auto-style33">
                    <asp:Button ID="ConfirmButton" runat="server" BackColor="#009900" BorderStyle="None" CssClass="btn btn-success" ForeColor="White" Height="27px" OnClick="ConfirmButton_Click" Text="Confirm" Width="140px"/>
                </td>
            </tr>
        </table>
    


    </div>
    </form>
</body>
</html>
