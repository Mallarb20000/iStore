using System;
using System.Collections.Generic;
using Testing3;

namespace ClassLibrary
{
    public class clsPaymentCollection
    {
        //private data member for the PaymentList property
        List<clsPayment> mPaymentList = new List<clsPayment>();


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


        public clsPayment Name { get; set; }

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
    }
}