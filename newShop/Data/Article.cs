﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace newShop.Data
{
    public class Article
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
    }
}
