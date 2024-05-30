using System;
using System.Collections.Generic;

namespace ClassLibrary

{
    public class clsRegisterCollection
    {

        public clsRegisterCollection()
        {

            //variable for the index
            Int32 Index = 0;

            //varible to store the record count 
            Int32 RecordCount = 0;
           //object for the data connect
           clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblEMS_SelectALL");
            RecordCount = DB.Count;
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
        //Private Data members
        List<clsRegister> mRegisterlist = new List<clsRegister> ();

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
        public clsRegister ThisRegister { get; set; }
    }
}