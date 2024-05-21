using System;

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
            mE_Id = 1;
            mE_Name = "Qwe";
            mE_username = "Qwe";
            mE_password = "Qwe";
            mE_trained = true;
            mTimestamp = Convert.ToDateTime("10 / 10 / 2023");
            mSalary = Convert.ToInt32("1000");

            return true;
        }

        
    }
}