using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class aadF : System.Web.UI.Page
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
        Utilities U = new Utilities();
        string VehicleID = TextBox1.Text;
        string Fines = TextBox2.Text;
        int oldf = 0; // Initialize oldf

        string connectionString = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string selectQuery = "SELECT Fines FROM Citizens WHERE VehicleID = @id";
            string updateQuery = "UPDATE Citizens SET Fines = @f WHERE VehicleID = @id";

            con.Open();

            // First, retrieve the current fines
            using (SqlCommand selectCmd = new SqlCommand(selectQuery, con))
            {
                selectCmd.Parameters.AddWithValue("@id", VehicleID);
                object result = selectCmd.ExecuteScalar();

                if (result != null)
                {
                    oldf = (int)result;
                    Label1.Text = oldf.ToString();
                }
            }

            // Then, update the fines
            using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
            {
                updateCmd.Parameters.AddWithValue("@id", VehicleID);
                updateCmd.Parameters.AddWithValue("@f", Fines);

                int rowsAffected = updateCmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Response.Write("Update successful");
                }
                else
                {
                    Response.Write("Update failed");
                }
            }
        }
    }

}