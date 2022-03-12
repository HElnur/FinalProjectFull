using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.Models
{
    public class ProductImage:BaseEntity
    {
        public int ProductId { get; set; }
        public string Image { get; set; }
        public bool? PosterStatus { get; set; }

        public Product Product { get; set; }

    }
}
