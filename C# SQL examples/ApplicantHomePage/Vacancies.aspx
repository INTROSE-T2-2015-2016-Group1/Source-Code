<%@ Page Title="" Language="C#" MasterPageFile="~/Application/ApplicantHomePage/Site1.Master" AutoEventWireup="true" CodeBehind="Vacancies.aspx.cs" Inherits="eRecruitment.Application.ApplicantHomePage.Vacancies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .newStyle5 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: large;
            font-weight: bold;
            font-variant: normal;
        }
        .newStyle6 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .newStyle7 {
            font-family: Arial, Helvetica, sans-serif;
            font-weight: normal;
        }
        .newStyle8 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
            font-size: 52px;
            font-weight: lighter;
            color: #808080;
            letter-spacing: -2px;
        }
        .auto-style39 {
            width: 502px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <span class="newStyle8">VACANCIES</span><br />
    
    <br />
    <br />
    <table class="nav-justified">
        <tr>
            <td class="auto-style39">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style39">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style39">
                Departments:<br />
                <asp:DropDownList ID="departmentDDL" runat="server" DataSourceID="SqlDataSource2" DataTextField="DESCRIPTION" DataValueField="SEQ_NUM" ondatabound="DDLDepartments" AutoPostBack="True" OnSelectedIndexChanged="departmentDDL_SelectedIndexChanged">
                </asp:DropDownList>
                <br />
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:erecruitmentConnectionString %>" SelectCommand="SELECT [SEQ_NUM], [DESCRIPTION] FROM [M_DEPT]"></asp:SqlDataSource>
                <br />
                Positions:<br />
                <asp:DropDownList ID="PositionsDDL" runat="server" Font-Names="Arial" DataSourceID="AllPositionsDataSource" DataTextField="DESCRIPTION" DataValueField="DESCRIPTION">
                </asp:DropDownList>
            </td>
            <td rowspan="7">
                <asp:Label ID="invalidApplyLbl1" runat="server" Text="Unable to apply for position. Please make sure that the following fields are completely filled up:" Font-Italic="True" ForeColor="Red"></asp:Label>
                <br />
                <asp:Label ID="invalidApplyLbl2" runat="server" Text="At least one work experience:" Font-Italic="True" ForeColor="Red"></asp:Label>
                 <br />
                <asp:Label ID="invalidApplyLbl3" runat="server" Text="At least one educational background:" Font-Italic="True" ForeColor="Red"></asp:Label>
                 <br />
                <asp:Label ID="invalidApplyLbl4" runat="server" Text="At least two family experience:" Font-Italic="True" ForeColor="Red"></asp:Label>
                 <br />
                <asp:Label ID="invalidApplyLbl5" runat="server" Text="At least one work experience:" Font-Italic="True" ForeColor="Red"></asp:Label>
                 </td>
        </tr>
        <tr>
            <td class="auto-style39">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style39">Desired Salary:</td>
        </tr>
        <tr>
            <td class="auto-style39">
    <asp:TextBox ID="DesiredSalaryTextBox" runat="server" Width="189px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style39">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style39">
                <asp:Button ID="ApplyPositionBtn" runat="server" OnClick="ApplyPositionBtn_Click" Text="Apply" Font-Names="Arial" Width="69px" OnClientClick="javascript:return confirm('Are you sure you want to continue?');" />
                <asp:Label ID="alreadyAppliedLbl" runat="server" Font-Italic="True" Font-Names="Arial" ForeColor="Red" Text="You have already applied for this position."></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style39">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style39">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
    <asp:Label ID="AppliedApplicationIDLbl" runat="server" Text=" "></asp:Label>

    <asp:SqlDataSource ID="AllPositionsDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:erecruitmentConnectionString %>" SelectCommand="IF (@DEPT = 0) SELECT  [DESCRIPTION] FROM [R_POSITION] ELSE SELECT [DESCRIPTION] FROM [R_POSITION] WHERE ([DEPT] = @DEPT)">
        <SelectParameters>
            <asp:SessionParameter DefaultValue="0" Name="DEPT" SessionField="dept" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>
