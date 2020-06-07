using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace newShop.Data
{
    public class LoyaltyPoints
    {
        [Key]
        public int Id { get; set; }
        public int Points { get; set; }
    }
}
