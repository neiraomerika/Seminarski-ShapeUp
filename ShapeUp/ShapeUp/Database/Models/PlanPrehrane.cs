using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

//#nullable disable

namespace ShapeUp.Database
{
    public partial class PlanPrehrane
    {
        public PlanPrehrane()
        {
            Plans = new HashSet<Plan>();
        }

        public int Id { get; set; }
        public string Opis { get; set; }
        public byte[] Slika { get; set; }
        public string NutritivneVrijednosti { get; set; }
        public int? CiljId { get; set; }

        public virtual Cilj Cilj { get; set; }
        public virtual ICollection<Plan> Plans { get; set; }
    }
}
