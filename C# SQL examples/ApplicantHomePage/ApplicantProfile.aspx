<%@ Page Title="" Language="C#" MasterPageFile="~/Application/ApplicantHomePage/Site1.Master" AutoEventWireup="true" CodeBehind="ApplicantProfile.aspx.cs" Inherits="eRecruitment.Application.ApplicantHomePage.ApplicantProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style41 {
            height: 30px;
            background-color: #FFCC00;
        }
        .auto-style42 {
            width: 20px;
        }
        .auto-style44 {
            width: 300px;
        }
        .newStyle5 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .newStyle6 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
        }
        .auto-style45 {
            font-size: large;
        }
        .auto-style49 {
        font-size: medium;
    }
    .auto-style50 {
        width: 20px;
        font-size: medium;
    }
        .newStyle7 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
            font-size: 48px;
            font-weight: lighter;
            color: #808080;
            white-space: normal;
            letter-spacing: -2px;
        }
        .auto-style51 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
            font-size: 52px;
            font-weight: lighter;
            color: #808080;
            white-space: normal;
            letter-spacing: -2px;
        }
        .auto-style60 {
            height: 30px;
            background-color: #FFFFFF;
            }
        .auto-style61 {
            background-color: #FFFFFF;
        }
        .auto-style62 {
            width: 300px;
            font-size: medium;
        }
        .auto-style63 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            width: 1152px;
        }
        .auto-style70 {
            width: 20px;
            height: 18px;
        }
        .auto-style71 {
            width: 300px;
            height: 18px;
        }
        .auto-style72 {
            background-color: #FFFFFF;
            height: 18px;
        }
        .auto-style73 {
            width: 300px;
            height: 18px;
            font-weight: bold;
        }
        .auto-style74 {
            background-color: #FFFFFF;
            font-weight: bold;
        }
        .auto-style75 {
            width: 300px;
            font-weight: bold;
        }
        .auto-style76 {
            width: 20px;
            font-weight: bold;
        }
        .auto-style108 {
            width: 253px;
        }
        .auto-style109 {
            width: 253px;
            height: 18px;
        }
        .auto-style110 {
            width: 253px;
            height: 18px;
            font-weight: bold;
        }
        .auto-style147 {
            color: #FFCC00;
        }
        .auto-style148 {
            color: #000000;
            height: 30px;
            text-align: center;
            background-color: #FFCC00;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style149 {
            font-size: small;
        }
        .auto-style150 {
            width: 1137px;
            height: 176px;
        }
        .auto-style152 {
            width: 1140px;
        }
        .auto-style153 {
            font-size: medium;
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style154 {
            height: 20px;
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
        }
        .auto-style156 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            text-align: left;
        }
        .auto-style157 {
            width: 1142px;
        }
        .auto-style158 {
            height: 23px;
            width: 24px;
        }
        .auto-style159 {
            width: 99%;
        }
        .auto-style160 {
            font-family: Arial, Helvetica, sans-serif;
            height: 30px;
            background-color: #FFCC00;
            font-size: medium;
            text-align: center;
        }
        .auto-style162 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            width: 20px;
        }
        .auto-style163 {
            font-family: Arial, Helvetica, sans-serif;
            width: 20px;
        }
        .auto-style167 {
            height: 23px;
            width: 20px;
        }
        .auto-style169 {
            width: 260px;
        }
        .auto-style170 {
            width: 294px;
        }
        .auto-style171 {
            width: 24px;
        }
        .auto-style172 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            width: 532px;
        }
        .auto-style173 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            width: 260px;
        }
        .auto-style174 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            width: 294px;
        }
        .auto-style175 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            width: 24px;
        }
        .auto-style176 {
            height: 20px;
            width: 532px;
        }
        .auto-style177 {
            height: 20px;
            width: 260px;
        }
        .auto-style178 {
            height: 20px;
            width: 294px;
        }
        .auto-style179 {
            height: 20px;
            width: 24px;
        }
        .auto-style180 {
            height: 23px;
            width: 532px;
        }
        .auto-style181 {
            height: 23px;
            width: 260px;
        }
        .auto-style182 {
            height: 23px;
            width: 294px;
        }
        .auto-style184 {
            width: 532px;
        }
        .auto-style185 {
            font-family: Arial, Helvetica, sans-serif;
            width: 20px;
            font-size: medium;
        }
        .auto-style186 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            text-align: center;
        }
        .auto-style187 {
            height: 20px;
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
            text-align: center;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <span class="auto-style51">APPLICANT PROFILE</span><br />
    <br />
    <table class="auto-style63">
        <tr>
            <td class="auto-style41" colspan="6">&nbsp; <span class="auto-style45">&nbsp;</span><strong><span class="auto-style45">Personal Details&nbsp;</span></strong></td>
            <td class="auto-style60"></td>
        </tr>
        <tr>
            <td class="auto-style42">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style108">&nbsp;</td>
            <td class="auto-style61">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style70"></td>
            <td class="auto-style73">Last Name:</td>
            <td class="auto-style73">First Name:</td>
            <td class="auto-style73">Middle Name:</td>
            <td class="auto-style73">Nickname:</td>
            <td class="auto-style109"></td>
            <td class="auto-style72"></td>
        </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td class="auto-style44">
                <asp:Label ID="lastNameLbl" runat="server" CssClass="auto-style49"></asp:Label>
            </td>
            <td class="auto-style62">
                <asp:Label ID="firstNameLbl" runat="server"></asp:Label>
            </td>
            <td class="auto-style44">
                <asp:Label ID="middleNameLbl" runat="server" style="font-size: medium"></asp:Label>
            </td>
            <td class="auto-style44">
                <asp:Label ID="nicknameLbl" runat="server" style="font-size: medium"></asp:Label>
            </td>
            <td class="auto-style108"></span></td>
            <td class="auto-style61">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style42">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style108">&nbsp;</td>
            <td class="auto-style61">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style70"></td>
            <td class="auto-style73">Sex:</td>
            <td class="auto-style73">Civil Status:</td>
            <td class="auto-style73">Age:</td>
            <td class="auto-style73">Birth Date:</td>
            <td class="auto-style110">Birth Place:</td>
            <td class="auto-style72"></td>
        </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td class="auto-style44">
                <asp:Label ID="sexLbl" runat="server" CssClass="auto-style49"></asp:Label>
                </span>
            </td>
            <td class="auto-style44">
                <asp:DropDownList ID="StatusList" runat="server" CssClass="auto-style49">
                    <asp:ListItem Value="S">Single</asp:ListItem>
                    <asp:ListItem Value="D">Divorced</asp:ListItem>
                    <asp:ListItem Value="W">Widowed</asp:ListItem>
                    <asp:ListItem Value="N">N/A</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style62">
                <asp:Label ID="ageLbl" runat="server"></asp:Label>
            </td>
            <td class="auto-style44">
                <asp:Label ID="birthDateLbl" runat="server" CssClass="auto-style49"></asp:Label>
            </td>
            <td class="auto-style108">
                <asp:Label ID="birthPlaceLbl" runat="server" CssClass="auto-style49"></asp:Label>
                </span>
            </td>
            <td class="auto-style61">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style42">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style108">&nbsp;</td>
            <td class="auto-style61">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style76">&nbsp;</td>
            <td class="auto-style75">Nationality:</td>
            <td colspan="2"><b>Present Address:</b></td>
            <td colspan="2"><b>Provincial Address:</b></td>
            <td class="auto-style74">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td class="auto-style44">
                <asp:TextBox ID="nationalityTB" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td colspan="2">
                <asp:TextBox ID="presentAddressTB" runat="server" Width="420px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td colspan="2">
                <asp:TextBox ID="provAddressTB" runat="server" Width="420px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="auto-style61">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style42">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style108">&nbsp;</td>
            <td class="auto-style61">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style70"></td>
            <td class="auto-style73">Cellphone Number:</td>
            <td class="auto-style73">Telephone Number:</td>
            <td class="auto-style73">Email Address:</td>
            <td class="auto-style73">Special Skills:</td>
            <td class="auto-style110"><span lang="EN-US">Languages/Dialects Spoken</span>:</td>
            <td class="auto-style72"></td>
        </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td class="auto-style44">
                <asp:TextBox ID="cellNumTB" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="auto-style44">
                <asp:TextBox ID="tellNumTB" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="auto-style44">
                <asp:Label ID="emailAddressLbl" runat="server" CssClass="auto-style49"></asp:Label>
            </td>
            <td class="auto-style44">
                <asp:TextBox ID="hobbiesTB" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="auto-style108">
                <asp:TextBox ID="languagesTB" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="auto-style61">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style42">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style108">&nbsp;</td>
            <td class="auto-style61">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style70"></td>
            <td class="auto-style73">PhilHealth Number:</td>
            <td class="auto-style73">SSS Number:</td>
            <td class="auto-style73">TIN:</td>
            <td class="auto-style71"></td>
            <td class="auto-style109"></td>
            <td class="auto-style72"></td>
        </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td class="auto-style44">
                <asp:TextBox ID="philHealthNumTB" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="auto-style44">
                <asp:TextBox ID="sssNumTB" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="auto-style44">
                <asp:TextBox ID="tinNumTB" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="auto-style44">
                &nbsp;</td>
            <td class="auto-style108"></span></td>
            <td class="auto-style61">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style42">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style108">&nbsp;</td>
            <td class="auto-style61">&nbsp;</td>
        </tr>
    </table>
    <br />
    <table class="auto-style150">
        <tr>
            <td class="auto-style160" colspan="9"><strong>&nbsp;Family Background</strong></td>
        </tr>
        <tr>
            <td class="auto-style42">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style6"><strong><span class="newStyle6">Last Name</span></strong><span class="auto-style149"></span>:</td>
            <td class="auto-style154"><strong>First Name:</strong></td>
            <td class="auto-style154"><strong>MI:</strong></td>
            <td class="auto-style154"><strong>Birthdate:</strong></td>
            <td class="auto-style154"><strong>Employer:</strong></td>
            <td class="auto-style154"><strong>Occupation:</strong></td>
            <td class="auto-style154"><strong>Relationship:</strong></td>
            <td class="auto-style154"></span></td>
        </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td><asp:TextBox ID="FB1LName" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB1FName" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB1MI" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB1Bday" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB1Emp" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB1Occ" runat="server" Width="140px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB1Relation" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="auto-style49">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td><asp:TextBox ID="FB2LName" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB2FName" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB2MI" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB2Bday" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB2Emp" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB2Occ" runat="server" Width="140px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB2Relation" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="auto-style49">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td><asp:TextBox ID="FB3LName" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB3FName" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB3MI" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB3Bday" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB3Emp" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB3Occ" runat="server" Width="140px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB3Relation" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="auto-style49">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td><asp:TextBox ID="FB4LName" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB4FName" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB4MI" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB4Bday" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB4Emp" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB4Occ" runat="server" Width="140px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB4Relation" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="auto-style49">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td><asp:TextBox ID="FB5LName" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB5FName" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB5MI" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB5Bday" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB5Emp" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB5Occ" runat="server" Width="140px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="FB5Relation" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="auto-style49">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style42">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
    <table class="auto-style152">
        <tr>
            <td class="auto-style160" colspan="8"><strong>Educational Background</strong></td>
        </tr>
        <tr>
            <td class="auto-style42">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style162" rowspan="2">&nbsp;</td>
            <td class="auto-style154" rowspan="2"><strong>Level:</strong></td>
            <td rowspan="2"><strong><span class="auto-style154">Name of School</span></strong><span class="auto-style149"></span>:</td>
            <td class="auto-style187" colspan="2"><strong>Inclusive Academic Years:</strong></td>
            <td class="auto-style6" rowspan="2"><span class="newStyle6"></span></span><strong><span class="auto-style154">Degrees/Awards/Honors:</span></strong></td>
            <td class="newStyle6" rowspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style154"><strong>From:</strong></td>
            <td class="auto-style154"><strong>To:</strong></td>
        </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td class="auto-style49">Post-Degree</td>
            <td>
                <asp:TextBox ID="EB1School" runat="server" Width="250px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="EB1YearStart" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="EB1YearGrad" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="EB1Awards" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="auto-style49">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td class="auto-style49">College</td>
            <td>
                <asp:TextBox ID="EB2School" runat="server" Width="250px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="EB2YearStart" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="EB2YearGrad" runat="server"  Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="EB2Awards" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="auto-style49">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td class="auto-style49">High school</td>
            <td>
                <asp:TextBox ID="EB3School" runat="server" Width="250px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="EB3YearStart" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="EB3YearGrad" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="EB3Awards" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="auto-style49">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td class="auto-style49">Elementary</td>
            <td>
                <asp:TextBox ID="EB4School" runat="server" Width="250px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="EB4YearStart" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="EB4YearGrad" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="EB4Awards" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="auto-style49">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style42">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <table class="auto-style159">
        <tr>
            <td class="auto-style162"><strong></strong></td>
            <td class="newStyle6"><strong>Government Exams Taken:</strong></td>
            <td class="newStyle6"><strong>Date Taken</strong></td>
            <td class="newStyle6"><strong>Rating:</strong></td>
            <td class="newStyle6"><strong>Professional Affiliation:</strong></td>
            <td class="newStyle6"><strong>Position:</strong></td>
            <td class="newStyle6"><strong></strong></td>
        </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td>
                <asp:TextBox ID="GE1Exam" runat="server" Width="250px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="GE1Date" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="GE1Rating" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="GE1ProfAff" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="GE1Pos" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="auto-style49">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td>
                <asp:TextBox ID="GE2Exam" runat="server" Width="250px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="GE2Date" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="GE2Rating" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="GE2ProfAff" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="GE2Pos" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="auto-style49">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style42">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
    <table class="auto-style152">
        <tr class="auto-style147">
            <td class="auto-style148" colspan="7"><strong><span class="auto-style153">&nbsp;Work Experience</span></strong><span class="auto-style153">&nbsp;</span></td>
        </tr>
        <tr>
            <td class="auto-style163">&nbsp;</td>
            <td class="newStyle5">&nbsp;</td>
            <td class="newStyle5">&nbsp;</td>
            <td class="newStyle5">&nbsp;</td>
            <td class="newStyle5">&nbsp;</td>
            <td class="newStyle5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style162" rowspan="2">&nbsp;</td>
            <td class="newStyle6" rowspan="2"><strong>Employer:</strong></td>
            <td rowspan="2"><strong><span class="newStyle6">Position Held:</span></strong><span class="auto-style149"></td>
            <td colspan="2" class="auto-style186"><strong>Inclusive Dates:</strong></td>
            <td rowspan="2"><span class="newStyle6"></span></span><strong><span class="newStyle6">Reason for Leaving:</span></strong></td>
            <td class="newStyle6" rowspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style156"><strong>From</strong></td>
            <td class="auto-style156"><strong>To</strong></td>
        </tr>
        <tr>
            <td class="auto-style185">&nbsp;</td>
            <td>
                <asp:TextBox ID="WE1EmpName" runat="server" Width="250px" CssClass="auto-style153"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="WE1PosRank" runat="server" CssClass="auto-style153"></asp:TextBox>
            </td>
            <td class="newStyle5">
                <asp:TextBox ID="WE1FromDate" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="newStyle5">
                <asp:TextBox ID="WE1ToDate" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="WE1Reason" runat="server" CssClass="auto-style153"></asp:TextBox>
            </td>
            <td class="auto-style49">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style185">&nbsp;</td>
            <td>
                <asp:TextBox ID="WE2EmpName" runat="server" Width="250px" CssClass="auto-style153"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="WE2PosRank" runat="server" CssClass="auto-style153"></asp:TextBox>
            </td>
            <td class="newStyle5">
                <asp:TextBox ID="WE2FromDate" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="newStyle5">
                <asp:TextBox ID="WE2ToDate" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="WE2Reason" runat="server" CssClass="auto-style153"></asp:TextBox>
            </td>
            <td class="auto-style49">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style185">&nbsp;</td>
            <td>
                <asp:TextBox ID="WE3EmpName" runat="server" Width="250px" CssClass="auto-style153"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="WE3PosRank" runat="server" CssClass="auto-style153"></asp:TextBox>
            </td>
            <td class="newStyle5">
                <asp:TextBox ID="WE3FromDate" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="newStyle5">
                <asp:TextBox ID="WE3ToDate" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="WE3Reason" runat="server" CssClass="auto-style153"></asp:TextBox>
            </td>
            <td class="auto-style49">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style185">&nbsp;</td>
            <td>
                <asp:TextBox ID="WE4EmpName" runat="server" Width="250px" CssClass="auto-style153"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="WE4PosRank" runat="server" CssClass="auto-style153"></asp:TextBox>
            </td>
            <td class="newStyle5">
                <asp:TextBox ID="WE4FromDate" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="newStyle5">
                <asp:TextBox ID="WE4ToDate" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="WE4Reason" runat="server" CssClass="auto-style153"></asp:TextBox>
            </td>
            <td class="auto-style49">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style185">&nbsp;</td>
            <td>
                <asp:TextBox ID="WE5EmpName" runat="server" Width="250px" CssClass="auto-style153"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="WE5PosRank" runat="server" CssClass="auto-style153"></asp:TextBox>
            </td>
            <td class="newStyle5">
                <asp:TextBox ID="WE5FromDate" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="newStyle5">
                <asp:TextBox ID="WE5ToDate" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="WE5Reason" runat="server" CssClass="auto-style153"></asp:TextBox>
            </td>
            <td class="auto-style49">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style163">&nbsp;</td>
            <td class="newStyle5">&nbsp;</td>
            <td class="newStyle5">&nbsp;</td>
            <td class="newStyle5">&nbsp;</td>
            <td class="newStyle5">&nbsp;</td>
            <td class="newStyle5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
    <table class="auto-style157">
        <tr>
            <td class="auto-style160" colspan="5"><strong>Relative/s by Consanguinity/Affinity Who Are Employees of Maybank</strong></td>
        </tr>
        <tr>
            <td class="auto-style42">&nbsp;</td>
            <td class="auto-style184">&nbsp;</td>
            <td class="auto-style169">&nbsp;</td>
            <td class="auto-style170">&nbsp;</td>
            <td class="auto-style171">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style162"><strong></strong></td>
            <td class="auto-style172"><strong>Name:</strong></td>
            <td class="auto-style173"><strong>Position:</strong></td>
            <td class="auto-style174"><strong>Nature of Relationship:</strong></td>
            <td class="auto-style175"><strong></strong></td>
        </tr>
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style176">
                <asp:TextBox ID="EM1Name" runat="server" Width="250px" CssClass="auto-style153"></asp:TextBox>
            </td>
            <td class="auto-style177">
                <asp:TextBox ID="EM1Pos" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="auto-style178">
                <asp:TextBox ID="EM1Relation" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="auto-style179"></td>
        </tr>
        <tr>
            <td class="auto-style167"></td>
            <td class="auto-style180">
                <asp:TextBox ID="EM2Name" runat="server" Width="250px" CssClass="auto-style153"></asp:TextBox>
            </td>
            <td class="auto-style181">
                <asp:TextBox ID="EM2Pos" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="auto-style182">
                <asp:TextBox ID="EM2Relation" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td class="auto-style158"></td>
        </tr>
        <tr>
            <td class="auto-style42">&nbsp;</td>
            <td class="auto-style184">&nbsp;</td>
            <td class="auto-style169">&nbsp;</td>
            <td class="auto-style170">&nbsp;</td>
            <td class="auto-style171">&nbsp;</td>
        </tr>
    </table>
    <br />
    <table class="auto-style159">
        <tr>
            <td class="auto-style160" colspan="7"><strong>Character References (Co-workers &amp; Immediate Supervisors)</strong></td>
        </tr>
        <tr>
            <td class="auto-style42">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style162">&nbsp;</td>
            <td class="newStyle6"><strong>Last Name:</strong></td>
            <td class="newStyle6"><strong>First Name:</strong></td>
            <td class="newStyle6"><strong>MI:</strong></td>
            <td class="newStyle6"><strong>Position:</strong></td>
            <td class="newStyle6"><strong>Company Address/Phone no.:</strong></td>
            <td class="newStyle6">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td>
                <asp:TextBox ID="CR1LName" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="CR1FName" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="CR1MI" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="CR1Pos" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="CR1Contact" runat="server" Width="250px" CssClass="auto-style153"></asp:TextBox>
            </td>
            <td class="auto-style49">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td>
                <asp:TextBox ID="CR2LName" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="CR2FName" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="CR2MI" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="CR2Pos" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="CR2Contact" runat="server" Width="250px" CssClass="auto-style153"></asp:TextBox>
            </td>
            <td class="auto-style49">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td>
                <asp:TextBox ID="CR3LName" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="CR3FName" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="CR3MI" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="CR3Pos" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="CR3Contact" runat="server" Width="250px" CssClass="auto-style153"></asp:TextBox>
            </td>
            <td class="auto-style49">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style50">&nbsp;</td>
            <td>
                <asp:TextBox ID="CR4LName" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="CR4FName" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="CR4MI" runat="server" Width="130px" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="CR4Pos" runat="server" CssClass="auto-style49"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="CR4Contact" runat="server" Width="250px" CssClass="auto-style153"></asp:TextBox>
            </td>
            <td class="auto-style49">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style42">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
    &nbsp;
    &nbsp;<asp:Button ID="updateBtn" runat="server" OnClick="updateBtn_Click" Text="Update" BackColor="#009900" BorderStyle="None" ForeColor="White" Height="25px" Width="90px" />
    <br />
    <br />
    

</asp:Content>
