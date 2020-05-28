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
    public partial class LectureClassTest : System.Web.UI.Page
    {
        bool Test_Exist;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btSave_Click(object sender, EventArgs e)
        {   //////////checking weather the text boxes are filled


            if ((tbQuestion1.Text == "" && tbQuestion2.Text == "" && tbQuestion3.Text == "" &&
                    (tbQ1o1.Text == "" && tbQ1o2.Text == "" && tbQ1o3.Text == null) &&
                    (tbQ2o2.Text == "" && tbQ2o2.Text == "" && tbQ2o3.Text == null) &&
                    (tbQ3o1.Text == "" && tbQ3o2.Text == "" && tbQ3o3.Text == null)))
            {
                MessageBox.Show(this, "Fill in all the required fields before Saving/updating the test");
              

            }
            else
            {
               
                    
                    Test_Update();

               

            }

        }

        protected void btBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("LectureMain.aspx");
        }

        void Saving_to_database()
        {
            int Temp = 1; 

            SqlConnection connection = new SqlConnection(db.db_string);
            

         

            if (Temp == 1)
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand($"INSERT INTO {dbTable.QuestionsTable}({QuestionsTable.ColumnQuestions},{QuestionsTable.ColumnOption1},{QuestionsTable.ColumnOption2},{QuestionsTable.ColumnAnswer})" +
                    $"Values(@Q ,@Q1 ,@Q2, @CA) ", connection);

                cmd.Parameters.AddWithValue("@Q", tbQuestion1.Text);
                cmd.Parameters.AddWithValue("@Q1", tbQ1o2.Text);
                cmd.Parameters.AddWithValue("@Q2", tbQ1o2.Text);
                cmd.Parameters.AddWithValue("@CA", tbQ1o3.Text);

                cmd.ExecuteNonQuery();
                connection.Close();
                Temp = 2;
            }

            if (Temp == 2)
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand($"INSERT INTO {dbTable.QuestionsTable}({QuestionsTable.ColumnQuestions},{QuestionsTable.ColumnOption1},{QuestionsTable.ColumnOption2},{QuestionsTable.ColumnAnswer})" +
                    $"Values(@Q ,@Q1 ,@Q2, @CA) ", connection);

                cmd.Parameters.AddWithValue("@Q", tbQuestion2.Text);
                cmd.Parameters.AddWithValue("@Q1", tbQ2o1.Text);
                cmd.Parameters.AddWithValue("@Q2", tbQ2o1.Text);
                cmd.Parameters.AddWithValue("@CA", tbQ2o1.Text);

                cmd.ExecuteNonQuery();
                connection.Close();
                Temp = 3;
            }

            if (Temp == 3)
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand($"INSERT INTO {dbTable.QuestionsTable}({QuestionsTable.ColumnQuestions},{QuestionsTable.ColumnOption1},{QuestionsTable.ColumnOption2},{QuestionsTable.ColumnAnswer})" +
                    $"Values(@Q ,@Q1 ,@Q2, @CA) ", connection);

                cmd.Parameters.AddWithValue("@Q", tbQuestion3.Text);
                cmd.Parameters.AddWithValue("@Q1", tbQ3o1.Text);
                cmd.Parameters.AddWithValue("@Q2", tbQ3o2.Text);
                cmd.Parameters.AddWithValue("@CA", tbQ3o3.Text);


                cmd.ExecuteNonQuery();
                connection.Close();
                Temp = 2;
            }

            MessageBox.Show(this, "TEST SAVED");

        }

        void Test_Update() {
            




            int Temp = 1;

            SqlConnection connection = new SqlConnection(db.db_string);
          



            if(Temp == 1)
            {
                connection.Open();

//                scm = new SqlCommand("UPDATE questions SET question=@qs, question_o1=@qo1, question_o2=@qo2, question_o3=@qo3,correct_answer=@ca  WHERE q_num=@qn", sc);


                SqlCommand cmd = new SqlCommand($"Update {dbTable.QuestionsTable} SET {QuestionsTable.ColumnQuestions} =@Q,{QuestionsTable.ColumnOption1} =@Q1,{QuestionsTable.ColumnOption2} =@q2,{QuestionsTable.ColumnAnswer} =@CA Where Question_Number=@QN" , connection);

                cmd.Parameters.AddWithValue("@Qn", Temp);
                cmd.Parameters.AddWithValue("@Q", tbQuestion3.Text);
                cmd.Parameters.AddWithValue("@Q1", tbQ1o1.Text);
                cmd.Parameters.AddWithValue("@Q2", tbQ1o2.Text);
                cmd.Parameters.AddWithValue("@CA", tbQ1o3.Text);


                cmd.ExecuteNonQuery();
                connection.Close();
                Temp = 2;

            }
            if (Temp == 2)
            {
                connection.Open();

                //                scm = new SqlCommand("UPDATE questions SET question=@qs, question_o1=@qo1, question_o2=@qo2, question_o3=@qo3,correct_answer=@ca  WHERE q_num=@qn", sc);


                SqlCommand cmd = new SqlCommand($"Update {dbTable.QuestionsTable} SET {QuestionsTable.ColumnQuestions} =@Q,{QuestionsTable.ColumnOption1} =@Q1,{QuestionsTable.ColumnOption2} =@q2,{QuestionsTable.ColumnAnswer} =@CA Where Question_Number=@QN", connection);

                cmd.Parameters.AddWithValue("@Qn", Temp);
                cmd.Parameters.AddWithValue("@Q", tbQuestion3.Text);
                cmd.Parameters.AddWithValue("@Q1", tbQ2o1.Text);
                cmd.Parameters.AddWithValue("@Q2", tbQ2o2.Text);
                cmd.Parameters.AddWithValue("@CA", tbQ2o3.Text);


                cmd.ExecuteNonQuery();
                connection.Close();
                Temp = 3;

            }
            if (Temp == 3)
            {
                connection.Open();

                //                scm = new SqlCommand("UPDATE questions SET question=@qs, question_o1=@qo1, question_o2=@qo2, question_o3=@qo3,correct_answer=@ca  WHERE q_num=@qn", sc);


                SqlCommand cmd = new SqlCommand($"Update {dbTable.QuestionsTable} SET {QuestionsTable.ColumnQuestions} =@Q,{QuestionsTable.ColumnOption1} =@Q1,{QuestionsTable.ColumnOption2} =@q2,{QuestionsTable.ColumnAnswer} =@CA Where Question_Number=@QN", connection);

                cmd.Parameters.AddWithValue("@Qn", Temp);
                cmd.Parameters.AddWithValue("@Q", tbQuestion3.Text);
                cmd.Parameters.AddWithValue("@Q1", tbQ3o1.Text);
                cmd.Parameters.AddWithValue("@Q2", tbQ3o2.Text);
                cmd.Parameters.AddWithValue("@CA", tbQ3o3.Text);


                cmd.ExecuteNonQuery();
                connection.Close();
                Temp = 2;
                MessageBox.Show(this, "Test Succesfully updated");

            }


            

        }


        void Declaration() {

            TestInfo.LectureQuestions.Add(tbQuestion1.Text);
            TestInfo.LectureQuestions.Add(tbQuestion2.Text);
            TestInfo.LectureQuestions.Add(tbQuestion3.Text);



            TestInfo.LectureQuestion1Options.Add(tbQ1o1.Text);

            TestInfo.LectureQuestion1Options.Add(tbQ1o2.Text);

            TestInfo.LectureQuestion1Options.Add(tbQ1o3.Text);



            TestInfo.LectureQuestion1Options.Add(tbQ2o1.Text);
            TestInfo.LectureQuestion1Options.Add(tbQ2o2.Text);
            TestInfo.LectureQuestion1Options.Add(tbQ2o3.Text);


            TestInfo.LectureQuestion1Options.Add(tbQ3o1.Text);
            TestInfo.LectureQuestion1Options.Add(tbQ3o2.Text);
            TestInfo.LectureQuestion1Options.Add(tbQ3o3.Text);



        }

        void Testing() {

            SqlConnection connection = new SqlConnection(db.db_string);

            SqlCommand command = new SqlCommand($"SELECT * FROM {dbTable.QuestionsTable}", connection);

            command.Parameters.AddWithValue("@usr",tbQ1o1.Text);

            SqlDataAdapter adapter = new SqlDataAdapter(command);


            DataTable dt = new DataTable();

            adapter.Fill(dt);

            connection.Open();
            if (dt.Rows.Count > 0)
            {
                Test_Exist = true;
            }

            
            else
            {

               Test_Exist = false;
            }
        }

        protected void tbQuestion2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

class Questions
{

    protected string question;


    public Questions(string q)
    {

        question = q;
    }

    public virtual string getA()
    {
        Console.WriteLine("Parent class area :");
        return "temp";
    }


}
#region Don't look
class Question_1 : Questions
{

    public Question_1(string a) : base(a) { }

    public override string getA()
    {
        Console.WriteLine("Question 1 : ");
        return question;
        //return base.getA();
    }


}

class Question_2 : Questions
{

    public Question_2(string a) : base(a) { }

    public override string getA()
    {
        Console.WriteLine($"Question 2 : ");
        return question;
        //return base.getA();
    }

}

class Question_3 : Questions
{

    public Question_3(string a) : base(a) { }

    public override string getA()
    {
        Console.WriteLine("Question 3 : ");
        return question;
        //return base.getA();
    }


}
#endregion
