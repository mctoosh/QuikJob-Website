using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_Applicaton_Calculation : System.Web.UI.Page
{
int tot = 0;
    string s;
    string t;
    string[] a = new string[15];
    string Job_No; 
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["user"] == null)
        {
            Response.Redirect("userLogin.aspx");
        }


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

            }
        }


        //this gives the Job_no a 10 digit random number
            Job_No = ClassLibrary.clsRandomiser.GetRandomPassword(10).ToString();
        Session["Job_No"] = Job_No.ToString();

        Response.Redirect("Application_Success.aspx?job="+Job_No.ToString()+"");


    }
}