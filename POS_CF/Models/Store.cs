using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace POS_CF.Models
{
    public class Store
    {
        public int StoreID { get; set; }
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        [Required]
        [StringLength(150)]
        public string Adress { get; set; }
        [Required]
        [StringLength(8)]
        public string ZipCode { get; set; }
        [Required]
        [StringLength(9)]
        public string Phone { get; set; }
        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        public DateTime CreatedDate { get; set; }

        public ICollection<Pos> Pos { get; set; }
    }
}
