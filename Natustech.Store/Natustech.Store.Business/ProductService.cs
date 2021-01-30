using Natustech.Store.DataAccess;
using Natustech.Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Natustech.Store.Business
{
    public class ProductService : IProductService
    {
        private IProductRepository productRepository;

        //repository olacak ama her an değişebilir.
        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public Product AddProduct(Product product)
        {
           var addedProduct =  productRepository.Add(product);
            return addedProduct;
        }

        public Product GetProductById(int id)
        {
            return productRepository.GetById(id);
        }

        public List<Product> GetProducts()
        {
            return productRepository.GetAllEntities().ToList();
        }

        public IList<Product> GetProductsByCategoryId(int categoryId)
        {
            return productRepository.GetAllEntities(x => x.CategoryId == categoryId);
        }

        public void Update(Product product)
        {
            productRepository.Update(product);

        }
    }
}
