using Devita.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.ViewModels
{
    public class CheckOutViewModel
    {
        public AppUser Users { get; set; }
        public List<CheckOutItemViewModel> CheckoutItems { get; set; }
        public Order Order { get; set; }
    }
}
