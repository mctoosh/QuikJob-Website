using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class admin_Delete : System.Web.UI.Page
{
    string category;
    //Connection to our Database location
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        category = Request.QueryString["category"].ToString();
        //Open connection
        con.Open();
        //Create and return SqlCommand
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        //Write a query that adds inserted fields into the Add_Jobs database
        cmd.CommandText = "delete from Job_Category where Job_Catagory = '"+category.ToString()+"'";
        //Execute the nonquery
        cmd.ExecuteNonQuery();


        SqlCommand cmd1 = con.CreateCommand();
        cmd1.CommandType = CommandType.Text;
        //Write a query that adds inserted fields into the Add_Jobs database
        cmd1.CommandText = "delete from Add_JobsDB where Job_Category = '" + category.ToString() + "'";
        //Execute the nonquery
        cmd1.ExecuteNonQuery();

        con.Close();

        Response.Redirect("Add_Category.aspx");
    }
}