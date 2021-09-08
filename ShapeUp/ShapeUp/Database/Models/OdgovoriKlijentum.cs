using ShapeUp.Database.Models;
using System;
using System.Collections.Generic;

//#nullable disable

namespace ShapeUp.Database
{
    public partial class OdgovoriKlijentum
    {
        public int Id { get; set; }
        public int KlijentId { get; set; }
        public int? PitanjeId { get; set; }
        public string Odgovor { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual Pitanja Pitanje { get; set; }
    }
}
