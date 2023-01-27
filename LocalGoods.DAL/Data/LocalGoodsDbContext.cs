using LocalGoods.DAL.Configurations;
using LocalGoods.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace LocalGoods.DAL.Data
{
    public class LocalGoodsDbContext : DbContext//IdentityDbContext<User>
    {
        public LocalGoodsDbContext(DbContextOptions<LocalGoodsDbContext> options)
            : base(options)
        {

        }
        //public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.ApplyConfiguration(new ProductConfiguration());
            //builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
        }
    }
}
