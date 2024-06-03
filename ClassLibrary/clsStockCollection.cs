using System;
using System.Collections.Generic;


namespace ClassLibrary

{
    public class clsStockCollection
    {
        //constructor for the class
        public clsStockCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count 
            Int32 RecordCount= 0;   
            //object for the data connect 
            clsDataConnection DB = new clsDataConnection();
            //exacute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are rcords to process
            while ( Index < RecordCount )
            {
                //create a blank stock
                clsStock AnStock = new clsStock();
                //read in the fields
                AnStock.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnStock.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AnStock.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                AnStock.ProductPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductPrice"]);
                AnStock.ProductQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductQuantity"]);
                AnStock.ProductDescription = Convert.ToString(DB.DataTable.Rows[Index]["ProductDescription"]);
                AnStock.ProductImg = Convert.ToString(DB.DataTable.Rows[Index]["ProductImg"]);
                //add the record to the  the private data member
                mStockList.Add( AnStock );
                //point at the next record
                Index++;

            }


        }



        //private data member for the list 
        List<clsStock> mStockList = new List<clsStock>();

        //public property for the stock list 
        public List<clsStock> StockList
        {
            get
            {
                //return the priavte data 
                return mStockList;
            }
            set
            {
                //set the private data 
                mStockList = value;
            }
        
        }
         //public property for count
         public int Count
        {
            get
            {
               //return the count of the list 
                return mStockList.Count;

            }

        set
            {

            }

        }

        public clsStock ThisStock { get; set; }
    
    }

    
   

}