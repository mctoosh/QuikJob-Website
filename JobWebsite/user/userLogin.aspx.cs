using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class user_userLogin : System.Web.UI.Page
{
    //Connection to our Database location
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
    int tot = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //Open connection
        con.Open();
        //Create and return SqlCommand
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        //Write a query that adds inserted fields into the database
        cmd.CommandText = "select * from User_Registration where Email='"+txtEmail.Text+"' and Password='"+txtPassword.Text+"'";
        //Execute the nonquery
        cmd.ExecuteNonQuery();
        //create a datatable instance
        DataTable dt = new DataTable();
        //create a sql dataAdapter instance
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //add or refresh rows in the database
        da.Fill(dt);
        tot = Convert.ToInt32(dt.Rows.Count.ToString());

        if (tot > 0)
        {
            if (Session["Applybutton"] == "yes")
            {
                Session["user"] = txtEmail.Text;
                Response.Redirect("Update_User_Details.aspx");
            }
            else
            {
                Session["user"] = txtEmail.Text;
                Response.Redirect("User_Details.aspx");
            }
        }
        else
        {
            lblMessage.Text = "Invalid Username or Password";
        }


        //Close Connection
        con.Close();
    }
}