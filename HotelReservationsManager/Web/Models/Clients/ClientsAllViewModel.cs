using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.Clients
{
    public class ClientsAllViewModel
    {
        public PagerViewModel Pager { get; set; }

        public ICollection<ClientsViewModel> Items { get; set; }
    }
}
