using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.Reservations
{
    public class ReservationsViewModel
    {
        public string Id { get; set; }
        public string RoomNumber { get; set; }
        public string UserName { get; set; }
        public ICollection<ClientReservation> Clients { get; set; }

        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }
        public string IncludedBreakfast { get; set; }
        public string IsAllInclusive { get; set; }
        public decimal FinalPrice { get; set; }
    }
}
