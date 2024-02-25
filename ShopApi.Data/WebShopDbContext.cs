﻿using Microsoft.EntityFrameworkCore;
using ShopApi.Model.Models;

namespace ShopApi.Data
{
    public sealed class WebShopDbContext : DbContext
    {
        public WebShopDbContext(DbContextOptions options) : base(options) 
        {
        }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuGroup> MenuGroups { get; set; }
        public DbSet<Order> Users { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategorys { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategorys { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<SupportOnline> SupportOnlines { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<VisitorStatistic> VisitorStatistics { get; set; }

        // chuỗi kết nối với tên db sẽ làm  việc đặt là webdb
        public const string ConnectString = @"Data Source=QUANGSON\QUANGSON;Initial Catalog=WebExample;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>()
                  .HasKey(m => new { m.OrderID, m.ProductID });
            modelBuilder.Entity<PostTag>()
                  .HasKey(m => new { m.PostID, m.TagID });
            modelBuilder.Entity<ProductTag>()
                 .HasKey(m => new { m.ProductID, m.TagID });

   
        }
    }
}
