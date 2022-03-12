using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.Models
{
    public class HomeStatic:BaseEntity
    {
        [Required]
        [StringLength(maximumLength:60)]
        public string Title { get; set; }
        [StringLength(maximumLength:100)]
        public string BgImage { get; set; }
        [Required]
        [StringLength(maximumLength:150)]
        public string Desc { get; set; }
        [Required]
        [Column(TypeName="decimal(18,2)")]
        public decimal Price { get; set; }
        [Required]
        [StringLength(maximumLength:20)]
        public string ButtonText { get; set; }
        [Required]
        [StringLength(maximumLength:400)]
        public string ButtonUrl { get; set; }
        [NotMapped]
        public IFormFile BgImageFile { get; set; }

    }
}
