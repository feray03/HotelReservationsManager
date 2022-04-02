using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Data.Entities
{
    public enum RoomTypeEnum
    {
        [Description("Two Single Beds")]
        TwoBeds,
        Apartament,
        [Description("Double Bed Room")]
        DubleBad,
        Penthouse,
        Maisonette
    }
}
