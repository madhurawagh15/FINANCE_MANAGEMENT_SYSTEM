using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FINANCE_MANAGEMENT_SYSTEM.Models
{
    public partial class FINANCE_MANAGEMENT_SYSTEMContext : DbContext
    {
        public FINANCE_MANAGEMENT_SYSTEMContext()
        {
        }

        public FINANCE_MANAGEMENT_SYSTEMContext(DbContextOptions<FINANCE_MANAGEMENT_SYSTEMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Emicard> Emicard { get; set; }
        public virtual DbSet<LoginA> LoginA { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<RegistrationU> RegistrationU { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=MSI\\SQLEXPRESS;Database=FINANCE_MANAGEMENT_SYSTEM;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Emicard>(entity =>
            {
                entity.HasKey(e => e.EmiCardno)
                    .HasName("PK__EMICARD__C33E78B557897C52");

                entity.ToTable("EMICARD");

                entity.Property(e => e.EmiCardno)
                    .HasColumnName("EMI_CARDNO")
                    .ValueGeneratedNever();

                entity.Property(e => e.CardType)
                    .IsRequired()
                    .HasColumnName("CARD_TYPE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreditUsed)
                    .HasColumnName("CREDIT_USED")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('UNAPPROVED')");

                entity.Property(e => e.TotalCredit)
                    .HasColumnName("TOTAL_CREDIT")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ValidTill)
                    .HasColumnName("VALID_TILL")
                    .HasColumnType("date");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Emicard)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("FK__EMICARD__USERNAM__15502E78");
            });

            modelBuilder.Entity<LoginA>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOGIN_A");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__ORDERS__460A946476381E4D");

                entity.ToTable("ORDERS");

                entity.Property(e => e.OrderId)
                    .HasColumnName("ORDER_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmiTenure).HasColumnName("EMI_TENURE");

                entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.Property(e => e.TotalCost)
                    .HasColumnName("TOTAL_COST")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__ORDERS__PRODUCT___1A14E395");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("FK__ORDERS__USERNAME__1920BF5C");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__PRODUCTS__52B41763089D5E39");

                entity.ToTable("PRODUCTS");

                entity.Property(e => e.ProductId)
                    .HasColumnName("PRODUCT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cost)
                    .HasColumnName("COST")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductDetails)
                    .IsRequired()
                    .HasColumnName("PRODUCT_DETAILS")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProductImage)
                    .IsRequired()
                    .HasColumnName("PRODUCT_IMAGE")
                    .HasColumnType("image");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnName("PRODUCT_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RegistrationU>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__REGISTRA__B15BE12FA28E3C03");

                entity.ToTable("REGISTRATION_U");

                entity.Property(e => e.Username)
                    .HasColumnName("USERNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNum)
                    .HasColumnName("ACCOUNT_NUM")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasColumnName("BANK_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .IsRequired()
                    .HasColumnName("CARD_TYPE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmPassword)
                    .IsRequired()
                    .HasColumnName("CONFIRM_PASSWORD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IfscCode)
                    .IsRequired()
                    .HasColumnName("IFSC_CODE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("PHONE_NO")
                    .HasColumnType("numeric(10, 0)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
