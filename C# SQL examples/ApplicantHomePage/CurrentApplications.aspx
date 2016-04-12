<%@ Page Title="" Language="C#" MasterPageFile="~/Application/ApplicantHomePage/Site1.Master" AutoEventWireup="true" CodeBehind="CurrentApplications.aspx.cs" Inherits="eRecruitment.Application.ApplicantHomePage.CurrentApplications" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .newStyle5 {
        font-family: Arial, Helvetica, sans-serif;
        font-size: xx-large;
        font-weight: normal;
        font-style: normal;
        font-variant: normal;
        color: #F3BE76;
    }
        .newStyle6 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
            font-size: 50px;
            font-weight: normal;
            letter-spacing: -2px;
        }
        .newStyle7 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
            font-size: 52px;
            font-weight: lighter;
            color: #808080;
            letter-spacing: -2px;
        }
        .auto-style14 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <span class="newStyle7">
    CURRENT APPLICATIONS
    </span>
    <br />
    <br />
    <asp:Label ID="NoCurrentAppLbl" runat="server" Text="You do not have any applications on going." Visible="False"></asp:Label>
    

    <div class="auto-style14">
    

    <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="APPLICATION_CODE" DataSourceID="CurrentApplicationsSQLDataSource" onrowcommand="GridView1_RowCommand" ForeColor="#333333" GridLines="None" Width="979px" Height="136px" >
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="APPLICATION_CODE" HeaderText="Application Code" ReadOnly="True" SortExpression="APPLICATION_CODE" InsertVisible="False" />
            <asp:BoundField DataField="POSITION" HeaderText="Position" SortExpression="POSITION" />
            <asp:BoundField DataField="DATE_APPLIED" HeaderText="Date Applied" SortExpression="DATE_APPLIED" />
            <asp:TemplateField HeaderText="Status">
                <ItemTemplate>
                    <asp:Label ID="currentStatusLbl" runat="server" Text="Pending" />
                </ItemTemplate> 
            </asp:TemplateField>
            <asp:BoundField DataField="REMARKS" HeaderText="Remarks" SortExpression="REMARKS" />
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="withdrawComBtn" runat="server" 
                        CommandName="withdrawCom" 
                        CommandArgument="<%# ((GridViewRow) Container).RowIndex %>"
                        Text="Withdraw" />
                </ItemTemplate> 
        </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#FFCC00" Font-Bold="True" ForeColor="White" Font-Size="22px" HorizontalAlign="Center"/>
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333"/>
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>



    </div>



    <br />
    <br />
    <br />
    <asp:SqlDataSource ID="CurrentApplicationsSQLDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:erecruitmentConnectionString %>" SelectCommand="SELECT [APPLICATION_CODE], [POSITION], [DATE_APPLIED], [STATUS_CODE], [REMARKS] FROM [T_APPLICATION_INFO] WHERE ([EMAIL_ADDRESS] = @EMAIL_ADDRESS)">
        <SelectParameters>
            <asp:SessionParameter Name="EMAIL_ADDRESS" SessionField="NEW" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    </asp:Content>
