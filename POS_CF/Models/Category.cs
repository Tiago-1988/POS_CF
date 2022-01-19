using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace POS_CF.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
