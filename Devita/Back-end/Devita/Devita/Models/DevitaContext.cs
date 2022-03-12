using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devita.Models
{
    public class DevitaContext : IdentityDbContext
    {
        public DevitaContext(DbContextOptions<DevitaContext> options) : base(options)
        {

        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ProductColor> ProductColor { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Wrapper> Wrappers { get; set; }

    }
}
