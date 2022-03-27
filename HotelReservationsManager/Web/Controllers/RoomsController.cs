using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{   
    [Autorize]
    public class RoomsController : Controller
    {
        private readonly HotelDbContext _context;

        public RoomsController(HotelDbContekst)
        {
            _context = context;
            // GET Rooms

            public async Task< IActionResult >Index (string currentFilter, string searchString , int ? pageNumber)
            {
                if (searchString! = null)
                    pageNumber = 1;
                else
                    searchString = currentFilter;
                ViewData["CurrentFilter"] = searchString;
                var rooms = from u in _context.Rooms
                            select u;
                if (!String.IsNullOrEmty(searchString))
                {
                    rooms = rooms.Where(u => u.Capacity.ToString().Contains(searchString)
                         || nameof(u.Type).Contains(searchString));
                }
                int pageSize = 5;

                return View(await PaginatedList<Room>.CreateAsync(rooms.AsNoTraccking(), pageNumber ?? 1, pageSize));
            }
                // GET: Rooms/Details/5
            
            public async Task<IActionResult> Details (int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }
                var room = await _context.Rooms
                   .FirstOrDefaultAsync(m => m.Id == id);
                if (room == null)
                {
                    return NotFound();
                }
                return View(room);
            }
            [Authorize(Roles = "Admin")]

            //GET Rooms/Create
            public IActionResult
            }
        }
    }
}
