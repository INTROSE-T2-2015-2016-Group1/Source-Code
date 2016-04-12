using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace eRecruitment.Application.ApplicantHomePage
{
    public partial class CurrentApplications : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetCacheability(HttpCacheability.Public);

            if (GridView1.Rows.Count == 0)
            {
                NoCurrentAppLbl.Visible = true;
            }

            if (!IsPostBack)
            {
                int total = GridView1.Rows.Count;
                int i;

                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["erecruitmentConnectionString"].ConnectionString);
                con.Open();
                for (i = 0; i < total; i++)
                {
                    string selectQuery = "Select STATUS_CODE from T_APPLICATION_INFO where APPLICATION_CODE = '" + GridView1.Rows[i].Cells[0].Text + "'";
                    SqlCommand getInfoCom = new SqlCommand(selectQuery, con);
                    if (getInfoCom.ExecuteScalar().ToString() == "W")
                    {
                        GridView1.Rows[i].Cells[5].Visible = false;
                        GridView1.Rows[i].Cells[3].Text = "Withdrawn";
                    }
                }
                con.Close();
            }
        }
        
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "withdrawCom")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];

                SqlConnection changeInfoConn = new SqlConnection(ConfigurationManager.ConnectionStrings["erecruitmentConnectionString"].ConnectionString);
                changeInfoConn.Open();

                string selectQuery = "Select STATUS_CODE from T_APPLICATION_INFO where APPLICATION_CODE = '" + row.Cells[0].Text + "'";
                SqlCommand getInfoCom = new SqlCommand(selectQuery, changeInfoConn);
                if (getInfoCom.ExecuteScalar().ToString() != "W")
                {
                    string setInfoQuery = "Update T_APPLICATION_INFO set STATUS_CODE = @STATUS_CODE where APPLICATION_CODE = '" + row.Cells[0].Text + "' ";
                    SqlCommand changeInfoCom = new SqlCommand(setInfoQuery, changeInfoConn);
                    changeInfoCom.Parameters.AddWithValue("@STATUS_CODE", "W");
                    changeInfoCom.ExecuteNonQuery();
                    Response.Redirect(Request.RawUrl);
                }
                else
                {
                    Response.Write("<script>alert('You already withdrew from this position.');</script>");
                }
                changeInfoConn.Close();
            }
        }
         
    }

}