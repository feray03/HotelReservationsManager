using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
     public class Reservation : BaseEntity
    {
        public Reservation(Reservation reservation)
        {
            Id = reservation.Id;
            Room = new Room(reservation.Room);
            User = new User(reservation.User);
            CheckInDate = reservation.CheckInDate;
            IsAllInclusive = reservation.IsAllInclusive;
            FinalPrice = reservation.FinalPrice;
            ClientReservations = reservation.ClientReservations;
        }
        public Reservation()
        {
            ClientReservations = new HashSet<ClientReservation>();
        }
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public bool IncludedBreakfast { get; set; }
        public bool IsAllInclusive { get; set; }
        public double FinalPrice { get; set; }
        public ICollection<ClientReservation> ClientReservations { get; set; }
    }
}
