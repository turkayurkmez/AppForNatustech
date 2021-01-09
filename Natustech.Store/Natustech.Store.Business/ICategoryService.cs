using Natustech.Store.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Natustech.Store.Business
{
   public interface ICategoryService 
    {
        public IList<Category> GetCategories();
    }
}
