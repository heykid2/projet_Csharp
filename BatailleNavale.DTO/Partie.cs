
namespace BatailleNavale.DTO
{
    public class Partie
    {
        public Joueur Joueur1 { get; set; }
        public Joueur Joueur2 { get; set; }
        public Joueur JoueurCourant { get; set; }
        public Joueur JoueurAdverse { get; set; }
        public bool EstTerminee { get; set; }
        public Joueur Gagnant { get; set; }

        public Partie()
        {
            Joueur1 = new Joueur();
            Joueur2 = new Joueur();
            JoueurCourant = Joueur1;
            JoueurAdverse = Joueur2;
            EstTerminee = false;
        }
    }
}
