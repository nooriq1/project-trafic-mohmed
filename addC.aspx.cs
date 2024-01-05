using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class addC : System.Web.UI.Page
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
        string VehicleID = TextBox1.Text;
        string Name = TextBox2.Text;
        string connectionString = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string insertQuery = "insert Citizens values(@u,0,@p)";
            con.Open();
            using (SqlCommand insertcmd = new SqlCommand(insertQuery, con))
            {
                insertcmd.Parameters.AddWithValue("@u", VehicleID);
                insertcmd.Parameters.AddWithValue("@p", Name);
                int rowsAffected = insertcmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Response.Write("Citizens added successfully!");
                    
                }
                else
                {
                    Response.Write("Citizens addition failed!");
                }
            }
        }



    }
}