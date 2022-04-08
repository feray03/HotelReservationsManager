using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models.Reservations;

namespace Web.Models.Clients
{
    public class ClientsDetailsViewModel
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public string IsAdult { get; set; }
        public ICollection<ReservationsViewModel> Reservations { get; set; }
    }
}
