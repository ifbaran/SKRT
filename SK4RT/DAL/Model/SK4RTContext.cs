using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Model
{
    public partial class SK4RTContext : DbContext
    {
        public SK4RTContext()
        {
        }

        public SK4RTContext(DbContextOptions<SK4RTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chairs> Chairs { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Films> Films { get; set; }
        public virtual DbSet<Saloons> Saloons { get; set; }
        public virtual DbSet<Sessions> Sessions { get; set; }
        public virtual DbSet<Theaters> Theaters { get; set; }
        public virtual DbSet<Tickets> Tickets { get; set; }
        public virtual DbSet<Workers> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=SK4RT;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chairs>(entity =>
            {
                entity.HasKey(e => e.ChairId)
                    .HasName("PK_Chair");

                entity.Property(e => e.ChairName).HasMaxLength(10);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK_Customer");

                entity.Property(e => e.CustomerEmail).HasMaxLength(100);

                entity.Property(e => e.CustomerLastName).HasMaxLength(50);

                entity.Property(e => e.CustomerName).HasMaxLength(50);
            });

            modelBuilder.Entity<Films>(entity =>
            {
                entity.HasKey(e => e.FilmId)
                    .HasName("PK_Film");

                entity.Property(e => e.FilmAuthor).HasMaxLength(100);

                entity.Property(e => e.FilmName).HasMaxLength(50);
            });

            modelBuilder.Entity<Saloons>(entity =>
            {
                entity.HasKey(e => e.SaloonId)
                    .HasName("PK_Saloon");

                entity.Property(e => e.SaloonName).HasMaxLength(10);
            });

            modelBuilder.Entity<Sessions>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PK_Session");

                entity.Property(e => e.TranDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<Theaters>(entity =>
            {
                entity.HasKey(e => e.TheaterId)
                    .HasName("PK_Theater");

                entity.Property(e => e.TheaterAuthor).HasMaxLength(100);

                entity.Property(e => e.TheaterName).HasMaxLength(50);
            });

            modelBuilder.Entity<Tickets>(entity =>
            {
                entity.HasKey(e => e.TicketId)
                    .HasName("PK_Ticket");

                entity.Property(e => e.TicketDate).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Ticket_Customer");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.FilmId)
                    .HasConstraintName("FK_Ticket_Film");

                entity.HasOne(d => d.Saloon)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.SaloonId)
                    .HasConstraintName("FK_Ticket_Saloon");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.SessionId)
                    .HasConstraintName("FK_Ticket_Session");

                entity.HasOne(d => d.Theater)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.TheaterId)
                    .HasConstraintName("FK_Ticket_Theater");

                entity.HasOne(d => d.Worker)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.WorkerId)
                    .HasConstraintName("FK_Ticket_Worker");
            });

            modelBuilder.Entity<Workers>(entity =>
            {
                entity.HasKey(e => e.WorkerId)
                    .HasName("PK_Worker");

                entity.Property(e => e.WorkerEmail).HasMaxLength(100);

                entity.Property(e => e.WorkerLastName).HasMaxLength(50);

                entity.Property(e => e.WorkerName).HasMaxLength(50);

                entity.Property(e => e.WorkerPassword).HasMaxLength(20);

                entity.Property(e => e.WorkerSalary).HasColumnType("money");

                entity.Property(e => e.WorkerUsername).HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
