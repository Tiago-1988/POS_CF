using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS_CF.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        
    }
}
