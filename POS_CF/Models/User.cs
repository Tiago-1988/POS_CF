﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace POS_CF.Models
{
    public class User
    {
        public int UserID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        
    }
}
