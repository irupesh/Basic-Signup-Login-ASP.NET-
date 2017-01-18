using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class signup : System.Web.UI.Page
{
    string conString = ConfigurationManager.ConnectionStrings["DBcon"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(conString);
        con.Open();
        string query = "INSERT INTO [training].[dbo].[user] values('" + txtName.Text + "','" + txtEmail.Text + "','" + txtPassword.Text + "')";
        SqlCommand cmd = new SqlCommand(query, con);
        cmd.ExecuteNonQuery();
        con.Close();
        Label5.Text = "Sucessfull";
        Response.Redirect("login.aspx");
    }
}