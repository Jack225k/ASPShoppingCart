﻿
using System.Collections.Generic;



namespace OnlineShopping.Models
{
    public partial class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}