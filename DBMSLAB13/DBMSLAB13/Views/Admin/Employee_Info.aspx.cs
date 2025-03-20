using System;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBMSLAB13
{
    public partial class EmployeeInformation : System.Web.UI.Page
    {
        private static string connectionString = "Data Source=JAWWAD-PC\\SQLEXPRESS;Initial Catalog=pms;Integrated Security=True;Encrypt=False";
        SqlConnection connection = new SqlConnection(connectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }
        }

        private void BindGridView()
        {
            try
            {
                SqlCommand command = new SqlCommand("ListEmployee", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                emplist.DataSource = reader;
                emplist.DataBind();
            }
            catch (Exception ex)
            {
                lblMessage.Text = "An error occurred: " + ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }
        protected void btnInsert_OnClick(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(empsalary.Text) > 0 && DateTime.Parse(txtdob.Text) < System.DateTime.Now)
                {
                SqlCommand command = new SqlCommand("InsertEmployee", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@emp_name", txtName.Text);
                command.Parameters.AddWithValue("@emp_address", txtAddress.Text);
                command.Parameters.AddWithValue("@emp_phone", txtphone.Text);
                command.Parameters.AddWithValue("@emp_email", txtEmail.Text);
                command.Parameters.AddWithValue("@emp_DOB", txtdob.Text);
                command.Parameters.AddWithValue("@emp_DOJ", txtdoj.Text);
                command.Parameters.AddWithValue("@emp_position", txtposition.Text);
                command.Parameters.AddWithValue("@emp_salary", empsalary.Text);
                connection.Open();
                command.ExecuteNonQuery();
                lblMessage.Text = "Record inserted successfully!";

                }
                else
                {
                    lblMessage.Text = "salary must be greater than 0";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "There is an error: " + ex.Message;
            }
            finally
            {
                connection.Close();
                BindGridView();
            }
        }

        protected void btnUpdate_OnClick(object sender, EventArgs e)
        {
            try
            {
                if (emplist.SelectedRow == null)
                {
                    lblMessage.Text = "Please select a record to update.";
                    return;
                }

                int empId = int.Parse(emplist.SelectedRow.Cells[1].Text);

                SqlCommand command = new SqlCommand("UpdateEmployee", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@emp_id", empId);
                command.Parameters.AddWithValue("@emp_name", txtName.Text);
                command.Parameters.AddWithValue("@emp_address", txtAddress.Text);
                command.Parameters.AddWithValue("@emp_phone", txtphone.Text);
                command.Parameters.AddWithValue("@emp_email", txtEmail.Text);
                command.Parameters.AddWithValue("@emp_DOB", txtdob.Text);
                command.Parameters.AddWithValue("@emp_DOJ", txtdoj.Text);
                command.Parameters.AddWithValue("@emp_position", txtposition.Text);
                command.Parameters.AddWithValue("@emp_salary", empsalary.Text);
                connection.Open();
                command.ExecuteNonQuery();
                lblMessage.Text = "Record updated successfully!";
            }
            catch (Exception ex)
            {
                lblMessage.Text = "There is an error: " + ex.Message;
            }
            finally
            {
                connection.Close();
                BindGridView();
            }
        }

        protected void btnDelete_OnClick(object sender, EventArgs e)
        {
            try
            {
                if (emplist.SelectedRow == null)
                {
                    lblMessage.Text = "Please select a record to delete.";
                    return;
                }

                int empId = int.Parse(emplist.SelectedRow.Cells[1].Text);

                // Delete associated feedback records first
                DeleteFeedbackRecords(empId);

                // Then delete the employee record
                SqlCommand command = new SqlCommand("DeleteEmployee", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@emp_id", empId);
                connection.Open();
                command.ExecuteNonQuery();
                lblMessage.Text = "Record deleted successfully!";
            }
            catch (Exception ex)
            {
                lblMessage.Text = "There is an error: " + ex.Message;
            }
            finally
            {
                connection.Close();
                BindGridView();
            }
        }

        private void DeleteFeedbackRecords(int empId)
        {
            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM feedback WHERE emp_id = @empId", connection);
                command.Parameters.AddWithValue("@empId", empId);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                lblMessage.Text = "An error occurred while deleting associated feedback records: " + ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }

        protected void emplist_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtEmployeeID.Text = emplist.SelectedRow.Cells[0].Text;
            txtName.Text = emplist.SelectedRow.Cells[2].Text;
            txtAddress.Text = emplist.SelectedRow.Cells[3].Text;
            txtphone.Text = emplist.SelectedRow.Cells[4].Text;
            txtEmail.Text = emplist.SelectedRow.Cells[5].Text;
            txtdob.Text = emplist.SelectedRow.Cells[6].Text;
            txtdoj.Text = emplist.SelectedRow.Cells[7].Text;
            txtposition.Text = emplist.SelectedRow.Cells[8].Text;
            empsalary.Text = emplist.SelectedRow.Cells[9].Text;
        }
    }
}
