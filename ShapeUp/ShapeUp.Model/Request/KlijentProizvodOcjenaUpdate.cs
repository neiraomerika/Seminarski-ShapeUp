using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeUp.Model.Request
{
    public class KlijentProizvodOcjenaUpdate
    {
        public string KlijentId { get; set; }
        public int ProizvodId { get; set; }
        public decimal Ocjena { get; set; }
    }
}
