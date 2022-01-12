using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeUp.Model.Models
{
    public class MTrening
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public byte[] Slika { get; set; }
        public string VideoUrl { get; set; }
        public int? CiljId { get; set; }
        public int? KategorijaTreningaId { get; set; }
    }
}
