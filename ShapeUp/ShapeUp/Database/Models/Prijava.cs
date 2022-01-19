using ShapeUp.Database.Models;
using System;
using System.Collections.Generic;

//#nullable disable

namespace ShapeUp.Database
{
    public partial class Prijava
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public string KlijentId { get; set; }

        public virtual Klijent Klijent { get; set; }
    }
}
