using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class admin_adminLogin : System.Web.UI.Page
{

    //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;AttachDbFilename=H:\Year 3\Team Development Project\MainJobPortalProject\App_Data\JobsDB.mdf");
    
    //Connection to our Database      
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
    
    //Declare i variable
    int i;
    protected void Page_Load(object sender, EventArgs e)
    {
      
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //Initilise i
        i = 0;
        //Open connection
        con.Open();
        //Create and return SqlCommand
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        //Write query that fetches data from the database that allows admin to login to the system 
        cmd.CommandText = "select * from admin_loginDB where username='"+txtUser.Text+"' and password='"+txtPassword.Text+"'";
        //Execute the nonquery 
        cmd.ExecuteNonQuery();
        //create a datatable instance
        DataTable dt = new DataTable();
        //create a sql dataAdapter instance
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //add or refresh rows in the database
        da.Fill(dt);
        i = Convert.ToInt32(dt.Rows.Count.ToString());

        if (i == 1)
        {
            Session["admin"] = txtUser.Text;
            //If data is found from the database take the admin to the Add_Jobs page
            Response.Redirect("Display_Jobs_Applied.aspx");
        }
        else
        {
            //If no data is found prompt error message 
            lblError.Text = "You Have Entered Invalid Username or Password";
        }
        //Close Connection 
        con.Close();
    }
}