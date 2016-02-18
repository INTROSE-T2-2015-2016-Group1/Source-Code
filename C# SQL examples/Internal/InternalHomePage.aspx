<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InternalHomePage.aspx.cs" Inherits="eRecruitment.Application.Internal.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 95%;
        margin-right: 0px;
    }
        .auto-style2 {
            width: 341px;
        }
        .auto-style5 {
            width: 341px;
            height: 23px;
        }
        .newStyle1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style7 {
            width: 341px;
            font-family: Arial, Helvetica, sans-serif;
            font-size: 1.5em;
        height: 4px;
    }
        .newStyle2 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style8 {
            width: 558px;
            font-size: 1.5em;
        height: 4px;
    }
        .newStyle3 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style11 {
            width: 341px;
            height: 80px;
        text-align: justify;
        font-family: Arial;
        font-size: medium;
    }
        .newStyle4 {
            font-family: Arial;
        }
        .newStyle5 {
            font-family: Arial;
        }
        .auto-style12 {
            font-family: Arial;
            height: 23px;
            width: 558px;
        }
    .auto-style13 {
            font-family: Arial;
            width: 558px;
        }
    .newStyle6 {
        font-family: "Arial Black";
    }
    .newStyle7 {
        font-family: Arial;
    }
    .newStyle8 {
        font-family: Arial;
    }
    .auto-style18 {
        font-family: Arial;
        width: 558px;
        text-align: justify;
        height: 80px;
    }
    .newStyle9 {
        font-family: Arial;
    }
    .auto-style19 {
        font-family: Arial;
        height: 7px;
        width: 558px;
    }
    .auto-style20 {
        width: 341px;
        height: 7px;
    }
        .newStyle10 {
            color: #808080;
        }
        .newStyle11 {
            color: #666666;
        }
        .auto-style21 {
            width: 152px;
            font-size: 1.5em;
            height: 4px;
        }
        .auto-style22 {
            font-family: Arial;
            width: 152px;
        }
        .auto-style23 {
            font-family: Arial;
            height: 7px;
            width: 152px;
        }
        .auto-style24 {
            font-family: Arial;
            width: 152px;
            text-align: justify;
            height: 80px;
        }
        .auto-style25 {
            font-family: Arial;
            height: 23px;
            width: 152px;
        }
        .auto-style26 {
            width: 100%;
        }
        .auto-style27 {
            font-family: Arial, Helvetica, sans-serif;
            width: 558px;
            font-size: x-large;
        }
        .newStyle12 {
            font-family: Arial, Helvetica, sans-serif;
            color: #999999;
            font-size: 1.5em;
        }
        .auto-style28 {
            font-family: Arial, Helvetica, sans-serif;
            color: #999999;
            font-size: 1em;
        }
        .newStyle13 {
            font-family: Arial, Helvetica, sans-serif;
            color: #999999;
            font-size: 1em;
        }
        .newStyle12 {
        }
        .newStyle12 {
        }
        .newStyle12 {
        }
        .newStyle13 {
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
          <img alt="Maybank Logo" src="../../Images/maybank%20logo.png" title="Maybank Logo" style="border: 4px solid #000000; height: 228px; width: 1301px; margin-right: 0px; margin-left: 0px; margin-top: 28px; background-color: #FFFFFF;" width="80%" /><br />
          <br />
          <table class="auto-style26">
              <tr>
                  <td>&nbsp;</td>
                  <td>&nbsp;</td>
              </tr>
          </table>
          <br />
    <table class="auto-style1">
        <tr>
            <td class="auto-style8"></td>
            <td class="auto-style21"></td>
            <td class="auto-style7"></td>
        </tr>
        <tr class="newStyle11">
            <td class="auto-style27"><strong><span class="newStyle12">I</span><span class="auto-style28">NTERNAL</span></strong></td>
            <td class="auto-style22">&nbsp;</td>
            <td class="auto-style5"><strong class="newStyle7"><span class="newStyle12">I</span><span class="newStyle13">NTERNAL</span></strong><strong class="newStyle7" style="font-size: x-large"> </strong><span class="newStyle12"><strong class="newStyle7">P</strong></span><strong class="newStyle13">ROVINCIAL</strong></td>
        </tr>
        <tr>
            <td class="auto-style19">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; </td>
            <td class="auto-style23">&nbsp;</td>
            <td class="auto-style20"></td>
        </tr>
        <tr>
            <td class="auto-style18" dir="auto">For applicants who are applying inside
                Metro Manila, please fill up the Internal Application Form by clicking this link:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
            <td class="auto-style24" dir="auto">&nbsp;</td>
            <td class="auto-style11" dir="auto">For applicants who are applying outside Metro Manila, please upload a soft-copy of your resume:</td>
        </tr>
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style13">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="appForm_link" runat="server" ForeColor="#000099" NavigateUrl="http://www.mpierecruitment.com.ph:8082/ApplicationInfoServ/applicationInfo.jsp" style="text-decoration: underline; background-color: #FFFFFF">Internal Application Form</asp:HyperLink>
            </td>
            <td class="auto-style22">&nbsp;</td>
            <td class="auto-style2"><asp:FileUpload ID="FileUpload1" runat="server" Width="285px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style13"></td>
            <td class="auto-style22">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style13">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td class="auto-style22">&nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style25">&nbsp;</td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            <td class="auto-style13">&nbsp;</td>
            <td class="auto-style22">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style13">&nbsp;</td>
            <td class="auto-style22">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
    </table>
        </div>
    </form>
    </body>
</html>

