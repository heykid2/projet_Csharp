namespace BatailleNavale.DTO
{
    public class Joueur
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public MapAttaque MapAttaque { get; set; }

        public MapDefense MapDefense { get; set; }

        public Joueur()
        {
            MapAttaque = new MapAttaque();
            MapDefense = new MapDefense();
        }
    }
}