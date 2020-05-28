using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace POE_TASK_3
{
    public partial class StudentTestWrite : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection(db.db_string);

        public static bool Done_Test;

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadTest();
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void rbQuestion1o4_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void rbQuestion2o5_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentMain.aspx");
        }


        void LoadTest()
        {
            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand($"SELECT * FROM {dbTable.QuestionsTable}", connection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                //Questions from the database
                TestInfo.Questions.Add(dt.Rows[0][1].ToString());

                TestInfo.Questions.Add(dt.Rows[1][1].ToString());

                TestInfo.Questions.Add(dt.Rows[2][1].ToString());

                //Initialising the correct answer from the database data
                TestInfo.CorrectAnswer.Add(dt.Rows[0][4].ToString());
                TestInfo.CorrectAnswer.Add(dt.Rows[1][4].ToString());
                TestInfo.CorrectAnswer.Add(dt.Rows[2][4].ToString());

                //Questions 1 options 
                TestInfo.Question1Options.Add(dt.Rows[0][4].ToString());
                TestInfo.Question1Options.Add(dt.Rows[0][3].ToString());
                TestInfo.Question1Options.Add(dt.Rows[0][2].ToString());

                //Question 2 options
                TestInfo.Question2Options.Add(dt.Rows[1][2].ToString());
                TestInfo.Question2Options.Add(dt.Rows[1][3].ToString());
                TestInfo.Question2Options.Add(dt.Rows[1][4].ToString());

                //Question 3 options
                TestInfo.Question3Options.Add(dt.Rows[2][3].ToString());
                TestInfo.Question3Options.Add(dt.Rows[2][4].ToString());
                TestInfo.Question3Options.Add(dt.Rows[2][2].ToString());

                //Manupulating the lables to fill questions from the database
                lbQuestion1.Text = TestInfo.Questions[0];
                lbQuestion2.Text = TestInfo.Questions[1];
                lbQuestion3.Text = TestInfo.Questions[2];

                //Manupulating the radio buttons
                //Question 1
                rbQuestion1o1.Text = TestInfo.Question1Options[1];
                rbQuestion1o2.Text = TestInfo.Question1Options[2];
                rbQuestion1o3.Text = TestInfo.Question1Options[0];

                //Manupulating the radio buttons
                //Question 2
                rbQuestion2o1.Text = TestInfo.Question2Options[0];
                rbQuestion2o2.Text = TestInfo.Question2Options[2];
                rbQuestion2o3.Text = TestInfo.Question2Options[1];

                //Manupulating the radio buttons
                //Question 3
                rbQuestion3o1.Text = TestInfo.Question3Options[0];
                rbQuestion3o2.Text = TestInfo.Question3Options[1];
                rbQuestion3o3.Text = TestInfo.Question3Options[2];
                connection.Close();
            }
            catch (SqlException e) { MessageBox.Show(this, e.ToString()); }

        }

        void TestMark()
        {

            try
            {
                int Temp = 0;

                //Checking for the checked box at Question 1
                if (rbQuestion1o1.Checked) { TestInfo.StudentAnswer.Add(rbQuestion1o1.Text); Temp = +1; }
                else if (rbQuestion1o2.Checked) { TestInfo.StudentAnswer.Add(rbQuestion1o2.Text); Temp = +1; }
                else if (rbQuestion1o3.Checked) { TestInfo.StudentAnswer.Add(rbQuestion1o3.Text); Temp = +1; }
                else { TestInfo.StudentAnswer.Add("Temp"); }

                //Checking for the checked box at Question 2
                if (rbQuestion2o1.Checked) { TestInfo.StudentAnswer.Add(rbQuestion1o1.Text); Temp = +1; }
                else
                if (rbQuestion2o2.Checked) { TestInfo.StudentAnswer.Add(rbQuestion2o2.Text); Temp = +1; }
                else
                if (rbQuestion2o3.Checked) { TestInfo.StudentAnswer.Add(rbQuestion2o3.Text); Temp = +1; }
                else { TestInfo.StudentAnswer.Add("Temp"); }

                //Checking for the checked box at Question 3
                if (rbQuestion3o1.Checked) { TestInfo.StudentAnswer.Add(rbQuestion1o1.Text); Temp = +1; }
                else if (rbQuestion3o2.Checked) { TestInfo.StudentAnswer.Add(rbQuestion2o2.Text); Temp = +1; }
                else if (rbQuestion3o3.Checked) { TestInfo.StudentAnswer.Add(rbQuestion3o3.Text); Temp = +1; }
                else { TestInfo.StudentAnswer.Add("Temp"); }


                //Comparering the student answers and the answers set by lecture from database
                if (TestInfo.StudentAnswer[0] == TestInfo.CorrectAnswer[0]) { TestInfo.StudentMark = +1; TestInfo.Tokken.Add("✔"); } else { TestInfo.Tokken.Add("✖"); }
                if (TestInfo.StudentAnswer[1] == TestInfo.CorrectAnswer[1]) { TestInfo.StudentMark = +1; TestInfo.Tokken.Add("✔"); } else { TestInfo.Tokken.Add("✖"); }
                if (TestInfo.StudentAnswer[2] == TestInfo.CorrectAnswer[2]) { TestInfo.StudentMark = +1; TestInfo.Tokken.Add("✔"); } else { TestInfo.Tokken.Add("✖"); }

                Double t = TestInfo.StudentMark / 3;

                TestInfo.perc = t * 100;

                if (Temp == 3)
                {
                    MessageBox.Show(this, "Test saved Successfuly");
                    Done_Test = true;

                    Save_info_database();

                    Response.Redirect("StudentMain.aspx");

                }
                else if (Temp != 3)
                {
                    MessageBox.Show(this, "Test saved Successfuly But not Completed");
                    Save_info_database();
                    Done_Test = true;

                    Response.Redirect("StudentMain.aspx");
                }
            }
            catch { MessageBox.Show(this, "Error Database Offline"); }


        }

        void Save_info_database()
        {
            try
            {


                StudentDetails SD = new StudentDetails();

                connection.Open();


                //Saving the student results to the database
                SqlCommand command = new SqlCommand($"INSERT INTO {dbTable.StudentMarksTable} ({StudentMarksTable.ColumnName},{StudentMarksTable.ColumnSurname},{StudentMarksTable.ColumnMark},{StudentMarksTable.ColumnPecentage}) values(@N, @S, @M, @P)", connection);

                command.Parameters.AddWithValue("@N", StudentDetails.Name);
                command.Parameters.AddWithValue("@S", StudentDetails.Surname);
                command.Parameters.AddWithValue("@M", TestInfo.StudentMark);
                command.Parameters.AddWithValue("@P", TestInfo.perc);


                command.ExecuteNonQuery();

                connection.Close();
            }
            catch
            {
                MessageBox.Show(this, "Erro couldn't save to database");
            }




        }

        protected void btSubmit_Click(object sender, EventArgs e)
        {
            TestMark();
        }
    }
}