using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MyShopList.Models
{
    public class Items
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Category { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
    public class ItemsDBContext : DbContext
    {
        public DbSet<Items> Items { get; set; }
    }
}