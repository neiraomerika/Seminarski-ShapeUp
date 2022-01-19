using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeUp.Model.Models
{
    public class MPlanPrehrane
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public byte[] Slika { get; set; }
        public string NutritivneVrijednosti { get; set; }
        public int? CiljId { get; set; }
    }
}
