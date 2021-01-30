using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace usingWebAPI.Models
{
    public partial class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }
        public string ImageUrl { get; set; }
        public double Discount { get; set; }
        public string ProductInfo { get; set; }
        public int StockCount { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModified { get; set; }
        public int OrderNumber { get; set; }
        public int CategoryId { get; set; }

        public virtual Categories Category { get; set; }
    }
}
