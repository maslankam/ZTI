using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newShop.Data
{
    public class Cart
    {
        public List<Product> Products{ get; set; }
        public int Price => Products.Sum(p => p.Price);

        public Cart()
        {
            Products = new List<Product>();
        }


    }
}
