using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class adminlogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
            Utilities U = new Utilities();
            string username = TextBox1.Text;
            string password = TextBox2.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM admin WHERE username_admin = @username AND password_admin = @password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", U.PreventInjection(username));
                    cmd.Parameters.AddWithValue("@password", U.PreventInjection(password));

                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Use session for authentication
                        Session["user"] = reader["username_admin"].ToString();
                        Response.Redirect("admin.aspx");
                    }
                    else
                    {
                        // Avoid exposing detailed error messages
                        Label1.Text = "Invalid username or password";
                    }
                }
            }
        
    }


}