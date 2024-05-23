using System;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public Int32 OrderID
        {
            get
            {
                //this life of code sends data out of the property
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
            //set the private data members to the test data value
            mOrderID = 21;
            //always return true
            return true;
        }
        //priate data member for the Order ID property
        private Int32 mOrderID;
    }
}