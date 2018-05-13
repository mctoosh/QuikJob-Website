using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the mUserId property
        private int mUserId;
        //private data member for the mFirst_Name property
        private string mFirst_Name;
        //private data member for the mLast_Name property
        private string mLast_Name;
        //private data member for the mEmail property
        private string mEmail;
        //private data member for the mAddress property
        private string mAddress;
        //private data member for the mPostcode property
        private string mPostcode;
        //private data member for the mPassword property
        private string mPassword;
        //private data member for the mAge property
        private string mAge;
        //private data member for the mPhone_Number property
        private string mPhone_Number;
        //private data member for the mUser_CV property
        private string mUser_CV;

   
        //public property for the UserId
        public int UserId
        {
            get
            {
                //return the private data
                return mUserId;
            }

            set
            {
                //set the value of the private data member
                mUserId = value;
            }

        }

        public string First_Name
        {
            get
            {
                //return the private data
                return mFirst_Name;
            }

            set
            {
                //set the value of the private data member
                mFirst_Name = value;
            }

        }

        public string Last_Name
        {
            get
            {
                //return the private data
                return mLast_Name;
            }

            set
            {
                //set the value of the private data member
                mLast_Name = value;
            }

        }

        public string Email
        {
            get
            {
                //return the private data
                return mEmail;
            }

            set
            {
                //set the value of the private data member
                mEmail = value;
            }

        }

        public string Address
        {
            get
            {
                //return the private data
                return mAddress;
            }

            set
            {
                //set the value of the private data member
                mAddress = value;
            }

        }

        public string Postcode
        {
            get
            {
                //return the private data
                return mPostcode;
            }

            set
            {
                //set the value of the private data member
                mPostcode = value;
            }

        }

        public string Password
        {
            get
            {
                //return the private data
                return mPassword;
            }

            set
            {
                //set the value of the private data member
                mPassword = value;
            }

        }

        public string Age
        {
            get
            {
                //return the private data
                return mAge;
            }

            set
            {
                //set the value of the private data member
                mAge = value;
            }

        }

        public string Phone_Number
        {
            get
            {
                //return the private data
                return mPhone_Number;
            }

            set
            {
                //set the value of the private data member
                mPhone_Number = value;
            }

        }

        public string User_CV
        {
            get
            {
                //return the private data
                return mUser_CV;
            }

            set
            {
                //set the value of the private data member
                mUser_CV = value;
            }

        }


        public bool Valid(string First_Name, string Last_Name, string Email, string Address, string Postcode, string Password, string Age, string Phone_Number, string User_CV)
        {
            //create a boolean variable to flag the error
            Boolean OK = true;
            //if the FirstName is blank
            if (First_Name.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the first name is greater than 22 charecters
            if (First_Name.Length > 22)
            {
                //set the flag ok false
                OK = false;
            }

            //-------------------LastName Validation--------------------------------------------------------------------//

            //if the LastName is blank
            if (Last_Name.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the LastName is greater than 22 charecters
            if (Last_Name.Length > 22)
            {
                //set the flag ok false
                OK = false;
            }

            //-------------------Email Validation--------------------------------------------------------------------//

            //if the Email is blank
            if (Email.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the Email is greater than 40 charecters
            if (Email.Length > 40)
            {
                //set the flag ok false
                OK = false;
            }

            //-------------------Address Validation--------------------------------------------------------------------//
            //if the Address is blank
            if (Address.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the Address is greater than 40 charecters
            if (Address.Length > 40)
            {
                //set the flag ok false
                OK = false;
            }

            //-------------------Postcode Validation--------------------------------------------------------------------//
            //if the Postcode is blank
            if (Postcode.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the Postcode is greater than 50 charecters
            if (Postcode.Length > 22)
            {
                //set the flag ok false
                OK = false;
            }

            //-------------------Password Validation--------------------------------------------------------------------//
            //if the Password is blank
            if (Password.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the Password is greater than 100 charecters
            if (Password.Length > 40)
            {
                //set the flag ok false
                OK = false;
            }

            //-------------------PhoneNumber Validation--------------------------------------------------------------------//
            //if the PhoneNumber is blank
            if (Phone_Number.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the PhoneNumber is greater than 100 charecters
            if (Phone_Number.Length > 22)
            {
                //set the flag ok false
                OK = false;
            }

            //-------------------User_CV Validation--------------------------------------------------------------------//
            //if the User_CV is blank
            if (User_CV.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the User_CV is greater than 10000 charecters
            if (User_CV.Length > 10000)
            {
                //set the flag ok false
                OK = false;
            }

            //return the value OK
            return OK;
        }

        public bool Find(int UserId)
        {
            //create an instance of the data conncetion
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the BookingNo to search for
            DB.AddParameter("@UserId", UserId);
            //execute the stored procedure
            DB.Execute("sproc_Main_Registration_FilterByUserId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);
                mFirst_Name = Convert.ToString(DB.DataTable.Rows[0]["First_Name"]);
                mLast_Name = Convert.ToString(DB.DataTable.Rows[0]["Last_Name"]);
                mAge = Convert.ToString(DB.DataTable.Rows[0]["Age"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPostcode = Convert.ToString(DB.DataTable.Rows[0]["Postcode"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mPhone_Number = Convert.ToString(DB.DataTable.Rows[0]["Phone_Number"]);
                mUser_CV = Convert.ToString(DB.DataTable.Rows[0]["User_CV"]);
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