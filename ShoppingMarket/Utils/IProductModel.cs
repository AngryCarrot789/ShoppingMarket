using ShoppingMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingMarket
{
    public interface IProductModel
    {
        string ItemName { get; set; }
        bool Shipped { get; set; }
        void ShipItem(CustomerModel customer);
    }
}
