using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntrodotnetCore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public float Rating { get; set; }
        public string PictureUrl { get; set; }

    }
}
