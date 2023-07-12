﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.EFClasses;

namespace DataLayer.EFClasses
{
    public class Tag
    {
        
        [Key]
        [Required]
        [MaxLength(40)]
        public string? TagId { get; set; } 
        
        public ICollection<Book>? Books { get; set; }
    }
}
