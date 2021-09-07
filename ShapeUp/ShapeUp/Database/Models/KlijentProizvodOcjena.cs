using ShapeUp.Database.Models;
using System;
using System.Collections.Generic;

//#nullable disable

namespace ShapeUp.Database
{
    public partial class KlijentProizvodOcjena
    {
        public int Id { get; set; }
        public int? KlijentId { get; set; }
        public int? ProizvodId { get; set; }
        public decimal? Ocjena { get; set; }

        public virtual Proizvod Proizvod { get; set; }
        public virtual Klijent Klijent { get; set; }
    }
}
