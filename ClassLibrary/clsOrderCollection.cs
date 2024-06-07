using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member of the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private member data for this Order
        clsOrder mThisOrder = new clsOrder();
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }

        //public property for thisorder
        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //Later
            }
        }

        public int Add()
        {
            //adds a record to the database 
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters  
            DB.AddParameter("@ProductID", mThisOrder.ProductID);
            DB.AddParameter("@City", mThisOrder.Town);
            DB.AddParameter("@OrderDate", mThisOrder.DateAdded);
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            //execute the query returning the primary key value
            return DB.Execute(" sproc_tblOrder_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrdeID", mThisOrder.OrderID);

            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByPostCode(string PostCode)
        {
            //filters the records based on a full or partial post code
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PostCode", PostCode);
            DB.Execute("sproc_tblOrder_FilterByPostCode");
        }

        public void Update()
        {
            //update an existing record based on the values
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("OrderID", mThisOrder.OrderID);
            DB.AddParameter("DateAdded", mThisOrder.DateAdded);
            DB.AddParameter("OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("Town", mThisOrder.Town);
            // execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Payment object
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.Town = Convert.ToString(DB.DataTable.Rows[Index]["City"]);
                AnOrder.OrderStatus = Convert.ToString(DB.DataTable.Rows[Index]["OrderStatus"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }
    }
}