using System;
using System.Collections.Generic;
using System.Text;

namespace Natustech.Store.Domain
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
