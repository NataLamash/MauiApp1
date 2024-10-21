using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class Item
    {
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public required string Country { get; set; }
        public DateTime PackagingDate { get; set; }
        public required string Description { get; set; }
    }
}
