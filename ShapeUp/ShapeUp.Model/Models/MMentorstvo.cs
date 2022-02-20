using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeUp.Model.Models
{
    public class MMentorstvo
    {
        public int Id { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }
        public int UplataId { get; set; }
        public virtual MUplata Uplata { get; set; }
        public string NazivKlijenta { get; set; }

    }
}
