using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.Models
{
    public class Category:BaseEntity
    {
        [Required]
        [StringLength(maximumLength:25)]
        public string Name { get; set; }
        public List<Product> Products { get; set; }

    }
}
