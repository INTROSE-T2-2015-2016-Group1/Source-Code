using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


namespace eRecruitment.Application.External
{
    public partial class ExternalRegistrationConfirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region Display Confirmation Details
            if (!IsPostBack)
            {
                
                FirstNameLabel.Text = Session["FName"].ToString();
                MiddleNameLabel.Text = Session["MName"].ToString();
                LastNameLabel.Text = Session["LName"].ToString();
                NickNameLabel.Text = Session["NName"].ToString();
                EmailLabel.Text = Session["Email"].ToString();
                BDayLabel.Text = Session["BDay"].ToString();
                BPlaceLabel.Text = Session["BPlace"].ToString();
                GenderLabel.Text = Session["Gender"].ToString();
                QuestionLabel.Text = Session["SQuestion"].ToString();
                AnswerLabel.Text = Session["SAnswer"].ToString();
            }
            #endregion
        }

        protected void ConfirmButton_Click(object sender, EventArgs e)
        {
            string display;
            try
            {
                //Check if existing FNAME, MNAME, LNAME, EMAIL_ADDRESS AND BDAY
                SqlConnection LogConn = new SqlConnection(ConfigurationManager.ConnectionStrings["erecruitmentConnectionString"].ConnectionString);

                LogConn.Open();

                string insertQuery = "select count(*) from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["Email"].ToString() + "' AND LAST_NAME = '" + Session["LName"].ToString() + "' AND FIRST_NAME = '" + Session["FName"].ToString() + "' AND MIDDLE_NAME = '" + Session["MName"].ToString() + "' AND BIRTH_DATE = '" + Session["BDay"].ToString() + "' ";
                SqlCommand regCom = new SqlCommand(insertQuery, LogConn);
                int temp = Convert.ToInt32(regCom.ExecuteScalar().ToString());

                if (temp == 0)
                {
                    #region Insert Queries
                    insertQuery = "insert into T_USER_ACCOUNTS (EMAIL_ADDRESS, PASSWORD, LAST_NAME, FIRST_NAME, MIDDLE_NAME, NICKNAME, BIRTH_DATE, BIRTH_PLACE, SEX, AGE,SECRET_QUESTION, SECRET_ANSWER) values (@Email, @Password, @LName, @FName, @MName, @NName, @BDay, @BPlace, @Sex, @Age, @SecretQuestion, @SecretAnswer)";
                    regCom = new SqlCommand(insertQuery, LogConn);
                    regCom.Parameters.AddWithValue("@Email", Session["Email"].ToString());
                    regCom.Parameters.AddWithValue("@LName", Session["LName"].ToString());
                    regCom.Parameters.AddWithValue("@FName", Session["FName"].ToString());
                    regCom.Parameters.AddWithValue("@MName", Session["MName"].ToString());
                    regCom.Parameters.AddWithValue("@NName", Session["NName"].ToString());
                    regCom.Parameters.AddWithValue("@Password", Session["Password"].ToString());
                    regCom.Parameters.AddWithValue("@BDay", Session["BDay"].ToString());
                    regCom.Parameters.AddWithValue("@BPlace", Session["BPlace"].ToString());
                    regCom.Parameters.AddWithValue("@Age", Convert.ToInt32(Session["Age"]));
                    regCom.Parameters.AddWithValue("@Sex", Session["Gender"].ToString());
                    regCom.Parameters.AddWithValue("@SecretQuestion", Session["SQuestion"].ToString());
                    regCom.Parameters.AddWithValue("@SecretAnswer", Session["SAnswer"].ToString());
                    regCom.ExecuteNonQuery();

                    string insertEduQuery1 = "insert into T_USER_EDUBKGND (EMAIL_ADDRESS, EDUCATION_CODE) values (@EMAIL_ADDRESS, @EDUCATION_CODE)";
                    SqlCommand regEduCom1 = new SqlCommand(insertEduQuery1, LogConn);
                    regEduCom1.Parameters.AddWithValue("@EMAIL_ADDRESS", Session["Email"].ToString());
                    regEduCom1.Parameters.AddWithValue("@EDUCATION_CODE", Session["Email"].ToString() + "_1");
                    regEduCom1.ExecuteNonQuery();

                    string insertEduQuery2 = "insert into T_USER_EDUBKGND (EMAIL_ADDRESS, EDUCATION_CODE) values (@EMAIL_ADDRESS, @EDUCATION_CODE)";
                    SqlCommand regEduCom2 = new SqlCommand(insertEduQuery2, LogConn);
                    regEduCom2.Parameters.AddWithValue("@EMAIL_ADDRESS", Session["Email"].ToString());
                    regEduCom2.Parameters.AddWithValue("@EDUCATION_CODE", Session["Email"].ToString() + "_2");
                    regEduCom2.ExecuteNonQuery();

                    string insertEduQuery3 = "insert into T_USER_EDUBKGND (EMAIL_ADDRESS, EDUCATION_CODE) values (@EMAIL_ADDRESS, @EDUCATION_CODE)";
                    SqlCommand regEduCom3 = new SqlCommand(insertEduQuery3, LogConn);
                    regEduCom3.Parameters.AddWithValue("@EMAIL_ADDRESS", Session["Email"].ToString());
                    regEduCom3.Parameters.AddWithValue("@EDUCATION_CODE", Session["Email"].ToString() + "_3");
                    regEduCom3.ExecuteNonQuery();

                    string insertEduQuery4 = "insert into T_USER_EDUBKGND (EMAIL_ADDRESS, EDUCATION_CODE) values (@EMAIL_ADDRESS, @EDUCATION_CODE)";
                    SqlCommand regEduCom4 = new SqlCommand(insertEduQuery4, LogConn);
                    regEduCom4.Parameters.AddWithValue("@EMAIL_ADDRESS", Session["Email"].ToString());
                    regEduCom4.Parameters.AddWithValue("@EDUCATION_CODE", Session["Email"].ToString() + "_4");
                    regEduCom4.ExecuteNonQuery();

                    string insertGovTestQuery1 = "insert into T_USER_EDUBKGND_GOVTEST (EMAIL_ADDRESS, EDUCATION_GOVTEST_CODE) values (@EMAIL_ADDRESS, @EDUCATION_GOVTEST_CODE)";
                    SqlCommand regGovTestCom1 = new SqlCommand(insertGovTestQuery1, LogConn);
                    regGovTestCom1.Parameters.AddWithValue("@EMAIL_ADDRESS", Session["Email"].ToString());
                    regGovTestCom1.Parameters.AddWithValue("@EDUCATION_GOVTEST_CODE", Session["Email"].ToString() + "_1");
                    regGovTestCom1.ExecuteNonQuery();

                    string insertGovTestQuery2 = "insert into T_USER_EDUBKGND_GOVTEST (EMAIL_ADDRESS, EDUCATION_GOVTEST_CODE) values (@EMAIL_ADDRESS, @EDUCATION_GOVTEST_CODE)";
                    SqlCommand regGovTestCom2 = new SqlCommand(insertGovTestQuery2, LogConn);
                    regGovTestCom2.Parameters.AddWithValue("@EMAIL_ADDRESS", Session["Email"].ToString());
                    regGovTestCom2.Parameters.AddWithValue("@EDUCATION_GOVTEST_CODE", Session["Email"].ToString() + "_2");
                    regGovTestCom2.ExecuteNonQuery();

                    string insertFamQuery1 = "insert into T_USER_FMLYBCK (EMAIL_ADDRESS, FAMILY_CODE) values (@EMAIL_ADDRESS, @FAMILY_CODE)";
                    SqlCommand regFamCom1 = new SqlCommand(insertFamQuery1, LogConn);
                    regFamCom1.Parameters.AddWithValue("@EMAIL_ADDRESS", Session["Email"].ToString());
                    regFamCom1.Parameters.AddWithValue("@FAMILY_CODE", Session["Email"].ToString() + "_1");
                    regFamCom1.ExecuteNonQuery();

                    string insertFamQuery2 = "insert into T_USER_FMLYBCK (EMAIL_ADDRESS, FAMILY_CODE) values (@EMAIL_ADDRESS, @FAMILY_CODE)";
                    SqlCommand regFamCom2 = new SqlCommand(insertFamQuery2, LogConn);
                    regFamCom2.Parameters.AddWithValue("@EMAIL_ADDRESS", Session["Email"].ToString());
                    regFamCom2.Parameters.AddWithValue("@FAMILY_CODE", Session["Email"].ToString() + "_2");
                    regFamCom2.ExecuteNonQuery();

                    string insertFamQuery3 = "insert into T_USER_FMLYBCK (EMAIL_ADDRESS, FAMILY_CODE) values (@EMAIL_ADDRESS, @FAMILY_CODE)";
                    SqlCommand regFamCom3 = new SqlCommand(insertFamQuery3, LogConn);
                    regFamCom3.Parameters.AddWithValue("@EMAIL_ADDRESS", Session["Email"].ToString());
                    regFamCom3.Parameters.AddWithValue("@FAMILY_CODE", Session["Email"].ToString() + "_3");
                    regFamCom3.ExecuteNonQuery();

                    string insertFamQuery4 = "insert into T_USER_FMLYBCK (EMAIL_ADDRESS, FAMILY_CODE) values (@EMAIL_ADDRESS, @FAMILY_CODE)";
                    SqlCommand regFamCom4 = new SqlCommand(insertFamQuery4, LogConn);
                    regFamCom4.Parameters.AddWithValue("@EMAIL_ADDRESS", Session["Email"].ToString());
                    regFamCom4.Parameters.AddWithValue("@FAMILY_CODE", Session["Email"].ToString() + "_4");
                    regFamCom4.ExecuteNonQuery();

                    string insertFamQuery5 = "insert into T_USER_FMLYBCK (EMAIL_ADDRESS, FAMILY_CODE) values (@EMAIL_ADDRESS, @FAMILY_CODE)";
                    SqlCommand regFamCom5 = new SqlCommand(insertFamQuery5, LogConn);
                    regFamCom5.Parameters.AddWithValue("@EMAIL_ADDRESS", Session["Email"].ToString());
                    regFamCom5.Parameters.AddWithValue("@FAMILY_CODE", Session["Email"].ToString() + "_5");
                    regFamCom5.ExecuteNonQuery();

                    string insertProfQuery1 = "insert into T_USER_PERSREF (EMAIL_ADDRESS, REFERENCE_CODE) values (@EMAIL_ADDRESS, @REFERENCE_CODE)";
                    SqlCommand regProfCom1 = new SqlCommand(insertProfQuery1, LogConn);
                    regProfCom1.Parameters.AddWithValue("@EMAIL_ADDRESS", Session["Email"].ToString());
                    regProfCom1.Parameters.AddWithValue("@REFERENCE_CODE", Session["Email"].ToString() + "_1");
                    regProfCom1.ExecuteNonQuery();

                    string insertProfQuery2 = "insert into T_USER_PERSREF (EMAIL_ADDRESS, REFERENCE_CODE) values (@EMAIL_ADDRESS, @REFERENCE_CODE)";
                    SqlCommand regProfCom2 = new SqlCommand(insertProfQuery2, LogConn);
                    regProfCom2.Parameters.AddWithValue("@EMAIL_ADDRESS", Session["Email"].ToString());
                    regProfCom2.Parameters.AddWithValue("@REFERENCE_CODE", Session["Email"].ToString() + "_2");
                    regProfCom2.ExecuteNonQuery();

                    string insertProfQuery3 = "insert into T_USER_PERSREF (EMAIL_ADDRESS, REFERENCE_CODE) values (@EMAIL_ADDRESS, @REFERENCE_CODE)";
                    SqlCommand regProfCom3 = new SqlCommand(insertProfQuery3, LogConn);
                    regProfCom3.Parameters.AddWithValue("@EMAIL_ADDRESS", Session["Email"].ToString());
                    regProfCom3.Parameters.AddWithValue("@REFERENCE_CODE", Session["Email"].ToString() + "_3");
                    regProfCom3.ExecuteNonQuery();

                    string insertProfQuery4 = "insert into T_USER_PERSREF (EMAIL_ADDRESS, REFERENCE_CODE) values (@EMAIL_ADDRESS, @REFERENCE_CODE)";
                    SqlCommand regProfCom4 = new SqlCommand(insertProfQuery4, LogConn);
                    regProfCom4.Parameters.AddWithValue("@EMAIL_ADDRESS", Session["Email"].ToString());
                    regProfCom4.Parameters.AddWithValue("@REFERENCE_CODE", Session["Email"].ToString() + "_4");
                    regProfCom4.ExecuteNonQuery();

                    string insertWorkQuery1 = "insert into T_USER_WORKEXP (EMAIL_ADDRESS, EXPERIENCED_CODE) values (@EMAIL_ADDRESS, @EXPERIENCED_CODE)";
                    SqlCommand regWorkCom1 = new SqlCommand(insertWorkQuery1, LogConn);
                    regWorkCom1.Parameters.AddWithValue("@EMAIL_ADDRESS", Session["Email"].ToString());
                    regWorkCom1.Parameters.AddWithValue("@EXPERIENCED_CODE", Session["Email"].ToString() + "_1");
                    regWorkCom1.ExecuteNonQuery();

                    string insertWorkQuery2 = "insert into T_USER_WORKEXP (EMAIL_ADDRESS, EXPERIENCED_CODE) values (@EMAIL_ADDRESS, @EXPERIENCED_CODE)";
                    SqlCommand regWorkCom2 = new SqlCommand(insertWorkQuery2, LogConn);
                    regWorkCom2.Parameters.AddWithValue("@EMAIL_ADDRESS", Session["Email"].ToString());
                    regWorkCom2.Parameters.AddWithValue("@EXPERIENCED_CODE", Session["Email"].ToString() + "_2");
                    regWorkCom2.ExecuteNonQuery();

                    string insertWorkQuery3 = "insert into T_USER_WORKEXP (EMAIL_ADDRESS, EXPERIENCED_CODE) values (@EMAIL_ADDRESS, @EXPERIENCED_CODE)";
                    SqlCommand regWorkCom3 = new SqlCommand(insertWorkQuery3, LogConn);
                    regWorkCom3.Parameters.AddWithValue("@EMAIL_ADDRESS", Session["Email"].ToString());
                    regWorkCom3.Parameters.AddWithValue("@EXPERIENCED_CODE", Session["Email"].ToString() + "_3");
                    regWorkCom3.ExecuteNonQuery();

                    string insertWorkQuery4 = "insert into T_USER_WORKEXP (EMAIL_ADDRESS, EXPERIENCED_CODE) values (@EMAIL_ADDRESS, @EXPERIENCED_CODE)";
                    SqlCommand regWorkCom4 = new SqlCommand(insertWorkQuery4, LogConn);
                    regWorkCom4.Parameters.AddWithValue("@EMAIL_ADDRESS", Session["Email"].ToString());
                    regWorkCom4.Parameters.AddWithValue("@EXPERIENCED_CODE", Session["Email"].ToString() + "_4");
                    regWorkCom4.ExecuteNonQuery();

                    string insertWorkQuery5 = "insert into T_USER_WORKEXP (EMAIL_ADDRESS, EXPERIENCED_CODE) values (@EMAIL_ADDRESS, @EXPERIENCED_CODE)";
                    SqlCommand regWorkCom5 = new SqlCommand(insertWorkQuery5, LogConn);
                    regWorkCom5.Parameters.AddWithValue("@EMAIL_ADDRESS", Session["Email"].ToString());
                    regWorkCom5.Parameters.AddWithValue("@EXPERIENCED_CODE", Session["Email"].ToString() + "_5");
                    regWorkCom5.ExecuteNonQuery();

                    string insertMaybankEmpQuery1 = "insert into T_USER_MAYBANK_EMP (EMAIL_ADDRESS, MAYBANK_EMP_CODE) values (@EMAIL_ADDRESS, @MAYBANK_EMP_CODE)";
                    SqlCommand regMaybankEmpCom1 = new SqlCommand(insertMaybankEmpQuery1, LogConn);
                    regMaybankEmpCom1.Parameters.AddWithValue("@EMAIL_ADDRESS", Session["Email"].ToString());
                    regMaybankEmpCom1.Parameters.AddWithValue("@MAYBANK_EMP_CODE", Session["Email"].ToString() + "_1");
                    regMaybankEmpCom1.ExecuteNonQuery();

                    string insertMaybankEmpQuery2 = "insert into T_USER_MAYBANK_EMP (EMAIL_ADDRESS, MAYBANK_EMP_CODE) values (@EMAIL_ADDRESS, @MAYBANK_EMP_CODE)";
                    SqlCommand regMaybankEmpCom2 = new SqlCommand(insertMaybankEmpQuery2, LogConn);
                    regMaybankEmpCom2.Parameters.AddWithValue("@EMAIL_ADDRESS", Session["Email"].ToString());
                    regMaybankEmpCom2.Parameters.AddWithValue("@MAYBANK_EMP_CODE", Session["Email"].ToString() + "_2");
                    regMaybankEmpCom2.ExecuteNonQuery();

                    #endregion

                    display = "Account Registered! " + temp.ToString();
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Success!", "alert('" + display +"');", true);            
                 }
                else
                {
                    display = "Account already exists!";
                    ClientScript.RegisterStartupScript(this.GetType(), "Success!", "alert('" + display + "');", true);
                }

                LogConn.Close();

                if(temp == 0)
                    Response.Redirect("../DesignateApp.aspx", false);
            }
            catch (Exception)
            {
                display = "Error in your account! Please try again.";
                ClientScript.RegisterStartupScript(this.GetType(), "Success!", "alert('" + display + "');", true);
            }

 
        }

        protected void BackB_Click(object sender, EventArgs e)
        {
            Response.Redirect("ExternalRegistration.aspx");
        }
    }
}