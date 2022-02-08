using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeUp.Model.Models
{
    public class MPlan
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public int TreningId { get; set; }
        public virtual MTrening Trening { get; set; }
        public int PlanPrehraneId { get; set; }
        public virtual MPlanPrehrane PlanPrehrane { get; set; }
        public int MentorstvoId { get; set; }
        public virtual MMentorstvo Mentorstvo { get; set; }
        public string KlijentId { get; set; }
        public virtual MKlijent Klijent { get; set; }
    }
}
