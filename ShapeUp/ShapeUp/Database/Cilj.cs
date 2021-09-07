using System;
using System.Collections.Generic;

//#nullable disable

namespace ShapeUp.Database
{
    public partial class Cilj
    {
        public Cilj()
        {
            PlanPrehranes = new HashSet<PlanPrehrane>();
            Trenings = new HashSet<Trening>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<PlanPrehrane> PlanPrehranes { get; set; }
        public virtual ICollection<Trening> Trenings { get; set; }
    }
}
