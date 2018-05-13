using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_View_Jobs : System.Web.UI.Page
{
    //declare s variable
    string s;
    //declare t variable
    string t;
    //declare an array variable
    string[] a = new string[10];
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a datatable instance
        DataTable dt = new DataTable();
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

        //the values are displayed on the datalist tag 
        dtlList.DataSource = dt;
        dtlList.DataBind();
    }



    protected void btnFApply_Click(object sender, EventArgs e)
    {

        Session["Applybutton"] = "yes";

        //redirect the page to apply page
        Response.Redirect("Apply.aspx");
    }
}