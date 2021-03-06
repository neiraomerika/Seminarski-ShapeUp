using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeUp.Model.Request
{
    public class NapredakInsertRequest
    {
        public int? Tezina { get; set; }
        public int? ObimDesneRuke { get; set; }
        public int? ObimLijeveRuke { get; set; }
        public int? ObimStruka { get; set; }
        public int? ObimKukova { get; set; }
        public int? ObimDesneNoge { get; set; }
        public int? ObimLijeveNoge { get; set; }
        public string KlijentId { get; set; }
        public DateTime Datum { get; set; }
    }
}
