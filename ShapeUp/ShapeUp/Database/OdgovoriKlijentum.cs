using System;
using System.Collections.Generic;

//#nullable disable

namespace ShapeUp.Database
{
    public partial class OdgovoriKlijentum
    {
        public int? PitanjeId { get; set; }
        public string Odgovor { get; set; }

        public virtual Pitanja Pitanje { get; set; }
    }
}
