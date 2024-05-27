using System;

namespace Testing3
{
    public class clsPayment
    {
        //private data member for the TransactionID property
        private Int32 mTransactionID;

        public Int32 TransactionID
        {
            get
            {
                //this line of code sends data out of the property
                return mTransactionID;
            }
            set
            {
                //this line of code allows data into property
                mTransactionID = value;
            }
        }

        public bool Active { get; set; }
        public bool PaymentAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int PaymentMethod { get; set; }
        public string TransactionStatus { get; set; }
        public int OrderID { get; set; }


        public bool Find(int TransactonId) =>
            //always return true
            true;
    }
}