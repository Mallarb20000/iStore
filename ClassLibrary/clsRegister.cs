using System;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;

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
            //create a string variable to store the error
            String Error = "";

            //temperory variable for data values
            DateTime DateTemp;

            
            //if the name is blank 
            if ( name.Length == 0 )
            {
                //record the error
                Error += "Name cannot be blank";
            }

            //if the name is longer than 100 characters

            if (name.Length > 100)
            {
                Error += "Name cannot be longer than 100 characters:";
            }

            // Validate Username
            if (string.IsNullOrEmpty(username))
            {
                Error += "Username cannot be empty. ";
            }
            if (username.Length > 30)
            {
                Error += "Username cannot exceed 30 characters. ";
            }

            /******************Validate Timestamp***************/
            //copy the dateAdded value to the DateTemp
            //
            try
            {
                DateTemp = Convert.ToDateTime(timestamp);

                //check to see if the less than today's data 
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be past";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error += "The date cannot be future";
                }
            }
            catch
            {
                Error += "The date was not a valid date";
            }
            


            // Validate Password
            if (password.Length<8)
            {
                Error += "Password cannot be less than 8. ";
            }
            if (password.Length > 30)
            {
                Error += "Password cannot exceed 30 characters. ";
            }
            /*if (Regex.IsMatch(password, @"[^a-zA-Z0-9]"))
            {
                Error += "Password contains invalid characters. ";
            }
            if (!password.Any(char.IsUpper) || !password.Any(char.IsLower))
            {
                Error += "Password must contain both uppercase and lowercase letters. ";
            }
            if (!Regex.IsMatch(password, @"[^a-zA-Z0-9\s]"))
            {
                Error += "Password must contain at least one special character. ";
            }*/

            // Validate Salary
            double salaryValue;
            if (!double.TryParse(salary, out salaryValue))
            {
                Error += "Salary must be a valid double number. ";
            }
            else
            {
                if (salaryValue < 0)
                {
                    Error += "Salary cannot be negative. ";
                }
                if (salaryValue > 10000000)
                {
                    Error += "Salary cannot exceed 10million. ";
                }
            }



            //return any error message
            return Error;
        }
    }
}