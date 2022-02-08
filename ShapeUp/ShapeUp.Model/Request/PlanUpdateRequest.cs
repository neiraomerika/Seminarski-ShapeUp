using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeUp.Model.Request
{
    public class PlanUpdateRequest
    {
        public DateTime Datum { get; set; }
        public int TreningId { get; set; }
        public int PlanPrehraneId { get; set; }
        public int MentorstvoId { get; set; }
        public string KlijentId { get; set; }
    }
}
