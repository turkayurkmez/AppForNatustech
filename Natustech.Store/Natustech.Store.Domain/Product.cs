using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Natustech.Store.Domain
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        [MaxLength(150)]
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
        public Category Category { get; set; }

    }
}
