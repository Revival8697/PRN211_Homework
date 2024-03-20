using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Service.Models;

public partial class ConvenienceStoreContext : DbContext
{
    public ConvenienceStoreContext()
    {
    }

    public ConvenienceStoreContext(DbContextOptions<ConvenienceStoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Bill> Bills { get; set; }

    public virtual DbSet<BillDetail> BillDetails { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<ExportBill> ExportBills { get; set; }

    public virtual DbSet<ImportBill> ImportBills { get; set; }

    public virtual DbSet<Merchandise> Merchandises { get; set; }

    public virtual DbSet<Provider> Providers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder()
                          .SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        IConfigurationRoot configuration = builder.Build();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("ConvenienceStore"));
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.AccId).HasName("PK__Account__A471AFDAE2955E2C");

            entity.ToTable("Account");

            entity.Property(e => e.AccId).HasColumnName("accId");
            entity.Property(e => e.AccAddress)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("accAddress");
            entity.Property(e => e.AccCreatedTime)
                .HasColumnType("datetime")
                .HasColumnName("accCreatedTime");
            entity.Property(e => e.AccDob).HasColumnName("accDOB");
            entity.Property(e => e.AccName)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("accName");
            entity.Property(e => e.AccPass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("accPass");
            entity.Property(e => e.AccPhone)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("accPhone");
            entity.Property(e => e.AccRole).HasColumnName("accRole");
        });

        modelBuilder.Entity<Bill>(entity =>
        {
            entity.HasKey(e => e.BillId).HasName("PK__Bill__6D903F03C9C5CF7E");

            entity.ToTable("Bill");

            entity.Property(e => e.BillId).HasColumnName("billId");
            entity.Property(e => e.AccId).HasColumnName("accId");
            entity.Property(e => e.BillCreatedTime)
                .HasColumnType("datetime")
                .HasColumnName("billCreatedTime");
            entity.Property(e => e.MerId).HasColumnName("merId");

            entity.HasOne(d => d.Acc).WithMany(p => p.Bills)
                .HasForeignKey(d => d.AccId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Bill__accId__49C3F6B7");

            entity.HasOne(d => d.Mer).WithMany(p => p.Bills)
                .HasForeignKey(d => d.MerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Bill__merId__4AB81AF0");
        });

        modelBuilder.Entity<BillDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BillDetail");

            entity.Property(e => e.BillDetailId)
                .ValueGeneratedOnAdd()
                .HasColumnName("billDetailId");
            entity.Property(e => e.BillId).HasColumnName("billId");
            entity.Property(e => e.BillMerPrice).HasColumnName("billMerPrice");
            entity.Property(e => e.BillMerQuanity).HasColumnName("billMerQuanity");
            entity.Property(e => e.MerId).HasColumnName("merId");

            entity.HasOne(d => d.Bill).WithMany()
                .HasForeignKey(d => d.BillId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BillDetai__billI__4CA06362");

            entity.HasOne(d => d.Mer).WithMany()
                .HasForeignKey(d => d.MerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BillDetai__merId__4D94879B");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.IdCategory).HasName("PK__Category__79D361B6F5AD1435");

            entity.ToTable("Category");

            entity.Property(e => e.IdCategory).HasColumnName("idCategory");
            entity.Property(e => e.NameCateGory)
                .HasMaxLength(100)
                .HasColumnName("nameCateGory");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CusId).HasName("PK__Customer__BA9897F3A7A4F54A");

            entity.ToTable("Customer");

            entity.Property(e => e.CusId).HasColumnName("cusId");
            entity.Property(e => e.CusDob).HasColumnName("cusDOB");
            entity.Property(e => e.CusGender).HasColumnName("cusGender");
            entity.Property(e => e.CusName)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("cusName");
            entity.Property(e => e.CusPhone)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("cusPhone");
        });

        modelBuilder.Entity<ExportBill>(entity =>
        {
            entity.HasKey(e => e.ExId).HasName("PK__ExportBi__38F47E58B71D18E3");

            entity.ToTable("ExportBill");

            entity.Property(e => e.ExId).HasColumnName("exId");
            entity.Property(e => e.AccId).HasColumnName("accId");
            entity.Property(e => e.CusId).HasColumnName("cusId");
            entity.Property(e => e.ExDate)
                .HasColumnType("datetime")
                .HasColumnName("exDate");
            entity.Property(e => e.ExManager)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("exManager");

            entity.HasOne(d => d.Acc).WithMany(p => p.ExportBills)
                .HasForeignKey(d => d.AccId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ExportBil__accId__4222D4EF");

            entity.HasOne(d => d.Cus).WithMany(p => p.ExportBills)
                .HasForeignKey(d => d.CusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ExportBil__cusId__4316F928");
        });

        modelBuilder.Entity<ImportBill>(entity =>
        {
            entity.HasKey(e => e.ImId).HasName("PK__ImportBi__9BF4082FAA002512");

            entity.ToTable("ImportBill");

            entity.Property(e => e.ImId).HasColumnName("imId");
            entity.Property(e => e.ImDate)
                .HasColumnType("datetime")
                .HasColumnName("imDate");
            entity.Property(e => e.ImName)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("imName");
            entity.Property(e => e.ImProvider)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("imProvider");
            entity.Property(e => e.MerId).HasColumnName("merId");
            entity.Property(e => e.ProId).HasColumnName("proId");

            entity.HasOne(d => d.Mer).WithMany(p => p.ImportBills)
                .HasForeignKey(d => d.MerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ImportBil__merId__45F365D3");

            entity.HasOne(d => d.Pro).WithMany(p => p.ImportBills)
                .HasForeignKey(d => d.ProId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ImportBil__proId__46E78A0C");
        });

        modelBuilder.Entity<Merchandise>(entity =>
        {
            entity.HasKey(e => e.MerId).HasName("PK__Merchand__31EEDA21C76795D7");

            entity.ToTable("Merchandise");

            entity.Property(e => e.MerId).HasColumnName("merId");
            entity.Property(e => e.MerDescription)
                .HasMaxLength(2000)
                .HasColumnName("merDescription");
            entity.Property(e => e.MerIdCategory).HasColumnName("merIdCategory");
            entity.Property(e => e.MerName)
                .HasMaxLength(100)
                .HasColumnName("merName");
            entity.Property(e => e.MerPrice).HasColumnName("merPrice");
            entity.Property(e => e.MerQuantity).HasColumnName("merQuantity");
            entity.Property(e => e.MerUnit)
                .HasMaxLength(50)
                .HasColumnName("merUnit");

            entity.HasOne(d => d.MerIdCategoryNavigation).WithMany(p => p.Merchandises)
                .HasForeignKey(d => d.MerIdCategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Merchandi__merId__3D5E1FD2");
        });

        modelBuilder.Entity<Provider>(entity =>
        {
            entity.HasKey(e => e.ProId).HasName("PK__Provider__5BBBEEF59A2CC8E5");

            entity.ToTable("Provider");

            entity.Property(e => e.ProId).HasColumnName("proId");
            entity.Property(e => e.ProDob).HasColumnName("proDOB");
            entity.Property(e => e.ProGender).HasColumnName("proGender");
            entity.Property(e => e.ProName)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("proName");
            entity.Property(e => e.ProPhone)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("proPhone");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
