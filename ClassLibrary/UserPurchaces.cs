using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary
{
    public class UserPurchasesBase
    {
        public int PurchaseID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public string CustomerEmail { get; set; }
        public string Product { get; set; }
        public DateTime DatetimeStamp { get; set; }

        protected static List<UserPurchasesBase> _purchases = new List<UserPurchasesBase>();

        public virtual bool Create()
        {
            PurchaseID = _purchases.Count + 1;  // Simulate auto-increment ID
            _purchases.Add(this);
            return true;
        }

        public virtual bool Read(int customerID, int productID, out UserPurchasesBase purchase)
        {
            purchase = _purchases.FirstOrDefault(p => p.CustomerID == customerID && p.ProductID == productID);
            return purchase != null;
        }

        public virtual bool Update()
        {
            var existingPurchase = _purchases.FirstOrDefault(p => p.CustomerID == CustomerID && p.ProductID == ProductID);
            if (existingPurchase != null)
            {
                existingPurchase.CustomerEmail = CustomerEmail;
                existingPurchase.Product = Product;
                existingPurchase.DatetimeStamp = DatetimeStamp;
                return true;
            }
            return false;
        }

        public virtual bool Delete(int customerID, int productID)
        {
            var purchase = _purchases.FirstOrDefault(p => p.CustomerID == customerID && p.ProductID == productID);
            if (purchase != null)
            {
                _purchases.Remove(purchase);
                return true;
            }
            return false;
        }

        public virtual bool Find(int purchaseID)
        {
            var purchase = _purchases.FirstOrDefault(p => p.PurchaseID == purchaseID);
            if (purchase != null)
            {
                PurchaseID = purchase.PurchaseID;
                CustomerID = purchase.CustomerID;
                ProductID = purchase.ProductID;
                CustomerEmail = purchase.CustomerEmail;
                Product = purchase.Product;
                DatetimeStamp = purchase.DatetimeStamp;
                return true;
            }
            return false;
        }

        public string Valid()
        {
            string error = "";

            if (CustomerID <= 0)
            {
                error += "CustomerID must be greater than 0. ";
            }
            if (ProductID <= 0)
            {
                error += "ProductID must be greater than 0. ";
            }
            if (string.IsNullOrWhiteSpace(CustomerEmail))
            {
                error += "CustomerEmail cannot be null or empty. ";
            }
            if (string.IsNullOrWhiteSpace(Product))
            {
                error += "Product cannot be null or empty. ";
            }
            if (DatetimeStamp == default(DateTime))
            {
                error += "DatetimeStamp must be set. ";
            }

            return error;
        }

        public static void ClearPurchases()
        {
            _purchases.Clear();
        }

    }
}
