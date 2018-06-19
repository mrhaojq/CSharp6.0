﻿using System;
using System.ServiceModel;

namespace RoomReservationContracts
{
    [ServiceContract(Namespace = "http://www.cninnovation.com/RoomReservation/2016")]
    public interface IRoomService
    {
        [OperationContract]
        [FaultContract(typeof(RoomReservationFault))]
        bool ReserveRoom(RoomReservation roomReservation);

        [OperationContract]
        [FaultContract(typeof(RoomReservationFault))]
        RoomReservation[] GetRoomReservations(DateTime fromDate, DateTime toDate);
    }
}
