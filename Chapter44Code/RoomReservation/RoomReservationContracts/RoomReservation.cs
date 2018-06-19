using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace RoomReservationContracts
{
    [DataContract]
    public class RoomReservation : INotifyPropertyChanged
    {


        private int _id;

        [DataMember]
        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }//SetProperty 根据传递的第一个参数类型 推断数据类型
        }

        private string _roomName;

        [DataMember]
        [StringLength(30)]
        public string RoomName
        {
            get { return _roomName; }
            set { SetProperty(ref _roomName, value); }
        }

        private DateTime _startTime;
        [DataMember]
        public DateTime StartTime
        {
            get { return _startTime; }
            set { SetProperty<DateTime>(ref _startTime, value); }
        }

        private DateTime _endTime;
        [DataMember]
        public DateTime EndTime
        {
            get { return _endTime; }
            set { SetProperty(ref _endTime, value); }
        }

        private string _contact;
        [DataMember]
        [StringLength(30)]
        public string Contact
        {
            get { return _contact; }
            set { SetProperty(ref _contact, value); }
        }

        private string _text;
        [DataMember]
        [StringLength(50)]
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }


        #region 属性变化时触发事件
        protected virtual void SetProperty<T>(ref T item, T value, [CallerMemberName] string propertyName = null)
        {
            if (!EqualityComparer<T>.Default.Equals(item, value))
            {
                item = value;
                OnNotifyPropertyChanged(propertyName);
            }
        }

        protected virtual void OnNotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //等效于下边的写法
            //if (PropertyChanged!=null)
            //{
            //    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //}
        }

        //INotifyPropertyChanged 向客户端发出某一属性已更改的通知
        public event PropertyChangedEventHandler PropertyChanged;//定义一个属性变化的事件
        #endregion
    }
}
