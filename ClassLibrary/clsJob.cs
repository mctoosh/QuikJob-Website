using System;

namespace ClassLibrary
{
    public class clsJob
    {

        //private data member for the mJobId property
        private int mJobId;
        //private data member for the mJob_Name property
        private string mJob_Name;
        //private data member for the mJob_Type property
        private string mJob_Type;
        //private data member for the mJob_Description property
        private string mJob_Description;
        //private data member for the mJob_Address property
        private string mJob_Address;
        //private data member for the mJob_Postcode property
        private string mJob_Postcode;
        //private data member for the mJob_Image property
        private string mJob_Image;


        //public property for the userid
        public int JobId
        {
            get
            {
                //return the private data
                return mJobId;
            }

            set
            {
                //set the value of the private data member
                mJobId = value;
            }

        }

        public string Job_Name
        {
            get
            {
                //return the private data
                return mJob_Name;
            }

            set
            {
                //set the value of the private data member
                mJob_Name = value;
            }

        }

        public string Job_Type
        {
            get
            {
                //return the private data
                return mJob_Type;
            }

            set
            {
                //set the value of the private data member
                mJob_Type = value;
            }

        }

        public string Job_Description
        {
            get
            {
                //return the private data
                return mJob_Description;
            }

            set
            {
                //set the value of the private data member
                mJob_Description = value;
            }

        }

        public string Job_Address
        {
            get
            {
                //return the private data
                return mJob_Address;
            }

            set
            {
                //set the value of the private data member
                mJob_Address = value;
            }

        }

        public string Job_Postcode
        {
            get
            {
                //return the private data
                return mJob_Postcode;
            }

            set
            {
                //set the value of the private data member
                mJob_Postcode = value;
            }

        }

        public string Job_Image
        {
            get
            {
                //return the private data
                return mJob_Image;
            }

            set
            {
                //set the value of the private data member
                mJob_Image = value;
            }

        }



        public bool Valid(string Job_Name, string Job_Type, string Job_Description, string Job_Address, string Job_Postcode, string Job_Image)
        {
            //create a boolean variable to flag the error
            Boolean OK = true;
            //if the JobName is blank
            if (Job_Name.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the Job name is greater than 22 charecters
            if (Job_Name.Length > 22)
            {
                //set the flag ok false
                OK = false;
            }
            //-------------------JobType Validation--------------------------------------------------------------------//

            //if the JobType is blank
            if (Job_Type.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the Jobtype is greater than 22 charecters
            if (Job_Type.Length > 22)
            {
                //set the flag ok false
                OK = false;
            }
            //-------------------Job_Description Validation--------------------------------------------------------------------//

            //if the Job_Description is blank
            if (Job_Description.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the Job_Description is greater than 100 charecters
            if (Job_Description.Length > 100)
            {
                //set the flag ok false
                OK = false;
            }
            //-------------------Job_Address Validation--------------------------------------------------------------------//

            //if the Job_Address is blank
            if (Job_Address.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the Job_Address is greater than 40 charecters
            if (Job_Address.Length > 40)
            {
                //set the flag ok false
                OK = false;
            }
            //-------------------Job_Postcode Validation--------------------------------------------------------------------//

            //if the Job_Postcode is blank
            if (Job_Postcode.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the Job_Postcode is greater than 22 charecters
            if (Job_Postcode.Length > 22)
            {
                //set the flag ok false
                OK = false;
            }
            //-------------------Job_Image Validation--------------------------------------------------------------------//

            //if the Job_Image is blank
            if (Job_Image.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the Job_Image is greater than 1000 charecters
            if (Job_Image.Length > 1000)
            {
                //set the flag ok false
                OK = false;
            }

            return OK;
        }

        public bool Find(int JobId)
        {
            //create an instance of the data conncetion
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the BookingNo to search for
            DB.AddParameter("@JobId", JobId);
            //execute the stored procedure
            DB.Execute("sproc_Add_Jobs_FilterByJobId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mJobId = Convert.ToInt32(DB.DataTable.Rows[0]["JobId"]);
                mJob_Name = Convert.ToString(DB.DataTable.Rows[0]["Job_Name"]);
                mJob_Type = Convert.ToString(DB.DataTable.Rows[0]["Job_Type"]);
                mJob_Description = Convert.ToString(DB.DataTable.Rows[0]["Job_Description"]);
                mJob_Address = Convert.ToString(DB.DataTable.Rows[0]["Job_Address"]);
                mJob_Postcode = Convert.ToString(DB.DataTable.Rows[0]["Job_Postcode"]);
                mJob_Image = Convert.ToString(DB.DataTable.Rows[0]["Job_Image"]);
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