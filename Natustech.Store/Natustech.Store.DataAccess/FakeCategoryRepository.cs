using Natustech.Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Natustech.Store.DataAccess
{
    public class FakeCategoryRepository : ICategoryRepository
    {
        public Category Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Category> GetAllEntities()
        {
            return new List<Category>
             {
                 new Category { Id=1, Description="Test", Name="Telefon"},
                 new Category { Id=3, Description="Test", Name="Bilgisayar"},
                 new Category { Id=2, Description="Test", Name="Tablet"},
             };
        }

        public IList<Category> GetAllEntities(Expression<Func<Category, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Category Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
