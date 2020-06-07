using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newShop.Data
{
    public class Discounts
    {
        public int Id {get ; set;}
        public int ProductId { get; set; }
        public int NewPrice { get; set; }
    }
}
