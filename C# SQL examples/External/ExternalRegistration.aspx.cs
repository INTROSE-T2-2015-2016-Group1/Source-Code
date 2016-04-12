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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                SqlConnection LogConn = new SqlConnection(ConfigurationManager.ConnectionStrings["erecruitmentConnectionString"].ConnectionString);
                LogConn.Open();
                string checkUser = "select count(*) from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + EmailBoxR.Text + "'";
                SqlCommand regCom = new SqlCommand(checkUser, LogConn);
                int temp = Convert.ToInt32(regCom.ExecuteScalar().ToString());

                if (temp == 1)
                    Response.Write("Entered email address is already in use");

                LogConn.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Session["Email"]=  EmailBoxR.Text.ToLower();
                Session["FName"] = FNameBoxR.Text;
                Session["LName"] = LNameBoxR.Text;
                Session["MName"] = MNameBoxR.Text;
                Session["NName"] = NNameBoxR.Text;
                Session["Password"] = PassBoxR.Text;
                Session["BDay"] = MonthList.SelectedItem.Text + "/" + DayList.SelectedItem.Text + "/" + yearList.SelectedItem.Text;
                Session["BPlace"] = BirthPlaceBoxR.Text;
                Session["Gender"] = GenderList.SelectedValue.ToString();
                Session["SQuestion"] = SecretQuestionList.SelectedItem.Text;
                Session["SAnswer"] = SecretAnswerBox.Text;
                Session["Age"] = Convert.ToInt32(System.DateTime.Now.ToString("yyyy")) - Convert.ToInt32(yearList.SelectedItem.Text);

                Response.Redirect("ExternalRegistrationConfirm.aspx", false);
            }
            catch (Exception er)
            {
                Response.Write("Error:" + er.ToString());
            }
        }

        protected void BackB_Click1(object sender, EventArgs e)
        {
            Response.Redirect("../DesignateApp.aspx");
        }

    }
}