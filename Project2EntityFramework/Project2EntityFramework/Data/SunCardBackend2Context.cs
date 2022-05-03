using Microsoft.EntityFrameworkCore;

namespace Project2EntityFramework.Models
{
    public class SunCardBackend2Context : DbContext
    {
        public SunCardBackend2Context()
        {
        }

        public SunCardBackend2Context(DbContextOptions<SunCardBackend2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Card> CardLists { get; set; } = null!;
        public virtual DbSet<Customer> CustomerLists { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("ConnectionString");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>(entity =>
            {
                entity.HasKey(e => e.cardId)
                    .HasName("PK__CardList__45AA4B439D22A0B4");

                entity.ToTable("CardList", "Firecard");

                entity.Property(e => e.cardId).HasColumnName("Card_ID");

                entity.Property(e => e.cardNumber).HasColumnName("Card_Number");

                entity.Property(e => e.cardCurrentBalance).HasColumnType("money");

                entity.Property(e => e.cardInitialBalance).HasColumnType("money");

                entity.Property(e => e.cardPurchaseDate).HasMaxLength(10);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.customerId)
                    .HasName("PK__Customer__8CB286B935965D52");

                entity.ToTable("CustomerList", "Firecard");

                entity.Property(e => e.customerId).HasColumnName("Customer_ID");

                entity.Property(e => e.customerAddress1).HasMaxLength(255);

                entity.Property(e => e.customerAddress2).HasMaxLength(255);

                entity.Property(e => e.customerCity).HasMaxLength(255);

                entity.Property(e => e.customerEmail).HasMaxLength(100);

                entity.Property(e => e.customerFirstName).HasMaxLength(150);

                entity.Property(e => e.customerLastName).HasMaxLength(150);

                entity.Property(e => e.customerPhone).HasMaxLength(20);

                entity.Property(e => e.customerPWord)
                    .HasMaxLength(30)
                    .HasColumnName("PWord");

                entity.Property(e => e.customerStateAbb).HasMaxLength(2);

                entity.Property(e => e.customerZip).HasMaxLength(10);
            });

        }

    }

}
