using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class user_Application_Success : System.Web.UI.Page
{
    //Connection to our Database
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

    string Job = "";
    string Job_Id;
    string s;
    string t;
    string[] a = new string[15];
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        Job = Request.QueryString["Job"].ToString();

        if (Job == Session["Job_No"].ToString())
        {
            //This is for getting user details and storing it on Job Details

            //Create and return SqlCommand
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //Write a query that gets everything from the Add_Jobs database so they could be displayed
            cmd.CommandText = "select * from User_Registration where Email='" + Session["user"].ToString() + "'";
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
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "insert into User_Display values('" + dr["First_Name"].ToString() + "', '" + dr["Last_Name"].ToString() + "', '" + dr["Email"].ToString() + "', '" + dr["Address"].ToString() + "', '" + dr["Postcode"].ToString() + "', '" + dr["Age"].ToString() + "', '" + dr["Phone_Number"].ToString() + "', '" + dr["User_CV"].ToString() + "')";
                cmd1.ExecuteNonQuery();
            }

            //end storing user details

            //start to get Job id from user table

            //Create and return SqlCommand
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            //Write a query that gets everything from the Add_Jobs database so they could be displayed
            cmd2.CommandText = "select top 1 * from User_Display where User_Email='" + Session["user"].ToString() + "' order by id desc ";
            //Execute the nonquery
            cmd2.ExecuteNonQuery();
            //create a datatable instance
            DataTable dt2 = new DataTable();
            //create a sql dataAdapter instance
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            //add or refresh rows in the database
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                Job_Id = dr2["Id"].ToString();
            }

            //End of getting job id

            if (Request.Cookies["aa"] != null)
            {
                s = Convert.ToString(Request.Cookies["aa"].Value);
                string[] strArr = s.Split('|');
                for (int i = 0; i < strArr.Length; i++)
                {
                    t = Convert.ToString(strArr[i].ToString());
                    string[] strArr1 = t.Split(',');
                    for (int j = 0; j < strArr1.Length; j++)
                    {
                        a[j] = strArr1[j].ToString();
                    }

                    SqlCommand cmd3 = con.CreateCommand();
                    cmd3.CommandType = CommandType.Text;
                    cmd3.CommandText = "insert into User_Job_Details values('" + Job_Id.ToString() + "', '" + a[0].ToString() + "', '" + a[2].ToString() + "', '" + a[3].ToString() + "', '" + a[5].ToString() +"')";
                    cmd3.ExecuteNonQuery();
                }

            }
            //end of getting user Jobs cookies

            else
            {
                Response.Redirect("User_Login.aspx");
            }

                    con.Close();

                    Session["user"] = "";
                    Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-1);

                    Response.Redirect("Display_AllJobs.aspx");

                }
            }
        }
