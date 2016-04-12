using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Text;

namespace eRecruitment.Application
{
    public partial class ForgotPassword : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private string RandomString(int size, bool isLowerCase) //isLowerCase = True -> generate lower case randomized password; else -> create uppercase randomized password
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (isLowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public string GetPassword()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(RandomNumber(1, 5), true));
            builder.Append(RandomNumber(0, 10));
            builder.Append(RandomString(RandomNumber(1, 3), false));
            builder.Append(RandomNumber(0, 10));
            return builder.ToString();
        }

        protected void SendPass_Click(object sender, EventArgs e)
        {
            SqlConnection EmailConn = new SqlConnection(ConfigurationManager.ConnectionStrings["erecruitmentConnectionString"].ConnectionString);
            EmailConn.Open();
            string checkUserQuery = "select count(*) from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + EmailBoxF.Text + "'";
            SqlCommand Forgotcom = new SqlCommand(checkUserQuery, EmailConn);
            int checker = Convert.ToInt32(Forgotcom.ExecuteScalar().ToString());
            string newpass;

            if (checker == 1)
            {
                checkUserQuery = "Update T_USER_ACCOUNTS set PASSWORD = @newPass where EMAIL_ADDRESS = @EmailF";
                SqlCommand PassCom = new SqlCommand(checkUserQuery, EmailConn);
                PassCom.Parameters.AddWithValue("@newPass", newpass = GetPassword());
                PassCom.Parameters.AddWithValue("@EmailF", EmailBoxF.Text);
                PassCom.ExecuteNonQuery();

                Session["newPass"] = newpass;
                EmailConn.Close();

                Response.Redirect("ForgotPasswordConfirm.aspx", false);
            }
            else
            {
                PassStat.Text = "No user found with the given e-mail address";
            }

            EmailConn.Close();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("DesignateApp.aspx");
        }

    }
}