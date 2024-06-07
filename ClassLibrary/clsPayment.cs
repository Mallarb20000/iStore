using System;
using System.IO;

namespace Testing3
{
    public class clsPayment
    {
        //private data member for the TransactionID property
        private Int32 mPaymentID;
        private string mName;
        private string mEmail;
        private string mPostCode;
        private DateTime mPaymentDate;
        private string mTransactionStatus;
        private string mPaymentAmount;

        public Int32 PaymentID
        {
            get
            {
                //this line of code sends data out of the property
                return mPaymentID;
            }
            set
            {
                //this line of code allows data into property
                mPaymentID = value;
            }
        }

        public DateTime PaymentDate
        {
            get
            {
                //this line of code sends data out of the property
                return mPaymentDate;
            }
            set
            {
                //this line of code allows data into property
                mPaymentDate = value;
            }
        }

        public string Name
        {
            get
            {
                //this line of code sends data out of the property
                return mName;
            }
            set
            {
                //this line of code allows data into property
                mName = value;
            }
        }

        public string Email
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into property
                mEmail = value;
            }
        }

        public string PostCode
        {
            get
            {
                //this line of code sends data out of the property
                return mPostCode;
            }
            set
            {
                //this line of code allows data into property
                mPostCode = value;
            }
        }

        public string PaymentAmount
        {
            get
            {
                //this line of code sends data out of the property
                return mPaymentAmount;
            }
            set
            {
                //this line of code allows data into property
                mPaymentAmount = value;
            }
        }

        public string TransactionStatus
        {
            get
            {
                //this line of code sends data out of the property
                return mTransactionStatus;
            }
            set
            {
                //this line of code allows data into property
                mTransactionStatus = value;
            }

        }


        /****** FIND METHOD ******/
        public bool Find(int PaymentID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("@PaymentID", PaymentID);
            //execute the stored procedure
            DB.Execute("sproc_tblPayment_FilterByPaymentID");
            //if one record is found(there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mPaymentID = Convert.ToInt32(DB.DataTable.Rows[0]["PaymentID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPaymentAmount = Convert.ToString(DB.DataTable.Rows[0]["PaymentAmount"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mTransactionStatus = Convert.ToString(DB.DataTable.Rows[0]["TransactionStatus"]);
                mPaymentDate = Convert.ToDateTime(DB.DataTable.Rows[0]["PaymentDate"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }

        public string Valid(string Name, string Email, string PostCode, string PaymentAmount, string PaymentDate, string TransactionStatus)
        {
            //create a temporary variable to store the data values
            DateTime Datatemp;
            //create a string variable to store th error
            string Error = "";
            //if the Name is blank
            if (Name.Length ==0)
            {
                //record the error
                Error = Error + "The Name may not be blank : ";
            }
            //if the name is greater than 6 characters
            if (Name.Length > 20)
            {
                //record the error
                Error = Error + "The Name must be less than 20 characters : ";
            }
            //create an instance of DateTime to compare with Datetemp
            //in the if statement
            DateTime DateComp = DateTime.Now.Date;
            try
            {
                //copy the PaymentDate Value to the Datetemp variable
                Datatemp = Convert.ToDateTime(PaymentDate);
                if (Datatemp <  DateComp) //compare Paymentdate with Date
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                else if (Datatemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //is the post code blank
            if (PostCode.Length ==0)
            {
                //record the error
                Error = Error + "The PostCode may not be blank : ";
            }
            //if the post code is too long
            if (PostCode.Length > 10)
            {
                //record the error
                Error = Error + "The PostCode must be less than 9 characters : ";
            }
            //is the Email blank
            if (Email.Length ==0)
            {
                //record the error
                Error = Error + "The Email may not be blank : ";
            }
            //if the Email is too long
            if (Email.Length > 50)
            {
                //record the error
                Error = Error + "The Email must be less than 50 characters : ";
            }
            //is the PaymentAmount blank
            if (PaymentAmount.Length ==0)
            {
                //record the error
                Error = Error + "The PaymentAmount may not be blank : ";
            }
            //if the PaymentAmount is too long
            if (PaymentAmount.Length > 50)
            {
                //record the error
                Error = Error + "The PaymentAmount must be less than 50 characters : ";
            }
            //if the TransactionStatus blank
            if (TransactionStatus.Length == 0)
            {
                //record the error
                Error = Error + "The TransactionStatus may not be blank : ";
            }
            //if the TransactionStatus is too long
            if (TransactionStatus.Length > 20)
            {
                //record the error
                Error = Error + "The TransctionStatus must be less than 20 characters : ";
            }
            //return any error messages
            return Error;
        }
    }
 }