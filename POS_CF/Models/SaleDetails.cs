using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POS_CF.Models
{
    public class SaleDetails
    {
        public int SaleID { get; set; }
        public int ProductID { get; set; }
        public double Quantity { get; set; }
        public decimal UnitePrice { get; set; }
        public decimal TotalAmout { get; set; }
    }
}
