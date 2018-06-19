using System;
using static System.Console;
using RoomReservationContracts;
using System.Data.Entity;

namespace RoomReservationData
{
    public class RoomReservationContext:DbContext
    {
        private const string ConnectionString = @"server=(localdb)\mssqllocaldb;Database=RoomReservations;trusted_connection=true";

        public RoomReservationContext():base()
        { }

        public DbSet<RoomReservation> RoomReservations { get; set; }
    }
}
