namespace NavalWar.DTO
{
    public class ShipDTO
    {
        public int? ShipId { get; set; }
        public int PV { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Size { get; set; }
        public bool IsVertical { get; set; }
        public string Name { get; set; }



        public ShipDTO(int? shipId, int pv, int x, int y, int size, bool isVertical, string name)
        {
            ShipId = shipId;
            PV = pv;
            X = x;
            Y = y;
            Size = size;
            IsVertical = isVertical;
            Name = name;
        }
    }
}
