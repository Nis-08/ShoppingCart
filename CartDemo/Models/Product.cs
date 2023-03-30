﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CartDemo.Models
{
    public class Product
    {
        [Key]
        
        public string ProductId { get; set; }
        [Required(ErrorMessage ="Required")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Required")]
        public string ProductCategory { get; set; }
        [Required(ErrorMessage = "Required")]
        public string ProductPrice { get; set; }
        [Required(ErrorMessage = "Required")]
        public string ProductQuantity { get; set; }
       public string ProductDescription { get; set; }
        public string CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        
        

    }
}