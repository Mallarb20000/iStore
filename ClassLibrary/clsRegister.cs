using System;

namespace ClassLibrary
{
    public class clsRegister
    {
        private Int32 mE_Id;
        public string username { get; set; }
        public int E_Id {
            get 
            {
                //to return data of the property
                return mE_Id;
            } set 
            {
                mE_Id = value;  
        
            }
        }

        public bool Find(int E_Id)
        {
            mE_Id = 1;
            return true;
        }
    }
}