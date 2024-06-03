using System;
using System.Collections.Generic;
using System.Reflection;
using Testing3;

namespace ClassLibrary
{
    public class clsPaymentCollection
    {
        //private data member for the PaymentList property
        List<clsPayment> mPaymentList = new List<clsPayment>();
        clsPayment mName = new clsPayment();


        public List<clsPayment> PaymentList
        {
            get
            {
                return mPaymentList;
            }
            set
            {
                mPaymentList = value;
            }
        }


        public clsPayment Name 
        { 
            get
            {  
                return mName; 
            }
            set
            {
                mName = value;
            }
                
        }

        public int Count
        {
            get
            {
                return mPaymentList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }


        //constructor for the class
        public clsPaymentCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblPayment_SeletctAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are recrods to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsPayment AnPayment = new clsPayment();
                //read in the fiedls for the current record 
                AnPayment.PaymentID = Convert.ToInt32(DB.DataTable.Rows[Index]["PaymentID"]);
                AnPayment.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AnPayment.PaymentDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["PaymentDate"]);
                AnPayment.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnPayment.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                AnPayment.PaymentAmount = Convert.ToString(DB.DataTable.Rows[Index]["PaymentAmount"]);
                AnPayment.TransactionStatus = Convert.ToString(DB.DataTable.Rows[Index]["TransactionStatus"]);
                //add the record to the private data member
                mPaymentList.Add(AnPayment);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Name", mName.Name);
            DB.AddParameter("@Email", mName.Email);
            DB.AddParameter("@PostCode", mName.PostCode);
            DB.AddParameter("@PaymentAmount", mName.PaymentAmount);
            DB.AddParameter("@TransactionStatus", mName.TransactionStatus);
            DB.AddParameter("@PaymentDate", mName.PaymentDate);

            return DB.Execute("sproc_tblpayment_Insert");
        }

        public void Update()
        {
                //update an existing record based on the values of thisAddress 
                //connect to the database
                clsDataConnection DB = new clsDataConnection();
                //set the parameters for the new stored procedure
            DB.AddParameter("@PaymentID", mName.PaymentID); 
            DB.AddParameter("@Name", mName.Name); 
            DB.AddParameter("@Email", mName.Email); 
            DB.AddParameter("@PaymentAmount", mName.PaymentAmount); 
            DB.AddParameter("@PostCode", mName.PostCode); 
            DB.AddParameter("@PaymentDate", mName.PaymentDate); 
            DB.AddParameter("@TransactionStatus", mName.TransactionStatus); 
            //execute the stored procedure
            DB.Execute("sproc_tblPayment_Update");
            }

        public void Delete()
        {
            clsDataConnection DB=new clsDataConnection();
            DB.AddParameter("@PaymentID", mName.PaymentID);

            DB.Execute("sproc_tblPayment_Delete");
        }

        public void ReportByPostCode(string PostCode)
        {
            //filters the records based on a full or partial post code
            clsDataConnection DB=new clsDataConnection();
            DB.AddParameter("@PostCode", PostCode);
            DB.Execute("sproc_tblPayment_FilterByPostCode");
        }
    }
}