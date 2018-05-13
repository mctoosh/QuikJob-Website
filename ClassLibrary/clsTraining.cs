using System;

namespace ClassLibrary
{
    public class clsTraining
    {
        //private data member for the mTraining_CourseId property
        private int mTraining_CourseId;
        //private data member for the mTraining_Course_Name property
        private string mTraining_Course_Name;
        //private data member for the mTraining_Course_Type property
        private string mTraining_Course_Type;
        //private data member for the mTraining_Course_Description property
        private string mTraining_Course_Description;


        //public property for the Training_CourseId
        public int Training_CourseId
        {
            get
            {
                //return the private data
                return mTraining_CourseId;
            }

            set
            {
                //set the value of the private data member
                mTraining_CourseId = value;
            }

        }

        public string Training_Course_Name
        {
            get
            {
                //return the private data
                return mTraining_Course_Name;
            }

            set
            {
                //set the value of the private data member
                mTraining_Course_Name = value;
            }

        }

        public string Training_Course_Type
        {
            get
            {
                //return the private data
                return mTraining_Course_Type;
            }

            set
            {
                //set the value of the private data member
                mTraining_Course_Type = value;
            }

        }

        public string Training_Course_Description
        {
            get
            {
                //return the private data
                return mTraining_Course_Description;
            }

            set
            {
                //set the value of the private data member
                mTraining_Course_Description = value;
            }

        }


        public bool Valid(string Training_Course_Name, string Training_Course_Type, string Training_Course_Description)
        {
            //create a boolean variable to flag the error
            Boolean OK = true;
            //if the Training_Course_Name is blank
            if (Training_Course_Name.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the Training_Course_Name is greater than 22 charecters
            if (Training_Course_Name.Length > 22)
            {
                //set the flag ok false
                OK = false;
            }
            //-------------------Training_Course_Type --------------------------------------------------------------------//
            //if the Training_Course_Type is blank
            if (Training_Course_Type.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the Training_Course_Type is greater than 22 charecters
            if (Training_Course_Type.Length > 22)
            {
                //set the flag ok false
                OK = false;
            }

            //-------------------Training_Course_Description --------------------------------------------------------------------//
            //if the Training_Course_Description is blank
            if (Training_Course_Description.Length == 0)
            {
                //set the flag OK to false 
                OK = false;
            }
            //if the Training_Course_Description is greater than 100 charecters
            if (Training_Course_Description.Length > 100)
            {
                //set the flag ok false
                OK = false;
            }

            return OK;
        }

        public bool Find(int Training_CourseId)
        {
            //create an instance of the data conncetion
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the BookingNo to search for
            DB.AddParameter("@Training_CourseId", @Training_CourseId);
            //execute the stored procedure
            DB.Execute("sproc_Add_Training_Course_FilterByTraining_CourseId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mTraining_CourseId = Convert.ToInt32(DB.DataTable.Rows[0]["Training_CourseId"]);
                mTraining_Course_Name = Convert.ToString(DB.DataTable.Rows[0]["Training_Course_Name"]);
                mTraining_Course_Type = Convert.ToString(DB.DataTable.Rows[0]["Training_Course_Type"]);
                mTraining_Course_Description = Convert.ToString(DB.DataTable.Rows[0]["Training_Course_Description"]);
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