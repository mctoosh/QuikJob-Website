using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class admin_View_Full_Details : System.Web.UI.Page
{    //Connection to our Database location
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["admin"] == null)
        {
            Response.Redirect("adminLogin.aspx");
        }


        id = Convert.ToInt32(Request.QueryString["id"].ToString());

        //Open Connection
        con.Open();
        //Create and return SqlCommand
        SqlCommand cmd1 = con.CreateCommand();
        cmd1.CommandType = CommandType.Text;
        //Write a query that adds inserted fields into the Add_Jobs database
        cmd1.CommandText = "select * from User_Display where id="+id+"";
        //Execute the nonquery
        cmd1.ExecuteNonQuery();
        //create a datatable instance
        DataTable dt1 = new DataTable();
        //create a sql dataAdapter instance
        SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
        //add or refresh rows in the database
        da1.Fill(dt1);
        r2.DataSource = dt1;
        r2.DataBind();

        //Close Connection
        con.Close();




        //Open Connection
        con.Open();
        //Create and return SqlCommand
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        //Write a query that adds inserted fields into the Add_Jobs database
        cmd.CommandText = "select * from User_Job_Details where Job_Id="+id+"";
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

        //Close Connection
        con.Close();
    }
}