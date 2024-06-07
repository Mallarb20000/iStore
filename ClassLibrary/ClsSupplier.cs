using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ClsSupplier
    {
        // Private data members
        private int mSupplierId;
        private string mSupplierName;
        private string mContactName;
        private string mContactEmail;
        private bool mIsActive;
        private DateTime mJoinDate;
        private int mRating;
        private string mPassword;

        // Public properties
        public int SupplierId
        {
            get { return mSupplierId; }
            set { mSupplierId = value; }
        }

        public string SupplierName
        {
            get { return mSupplierName; }
            set { mSupplierName = value; }
        }

        public string ContactName
        {
            get { return mContactName; }
            set { mContactName = value; }
        }

        public string ContactEmail
        {
            get { return mContactEmail; }
            set { mContactEmail = value; }
        }

        public bool IsActive
        {
            get { return mIsActive; }
            set { mIsActive = value; }
        }

        public DateTime JoinDate
        {
            get { return mJoinDate; }
            set { mJoinDate = value; }
        }

        public int Rating
        {
            get { return mRating; }
            set { mRating = value; }
        }

        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }

        // Find method for supplier by SupplierId
        public bool Find(int supplierId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierId", supplierId);
            DB.Execute("sproc_tblPMS_FindBySupplierId");

            if (DB.Count == 1)
            {
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mContactName = Convert.ToString(DB.DataTable.Rows[0]["ContactName"]);
                mContactEmail = Convert.ToString(DB.DataTable.Rows[0]["ContactEmail"]);
                mIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsActive"]);
                mJoinDate = Convert.ToDateTime(DB.DataTable.Rows[0]["JoinDate"]);
                mRating = Convert.ToInt32(DB.DataTable.Rows[0]["Rating"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        // Valid method
        public string Valid(string supplierName, string contactName, string contactEmail, string isActive, string joinDate, string rating, string password)
        {
            // Create a string variable to store the error
            string Error = "";

            // Validation rules

            // SupplierName cannot be blank
            if (supplierName.Length == 0)
            {
                Error += "The supplier name may not be blank. ";
            }
            // SupplierName must be less than 50 characters
            if (supplierName.Length > 50)
            {
                Error += "The supplier name must be less than 50 characters. ";
            }

            // ContactName cannot be blank
            if (contactName.Length == 0)
            {
                Error += "The contact name may not be blank. ";
            }
            // ContactName must be less than 50 characters
            if (contactName.Length > 50)
            {
                Error += "The contact name must be less than 50 characters. ";
            }

            // ContactEmail cannot be blank
            if (contactEmail.Length == 0)
            {
                Error += "The contact email may not be blank. ";
            }
            // ContactEmail must be less than 100 characters
            if (contactEmail.Length > 100)
            {
                Error += "The contact email must be less than 100 characters. ";
            }
            // ContactEmail must be in a valid format
            if (!Regex.IsMatch(contactEmail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                Error += "The contact email format is not valid. ";
            }

            // IsActive must be either 'true' or 'false'
            bool isActiveBool;
            if (!bool.TryParse(isActive, out isActiveBool))
            {
                Error += "The active status must be either 'true' or 'false'. ";
            }

            // JoinDate must be a valid date
            DateTime joinDateTemp;
            if (!DateTime.TryParse(joinDate, out joinDateTemp))
            {
                Error += "The join date is not a valid date. ";
            }

            // Rating must be a valid integer
            int ratingTemp;
            if (!int.TryParse(rating, out ratingTemp))
            {
                Error += "The rating must be a valid integer. ";
            }

            // Password cannot be blank
            if (password.Length == 0)
            {
                Error += "The password may not be blank. ";
            }
            // Password must be less than 100 characters
            if (password.Length > 100)
            {
                Error += "The password must be less than 100 characters. ";
            }

            // Return any error messages
            return Error;
        }
    }
}