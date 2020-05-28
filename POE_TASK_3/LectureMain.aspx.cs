using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace POE_TASK_3
{
    public partial class LectureMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btSetTest_Click(object sender, EventArgs e)
        {
            Response.Redirect("LectureClassTest.aspx");
        }

        protected void btViewClassList_Click(object sender, EventArgs e)
        {
            Response.Redirect("LectureClassList.aspx");
        }

        protected void btOldTest_Click(object sender, EventArgs e)
        {
            Response.Redirect("LectureAvailableTest.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}