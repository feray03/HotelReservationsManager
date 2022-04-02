using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.Reservations
{
    public class ReservationCreateClientViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ReservationCreateClientViewModel(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
