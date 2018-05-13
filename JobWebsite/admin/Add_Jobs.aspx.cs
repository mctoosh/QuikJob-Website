using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ClassLibrary;


public partial class admin_Add_Jobs : System.Web.UI.Page
{
    //Connection to our Database location
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
    //Declare a and b variables
    string a, b;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
        {
            Response.Redirect("adminLogin.aspx");
        }

        if (IsPostBack) return;

        ddl1.Items.Clear();

        //Open connection
        con.Open();
        //Create and return SqlCommand
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        //Write a query that adds inserted fields into the Add_Jobs database
        cmd.CommandText = "select * from Job_Category";
        //Execute the nonquery
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        foreach (DataRow dr in dt.Rows)
        {
            ddl1.Items.Add(dr["Job_Catagory"].ToString());
        }
        //Close Connection
        con.Close();


    }

    protected void btnUpload_Click(object sender, EventArgs e)
    {
        //Use clsRandomiser class to generate 10 random digit numbers  
        a = clsRandomiser.GetRandomPassword(10).ToString();
        //declare the path where the image can be saved and fetched from
        fldJobImage.SaveAs(Request.PhysicalApplicationPath + "./images/" + a + fldJobImage.FileName.ToString());
        //this variable allows the image to be added into the database through using the path
        b = "images/" + a + fldJobImage.FileName.ToString();

        //Open connection
        con.Open();
        //Create and return SqlCommand
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        //Write a query that adds inserted fields into the Add_Jobs database
        cmd.CommandText = "insert into Add_JobsDB values('" + txtJobName.Text + "','" + txtJobType.Text + "','" + txtJobDescription.Text + "','" + txtJobAddress.Text + "','" + txtJobPostcode.Text + "','" + b.ToString()+ "','" +ddl1.SelectedItem.ToString()+"')";
        //Execute the nonquery
        cmd.ExecuteNonQuery();
        //Close Connection
        con.Close();


        txtJobName.Text = "";
        txtJobType.Text = "";
        txtJobDescription.Text = "";
        txtJobAddress.Text = "";
        txtJobPostcode.Text = "";

        lblMessage.Text = "Job Added Succesfully";
    }
}