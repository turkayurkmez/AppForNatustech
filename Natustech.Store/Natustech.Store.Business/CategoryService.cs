using Natustech.Store.DataAccess;
using Natustech.Store.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Natustech.Store.Business
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IList<Category> GetCategories()
        {
            return categoryRepository.GetAllEntities();
        }
    }
}
