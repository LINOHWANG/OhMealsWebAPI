using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OhMealsWebAPI.Models
{
    public partial class dbOOContext : DbContext
    {
        public dbOOContext()
        {
        }

        public dbOOContext(DbContextOptions<dbOOContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<MainSite> MainSite { get; set; }
        public virtual DbSet<Ooitem> Ooitem { get; set; }
        public virtual DbSet<Ootransaction> Ootransaction { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }
        public virtual DbSet<Site> Site { get; set; }
        public virtual DbSet<Tax> Tax { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=192.168.1.200;Database=dbOO;User ID=tseadmin;Password=tsent2011;Integrated Security=False;Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasIndex(e => e.Phone)
                    .HasName("IX_Phone");

                entity.Property(e => e.Address1).HasMaxLength(30);

                entity.Property(e => e.Address2).HasMaxLength(20);

                entity.Property(e => e.DateMarried).HasMaxLength(10);

                entity.Property(e => e.DateOfBirth).HasMaxLength(10);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(20);

                entity.Property(e => e.LastName).HasMaxLength(20);

                entity.Property(e => e.Memo).HasMaxLength(300);

                entity.Property(e => e.Phone).HasMaxLength(15);

                entity.Property(e => e.SiteCode).HasMaxLength(5);

                entity.Property(e => e.Zip).HasMaxLength(6);
            });

            modelBuilder.Entity<MainSite>(entity =>
            {
                entity.HasKey(e => e.MainSiteCode);

                entity.Property(e => e.MainSiteCode).HasMaxLength(5);

                entity.Property(e => e.MainSiteAddress).HasMaxLength(255);

                entity.Property(e => e.MainSiteCreatedDttm)
                    .HasColumnName("MainSiteCreatedDTTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.MainSiteGstnumber)
                    .HasColumnName("MainSiteGSTNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.MainSiteName).HasMaxLength(100);

                entity.Property(e => e.MainSitePhoneNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<Ooitem>(entity =>
            {
                entity.ToTable("OOItem");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("IX_TransactionId");

                entity.Property(e => e.ProductName).HasMaxLength(30);

                entity.Property(e => e.PromoEndDate).HasMaxLength(10);

                entity.Property(e => e.PromoStartDate).HasMaxLength(10);

                entity.Property(e => e.SecondName).HasMaxLength(30);

                entity.Property(e => e.SiteCode).HasMaxLength(5);

                entity.Property(e => e.TransactionId).HasMaxLength(15);
            });

            modelBuilder.Entity<Ootransaction>(entity =>
            {
                entity.ToTable("OOTransaction");

                entity.HasIndex(e => e.Phone)
                    .HasName("IX_Phone");

                entity.HasIndex(e => e.TransactionId)
                    .HasName("IX_TransactionId");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Buzzer).HasMaxLength(20);

                entity.Property(e => e.CustomerName).HasMaxLength(20);

                entity.Property(e => e.IsPaid).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPosupdated)
                    .HasColumnName("IsPOSUpdated")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Memo).HasMaxLength(300);

                entity.Property(e => e.OrderDate).HasMaxLength(10);

                entity.Property(e => e.OrderTime).HasMaxLength(8);

                entity.Property(e => e.PayType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Phone).HasMaxLength(15);

                entity.Property(e => e.PickUpDate).HasMaxLength(10);

                entity.Property(e => e.PickUpTime).HasMaxLength(8);

                entity.Property(e => e.SiteCode).HasMaxLength(5);

                entity.Property(e => e.TotalPaid).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionId).HasMaxLength(15);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ProductName).HasMaxLength(30);

                entity.Property(e => e.PromoEndDate).HasMaxLength(10);

                entity.Property(e => e.PromoStartDate).HasMaxLength(10);

                entity.Property(e => e.SecondName).HasMaxLength(30);

                entity.Property(e => e.SiteCode).HasMaxLength(5);

                entity.Property(e => e.SpiceLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.SyncDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductType>(entity =>
            {
                entity.HasKey(e => e.PosTypeId);

                entity.Property(e => e.PosTypeId).ValueGeneratedNever();

                entity.Property(e => e.SiteCode).HasMaxLength(5);

                entity.Property(e => e.TypeName).HasMaxLength(20);
            });

            modelBuilder.Entity<Site>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.MainSiteCode).HasMaxLength(5);

                entity.Property(e => e.SiteAddress).HasMaxLength(255);

                entity.Property(e => e.SiteBizBreakFinish)
                    .HasColumnName("Site_Biz_Break_Finish")
                    .HasMaxLength(10);

                entity.Property(e => e.SiteBizBreakStart)
                    .HasColumnName("Site_Biz_Break_Start")
                    .HasMaxLength(10);

                entity.Property(e => e.SiteBizHourFinish)
                    .HasColumnName("Site_Biz_Hour_Finish")
                    .HasMaxLength(10);

                entity.Property(e => e.SiteBizHourLastCallHour)
                    .HasColumnName("Site_Biz_Hour_LastCall_Hour")
                    .HasMaxLength(10);

                entity.Property(e => e.SiteBizHourStart)
                    .HasColumnName("Site_Biz_Hour_Start")
                    .HasMaxLength(10);

                entity.Property(e => e.SiteCode)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.SiteCreatedDttm)
                    .HasColumnName("SiteCreatedDTTM")
                    .HasColumnType("datetime");

                entity.Property(e => e.SiteGstnumber)
                    .HasColumnName("SiteGSTNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.SiteName).HasMaxLength(100);

                entity.Property(e => e.SitePhoneNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<Tax>(entity =>
            {
                entity.HasKey(e => e.PosCode);

                entity.Property(e => e.PosCode).HasMaxLength(10);

                entity.Property(e => e.SiteCode).HasMaxLength(5);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
