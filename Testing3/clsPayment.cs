using System;

namespace Testing3
{
    public class clsPayment
    {
        public bool Active { get; internal set; }
        public bool PaymentAmount { get; internal set; }
        public DateTime PaymentDate { get; internal set; }
        public int PaymentMethod { get; internal set; }
        public string TransactionStatus { get; internal set; }
        public int OrderID { get; internal set; }
        public int TransactionID { get; internal set; }
    }
}