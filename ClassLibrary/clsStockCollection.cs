﻿using System;
using System.Collections.Generic;


namespace ClassLibrary

{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //private member data for thisStock
        clsStock mThisStock = new clsStock();

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count 
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list 
            mStockList = new List<clsStock>();
            //while there are rcords to process
            while (Index < RecordCount)
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
                mStockList.Add(AnStock);
                //point at the next record
                Index++;
            }

        }


        //constructor for the class
        public clsStockCollection()
        {
            //onject for data connection
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            PopulateArray(DB);

        }



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

        //public property for ThisStock
        public clsStock ThisStock
        {

            get
            {
                //return the private data 
                return mThisStock;
            }

            set
            {
                //set the private data 
                mThisStock = value;
            }
        }


        public int Add()
        {
            //adds a record to the database based on the values of mThisStock
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedure 
            DB.AddParameter("@ProductName", mThisStock.ProductName);
            DB.AddParameter("@ProductPrice", mThisStock.ProductPrice);
            DB.AddParameter("@ProductQuantity", mThisStock.ProductQuantity);
            DB.AddParameter("@ProductDescription", mThisStock.ProductDescription);
            DB.AddParameter("@ProductImg", mThisStock.ProductImg);
            DB.AddParameter("@Active", mThisStock.Active);

            //execute the query returning the primary key value 
            return DB.Execute("sproc_tblStock_Insert");

        }

        public void Delete()
        {
            //Deletes the record pointed to by thisStock
            //Connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedure 
            DB.AddParameter("@ProductID", mThisStock.ProductID);
            //Exacute the stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByProductName(string ProductName)
        {
            //filters the records based on a full or partial product name 
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the product =name parameter to the database 
            DB.AddParameter("@ProductName", ProductName);
            //exacute  the stored procedure
            DB.Execute("sproc_tblStock_FilterByProductName");
            //populate the array list  with the data table
            PopulateArray(DB);

        }

        public void Update()
        {

            //update an existing record based on the values of thisStock
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedure 
            DB.AddParameter("@ProductID", mThisStock.ProductID);
            DB.AddParameter("@ProductName", mThisStock.ProductName);
            DB.AddParameter("@ProductPrice", mThisStock.ProductPrice);
            DB.AddParameter("@ProductQuantity", mThisStock.ProductQuantity);
            DB.AddParameter("@ProductDescription", mThisStock.ProductDescription);
            DB.AddParameter("@ProductImg", mThisStock.ProductImg);
            DB.AddParameter("@Active", mThisStock.Active);

            //execute the stored procedure 
            DB.Execute("sproc_tblStock_Update");

        }
    }
}

    
   

