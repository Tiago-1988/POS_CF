using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS_CF.Models
{
    public class Customer
    {
        public int CusomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string NIF { get; set; }
        public int AdressID { get; set; }
    }
}
