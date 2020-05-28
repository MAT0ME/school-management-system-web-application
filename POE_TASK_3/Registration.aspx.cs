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
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //  int RandNumber = RandNumber(100, 999);
        }

        protected void btSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" && tbPassword.Text == "" && tbStudentNumber.Text == "" && tbSurname.Text == "")
            {
                MessageBox.Show(this, "Fill in all the required fields");
            }
            else {
                studentCheck();

                //Response.Redirect("Default.aspx");
            }
        }
        public static int RandNumber(int Low, int High)
        {
            Random randNum = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber));

            int rand = randNum.Next(Low, High);

            return rand;
        }

        void Save_Details(){

            SqlConnection connection = new SqlConnection(db.db_string);
            //create table Registration(Student_Number varchar(100),Password_ varchar(100), Name varchar(50), Surname varchar(50))
            connection.Open();

            SqlCommand cmd = new SqlCommand($"INSERT INTO {dbTable.StudentLoginTable}(Student_Number,Password_ , Name , Surname ) values(@STd,@P ,@N, @S)",connection);

            cmd.Parameters.AddWithValue("@STd", tbStudentNumber.Text);
            cmd.Parameters.AddWithValue("@P", tbPassword.Text);
            cmd.Parameters.AddWithValue("@N", tbName.Text);
            cmd.Parameters.AddWithValue("@S", tbSurname.Text);

            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show(this,"Student Details Saved");

            tbName.Text = "";
            tbPassword.Text = "";
            tbStudentNumber.Text = "";
            tbSurname.Text = "";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        void studentCheck() {

            SqlConnection connection = new SqlConnection(db.db_string);

            SqlCommand command = new SqlCommand($"SELECT * FROM {dbTable.StudentLoginTable} where Student_Number=@pass", connection);

            
            command.Parameters.AddWithValue("@pass", tbStudentNumber.Text);

            SqlDataAdapter adapter = new SqlDataAdapter(command);


            DataTable dt = new DataTable();

            adapter.Fill(dt);

            connection.Open();
            if (dt.Rows.Count > 0)
            {


                MessageBox.Show(this,"Student Number Exist");


            }
            else
            {

                Save_Details();
            }

            connection.Close();
        }
    }
}