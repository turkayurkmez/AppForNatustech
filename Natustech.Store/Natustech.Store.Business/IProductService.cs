using Natustech.Store.Domain;
using System.Collections.Generic;

namespace Natustech.Store.Business
{
    public interface IProductService
    {
        List<Product> GetProducts();
        IList<Product> GetProductsByCategoryId(int value);
    }
}