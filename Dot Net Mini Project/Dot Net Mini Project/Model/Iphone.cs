using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;

namespace Dot_Net_Mini_Project
{
    class Iphone
    {
        [Key]
        [Required()]
        public int ProductId { get; set; }

        [Required()]
        [MaxLength(10)]
        public string ProductName { get; set; }

        //[Required()]
        //public string Category { get; set; }

        [Required()]
        public int Quantity { get; set; }

        [Required()]
        public decimal Price { get; set; }

        public string Category { get; set; }

        public int UserId { get; set; }

        public User users { get; set; }

        
        //public Product products { get; set; }
    }
}
