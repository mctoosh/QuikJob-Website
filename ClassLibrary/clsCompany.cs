using System;

namespace ClassLibrary
{
    public class clsCompany
    {

        //private data member for the mJobId property
        private int mCompanyId;
        //private data member for the mJob_Name property
        private string mCompany_Name;
        //private data member for the mJob_Type property
        private string mCompany_Email;
        //private data member for the mJob_Description property
        private string mCompany_Description;
        //private data member for the mJob_Address property
        private string mCompany_Website;

        //public property for the userid
        public int CompanyId
        {
            get
            {
                //return the private data
                return mCompanyId;
            }

            set
            {
                //set the value of the private data member
                mCompanyId = value;
            }

        }

        public string Company_Name
        {
            get
            {
                //return the private data
                return mCompany_Name;
            }

            set
            {
                //set the value of the private data member
                mCompany_Name = value;
            }

        }

        public string Company_Email
        {
            get
            {
                //return the private data
                return mCompany_Email;
            }

            set
            {
                //set the value of the private data member
                mCompany_Email = value;
            }

        }

        public string Company_Description
        {
            get
            {
                //return the private data
                return mCompany_Description;
            }

            set
            {
                //set the value of the private data member
                mCompany_Description = value;
            }

        }

        public string Company_Website
        {
            get
            {
                //return the private data
                return mCompany_Website;
            }

            set
            {
                //set the value of the private data member
                mCompany_Website = value;
            }

        }


        public bool Valid(string Company_Name, string Company_Email, string Company_Description, string Company_Website)
        {
            //create a boolean variable to flag the error
            Boolean OK = true;
            //if the Company_Name is blank
            if (Company_Name.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the Company_Name is greater than 22 charecters
            if (Company_Name.Length > 22)
            {
                //set the flag ok false
                OK = false;
            }
            //-------------------Company_Email Validation--------------------------------------------------------------------//

            //if the Company_Email is blank
            if (Company_Email.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the Company_Email is greater than 22 charecters
            if (Company_Email.Length > 22)
            {
                //set the flag ok false
                OK = false;
            }
            //-------------------Company_Description Validation--------------------------------------------------------------------//
            //if the Job_Description is blank
            if (Company_Description.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the Job_Description is greater than 100 charecters
            if (Company_Description.Length > 100)
            {
                //set the flag ok false
                OK = false;
            }
            //-------------------Company_Website Validation--------------------------------------------------------------------//

            //if the Company_Website is blank
            if (Company_Website.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the Company_Website is greater than 22 charecters
            if (Company_Website.Length > 22)
            {
                //set the flag ok false
                OK = false;
            }



            return OK;
        }

        public bool Find(int CompanyId)
        {
            //create an instance of the data conncetion
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the BookingNo to search for
            DB.AddParameter("@CompanyId", CompanyId);
            // execute the stored procedure
            DB.Execute("sproc_Add_Company_FilterByCompanyId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCompanyId = Convert.ToInt32(DB.DataTable.Rows[0]["CompanyId"]);
                mCompany_Name = Convert.ToString(DB.DataTable.Rows[0]["Company_Name"]);
                mCompany_Email = Convert.ToString(DB.DataTable.Rows[0]["Company_Email"]);
                mCompany_Description = Convert.ToString(DB.DataTable.Rows[0]["Company_Description"]);
                mCompany_Website = Convert.ToString(DB.DataTable.Rows[0]["Company_Website"]);
                //return that everything worked OK
                return true;
            }

            //if no records was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
    }
}