using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.Models
{
    public class Product:BaseEntity
    {
        public int CategoryId { get; set; }
        [Required]
        [StringLength(maximumLength:40)]
        public string Name { get; set; }
        [StringLength(maximumLength:200)]
        public string Description { get; set; }
        [Column(TypeName ="decimal(18,2)")]
        public decimal CostPrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal SalePrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [Range(0,100)]
        public decimal  DiscountPercent { get; set; }
        public bool StockStatus { get; set; }
        public bool IsNew { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsTopRate { get; set; }
        public bool IsTopHeadphone { get; set; }
        public bool IsBest { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<ProductColor> ProductColor { get; set; }
        [NotMapped]
        public IFormFile PosterFile { get; set; }
        [NotMapped]
        public IFormFile HoverPosterFile { get; set; }
        [NotMapped]
        public List<IFormFile> ImageFiles { get; set; }
        public Category Category { get; set; }
        [NotMapped]
        public List<int> ProductImage { get; set; }
        public List<ProductComment> ProductComments { get; set; }







    }
}
