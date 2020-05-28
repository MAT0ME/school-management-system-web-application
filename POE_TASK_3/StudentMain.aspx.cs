using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace POE_TASK_3
{
    public partial class StudentMain : System.Web.UI.Page
    {

        StudentDetails SD = new StudentDetails();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Calling the VuewState Method
            ViewSLoad();

            lbName.Text = StudentDetails.Name;
            lbSurname.Text = StudentDetails.Surname;
            lbStdNumber.Text = StudentDetails.StudentNumber;
        }


        void ViewSLoad()
        {
            //Retrieving Value from a View State
            if (!String.IsNullOrEmpty(Convert.ToString(ViewState["StudentName"])))
            {
                lbName.Text = Convert.ToString(ViewState["StudentName"]);

            }
            if (!String.IsNullOrEmpty(Convert.ToString(ViewState["StudentSurname"])))
            {
                lbSurname.Text = Convert.ToString(ViewState["StudentSurname"]);

            }

            if (!String.IsNullOrEmpty(Convert.ToString(ViewState["StudentNumber"])))
            {
                lbStdNumber.Text = Convert.ToString(ViewState["StudentNumber"]);

            }

        }

        protected void btMemo_Click(object sender, EventArgs e)
        {
            if (StudentTestWrite.Done_Test == true) {
                Response.Redirect("StudentMemoView.aspx");
            }
            else { MessageBox.Show(this,"Write a test before you can view the memo"); }
        }

        protected void btBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btTakeTest_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentTestWrite.aspx");
        }
    }
}