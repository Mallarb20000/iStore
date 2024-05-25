using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ClassLibrary
{
    public class clsRegister
    {

        //Declare Fields
        private Int32 mE_Id;

        private string mE_Name;
        private string mE_username;
        private string mE_password;
        private Boolean mE_trained;
        private DateTime mTimestamp;
        private Int32 mSalary;

        //Getters and setter
        public string Username
        {
            get { return mE_username; }
            set { mE_username = value; }
        }

        public int E_Id
        {
            get { return mE_Id; }
            set { mE_Id = value; }
        }

        // Getter and Setter for Salary
        public int Salary
        {
            get { return mSalary; }
            set { mSalary = value; }
        }

        // Getter and Setter for Name
        public string Name
        {
            get { return mE_Name; }
            set { mE_Name = value; }
        }

        // Getter and Setter for Password
        public string Password
        {
            get { return mE_password; }
            set { mE_password = value; }
        }

        // Getter and Setter for Trained
        public bool Trained
        {
            get { return mE_trained; }
            set { mE_trained = value; }
        }

        // Getter and Setter for Timestamp
        public DateTime Timestamp
        {
            get { return mTimestamp; }
            set { mTimestamp = value; }
        }


        //Find Method
        public bool Find(int E_Id)
        {

            //create a instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the E_Id to search for 
            DB.AddParameter("@E_Id", E_Id);
            //execute the stored procedure
            DB.Execute("sproc_tblEMS_FilterByE_Id");

            //if one record is found(there should be either one or zero)
            if(DB.Count ==1)
            {
                mE_Id = Convert.ToInt32(DB.DataTable.Rows[0]["E_Id"]);
                mE_Name = Convert.ToString(DB.DataTable.Rows[0]["E_Name"]);
                mE_username = Convert.ToString(DB.DataTable.Rows[0]["E_username"]);
                mE_password = Convert.ToString(DB.DataTable.Rows[0]["E_password"]);
                mE_trained = Convert.ToBoolean(DB.DataTable.Rows[0]["E_trained"]);
                mTimestamp = Convert.ToDateTime(DB.DataTable.Rows[0]["E_Idcreated"]);
                mSalary = Convert.ToInt32(DB.DataTable.Rows[0]["E_salary"]);

                //return that everything worked OK

                return true;
            }
            else
            {
                //return false indicating an problem 
                return false;
            }
            
        }

        public string Valid(string username, string name, string password, string salary, string timestamp)
        {
            return "";
        }
    }
}