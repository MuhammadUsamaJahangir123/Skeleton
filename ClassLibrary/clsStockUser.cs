using System;

namespace ClassLibrary
{
    public class clsStockUser
    {
        //private data member for user properties
        private Int32 mUserID;
        private string mUserName;
        private string mPassword;
        private string mDepartment;

        public int UserID
        {
            get
            {
                //return the private data
                return mUserID;
            }
            set
            {
                //set the private data
                mUserID = value;
            }
        }
        public string UserName
        {
            get
            {
                //return the private data
                return mUserName;
            }
            set
            {
                //set the private data
                mUserName = value;
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
                //set the private data
                mPassword = value;
            }
        }
        public string Department
        {
            get
            {
                //return the private data
                return mDepartment;
            }
            set
            {
                //set the private data
                mDepartment = value;
            }
        }
        public bool FindUser(string UserName, string Password)
        {
            //create an instance of the data connction
            clsDataConnection DB = new clsDataConnection();
            //add the parameters for the username and pw 2 search for
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);
            //execute the sdtored procedure
            DB.Execute("sproc_tblUsers_FindUserNamePW");
            //if one record is found - shld be one or none
            if (DB.Count == 1)
            {
                //copy the data from the db to the priv data members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //conform rvrrthuibg weked ok
                return true;

            }
            else
            {
                return false;
            }
            
        }

        
        
    }
}