﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Catergory { get; set; }
        public decimal Price { get; set; }
    }
}