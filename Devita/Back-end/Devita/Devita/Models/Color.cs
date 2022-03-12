using Devita.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.Models
{
    public class Color:BaseEntity
    {
        public ColorProduct Name { get; set; }
        public ProductColor ProductColor { get; set; }

    }
}
