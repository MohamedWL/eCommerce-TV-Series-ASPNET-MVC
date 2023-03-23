using eSeries.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace eSeries.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //For the joint table explained in the ReadME
            modelBuilder.Entity<Actor_Serie>().HasKey(am => new
            {
                am.ActorId,
                am.SerieId
            });

            modelBuilder.Entity<Actor_Serie>().HasOne(m => m.Serie).WithMany(am=>am.Actors_Series).HasForeignKey(m=>m.SerieId);
            modelBuilder.Entity<Actor_Serie>().HasOne(m => m.Actor).WithMany(am => am.Actors_Series).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);//useful for auth and identifiers
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Actor_Serie> Actor_Series { get; set; }
        public DbSet<Streamer> Streamers { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
