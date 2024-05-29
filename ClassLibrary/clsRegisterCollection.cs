using System.Collections.Generic;

namespace ClassLibrary

{
    public class clsRegisterCollection
    {
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