using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace POE_TASK_3
{
    public partial class LectureAvailableTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("LectureMain.aspx");
        }
    }
}