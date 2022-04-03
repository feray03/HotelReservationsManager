using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.Reservations
{
    public class ReservationsCreateViewModel
    {
        public virtual Room Room { get; set; }
        public virtual Data.Entities.User User { get; set; }
        public List<ReservationCreateClientViewModel> CreateClient { get; set; }
        public List<ReservationCreateRoomViewModel> RoomsAdded { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy")]
        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy")]
        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }
        public bool IncludedBreakfast { get; set; }
        public bool IsAllInclusive { get; set; }
    }
}
