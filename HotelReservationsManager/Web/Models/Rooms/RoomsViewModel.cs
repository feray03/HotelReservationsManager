using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.Rooms
{
    public class RoomsViewModel
    {
        public string Id { get; set; }
        public string number { get; set; }
        public int Capasity { get; set; }
        public string type { get; set; }
        public string IsFree { get; set; }
        public decimal PriceForAdult { get; set; }
        public decimal PriceForKid { get; set; }
    }
}
