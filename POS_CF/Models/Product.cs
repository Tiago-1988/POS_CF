using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS_CF.Models
{


    public enum VAT
    {
        Exempt= 0, Minimum =  6, Intermediate = 3, Maximum = 23
    }
    public class Product
    {
        public int ProductID { get; set; }
        public int Name { get; set; }
        public decimal UntPrice { get; set; }
        public  VAT VAT { get; set; }
        public double Stock { get; set; }
        public DateTime DateCreated { get; set; } 
        public int CategoryID { get; set; }

        public decimal FinalPrice
        {
            get
            {
                return UntPrice + UntPrice * (decimal)VAT / 100;
            }

        }
    }
}
