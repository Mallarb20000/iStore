using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCmsCollection
    {

        public clsCmsCollection() {
            //variable for the index
            Int32 Index = 0;
            //variable to store he record count
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_TableCms_SelectAll");
            //et the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while(Index< RecordCount)
            {
                //create a blank address
                clsCms aCustomer= new clsCms();
                //read in the fileds for the curent record
                aCustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["C_id"]);
                aCustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["C_timeStrap"]);
                aCustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[0]["C_name"]);
                aCustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["C_email"]);
                aCustomer.CustomerPassword = Convert.ToString(DB.DataTable.Rows[0]["C_password"]);
                aCustomer.PostCode = Convert.ToString(DB.DataTable.Rows[0]["C_postCode"]);
                aCustomer.Membership = Convert.ToBoolean(DB.DataTable.Rows[0]["C_memership"]);
                // add the record to the private data memeber
                mCustomerList.Add(aCustomer);
                //point at the next record
                Index++;

            }
        }
        private List<clsCms> mCustomerList= new List<clsCms>(); 

        public List<clsCms> CustomerList 
        {
            get 
            {
                //return the private data
                return mCustomerList;   
            }
            set
            {
                //set the private data
                mCustomerList= value;   
            }
        }
        public int Count 
        {
            get
            {
                //return the private data
                return CustomerList.Count;
            }
            set
            {
                //set the private data
            }

        }

        public clsCms ThisCustomer { get; set; }

    }
}