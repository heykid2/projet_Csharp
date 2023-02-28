namespace NavalWar.DTO
{
    public class ShotDTO
    {
        public int? ID { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public bool Hit { get; set; }

        public ShotDTO(int? id, int x, int y, bool hit)
        {
            ID = id;
            X = x;
            Y = y;
            Hit = hit;
        }
    }
}
