using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.Reservations
{
    public class RequestReservationCreateViewModel
    {
        public virtual Room Room { get; set; }
        public virtual Data.Entities.User User { get; set; }
        public List<string> ClientsId { get; set; }
        public string RoomId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }

        public bool IncludedBreakfast { get; set; }
        public bool IsAllInclusive { get; set; }
        public decimal FinalPrice { get; set; }
    }
}
