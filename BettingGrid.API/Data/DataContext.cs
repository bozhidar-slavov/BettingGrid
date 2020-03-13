using System;
using BettingGrid.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BettingGrid.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().HasData(
                new
                {
                    Id = 1,
                    EventName = "Chelsea - Liverpool",
                    HomeSideOdds = 2.80m,
                    DrawOdds = 3.65m,
                    AwaySideOdds = 1.60m,
                    StartDate = DateTime.Today.AddDays(5)
                },
                new
                {
                    Id = 2,
                    EventName = "Wilder - Fury",
                    HomeSideOdds = 4.50m,
                    DrawOdds = 14.50m,
                    AwaySideOdds = 1.40m,
                    StartDate = DateTime.Today.AddDays(30)
                },
                new
                {
                    Id = 3,
                    EventName = "Inter - Ludogorets",
                    HomeSideOdds = 1.45m,
                    DrawOdds = 3.50m,
                    AwaySideOdds = 5.50m,
                    StartDate = DateTime.Today.AddDays(10)
                },
                new
                {
                    Id = 4,
                    EventName = "Barcelona - Real Madrid",
                    HomeSideOdds = 2.30m,
                    DrawOdds = 3.45m,
                    AwaySideOdds = 2.60m,
                    StartDate = DateTime.Today.AddDays(8)
                },
                new
                {
                    Id = 5,
                    EventName = "CSKA - Liverpool",
                    HomeSideOdds = 3.20m,
                    DrawOdds = 3.60m,
                    AwaySideOdds = 2.50m,
                    StartDate = DateTime.Today.AddYears(-38)
                });
        }

        public DbSet<Event> Events { get; set; }
    }
}