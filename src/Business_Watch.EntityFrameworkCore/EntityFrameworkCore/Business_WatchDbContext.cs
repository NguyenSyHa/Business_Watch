using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Business_Watch.Authorization.Roles;
using Business_Watch.Authorization.Users;
using Business_Watch.MultiTenancy;
using Business_Watch.Entities;

namespace Business_Watch.EntityFrameworkCore
{
    public class Business_WatchDbContext : AbpZeroDbContext<Tenant, Role, User, Business_WatchDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Bank> Banks { get; set; }

        public DbSet<Code_Discount> Code_Discounts { get; set; }

        public DbSet<CodeUser> CodeUsers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_Detail> Order_Details { get; set; }
        public DbSet<ReviewShipper> ReviewShippers { get; set; }
        public DbSet<ReviewWatch> ReviewWatchs { get; set; }
        public DbSet<ReviewTradeMark> ReviewTradeMarks { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<TradeMark_Watch> TradeMark_Watches { get; set; }
        public DbSet<Watch> Watches { get; set; }
        
        public Business_WatchDbContext(DbContextOptions<Business_WatchDbContext> options)
            : base(options)
        {
        }
    }
}
