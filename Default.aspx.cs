using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            Utilities U = new Utilities();
            string VehicleID = TextBox1.Text;



            string connectionString = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string selectQuery = "SELECT Fines FROM Citizens WHERE VehicleID = @id";


                con.Open();

                using (SqlCommand selectCmd = new SqlCommand(selectQuery, con))
                {
                    selectCmd.Parameters.AddWithValue("@id", U.PreventInjection(VehicleID));
                    object result = selectCmd.ExecuteScalar();

                    if (result != null)
                    {

                        Label1.Text = "عليك مبلغ قدره:" + result.ToString();
                    }
                }
            }

        }
        catch (Exception x)
        {

            Response.Redirect("error.aspx");
        }
    }
}