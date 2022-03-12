using Devita.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.ViewModels
{
    public class HomeViewModel
    {
        public List<Product> NewProducts { get; set; }
        public List<Product> FeaturedProducts { get; set; }
        public List<Product> BestProducts { get; set; }
        public List<Product> TopHeadphonesProduct { get; set; }
        public List<Product> TopRates { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Wrapper> Wrappers { get; set; }
        public List<HomeStatic> HomeStatics { get; set; }
    }
}
