using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class user_Display_AllJobs : System.Web.UI.Page
{
    //Connection to our Database
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        //Open connection
        con.Open();
        //Create and return SqlCommand
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
       
        if (Request.QueryString["category"] == null)
        {
           //Write a query that gets everything from the Add_Jobs database so they could be displayed
            cmd.CommandText = "select * from Add_JobsDB";
        }
        else
        {
            //Write a query that gets everything from the Add_Jobs database so they could be displayed
            cmd.CommandText = "select * from Add_JobsDB where Job_Category='"+ Request.QueryString["category"].ToString() + "'";
        }
        //if user did not click on a category and user clicks on the search text box
        if (Request.QueryString["category"] == null && Request.QueryString["search"] != null)
        {
            //If there are any searches made that is similar to the job name then display it
            cmd.CommandText = "select * from Add_JobsDB where Job_Name like('%" + Request.QueryString["search"].ToString() + "%')";
        }



            //Execute the nonquery
            cmd.ExecuteNonQuery();
        //create a datatable instance
        DataTable dt = new DataTable();
        //create a sql dataAdapter instance
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //add or refresh rows in the database
        da.Fill(dt);
        //display the data to the repeater tag
        rptMain.DataSource = dt;
        rptMain.DataBind();

        //close connection
        con.Close();

    }
}