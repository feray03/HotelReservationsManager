using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Entities
{
    public class Room : BaseEntity
    {
        public Room() 
        { 

        }

        public Room (Room room)
        {
            Id = room.Id;
            Capacity = room.Capacity;
            RoomType = room.RoomType;
            IsAvailable = room.IsAvailable;
            PriceForAdult = room.PriceForAdult;
            PriceForKids = room.PriceForKids;
            Number = room.Number;


        }
      [Range(1,5)] //може да има минимум 1 човек и максимум 5.
      [Required]
      public int Capacity { get; set; }

      [Required]
      public string RoomType { get; set; }

      [Required]
      public bool IsAvailable { get; set; }

      [Required]
      public double PriceForAdult { get; set; }

      [Required]
      public double PriceForKids { get; set; }

      [Required]
      public int Number { get; set; }
    }
}
