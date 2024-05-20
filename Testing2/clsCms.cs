using System;
using System.CodeDom;

namespace TestingCms.TestingCms
{
    internal class clsCms
    {
        public DateTime PaymentDate { get; internal set; }
        public int CustomerName { get; internal set; }
        public string CustomerEmail { get; internal set; }
        public string CustomerPassword { get; internal set; }

        private string postCode;

        //post code public property 
        public string GetPostCode()
        {
            return postCode;
        }

        //post code public property 
        public void SetPostCode(string value)
        {
            postCode = value;
        }

        public int CustomerID { get; internal set; }

        public bool Find(int customerId)
        {
            // set the rpivate data members to the test the value
            mCustomerId = 21;   
            // always return true
            return true;
        }
        private Int32 mCustomerId;

        public Int32 CustomerId
        {
            get
            {
                //return line of code sends data out of property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        }
        //private data member for the post code property 
        private string mPostCode;
        //post code public property 
        public string PostCode
        {
            get
            {
                //this line of code sends data out of the property 
                return mPostCode;
            }
            set
            {
                //this line of code allows data into the property 
                mPostCode = value;
            }
        }
       

        //private data member for the active property 
        private Boolean mActive;
        //active public property 
        public bool Active
        {
            get
            {
                //this line of code sends data out of the property 
                return mActive;
            }
            set
            {
                //this line of code allows data into the property 
                mActive = value;
            }
        }

    }



}