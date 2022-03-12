using Devita.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.Models
{
    public class Order:BaseEntity
    {
        public string AppUserId { get; set; }
        [StringLength(maximumLength:50)]
        public string FullName { get; set; }
        [StringLength(maximumLength:100)]
        public string Email { get; set; }
        [Required]
        [StringLength(maximumLength:25)]
        public string Phone { get; set; }
        [Required]
        [StringLength(maximumLength:250)]
        public string Address { get; set; }
        [Required]
        [StringLength(maximumLength:25)]
        public string Country { get; set; }
        [Required]
        [StringLength(maximumLength:25)]
        public string City { get; set; }
        [StringLength(maximumLength:250)]
        public string Note { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }
        [StringLength(maximumLength: 700)]
        public string RejectComment { get; set; }
        public DateTime CreatedAt { get; set; }
        public OrderStatus Status { get; set; }
        public OrderDeliveryStatus? DeliveryStatus { get; set; }
        public AppUser AppUser { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
