using System;
using System.Collections.Generic;

//#nullable disable

namespace ShapeUp.Database
{
    public partial class Napredak
    {
        public int Id { get; set; }
        public int? Tezina { get; set; }
        public int? ObimDesneRuke { get; set; }
        public int? ObimLijeveRuke { get; set; }
        public int? ObimStruka { get; set; }
        public int? ObimKukova { get; set; }
        public int? ObimDesneNoge { get; set; }
        public int? ObimLijeveNoge { get; set; }
    }
}
