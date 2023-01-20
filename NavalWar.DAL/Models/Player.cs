using System.ComponentModel.DataAnnotations;

namespace NavalWar.DAL.Models
{
    public class Player
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Navigation property for foreign key
        /// </summary>
        public List<Session> Sessions { get; set; }
    }
}


//TODO: METTRE LES INFOS DE L'AUTRE CLASSE PLAYER ICI ET LA SUPPR