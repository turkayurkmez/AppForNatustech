using Natustech.Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natustech.Store.Models
{
    public class Cart
    {
        private List<ProductInCart> products = new List<ProductInCart>();

        public void AddItem(Product product, int quantity)
        {
            ProductInCart existingProduct = products.FirstOrDefault(x => x.Product.Id == product.Id);
            if (existingProduct == null)
            {
                products.Add(new ProductInCart { Product = product, Quantity = quantity });
            }
            else
            {
                existingProduct.Quantity += quantity;
            }
        }

        public decimal GetTotalValue()
        {
            return products.Sum(x =>(decimal) x.Product.Price * x.Quantity);

        }

        public void Clear() => products.Clear();
        public void Remove(Product product) => products.RemoveAll(x => x.Product.Id == product.Id);

        //JSON'a serileşmesi için public bir koleksiyon döndürüyoruz (property -> get)
        public IEnumerable<ProductInCart> Products => products;

    }
}
