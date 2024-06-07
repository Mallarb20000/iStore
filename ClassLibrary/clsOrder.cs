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
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public string OrderStatus { get; set; }

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

        public string Valid(string town, string dateAdded, string orderStatus, string customerID)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temp variable to store date values
            DateTime DateTemp;
            //if the Order Stat is blank
            if (orderStatus.Length == 0)
            {
                // record the error
                Error = Error + "The Order may not be blank:";
            }
            //if the Order stat is greater than 6 characters
            if (orderStatus.Length > 6)
            {
                //record the error
                Error = Error + "The order status must not be less than 6 characters:";
            }

            //create an instance of DateTime to comparre 
            //in the if statements
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the dateadded value to the datetemp variable
                DateTemp = Convert.ToDateTime(dateAdded);

                if (DateTemp < DateComp) //compare dateadded with Date
                {
                    //record the error
                    Error = Error + "The date cannot be in the past";
                }
                //check tto see if the date is greater than today's date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date is invalid";
            }

            //is the town blank
            if (town.Length == 0)
            {
                //record the error
                Error = Error + "The town may not be blank : ";
            }
            //if the town is too long
            if (town.Length > 50)
            {
                //record the error
                Error = Error + "The town must be less than 50 characters : ";
            }
            //return any error messages
            return Error;
        }

        //function for the public validation method
        /* public string Valid(string Town,
                             string Street,
                             DateTime DateAdded) 
         //// this function accepts 3 parameters for validation
         //// the function returns a string containing any error message
         //// if no errors found then a blank string is returned
         { }*/



    } 
}