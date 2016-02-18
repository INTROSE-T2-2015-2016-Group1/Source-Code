using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;

namespace eRecruitment.Application
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Clear();
                Session.Abandon();
                Session.RemoveAll();
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1));
                Response.Cache.SetNoStore();
                FormsAuthentication.SignOut();
            }
        }

        protected void LogInBtn_Click(object sender, EventArgs e)
        {

            LogInCat.Text = "Correct";
            string username = EmailBox.Text;
            username = username.ToLower();
            if (username.Contains("@"))
            {
                /* CHECK IF INTERNAL OR EXTERNAL */
                if (username.Contains("@maybank.com"))
                {
                    LogInCat.Text = " Internal";
                }
                else
                {
                    LogInCat.Text = " External";
                }
            }
            else
            {
                LogInCat.Text = " Invalid ID.";
            }

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["erecruitmentConnectionString"].ConnectionString);
            conn.Open();
            string checkuser = "select count(*) from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + EmailBox.Text + "'";
            SqlCommand com = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            conn.Close();
            if (temp == 1)
            {
                conn.Open();
                string checkPasswordQuery = "select count(*) from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + EmailBox.Text + "'  and Password = '" + PasswordBox.Text + "'";
                SqlCommand passCom = new SqlCommand(checkPasswordQuery, conn);
                int password = Convert.ToInt32(passCom.ExecuteScalar().ToString());
                conn.Close();
                if (password == 1)
                {

                    Session["New"] = EmailBox.Text;
                    Response.Redirect("~/Application/ApplicantHomePage/CurrentApplications.aspx");
                }
                else
                {
                    LogInStatus.Text = " Invalid Password.";
                }
            }
            else
            {
                LogInStatus.Text = " Email does not Exists.";
            }

        }

        protected void ForgotButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForgotPassword.aspx", false);
        }

        protected void RegisterSB_Click(object sender, EventArgs e)
        {
            Response.Redirect("External/ExternalRegistration.aspx", false);
        }

        protected void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

        }

    }         
}