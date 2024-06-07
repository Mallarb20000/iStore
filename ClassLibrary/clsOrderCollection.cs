using System;
using System.Collections.Generic;

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
    }
}