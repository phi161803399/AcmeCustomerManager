using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase
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
        private string _ProductName;

        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }




        public override bool Validate()
        {
            //var isValid = true;

            //if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            //if (CurrentPrice == null) isValid = false;
            //return isValid;
            return !(string.IsNullOrWhiteSpace(ProductName) || (CurrentPrice == null));
        }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
