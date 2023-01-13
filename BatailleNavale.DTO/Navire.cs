using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale.DTO
{
    public class Navire
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Taille { get; set; }
        public bool EstCoule { get; set; }
    }
}
