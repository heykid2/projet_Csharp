
namespace BatailleNavale.DTO
{
    public enum Direction
    {
        Haut,
        Bas,
        Gauche,
        Droite
    }

    public class MapDefense : Map
    {
        public List<Navire> Navires { get; set; }

        public MapDefense()
        {
            Navires = new List<Navire>();
        }

        public void AjouterNavire(Navire navire, int xDepart, int yDepart, Direction direction)
        {
            Navires.Add(navire);

            // Verifier que toutes les cases sont libres avant de placer le navire
            try
            {
                NavirePeutEtrePlace(this, navire, xDepart, yDepart, direction);
            }
            catch (Exception)
            {
                throw;
            }

            // Placer le navire sur la map
            for (int i = 0; i < navire.Taille; i++)
            {
                Cases[xDepart][yDepart].EstOccupee = true;
                Cases[xDepart][yDepart].Navire = navire;

                switch (direction)
                {
                    case Direction.Haut:
                        xDepart--;
                        break;
                    case Direction.Bas:
                        xDepart++;
                        break;
                    case Direction.Gauche:
                        yDepart--;
                        break;
                    case Direction.Droite:
                        yDepart++;
                        break;
                }
            }

        }

        private static void NavirePeutEtrePlace(Map map, Navire navire, int xDepart, int yDepart, Direction direction)
        {
            for (int i = 0; i < navire.Taille; i++)
            {
                switch(direction)
                {
                    case Direction.Haut:
                        if (map.Cases[xDepart][yDepart - i].EstOccupee || yDepart - i < 0)
                        {
                            throw new Exception("Case occupée");
                        }
                        break;
                    case Direction.Bas:
                        if (map.Cases[xDepart][yDepart + i].EstOccupee || yDepart + i > map.Taille)
                        {
                            throw new Exception("Case occupée");
                        }
                        break;
                    case Direction.Gauche:
                        if (map.Cases[xDepart - i][yDepart].EstOccupee || xDepart - i < 0)
                        {
                            throw new Exception("Case occupée");
                        }
                        break;
                    case Direction.Droite:
                        if (map.Cases[xDepart + i][yDepart].EstOccupee || xDepart + i > map.Taille)
                        {
                            throw new Exception("Case occupée");
                        }
                        break;
                }
            }
        }
    }
}
