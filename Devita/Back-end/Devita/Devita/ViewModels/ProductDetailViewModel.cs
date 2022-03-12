using Devita.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.ViewModels
{
    public class ProductDetailViewModel
    {
        public Product Product { get; set; }
        public List<Product> RelatedProduct { get; set; }
        public ProductComment Comment { get; set; }

    }
}
