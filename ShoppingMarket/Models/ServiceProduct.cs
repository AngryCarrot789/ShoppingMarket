using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingMarket.Models
{
    public class ServiceProduct : IProductModel
    {
        public string ItemName { get; set; }
        public bool Shipped { get; set; }

        public void ShipItem(CustomerModel customer)
        {

        }
    }
}
