using NavalWar.DTO.WebDTO;

namespace NavalWar.DAL.Models
{
    public class Session
    {
        public int ID { get; set; }

        public SessionDTO ToDto()
        {
            return new SessionDTO();
        }
    }
}
