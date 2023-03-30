﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CartDemo.Models
{
    public class CartDBContext:DbContext
    {
        public CartDBContext() : base("name=CartConnection")
        {

        }

        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Merchant> merchants { get; set; }
        public DbSet<OrderDetail> orderdetails { get; set; }
        

    }
}