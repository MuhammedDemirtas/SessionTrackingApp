using Microsoft.EntityFrameworkCore;
using GörselProgramlama2.Models;

namespace GörselProgramlama2
{
    public partial class DBContext : DbContext
    {
        public virtual DbSet<FILM> Movies { get; set; }
        public virtual DbSet<LOUNGE> MovieTheaters { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = " + Program.pathDB);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FILM>(entity =>
            {
                entity.ToTable("Movie");
                entity.HasKey(e => e.id);
                entity.Property(e => e.movieName).HasColumnType("TEXT");
                entity.Property(e => e.timeOne).HasColumnType("TIMESPAN");
                entity.Property(e => e.timeTwo).HasColumnType("TIMESPAN");
                entity.Property(e => e.timeThree).HasColumnType("TIMESPAN");
            });

            modelBuilder.Entity<LOUNGE>(entity =>
            {
                entity.ToTable("MovieTheater");
                entity.HasKey(e => e.id);
                entity.Property(e => e.movieTheaterName).HasColumnType("TEXT");
                entity.Property(e => e.movieTheaterCapacity).HasColumnType("INTEGER");
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.ToTable("Session");
                entity.HasKey(e => e.id);
                entity.Property(e => e.movieName).HasColumnType("TEXT");
                entity.Property(e => e.movieTheaterName).HasColumnType("TEXT");
                entity.Property(e => e.movieDate).HasColumnType("DATETIME");
                entity.Property(e => e.movieTime).HasColumnType("TIMESPAN");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");
                entity.HasKey(e => e.id);
                entity.Property(e => e.sessionID).HasColumnType("INTEGER");
                entity.Property(e => e.customerName).HasColumnType("TEXT");
                entity.Property(e => e.customerSurname).HasColumnType("TEXT");
                entity.Property(e => e.cardNumber).HasColumnType("TEXT");
                entity.Property(e => e.validityMonth).HasColumnType("INTEGER");
                entity.Property(e => e.validityYear).HasColumnType("INTEGER");
                entity.Property(e => e.securityCode).HasColumnType("INTEGER");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
