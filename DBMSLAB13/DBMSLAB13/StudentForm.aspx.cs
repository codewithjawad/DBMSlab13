using System;
using System.Data.SqlClient;

namespace DBMSLAB13
{
    public partial class StudentForm : System.Web.UI.Page
    {
        private static string connString = "Data Source=JAWWAD-PC\\SQLEXPRESS;Initial Catalog=dbmslab13;Integrated Security=True;Encrypt=False";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }
        }

        private void BindGridView()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENT", sqlConnection);
                    sqlConnection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    GridView1.DataSource = reader;
                    GridView1.DataBind();
                }
                catch (Exception ex)
                {
                    errormsg.Text = "There is an error: " + ex.Message;
                }
            }
        }

        protected void btnInsert_OnClick(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand sql = new SqlCommand("INSERT_DATA", sqlConnection);
                    sql.CommandType = System.Data.CommandType.StoredProcedure;
                    sql.Parameters.AddWithValue("@ID", int.Parse(txtbStdID.Text));
                    sql.Parameters.AddWithValue("@NAME", txtbStdname.Text);
                    sql.Parameters.AddWithValue("@AGE", int.Parse(txtbStdage.Text));
                    sql.Parameters.AddWithValue("@GRADE", txtbStdgrade.Text);
                    sqlConnection.Open();
                    sql.ExecuteNonQuery();

                    errormsg.Text = "";
                }
                catch (Exception ex)
                {
                    errormsg.Text = "There is an error: " + ex.Message;
                }
            }
            BindGridView();
        }

        protected void btnUpdate_OnClick(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand sql = new SqlCommand("UPDATE_DATA", sqlConnection);
                    sql.CommandType = System.Data.CommandType.StoredProcedure;
                    sql.Parameters.AddWithValue("@ID", int.Parse(txtbStdID.Text));
                    sql.Parameters.AddWithValue("@NAME", txtbStdname.Text);
                    sql.Parameters.AddWithValue("@AGE", int.Parse(txtbStdage.Text));
                    sql.Parameters.AddWithValue("@GRADE", txtbStdgrade.Text);
                    sqlConnection.Open();
                    sql.ExecuteNonQuery();

                    errormsg.Text = "";
                }
                catch (Exception ex)
                {
                    errormsg.Text = "There is an error: " + ex.Message;
                }
            }
            BindGridView();
        }

        protected void btnDelete_OnClick(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                try
                {
                    SqlCommand sql = new SqlCommand("DELETE_DATA", sqlConnection);
                    sql.CommandType = System.Data.CommandType.StoredProcedure;
                    sql.Parameters.AddWithValue("@ID", int.Parse(txtbStdID.Text));
                    sqlConnection.Open();
                    sql.ExecuteNonQuery();

                    errormsg.Text = "";
                }
                catch (Exception ex)
                {
                    errormsg.Text = "There is an error: " + ex.Message;
                }
            }
            BindGridView();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
                   }
    }
}
