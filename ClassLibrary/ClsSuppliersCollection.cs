using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ClsSuppliersCollection
    {
        // Private data member for the list
        private List<ClsSupplier> mSuppliersList = new List<ClsSupplier>();
        // Private data member for ThisSupplier
        private ClsSupplier mThisSupplier = new ClsSupplier();

        // Public property for the SuppliersList
        public List<ClsSupplier> SuppliersList
        {
            get { return mSuppliersList; }
            set { mSuppliersList = value; }
        }

        // Public property for Count
        public int Count
        {
            get { return mSuppliersList.Count; }
        }

        // Public property for ThisSupplier
        public ClsSupplier ThisSupplier
        {
            get { return mThisSupplier; }
            set { mThisSupplier = value; }
        }

        // Constructor for the class
        public ClsSuppliersCollection()
        {
            // Object for the data connection
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure to get all suppliers
            DB.Execute("sproc_tblPMS_SelectAll");
            // Populate the list with the data table
            PopulateArray(DB);
        }

        // Method to populate the list based on the data table in the parameter DB
        void PopulateArray(clsDataConnection DB)
        {
            // Populate the list based on the table in the database
            int Index = 0;
            int RecordCount = DB.Count;
            mSuppliersList = new List<ClsSupplier>();
            while (Index < RecordCount)
            {
                ClsSupplier ASupplier = new ClsSupplier();
                ASupplier.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                ASupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                ASupplier.ContactName = Convert.ToString(DB.DataTable.Rows[Index]["ContactName"]);
                ASupplier.ContactEmail = Convert.ToString(DB.DataTable.Rows[Index]["ContactEmail"]);
                ASupplier.IsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                ASupplier.JoinDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["JoinDate"]);
                ASupplier.Rating = Convert.ToInt32(DB.DataTable.Rows[Index]["Rating"]);
                mSuppliersList.Add(ASupplier);
                Index++;
            }
        }

        public bool IsEmailRegistered(string email)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ContactEmail", email);
            DB.Execute("sproc_tblPMS_FindByEmail");
            if (DB.Count == 1)
            {
                return true;
            }
            return false;
        }

        public int Add()
        {
            // Add a new record to the database based on the values of mThisSupplier
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@ContactName", mThisSupplier.ContactName);
            DB.AddParameter("@ContactEmail", mThisSupplier.ContactEmail);
            DB.AddParameter("@IsActive", mThisSupplier.IsActive);
            DB.AddParameter("@JoinDate", mThisSupplier.JoinDate);
            DB.AddParameter("@Rating", mThisSupplier.Rating);
            // Execute the query returning the primary key value
            return DB.Execute("sproc_tblPMS_Insert");
        }

        public void Delete(int supplierId)
        {
            // Delete a record from the database based on the SupplierId
            clsDataConnection DB = new clsDataConnection();
            // Set the parameter for the stored procedure
            DB.AddParameter("@SupplierId", supplierId);
            // Execute the stored procedure
            DB.Execute("sproc_tblPMS_Delete");
        }

        public void Update()
        {
            // Update an existing record in the database based on the values of mThisSupplier
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@SupplierId", mThisSupplier.SupplierId);
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@ContactName", mThisSupplier.ContactName);
            DB.AddParameter("@ContactEmail", mThisSupplier.ContactEmail);
            DB.AddParameter("@IsActive", mThisSupplier.IsActive);
            DB.AddParameter("@JoinDate", mThisSupplier.JoinDate);
            DB.AddParameter("@Rating", mThisSupplier.Rating);
            // Execute the stored procedure
            DB.Execute("sproc_tblPMS_Update");
        }
    }
}