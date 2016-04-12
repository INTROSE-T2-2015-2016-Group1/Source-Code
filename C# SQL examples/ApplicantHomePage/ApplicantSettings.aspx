<%@ Page Title="" Language="C#" MasterPageFile="~/Application/ApplicantHomePage/Site1.Master" AutoEventWireup="true" CodeBehind="ApplicantSettings.aspx.cs" Inherits="eRecruitment.Application.ApplicantHomePage.Applicant_Settings" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .newStyle2 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style14 {
            width: 100%;
            margin-top: 29px;
            margin-bottom: 0px;
        }
        .auto-style15 {
            text-align: left;
            width: 142px;
        }
        .auto-style16 {
            width: 236px;
        }
        .auto-style17 {
            width: 597px;
        }
        .auto-style19 {
            text-align: left;
            width: 142px;
            height: 30px;
        }
        .auto-style20 {
            width: 236px;
            height: 30px;
        }
        .auto-style21 {
            width: 597px;
            height: 30px;
        }
        .auto-style22 {
            font-weight: bold;
        }
        .auto-style26 {
            width: 597px;
            height: 22px;
        }
        .auto-style27 {
            text-align: left;
            width: 142px;
            height: 29px;
        }
        .newStyle5 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
            font-size: 52px;
            font-weight: lighter;
            color: #808080;
            letter-spacing: -2px;
        }
        .auto-style28 {
            text-align: left;
            width: 142px;
            height: 23px;
        }
        .auto-style29 {
            width: 236px;
            height: 23px;
        }
        .auto-style30 {
            width: 597px;
            height: 23px;
        }
        .auto-style32 {
            width: 236px;
            height: 34px;
        }
        .auto-style33 {
            width: 597px;
            height: 34px;
        }
        .auto-style34 {
            text-align: left;
            width: 142px;
            font-size: x-small;
        }
        .auto-style36 {
            text-align: left;
            width: 142px;
            font-family: Arial, Helvetica, sans-serif;
            color: #000000;
            font-size: x-small;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    
    <span class="newStyle5">YOUR SETTINGS</span>
    <br />
    <span class="newStyle2">
        <table class="auto-style14">
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style16">
                &nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15">Upload Profile Picture:</td>
            <td class="auto-style16">
                <asp:FileUpload ID="uploadPicFU" runat="server" /></td>
            <td class="auto-style17">
                <asp:Label ID="invalidUploadLbl" runat="server" Text="Please use only supported image files: .jpeg, .jpg, .png" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style36"><em>*preferably a 2x2 ID picture. Maximum size of 4mb.</em></td>
            <td class="auto-style16">
                &nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style34" rowspan="2">&nbsp;</td>
            <td class="auto-style32">
    <span class="newStyle2">
                <asp:Button ID="uploadPicBtn" runat="server" BackColor="#009900" BorderStyle="None" ForeColor="White" Height="25px" Text="Upload Picture" Width="140px" CssClass="auto-style22" OnClick="uploadPicBtn_Click" CausesValidation="False" />
    </span> 
            </td>
            <td class="auto-style33"></td>
        </tr>
        <tr>
            <td class="auto-style32">
    <span class="newStyle2">
                <asp:Button ID="removePicBtn" runat="server" BackColor="#009900" BorderStyle="None" ForeColor="White" Height="25px" Text="Remove Picture" Width="140px" CssClass="auto-style22" CausesValidation="False" OnClick="removePicBtn_Click" />
    </span> 
            </td>
            <td class="auto-style33"></td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style16">
                &nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style16">
                &nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style28">E-mail Address:</td>
            <td class="auto-style29">
                <asp:Label ID="EmailLabel" runat="server"></asp:Label>
            </td>
            <td class="auto-style30"></td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style16">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
        </tr>
        <tr>
    <span class="newStyle2">
            <td class="auto-style15">Secret Question:</td>
            <td class="auto-style16">
                <asp:DropDownList ID="changeSecretQuestionList" runat="server" Height="20px" Width="90%">
                    <asp:ListItem>What is your first Pet&#39;s name?</asp:ListItem>
                    <asp:ListItem>What is your favorite food?</asp:ListItem>
                    <asp:ListItem>What was the name of your primary school?</asp:ListItem>
                    <asp:ListItem>What is your favorite movie?</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style17">&nbsp;</td>
    </span>
        </tr>
        <tr>
    <span class="newStyle2">
            <td class="auto-style15">Answer:</td>
            <td class="auto-style16">
                <asp:TextBox ID="changeSecAnswerB" runat="server" Height="20px" Width="90%"></asp:TextBox>
            </td>
            <td class="auto-style17">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="changeSecAnswerB" CssClass="auto-style20" ErrorMessage="Please enter an answer to your question" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
    </span>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
        </tr>
        <tr>
            <span class="newStyle2">
            <td class="auto-style19">Password</td>
            <td class="auto-style20">
                <asp:TextBox ID="OldPassBox" runat="server" Height="20px" Width="95%"></asp:TextBox>
            </td>
            <td class="auto-style21">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="OldPassBox" CssClass="auto-style26" ErrorMessage="Please enter your current password" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
    </span>
        </tr>
        <tr>
            <span class="newStyle2">
            <td class="auto-style15">New Password:</td>
            <td class="auto-style16">
                <asp:TextBox ID="NewPassBox" runat="server" Height="20px" Width="95%"></asp:TextBox>
            </td>
            <td class="auto-style17">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="NewPassBox" CssClass="auto-style26" ErrorMessage="Please enter your new password" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
    </span>
        </tr>
        <tr>
            <span class="newStyle2">
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style16">
    <span class="newStyle2">
                    <asp:Label ID="PassValidLbl" runat="server" Font-Italic="True" Font-Size="XX-Small" Text="Password should ba a combination of 6 - 20 uppercase, lowercase, and numeric characters." style="font-size: xx-small"></asp:Label>
    </span>
            </td>
            <td class="auto-style17">
    <span class="newStyle2">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="NewPassBox" CssClass="auto-style27" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{6,20}$">Please enter a valid password</asp:RegularExpressionValidator>
    </span></td>
    </span>
        </tr>
        <tr>
            <span class="newStyle2">
            <td class="auto-style15">Confirm Password: </td>
            <td class="auto-style16">
                <asp:TextBox ID="NewPassConfirmBox" runat="server" Height="20px" Width="95%"></asp:TextBox>
            </td>
            <td class="auto-style17">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="OldPassBox" CssClass="auto-style26" ErrorMessage="Please re-enter your new password" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
    </span>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style16">
                <asp:Button ID="ChangePassB" runat="server" BackColor="#009900" BorderStyle="None" ForeColor="White" Height="25px" OnClick="ChangePassB_Click" Text="Change Password" Width="140px" CssClass="auto-style22" />
&nbsp;&nbsp; </td>
            <td class="auto-style17">
                <asp:Label ID="InformationLabel" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style16">
                &nbsp;</td>
            <td class="auto-style17">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style16"><span class="newStyle2">
                <asp:Button ID="ChangeSecQueB" runat="server" BackColor="#009900" BorderStyle="None" CssClass="auto-style22" ForeColor="White" Height="25px" OnClick="ChangeSecQueB_Click" Text="Change Secret Question" Width="190px" />
    </span> 
            </td>
            <td class="auto-style17">&nbsp;</td>
        </tr>
    </table>
    </span> 
</asp:Content>
