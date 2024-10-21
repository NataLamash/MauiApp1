using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class Product : Item
    {
        public DateTime ExpiryDate { get; set; }
        public int Quantity { get; set; }
        public required string UnitOfMeasure { get; set; }
    }
}
