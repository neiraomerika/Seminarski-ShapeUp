using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeUp.Model.Models
{
    public class MTrening
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public bool? Slika { get; set; }
        public string VideoUrl { get; set; }
        public int? CiljId { get; set; }
        public int? KategorijaTreningaId { get; set; }

        public virtual MCilj Cilj { get; set; }
        public virtual MKategorijaTreninga KategorijaTreninga { get; set; }
    }
}
