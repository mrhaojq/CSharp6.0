using RoomReservationContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservationData
{
  public  class RoomReservationRepository
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
