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
    public partial class LectureClassList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // Gridload();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void Gridload() {

            SqlConnection connection = new SqlConnection(db.db_string);

            connection.Open();

            SqlCommand command = new SqlCommand($"SELECT * FROM MARKS", connection);


            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.ExecuteNonQuery();

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            GridView1.DataSource = dt;

            connection.Close();






        }

        protected void btBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("LectureMain.aspx");
        }
    }
}