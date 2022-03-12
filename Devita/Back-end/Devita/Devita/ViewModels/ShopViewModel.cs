using Devita.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.ViewModels
{
    public class ShopViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<Color> Colors { get; set; }
        public Pagenated<Product> PagenetedProduct { get; set; }
    }
}
