using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SportClubDbManager.Data;
using SportClubDbManager.Data.Views;

#nullable disable

namespace SportClubDbManager.Infrastructure
{
    public partial class SportClubDBContext : DbContext
    {
        public SportClubDBContext()
        {
        }

        public SportClubDBContext(DbContextOptions<SportClubDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<OpponentSport> OpponentSports { get; set; }
        public virtual DbSet<PairedSportError> PairedSportErrors { get; set; }
        public virtual DbSet<PreviousTrainer> PreviousTrainers { get; set; }
        public virtual DbSet<Sport> Sports { get; set; }
        public virtual DbSet<Sportsman> Sportsmen { get; set; }
        public virtual DbSet<SportsmenMove> SportsmenMoves { get; set; }
        public virtual DbSet<SportsmenWithoutMove> SportsmenWithoutMoves { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<OpponentSameSport> OpponentSameSports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=SportClubDB;Username=postgres;Password=282grjwkb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Russian_Russia.1251");

            modelBuilder.Entity<OpponentSport>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("pk_op_sports");

                entity.ToTable("opponent_sports");

                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .HasColumnName("name");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(14)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<PairedSportError>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("paired_sport_errors");


                entity.Property(e => e.CertNum)
                    .HasPrecision(6)
                    .HasColumnName("cert_num");

                entity.Property(e => e.Fio)
                    .HasMaxLength(40)
                    .HasColumnName("fio");

            });

            modelBuilder.Entity<OpponentSameSport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("opponent_same_sports");


                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .HasColumnName("name");

                entity.Property(e => e.Type)
                     .HasMaxLength(14)
                     .HasColumnName("type");

            });

            modelBuilder.Entity<PreviousTrainer>(entity =>
            {
                entity.HasKey(e => new { e.Trainer, e.Sportsman })
                    .HasName("pk_previous_trainers");

                entity.ToTable("previous_trainers");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.Sportsman)
                    .HasPrecision(6)
                    .HasColumnName("sportsman");

                entity.Property(e => e.Trainer)
                    .HasPrecision(3)
                    .HasColumnName("trainer");

                entity.HasOne(d => d.SportsmanNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Sportsman)
                    .HasConstraintName("ref_sportsmen");

                entity.HasOne(d => d.TrainerNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Trainer)
                    .HasConstraintName("ref_trainers");
            });

            modelBuilder.Entity<Sport>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("pk_sports");

                entity.ToTable("sports");

                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .HasColumnName("name");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(14)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Sportsman>(entity =>
            {
                entity.HasKey(e => e.CertNum)
                    .HasName("pk_sportsmen");

                entity.ToTable("sportsmen");

                entity.Property(e => e.CertNum)
                    .HasPrecision(6)
                    .HasColumnName("cert_num");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("address");

                entity.Property(e => e.BirthDate)
                    .HasColumnType("date")
                    .HasColumnName("birth_date");

                entity.Property(e => e.Fio)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("fio");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(11)
                    .HasColumnName("home_phone")
                    .IsFixedLength(true);

                entity.Property(e => e.Level)
                    .HasMaxLength(7)
                    .HasColumnName("level");

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(11)
                    .HasColumnName("mobile_phone")
                    .IsFixedLength(true);

                entity.Property(e => e.Partner)
                    .HasPrecision(6)
                    .HasColumnName("partner");

                entity.Property(e => e.Rating)
                    .HasPrecision(4)
                    .HasColumnName("rating");

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .HasColumnName("sex");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.Trainer)
                    .HasPrecision(3)
                    .HasColumnName("trainer");

                entity.HasOne(d => d.PartnerNavigation)
                    .WithMany(p => p.InversePartnerNavigation)
                    .HasForeignKey(d => d.Partner)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("ref_sportsmen");

                entity.HasOne(d => d.TrainerNavigation)
                    .WithMany(p => p.Sportsmen)
                    .HasForeignKey(d => d.Trainer)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("ref_trainers");
            });

            modelBuilder.Entity<SportsmenMove>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sportsmen_moves");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.SportName)
                    .HasMaxLength(40)
                    .HasColumnName("sport_name");

                entity.Property(e => e.SportsmanName)
                    .HasMaxLength(40)
                    .HasColumnName("sportsman_name");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.TrainerName)
                    .HasMaxLength(40)
                    .HasColumnName("trainer_name");
            });

            modelBuilder.Entity<SportsmenWithoutMove>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sportsmen_without_moves");

                entity.Property(e => e.Address)
                    .HasMaxLength(40)
                    .HasColumnName("address");

                entity.Property(e => e.BirthDate)
                    .HasColumnType("date")
                    .HasColumnName("birth_date");

                entity.Property(e => e.CertNum)
                    .HasPrecision(6)
                    .HasColumnName("cert_num");

                entity.Property(e => e.Fio)
                    .HasMaxLength(40)
                    .HasColumnName("fio");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(11)
                    .HasColumnName("home_phone")
                    .IsFixedLength(true);

                entity.Property(e => e.Level)
                    .HasMaxLength(7)
                    .HasColumnName("level");

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(11)
                    .HasColumnName("mobile_phone")
                    .IsFixedLength(true);

                entity.Property(e => e.Partner)
                    .HasPrecision(6)
                    .HasColumnName("partner");

                entity.Property(e => e.Rating)
                    .HasPrecision(4)
                    .HasColumnName("rating");

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .HasColumnName("sex");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.Trainer)
                    .HasPrecision(3)
                    .HasColumnName("trainer");
            });

            modelBuilder.Entity<Trainer>(entity =>
            {
                entity.ToTable("trainers");

                entity.Property(e => e.Id)
                    .HasPrecision(3)
                    .HasColumnName("id");

                entity.Property(e => e.Fio)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("fio");

                entity.Property(e => e.Level)
                    .HasMaxLength(7)
                    .HasColumnName("level");

                entity.Property(e => e.Rating)
                    .HasPrecision(4, 3)
                    .HasColumnName("rating");

                entity.Property(e => e.SportName)
                    .HasMaxLength(40)
                    .HasColumnName("sport_name");

                entity.HasOne(d => d.SportNameNavigation)
                    .WithMany(p => p.Trainers)
                    .HasForeignKey(d => d.SportName)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("ref_sports");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
