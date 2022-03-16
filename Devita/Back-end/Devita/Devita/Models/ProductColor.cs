﻿using Devita.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.Models
{
    public class ProductColor:BaseEntity
    {
        public int ProductId { get; set; }
        //public int ColorId { get; set; }
        public Product Product { get; set; }
        public ColorProduct Color { get; set; }
        //public Color Color { get; set; }

    }
}
