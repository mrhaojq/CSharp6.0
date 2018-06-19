using System;
using static System.Console;
using RoomReservationContracts;
using Microsoft.EntityFrameworkCore;

namespace RoomReservationData
{
    public class RoomReservationContext:DbContext
    {
        private const string ConnectionString = @"server=(localdb)\mssqllocaldb;Database=RoomReservations;trusted_connection=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<RoomReservation> RoomReservations { get; set; }
    }
}
