using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class user_Update_User_Details : System.Web.UI.Page
{
    //Connection to our Database
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["user"] == null)
        {
            Response.Redirect("userLogin.aspx");
        }

        if (IsPostBack) {
            return;
        }
        //Open connection
        con.Open();
        //Create and return SqlCommand
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        //Write a query that gets everything from the Add_Jobs database so they could be displayed
        cmd.CommandText = "select * from User_Registration where Email='"+Session["user"].ToString()+"'";
        //Execute the nonquery
        cmd.ExecuteNonQuery();
        //create a datatable instance
        DataTable dt = new DataTable();
        //create a sql dataAdapter instance
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //add or refresh rows in the database
        da.Fill(dt);
        foreach (DataRow dr in dt.Rows)
        {
            txtFName.Text = dr["First_Name"].ToString();
            txtLastName.Text = dr["Last_Name"].ToString();
            txtEmail.Text = dr["Email"].ToString();
            txtAddress.Text = dr["Address"].ToString();
            txtPostcode.Text = dr["Postcode"].ToString();
            txtAge.Text = dr["Age"].ToString();
            txtPhoneNumber.Text = dr["Phone_Number"].ToString();
        }
        //close connection
        con.Close();
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        //Open connection
        con.Open();
        //Create and return SqlCommand
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        //Write a query that gets everything from the Add_Jobs database so they could be displayed
        cmd.CommandText = "update User_Registration set First_Name='"+txtFName.Text+"', Last_Name='"+txtLastName.Text+"', Email='"+txtEmail.Text+"', Address='"+txtAddress.Text+"', Postcode='"+txtPostcode.Text+"', Age='"+txtAge.Text+"', Phone_Number='"+txtPhoneNumber.Text+"' where email='" + Session["user"].ToString() + "'";
        //Execute the nonquery
        cmd.ExecuteNonQuery();
        //close connection
        con.Close();

        Response.Redirect("Applicaton_Calculation.aspx");
    }
}