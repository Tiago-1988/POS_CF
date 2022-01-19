using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS_CF.Models
{
    public class Sale
    {
        public int SaleID { get; set; }
        public int SaleNumber { get; set; }
        public DateTime DateCreated { get; set; }
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public bool Paid { get; set; }
        public int PosID { get; set; }
    }
}
