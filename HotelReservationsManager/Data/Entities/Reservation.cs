using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
     public class Reservation
    {
        public Reservation(Reservation reservation)
        {
            this.Id = resetrvation.Id;
            this.Room = new Room(reservation.Room);
            this.User = new User(reservation.User);
            this.CheckInDate = reservation.CheckInDate;
            this.IsAllInclusive = reservation.IsAllInclusive;
            this.FinalPrice = reservation.FinalPrice;
            this.ClientReservations = reservation.ClientReservations;
        }
        public Reservation()
        {
            ClientReservations = new HashSet<ClientReservarvation>();
        }
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public bool IncludedBreakfast { get; set; }
        public Double FinalPrice { get; set; }
    }
}
