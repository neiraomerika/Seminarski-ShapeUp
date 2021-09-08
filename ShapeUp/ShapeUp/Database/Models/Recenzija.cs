using System;
using System.Collections.Generic;

//#nullable disable

namespace ShapeUp.Database
{
    public partial class Recenzija
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public int? Ocjena { get; set; }
        public DateTime? Datum { get; set; }
        public int? MentorstvoId { get; set; }

        public virtual Mentorstvo Mentorstvo { get; set; }
    }
}
