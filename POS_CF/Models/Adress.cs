using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace POS_CF.Models
{
    public class Adress
    {
        public int AdressID { get; set; }
        [Required]
        [StringLength(150)]
        public string Adress_st { get; set; }
        [Required]
        [StringLength(100)]
        public string City { get; set; }
        [Required]
        [StringLength(7)]
        public string Zip_Code { get; set; }

        public Customer Customer { get; set; }


    }
}
