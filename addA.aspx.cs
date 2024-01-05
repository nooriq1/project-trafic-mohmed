using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class addA : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Redirect("adminlogin.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string username = TextBox1.Text;
        string password = TextBox2.Text;
        string connectionString = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string insertQuery = "insert admin values(@u,@p)";
            con.Open();
            using (SqlCommand insertcmd = new SqlCommand(insertQuery, con))
            {
                insertcmd.Parameters.AddWithValue("@u", username);
                insertcmd.Parameters.AddWithValue("@p", password);
                int rowsAffected = insertcmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Response.Write("User added successfully!");
                    
                }
                else
                {
                    Response.Write("User addition failed!");
                }
            }
        }


    }
}