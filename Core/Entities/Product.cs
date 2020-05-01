using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Product : BaseEntity
    {
        //public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int ProductTypeId { get; set; }
        public int ProductBrandId { get; set; }
        public ProductType ProductType { get; set; }
        public ProductBrand ProductBrand { get; set; }

        public int Stock { get; set; }
        public int Rating { get; set; }
        public string PhotoName { get; set; }

        public DateTimeOffset DateCreated { get; set; }
    }
}