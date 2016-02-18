using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Web.Security;

namespace eRecruitment.Application.ApplicantHomePage
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetCacheability(HttpCacheability.Public);

            Random mRnd = new Random();
            int mRandomNumber = mRnd.Next(0, 99999);

            if (!IsPostBack)
            {
                if (Session["New"] != null)
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["erecruitmentConnectionString"].ConnectionString);
                    conn.Open();
                    string getNameQuery = "select NICKNAME from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"].ToString() + "'";
                    SqlCommand nameCom = new SqlCommand(getNameQuery, conn);
                    String name = nameCom.ExecuteScalar().ToString();
                    conn.Close();

                    nameLbl.Text = name;



                    String pngImgURL = "~/Images/ProfilePictures/" + Session["New"].ToString() + ".png";
                    String jpgImgURL = "~/Images/ProfilePictures/" + Session["New"].ToString() + ".jpg";
                    String jpegImgURL = "~/Images/ProfilePictures/" + Session["New"].ToString() + ".jpeg";

                    if (File.Exists(Server.MapPath(pngImgURL)))
                    {
                        profilePic.ImageUrl = pngImgURL + "?" + mRandomNumber;
                    }
                    else if (File.Exists(Server.MapPath(jpgImgURL)))
                    {
                        profilePic.ImageUrl = jpgImgURL + "?" + mRandomNumber;
                    }
                    else if (File.Exists(Server.MapPath(jpegImgURL)))
                    {
                        profilePic.ImageUrl = jpegImgURL + "?" + mRandomNumber;
                    }
                    else
                    {
                        profilePic.ImageUrl = "~/Images/ProfilePictures/default2.png";
                    }

                }
                else
                {
                    Response.Redirect("~/Application/DesignateApp.aspx");
                }
            }
            
        }
        protected void clearSession()
        {
            Session.Clear();
            Session.Abandon();
            Session.RemoveAll();
            Response.Cookies.Clear();
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1));
            Response.Cache.SetNoStore();
            FormsAuthentication.SignOut();

        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            clearSession();
            Response.Redirect("~/Application/DesignateApp.aspx",false);
        }
       
    }
}