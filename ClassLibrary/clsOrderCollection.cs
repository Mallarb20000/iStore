using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member of the list
        List<clsOrder> mOrderList = new List<clsOrder>();
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
        public clsOrder ThisOrder { get; set; }

        public clsOrderCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsOrder AnOrder = new clsOrder();
                //read in the fields for the current record
                AnOrder.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.Town = Convert.ToString(DB.DataTable.Rows[Index]["Town"]);
                AnOrder.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnOrder.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AnOrder.OrderStatus = Convert.ToString(DB.DataTable.Rows[Index]["OrderStatus"]);
                //add the record to the private data member
                mOrderList.Add( AnOrder );
                //point at the next record
                Index++;
            }
            /*//create the items of test data
            clsOrder TestItem = new clsOrder();
            //set the properties
            TestItem.Active = true;
            TestItem.OrderID = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.OrderStatus = "pending";
            TestItem.Town = "Leicester";
            TestItem.CustomerID = 101;
            //add the test items to test list
            mOrderList.Add(TestItem);
            // re initialise the object for some new data
            TestItem = new clsOrder();
            //set its properties
            TestItem.Active = true;
            TestItem.OrderID = 1;
            TestItem.DateAdded = DateTime.Now;
            TestItem.OrderStatus = "pending";
            TestItem.Town = "Leicester";
            TestItem.CustomerID = 101;
            // ad the item to the test list
            mOrderList.Add(TestItem);*/
        }
    }
}