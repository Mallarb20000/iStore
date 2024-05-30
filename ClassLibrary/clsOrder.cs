using System;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Active { get; set; }
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of the property
                return mDateAdded;
            }
            set
            {
                //this line of the code allows data into the property
                mDateAdded = value;
            }
        }
        public Int32 OrderID
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderID;
            }
            set
            {
                //this line of the code allows data into the property
                mOrderID = value;
            }
        }
        public int CountyCode { get; set; }
        /*public string HouseNo { get; set; }*/
        public string PostCode { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string Search { get; set; }

        public bool Find(int orderID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order id to search for
            DB.AddParameter("@OrderID", orderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                //return that everything worked
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }

            //set the private data members to the test data value
            mOrderID = 21;
            mDateAdded = Convert.ToDateTime("23/12/2022");
            
            //always return true
            return true;
            
        }
        //priate data member for the Order ID property
        private Int32 mOrderID;
        private DateTime mDateAdded;
    }
}