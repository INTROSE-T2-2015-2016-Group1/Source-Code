
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
    public partial class Vacancies : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            alreadyAppliedLbl.Visible = false;
            invalidApplyLbl1.Visible = false;
            invalidApplyLbl2.Visible = false;
            invalidApplyLbl3.Visible = false;
            invalidApplyLbl4.Visible = false;
            invalidApplyLbl5.Visible = false;
            
        }

        protected void DDLDepartments(object sender, EventArgs e)
        {
            departmentDDL.Items.Insert(0, new ListItem("All Departments", "0"));
        }
        protected void departmentDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["dept"] = departmentDDL.SelectedItem.Value;
            if (departmentDDL.SelectedItem.Value == "0")
            {

            }
        }

        protected string getApplicationCode()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["erecruitmentConnectionString"].ConnectionString);
            conn.Open();
            string applicationCodeQuery = "select APPLICATION_CODE from T_APPLICATION_INFO where EMAIL_ADDRESS = '" + Session["New"].ToString() + "' and POSITION = '" + PositionsDDL.SelectedItem.Text + "' and STATUS_CODE = 'N'";
            SqlCommand applicationCodeCom = new SqlCommand(applicationCodeQuery, conn);
            string applicationCode = applicationCodeCom.ExecuteScalar().ToString();
            conn.Close();
            return applicationCode;
        }

        protected void updatePersonalInfoDB()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["erecruitmentConnectionString"].ConnectionString);

            string applicationCode = getApplicationCode();

            string lastNameQuery = "select LAST_NAME from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"].ToString() + "'";
            string firstNameQuery = "select FIRST_NAME from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"].ToString() + "'";
            string middleNameQuery = "select MIDDLE_NAME from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"].ToString() + "'";
            string nicknameQuery = "select NICKNAME from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"].ToString() + "'";
            string presentAddressQuery = "select PRESENT_ADDRESS from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"].ToString() + "'";
            string provAddressQuery = "select PROV_ADDRESS from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"].ToString() + "'";
            string birthDateQuery = "select BIRTH_DATE from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"].ToString() + "'";
            string birthPlaceQuery = "select BIRTH_PLACE from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"].ToString() + "'";
            string nationalityQuery = "select NATIONALITY from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"].ToString() + "'";
            string cellphoneNumberQuery = "select CELLPHONE_NUM from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"].ToString() + "'";
            string telephoneNumberQuery = "select TELEPHONE_NUM from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"].ToString() + "'";
            string sssCodeQuery = "select SSS_Code from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"].ToString() + "'";
            string tinNumQuery = "select TIN_NUM from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"].ToString() + "'";
            string phicNumQuery = "select PHIC_NUM from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"].ToString() + "'";
            string ageQuery = "select AGE from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"].ToString() + "'";
            string civilStatusQuery = "select CIVIL_STATUS from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"].ToString() + "'";
            string sexQuery = "select SEX from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"].ToString() + "'";
            string languagesQuery = "select LANGUAGES from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"].ToString() + "'";
            string hobbiesQuery = "select HOBBIES from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"].ToString() + "'";
            string filePathQuery = "select FILE_PATH from T_USER_ACCOUNTS where EMAIL_ADDRESS = '" + Session["New"].ToString() + "'";

            conn.Open();
            SqlCommand lastNameCom = new SqlCommand(lastNameQuery, conn);
            String lastName = lastNameCom.ExecuteScalar().ToString();
            SqlCommand firstNameCom = new SqlCommand(firstNameQuery, conn);
            String firstName = firstNameCom.ExecuteScalar().ToString();
            SqlCommand middleNameCom = new SqlCommand(middleNameQuery, conn);
            String middleName = middleNameCom.ExecuteScalar().ToString();
            SqlCommand nicknameCom = new SqlCommand(nicknameQuery, conn);
            String nickname = nicknameCom.ExecuteScalar().ToString();
            SqlCommand presentAddressCom = new SqlCommand(presentAddressQuery, conn);
            String presentAddress = presentAddressCom.ExecuteScalar().ToString();
            SqlCommand provAddressCom = new SqlCommand(provAddressQuery, conn);
            String provAddress = provAddressCom.ExecuteScalar().ToString();
            SqlCommand birthDateCom = new SqlCommand(birthDateQuery, conn);
            String birthDate = birthDateCom.ExecuteScalar().ToString();
            SqlCommand birthPlaceCom = new SqlCommand(birthPlaceQuery, conn);
            String birthPlace = birthPlaceCom.ExecuteScalar().ToString();
            SqlCommand nationalityCom = new SqlCommand(nationalityQuery, conn);
            String nationality = nationalityCom.ExecuteScalar().ToString();

            long cellphoneNumber;
            long telephoneNumber;
            int sssCode;
            int tinNum;
            int phicNum;
            int age;

            try
            {
                SqlCommand cellphoneNumberCom = new SqlCommand(cellphoneNumberQuery, conn);
                cellphoneNumber = Convert.ToInt64(cellphoneNumberCom.ExecuteScalar().ToString());
            }
            catch (Exception)
            {

                cellphoneNumber = 0;
            }

            try
            {
                SqlCommand telephoneNumberCom = new SqlCommand(telephoneNumberQuery, conn);
                telephoneNumber = Convert.ToInt64(telephoneNumberCom.ExecuteScalar().ToString());
            }
            catch (Exception)
            {

                telephoneNumber = 0;
            }

            try
            {
                SqlCommand sssCodeCom = new SqlCommand(sssCodeQuery, conn);
                sssCode = Convert.ToInt32(sssCodeCom.ExecuteScalar().ToString());
            }
            catch (Exception)
            {

                sssCode = 0;
            }

            try
            {
                SqlCommand tinNumCom = new SqlCommand(tinNumQuery, conn);
                tinNum = Convert.ToInt32(tinNumCom.ExecuteScalar().ToString());
            }
            catch (Exception)
            {

                tinNum = 0;
            }

            try
            {
                SqlCommand phicNumCom = new SqlCommand(phicNumQuery, conn);
                phicNum = Convert.ToInt32(phicNumCom.ExecuteScalar().ToString());
            }
            catch (Exception)
            {

                phicNum = 0;
            }

            try
            {
                SqlCommand ageCom = new SqlCommand(ageQuery, conn);
                age = Convert.ToInt32(ageCom.ExecuteScalar().ToString());
            }
            catch (Exception)
            {

                age = 0;
            }

            SqlCommand civilStatusCom = new SqlCommand(civilStatusQuery, conn);
            String civilStatus = civilStatusCom.ExecuteScalar().ToString();
            SqlCommand sexCom = new SqlCommand(sexQuery, conn);
            String sex = sexCom.ExecuteScalar().ToString();
            SqlCommand languagesCom = new SqlCommand(languagesQuery, conn);
            String languages = languagesCom.ExecuteScalar().ToString();
            SqlCommand hobbiesCom = new SqlCommand(hobbiesQuery, conn);
            String hobbies = hobbiesCom.ExecuteScalar().ToString();
            SqlCommand filePathCom = new SqlCommand(filePathQuery, conn);
            String filePath = filePathCom.ExecuteScalar().ToString();

            string insertQuery = "insert into T_PERSONAL_INFO (APPLICATION_CODE, LAST_NAME, FIRST_NAME, MIDDLE_NAME, NICKNAME, PRESENT_ADDRESS, PROV_ADDRESS, BIRTH_DATE, BIRTH_PLACE, NATIONALITY, CELLPHONE_NUM, TELEPHONE_NUM, EMAIL_ADDRESS, SSS_CODE, TIN_NUM, PHIC_NUM, AGE, CIVIL_STATUS, SEX, LANGUAGES, HOBBIES, FILE_PATH) values (@APPLICATION_CODE, @LAST_NAME, @FIRST_NAME, @MIDDLE_NAME, @NICKNAME, @PRESENT_ADDRESS, @PROV_ADDRESS, @BIRTH_DATE, @BIRTH_PLACE, @NATIONALITY, @CELLPHONE_NUM, @TELEPHONE_NUM, @EMAIL_ADDRESS, @SSS_CODE, @TIN_NUM, @PHIC_NUM, @AGE, @CIVIL_STATUS, @SEX, @LANGUAGES, @HOBBIES, @FILE_PATH)";
            SqlCommand updatePICom = new SqlCommand(insertQuery, conn);
            updatePICom.Parameters.AddWithValue("@APPLICATION_CODE", applicationCode);
            updatePICom.Parameters.AddWithValue("@LAST_NAME",lastName);
            updatePICom.Parameters.AddWithValue("@FIRST_NAME",firstName);
            updatePICom.Parameters.AddWithValue("@MIDDLE_NAME",middleName);
            updatePICom.Parameters.AddWithValue("@NICKNAME",nickname);
            updatePICom.Parameters.AddWithValue("@PRESENT_ADDRESS",presentAddress);
            updatePICom.Parameters.AddWithValue("@PROV_ADDRESS",provAddress);
            updatePICom.Parameters.AddWithValue("@BIRTH_DATE",birthDate);
            updatePICom.Parameters.AddWithValue("@BIRTH_PLACE", birthPlace);
            updatePICom.Parameters.AddWithValue("@NATIONALITY",nationality);
            updatePICom.Parameters.AddWithValue("@CELLPHONE_NUM",cellphoneNumber);
            updatePICom.Parameters.AddWithValue("@TELEPHONE_NUM",telephoneNumber);
            updatePICom.Parameters.AddWithValue("@EMAIL_ADDRESS",Session["New"].ToString());
            updatePICom.Parameters.AddWithValue("@SSS_CODE",sssCode);
            updatePICom.Parameters.AddWithValue("@TIN_NUM",tinNum);
            updatePICom.Parameters.AddWithValue("@PHIC_NUM",phicNum);
            updatePICom.Parameters.AddWithValue("@AGE",age);
            updatePICom.Parameters.AddWithValue("@CIVIL_STATUS",civilStatus);
            updatePICom.Parameters.AddWithValue("@SEX",sex);
            updatePICom.Parameters.AddWithValue("@LANGUAGES",languages);
            updatePICom.Parameters.AddWithValue("@HOBBIES",hobbies);
            updatePICom.Parameters.AddWithValue("@FILE_PATH",filePath);
            updatePICom.ExecuteNonQuery();

            conn.Close();
        }

        protected void updateEducationalBackground()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["erecruitmentConnectionString"].ConnectionString);

            string applicationCode = getApplicationCode();

            conn.Open();

            /*          1. GET EDUCATIONAL BACKGROUND          */
            string getInfoQuery = "select SCHOOL_NAME from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_1' ";
            SqlCommand getInfoCom = new SqlCommand(getInfoQuery, conn);
            string school = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select COURSE from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string course = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select YEAR_STARTED from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string yearStart = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select YEAR_GRADUATED from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string yearGrad = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select ACCOMPLISHMENT from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string awards = getInfoCom.ExecuteScalar().ToString();

            /*          1. UPDATE EDUCATIONAL BACKGROUND       */
            string insertQuery = "insert into T_EDUCATIONAL_BACKGRND (APPLICATION_CODE, EDUCATION_CODE, SCHOOL_NAME, COURSE, YEAR_STARTED, YEAR_GRADUATED, ACCOMPLISHMENT) values (@APPLICATION_CODE, @EDUCATION_CODE, @SCHOOL_NAME, @COURSE, @YEAR_STARTED, @YEAR_GRADUATED, @ACCOMPLISHMENT)";
            SqlCommand updateEBCom = new SqlCommand(insertQuery, conn);
            updateEBCom.Parameters.AddWithValue("@APPLICATION_CODE",applicationCode);
            updateEBCom.Parameters.AddWithValue("@EDUCATION_CODE", applicationCode + "001");
            updateEBCom.Parameters.AddWithValue("@SCHOOL_NAME",school);
            updateEBCom.Parameters.AddWithValue("@COURSE",course);
            updateEBCom.Parameters.AddWithValue("@YEAR_STARTED", yearStart);
            updateEBCom.Parameters.AddWithValue("@YEAR_GRADUATED",yearGrad);
            updateEBCom.Parameters.AddWithValue("@ACCOMPLISHMENT",awards);
            updateEBCom.ExecuteNonQuery();

            /*          2. GET EDUCATIONAL BACKGROUND          */
            getInfoQuery = "select SCHOOL_NAME from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            school = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select COURSE from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            course = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select YEAR_STARTED from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            yearStart = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select YEAR_GRADUATED from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            yearGrad = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select ACCOMPLISHMENT from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            awards = getInfoCom.ExecuteScalar().ToString();

            /*          2. UPDATE EDUCATIONAL BACKGROUND       */
            insertQuery = "insert into T_EDUCATIONAL_BACKGRND (APPLICATION_CODE, EDUCATION_CODE, SCHOOL_NAME, COURSE, YEAR_STARTED, YEAR_GRADUATED, ACCOMPLISHMENT) values (@APPLICATION_CODE, @EDUCATION_CODE, @SCHOOL_NAME, @COURSE, @YEAR_STARTED, @YEAR_GRADUATED, @ACCOMPLISHMENT)";
            updateEBCom = new SqlCommand(insertQuery, conn);
            updateEBCom.Parameters.AddWithValue("@APPLICATION_CODE", applicationCode);
            updateEBCom.Parameters.AddWithValue("@EDUCATION_CODE", applicationCode + "002");
            updateEBCom.Parameters.AddWithValue("@SCHOOL_NAME", school);
            updateEBCom.Parameters.AddWithValue("@COURSE", course);
            updateEBCom.Parameters.AddWithValue("@YEAR_STARTED", yearStart);
            updateEBCom.Parameters.AddWithValue("@YEAR_GRADUATED", yearGrad);
            updateEBCom.Parameters.AddWithValue("@ACCOMPLISHMENT", awards);
            updateEBCom.ExecuteNonQuery();

            /*          3. GET EDUCATIONAL BACKGROUND          */
            getInfoQuery = "select SCHOOL_NAME from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_3' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            school = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select COURSE from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_3' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            course = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select YEAR_STARTED from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_3' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            yearStart = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select YEAR_GRADUATED from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_3' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            yearGrad = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select ACCOMPLISHMENT from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_3' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            awards = getInfoCom.ExecuteScalar().ToString();

            /*          3. UPDATE EDUCATIONAL BACKGROUND       */
            insertQuery = "insert into T_EDUCATIONAL_BACKGRND (APPLICATION_CODE, EDUCATION_CODE, SCHOOL_NAME, COURSE, YEAR_STARTED, YEAR_GRADUATED, ACCOMPLISHMENT) values (@APPLICATION_CODE, @EDUCATION_CODE, @SCHOOL_NAME, @COURSE, @YEAR_STARTED, @YEAR_GRADUATED, @ACCOMPLISHMENT)";
            updateEBCom = new SqlCommand(insertQuery, conn);
            updateEBCom.Parameters.AddWithValue("@APPLICATION_CODE", applicationCode);
            updateEBCom.Parameters.AddWithValue("@EDUCATION_CODE", applicationCode + "003");
            updateEBCom.Parameters.AddWithValue("@SCHOOL_NAME", school);
            updateEBCom.Parameters.AddWithValue("@COURSE", course);
            updateEBCom.Parameters.AddWithValue("@YEAR_STARTED", yearStart);
            updateEBCom.Parameters.AddWithValue("@YEAR_GRADUATED", yearGrad);
            updateEBCom.Parameters.AddWithValue("@ACCOMPLISHMENT", awards);
            updateEBCom.ExecuteNonQuery();

            /*          4. GET EDUCATIONAL BACKGROUND          */
            getInfoQuery = "select SCHOOL_NAME from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_4' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            school = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select COURSE from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_4' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            course = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select YEAR_STARTED from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_4' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            yearStart = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select YEAR_GRADUATED from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_4' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            yearGrad = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select ACCOMPLISHMENT from T_USER_EDUBKGND where EDUCATION_CODE = '" + Session["New"] + "_4' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            awards = getInfoCom.ExecuteScalar().ToString();

            /*          4. UPDATE EDUCATIONAL BACKGROUND       */
            insertQuery = "insert into T_EDUCATIONAL_BACKGRND (APPLICATION_CODE, EDUCATION_CODE, SCHOOL_NAME, COURSE, YEAR_STARTED, YEAR_GRADUATED, ACCOMPLISHMENT) values (@APPLICATION_CODE, @EDUCATION_CODE, @SCHOOL_NAME, @COURSE, @YEAR_STARTED, @YEAR_GRADUATED, @ACCOMPLISHMENT)";
            updateEBCom = new SqlCommand(insertQuery, conn);
            updateEBCom.Parameters.AddWithValue("@APPLICATION_CODE", applicationCode);
            updateEBCom.Parameters.AddWithValue("@EDUCATION_CODE", applicationCode + "004");
            updateEBCom.Parameters.AddWithValue("@SCHOOL_NAME", school);
            updateEBCom.Parameters.AddWithValue("@COURSE", course);
            updateEBCom.Parameters.AddWithValue("@YEAR_STARTED", yearStart);
            updateEBCom.Parameters.AddWithValue("@YEAR_GRADUATED", yearGrad);
            updateEBCom.Parameters.AddWithValue("@ACCOMPLISHMENT", awards);
            updateEBCom.ExecuteNonQuery();

            /*          1. GET GOVERNMENT EXAMS             */
            getInfoQuery = "select EXAM_NAME from T_USER_EDUBKGND_GOVTEST where EDUCATION_GOVTEST_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string exam = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select DATE_TAKEN from T_USER_EDUBKGND_GOVTEST where EDUCATION_GOVTEST_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string dateTaken = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RATING from T_USER_EDUBKGND_GOVTEST where EDUCATION_GOVTEST_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string rating = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select PROF_AFF from T_USER_EDUBKGND_GOVTEST where EDUCATION_GOVTEST_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string profAff = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select POSITION from T_USER_EDUBKGND_GOVTEST where EDUCATION_GOVTEST_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string examPosition = getInfoCom.ExecuteScalar().ToString();

            /*          1. UPDATE GOVERNMENT EXAMS           */
            insertQuery = "insert into T_GOVERNMENT_EXAM (APPLICATION_CODE, GOVERNMENT_CODE, EXAM_NAME, DATE_TAKEN, RATING, PROF_AFF, POSITION) values (@APPLICATION_CODE, @GOVERNMENT_CODE, @EXAM_NAME, @DATE_TAKEN, @RATING, @PROF_AFF, @POSITION)";
            updateEBCom = new SqlCommand(insertQuery, conn);
            updateEBCom.Parameters.AddWithValue("@APPLICATION_CODE", applicationCode);
            updateEBCom.Parameters.AddWithValue("@GOVERNMENT_CODE", applicationCode + "001");
            updateEBCom.Parameters.AddWithValue("@EXAM_NAME", exam);
            updateEBCom.Parameters.AddWithValue("@DATE_TAKEN", dateTaken);
            updateEBCom.Parameters.AddWithValue("@RATING", rating);
            updateEBCom.Parameters.AddWithValue("@PROF_AFF", profAff);
            updateEBCom.Parameters.AddWithValue("@POSITION", examPosition);
            updateEBCom.ExecuteNonQuery();

            /*          2. GET GOVERNMENT EXAMS             */
            getInfoQuery = "select EXAM_NAME from T_USER_EDUBKGND_GOVTEST where EDUCATION_GOVTEST_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            exam = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select DATE_TAKEN from T_USER_EDUBKGND_GOVTEST where EDUCATION_GOVTEST_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            dateTaken = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RATING from T_USER_EDUBKGND_GOVTEST where EDUCATION_GOVTEST_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            rating = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select PROF_AFF from T_USER_EDUBKGND_GOVTEST where EDUCATION_GOVTEST_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            profAff = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select POSITION from T_USER_EDUBKGND_GOVTEST where EDUCATION_GOVTEST_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            examPosition = getInfoCom.ExecuteScalar().ToString();

            /*          2. UPDATE GOVERNMENT EXAMS           */
            insertQuery = "insert into T_GOVERNMENT_EXAM (APPLICATION_CODE, GOVERNMENT_CODE, EXAM_NAME, DATE_TAKEN, RATING, PROF_AFF, POSITION) values (@APPLICATION_CODE, @GOVERNMENT_CODE, @EXAM_NAME, @DATE_TAKEN, @RATING, @PROF_AFF, @POSITION)";
            updateEBCom = new SqlCommand(insertQuery, conn);
            updateEBCom.Parameters.AddWithValue("@APPLICATION_CODE", applicationCode);
            updateEBCom.Parameters.AddWithValue("@GOVERNMENT_CODE", applicationCode + "002");
            updateEBCom.Parameters.AddWithValue("@EXAM_NAME", exam);
            updateEBCom.Parameters.AddWithValue("@DATE_TAKEN", dateTaken);
            updateEBCom.Parameters.AddWithValue("@RATING", rating);
            updateEBCom.Parameters.AddWithValue("@PROF_AFF", profAff);
            updateEBCom.Parameters.AddWithValue("@POSITION", examPosition);
            updateEBCom.ExecuteNonQuery();

            conn.Close();
        }

        protected void updateFamilyBackground()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["erecruitmentConnectionString"].ConnectionString);

            string applicationCode = getApplicationCode();

            conn.Open();

            /*          1. GET FAMILY BACKGROUND          */
            string getInfoQuery = "select RELATIVE_LNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_1' ";
            SqlCommand getInfoCom = new SqlCommand(getInfoQuery, conn);
            string lName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_FNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string fName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_MNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string mName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_JOB from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string job = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_EMP from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string emp = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_BIRTHDATE from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string bday = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_RELATIONSHIP from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string relation = getInfoCom.ExecuteScalar().ToString();

            /*          1. UPDATE FAMILY BACKGROUND       */
            string insertQuery = "insert into T_FAMILY_BACKGRND (APPLICATION_CODE, FAMILY_CODE, RELATIVE_LNAME, RELATIVE_FNAME, RELATIVE_MNAME, RELATIVE_JOB, RELATIVE_EMP, RELATIVE_BIRTHDATE, RELATIVE_RELATIONSHIP) values (@APPLICATION_CODE, @FAMILY_CODE, @RELATIVE_LNAME, @RELATIVE_FNAME, @RELATIVE_MNAME, @RELATIVE_JOB, @RELATIVE_EMP, @RELATIVE_BIRTHDATE, @RELATIVE_RELATIONSHIP)";
            SqlCommand updateEBCom = new SqlCommand(insertQuery, conn);
            updateEBCom.Parameters.AddWithValue("@APPLICATION_CODE", applicationCode);
            updateEBCom.Parameters.AddWithValue("@FAMILY_CODE", applicationCode + "001");
            updateEBCom.Parameters.AddWithValue("@RELATIVE_LNAME", lName);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_FNAME", fName);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_MNAME", mName);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_JOB", job);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_EMP", emp);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_BIRTHDATE", bday);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_RELATIONSHIP", relation);
            updateEBCom.ExecuteNonQuery();

            /*          2. GET FAMILY BACKGROUND          */
            getInfoQuery = "select RELATIVE_LNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            lName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_FNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            fName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_MNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            mName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_JOB from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            job = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_EMP from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            emp = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_BIRTHDATE from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            bday = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_RELATIONSHIP from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            relation = getInfoCom.ExecuteScalar().ToString();

            /*          2. UPDATE FAMILY BACKGROUND       */
            insertQuery = "insert into T_FAMILY_BACKGRND (APPLICATION_CODE, FAMILY_CODE, RELATIVE_LNAME, RELATIVE_FNAME, RELATIVE_MNAME, RELATIVE_JOB, RELATIVE_EMP, RELATIVE_BIRTHDATE, RELATIVE_RELATIONSHIP) values (@APPLICATION_CODE, @FAMILY_CODE, @RELATIVE_LNAME, @RELATIVE_FNAME, @RELATIVE_MNAME, @RELATIVE_JOB, @RELATIVE_EMP, @RELATIVE_BIRTHDATE, @RELATIVE_RELATIONSHIP)";
            updateEBCom = new SqlCommand(insertQuery, conn);
            updateEBCom.Parameters.AddWithValue("@APPLICATION_CODE", applicationCode);
            updateEBCom.Parameters.AddWithValue("@FAMILY_CODE", applicationCode + "002");
            updateEBCom.Parameters.AddWithValue("@RELATIVE_LNAME", lName);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_FNAME", fName);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_MNAME", mName);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_JOB", job);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_EMP", emp);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_BIRTHDATE", bday);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_RELATIONSHIP", relation);
            updateEBCom.ExecuteNonQuery();

            /*          3. GET FAMILY BACKGROUND          */
            getInfoQuery = "select RELATIVE_LNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_3' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            lName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_FNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_3' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            fName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_MNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_3' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            mName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_JOB from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_3' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            job = getInfoCom.ExecuteScalar().ToString();

            /*          3. UPDATE FAMILY BACKGROUND       */
            insertQuery = "insert into T_FAMILY_BACKGRND (APPLICATION_CODE, FAMILY_CODE, RELATIVE_LNAME, RELATIVE_FNAME, RELATIVE_MNAME, RELATIVE_JOB, RELATIVE_EMP, RELATIVE_BIRTHDATE, RELATIVE_RELATIONSHIP) values (@APPLICATION_CODE, @FAMILY_CODE, @RELATIVE_LNAME, @RELATIVE_FNAME, @RELATIVE_MNAME, @RELATIVE_JOB, @RELATIVE_EMP, @RELATIVE_BIRTHDATE, @RELATIVE_RELATIONSHIP)";
            updateEBCom = new SqlCommand(insertQuery, conn);
            updateEBCom.Parameters.AddWithValue("@APPLICATION_CODE", applicationCode);
            updateEBCom.Parameters.AddWithValue("@FAMILY_CODE", applicationCode + "003");
            updateEBCom.Parameters.AddWithValue("@RELATIVE_LNAME", lName);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_FNAME", fName);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_MNAME", mName);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_JOB", job);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_EMP", emp);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_BIRTHDATE", bday);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_RELATIONSHIP", relation);
            updateEBCom.ExecuteNonQuery();

            /*          4. GET FAMILY BACKGROUND          */
            getInfoQuery = "select RELATIVE_LNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_4' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            lName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_FNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_4' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            fName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_MNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_4' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            mName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_JOB from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_4' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            job = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_EMP from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_4' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            emp = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_BIRTHDATE from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_4' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            bday = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_RELATIONSHIP from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_4' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            relation = getInfoCom.ExecuteScalar().ToString();

            /*          4. UPDATE FAMILY BACKGROUND       */
            insertQuery = "insert into T_FAMILY_BACKGRND (APPLICATION_CODE, FAMILY_CODE, RELATIVE_LNAME, RELATIVE_FNAME, RELATIVE_MNAME, RELATIVE_JOB, RELATIVE_EMP, RELATIVE_BIRTHDATE, RELATIVE_RELATIONSHIP) values (@APPLICATION_CODE, @FAMILY_CODE, @RELATIVE_LNAME, @RELATIVE_FNAME, @RELATIVE_MNAME, @RELATIVE_JOB, @RELATIVE_EMP, @RELATIVE_BIRTHDATE, @RELATIVE_RELATIONSHIP)";
            updateEBCom = new SqlCommand(insertQuery, conn);
            updateEBCom.Parameters.AddWithValue("@APPLICATION_CODE", applicationCode);
            updateEBCom.Parameters.AddWithValue("@FAMILY_CODE", applicationCode + "004");
            updateEBCom.Parameters.AddWithValue("@RELATIVE_LNAME", lName);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_FNAME", fName);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_MNAME", mName);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_JOB", job);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_EMP", emp);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_BIRTHDATE", bday);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_RELATIONSHIP", relation);
            updateEBCom.ExecuteNonQuery();

            /*          5. GET FAMILY BACKGROUND          */
            getInfoQuery = "select RELATIVE_LNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_5' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            lName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_FNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_5' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            fName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_MNAME from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_5' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            mName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_JOB from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_5' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            job = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_EMP from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_5' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            emp = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_BIRTHDATE from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_5' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            bday = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select RELATIVE_RELATIONSHIP from T_USER_FMLYBCK where FAMILY_CODE = '" + Session["New"] + "_5' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            relation = getInfoCom.ExecuteScalar().ToString();

            /*          5. UPDATE FAMILY BACKGROUND       */
            insertQuery = "insert into T_FAMILY_BACKGRND (APPLICATION_CODE, FAMILY_CODE, RELATIVE_LNAME, RELATIVE_FNAME, RELATIVE_MNAME, RELATIVE_JOB, RELATIVE_EMP, RELATIVE_BIRTHDATE, RELATIVE_RELATIONSHIP) values (@APPLICATION_CODE, @FAMILY_CODE, @RELATIVE_LNAME, @RELATIVE_FNAME, @RELATIVE_MNAME, @RELATIVE_JOB, @RELATIVE_EMP, @RELATIVE_BIRTHDATE, @RELATIVE_RELATIONSHIP)";
            updateEBCom = new SqlCommand(insertQuery, conn);
            updateEBCom.Parameters.AddWithValue("@APPLICATION_CODE", applicationCode);
            updateEBCom.Parameters.AddWithValue("@FAMILY_CODE", applicationCode + "005");
            updateEBCom.Parameters.AddWithValue("@RELATIVE_LNAME", lName);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_FNAME", fName);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_MNAME", mName);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_JOB", job);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_EMP", emp);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_BIRTHDATE", bday);
            updateEBCom.Parameters.AddWithValue("@RELATIVE_RELATIONSHIP", relation);
            updateEBCom.ExecuteNonQuery();

            conn.Close();
        }

        protected void updateWorkExperience()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["erecruitmentConnectionString"].ConnectionString);

            string applicationCode = getApplicationCode();

            conn.Open();

            /*          1. UPDATE WORK EXPERIENCE          */
            string getInfoQuery = "select EMPLOYER_NAME from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_1' ";
            SqlCommand getInfoCom = new SqlCommand(getInfoQuery, conn);
            string empName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select POSITION from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string position = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select START_DATE from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string start = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select END_DATE from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string end = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select SALARY from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string salary = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select REASON_FOR_LEAVING from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string reason = getInfoCom.ExecuteScalar().ToString();

            /*          1. UPDATE WORK EXPERIENCE       */
            string insertQuery = "insert into T_WORK_EXPERIENCED (APPLICATION_CODE, EXPERIENCED_CODE, EMPLOYER_NAME, POSITION, START_DATE, END_DATE, SALARY, REASON_FOR_LEAVING) values (@APPLICATION_CODE, @EXPERIENCED_CODE, @EMPLOYER_NAME, @POSITION, @START_DATE, @END_DATE, @SALARY, @REASON_FOR_LEAVING)";
            SqlCommand updateEBCom = new SqlCommand(insertQuery, conn);
            updateEBCom.Parameters.AddWithValue("@APPLICATION_CODE", applicationCode);
            updateEBCom.Parameters.AddWithValue("@EXPERIENCED_CODE", applicationCode + "001");
            updateEBCom.Parameters.AddWithValue("@EMPLOYER_NAME", empName);
            updateEBCom.Parameters.AddWithValue("@POSITION", position);
            updateEBCom.Parameters.AddWithValue("@START_DATE", start);
            updateEBCom.Parameters.AddWithValue("@END_DATE", end);
            updateEBCom.Parameters.AddWithValue("@SALARY", salary);
            updateEBCom.Parameters.AddWithValue("@REASON_FOR_LEAVING", reason);
            updateEBCom.ExecuteNonQuery();

            /*          2. UPDATE WORK EXPERIENCE          */
            getInfoQuery = "select EMPLOYER_NAME from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            empName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select POSITION from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            position = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select START_DATE from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            start = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select END_DATE from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            end = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select SALARY from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            salary = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select REASON_FOR_LEAVING from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            reason = getInfoCom.ExecuteScalar().ToString();

            /*          2. UPDATE WORK EXPERIENCE       */
            insertQuery = "insert into T_WORK_EXPERIENCED (APPLICATION_CODE, EXPERIENCED_CODE, EMPLOYER_NAME, POSITION, START_DATE, END_DATE, SALARY, REASON_FOR_LEAVING) values (@APPLICATION_CODE, @EXPERIENCED_CODE, @EMPLOYER_NAME, @POSITION, @START_DATE, @END_DATE, @SALARY, @REASON_FOR_LEAVING)";
            updateEBCom = new SqlCommand(insertQuery, conn);
            updateEBCom.Parameters.AddWithValue("@APPLICATION_CODE", applicationCode);
            updateEBCom.Parameters.AddWithValue("@EXPERIENCED_CODE", applicationCode + "002");
            updateEBCom.Parameters.AddWithValue("@EMPLOYER_NAME", empName);
            updateEBCom.Parameters.AddWithValue("@POSITION", position);
            updateEBCom.Parameters.AddWithValue("@START_DATE", start);
            updateEBCom.Parameters.AddWithValue("@END_DATE", end);
            updateEBCom.Parameters.AddWithValue("@SALARY", salary);
            updateEBCom.Parameters.AddWithValue("@REASON_FOR_LEAVING", reason);
            updateEBCom.ExecuteNonQuery();

            /*          3. UPDATE WORK EXPERIENCE          */
            getInfoQuery = "select EMPLOYER_NAME from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_3' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            empName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select POSITION from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_3' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            position = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select START_DATE from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_3' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            start = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select END_DATE from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_3' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            end = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select SALARY from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_3' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            salary = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select REASON_FOR_LEAVING from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_3' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            reason = getInfoCom.ExecuteScalar().ToString();

            /*          3. UPDATE WORK EXPERIENCE       */
            insertQuery = "insert into T_WORK_EXPERIENCED (APPLICATION_CODE, EXPERIENCED_CODE, EMPLOYER_NAME, POSITION, START_DATE, END_DATE, SALARY, REASON_FOR_LEAVING) values (@APPLICATION_CODE, @EXPERIENCED_CODE, @EMPLOYER_NAME, @POSITION, @START_DATE, @END_DATE, @SALARY, @REASON_FOR_LEAVING)";
            updateEBCom = new SqlCommand(insertQuery, conn);
            updateEBCom.Parameters.AddWithValue("@APPLICATION_CODE", applicationCode);
            updateEBCom.Parameters.AddWithValue("@EXPERIENCED_CODE", applicationCode + "003");
            updateEBCom.Parameters.AddWithValue("@EMPLOYER_NAME", empName);
            updateEBCom.Parameters.AddWithValue("@POSITION", position);
            updateEBCom.Parameters.AddWithValue("@START_DATE", start);
            updateEBCom.Parameters.AddWithValue("@END_DATE", end);
            updateEBCom.Parameters.AddWithValue("@SALARY", salary);
            updateEBCom.Parameters.AddWithValue("@REASON_FOR_LEAVING", reason);
            updateEBCom.ExecuteNonQuery();

            /*          4. UPDATE WORK EXPERIENCE          */
            getInfoQuery = "select EMPLOYER_NAME from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_4' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            empName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select POSITION from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_4' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            position = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select START_DATE from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_4' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            start = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select END_DATE from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_4' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            end = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select SALARY from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_4' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            salary = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select REASON_FOR_LEAVING from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_4' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            reason = getInfoCom.ExecuteScalar().ToString();

            /*          4. UPDATE WORK EXPERIENCE       */
            insertQuery = "insert into T_WORK_EXPERIENCED (APPLICATION_CODE, EXPERIENCED_CODE, EMPLOYER_NAME, POSITION, START_DATE, END_DATE, SALARY, REASON_FOR_LEAVING) values (@APPLICATION_CODE, @EXPERIENCED_CODE, @EMPLOYER_NAME, @POSITION, @START_DATE, @END_DATE, @SALARY, @REASON_FOR_LEAVING)";
            updateEBCom = new SqlCommand(insertQuery, conn);
            updateEBCom.Parameters.AddWithValue("@APPLICATION_CODE", applicationCode);
            updateEBCom.Parameters.AddWithValue("@EXPERIENCED_CODE", applicationCode + "004");
            updateEBCom.Parameters.AddWithValue("@EMPLOYER_NAME", empName);
            updateEBCom.Parameters.AddWithValue("@POSITION", position);
            updateEBCom.Parameters.AddWithValue("@START_DATE", start);
            updateEBCom.Parameters.AddWithValue("@END_DATE", end);
            updateEBCom.Parameters.AddWithValue("@SALARY", salary);
            updateEBCom.Parameters.AddWithValue("@REASON_FOR_LEAVING", reason);
            updateEBCom.ExecuteNonQuery();

            /*          5. UPDATE WORK EXPERIENCE          */
            getInfoQuery = "select EMPLOYER_NAME from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_5' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            empName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select POSITION from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_5' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            position = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select START_DATE from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_5' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            start = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select END_DATE from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_5' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            end = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select SALARY from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_5' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            salary = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select REASON_FOR_LEAVING from T_USER_WORKEXP where EXPERIENCED_CODE = '" + Session["New"] + "_5' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            reason = getInfoCom.ExecuteScalar().ToString();

            /*          5. UPDATE WORK EXPERIENCE       */
            insertQuery = "insert into T_WORK_EXPERIENCED (APPLICATION_CODE, EXPERIENCED_CODE, EMPLOYER_NAME, POSITION, START_DATE, END_DATE, SALARY, REASON_FOR_LEAVING) values (@APPLICATION_CODE, @EXPERIENCED_CODE, @EMPLOYER_NAME, @POSITION, @START_DATE, @END_DATE, @SALARY, @REASON_FOR_LEAVING)";
            updateEBCom = new SqlCommand(insertQuery, conn);
            updateEBCom.Parameters.AddWithValue("@APPLICATION_CODE", applicationCode);
            updateEBCom.Parameters.AddWithValue("@EXPERIENCED_CODE", applicationCode + "005");
            updateEBCom.Parameters.AddWithValue("@EMPLOYER_NAME", empName);
            updateEBCom.Parameters.AddWithValue("@POSITION", position);
            updateEBCom.Parameters.AddWithValue("@START_DATE", start);
            updateEBCom.Parameters.AddWithValue("@END_DATE", end);
            updateEBCom.Parameters.AddWithValue("@SALARY", salary);
            updateEBCom.Parameters.AddWithValue("@REASON_FOR_LEAVING", reason);
            updateEBCom.ExecuteNonQuery();

            conn.Close();
        }

        protected void updatePersonalReferences()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["erecruitmentConnectionString"].ConnectionString);

            string applicationCode = getApplicationCode();

            conn.Open();

            /*          1. UPDATE PERSONAL REFERENCES          */
            string getInfoQuery = "select REFERENCE_LNAME from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_1' ";
            SqlCommand getInfoCom = new SqlCommand(getInfoQuery, conn);
            string lName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select REFERENCE_FNAME from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string fName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select REFERENCE_MI from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string mi = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select DESIGNATION from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string designation = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select CONTACT_INFO from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string contactNum = getInfoCom.ExecuteScalar().ToString();

            /*          1. UPDATE PERSONAL REFERENCES       */
            string insertQuery = "insert into T_PERSONAL_REFERENCES (APPLICATION_CODE, REFERENCE_CODE, REFERENCE_LNAME, REFERENCE_FNAME, REFERENCE_MI, DESIGNATION, CONTACT_INFO) values (@APPLICATION_CODE, @REFERENCE_CODE, @REFERENCE_LNAME, @REFERENCE_FNAME, @REFERENCE_MI, @DESIGNATION, @CONTACT_INFO)";
            SqlCommand updateEBCom = new SqlCommand(insertQuery, conn);
            updateEBCom.Parameters.AddWithValue("@APPLICATION_CODE", applicationCode);
            updateEBCom.Parameters.AddWithValue("@REFERENCE_CODE", applicationCode + "001");
            updateEBCom.Parameters.AddWithValue("@REFERENCE_LNAME", lName);
            updateEBCom.Parameters.AddWithValue("@REFERENCE_FNAME", fName);
            updateEBCom.Parameters.AddWithValue("@REFERENCE_MI", mi);
            updateEBCom.Parameters.AddWithValue("@DESIGNATION", designation);
            updateEBCom.Parameters.AddWithValue("@CONTACT_INFO", contactNum);
            updateEBCom.ExecuteNonQuery();

            /*          2. UPDATE PERSONAL REFERENCES          */
            getInfoQuery = "select REFERENCE_LNAME from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            lName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select REFERENCE_FNAME from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            fName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select REFERENCE_MI from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            mi = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select DESIGNATION from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            designation = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select CONTACT_INFO from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            contactNum = getInfoCom.ExecuteScalar().ToString();

            /*          2. UPDATE PERSONAL REFERENCES       */
            insertQuery = "insert into T_PERSONAL_REFERENCES (APPLICATION_CODE, REFERENCE_CODE, REFERENCE_LNAME, REFERENCE_FNAME, REFERENCE_MI, DESIGNATION, CONTACT_INFO) values (@APPLICATION_CODE, @REFERENCE_CODE, @REFERENCE_LNAME, @REFERENCE_FNAME, @REFERENCE_MI, @DESIGNATION, @CONTACT_INFO)";
            updateEBCom = new SqlCommand(insertQuery, conn);
            updateEBCom.Parameters.AddWithValue("@APPLICATION_CODE", applicationCode);
            updateEBCom.Parameters.AddWithValue("@REFERENCE_CODE", applicationCode + "002");
            updateEBCom.Parameters.AddWithValue("@REFERENCE_LNAME", lName);
            updateEBCom.Parameters.AddWithValue("@REFERENCE_FNAME", fName);
            updateEBCom.Parameters.AddWithValue("@REFERENCE_MI", mi);
            updateEBCom.Parameters.AddWithValue("@DESIGNATION", designation);
            updateEBCom.Parameters.AddWithValue("@CONTACT_INFO", contactNum);
            updateEBCom.ExecuteNonQuery();

            /*          3. UPDATE PERSONAL REFERENCES          */
            getInfoQuery = "select REFERENCE_LNAME from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_3' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            lName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select REFERENCE_FNAME from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_3' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            fName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select REFERENCE_MI from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_3' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            mi = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select DESIGNATION from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_3' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            designation = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select CONTACT_INFO from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_3' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            contactNum = getInfoCom.ExecuteScalar().ToString();

            /*          3. UPDATE PERSONAL REFERENCES       */
            insertQuery = "insert into T_PERSONAL_REFERENCES (APPLICATION_CODE, REFERENCE_CODE, REFERENCE_LNAME, REFERENCE_FNAME, REFERENCE_MI, DESIGNATION, CONTACT_INFO) values (@APPLICATION_CODE, @REFERENCE_CODE, @REFERENCE_LNAME, @REFERENCE_FNAME, @REFERENCE_MI, @DESIGNATION, @CONTACT_INFO)";
            updateEBCom = new SqlCommand(insertQuery, conn);
            updateEBCom.Parameters.AddWithValue("@APPLICATION_CODE", applicationCode);
            updateEBCom.Parameters.AddWithValue("@REFERENCE_CODE", applicationCode + "003");
            updateEBCom.Parameters.AddWithValue("@REFERENCE_LNAME", lName);
            updateEBCom.Parameters.AddWithValue("@REFERENCE_FNAME", fName);
            updateEBCom.Parameters.AddWithValue("@REFERENCE_MI", mi);
            updateEBCom.Parameters.AddWithValue("@DESIGNATION", designation);
            updateEBCom.Parameters.AddWithValue("@CONTACT_INFO", contactNum);
            updateEBCom.ExecuteNonQuery();

            /*          3. UPDATE PERSONAL REFERENCES          */
            getInfoQuery = "select REFERENCE_LNAME from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_4' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            lName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select REFERENCE_FNAME from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_4' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            fName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select REFERENCE_MI from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_4' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            mi = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select DESIGNATION from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_4' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            designation = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select CONTACT_INFO from T_USER_PERSREF where REFERENCE_CODE = '" + Session["New"] + "_4' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            contactNum = getInfoCom.ExecuteScalar().ToString();

            /*          3. UPDATE PERSONAL REFERENCES       */
            insertQuery = "insert into T_PERSONAL_REFERENCES (APPLICATION_CODE, REFERENCE_CODE, REFERENCE_LNAME, REFERENCE_FNAME, REFERENCE_MI, DESIGNATION, CONTACT_INFO) values (@APPLICATION_CODE, @REFERENCE_CODE, @REFERENCE_LNAME, @REFERENCE_FNAME, @REFERENCE_MI, @DESIGNATION, @CONTACT_INFO)";
            updateEBCom = new SqlCommand(insertQuery, conn);
            updateEBCom.Parameters.AddWithValue("@APPLICATION_CODE", applicationCode);
            updateEBCom.Parameters.AddWithValue("@REFERENCE_CODE", applicationCode + "004");
            updateEBCom.Parameters.AddWithValue("@REFERENCE_LNAME", lName);
            updateEBCom.Parameters.AddWithValue("@REFERENCE_FNAME", fName);
            updateEBCom.Parameters.AddWithValue("@REFERENCE_MI", mi);
            updateEBCom.Parameters.AddWithValue("@DESIGNATION", designation);
            updateEBCom.Parameters.AddWithValue("@CONTACT_INFO", contactNum);
            updateEBCom.ExecuteNonQuery();

            /*          1. SELECT EMPLOYEES WORKING IN MAYBANK      */
            getInfoQuery = "select MAYBANK_EMP_NAME from T_USER_MAYBANK_EMP where MAYBANK_EMP_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string empName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select POSITION from T_USER_MAYBANK_EMP where MAYBANK_EMP_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string position = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select NATURE_OF_RELATIONSHIP from T_USER_MAYBANK_EMP where MAYBANK_EMP_CODE = '" + Session["New"] + "_1' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            string relation = getInfoCom.ExecuteScalar().ToString();

            /*          1. UPDATE PERSONAL REFERENCES       */
            insertQuery = "insert into T_MAYBANK_EMP (APPLICATION_CODE, MAYBANK_EMP_CODE, MAYBANK_EMP_NAME, POSITION, NATURE_OF_RELATIONSHIP) values (@APPLICATION_CODE, @MAYBANK_EMP_CODE, @MAYBANK_EMP_NAME, @POSITION, @NATURE_OF_RELATIONSHIP)";
            updateEBCom = new SqlCommand(insertQuery, conn);
            updateEBCom.Parameters.AddWithValue("@APPLICATION_CODE", applicationCode);
            updateEBCom.Parameters.AddWithValue("@MAYBANK_EMP_CODE", applicationCode + "001");
            updateEBCom.Parameters.AddWithValue("@MAYBANK_EMP_NAME", empName);
            updateEBCom.Parameters.AddWithValue("@POSITION", position);
            updateEBCom.Parameters.AddWithValue("@NATURE_OF_RELATIONSHIP", relation);
            updateEBCom.ExecuteNonQuery();

            /*          2. SELECT EMPLOYEES WORKING IN MAYBANK      */
            getInfoQuery = "select MAYBANK_EMP_NAME from T_USER_MAYBANK_EMP where MAYBANK_EMP_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            empName = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select POSITION from T_USER_MAYBANK_EMP where MAYBANK_EMP_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            position = getInfoCom.ExecuteScalar().ToString();

            getInfoQuery = "select NATURE_OF_RELATIONSHIP from T_USER_MAYBANK_EMP where MAYBANK_EMP_CODE = '" + Session["New"] + "_2' ";
            getInfoCom = new SqlCommand(getInfoQuery, conn);
            relation = getInfoCom.ExecuteScalar().ToString();

            /*          2. UPDATE PERSONAL REFERENCES       */
            insertQuery = "insert into T_MAYBANK_EMP (APPLICATION_CODE, MAYBANK_EMP_CODE, MAYBANK_EMP_NAME, POSITION, NATURE_OF_RELATIONSHIP) values (@APPLICATION_CODE, @MAYBANK_EMP_CODE, @MAYBANK_EMP_NAME, @POSITION, @NATURE_OF_RELATIONSHIP)";
            updateEBCom = new SqlCommand(insertQuery, conn);
            updateEBCom.Parameters.AddWithValue("@APPLICATION_CODE", applicationCode);
            updateEBCom.Parameters.AddWithValue("@MAYBANK_EMP_CODE", applicationCode + "002");
            updateEBCom.Parameters.AddWithValue("@MAYBANK_EMP_NAME", empName);
            updateEBCom.Parameters.AddWithValue("@POSITION", position);
            updateEBCom.Parameters.AddWithValue("@NATURE_OF_RELATIONSHIP", relation);
            updateEBCom.ExecuteNonQuery();


            conn.Close();
        }

        protected Boolean checkRequirements()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["erecruitmentConnectionString"].ConnectionString);

            conn.Open();

            /*Educational Background*/
            string countNull = "select count(*) from T_USER_EDUBKGND where EMAIL_ADDRESS = '" + Session["New"].ToString() + "' and SCHOOL_NAME IS NULL and COURSE IS NULL and YEAR_GRADUATED IS NULL";
            SqlCommand com = new SqlCommand(countNull, conn);
            int numNull = Convert.ToInt32(com.ExecuteScalar().ToString());

            string countEmpty = "select count(*) from T_USER_EDUBKGND where EMAIL_ADDRESS = '" + Session["New"].ToString() + "' and SCHOOL_NAME ='' and COURSE ='' and YEAR_GRADUATED =''";
            com = new SqlCommand(countEmpty, conn);
            int numEmpty = Convert.ToInt32(com.ExecuteScalar().ToString());

            if (!(numNull <= 2 && numEmpty <= 2))
            {
                return false;
            }

            /*Family Background*/
            countNull = "select count(*) from T_USER_FMLYBCK where EMAIL_ADDRESS = '" + Session["New"].ToString() + "' and RELATIVE_LNAME IS NULL and RELATIVE_FNAME IS NULL and RELATIVE_MNAME IS NULL and RELATIVE_JOB IS NULL";
            com = new SqlCommand(countNull, conn);
            numNull = Convert.ToInt32(com.ExecuteScalar().ToString());

            countEmpty = "select count(*) from T_USER_FMLYBCK where EMAIL_ADDRESS = '" + Session["New"].ToString() + "' and RELATIVE_LNAME ='' and RELATIVE_FNAME ='' and RELATIVE_MNAME ='' and RELATIVE_JOB =''";
            com = new SqlCommand(countEmpty, conn);
            numEmpty = Convert.ToInt32(com.ExecuteScalar().ToString());

            if (!(numNull <= 3 && numEmpty <= 3))
            {
                return false;
            }

            /*Personal References*/
            countNull = "select count(*) from T_USER_PERSREF where EMAIL_ADDRESS = '" + Session["New"].ToString() + "' and REFERENCE_LNAME IS NULL and REFERENCE_FNAME IS NULL and REFERENCE_MI IS NULL and DESIGNATION IS NULL and CONTACT_INFO IS NULL";
            com = new SqlCommand(countNull, conn);
            numNull = Convert.ToInt32(com.ExecuteScalar().ToString());

            countEmpty = "select count(*) from T_USER_PERSREF where EMAIL_ADDRESS = '" + Session["New"].ToString() + "' and REFERENCE_LNAME ='' and REFERENCE_FNAME ='' and REFERENCE_MI ='' and DESIGNATION ='' and CONTACT_INFO =''";
            com = new SqlCommand(countEmpty, conn);
            numEmpty = Convert.ToInt32(com.ExecuteScalar().ToString());

            if (!(numNull <= 2 && numEmpty <= 2))
            {
                return false;
            }

            /*Work Experience*/
            countNull = "select count(*) from T_USER_WORKEXP where EMAIL_ADDRESS = '" + Session["New"].ToString() + "' and EMPLOYER_NAME IS NULL and POSITION IS NULL and SALARY IS NULL and REASON_FOR_LEAVING IS NULL";
            com = new SqlCommand(countNull, conn);
            numNull = Convert.ToInt32(com.ExecuteScalar().ToString());

            countEmpty = "select count(*) from T_USER_WORKEXP where EMAIL_ADDRESS = '" + Session["New"].ToString() + "' and EMPLOYER_NAME ='' and POSITION ='' and SALARY ='' and REASON_FOR_LEAVING =''";
            com = new SqlCommand(countEmpty, conn);
            numEmpty = Convert.ToInt32(com.ExecuteScalar().ToString());

            if (!(numNull <= 2 && numEmpty <= 2))
            {
                return false;
            }

            conn.Close();
            
            
            return true;
        }

        protected void ApplyPositionBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["erecruitmentConnectionString"].ConnectionString);

            conn.Open();
            string query = "select count(*) from T_APPLICATION_INFO where EMAIL_ADDRESS = '" + Session["New"].ToString() + "' and POSITION = '" + PositionsDDL.SelectedItem.Text + "' and STATUS_CODE != 'W'";
            SqlCommand com = new SqlCommand(query, conn);
            int posCount = Convert.ToInt32(com.ExecuteScalar().ToString());
            conn.Close();

            if (checkRequirements())
            {
                if (posCount == 0)
                {
                    alreadyAppliedLbl.Visible = false;
                    try
                    {
                        conn.Open();
                        //string insertQuery = "insert into T_APPLICATION_INFO ( POSITION, DESIRED_SALARY, DATE_APPLIED, STATUS_CODE, REMARKS, EMAIL_ADDRESS) values ( @POSITION, @DESIRED_SALARY, @DATE_APPLIED, @STATUS_CODE, @REMARKS,@EMAIL_ADDRESS)";
                        string insertQuery = "insert into T_APPLICATION_INFO ( POSITION, DESIRED_SALARY, DATE_APPLIED, STATUS_CODE, REMARKS, EMAIL_ADDRESS) values ( @POSITION, @DESIRED_SALARY, @DATE_APPLIED, @STATUS_CODE, @REMARKS,@EMAIL_ADDRESS)";
                        SqlCommand applyPositionCom = new SqlCommand(insertQuery, conn);
                        applyPositionCom.Parameters.AddWithValue("@POSITION", PositionsDDL.SelectedItem.Text);
                        applyPositionCom.Parameters.AddWithValue("@DESIRED_SALARY", Int32.Parse(DesiredSalaryTextBox.Text));
                        applyPositionCom.Parameters.AddWithValue("@DATE_APPLIED", DateTime.Now.ToString("yyyy-dd-MM HH:mm:ss"));
                        applyPositionCom.Parameters.AddWithValue("@STATUS_CODE", "N");
                        applyPositionCom.Parameters.AddWithValue("@REMARKS", "New Applicant");
                        applyPositionCom.Parameters.AddWithValue("@EMAIL_ADDRESS", Session["New"].ToString());
                        applyPositionCom.ExecuteNonQuery();
                        AppliedApplicationIDLbl.Text = "Registration Successful!";

                        try
                        {
                            updatePersonalInfoDB();
                        }
                        catch (Exception er)
                        {

                            Response.Write("Error with updating Personal Information:" + er.ToString());
                        }

                        try
                        {
                            updateEducationalBackground();
                        }
                        catch (Exception er)
                        {

                            Response.Write("Error with updating Educational Background:" + er.ToString());
                        }

                        try
                        {
                            updateFamilyBackground();
                        }
                        catch (Exception er)
                        {

                            Response.Write("Error with updating Family Background:" + er.ToString());
                        }

                        try
                        {
                            updateWorkExperience();
                        }
                        catch (Exception er)
                        {

                            Response.Write("Error with updating Work Experience:" + er.ToString());
                        }

                        try
                        {
                            updatePersonalReferences();
                        }
                        catch (Exception er)
                        {

                            Response.Write("Error with updating Personal References:" + er.ToString());
                        }
                    }
                    catch (Exception aa)
                    {
                        //Response.Write(aa);
                        AppliedApplicationIDLbl.Text = "Registration is not successful! Please enter valid salary.";
                    }
                    conn.Close();
                }

                else
                {
                    alreadyAppliedLbl.Visible = true;
                }
            }
            else
            {
                invalidApplyLbl1.Visible = true;
                invalidApplyLbl2.Visible = true;
                invalidApplyLbl3.Visible = true;
                invalidApplyLbl4.Visible = true;
                invalidApplyLbl5.Visible = true;
            }
        }

        
    }
}