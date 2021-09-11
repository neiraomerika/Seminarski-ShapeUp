using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeUp.Model.Request
{
    public class ProizvodiInsertRequest
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public decimal? ProsjecnaOcjena { get; set; }
        public byte[] Slika { get; set; }
        public decimal? Cijena { get; set; }
        public int? KategorijaProizvodaId { get; set; }
 
       
    }
}
