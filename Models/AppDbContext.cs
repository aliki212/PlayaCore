using Microsoft.AspNetCore.Routing.Matching;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayaCore.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Playa> Playas { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Position> Positions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Position>().HasData(new Position { Id = 1, Name = "GoalKeeper", Description = "He keeps the gates safe..." });
            modelBuilder.Entity<Position>().HasData(new Position { Id = 2, Name = "Defender", Description = "He defends until they drop..." });
            modelBuilder.Entity<Position>().HasData(new Position { Id = 3, Name = "Midfielder", Description = "He stays in the middle..." });
            modelBuilder.Entity<Position>().HasData(new Position { Id = 4, Name = "Forward", Description = "He attacks with full wrath..." });

            modelBuilder.Entity<Team>().HasData(new Position { Id = 1, Name = "Juventus" });

            modelBuilder.Entity<Playa>().HasData(new Playa
            {
                Id = 1,
                LastName = "Buffon",
                FirstName = "Gianluigi",
                IsNotInjured = true,
                ImageUrl = "https://s.hs-data.com/bilder/spieler/gross/1337.jpg",
                TeamId = 1,
                PositionId = 1
            });


        }
    }
}
