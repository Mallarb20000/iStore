using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the ProductID property
        private Int32 mProductID;
        
        //productID public property
        public Int32 ProductID

        {
            get
            {
                //this line of code sends data out of the property
                return mProductID;
            }
            set
            {
            
                //this line of code allows data into the property
                mProductID = value; 
            
            }
        }

        //private data member for the ProductName property
        private String mProductName;

        //productName public property
        public String ProductName

        {
            get
            {
                //this line of code sends data out of the property
                return mProductName;
            }
            set
            {

                //this line of code allows data into the property
                mProductName = value;

            }
        }

        //private data member for the ProductPrice property
        private Int32 mProductPrice;

        //productPrice public property
        public Int32 ProductPrice

        {
            get
            {
                //this line of code sends data out of the property
                return mProductPrice;
            }
            set
            {

                //this line of code allows data into the property
                mProductPrice = value;

            }
        }

        //private data member for the ProductQuantity property
        private Int32 mProductQuantity;

        //ProductQuantity public property
        public Int32 ProductQuantity

        {
            get
            {
                //this line of code sends data out of the property
                return mProductQuantity;
            }
            set
            {

                //this line of code allows data into the property
                mProductQuantity = value;

            }
        }

        //private data member for the ProductDescription property
        private String  mProductDescription;

        //ProductDescription public property
        public String ProductDescription

        {
            get
            {
                //this line of code sends data out of the property
                return mProductDescription;
            }
            set
            {

                //this line of code allows data into the property
                mProductDescription = value;

            }
        }

        //private data member for the ProductImg  property
        private String mProductImg;

        //ProductImg  public property
        public String ProductImg

        {
            get
            {
                //this line of code sends data out of the property
                return mProductImg;
            }
            set
            {

                //this line of code allows data into the property
                mProductImg = value;

            }
        }

        //private data member for the Active  property
        private Boolean mActive;

        //Active public property
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



                       // find method//
       
    
        
        public bool Find(int ProductID)
        {

            //create an istance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter fo the ProductID
            DB.AddParameter ("@ProductID", ProductID);
            //exacute the stored procedure 
            DB.Execute("dbo.sproc_tblSMS_FilterByProductID");
            // if one record is found (there should be either one or zero)
            if(DB.Count == 1)
            {
                //copy the data from th database to the private data members
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mProductPrice = Convert.ToInt32(DB.DataTable.Rows[0]["ProductPrice"]);
                mProductQuantity= Convert.ToInt32(DB.DataTable.Rows[0]["ProductQuantity"]);
                mProductDescription = Convert.ToString(DB.DataTable.Rows[0]["ProductDescription"]);
                mProductImg = Convert.ToString(DB.DataTable.Rows[0]["ProductImg"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everthing worked OK
                return true;

            }

            // if no record was found
            else
            {
                //return false indicating there is  problem
                return false;
            }

            
        }

        public string Valid(string productName, string productPrice, String productQuantity, string productDescription )
        {
            //create a string variable to store the error
            string Error = "";


            if (productName.Length == 0)
            {
                //record the error
                Error += "Name cannot be blank";
            }

            if (productName.Length > 50)
            {
                //record the error
                Error += " the Product Name must be less then 51";
            }

            if (productPrice.Length == 0)
            {
                //record the error
                Error += "Price cannot be blank";
            }

            if (productPrice.Length > 6)
            {
                //record the error
                Error += " the Product Price must be less then 7";
            }

            if (productQuantity.Length == 0)
            {
                //record the error
                Error += "Quantity cannot be blank";
            }

            if (productQuantity.Length > 6)
            {
                //record the error
                Error += " the Product Quantity must be less then 7";
            }

            if (productDescription.Length == 0)
            {
                //record the error
                Error += "Description cannot be blank";
            }

            if (productDescription.Length > 50)
            {
                //record the error
                Error += " the Product Description must be less then 51";
            }

            return Error;

        }

    }
}