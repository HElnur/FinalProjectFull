using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.Models
{
    public class Slider:BaseEntity
    {
        [StringLength(maximumLength:300)] 
        public string Text { get; set; }
        [StringLength(maximumLength: 100)]
        public string Image { get; set; }
        [StringLength(maximumLength:100)]
        public string BgImage { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [NotMapped]
        public IFormFile BgImageFile { get; set; }

    }
}
