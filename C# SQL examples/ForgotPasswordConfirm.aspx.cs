using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace eRecruitment.Application
{
    public partial class ForgotPasswordConfirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection QueConn = new SqlConnection(ConfigurationManager.ConnectionStrings["erecruitmentConnectionString"].ConnectionString);
                QueConn.Open();
                string Question = "select SECRET_QUESTION from T_USER_ACCOUNTS where PASSWORD = '" + Session["newPass"].ToString() + "'";
                SqlCommand QueCom = new SqlCommand(Question, QueConn);
                SecretQuestionLabel.Text = QueCom.ExecuteScalar().ToString();
                QueConn.Close();
        }

        protected void SubmitAnswer_Click(object sender, EventArgs e)
        {
            SqlConnection checkAnsConn = new SqlConnection(ConfigurationManager.ConnectionStrings["erecruitmentConnectionString"].ConnectionString);    
            checkAnsConn.Open();

            string checkAnswer = "select count(*) from T_USER_ACCOUNTS where PASSWORD = '" + Session["newPass"].ToString() + "' and SECRET_ANSWER = '" + SecretAnswerCon.Text + "'";
            SqlCommand checkCom = new SqlCommand(checkAnswer, checkAnsConn);
            int temp = Convert.ToInt32(checkCom.ExecuteScalar().ToString());

            if (temp == 1)
                ShowPassword.Text = "Your password is: " + Session["newPass"].ToString();
            else
                ShowPassword.Text = "The answer to your secret question is incorrect";
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("ForgotPassword.aspx");
        }
    }
}
