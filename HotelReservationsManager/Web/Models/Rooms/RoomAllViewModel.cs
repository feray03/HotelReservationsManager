using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.Rooms
{
    public class RoomAllViewModel
    {
        public PagerViewModel Pager { get; set; }

        public ICollection<RoomsViewModel>Items { get; set; }
    }
}
