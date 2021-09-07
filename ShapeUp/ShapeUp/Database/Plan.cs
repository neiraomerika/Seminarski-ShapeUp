using System;
using System.Collections.Generic;

//#nullable disable

namespace ShapeUp.Database
{
    public partial class Plan
    {
        public int Id { get; set; }
        public DateTime? Datum { get; set; }
        public int? TreningId { get; set; }
        public int? PlanPrehraneId { get; set; }
        public int? MentorstvoId { get; set; }

        public virtual Mentorstvo Mentorstvo { get; set; }
        public virtual PlanPrehrane PlanPrehrane { get; set; }
        public virtual Trening Trening { get; set; }
    }
}
