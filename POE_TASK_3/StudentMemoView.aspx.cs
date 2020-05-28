using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;



namespace POE_TASK_3
{
    public partial class StudentMemoView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            MemoData();
        }

       void MemoData()
        {
            try
            {
                //inserting data to the questions labeles
                lbQuestion1.Text = TestInfo.Questions[0];
                lbQuestion2.Text = TestInfo.Questions[1];
                lbQuestion3.Text = TestInfo.Questions[2];


                //inserting data to student question 1 information
                lbStudentQ1A.Text = TestInfo.StudentAnswer[0];
                lbStudentQ1Tokken.Text = TestInfo.Tokken[0];
                lbCorrectAnswer1.Text = TestInfo.CorrectAnswer[0];

                //inserting data to student question 2 information
                lbStudentQ2Anwer.Text = TestInfo.StudentAnswer[1];
                lbStudentQ2Tokken.Text = TestInfo.Tokken[1];
                lbCorrectAnswer2.Text = TestInfo.CorrectAnswer[1];

                //inserting data to student question 3 information
                lbStudentQ3Anwer.Text = TestInfo.StudentAnswer[2];
                lbStudentQ3Tokken.Text = TestInfo.Tokken[2];
                lbCorrectAnswer3.Text = TestInfo.CorrectAnswer[2];

                lbMark.Text = TestInfo.StudentMark.ToString();
            }
            catch { MessageBox.Show(this,"Error No data"); }
        }

        protected void btBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentMain.aspx");
        }
    }
}