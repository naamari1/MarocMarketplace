using Maroc.Core.Entities;
using Maroc.Core.Enums;
using Microsoft.EntityFrameworkCore;

namespace Maroc.Infastructure.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Payment> Payments { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Seeder.SeedData(modelBuilder);

            modelBuilder.Entity<Order>()
                .Property(e => e.Status)
                .HasConversion(
                v => v.ToString(),
                    v => (OrderStatus)Enum.Parse(typeof(OrderStatus), v));


            modelBuilder.Entity<Payment>()
                .Property(e => e.PaymentMethod)
                .HasConversion(
                               v => v.ToString(),
                                    v => (PaymentMethod)Enum.Parse(typeof(PaymentMethod), v));
        }
    }
}
