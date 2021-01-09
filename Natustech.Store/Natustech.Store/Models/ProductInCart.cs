using Natustech.Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natustech.Store.Models
{
    public class ProductInCart
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
