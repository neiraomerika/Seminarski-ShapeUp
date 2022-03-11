using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeUp.Model.Models
{
    public class MKlijentProizvodOcjena
    {
        public string KlijentId { get; set; }
        public int ProizvodId { get; set; }
        public decimal Ocjena { get; set; }

        public virtual MProizvodi Proizvod { get; set; }
        public virtual MKlijent Klijent { get; set; }
    }
}
