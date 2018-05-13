using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_Delete_Job : System.Web.UI.Page
{
    //declare s variable
    string s;
    //declare t variable
    string t;
    //declare an array variable
    string[] a = new string[15];
    //declare an id variable
    int id;
    //Declare Add_Job database coloumns variables
    string Job_Name, Job_Type, Job_Description, Job_Address, Job_Postcode, Job_Image;
    //declare an count variable with a value
    int count = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Declare the id vlaue
        id = Convert.ToInt32(Request.QueryString["id"].ToString());

        //create a datatable instance
        DataTable dt = new DataTable();
        //clear datatable rows
        dt.Rows.Clear();
        //create a temporary data coloumn tables so that cookies data's could be stored on to the data coloumn table
        dt.Columns.AddRange(new DataColumn[7] { new DataColumn("Job_Name"), new DataColumn("Job_Type"), new DataColumn("Job_Description"), new DataColumn("Job_Address"), new DataColumn("Job_Postcode"), new DataColumn("Job_Image"), new DataColumn("id") });
        
        //If there is cookies in the system 
        if (Request.Cookies["aa"] != null)
        {
            //the cookies is stored in the s variable
            s = Convert.ToString(Request.Cookies["aa"].Value);
            //the records are split using the Pipe sign
            string[] strArr = s.Split('|');

            //for loop to split the records using the comma sign
            for (int i = 0; i < strArr.Length; i++)
            {
                t = Convert.ToString(strArr[i].ToString());
                string[] strArr1 = t.Split(',');
                for (int j = 0; j < strArr1.Length; j++)
                {
                    //the record is stored in an array variable
                    a[j] = strArr1[j].ToString();
                }
                //the array variable value is passed on to the datatable
                dt.Rows.Add(a[0].ToString(), a[1].ToString(), a[2].ToString(), a[3].ToString(), a[4].ToString(), a[5].ToString(), i.ToString());
            }
        }
        //remove record from the datatable
        dt.Rows.RemoveAt(id);

        //clear cookies
        Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-1);
        //clear cookies
        Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-1);

        //for loop table where the values are taken from the datatable and are stored in the variables
        foreach (DataRow dr in dt.Rows)
        {
            Job_Name = dr["Job_Name"].ToString();
            Job_Type = dr["Job_Type"].ToString();
            Job_Description = dr["Job_Description"].ToString();
            Job_Address = dr["Job_Address"].ToString();
            Job_Postcode = dr["Job_Postcode"].ToString();
            Job_Image = dr["Job_Image"].ToString();

            count = count + 1;

            if (count == 1)
            {
                //create aa cookies and add cookies into the system from the database seperating them with comma
                Response.Cookies["aa"].Value = Job_Name.ToString() + "," + Job_Type.ToString() + "," + Job_Description.ToString() + "," + Job_Address.ToString() + "," + Job_Postcode.ToString() + "," + Job_Image.ToString() + "," + id.ToString();
                //clear cookies every 24 hours
                Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);
            }
            else
            {
                //request the cookies and devide them with pipe sign
                Response.Cookies["aa"].Value = Request.Cookies["aa"].Value + "|" + Job_Name.ToString() + "," + Job_Type.ToString() + "," + Job_Description.ToString() + "," + Job_Address.ToString() + "," + Job_Postcode.ToString() + "," + Job_Image.ToString() + "," + id.ToString();
                //clear cookies every 24 hours
                Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);
            }
        }
        //redirect page to View_Jobs page
        Response.Redirect("View_Jobs.aspx");

    }
}