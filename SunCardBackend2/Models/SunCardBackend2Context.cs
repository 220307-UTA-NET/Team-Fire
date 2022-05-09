using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SunCardBackend2.Models
{
    public partial class SunCardBackend2Context : DbContext
    {
        public SunCardBackend2Context()
        {
        }

        public SunCardBackend2Context(DbContextOptions<SunCardBackend2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<CardList> CardLists { get; set; } = null!;
        public virtual DbSet<CustomerList> CustomerLists { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("connectionString");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CardList>(entity =>
            {
                entity.HasKey(e => e.CardId)
                    .HasName("PK__CardList__45AA4B439D22A0B4");

                entity.ToTable("CardList", "Firecard");

                entity.Property(e => e.CardId).HasColumnName("Card_ID");

                entity.Property(e => e.CardNumber).HasColumnName("Card_Number");

                entity.Property(e => e.CurrentBalance).HasColumnType("money");

                entity.Property(e => e.InitialBalance).HasColumnType("money");

                entity.Property(e => e.PurchaseDate).HasMaxLength(10);
            });

            modelBuilder.Entity<CustomerList>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__Customer__8CB286B935965D52");

                entity.ToTable("CustomerList", "Firecard");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.Address1).HasMaxLength(255);

                entity.Property(e => e.Address2).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(150);

                entity.Property(e => e.LastName).HasMaxLength(150);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.Pword)
                    .HasMaxLength(30)
                    .HasColumnName("PWord");

                entity.Property(e => e.StateAbb).HasMaxLength(2);

                entity.Property(e => e.Zip).HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
