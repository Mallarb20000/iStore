using System;

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
    }
}