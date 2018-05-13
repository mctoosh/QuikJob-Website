using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class user_Job_Description : System.Web.UI.Page
{
    //Connection to our Database
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
    //Declare id variable
    int id;
    //Declare Add_Job database coloumns variables
    string Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image;
    protected void Page_Load(object sender, EventArgs e)
    {
        //if id is null
        if (Request.QueryString["id"] == null)
        {
            //redirect the page to Display_AllJobs web page
            Response.Redirect("Display_AllJobs.aspx");
        }
        else
        {
            //Declare the id vlaue
            id = Convert.ToInt32(Request.QueryString["id"].ToString());
            //open connection
            con.Open();
            //Create and return SqlCommand
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //Write query that selects everything from Add_Jobs Database where the JobId is the same as id
            cmd.CommandText = "select * from Add_JobsDB where JobId=" + id + "";
            //Execute the nonquery
            cmd.ExecuteNonQuery();
            //create a datatable instance
            DataTable dt = new DataTable();
            //create a sql dataAdapter instance
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //add or refresh rows in the database
            da.Fill(dt);
            //display the data to the repeater tag
            rptMain1.DataSource = dt;
            rptMain1.DataBind();

            //close connection
            con.Close();
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //open connection
        con.Open();
        //Create and return SqlCommand
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        //Write query that selects everything from Add_Jobs Database where the JobId is the same as id
        cmd.CommandText = "select * from Add_JobsDB where JobId=" + id + "";
        //Execute the nonquery
        cmd.ExecuteNonQuery();
        //create a datatable instance
        DataTable dt = new DataTable();
        //create a sql dataAdapter instance
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //add or refresh rows in the database
        da.Fill(dt);

        //for loop which gets the values from the database and displays them on to the web page 
        foreach (DataRow dr in dt.Rows)
        {
            Job_Name = dr["Job_Name"].ToString();
            Job_Type = dr["Job_Type"].ToString();
            Job_Description = dr["Job_Description"].ToString();
            Job_Address = dr["Job_Address"].ToString();
            Job_Postcode = dr["Job_Postcode"].ToString();
            Job_Image = dr["Job_Image"].ToString();
        }
        //close connection 
        con.Close();

        //if cookies is null 
        if (Request.Cookies["aa"] == null)
        {
            //create aa cookies and add cookies into the system from the database seperating with comma
            Response.Cookies["aa"].Value = Job_Name.ToString() + "," + Job_Type.ToString() + "," + Job_Description.ToString() + "," + Job_Address.ToString() + "," + Job_Postcode.ToString() + "," + Job_Image.ToString();
            //clear cookies every 24 hours
            Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);
        }
        //else if there is a cookie that exists in the system already
        else
        {
            //request the cookies and devide them with pipe sign
            Response.Cookies["aa"].Value = Request.Cookies["aa"].Value + "|" + Job_Name.ToString() + "," + Job_Type.ToString() + "," + Job_Description.ToString() + "," + Job_Address.ToString() + "," + Job_Postcode.ToString() + "," + Job_Image.ToString();
            //clear cookies every 24 hours
            Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);
        }
        //redirect the page to View_Jobs page
        Response.Redirect("View_Jobs.aspx");

    }

}