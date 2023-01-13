
namespace BatailleNavale.DTO
{
    public class Map
    {
        public List<List<Case>> Cases { get; set; }

        public int Taille { get; set; }

        public Map()
        {
            Cases = new List<List<Case>>();
            Taille = 10;
            for (int i = 0; i < Taille; i++)
            {
                Cases.Add(new List<Case>());
                for (int j = 0; j < Taille; j++)
                {
                    Cases[i].Add(new Case { X = i, Y = j });
                }
            }
        }
    }
}
