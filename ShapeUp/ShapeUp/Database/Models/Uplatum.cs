﻿using System;
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
        public int? Iznos { get; set; }

        public virtual ICollection<Mentorstvo> Mentorstvos { get; set; }
    }
}