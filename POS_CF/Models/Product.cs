using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        [StringLength(100)]
        public int Name { get; set; }
        [DisplayFormat(DataFormatString ="{0:C}")]
        public decimal UntPrice { get; set; }

        public  VAT VAT { get; set; }
        [Required]
        public double Stock { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateCreated { get; set; }

        public int CategoryID { get; set; }

        public decimal FinalPrice
        {
            get
            {
                return UntPrice + UntPrice * (decimal)VAT / 100;
            }

        }

        public Category Category { get; set; }
    }
}
