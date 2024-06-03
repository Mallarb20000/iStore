using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCmsCollection
    {

        public clsCmsCollection()
        {
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
            while (Index < RecordCount)
            {
                //create a blank address
                clsCms aCustomer = new clsCms();
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
                mCustomerList = value;
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
        //private data member for the list
        private List<clsCms> mCustomerList = new List<clsCms>();
        // private member data for thisCustomer
        clsCms mThisCustomer = new clsCms();

        public clsCms ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

      

        public int Add()
        {
            // adds a record to the database based on the values of mThisCustomer
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@C_id", mThisCustomer.CustomerId);
            DB.AddParameter("@C_timeStrap", mThisCustomer.DateAdded);
            DB.AddParameter("@C_name", mThisCustomer.CustomerName);
            DB.AddParameter("@C_email", mThisCustomer.CustomerEmail);
            DB.AddParameter("@C_password", mThisCustomer.CustomerPassword);
            DB.AddParameter("@C_postCode", mThisCustomer.PostCode);
            DB.AddParameter("@C_memership", mThisCustomer.Membership);

            //execute the query returning the primary key value
            return DB.Execute("sproc_TableCms_Insert");
        }

        public void Update()
        {
            clsDataConnection DB= new clsDataConnection();
            DB.AddParameter("@C_id", mThisCustomer.CustomerId);
            DB.AddParameter("@C_timeStrap", mThisCustomer.DateAdded);
            DB.AddParameter("@C_name", mThisCustomer.CustomerName);
            DB.AddParameter("@C_email", mThisCustomer.CustomerEmail);
            DB.AddParameter("@C_password", mThisCustomer.CustomerPassword);
            DB.AddParameter("@C_postCode", mThisCustomer.PostCode);
            DB.AddParameter("@C_memership", mThisCustomer.Membership);
            DB.Execute("sproc_TableCms_Update");
        }
    }
    }
