using System;
using System.Collections.Generic;


namespace ShapeUp.Database
{
    public partial class Proizvod
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public decimal? ProsjecnaOcjena { get; set; }
        public byte[] Slika { get; set; }
        public decimal? Cijena { get; set; }
        public int? KategorijaProizvodaId { get; set; }

        public virtual KategorijaProizvodum KategorijaProizvoda { get; set; }
    }
}
