using Natustech.Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Natustech.Store.DataAccess
{
    public class FakeProductRepository : IProductRepository
    {
        public Product Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAllEntities()
        {
            return new List<Product>
            {
                 new Product{ Id=1, Name="Xiaomi", Description="Poco X3", ImageUrl="https://cdn.dsmcdn.com//ty18/product/media/images/20201028/10/20058089/98295022/1/1_org.jpg", Discount=0.15, Price=3570, Rating=5},
                 new Product{ Id=2, Name="A", Description="Poco X3", ImageUrl="https://cdn.dsmcdn.com//ty18/product/media/images/20201028/10/20058089/98295022/1/1_org.jpg", Discount=0.15, Price=3570, Rating=5},
                 new Product{ Id=3, Name="B", Description="Poco X3", ImageUrl="https://cdn.dsmcdn.com//ty18/product/media/images/20201028/10/20058089/98295022/1/1_org.jpg", Discount=0.15, Price=3570, Rating=5},
                 new Product{ Id=4, Name="C", Description="Poco X3", ImageUrl="https://cdn.dsmcdn.com//ty18/product/media/images/20201028/10/20058089/98295022/1/1_org.jpg", Discount=0.15, Price=3570, Rating=5},
                 new Product{ Id=5, Name="X", Description="Poco X3", ImageUrl="https://cdn.dsmcdn.com//ty18/product/media/images/20201028/10/20058089/98295022/1/1_org.jpg", Discount=0.15, Price=3570, Rating=5},
                 new Product{ Id=6, Name="Y", Description="Poco X3", ImageUrl="https://cdn.dsmcdn.com//ty18/product/media/images/20201028/10/20058089/98295022/1/1_org.jpg", Discount=0.15, Price=3570, Rating=5},
                 new Product{ Id=7, Name="Z", Description="Poco X3", ImageUrl="https://cdn.dsmcdn.com//ty18/product/media/images/20201028/10/20058089/98295022/1/1_org.jpg", Discount=0.15, Price=3570, Rating=5},
                 new Product{ Id=8, Name="Q", Description="Poco X3", ImageUrl="https://cdn.dsmcdn.com//ty18/product/media/images/20201028/10/20058089/98295022/1/1_org.jpg", Discount=0.15, Price=3570, Rating=5},
                 new Product{ Id=9, Name="1", Description="Poco X3", ImageUrl="https://cdn.dsmcdn.com//ty18/product/media/images/20201028/10/20058089/98295022/1/1_org.jpg", Discount=0.15, Price=3570, Rating=5},
                 new Product{ Id=10, Name="2", Description="Poco X3", ImageUrl="https://cdn.dsmcdn.com//ty18/product/media/images/20201028/10/20058089/98295022/1/1_org.jpg", Discount=0.15, Price=3570, Rating=5}
            };
        }

        public IList<Product> GetAllEntities(Expression<Func<Product, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetProductsByName(string name)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
