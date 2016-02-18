using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace eRecruitment.Application.ApplicantHomePage
{
    public partial class Applicant_Settings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetCacheability(HttpCacheability.Public);

            if (!IsPostBack)
            {
                EmailLabel.Text = Session["New"].ToString();
                invalidUploadLbl.Visible = false;
            }
        }

        protected void ChangePassB_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection changePassConn = new SqlConnection(ConfigurationManager.ConnectionStrings["erecruitmentConnectionString"].ConnectionString);
                changePassConn.Open();

                string checkUserQuery = "select count(*) from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"].ToString() + "' and PASSWORD = '" + OldPassBox.Text + "'";
                SqlCommand changePassCom = new SqlCommand(checkUserQuery, changePassConn);
                int checker = Convert.ToInt32(changePassCom.ExecuteScalar().ToString());

                if (checker == 1)
                {
                    if (NewPassBox.Text == NewPassConfirmBox.Text)
                    {
                        string setPasswordQuery = "Update T_USER_ACCOUNTS set PASSWORD = @newPass where EMAIL_ADDRESS = '" + Session["New"].ToString() + "' and PASSWORD = '" + OldPassBox.Text + "'";
                        changePassCom = new SqlCommand(setPasswordQuery, changePassConn);
                        changePassCom.Parameters.AddWithValue("@newPass", NewPassBox.Text);
                        changePassCom.ExecuteNonQuery();
                        InformationLabel.Text = "Password updated!";
                    }
                    else
                        InformationLabel.Text = "Entered new password and confirm password are not the same";
                }
                else
                    InformationLabel.Text = "Entered current password is incorrect";
            }
            catch (Exception er)
            {
                Response.Write("Error:" + er.ToString());
            }
        }

        protected void ChangeSecQueB_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection setQuestionConn = new SqlConnection(ConfigurationManager.ConnectionStrings["erecruitmentConnectionString"].ConnectionString);
                setQuestionConn.Open();
                string setQuestionQuery = "Update T_USER_ACCOUNTS set SECRET_QUESTION = @newSecretQuestion, SECRET_ANSWER = @newSecretAnswer where EMAIL_ADDRESS = '" + Session["New"] + "'";
                SqlCommand changeQuestionCom = new SqlCommand(setQuestionQuery, setQuestionConn);
                changeQuestionCom.Parameters.AddWithValue("@newSecretQuestion", changeSecretQuestionList.SelectedItem.Text);
                changeQuestionCom.Parameters.AddWithValue("@newSecretAnswer", changeSecAnswerB.Text);
                changeQuestionCom.ExecuteNonQuery();
    
                InformationLabel.Text = "Secret question and answer updated!";

                setQuestionConn.Close();
            }
            catch (Exception er)
            {
                Response.Write("Error:" + er.ToString());
            }
        }


        protected void uploadPicBtn_Click(object sender, EventArgs e)
        {
            
            if (this.uploadPicFU.HasFile)
            {
                //String ext = System.IO.Path.GetExtension(this.uploadPicFU.PostedFile.FileName);
                String ext = System.IO.Path.GetExtension(uploadPicFU.FileName);
                //var FileExtension = Path.GetExtension(uploadPicFU.PostedFile.FileName).Substring(1);
                //String ext = FileExtension;

                if (ext.ToLower() == ".jpg" || ext.ToLower() == ".png" || ext.ToLower() == ".jpeg")
                //if (uploadPicFU.PostedFile.ContentType == "image/jpeg")
                {
                    try
                    {
                        /*  Delete Old Photo*/
                        string fullPath = Request.MapPath("~/Images/ProfilePictures/" + Session["New"] + ".jpg");
                        if (System.IO.File.Exists(fullPath))
                        {
                            System.IO.File.Delete(fullPath);
                        }
                        fullPath = Request.MapPath("~/Images/ProfilePictures/" + Session["New"] + ".jpeg");
                        if (System.IO.File.Exists(fullPath))
                        {
                            System.IO.File.Delete(fullPath);
                        }
                        fullPath = Request.MapPath("~/Images/ProfilePictures/" + Session["New"] + ".png");
                        if (System.IO.File.Exists(fullPath))
                        {
                            System.IO.File.Delete(fullPath);
                        }

                        uploadPicFU.SaveAs(Server.MapPath("~/Images/ProfilePictures/" + Session["New"] + ext));
                        string fileName = Path.GetFileName(this.uploadPicFU.PostedFile.FileName);
                        invalidUploadLbl.Visible = false;

                        Response.Redirect("ApplicantSettings.aspx");
                    }
                    catch (Exception)
                    {

                        Response.Write("<script>alert('Unable to upload profile picture.');</script>");
                    }
                    
                }
                else
                {
                    invalidUploadLbl.Visible = true;
                }

               
            }
        }

        protected void removePicBtn_Click(object sender, EventArgs e)
        {
            string fullPath = Request.MapPath("~/Images/ProfilePictures/" + Session["New"] + ".jpg");
            if (System.IO.File.Exists(fullPath))
            {
                System.IO.File.Delete(fullPath);
            }
            fullPath = Request.MapPath("~/Images/ProfilePictures/" + Session["New"] + ".jpeg");
            if (System.IO.File.Exists(fullPath))
            {
                System.IO.File.Delete(fullPath);
            }
            fullPath = Request.MapPath("~/Images/ProfilePictures/" + Session["New"] + ".png");
            if (System.IO.File.Exists(fullPath))
            {
                System.IO.File.Delete(fullPath);
            }
            Response.Redirect("ApplicantSettings.aspx");
        }

    }
}