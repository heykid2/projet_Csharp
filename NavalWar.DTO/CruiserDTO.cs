namespace NavalWar.DTO
{
    public class CruiserDTO : ShipDTO
    {
        public CruiserDTO(int? id, int pv, int x, int y, int size, bool isVertical) : base(id, pv, x, y, size, isVertical)
        {
        }
    }
}
