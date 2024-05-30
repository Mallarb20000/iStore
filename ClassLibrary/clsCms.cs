using System;
using System.Globalization;

namespace ClassLibrary
{
    public class clsCms
    {
        
        private Int32 mC_id;
        private int mCustomerId;
        private DateTime mTimeStrap;
        private string mCustomerName;
        private string mCustomerEmail;
        private String mCustomerPassword;
        private String mPostCode;
        private Boolean mMembership;
       

        public int CustomerId
        {
            get { return mCustomerId; }
            set { mCustomerId = value; }
        }
        public DateTime TimeStrap
        {
            get { return mTimeStrap; }
            set { mTimeStrap = value; }
        }


        public String CustomerName
        {
            get { return mCustomerName; }
            set { mCustomerName = value; }
        }
        public string CustomerEmail
        {
            get { return mCustomerEmail; }
            set { mCustomerEmail = value; }
        }

        public string CustomerPassword
        {
            get { return mCustomerPassword; }
            set { mCustomerPassword = value; }
        }
        public Boolean Membership
        {
            get { return mMembership; }
            set { mMembership = value; }
        }
        public string PostCode
        {
            get { return mPostCode; }
            set { mPostCode = value; }
        }
        public Int32 C_id
        {
            get { return mC_id; }
            set { mC_id = value; }
        }





        //Find Method
        public bool Find(int C_id)
        {

            //create a instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the E_Id to search for 
            DB.AddParameter("@C_id", C_id);
            //execute the stored procedure
            DB.Execute("sproc_TableCms_FilterByC_id");

            //if one record is found(there should be either one or zero)
            if (DB.Count == 1)
            {
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["C_id"]);
                mTimeStrap = Convert.ToDateTime(DB.DataTable.Rows[0]["C_timeStrap"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["C_name"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["C_email"]);
                mCustomerPassword = Convert.ToString(DB.DataTable.Rows[0]["C_password"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["C_postCode"]);
                mMembership = Convert.ToBoolean(DB.DataTable.Rows[0]["C_memership"]);

                //return that everything worked OK

                return true;
                }
                else
                {
                    //return false indicating an problem 
                    return false;
                }

            }

        public string Valid(string customerName, string customerEmail, string customerPassword, string customerPostCode)
        {
            return "";
        }

    }
    }
