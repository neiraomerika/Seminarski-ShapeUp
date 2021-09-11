using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeUp.Model.Request
{
    public class TreningUpdateRequest
    {
        public string Opis { get; set; }
        public bool? Slika { get; set; }
        public string VideoUrl { get; set; }
        public int? CiljId { get; set; }
        public int? KategorijaTreningaId { get; set; }
    }
}
