using System;
using System.Globalization;

namespace ClassLibrary
{
    public class clsCms
    {
        
        private Int32 mC_id;
        private int mCustomerId;
        private DateTime mDateAdded;
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
        public DateTime DateAdded
        {
            get { return mDateAdded; }
            set { mDateAdded = value; }
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
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["C_timeStrap"]);
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

       

        public string Valid( string customerName, string customerEmail, string customerPassword, string PostCode, string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary vatriable to store the data values
            DateTime DateTemp;
            // if the Post code is blank
            if (PostCode.Length==0) 
            {
                //record the error
                Error = Error + "The Post Code may not be blank:";
            }
            //iff the post code is grater than 10 characters
            if (PostCode.Length > 10)
            {
                Error = Error + "The Post Code must be less than 10 characters:";

            }
            if(customerName.Length == 0) 
            {
                //record the error
                Error = Error + "The Name may not be blank:";

            }
            if (customerName.Length > 20)
            {
                Error = Error + "The Name must be less than 20 characters:";

            }
            if(customerEmail.Length < 11)
            {
                Error = Error + "The Email may not be less than 11:";
            }
            if (customerEmail.Length > 50) 
            {
                Error = Error + "The Email must be less than 50 characters:";
            }
            if (customerPassword.Length < 5)
            {
                Error = Error + "The Password may not be less than 5:";
            }
            if (customerPassword.Length > 20)
            {
                Error = Error + "The Password must be less than 20 characters:";
            }
            if (PostCode.Length < 4)
            {
                Error = Error + "The PostCode may not be less than 4:";
            }
            if (PostCode.Length > 10)
            {
                Error = Error + "The PostCode must be less than 10 characters:";
            }
            // create an instance of DateTime to compare with DateTemp
            // in the if statement
            DateTime DateComp= DateTime.Now;
            try
            {
                DateTemp = Convert.ToDateTime(dateAdded);
                //check to see if the data is less than today's date
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past;";

                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future;";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date;";
            }

           
            //returm any error messages
            return Error;
        }

       
    }
    }
