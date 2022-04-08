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
      
      public int Capacity { get; set; }

      public string RoomType { get; set; }

      public bool IsAvailable { get; set; }

      public double PriceForAdult { get; set; }

      public double PriceForKids { get; set; }

      public int Number { get; set; }
    }
}
