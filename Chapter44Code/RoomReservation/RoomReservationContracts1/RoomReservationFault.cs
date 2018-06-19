using System.Runtime.Serialization;

namespace RoomReservationContracts1
{
    [DataContract]
    public class RoomReservationFault
    {
        [DataMember]
        public string Message { get; set; }
    }
}
