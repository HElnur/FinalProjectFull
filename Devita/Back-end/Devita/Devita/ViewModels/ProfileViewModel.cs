using Devita.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.ViewModels
{
    public class ProfileViewModel
    {
        public MemberUpdateViewModel Member { get; set; }
        public List<Order> Orders { get; set; }


    }
}
