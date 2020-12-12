using System;
using System.Collections.Generic;
using System.Text;

namespace HousingEstate1
{
    class Flat
    {
     
        public int FlatNum { get; set; }
        public int Extent { get; set; }
        public int Rooms { get; set; }


        public Flat(int flatNum, int extent, int rooms)
        {
          
            FlatNum = flatNum;
            Extent = extent;
            Rooms = rooms;

        }
        public Flat()
        {
            FlatNum = -1;
            Extent = -1;
            Rooms = -1;
        }
        public override string ToString()
        {
            return $"\nFlat Number:{FlatNum}\nExtent:{Extent}\nNumber of rooms:{Rooms}";

        }
        
        
    }
}
