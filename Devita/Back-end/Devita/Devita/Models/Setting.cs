using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.Models
{
    public class Setting:BaseEntity
    {
        [Required]
        [StringLength(maximumLength:30)]
        public string Key { get; set; }
        [StringLength(maximumLength:100)]
        public string Value { get; set; }

    }
}
