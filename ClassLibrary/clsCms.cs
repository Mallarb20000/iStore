using System;

namespace ClassLibrary
{
    public class clsCms
    {
        public int CustomerID { get; set; }
        public int CustomerId { get; set; }
        public DateTime PaymentDate { get; set; }
        public int CustomerName { get; set; }
        public string CustomerEmail { get; set; }

        public string CustomerPassword { get;  set; }
        public bool Active { get; set; }
        public string PostCode { get; set; }

        public bool Find(int customerId)
        {
            throw new NotImplementedException();
        }

        
    }
}