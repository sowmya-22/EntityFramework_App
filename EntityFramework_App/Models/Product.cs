using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework_App.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
        public DateTime ManufacturedDate { get; set; }
    }
}
