﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        // Foreign key usage
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
    }
}