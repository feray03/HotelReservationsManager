using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Room : BaseEntity
    {
        public Room() { }

        public Room (Room room)
        {
            this.Id = room.Id;
            this.Capacity = room.Capacity;
            this.RoomType = room.RoomType;
            this.IsFree = room.IsFree;
            this.PriceAdult = room.PriceForAdult;
            this.PriceChild = room.PriceChild;
            this.Number = room.Number;


        }
      [Range(1,5)] //може да има минимум 1 човек и максимум 5.
      [Required]
      public int Capacity { get; set; }
      [Required]
      public string Type { get; set; }
      [Required]
      public bool IsAvailable { get; set; }
      [Required]
      public double PriceForAdult { get; set; }
      [Required]
      public double PriceForKids { get; set; }
      [Required]
      public int Number { get; set; }
      [Required]



    }
}
