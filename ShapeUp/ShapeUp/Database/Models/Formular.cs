using System;
using System.Collections.Generic;

//#nullable disable

namespace ShapeUp.Database
{
    public partial class Formular
    {
        public Formular()
        {
            Pitanjas = new HashSet<Pitanja>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Pitanja> Pitanjas { get; set; }
    }
}
