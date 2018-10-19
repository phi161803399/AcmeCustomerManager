﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            this.ProduktId = productId;
        }
        public Decimal? CurrentPrice { get; set; }
        public int ProduktId { get; private set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }

        

        public bool Validate()
        {
            //var isValid = true;

            //if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            //if (CurrentPrice == null) isValid = false;
            //return isValid;
            return !(string.IsNullOrWhiteSpace(ProductName) || (CurrentPrice == null));
        }
    }
}
