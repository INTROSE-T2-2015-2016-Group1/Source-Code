<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExternalRegistration.aspx.cs"  Inherits="eRecruitment.Application.External.WebForm1" %>

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
        .newStyle3 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style9 {
            width: 149px;
        }
        .newStyle3 {
            margin-left: 40px;
        }
        .auto-style11 {
            color: #666666;
            font-size: small;
        }
        .newStyle3 {
        }
        .auto-style12 {
            width: 149px;
            height: 22px;
        }
        .auto-style13 {
            width: 250px;
            height: 22px;
        }
        .auto-style14 {
            height: 22px;
            width: 280px;
        }
        .auto-style15 {
            width: 149px;
            height: 40px;
        }
        .auto-style16 {
            width: 250px;
            height: 40px;
        }
        .auto-style17 {
            height: 40px;
            width: 280px;
        }
        .auto-style18 {
            width: 149px;
            height: 33px;
        }
        .auto-style19 {
            width: 250px;
            height: 33px;
        }
        .auto-style20 {
            height: 33px;
            width: 280px;
        }
        .auto-style21 {
            width: 149px;
            height: 34px;
        }
        .auto-style22 {
            width: 250px;
            height: 34px;
        }
        .auto-style23 {
            height: 34px;
            width: 280px;
        }
        .auto-style24 {
            color: #FF0000;
        }
        .auto-style25 {
            width: 149px;
            height: 31px;
        }
        .auto-style26 {
            width: 250px;
            height: 31px;
        }
        .auto-style27 {
            height: 31px;
            width: 280px;
        }
        .auto-style31 {}
        .auto-style33 {
            width: 250px;
        }
        .auto-style36 {
            height: -15px;
            width: 500px;
            text-align: left;
        }
        .auto-style37 {
            width: 280px;
        }
        .auto-style39 {
            font-size: medium;
        }
        .auto-style40 {}
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
    
        <table class="auto-style41" style="background-color: #222222; color: #9D9D9D; font-family: Arial, Helvetica, sans-serif; margin-left: 0px; margin-top: 0px;">
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
                <td class="auto-style3"><span class="newStyle2">&nbsp;E</span><span class="auto-style7">XTERNAL <span class="newStyle2">A</span>PPLICANT</span><span class="newStyle2"> R</span><span class="auto-style7">EGISTER</span><hr class="auto-style36" />
                </td>
            </tr>
        </table>
        <table class="newStyle3">
            <tr>
                <td class="auto-style11"><em>All fields are required to register</em></td>
            </tr>
        </table>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="ErrorLabel" runat="server" ForeColor="Red"></asp:Label>
        <br />
        </p>
        <table class="newStyle3">
            <tr>
                <td class="auto-style9">First Name:</td>
                <td class="auto-style33">
                    <asp:TextBox ID="FNameBoxR" runat="server" Height="20px" Width="90%"></asp:TextBox>
                    </td>
                <td class="auto-style37">
                    <asp:RequiredFieldValidator ID="FNameValid" runat="server" ErrorMessage="Please enter your first name" ForeColor="Red" ControlToValidate="FNameBoxR"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Middle Name:</td>
                <td class="auto-style33">
                    <asp:TextBox ID="MNameBoxR" runat="server" Height="20px" Width="90%"></asp:TextBox>
                    </td>
                <td class="auto-style37">
                    <asp:RequiredFieldValidator ID="MNameValid" runat="server" ErrorMessage="Please enter your middle name" ForeColor="Red" ControlToValidate="MNameBoxR"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Last Name:</td>
                <td class="auto-style33">
                    <asp:TextBox ID="LNameBoxR" runat="server" Height="20px" Width="90%"></asp:TextBox>
                    </td>
                <td class="auto-style37">
                    <asp:RequiredFieldValidator ID="LNameValid" runat="server" ErrorMessage="Please enter your last name" ForeColor="Red" ControlToValidate="LNameBoxR"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style25">Nickname:</td>
                <td class="auto-style26">
                    <asp:TextBox ID="NNameBoxR" runat="server" Height="20px" Width="90%"></asp:TextBox>
                    </td>
                <td class="auto-style27">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="NNameBoxR" ErrorMessage="Please enter your Nickname" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
                <td class="auto-style37">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style15">Email Address:</td>
                <td class="auto-style16">
                    <asp:TextBox ID="EmailBoxR" runat="server" Height="20px" Width="90%"></asp:TextBox>
                    </td>
                <td class="auto-style17">
                    <asp:RequiredFieldValidator ID="EmailValid1" runat="server" ErrorMessage="Please enter your e-mail address" ForeColor="Red" ControlToValidate="EmailBoxR"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="EmailValid2" runat="server" ControlToValidate="EmailBoxR" ErrorMessage="Please enter a valid e-mail address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12"></td>
                <td class="auto-style13"></td>
                <td class="auto-style14"></td>
            </tr>
            <tr>
                <td class="auto-style18">Password:</td>
                <td class="auto-style19">
                    <asp:TextBox ID="PassBoxR" runat="server" Height="20px" Width="90%" TextMode="Password"></asp:TextBox>
                    </td>
                <td class="auto-style20">
                    <asp:RequiredFieldValidator ID="PassValid" runat="server" ErrorMessage="Please enter your password" ForeColor="Red" ControlToValidate="PassBoxR"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="PassBoxR" ValidationExpression="^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{6,20}$" ErrorMessage="Please enter valid password" style="color: #FF0000"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style18"></td>
                <td class="auto-style19">
                    <asp:Label ID="PassValidLbl" runat="server" Font-Italic="True" Font-Size="XX-Small" Text="Password should ba a combination of 6 - 20 uppercase, lowercase, and numeric characters." style="font-size: xx-small"></asp:Label>
                    <br />
                </td>
                <td class="auto-style20">
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Confirm Password:</td>
                <td class="auto-style33">
                    <asp:TextBox ID="PassBoxCR" runat="server" Height="20px" Width="90%" TextMode="Password"></asp:TextBox>
                    </td>
                <td class="auto-style37">
                    <asp:RequiredFieldValidator ID="PassCValid1" runat="server" ErrorMessage="Please re-enter your password" ForeColor="Red" BorderStyle="None" ControlToValidate="PassBoxCR"></asp:RequiredFieldValidator>
                    <br />
                    <asp:CompareValidator ID="PassCValid2" runat="server" ControlToCompare="PassBoxR" ControlToValidate="PassBoxCR" ErrorMessage="Re-entered password is incorrect" ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
                <td class="auto-style37">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style18">Birth Date:</td>
                <td class="auto-style19">
                    <asp:DropDownList ID="MonthList" runat="server" CssClass="auto-style31" Height="20px">
                        <asp:ListItem>01</asp:ListItem>
                        <asp:ListItem>02</asp:ListItem>
                        <asp:ListItem>03</asp:ListItem>
                        <asp:ListItem>04</asp:ListItem>
                        <asp:ListItem>05</asp:ListItem>
                        <asp:ListItem>06</asp:ListItem>
                        <asp:ListItem>07</asp:ListItem>
                        <asp:ListItem>08</asp:ListItem>
                        <asp:ListItem>09</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<span class="auto-style39">/</span> <asp:DropDownList ID="DayList" runat="server" Height="20px">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                        <asp:ListItem>13</asp:ListItem>
                        <asp:ListItem>14</asp:ListItem>
                        <asp:ListItem>15</asp:ListItem>
                        <asp:ListItem>16</asp:ListItem>
                        <asp:ListItem>17</asp:ListItem>
                        <asp:ListItem>18</asp:ListItem>
                        <asp:ListItem>19</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                        <asp:ListItem>21</asp:ListItem>
                        <asp:ListItem>22</asp:ListItem>
                        <asp:ListItem>23</asp:ListItem>
                        <asp:ListItem>24</asp:ListItem>
                        <asp:ListItem>25</asp:ListItem>
                        <asp:ListItem>26</asp:ListItem>
                        <asp:ListItem>27</asp:ListItem>
                        <asp:ListItem>28</asp:ListItem>
                        <asp:ListItem>29</asp:ListItem>
                        <asp:ListItem>30</asp:ListItem>
                        <asp:ListItem>31</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;<span class="auto-style39">/</span><span class="newStyle2"> <asp:DropDownList ID="yearList" runat="server">
                    <asp:ListItem>2015</asp:ListItem>
                    <asp:ListItem>2014</asp:ListItem>
                    <asp:ListItem>2013</asp:ListItem>
                    <asp:ListItem>2012</asp:ListItem>
                    <asp:ListItem>2011</asp:ListItem>
                    <asp:ListItem>2010</asp:ListItem>
                    <asp:ListItem>2009</asp:ListItem>
                    <asp:ListItem>2008</asp:ListItem>
                    <asp:ListItem>2007</asp:ListItem>
                    <asp:ListItem>2006</asp:ListItem>
                    <asp:ListItem>2005</asp:ListItem>
                    <asp:ListItem>2004</asp:ListItem>
                    <asp:ListItem>2003</asp:ListItem>
                    <asp:ListItem>2002</asp:ListItem>
                    <asp:ListItem>2001</asp:ListItem>
                    <asp:ListItem>2000</asp:ListItem>
                    <asp:ListItem>1999</asp:ListItem>
                    <asp:ListItem>1998</asp:ListItem>
                    <asp:ListItem>1997</asp:ListItem>
                    <asp:ListItem>1996</asp:ListItem>
                    <asp:ListItem>1995</asp:ListItem>
                    <asp:ListItem>1994</asp:ListItem>
                    <asp:ListItem>1993</asp:ListItem>
                    <asp:ListItem>1992</asp:ListItem>
                    <asp:ListItem>1991</asp:ListItem>
                    <asp:ListItem>1990</asp:ListItem>
                    <asp:ListItem>1989</asp:ListItem>
                    <asp:ListItem>1988</asp:ListItem>
                    <asp:ListItem>1987</asp:ListItem>
                    <asp:ListItem>1986</asp:ListItem>
                    <asp:ListItem>1985</asp:ListItem>
                    <asp:ListItem>1984</asp:ListItem>
                    <asp:ListItem>1983</asp:ListItem>
                    <asp:ListItem>1982</asp:ListItem>
                    <asp:ListItem>1981</asp:ListItem>
                    <asp:ListItem>1980</asp:ListItem>
                    <asp:ListItem>1979</asp:ListItem>
                    <asp:ListItem>1978</asp:ListItem>
                    <asp:ListItem>1977</asp:ListItem>
                    <asp:ListItem>1976</asp:ListItem>
                    <asp:ListItem>1975</asp:ListItem>
                    <asp:ListItem>1974</asp:ListItem>
                    <asp:ListItem>1973</asp:ListItem>
                    <asp:ListItem>1972</asp:ListItem>
                    <asp:ListItem>1971</asp:ListItem>
                    <asp:ListItem>1970</asp:ListItem>
                    <asp:ListItem>1969</asp:ListItem>
                    <asp:ListItem>1968</asp:ListItem>
                    <asp:ListItem>1967</asp:ListItem>
                    <asp:ListItem>1966</asp:ListItem>
                    <asp:ListItem>1965</asp:ListItem>
                    <asp:ListItem>1964</asp:ListItem>
                    <asp:ListItem>1963</asp:ListItem>
                    <asp:ListItem>1962</asp:ListItem>
                    <asp:ListItem>1961</asp:ListItem>
                    <asp:ListItem>1960</asp:ListItem>
                    <asp:ListItem>1959</asp:ListItem>
                    <asp:ListItem>1958</asp:ListItem>
                    <asp:ListItem>1957</asp:ListItem>
                    <asp:ListItem>1956</asp:ListItem>
                    <asp:ListItem>1955</asp:ListItem>
                    <asp:ListItem>1954</asp:ListItem>
                    <asp:ListItem>1953</asp:ListItem>
                    <asp:ListItem>1952</asp:ListItem>
                    <asp:ListItem>1951</asp:ListItem>
                    <asp:ListItem>1950</asp:ListItem>
                    <asp:ListItem>1949</asp:ListItem>
                    <asp:ListItem>1948</asp:ListItem>
                    <asp:ListItem>1947</asp:ListItem>
                    <asp:ListItem>1946</asp:ListItem>
                    <asp:ListItem>1945</asp:ListItem>
                    <asp:ListItem>1943</asp:ListItem>
                    <asp:ListItem>1942</asp:ListItem>
                    <asp:ListItem>1941</asp:ListItem>
                    <asp:ListItem>1940</asp:ListItem>
                </asp:DropDownList>
    </span> 
                </td>
                <td class="auto-style20">
                    </td>
            </tr>
            <tr>
                <td class="auto-style18">Birth Place:</td>
                <td class="auto-style19">
                    <asp:TextBox ID="BirthPlaceBoxR" runat="server" Height="20px" Width="90%"></asp:TextBox>
                    </td>
                <td class="auto-style20">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="BirthPlaceBoxR" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Please enter your place of birth</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
                <td class="auto-style37">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style18">Sex:</td>
                <td class="auto-style19">
                    <asp:DropDownList ID="GenderList" runat="server" Height="20px" Width="20%" CssClass="auto-style40">
                        <asp:ListItem Value="M">M</asp:ListItem>
                        <asp:ListItem Value="F">F</asp:ListItem>
                    </asp:DropDownList>
                    </td>
                <td class="auto-style20">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
                <td class="auto-style37">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style18">Sercret Question: </td>
                <td class="auto-style19">
                    <asp:DropDownList ID="SecretQuestionList" runat="server" Height="20px" Width="90%">
                        <asp:ListItem>What is your first Pet&#39;s name?</asp:ListItem>
                        <asp:ListItem>What is your favorite food?</asp:ListItem>
                        <asp:ListItem>What was the name of your primary school?</asp:ListItem>
                        <asp:ListItem>What is your favorite movie?</asp:ListItem>
                    </asp:DropDownList>
                    </td>
                <td class="auto-style20">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style21">Answer:</td>
                <td class="auto-style22">
                    <asp:TextBox ID="SecretAnswerBox" runat="server" Height="20px" Width="90%"></asp:TextBox>
                    </td>
                <td class="auto-style23">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="SecretAnswerBox" CssClass="auto-style24" ErrorMessage="Please enter your answer to the question"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style33">&nbsp;</td>
                <td class="auto-style37">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="BackB" runat="server" BackColor="#009900" BorderStyle="None" Font-Bold="False" ForeColor="White" Height="27px" Text="Back" Width="65px" CausesValidation="False" CssClass="btn btn-success" OnClick="BackB_Click1"/>
                </td>
                <td class="auto-style33">
                    <asp:Button ID="Button1" runat="server" BackColor="#009900" BorderStyle="None" CssClass="btn btn-success" ForeColor="White" Height="27px" Text="Submit" OnClick="Button1_Click" Width="70%" />
                </td>
                <td class="auto-style37">&nbsp;</td>
            </tr>
        </table>
        <br />
    
    </div>
    </form>
</body>
</html>
