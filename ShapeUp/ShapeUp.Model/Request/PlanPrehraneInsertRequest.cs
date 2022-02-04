using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeUp.Model.Request
{
    public class PlanPrehraneInsertRequest
    {
        public string Opis { get; set; }
        public byte[] Slika { get; set; }
        public string NutritivneVrijednosti { get; set; }
        public int CiljId { get; set; }
    }
}
