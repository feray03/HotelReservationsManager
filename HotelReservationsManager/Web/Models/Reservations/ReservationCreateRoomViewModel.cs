using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.Reservations
{
    public class ReservationCreateRoomViewModel
    {
        public string Id { get; set; }
        public string number { get; set; }
        public RoomTypeEnum RoomType { get; set; }
        public decimal PriceForAdult { get; set; }
        public decimal PriceForKids { get; set; }
        public bool IsAvailable { get; set; }

        public ReservationCreateRoomViewModel(string id, string num, RoomTypeEnum roomType, decimal priceForAdult, decimal priceForKids, bool isAvailable)
        {
            this.Id = id;
            this.number = num;
            this.RoomType = roomType;
            this.PriceForAdult = priceForAdult;
            this.PriceForKids = priceForKids;
        }
    }
}
