using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class user_User_Details : System.Web.UI.Page
{    
    //Connection to our Database location
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["user"] == null)
        {
            Response.Redirect("userLogin.aspx");
        }

        //Open Connection
        con.Open();
        //Create and return SqlCommand
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        //Write a query that adds inserted fields into the Add_Jobs database
        cmd.CommandText = "select * from User_Registration where Email='" + Session["user"].ToString() + "'";
        //Execute the nonquery
        cmd.ExecuteNonQuery();
        //create a datatable instance
        DataTable dt = new DataTable();
        //create a sql dataAdapter instance
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //add or refresh rows in the database
        da.Fill(dt);
        r1.DataSource = dt;
        r1.DataBind();
        //close connection
        con.Close();
    }
}