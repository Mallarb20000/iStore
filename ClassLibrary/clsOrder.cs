using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int OrderID { get; set; }
        public int CountyCode { get; set; }
        public string HouseNo { get; set; }
    }
}