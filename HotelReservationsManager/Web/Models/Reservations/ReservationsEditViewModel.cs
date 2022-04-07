using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.Reservations
{
    public class ReservationsEditViewModel
    {
        public string Id { get; set; }
        public virtual Room Room { get; set; }
        public List<ReservationCreateRoomViewModel> RoomsAdded { get; set; }
        public string RoomId { get; set; }
        public virtual Data.Entities.User User { get; set; }

        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }
        public bool IncludedBreakfast { get; set; }
        public bool IsAllInclusive { get; set; }
        public decimal FinalPrice { get; set; }
    }
}
