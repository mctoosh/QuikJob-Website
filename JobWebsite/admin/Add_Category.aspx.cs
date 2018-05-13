using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class admin_Add_Category : System.Web.UI.Page
{
    //Connection to our Database location
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["admin"] == null)
        {
            Response.Redirect("adminLogin.aspx");
        }

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
        dd1.DataSource = dt;
        dd1.DataBind();
        
    }

    protected void btnAddCat_Click(object sender, EventArgs e)
    {
        
        //Create and return SqlCommand
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        //Write a query that adds inserted fields into the Add_Jobs database
        cmd.CommandText = "insert into Job_Category values('"+txtCategory.Text+"')";
        //Execute the nonquery
        cmd.ExecuteNonQuery();
        //Close Connection
        con.Close();

        Response.Write("<script>alert('Job Category has successfully been added');</script>");

        txtCategory.Text = "";
    }
}