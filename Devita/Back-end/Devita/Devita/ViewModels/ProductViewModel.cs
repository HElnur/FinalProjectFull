using Devita.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.ViewModels
{
    public class ProductViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public Pagenated<Product> PagenatedProducts { get; set; }

    }
}
