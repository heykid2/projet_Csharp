﻿namespace NavalWar.DTO
{
    public class ShipDTO
    {
        public int? ID { get; set; }
        public int PV { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Size { get; set; }
        public bool isVertical { get; set; }



        public ShipDTO(int? id, int pv, int x, int y, int size, bool isvertical)
        {
            ID = id;
            PV = pv;
            X = x;
            Y = y;
            Size = size;
            isVertical = isvertical;
        }
    }
}
