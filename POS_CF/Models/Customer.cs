using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace POS_CF.Models
{
    public class Customer
    {
        public int CusomerID { get; set; }
        [Required]
        [StringLength (50)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Email { get; set; }
        [StringLength(9)]
        public string NIF { get; set; }

        public int AdressID { get; set; }

        public Adress Adress { get; set; }

}
}
