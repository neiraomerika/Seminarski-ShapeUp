using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeUp.Model.Request
{
    public class RecenzijaUpdateRequest
    {
        public string Opis { get; set; }
        public int Ocjena { get; set; }
        public DateTime Datum { get; set; }
        public int MentorstvoId { get; set; }
    }
}
