using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class SharedData
    {
        private static bool Admin;
        public static bool IsDbEmpty()
        {
            using (HotelDbContext context = new HotelDbContext()) { return !context.Users.Any(); }
        }

        public static bool IsAdmin()
        {
            return Admin;
        }

        public static void SetAdmin(string id)
        {
            using (HotelDbContext context = new HotelDbContext()) { Admin = context.Users.Find(id).IsAdmin; }
        }
    }
}
