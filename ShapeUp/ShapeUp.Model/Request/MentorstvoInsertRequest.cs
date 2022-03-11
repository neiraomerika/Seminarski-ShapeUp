using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeUp.Model.Request
{
    public class MentorstvoInsertRequest
    {
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }
        public string NazivKlijenta { get; set; }

        public DateTime DatumUplate { get; set; }
        public decimal Iznos { get; set; }
    }
}
