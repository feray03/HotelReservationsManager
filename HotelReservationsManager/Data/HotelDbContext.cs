using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data
{
    public class HotelDbContext : IdentityDbContext<User,IdentityRole,string>
    {
      public HotelDbContext()
      {

      }

      public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
      {

      }

        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server= DESKTOP-IVQQUDH\SQLEXPRESS;Database=HotelDb;Integrated Security = true");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
