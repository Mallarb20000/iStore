using System;
using System.Dynamic;
using System.Security.Policy;

namespace ClassLibrary
{
    public class clsTstUser
    {
        private Int32 mUser_id;
        private String mUserName;
        private String mPassword;
        private String mDepartment;

        public int UserId 
        {
            get {  return mUser_id; }
            set {  mUser_id = value; }  
        }
        public string UserName 
        {
            get { return mUserName; }
            set { mUserName = value; }  
        }
        public string Password 
        {
            get { return mPassword; }
            set { mPassword = value; }
        }
        public string Department 
        { 
            get { return mDepartment; }
            set { mDepartment = value; }    
        }

        public bool FindUser(string UserName, string Password)
        {
            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the user suranem and password to search for 
            DB.AddParameter("@UserName",UserName);
            DB.AddParameter("@Password", Password);
            //execute the stored procedure 
            DB.Execute("sproc_tblUsers_FindUserNamePW");
            //if one record id found (there should be either one or none)
            if (DB.Count == 1)
            {
                mUser_id = Convert.ToInt32(DB.DataTable.Rows[0]["UserId"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword =Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment= Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirm everything worked ok
                return true;
            }
            else
            {
                return false;   
            }
        }
    }
}