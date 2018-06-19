using System;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace RoomReservationContracts
{
    [ServiceContract(Namespace = "http://www.cninnovation.com/RoomReservation/2016")]

    public interface IRoomService
    {
      
        [OperationContract]
        //[WebGet(BodyStyle = WebMessageBodyStyle.Wrapped)]
        [FaultContract(typeof(RoomReservationFault))]
        bool ReserveRoom(RoomReservation roomReservation);

        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Wrapped)]
        [FaultContract(typeof(RoomReservationFault))]
        RoomReservation[] GetRoomReservations(DateTime fromDate, DateTime toDate);
    }
}
