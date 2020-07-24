﻿using Microsoft.AspNetCore.Routing.Constraints;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemListing
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        //[Display(Name ="Name")]
        public string Name { get; set; }

        [Display(Name = "Free Delivery")]
        public Boolean freeDelivery { get; set; }

        [Required]
        public double Price { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",ApplyFormatInEditMode=true)]
        public DateTime dateOfLaunch { get; set; }

        public Boolean Active { get; set; }
        
    }
}
