using Gym.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Core.Context
{
    public class GymDbContext : DbContext
    {

        public GymDbContext(DbContextOptions<GymDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Receptionist> Receptionists { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=GymFinalDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<Client>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Client>()
                .HasOne(c => c.Coach)
                .WithMany()
                .HasForeignKey(c => c.CoachId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Client>()
                .HasOne(c => c.Membership)
                .WithMany()
                .HasForeignKey(c => c.MembershipId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Coach>()
                .HasKey(coach => coach.Id);

            modelBuilder.Entity<Receptionist>()
                .HasKey(r => r.Id);

            modelBuilder.Entity<Membership>()
                .HasKey(m => m.Id);

            modelBuilder.Entity<Payment>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Member)
                .WithMany()
                .HasForeignKey(p => p.MemberId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
