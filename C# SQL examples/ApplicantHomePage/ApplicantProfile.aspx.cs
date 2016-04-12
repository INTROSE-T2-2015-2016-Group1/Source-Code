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
    public partial class ApplicantProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {     
            if (!IsPostBack)
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["erecruitmentConnectionString"].ConnectionString);
                conn.Open();

                String getInfoQuery = "select LAST_NAME from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"] + "' ";
                SqlCommand getInfoCom = new SqlCommand(getInfoQuery, conn);
                lastNameLbl.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select FIRST_NAME from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"] + "' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                firstNameLbl.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select MIDDLE_NAME from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"] + "' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                middleNameLbl.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select NICKNAME from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"] + "' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                nicknameLbl.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select SEX from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"] + "' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                sexLbl.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select CIVIL_STATUS from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"] + "' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                StatusList.SelectedValue = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select AGE from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"] + "' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                ageLbl.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select BIRTH_DATE from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"] + "' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                birthDateLbl.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select BIRTH_PLACE from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"] + "' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                birthPlaceLbl.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select NATIONALITY from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"] + "' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                nationalityTB.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select PRESENT_ADDRESS from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"] + "' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                presentAddressTB.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select PROV_ADDRESS from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"] + "' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                provAddressTB.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select EMAIL_ADDRESS from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"] + "' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                emailAddressLbl.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select CELLPHONE_NUM from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"] + "' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                cellNumTB.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select TELEPHONE_NUM from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"] + "' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                tellNumTB.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select TIN_NUM from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"] + "' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                tinNumTB.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select SSS_CODE from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"] + "' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                sssNumTB.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select PHIC_NUM from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"] + "' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                philHealthNumTB.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select LANGUAGES from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"] + "' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                languagesTB.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select HOBBIES from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"] + "' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                hobbiesTB.Text = getInfoCom.ExecuteScalar().ToString();

                /*          FAMILY BACKGROUND           */
                getInfoQuery = "select RELATIVE_LNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB1LName.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_FNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB1FName.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_MNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB1MI.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_BIRTHDATE from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB1Bday.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_EMP from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB1Emp.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_JOB from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB1Occ.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_RELATIONSHIP from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB1Relation.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_LNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB2LName.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_FNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB2FName.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_MNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB2MI.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_BIRTHDATE from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB2Bday.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_EMP from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB2Emp.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_JOB from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB2Occ.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_RELATIONSHIP from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB2Relation.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_LNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_3' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB3LName.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_FNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_3' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB3FName.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_MNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_3' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB3MI.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_BIRTHDATE from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_3' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB3Bday.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_EMP from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_3' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB3Emp.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_JOB from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_3' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB3Occ.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_RELATIONSHIP from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_3' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB3Relation.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_LNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_4' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB4LName.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_FNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_4' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB4FName.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_MNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_4' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB4MI.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_BIRTHDATE from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_4' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB4Bday.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_EMP from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_4' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB4Emp.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_JOB from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_4' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB4Occ.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_RELATIONSHIP from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_4' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB4Relation.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_LNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_5' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB5LName.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_FNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_5' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB5FName.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_MNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_5' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB5MI.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_BIRTHDATE from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_5' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB5Bday.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_EMP from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_5' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB5Emp.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_JOB from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_5' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB5Occ.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RELATIVE_RELATIONSHIP from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_5' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                FB5Relation.Text = getInfoCom.ExecuteScalar().ToString();

                /*          EDUCATIONAL BACKGROUND      */
                getInfoQuery = "select SCHOOL_NAME from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                EB1School.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select YEAR_STARTED from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                EB1YearStart.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select YEAR_GRADUATED from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                EB1YearGrad.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select ACCOMPLISHMENT from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                EB1Awards.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select SCHOOL_NAME from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                EB2School.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select YEAR_STARTED from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                EB2YearStart.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select YEAR_GRADUATED from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                EB2YearGrad.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select ACCOMPLISHMENT from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                EB2Awards.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select SCHOOL_NAME from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_3' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                EB3School.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select YEAR_STARTED from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_3' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                EB3YearStart.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select YEAR_GRADUATED from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_3' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                EB3YearGrad.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select ACCOMPLISHMENT from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_3' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                EB3Awards.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select SCHOOL_NAME from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_4' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                EB4School.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select YEAR_STARTED from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_4' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                EB4YearStart.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select YEAR_GRADUATED from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_4' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                EB4YearGrad.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select ACCOMPLISHMENT from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_4' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                EB4Awards.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select EXAM_NAME from T_USER_EDUBKGND_GOVTEST where EDUCATION_GOVTEST_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                GE1Exam.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select DATE_TAKEN from T_USER_EDUBKGND_GOVTEST where EDUCATION_GOVTEST_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                GE1Date.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RATING from T_USER_EDUBKGND_GOVTEST where EDUCATION_GOVTEST_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                GE1Rating.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select PROF_AFF from T_USER_EDUBKGND_GOVTEST where EDUCATION_GOVTEST_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                GE1ProfAff.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select POSITION from T_USER_EDUBKGND_GOVTEST where EDUCATION_GOVTEST_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                GE1Pos.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select EXAM_NAME from T_USER_EDUBKGND_GOVTEST where EDUCATION_GOVTEST_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                GE2Exam.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select DATE_TAKEN from T_USER_EDUBKGND_GOVTEST where EDUCATION_GOVTEST_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                GE2Date.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select RATING from T_USER_EDUBKGND_GOVTEST where EDUCATION_GOVTEST_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                GE2Rating.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select PROF_AFF from T_USER_EDUBKGND_GOVTEST where EDUCATION_GOVTEST_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                GE2ProfAff.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select POSITION from T_USER_EDUBKGND_GOVTEST where EDUCATION_GOVTEST_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                GE2Pos.Text = getInfoCom.ExecuteScalar().ToString();

                /*          WORK EXPERIENCE         */
                getInfoQuery = "select EMPLOYER_NAME from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                WE1EmpName.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select POSITION from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                WE1PosRank.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select START_DATE from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                WE1FromDate.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select END_DATE from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                WE1ToDate.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select REASON_FOR_LEAVING from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                WE1Reason.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select EMPLOYER_NAME from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                WE2EmpName.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select POSITION from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                WE2PosRank.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select START_DATE from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                WE2FromDate.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select END_DATE from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                WE2ToDate.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select REASON_FOR_LEAVING from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                WE2Reason.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select EMPLOYER_NAME from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_3' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                WE3EmpName.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select POSITION from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_3' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                WE3PosRank.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select START_DATE from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_3' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                WE3FromDate.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select END_DATE from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_3' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                WE3ToDate.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select REASON_FOR_LEAVING from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_3' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                WE3Reason.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select EMPLOYER_NAME from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_4' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                WE4EmpName.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select POSITION from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_4' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                WE4PosRank.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select START_DATE from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_4' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                WE4FromDate.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select END_DATE from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_4' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                WE4ToDate.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select REASON_FOR_LEAVING from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_4' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                WE4Reason.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select EMPLOYER_NAME from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_5' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                WE5EmpName.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select POSITION from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_5' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                WE5PosRank.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select START_DATE from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_5' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                WE5FromDate.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select END_DATE from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_5' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                WE5ToDate.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select REASON_FOR_LEAVING from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_5' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                WE5Reason.Text = getInfoCom.ExecuteScalar().ToString();

                /*      RELATIVES WHO ARE MAYBANK EMPLOYEES     */
                getInfoQuery = "select MAYBANK_EMP_NAME from T_USER_MAYBANK_EMP where MAYBANK_EMP_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                EM1Name.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select POSITION from T_USER_MAYBANK_EMP where MAYBANK_EMP_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                EM1Pos.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select NATURE_OF_RELATIONSHIP from T_USER_MAYBANK_EMP where MAYBANK_EMP_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                EM1Relation.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select MAYBANK_EMP_NAME from T_USER_MAYBANK_EMP where MAYBANK_EMP_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                EM2Name.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select POSITION from T_USER_MAYBANK_EMP where MAYBANK_EMP_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                EM2Pos.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select NATURE_OF_RELATIONSHIP from T_USER_MAYBANK_EMP where MAYBANK_EMP_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                EM2Relation.Text = getInfoCom.ExecuteScalar().ToString();
               
                /*         PROFESSIONAL REFERENCES      */
                getInfoQuery = "select REFERENCE_LNAME from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                CR1LName.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select REFERENCE_FNAME from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                CR1FName.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select REFERENCE_MI from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                CR1MI.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select DESIGNATION from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                CR1Pos.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select CONTACT_INFO from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_1' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                CR1Contact.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select REFERENCE_LNAME from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                CR2LName.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select REFERENCE_FNAME from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                CR2FName.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select REFERENCE_MI from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                CR2MI.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select DESIGNATION from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                CR2Pos.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select CONTACT_INFO from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_2' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                CR2Contact.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select REFERENCE_LNAME from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_3' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                CR3LName.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select REFERENCE_FNAME from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_3' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                CR3FName.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select REFERENCE_MI from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_3' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                CR3MI.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select DESIGNATION from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_3' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                CR3Pos.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select CONTACT_INFO from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_3' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                CR3Contact.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select REFERENCE_LNAME from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_4' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                CR4LName.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select REFERENCE_FNAME from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_4' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                CR4FName.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select REFERENCE_MI from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_4' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                CR4MI.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select DESIGNATION from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_4' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                CR4Pos.Text = getInfoCom.ExecuteScalar().ToString();

                getInfoQuery = "select CONTACT_INFO from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_4' ";
                getInfoCom = new SqlCommand(getInfoQuery, conn);
                CR4Contact.Text = getInfoCom.ExecuteScalar().ToString();

                conn.Close();
            }
        
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection changeInfoConn = new SqlConnection(ConfigurationManager.ConnectionStrings["erecruitmentConnectionString"].ConnectionString);
                changeInfoConn.Open();

                string setInfoQuery = "Update T_USER_ACCOUNTS set NATIONALITY = @NATIONALITY, PRESENT_ADDRESS = @PRESENT_ADDRESS, PROV_ADDRESS= @PROV_ADDRESS, CELLPHONE_NUM = @CELLPHONE_NUM, TELEPHONE_NUM = @TELEPHONE_NUM, SSS_CODE = @SSS_CODE, TIN_NUM = @TIN_NUM , PHIC_NUM = @PHIC_NUM, CIVIL_STATUS = @CIVIL_STATUS, LANGUAGES = @LANGUAGES, HOBBIES = @HOBBIES where EMAIL_ADDRESS = '" + Session["New"] + "' ";
                SqlCommand changeInfoCom = new SqlCommand(setInfoQuery, changeInfoConn);
                changeInfoCom.Parameters.AddWithValue("@NATIONALITY", nationalityTB.Text);
                changeInfoCom.Parameters.AddWithValue("@PRESENT_ADDRESS", presentAddressTB.Text);
                changeInfoCom.Parameters.AddWithValue("@PROV_ADDRESS", provAddressTB.Text);
                changeInfoCom.Parameters.AddWithValue("@CELLPHONE_NUM", cellNumTB.Text);
                changeInfoCom.Parameters.AddWithValue("@TELEPHONE_NUM", tellNumTB.Text);
                changeInfoCom.Parameters.AddWithValue("@TIN_NUM", tinNumTB.Text);
                changeInfoCom.Parameters.AddWithValue("@SSS_CODE", sssNumTB.Text);
                changeInfoCom.Parameters.AddWithValue("@PHIC_NUM", philHealthNumTB.Text);
                changeInfoCom.Parameters.AddWithValue("@CIVIL_STATUS", StatusList.SelectedValue);
                changeInfoCom.Parameters.AddWithValue("@LANGUAGES", languagesTB.Text);
                changeInfoCom.Parameters.AddWithValue("@HOBBIES", hobbiesTB.Text);
                changeInfoCom.ExecuteNonQuery();

                /*          UPDATE WORK EXPERIENCE      */
                setInfoQuery = "Update T_USER_WORKEXP set EMPLOYER_NAME = @EMPLOYER_NAME, POSITION= @POSITION, START_DATE= @START_DATE, END_DATE= @END_DATE, REASON_FOR_LEAVING= @REASON_FOR_LEAVING where EXPERIENCED_CODE = '" + Session["New"] + "_1' ";
                changeInfoCom = new SqlCommand(setInfoQuery, changeInfoConn);
                changeInfoCom.Parameters.AddWithValue("@EMPLOYER_NAME", WE1EmpName.Text);
                changeInfoCom.Parameters.AddWithValue("@POSITION", WE1PosRank.Text);
                changeInfoCom.Parameters.AddWithValue("@START_DATE", WE1FromDate.Text);
                changeInfoCom.Parameters.AddWithValue("@END_DATE", WE1ToDate.Text);
                changeInfoCom.Parameters.AddWithValue("@REASON_FOR_LEAVING", WE1Reason.Text);
                changeInfoCom.ExecuteNonQuery();

                setInfoQuery = "Update T_USER_WORKEXP set EMPLOYER_NAME = @EMPLOYER_NAME, POSITION= @POSITION, START_DATE= @START_DATE, END_DATE= @END_DATE, REASON_FOR_LEAVING= @REASON_FOR_LEAVING where EXPERIENCED_CODE = '" + Session["New"] + "_2' ";
                changeInfoCom = new SqlCommand(setInfoQuery, changeInfoConn);
                changeInfoCom.Parameters.AddWithValue("@EMPLOYER_NAME", WE2EmpName.Text);
                changeInfoCom.Parameters.AddWithValue("@POSITION", WE2PosRank.Text);
                changeInfoCom.Parameters.AddWithValue("@START_DATE", WE2FromDate.Text);
                changeInfoCom.Parameters.AddWithValue("@END_DATE", WE2ToDate.Text); 
                changeInfoCom.Parameters.AddWithValue("@REASON_FOR_LEAVING", WE2Reason.Text);
                changeInfoCom.ExecuteNonQuery();

                setInfoQuery = "Update T_USER_WORKEXP set EMPLOYER_NAME = @EMPLOYER_NAME, POSITION= @POSITION, START_DATE= @START_DATE, END_DATE= @END_DATE, REASON_FOR_LEAVING= @REASON_FOR_LEAVING where EXPERIENCED_CODE = '" + Session["New"] + "_3' ";
                changeInfoCom = new SqlCommand(setInfoQuery, changeInfoConn);
                changeInfoCom.Parameters.AddWithValue("@EMPLOYER_NAME", WE3EmpName.Text);
                changeInfoCom.Parameters.AddWithValue("@POSITION", WE3PosRank.Text);
                changeInfoCom.Parameters.AddWithValue("@START_DATE", WE3FromDate.Text);
                changeInfoCom.Parameters.AddWithValue("@END_DATE", WE3ToDate.Text); 
                changeInfoCom.Parameters.AddWithValue("@REASON_FOR_LEAVING", WE3Reason.Text);
                changeInfoCom.ExecuteNonQuery();

                setInfoQuery = "Update T_USER_WORKEXP set EMPLOYER_NAME = @EMPLOYER_NAME, POSITION= @POSITION, START_DATE= @START_DATE, END_DATE= @END_DATE, REASON_FOR_LEAVING= @REASON_FOR_LEAVING where EXPERIENCED_CODE = '" + Session["New"] + "_4' ";
                changeInfoCom = new SqlCommand(setInfoQuery, changeInfoConn);
                changeInfoCom.Parameters.AddWithValue("@EMPLOYER_NAME", WE4EmpName.Text);
                changeInfoCom.Parameters.AddWithValue("@POSITION", WE4PosRank.Text);
                changeInfoCom.Parameters.AddWithValue("@START_DATE", WE4FromDate.Text);
                changeInfoCom.Parameters.AddWithValue("@END_DATE", WE4ToDate.Text);
                changeInfoCom.Parameters.AddWithValue("@REASON_FOR_LEAVING", WE4Reason.Text);
                changeInfoCom.ExecuteNonQuery();

                setInfoQuery = "Update T_USER_WORKEXP set EMPLOYER_NAME = @EMPLOYER_NAME, POSITION= @POSITION, START_DATE= @START_DATE, END_DATE= @END_DATE, REASON_FOR_LEAVING= @REASON_FOR_LEAVING where EXPERIENCED_CODE = '" + Session["New"] + "_5' ";
                changeInfoCom = new SqlCommand(setInfoQuery, changeInfoConn);
                changeInfoCom.Parameters.AddWithValue("@EMPLOYER_NAME", WE5EmpName.Text);
                changeInfoCom.Parameters.AddWithValue("@POSITION", WE5PosRank.Text);
                changeInfoCom.Parameters.AddWithValue("@START_DATE", WE5FromDate.Text);
                changeInfoCom.Parameters.AddWithValue("@END_DATE", WE5ToDate.Text);
                changeInfoCom.Parameters.AddWithValue("@REASON_FOR_LEAVING", WE3Reason.Text);
                changeInfoCom.ExecuteNonQuery();

                /*          UPDATE EDUCATIONAL BACKGROUND       */
                setInfoQuery = "Update T_USER_EDUBKGND set SCHOOL_NAME= @SCHOOL_NAME, YEAR_STARTED= @YEAR_STARTED, YEAR_GRADUATED= @YEAR_GRADUATED, ACCOMPLISHMENT= @ACCOMPLISHMENT where EDUCATION_CODE = '" + Session["New"] + "_1' ";
                changeInfoCom = new SqlCommand(setInfoQuery, changeInfoConn);
                changeInfoCom.Parameters.AddWithValue("@SCHOOL_NAME", EB1School.Text);
                changeInfoCom.Parameters.AddWithValue("@YEAR_STARTED", EB1YearStart.Text);
                changeInfoCom.Parameters.AddWithValue("@YEAR_GRADUATED", EB1YearGrad.Text);
                changeInfoCom.Parameters.AddWithValue("@ACCOMPLISHMENT", EB1Awards.Text);
                changeInfoCom.ExecuteNonQuery();

                setInfoQuery = "Update T_USER_EDUBKGND set SCHOOL_NAME= @SCHOOL_NAME, YEAR_STARTED= @YEAR_STARTED, YEAR_GRADUATED= @YEAR_GRADUATED, ACCOMPLISHMENT= @ACCOMPLISHMENT where EDUCATION_CODE = '" + Session["New"] + "_2' ";
                changeInfoCom = new SqlCommand(setInfoQuery, changeInfoConn);
                changeInfoCom.Parameters.AddWithValue("@SCHOOL_NAME", EB2School.Text);
                changeInfoCom.Parameters.AddWithValue("@YEAR_STARTED", EB2YearStart.Text);
                changeInfoCom.Parameters.AddWithValue("@YEAR_GRADUATED", EB2YearGrad.Text);
                changeInfoCom.Parameters.AddWithValue("@ACCOMPLISHMENT", EB2Awards.Text);
                changeInfoCom.ExecuteNonQuery();

                setInfoQuery = "Update T_USER_EDUBKGND set SCHOOL_NAME= @SCHOOL_NAME, YEAR_STARTED= @YEAR_STARTED, YEAR_GRADUATED= @YEAR_GRADUATED, ACCOMPLISHMENT= @ACCOMPLISHMENT where EDUCATION_CODE = '" + Session["New"] + "_3' ";
                changeInfoCom = new SqlCommand(setInfoQuery, changeInfoConn);
                changeInfoCom.Parameters.AddWithValue("@SCHOOL_NAME", EB3School.Text);
                changeInfoCom.Parameters.AddWithValue("@YEAR_STARTED", EB3YearStart.Text);
                changeInfoCom.Parameters.AddWithValue("@YEAR_GRADUATED", EB3YearGrad.Text);
                changeInfoCom.Parameters.AddWithValue("@ACCOMPLISHMENT", EB3Awards.Text);
                changeInfoCom.ExecuteNonQuery();

                setInfoQuery = "Update T_USER_EDUBKGND set SCHOOL_NAME= @SCHOOL_NAME, YEAR_STARTED= @YEAR_STARTED, YEAR_GRADUATED= @YEAR_GRADUATED, ACCOMPLISHMENT= @ACCOMPLISHMENT where EDUCATION_CODE = '" + Session["New"] + "_4' ";
                changeInfoCom = new SqlCommand(setInfoQuery, changeInfoConn);
                changeInfoCom.Parameters.AddWithValue("@SCHOOL_NAME", EB4School.Text);
                changeInfoCom.Parameters.AddWithValue("@YEAR_STARTED", EB4YearStart.Text);
                changeInfoCom.Parameters.AddWithValue("@YEAR_GRADUATED", EB4YearGrad.Text);
                changeInfoCom.Parameters.AddWithValue("@ACCOMPLISHMENT", EB4Awards.Text);
                changeInfoCom.ExecuteNonQuery();

                setInfoQuery = "Update T_USER_EDUBKGND_GOVTEST set EXAM_NAME= @EXAM_NAME, DATE_TAKEN= @DATE_TAKEN, RATING= @RATING, PROF_AFF= @PROF_AFF, POSITION= @POSITION where EDUCATION_GOVTEST_CODE = '" + Session["New"] + "_1' ";
                changeInfoCom = new SqlCommand(setInfoQuery, changeInfoConn);
                changeInfoCom.Parameters.AddWithValue("@EXAM_NAME", GE1Exam.Text);
                changeInfoCom.Parameters.AddWithValue("@DATE_TAKEN", GE1Date.Text);
                changeInfoCom.Parameters.AddWithValue("@RATING", GE1Rating.Text);
                changeInfoCom.Parameters.AddWithValue("@PROF_AFF", GE1ProfAff.Text);
                changeInfoCom.Parameters.AddWithValue("@POSITION", GE1Pos.Text);
                changeInfoCom.ExecuteNonQuery();

                setInfoQuery = "Update T_USER_EDUBKGND_GOVTEST set EXAM_NAME= @EXAM_NAME, DATE_TAKEN= @DATE_TAKEN, RATING= @RATING, PROF_AFF= @PROF_AFF, POSITION= @POSITION where EDUCATION_GOVTEST_CODE = '" + Session["New"] + "_2' ";
                changeInfoCom = new SqlCommand(setInfoQuery, changeInfoConn);
                changeInfoCom.Parameters.AddWithValue("@EXAM_NAME", GE2Exam.Text);
                changeInfoCom.Parameters.AddWithValue("@DATE_TAKEN", GE2Date.Text);
                changeInfoCom.Parameters.AddWithValue("@RATING", GE2Rating.Text);
                changeInfoCom.Parameters.AddWithValue("@PROF_AFF", GE2ProfAff.Text);
                changeInfoCom.Parameters.AddWithValue("@POSITION", GE2Pos.Text);
                changeInfoCom.ExecuteNonQuery();

                /*          UPDATE FAMILY BACKGROUND        */
                setInfoQuery = "Update T_USER_FMLYBCK set RELATIVE_LNAME= @RELATIVE_LNAME, RELATIVE_FNAME= @RELATIVE_FNAME, RELATIVE_MNAME= @RELATIVE_MNAME, RELATIVE_BIRTHDATE= @RELATIVE_BIRTHDATE, RELATIVE_EMP = @RELATIVE_EMP, RELATIVE_JOB = @RELATIVE_JOB, RELATIVE_RELATIONSHIP= @RELATIVE_RELATIONSHIP where FAMILY_CODE= '" + Session["New"] + "_1' ";
                changeInfoCom = new SqlCommand(setInfoQuery, changeInfoConn);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_LNAME", FB1LName.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_FNAME", FB1FName.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_MNAME", FB1MI.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_BIRTHDATE", FB1Bday.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_EMP", FB1Emp.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_JOB", FB1Occ.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_RELATIONSHIP", FB1Relation.Text);
                changeInfoCom.ExecuteNonQuery();

                setInfoQuery = "Update T_USER_FMLYBCK set RELATIVE_LNAME= @RELATIVE_LNAME, RELATIVE_FNAME= @RELATIVE_FNAME, RELATIVE_MNAME= @RELATIVE_MNAME, RELATIVE_BIRTHDATE= @RELATIVE_BIRTHDATE, RELATIVE_EMP = @RELATIVE_EMP, RELATIVE_JOB = @RELATIVE_JOB, RELATIVE_RELATIONSHIP= @RELATIVE_RELATIONSHIP where FAMILY_CODE= '" + Session["New"] + "_2' ";
                changeInfoCom = new SqlCommand(setInfoQuery, changeInfoConn);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_LNAME", FB2LName.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_FNAME", FB2FName.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_MNAME", FB2MI.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_BIRTHDATE", FB2Bday.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_EMP", FB2Emp.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_JOB", FB2Occ.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_RELATIONSHIP", FB2Relation.Text);
                changeInfoCom.ExecuteNonQuery();

                setInfoQuery = "Update T_USER_FMLYBCK set RELATIVE_LNAME= @RELATIVE_LNAME, RELATIVE_FNAME= @RELATIVE_FNAME, RELATIVE_MNAME= @RELATIVE_MNAME, RELATIVE_BIRTHDATE= @RELATIVE_BIRTHDATE, RELATIVE_EMP = @RELATIVE_EMP, RELATIVE_JOB = @RELATIVE_JOB, RELATIVE_RELATIONSHIP= @RELATIVE_RELATIONSHIP where FAMILY_CODE= '" + Session["New"] + "_3' ";
                changeInfoCom = new SqlCommand(setInfoQuery, changeInfoConn);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_LNAME", FB3LName.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_FNAME", FB3FName.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_MNAME", FB3MI.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_BIRTHDATE", FB3Bday.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_EMP", FB3Emp.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_JOB", FB3Occ.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_RELATIONSHIP", FB3Relation.Text);
                changeInfoCom.ExecuteNonQuery();

                setInfoQuery = "Update T_USER_FMLYBCK set RELATIVE_LNAME= @RELATIVE_LNAME, RELATIVE_FNAME= @RELATIVE_FNAME, RELATIVE_MNAME= @RELATIVE_MNAME, RELATIVE_BIRTHDATE= @RELATIVE_BIRTHDATE, RELATIVE_EMP = @RELATIVE_EMP, RELATIVE_JOB = @RELATIVE_JOB, RELATIVE_RELATIONSHIP= @RELATIVE_RELATIONSHIP where FAMILY_CODE= '" + Session["New"] + "_4' ";
                changeInfoCom = new SqlCommand(setInfoQuery, changeInfoConn);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_LNAME", FB4LName.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_FNAME", FB4FName.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_MNAME", FB4MI.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_BIRTHDATE", FB4Bday.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_EMP", FB4Emp.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_JOB", FB4Occ.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_RELATIONSHIP", FB4Relation.Text);
                changeInfoCom.ExecuteNonQuery();

                setInfoQuery = "Update T_USER_FMLYBCK set RELATIVE_LNAME= @RELATIVE_LNAME, RELATIVE_FNAME= @RELATIVE_FNAME, RELATIVE_MNAME= @RELATIVE_MNAME, RELATIVE_BIRTHDATE= @RELATIVE_BIRTHDATE, RELATIVE_EMP = @RELATIVE_EMP, RELATIVE_JOB = @RELATIVE_JOB, RELATIVE_RELATIONSHIP= @RELATIVE_RELATIONSHIP where FAMILY_CODE= '" + Session["New"] + "_5' ";
                changeInfoCom = new SqlCommand(setInfoQuery, changeInfoConn);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_LNAME", FB5LName.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_FNAME", FB5FName.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_MNAME", FB5MI.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_BIRTHDATE", FB5Bday.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_EMP", FB5Emp.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_JOB", FB5Occ.Text);
                changeInfoCom.Parameters.AddWithValue("@RELATIVE_RELATIONSHIP", FB5Relation.Text);
                changeInfoCom.ExecuteNonQuery();

                /*          UPDATE RELATIVES WORKING IN MAYBANK     */
                setInfoQuery = "Update T_USER_MAYBANK_EMP set MAYBANK_EMP_NAME= @NAME, POSITION= @POSITION, NATURE_OF_RELATIONSHIP= @NATURE_OF_RELATIONSHIP where MAYBANK_EMP_CODE = '" + Session["New"] + "_1' ";
                changeInfoCom = new SqlCommand(setInfoQuery, changeInfoConn);
                changeInfoCom.Parameters.AddWithValue("@NAME", EM1Name.Text);
                changeInfoCom.Parameters.AddWithValue("@POSITION", EM1Pos.Text);
                changeInfoCom.Parameters.AddWithValue("@NATURE_OF_RELATIONSHIP", EM1Relation.Text);
                changeInfoCom.ExecuteNonQuery();

                setInfoQuery = "Update T_USER_MAYBANK_EMP set MAYBANK_EMP_NAME= @NAME, POSITION= @POSITION, NATURE_OF_RELATIONSHIP= @NATURE_OF_RELATIONSHIP where MAYBANK_EMP_CODE = '" + Session["New"] + "_2' ";
                changeInfoCom = new SqlCommand(setInfoQuery, changeInfoConn);
                changeInfoCom.Parameters.AddWithValue("@NAME", EM2Name.Text);
                changeInfoCom.Parameters.AddWithValue("@POSITION", EM2Pos.Text);
                changeInfoCom.Parameters.AddWithValue("@NATURE_OF_RELATIONSHIP", EM2Relation.Text);
                changeInfoCom.ExecuteNonQuery();


                /*          UPDATE PROFESSIONAL REFERENCES        */
                setInfoQuery = "Update T_USER_PERSREF set REFERENCE_LNAME= @REFERENCE_LNAME, REFERENCE_FNAME= @REFERENCE_FNAME, REFERENCE_MI= @REFERENCE_MI, DESIGNATION= @DESIGNATION, CONTACT_INFO= @CONTACT_INFO where REFERENCE_CODE= '" + Session["New"] + "_1' ";
                changeInfoCom = new SqlCommand(setInfoQuery, changeInfoConn);
                changeInfoCom.Parameters.AddWithValue("@REFERENCE_LNAME", CR1LName.Text);
                changeInfoCom.Parameters.AddWithValue("@REFERENCE_FNAME", CR1FName.Text);
                changeInfoCom.Parameters.AddWithValue("@REFERENCE_MI", CR1MI.Text);
                changeInfoCom.Parameters.AddWithValue("@DESIGNATION", CR1Pos.Text);
                changeInfoCom.Parameters.AddWithValue("@CONTACT_INFO", CR1Contact.Text);
                changeInfoCom.ExecuteNonQuery();

                setInfoQuery = "Update T_USER_PERSREF set REFERENCE_LNAME= @REFERENCE_LNAME, REFERENCE_FNAME= @REFERENCE_FNAME, REFERENCE_MI= @REFERENCE_MI, DESIGNATION= @DESIGNATION, CONTACT_INFO= @CONTACT_INFO where REFERENCE_CODE= '" + Session["New"] + "_2' ";
                changeInfoCom = new SqlCommand(setInfoQuery, changeInfoConn);
                changeInfoCom.Parameters.AddWithValue("@REFERENCE_LNAME", CR2LName.Text);
                changeInfoCom.Parameters.AddWithValue("@REFERENCE_FNAME", CR2FName.Text);
                changeInfoCom.Parameters.AddWithValue("@REFERENCE_MI", CR2MI.Text);
                changeInfoCom.Parameters.AddWithValue("@DESIGNATION", CR2Pos.Text);
                changeInfoCom.Parameters.AddWithValue("@CONTACT_INFO", CR2Contact.Text);
                changeInfoCom.ExecuteNonQuery();

                setInfoQuery = "Update T_USER_PERSREF set REFERENCE_LNAME= @REFERENCE_LNAME, REFERENCE_FNAME= @REFERENCE_FNAME, REFERENCE_MI= @REFERENCE_MI, DESIGNATION= @DESIGNATION, CONTACT_INFO= @CONTACT_INFO where REFERENCE_CODE= '" + Session["New"] + "_3' ";
                changeInfoCom = new SqlCommand(setInfoQuery, changeInfoConn);
                changeInfoCom.Parameters.AddWithValue("@REFERENCE_LNAME", CR3LName.Text);
                changeInfoCom.Parameters.AddWithValue("@REFERENCE_FNAME", CR3FName.Text);
                changeInfoCom.Parameters.AddWithValue("@REFERENCE_MI", CR3MI.Text);
                changeInfoCom.Parameters.AddWithValue("@DESIGNATION", CR3Pos.Text);
                changeInfoCom.Parameters.AddWithValue("@CONTACT_INFO", CR3Contact.Text);
                changeInfoCom.ExecuteNonQuery();

                setInfoQuery = "Update T_USER_PERSREF set REFERENCE_LNAME= @REFERENCE_LNAME, REFERENCE_FNAME= @REFERENCE_FNAME, REFERENCE_MI= @REFERENCE_MI, DESIGNATION= @DESIGNATION, CONTACT_INFO= @CONTACT_INFO where REFERENCE_CODE= '" + Session["New"] + "_4' ";
                changeInfoCom = new SqlCommand(setInfoQuery, changeInfoConn);
                changeInfoCom.Parameters.AddWithValue("@REFERENCE_LNAME", CR4LName.Text);
                changeInfoCom.Parameters.AddWithValue("@REFERENCE_FNAME", CR4FName.Text);
                changeInfoCom.Parameters.AddWithValue("@REFERENCE_MI", CR4MI.Text);
                changeInfoCom.Parameters.AddWithValue("@DESIGNATION", CR4Pos.Text);
                changeInfoCom.Parameters.AddWithValue("@CONTACT_INFO", CR4Contact.Text);
                changeInfoCom.ExecuteNonQuery();

                changeInfoConn.Close();
            }
            catch (Exception er)
            {
                Response.Write("Error:" + er.ToString());
            }
        }

    }
}