using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaEPolimorfismo2.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufacturedDate) : base(name, price)
        {
            ManufacturedDate = manufacturedDate;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + " (used) (Manufacture date: " + ManufacturedDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
