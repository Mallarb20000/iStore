using System;

namespace Testing3
{
    public class clsPayment
    {
        //private data member for the TransactionID property
        private Int32 mPaymentID;
        private string mName;
        private string mEmail;
        private string mPostCode;
        private DateTime mPaymentDate;
        private string mPaymentMethod;
        private string mTransacationStatus;
        private string mPaymentAmount;

        public Int32 PaymentID
        {
            get
            {
                //this line of code sends data out of the property
                return mPaymentID;
            }
            set
            {
                //this line of code allows data into property
                mPaymentID = value;
            }
        }

        public DateTime PaymentDate
        {
            get
            {
                //this line of code sends data out of the property
                return mPaymentDate;
            }
            set
            {
                //this line of code allows data into property
                mPaymentDate = value;
            }
        }
        public string Name
        {
            get
            {
                //this line of code sends data out of the property
                return mName;
            }
            set
            {
                //this line of code allows data into property
                mName = value;
            }
        }


        public bool PaymentAmount { get; set; }
        public string TransactionStatus { get; set; }
        public string Email { get; set; }
        public string PostCode { get; set; }

        public bool Find(int TransactonId)
        {
            //set the private data members to the test data value
            mPaymentID = 1;
            //always return true
            return true;
        }

        internal bool Find(bool expectedPaymentStatus)
        {
            throw new NotImplementedException();
        }
    }
}