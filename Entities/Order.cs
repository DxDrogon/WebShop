﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebShop.Entities
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        [JsonIgnore]
        public virtual Customer Customer { get; set; }
        [JsonIgnore]
        public virtual List<Product> Products { get; set; } = new List<Product>();
    }
}
