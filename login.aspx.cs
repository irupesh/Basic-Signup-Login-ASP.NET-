using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    string conString = ConfigurationManager.ConnectionStrings["DBcon"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(conString);
        con.Open();
        string query = "SELECT * FROM [training].[dbo].[user] WHERE email ='" + txtEmail.Text + "' and password ='" + txtPassword.Text + "'";
        SqlCommand cmd = new SqlCommand(query, con);
        DataSet ds = new DataSet();
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        sda.Fill(ds);
        if (ds.Tables[0].Rows.Count == 0)
        {
            Label3.Text = "Invalid email or password";
        }
        else
            Label3.Text = "Login Sucessfull";
        con.Close();
    }
    protected void txtEmail_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
}