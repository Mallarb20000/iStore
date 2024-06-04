using System;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Active { get; set; }
        //private data members to the test data value
        private DateTime mDateAdded;
        // dateadded public library
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
        //private data member for the order id property
        private Int32 mOrderID;
            //orderid public property
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
        //private data member for town
        private string mTown;
        //town public property
        public string Town 
        { 
            get 
            {
                //this line sends out the property
                return mTown;
            }
            set
            {
                mTown = value;
            }
        }
        public string Search { get; set; }

        // FIND METHOD
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
                mTown = Convert.ToString(DB.DataTable.Rows[0]["City"]);
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
            /*mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
            mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["23/12/2022"]);
            mTown = Convert.ToString(DB.DataTable.Rows[0]["City"]);*/
            
            //always return true
           // return true;
            
        }
        //function for the public validation method
       /* public string Valid(string Town,
                            string Street,
                            DateTime DateAdded) 
        //// this function accepts 3 parameters for validation
        //// the function returns a string containing any error message
        //// if no errors found then a blank string is returned
        { }*/

        public string Valid(string town, string street, string dateAdded)
        {
            return "";
        }
    }
}