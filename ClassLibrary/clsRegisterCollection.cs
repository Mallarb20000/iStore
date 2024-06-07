using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace ClassLibrary

{
    public class clsRegisterCollection
    {
        //Private Data members
        List<clsRegister> mRegisterlist = new List<clsRegister>();
        clsRegister mThisRegister = new clsRegister();
        public clsRegisterCollection()
        {
            //onject for data connection
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblEMS_SelectAll");
            populateArray(DB);
        }

        void populateArray(clsDataConnection DB)
        {
            //populate the array list based on the datat table in the parameter DB
            
        //variable for the index
        Int32 Index = 0;

        //varible to store the record count 
        Int32 RecordCount;
        RecordCount = DB.Count;
            //clear private array list
         mRegisterlist= new List<clsRegister>();
        //while there are record to process
        while (Index<RecordCount)
        {
            clsRegister ARegister = new clsRegister();
            ARegister.E_Id = Convert.ToInt32(DB.DataTable.Rows[Index]["E_Id"]);
            ARegister.Name = Convert.ToString(DB.DataTable.Rows[Index]["E_Name"]);
            ARegister.Username = Convert.ToString(DB.DataTable.Rows[Index]["E_username"]);
            ARegister .Password= Convert.ToString(DB.DataTable.Rows[Index]["E_password"]);
            ARegister .Trained= Convert.ToBoolean(DB.DataTable.Rows[Index]["E_trained"]);
            ARegister.Timestamp = Convert.ToDateTime(DB.DataTable.Rows[Index]["E_Idcreated"]);
            ARegister.Salary = Convert.ToInt32(DB.DataTable.Rows[Index]["E_salary"]);
            //add the record to private data memnber 
            mRegisterlist.Add(ARegister);
            //point to next record
            Index++;
        }
            
        }
        

        public List<clsRegister> RegisterList
        {
            get
            {
                return mRegisterlist;
            }
            set
            {
                mRegisterlist = value;
            }
        }
        public int Count 
        { 
            get
            {
                return mRegisterlist.Count;
            }
            set
            {
               // return mRegisterlist.Count = value;
            } 
        }
        
        public clsRegister ThisRegister
        {
            get
            {
                return mThisRegister;
            }
            set
            {
                mThisRegister = value;
            }
        }

        public int Add()
        {
            ///connect to DB
            clsDataConnection DB = new clsDataConnection();
            //set the parameters sfor stored procedure
            //DB.AddParameter("@E_Id", mThisRegister.E_Id );
            DB.AddParameter("@E_name", mThisRegister.Name);
            DB.AddParameter("@E_username",mThisRegister.Username);
            DB.AddParameter("@E_password", mThisRegister.Password);
            DB.AddParameter("E_salary", mThisRegister.Salary);
            DB.AddParameter("E_trained", mThisRegister.Trained);
            DB.AddParameter("E_Idcreated", mThisRegister.Timestamp);

            //execute the query returning the primary key
            return DB.Execute("sproc_tblEMS_Insert");
        }


       
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@E_Id", mThisRegister.E_Id);
            DB.Execute("sproc_tblEMS_Delete");
        }

        public void Filter(string Username)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@E_username", Username);
            DB.Execute("sproc_tblEMS_FilteredByUsername");
            populateArray(DB);
        }

        public void Update()
        {
            ///connect to DB
            clsDataConnection DB = new clsDataConnection();
            //set the parameters sfor stored procedure
            DB.AddParameter("@E_Id", mThisRegister.E_Id );
            DB.AddParameter("@E_name", mThisRegister.Name);
            DB.AddParameter("@E_username", mThisRegister.Username);
            DB.AddParameter("@E_password", mThisRegister.Password);
            DB.AddParameter("E_salary", mThisRegister.Salary);
            DB.AddParameter("E_trained", mThisRegister.Trained);
            DB.AddParameter("E_Idcreated", mThisRegister.Timestamp);

            //execute the query returning the primary key
           DB.Execute("sproc_tblEMS_Update");
        }
    }
}