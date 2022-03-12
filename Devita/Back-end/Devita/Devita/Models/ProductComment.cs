using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.Models
{
    public class ProductComment:BaseEntity
    {
        public int ProductId { get; set; }
        public string AppUserId { get; set; }
        [StringLength(maximumLength:500)]
        public string Text { get; set; }
        [StringLength(maximumLength:100)]
        public string Email { get; set; }
        [StringLength(maximumLength:50)]
        public string FullName { get; set; }
        public bool CommentStatus { get; set; }
        [Required]
        [Range(1,5)]
        public int Rate { get; set; }
        public bool Status { get; set; }
        public DateTime CreateAt { get; set; }
        public Product Product { get; set; }
        public AppUser AppUser { get; set; }


    }
}
