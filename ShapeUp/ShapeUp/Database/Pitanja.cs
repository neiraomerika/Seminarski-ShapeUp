using System;
using System.Collections.Generic;

//#nullable disable

namespace ShapeUp.Database
{
    public partial class Pitanja
    {
        public int Id { get; set; }
        public string Pitanje { get; set; }
        public int? FormularId { get; set; }

        public virtual Formular Formular { get; set; }
    }
}
