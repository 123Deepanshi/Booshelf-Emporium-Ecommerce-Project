﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecomm_Book_1031.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Range(1, 1000)]
        public double ListPrice { get; set; }//600
        [Required]
        [Range(1, 1000)]
        public double Price { get; set; }//590
        [Required]
        [Range(1, 1000)]
        public double Price50 { get; set; }//500
        [Required]
        [Range(1, 1000)]
        public double Price100{get; set;}//450
        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Display(Name ="Cover Type")]
        public int CoverTypeId { get; set; }
        public CoverType CoverType { get; set; } 

    }
}
