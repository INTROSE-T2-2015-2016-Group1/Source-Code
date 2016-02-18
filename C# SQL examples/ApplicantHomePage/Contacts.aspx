<%@ Page Title="" Language="C#" MasterPageFile="~/Application/ApplicantHomePage/Site1.Master" AutoEventWireup="true" CodeBehind="Contacts.aspx.cs" Inherits="eRecruitment.Application.ApplicantHomePage.ApplicantHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type ="text/css">
        .auto-style51 {
            font-family: "Gill Sans", "Gill Sans MT", Calibri, "Trebuchet MS", sans-serif;
            font-size: 52px;
            font-weight: lighter;
            color: #808080;
            white-space: normal;
            letter-spacing: -2px;
        }
        .newStyle503 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .newStyle504 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .newStyle505 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style52 {
            height: 22px;
        }
    </style>
    <br />
    <span class="auto-style51">CONTACTS</span><br />
    
    <br />
    <span class="newStyle503">CORPORATE ADDRESS<br />
    <br />
                                4th floor 7th Avenue corner 28th Street
                                <br />
                                Bonifacio High Street Central
                                <br />
                                Bonifacio Global City, 1634 Taguig City
                                <br />
                                Metro Manila Philippines

                            <br />
    </span>
    <br />
    <span class="newStyle504">TALENT AQUISITION AND MANAGEMENT TEAM<br />
    </span>
    <table class="newStyle504" style="border-style: solid; border-width: medium">
                                <tr>
                                    <td align="center" class="auto-style52" 
                                        style="border-style: solid; border-width: thin">
                                    
                                        <asp:Label ID="name" runat="server" Text="Name"></asp:Label>
                                    
                                    </td>

                                    <td align="center" style="border-style: solid; border-width: thin" class="auto-style52">
                                    
                                        <asp:Label ID="position" runat="server" Text="Position"></asp:Label>
                                    
                                    </td>

                                    <td align="center" style="border-style: solid; border-width: thin" class="auto-style52">
                                        
                                        <asp:Label ID="email" runat="server" Text="Email Address"></asp:Label>
                                                                            
                                    </td>
                                </tr>

                                <tr>
                                    <td class="style2">
                                    
                                        <p style="border-style: none solid solid none; border-width: thin">
                                        &nbsp;
                                        Melanie P. Santos
                                        </p>
                                    
                                    </td>

                                    <td>
                                    
                                        <p style="border-style: none solid solid none; border-width: thin">
                                        &nbsp;
                                        Head - Talent Acquisition
                                        </p>
                                    
                                    </td>

                                    <td>
                                    
                                        <p style="border-style: none none solid none; border-width: thin">
                                        &nbsp;
                                        mpsantos@maybank.com.ph
                                        </p>
                                    
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style2">

                                        <p style="border-style: none solid solid none; border-width: thin">
                                        &nbsp;
                                        Mary Joy T. Remada
                                        </p>
                                    
                                    </td>

                                    <td>
                                    
                                        <p style="border-style: none solid solid none; border-width: thin">
                                        &nbsp;
                                        Talent Acquisition Officer
                                        </p>
                                    
                                    </td>

                                    <td>
                                    
                                        <p style="border-bottom-style: solid; border-width: thin">
                                        &nbsp;
                                        mtremada@maybank.com.ph
                                        </p>
                                    
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style2" 
                                        style="border-right-style: solid; border-bottom-style: solid; border-width: thin">
                                    
                                        <p>
                                        &nbsp;
                                        Kathrine Chelle P. Boter
                                        </p>
                                    
                                    </td>

                                    <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin">
                                    
                                        <p>
                                        &nbsp;
                                        Talent Acquisition Associate
                                        </p>
                                    
                                    </td>

                                    <td>
                                    
                                        <p style="border-style: none; border-width: thin;">
                                        &nbsp;
                                        kpboter@maybank.com.ph
                                        </p>
                                    
                                    </td>
                                </tr>
                            </table>
    <br />
    <asp:Label ID="contactLbl" runat="server" CssClass="newStyle505" Text=" Call us at: 588-3777 loc. 3779 "></asp:Label>
</asp:Content>
