using System;
using System.Collections.Generic;
using System.Text;
using RoomReservationContracts;
using System.Linq;

namespace RoomReservationData1
{
   public class RoomReservationRepository
    {
        public void RoomReservation(RoomReservation roomReservation)
        {
            using (var dbContext = new RoomReservationContext())
            {
                dbContext.RoomReservations.Add(roomReservation);
                dbContext.SaveChanges();
            }
        }

        public RoomReservation[] GetRoomReservations(DateTime fromTime, DateTime toTime)
        {
            using (var dbContext = new RoomReservationContext())
            {
                var list = from r in dbContext.RoomReservations
                           where r.StartTime > fromTime && r.EndTime < toTime
                           select r;
                return list.ToArray();

            }
        }
    }
}
