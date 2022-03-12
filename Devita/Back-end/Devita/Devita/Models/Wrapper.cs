using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.Models
{
    public class Wrapper:BaseEntity
    {
        [StringLength(maximumLength:100)]
        public string Image1 { get; set; }
        [StringLength(maximumLength:100)]
        public string Image2 { get; set; }
        [NotMapped]
        public IFormFile ImageFile1 { get; set; }
        [NotMapped]
        public IFormFile ImageFile2 { get; set; }

    }
}
