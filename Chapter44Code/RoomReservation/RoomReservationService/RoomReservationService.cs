using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using RoomReservationContracts;
using RoomReservationData;


namespace RoomReservationService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]//调用前创建，调用后回收
    public class RoomReservationService : IRoomService
    {
        //在AspNetCore MVC 或 API 中可以使用依赖注入，将RoomReservationRepository 通过构造函数注入到服务中

        public bool ReserveRoom(RoomReservation roomReservation)
        {
            //在约束 类库中 定义数据结构 定义访问数据需要实现的方法
            //在数据 类库中 实现数据类与数据库之间的交互
            //在服务 类库中 实现与APP的交互 隔离数据类和数据访问
            var data = new RoomReservationRepository();
            data.RoomReservation(roomReservation);
            return true;
        }

        public RoomReservation[] GetRoomReservations(DateTime fromDate, DateTime toDate)
        {
            var data = new RoomReservationRepository();
            return data.GetRoomReservations(fromDate, toDate);
        }
    }
}
