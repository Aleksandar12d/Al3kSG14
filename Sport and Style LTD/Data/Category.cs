﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sport_and_Style_LTD.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public  ICollection<Product> Products { get; set; }
    }
}