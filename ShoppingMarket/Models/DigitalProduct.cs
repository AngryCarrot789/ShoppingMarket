using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingMarket.Models;

namespace ShoppingMarket
{
    public class DigitalProduct : IProductModel
    {
        public string ItemName { get; set; }
        public bool Shipped { get; set; }

        public void ShipItem(CustomerModel customer)
        {

        }
    }
}
