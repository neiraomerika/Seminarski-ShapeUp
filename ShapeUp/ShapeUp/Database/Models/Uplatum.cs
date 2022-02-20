using System;
using System.Collections.Generic;

//#nullable disable

namespace ShapeUp.Database
{
    public partial class Uplatum
    {
        public Uplatum()
        {
            Mentorstvos = new HashSet<Mentorstvo>();
        }

        public int Id { get; set; }
        public DateTime? Datum { get; set; }
        public decimal Iznos { get; set; }
        public bool Placeno { get; set; } = false;
        public string ChargeId { get; set; }

        public virtual ICollection<Mentorstvo> Mentorstvos { get; set; }
    }
}
