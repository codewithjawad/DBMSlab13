using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBMSLAB13.Views.Admin
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            string admin = CEmailTb.Value;
            string pass = PassTb.Value;

            if (admin == "admin@gmail.com" && pass == "Admin")
            {
                Response.Redirect("Employee_info.aspx");
            }
            else
            {
                errormsg.InnerText = "Wrong Credentials";
            }
                CEmailTb.Value = string.Empty;
                PassTb.Value = string.Empty;
            
        }
    }
}