using System.Runtime.Serialization;

namespace RoomReservationContracts
{
    [DataContract]
    public class RoomReservationFault
    {
        [DataMember]
        public string Message { get; set; }
    }
}
