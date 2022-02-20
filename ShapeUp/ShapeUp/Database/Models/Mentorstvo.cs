using System;
using System.Collections.Generic;

//#nullable disable

namespace ShapeUp.Database
{
    public partial class Mentorstvo
    {
        public Mentorstvo()
        {
            Plans = new HashSet<Plan>();
            Recenzijas = new HashSet<Recenzija>();
        }

        public int Id { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }
        public int UplataId { get; set; }
        public string NazivKlijenta { get; set; }

        public virtual Uplatum Uplata { get; set; }
        public virtual ICollection<Plan> Plans { get; set; }
        public virtual ICollection<Recenzija> Recenzijas { get; set; }
    }
}
