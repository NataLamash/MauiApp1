using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class Book : Item
    {
        public int PagesCount { get; set; }
        public required string Publisher { get; set; }
        public required List<string> Authors { get; set; }
    }
}
