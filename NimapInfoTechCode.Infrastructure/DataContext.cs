using Microsoft.EntityFrameworkCore;
using NimapInfoTechCode.Core.Entities;
using System;

namespace NimapInfoTechCode.Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DataContext> options)
           : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           //optionsBuilder.UseSqlServer("Server=MAYUR-PC\\SQLEXPRESS;Database=NewDBTest;Integrated Security=SSPI; Trusted_Connection=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductMaster>(entity =>
            {
                entity.ToTable("ProductMaster");
                entity.Property(e => e.Name)
                  .HasColumnName("Name")
                  .HasMaxLength(1000)
                  .IsUnicode(false)
                  .IsRequired(true);
            });

            modelBuilder.Entity<CategoryMaster>(entity =>
            {
                entity.ToTable("CategoryMaster");
                entity.Property(e => e.Name)
                  .HasColumnName("Name")
                  .HasMaxLength(100)
                  .IsUnicode(false)
                  .IsRequired(true);

                entity.Property(e => e.IsActive)
                  .HasColumnName("IsActive")
                  .HasDefaultValueSql("((1))");
            });
        }
        public DbSet<ProductMaster> ProductMaster { get; set; }
        public DbSet<CategoryMaster> CategoryMaster { get; set; }
    }
}
