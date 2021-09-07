using System;
using System.Collections.Generic;

//#nullable disable

namespace ShapeUp.Database
{
    public partial class Trening
    {
        public Trening()
        {
            Plans = new HashSet<Plan>();
        }

        public int Id { get; set; }
        public string Opis { get; set; }
        public bool? Slika { get; set; }
        public string VideoUrl { get; set; }
        public int? CiljId { get; set; }
        public int? KategorijaTreningaId { get; set; }

        public virtual Cilj Cilj { get; set; }
        public virtual KategorijaTreninga KategorijaTreninga { get; set; }
        public virtual ICollection<Plan> Plans { get; set; }
    }
}
